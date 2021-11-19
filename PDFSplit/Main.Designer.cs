
namespace PDFSplit
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOpen = new System.Windows.Forms.Button();
            this.TbInputFile = new System.Windows.Forms.TextBox();
            this.TbOutputPrefix = new System.Windows.Forms.TextBox();
            this.BtnSplit = new System.Windows.Forms.Button();
            this.LblInput = new System.Windows.Forms.Label();
            this.LblOutputPrefix = new System.Windows.Forms.Label();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.PbSplitProgress = new System.Windows.Forms.ProgressBar();
            this.LblNoPages = new System.Windows.Forms.Label();
            this.TbNoPages = new System.Windows.Forms.TextBox();
            this.TbOutputDir = new System.Windows.Forms.TextBox();
            this.LblOutputDir = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.DgvOutputDirListing = new System.Windows.Forms.DataGridView();
            this.LblOutputDirListing = new System.Windows.Forms.Label();
            this.LblWelcomeMsg = new System.Windows.Forms.Label();
            this.BtnAbout = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOutputDirListing)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(304, 37);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(75, 23);
            this.BtnOpen.TabIndex = 1;
            this.BtnOpen.Text = "Select";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // TbInputFile
            // 
            this.TbInputFile.Location = new System.Drawing.Point(148, 37);
            this.TbInputFile.Name = "TbInputFile";
            this.TbInputFile.ReadOnly = true;
            this.TbInputFile.Size = new System.Drawing.Size(150, 23);
            this.TbInputFile.TabIndex = 2;
            this.TbInputFile.TextChanged += new System.EventHandler(this.TbOpen_TextChanged);
            // 
            // TbOutputPrefix
            // 
            this.TbOutputPrefix.Location = new System.Drawing.Point(148, 95);
            this.TbOutputPrefix.Name = "TbOutputPrefix";
            this.TbOutputPrefix.Size = new System.Drawing.Size(150, 23);
            this.TbOutputPrefix.TabIndex = 3;
            // 
            // BtnSplit
            // 
            this.BtnSplit.Location = new System.Drawing.Point(12, 483);
            this.BtnSplit.Name = "BtnSplit";
            this.BtnSplit.Size = new System.Drawing.Size(150, 23);
            this.BtnSplit.TabIndex = 5;
            this.BtnSplit.Text = "Split";
            this.BtnSplit.UseVisualStyleBackColor = true;
            this.BtnSplit.Click += new System.EventHandler(this.BtnSplit_Click);
            // 
            // LblInput
            // 
            this.LblInput.AutoSize = true;
            this.LblInput.Location = new System.Drawing.Point(12, 41);
            this.LblInput.Name = "LblInput";
            this.LblInput.Size = new System.Drawing.Size(57, 15);
            this.LblInput.TabIndex = 6;
            this.LblInput.Text = "Input file:";
            // 
            // LblOutputPrefix
            // 
            this.LblOutputPrefix.AutoSize = true;
            this.LblOutputPrefix.Location = new System.Drawing.Point(12, 98);
            this.LblOutputPrefix.Name = "LblOutputPrefix";
            this.LblOutputPrefix.Size = new System.Drawing.Size(133, 15);
            this.LblOutputPrefix.TabIndex = 7;
            this.LblOutputPrefix.Text = "Output file name prefix:";
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(379, 483);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(150, 23);
            this.BtnQuit.TabIndex = 8;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // PbSplitProgress
            // 
            this.PbSplitProgress.Location = new System.Drawing.Point(12, 512);
            this.PbSplitProgress.Name = "PbSplitProgress";
            this.PbSplitProgress.Size = new System.Drawing.Size(517, 23);
            this.PbSplitProgress.TabIndex = 9;
            // 
            // LblNoPages
            // 
            this.LblNoPages.AutoSize = true;
            this.LblNoPages.Location = new System.Drawing.Point(401, 41);
            this.LblNoPages.Name = "LblNoPages";
            this.LblNoPages.Size = new System.Drawing.Size(77, 15);
            this.LblNoPages.TabIndex = 10;
            this.LblNoPages.Text = "No. of pages:";
            // 
            // TbNoPages
            // 
            this.TbNoPages.Location = new System.Drawing.Point(479, 38);
            this.TbNoPages.Name = "TbNoPages";
            this.TbNoPages.ReadOnly = true;
            this.TbNoPages.Size = new System.Drawing.Size(50, 23);
            this.TbNoPages.TabIndex = 11;
            // 
            // TbOutputDir
            // 
            this.TbOutputDir.Location = new System.Drawing.Point(148, 66);
            this.TbOutputDir.Name = "TbOutputDir";
            this.TbOutputDir.ReadOnly = true;
            this.TbOutputDir.Size = new System.Drawing.Size(150, 23);
            this.TbOutputDir.TabIndex = 12;
            // 
            // LblOutputDir
            // 
            this.LblOutputDir.AutoSize = true;
            this.LblOutputDir.Location = new System.Drawing.Point(12, 69);
            this.LblOutputDir.Name = "LblOutputDir";
            this.LblOutputDir.Size = new System.Drawing.Size(98, 15);
            this.LblOutputDir.TabIndex = 13;
            this.LblOutputDir.Text = "Output directory:";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(304, 65);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 14;
            this.BtnSave.Text = "Select";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // DgvOutputDirListing
            // 
            this.DgvOutputDirListing.AllowUserToAddRows = false;
            this.DgvOutputDirListing.AllowUserToDeleteRows = false;
            this.DgvOutputDirListing.AllowUserToResizeRows = false;
            this.DgvOutputDirListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOutputDirListing.Location = new System.Drawing.Point(12, 157);
            this.DgvOutputDirListing.Name = "DgvOutputDirListing";
            this.DgvOutputDirListing.ReadOnly = true;
            this.DgvOutputDirListing.RowTemplate.Height = 25;
            this.DgvOutputDirListing.Size = new System.Drawing.Size(517, 320);
            this.DgvOutputDirListing.TabIndex = 15;
            this.DgvOutputDirListing.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOutputDirListing_CellDoubleClick);
            // 
            // LblOutputDirListing
            // 
            this.LblOutputDirListing.AutoSize = true;
            this.LblOutputDirListing.Location = new System.Drawing.Point(12, 139);
            this.LblOutputDirListing.Name = "LblOutputDirListing";
            this.LblOutputDirListing.Size = new System.Drawing.Size(0, 15);
            this.LblOutputDirListing.TabIndex = 16;
            // 
            // LblWelcomeMsg
            // 
            this.LblWelcomeMsg.AutoSize = true;
            this.LblWelcomeMsg.Location = new System.Drawing.Point(373, 9);
            this.LblWelcomeMsg.Name = "LblWelcomeMsg";
            this.LblWelcomeMsg.Size = new System.Drawing.Size(75, 15);
            this.LblWelcomeMsg.TabIndex = 18;
            this.LblWelcomeMsg.Text = "PDFSplit v1.0";
            // 
            // BtnAbout
            // 
            this.BtnAbout.Location = new System.Drawing.Point(454, 5);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(75, 23);
            this.BtnAbout.TabIndex = 19;
            this.BtnAbout.Text = "About";
            this.BtnAbout.UseVisualStyleBackColor = true;
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Enabled = false;
            this.BtnRefresh.Location = new System.Drawing.Point(454, 131);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 20;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 547);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.LblWelcomeMsg);
            this.Controls.Add(this.LblOutputDirListing);
            this.Controls.Add(this.DgvOutputDirListing);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblOutputDir);
            this.Controls.Add(this.TbOutputDir);
            this.Controls.Add(this.TbNoPages);
            this.Controls.Add(this.LblNoPages);
            this.Controls.Add(this.PbSplitProgress);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.LblOutputPrefix);
            this.Controls.Add(this.LblInput);
            this.Controls.Add(this.BtnSplit);
            this.Controls.Add(this.TbOutputPrefix);
            this.Controls.Add(this.TbInputFile);
            this.Controls.Add(this.BtnOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "PDFSplit";
            ((System.ComponentModel.ISupportInitialize)(this.DgvOutputDirListing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.TextBox TbInputFile;
        private System.Windows.Forms.TextBox TbOutputPrefix;
        private System.Windows.Forms.Button BtnSplit;
        private System.Windows.Forms.Label LblInput;
        private System.Windows.Forms.Label LblOutputPrefix;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.ProgressBar PbSplitProgress;
        private System.Windows.Forms.Label LblNoPages;
        private System.Windows.Forms.TextBox TbNoPages;
        private System.Windows.Forms.TextBox TbOutputDir;
        private System.Windows.Forms.Label LblOutputDir;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridView DgvOutputDirListing;
        private System.Windows.Forms.Label LblOutputDirListing;
        private System.Windows.Forms.Label LblWelcomeMsg;
        private System.Windows.Forms.Button BtnAbout;
        private System.Windows.Forms.Button BtnRefresh;
    }
}

