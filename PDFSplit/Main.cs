using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using iText.Kernel.Pdf;

namespace PDFSplit
{
    public partial class Main : Form
    {
        private PdfReader sourcePdfReader;
        private PdfDocument sourcePdfDocument;
        private int sourcePdfNoPages;
        private DataTable outputDirListing;

        public Main()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = ".pdf files (*.pdf)|*.pdf|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                TbInputFile.Text = openFileDialog.FileName;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                TbOutputDir.Text = folderBrowserDialog.SelectedPath;
                LblOutputDirListing.Text = folderBrowserDialog.SelectedPath;
                outputDirListing = CreateDirListing(folderBrowserDialog.SelectedPath);
                DgvOutputDirListing.DataSource = outputDirListing;
                BtnRefresh.Enabled = true;
            }
        }

        private void TbOpen_TextChanged(object sender, EventArgs e)
        {
            if (TbInputFile.Text.EndsWith(".pdf"))
            {
                try
                {
                    //Fill in the no of pages field.
                    sourcePdfReader = new PdfReader(TbInputFile.Text);
                    sourcePdfDocument = new PdfDocument(sourcePdfReader);
                    sourcePdfNoPages = sourcePdfDocument.GetNumberOfPages();
                    TbNoPages.Text = sourcePdfNoPages.ToString();
                }

                catch(Exception ex)
                {
                    MessageBox.Show($"An exception occurred when trying to get number of pages. Exception: {ex}", "An exception occurred.");
                }
            }
        }

        private void BtnSplit_Click(object sender, EventArgs e)
        {
            //Check to make sure that we have all of the data that we need.
            if (string.IsNullOrWhiteSpace(TbInputFile.Text))
            {
                MessageBox.Show("You need to specify an input file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(TbOutputDir.Text))
            {
                MessageBox.Show("You need to specify an output directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(TbOutputPrefix.Text))
            {
                MessageBox.Show("You need to specify an output file name prefix.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                //Go through each page and create a pdf.
                for (int i = 0; i < sourcePdfDocument.GetNumberOfPages(); i++)
                {
                    PdfWriter pdfWriter = new PdfWriter($"{TbOutputDir.Text}/{TbOutputPrefix.Text}-{i + 1}.pdf");
                    PdfDocument pdfDocument = new PdfDocument(pdfWriter);
                    sourcePdfDocument.CopyPagesTo(i + 1, i + 1, pdfDocument);
                    pdfDocument.Close();
                    pdfWriter.Close();
                    PbSplitProgress.Increment((i + 1) / sourcePdfNoPages * 100);
                }

                if (PbSplitProgress.Value == PbSplitProgress.Maximum)
                {
                    MessageBox.Show($"Split {TbInputFile.Text} into {sourcePdfNoPages} pdf files!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PbSplitProgress.Value = PbSplitProgress.Minimum;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred when trying to split PDF. Exception: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Refresh file listing
            outputDirListing = CreateDirListing(TbOutputDir.Text);
            DgvOutputDirListing.DataSource = outputDirListing;
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private static DataTable CreateDirListing(string folderPath)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("File name");
            dt.Columns.Add("Size");
            dt.Columns.Add("Last modified");

            dt.Columns["Size"].DataType = typeof(int);
            dt.Columns["Last modified"].DataType = typeof(DateTime);

            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            DataRow dataRow;

            //Go through every file and add.
            foreach (FileInfo fileInfo in directoryInfo.GetFiles("*", SearchOption.TopDirectoryOnly))
            {
                dataRow = dt.NewRow();
                dataRow["File name"] = fileInfo.Name;
                dataRow["Size"] = fileInfo.Length;
                dataRow["Last modified"] = fileInfo.LastWriteTime;
                dt.Rows.Add(dataRow);
            }
            return dt;
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            About aboutWindow = new About
            {
                Owner = this,
                StartPosition = FormStartPosition.CenterParent
            };
            aboutWindow.ShowDialog();
        }

        private void DgvOutputDirListing_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FileOption fileOption = new FileOption(TbOutputDir.Text, DgvOutputDirListing.Rows[e.RowIndex].Cells[0].Value.ToString())
            {
                Owner = this,
                StartPosition = FormStartPosition.CenterParent
            };
            fileOption.ShowDialog();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            outputDirListing = CreateDirListing(TbOutputDir.Text);
            DgvOutputDirListing.DataSource = outputDirListing;
        }
    }
}
