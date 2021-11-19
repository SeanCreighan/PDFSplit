
namespace PDFSplit
{
    partial class Rename
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TbNewFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TbNewFileName
            // 
            this.TbNewFileName.Location = new System.Drawing.Point(12, 27);
            this.TbNewFileName.Name = "TbNewFileName";
            this.TbNewFileName.Size = new System.Drawing.Size(300, 23);
            this.TbNewFileName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a new file name.";
            // 
            // BtnRename
            // 
            this.BtnRename.Location = new System.Drawing.Point(318, 27);
            this.BtnRename.Name = "BtnRename";
            this.BtnRename.Size = new System.Drawing.Size(75, 23);
            this.BtnRename.TabIndex = 2;
            this.BtnRename.Text = "Rename";
            this.BtnRename.UseVisualStyleBackColor = true;
            this.BtnRename.Click += new System.EventHandler(this.BtnRename_Click);
            // 
            // Rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 59);
            this.Controls.Add(this.BtnRename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbNewFileName);
            this.Name = "Rename";
            this.Text = "PDFSplit - Rename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbNewFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRename;
    }
}