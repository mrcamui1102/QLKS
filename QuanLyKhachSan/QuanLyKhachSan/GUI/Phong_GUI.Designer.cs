namespace QuanLyKhachSan.GUI
{
    partial class Phong_GUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.Superio = new System.Windows.Forms.RadioButton();
            this.Suite = new System.Windows.Forms.RadioButton();
            this.Deluxe = new System.Windows.Forms.RadioButton();
            this.Standard = new System.Windows.Forms.RadioButton();
            this.txtsl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabPhong = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.Superio);
            this.panelControl1.Controls.Add(this.Suite);
            this.panelControl1.Controls.Add(this.Deluxe);
            this.panelControl1.Controls.Add(this.Standard);
            this.panelControl1.Controls.Add(this.txtsl);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 7);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(773, 51);
            this.panelControl1.TabIndex = 0;
            // 
            // Superio
            // 
            this.Superio.AutoSize = true;
            this.Superio.Location = new System.Drawing.Point(427, 15);
            this.Superio.Name = "Superio";
            this.Superio.Size = new System.Drawing.Size(61, 17);
            this.Superio.TabIndex = 6;
            this.Superio.TabStop = true;
            this.Superio.Text = "Superio";
            this.Superio.UseVisualStyleBackColor = true;
            this.Superio.CheckedChanged += new System.EventHandler(this.Room_CheckedChanged);
            // 
            // Suite
            // 
            this.Suite.AutoSize = true;
            this.Suite.Location = new System.Drawing.Point(316, 15);
            this.Suite.Name = "Suite";
            this.Suite.Size = new System.Drawing.Size(49, 17);
            this.Suite.TabIndex = 5;
            this.Suite.TabStop = true;
            this.Suite.Text = "Suite";
            this.Suite.UseVisualStyleBackColor = true;
            this.Suite.CheckedChanged += new System.EventHandler(this.Room_CheckedChanged);
            // 
            // Deluxe
            // 
            this.Deluxe.AutoSize = true;
            this.Deluxe.Location = new System.Drawing.Point(220, 15);
            this.Deluxe.Name = "Deluxe";
            this.Deluxe.Size = new System.Drawing.Size(58, 17);
            this.Deluxe.TabIndex = 4;
            this.Deluxe.TabStop = true;
            this.Deluxe.Text = "Deluxe";
            this.Deluxe.UseVisualStyleBackColor = true;
            this.Deluxe.CheckedChanged += new System.EventHandler(this.Room_CheckedChanged);
            // 
            // Standard
            // 
            this.Standard.AutoSize = true;
            this.Standard.Checked = true;
            this.Standard.Location = new System.Drawing.Point(107, 15);
            this.Standard.Name = "Standard";
            this.Standard.Size = new System.Drawing.Size(69, 17);
            this.Standard.TabIndex = 3;
            this.Standard.TabStop = true;
            this.Standard.Text = "Standard";
            this.Standard.UseVisualStyleBackColor = true;
            this.Standard.CheckedChanged += new System.EventHandler(this.Room_CheckedChanged);
            // 
            // txtsl
            // 
            this.txtsl.Enabled = false;
            this.txtsl.Location = new System.Drawing.Point(536, 15);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(53, 20);
            this.txtsl.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chọn loại phòng:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.xtraTabPhong);
            this.panelControl2.Location = new System.Drawing.Point(13, 64);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(772, 395);
            this.panelControl2.TabIndex = 1;
            // 
            // xtraTabPhong
            // 
            this.xtraTabPhong.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabPhong.Location = new System.Drawing.Point(2, 2);
            this.xtraTabPhong.Name = "xtraTabPhong";
            this.xtraTabPhong.Size = new System.Drawing.Size(768, 391);
            this.xtraTabPhong.TabIndex = 0;
            this.xtraTabPhong.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabPhong_SelectedPageChanged);
            this.xtraTabPhong.CloseButtonClick += new System.EventHandler(this.xtraTabPhong_CloseButtonClick);
            this.xtraTabPhong.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.xtraTabPhong_ControlAdded);
            // 
            // Phong_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Phong_GUI";
            this.Size = new System.Drawing.Size(797, 518);
            this.Load += new System.EventHandler(this.Phong_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtsl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraTab.XtraTabControl xtraTabPhong;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtsl;
        private System.Windows.Forms.RadioButton Superio;
        private System.Windows.Forms.RadioButton Suite;
        private System.Windows.Forms.RadioButton Deluxe;
        private System.Windows.Forms.RadioButton Standard;
    }
}
