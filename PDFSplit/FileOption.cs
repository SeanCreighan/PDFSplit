using System;
using System.Windows.Forms;
using System.IO;

namespace PDFSplit
{
    public partial class FileOption : Form
    {
        private readonly string folderPath;
        private readonly string fileName;
        public FileOption(string folderpath, string filename)
        {
            folderPath = folderpath;
            fileName = filename;
            InitializeComponent();
        }

        private void BtnRename_Click(object sender, EventArgs e)
        {
            Rename rename = new Rename(folderPath, fileName)
            {
                Owner = this,
                StartPosition = FormStartPosition.CenterParent
            };
            rename.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult deleteResult = MessageBox.Show($"Delete {fileName}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteResult == DialogResult.Yes)
            {
                try
                {
                    File.Delete($"{folderPath}/{fileName}");
                    MessageBox.Show($"Deleted {fileName}.");
                }

                catch
                {
                    MessageBox.Show($"Cannot delete. The file may not exist or you may not have permission to delete the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Close();
        }
    }
}
