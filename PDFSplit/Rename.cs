using System;
using System.IO;
using System.Windows.Forms;

namespace PDFSplit
{
    public partial class Rename : Form
    {
        private readonly string folderPath;
        private readonly string fileName;
        public Rename(string folderpath, string filename)
        {
            folderPath = folderpath;
            fileName = filename;
            InitializeComponent();
            TbNewFileName.Text = fileName;
        }

        private void BtnRename_Click(object sender, EventArgs e)
        {
            try
            {
                File.Move($"{folderPath}/{fileName}", $"{folderPath}/{TbNewFileName.Text}");
                MessageBox.Show($"Renamed {fileName} to {TbNewFileName.Text}.");
            }

            catch
            {
                MessageBox.Show($"An error occurred when trying to rename {folderPath}/{fileName}. The file may not exist or you may not have permission to rename this file.");
            }

            Close();
        }
    }
}
