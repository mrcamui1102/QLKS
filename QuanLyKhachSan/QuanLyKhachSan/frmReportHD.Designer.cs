namespace QuanLyKhachSan
{
    partial class frmReportHD
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
            this.rpvHoadon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvHoadon
            // 
            this.rpvHoadon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvHoadon.Location = new System.Drawing.Point(0, 0);
            this.rpvHoadon.Name = "rpvHoadon";
            this.rpvHoadon.Size = new System.Drawing.Size(849, 461);
            this.rpvHoadon.TabIndex = 0;
            this.rpvHoadon.Load += new System.EventHandler(this.rpvHoadon_Load);
            // 
            // frmReportHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 461);
            this.Controls.Add(this.rpvHoadon);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(865, 500);
            this.MinimumSize = new System.Drawing.Size(865, 500);
            this.Name = "frmReportHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.frmReportHD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvHoadon;
    }
}