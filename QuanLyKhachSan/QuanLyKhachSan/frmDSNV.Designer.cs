namespace QuanLyKhachSan
{
    partial class frmDSNV
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
            this.rpvDSNV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvDSNV
            // 
            this.rpvDSNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvDSNV.Location = new System.Drawing.Point(0, 0);
            this.rpvDSNV.Name = "rpvDSNV";
            this.rpvDSNV.Size = new System.Drawing.Size(758, 457);
            this.rpvDSNV.TabIndex = 0;
            // 
            // frmDSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 457);
            this.Controls.Add(this.rpvDSNV);
            this.Name = "frmDSNV";
            this.Text = "Danh sách nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDSNV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDSNV;
    }
}