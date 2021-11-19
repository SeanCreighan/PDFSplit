using System;
using System.Windows.Forms;

namespace PDFSplit
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
