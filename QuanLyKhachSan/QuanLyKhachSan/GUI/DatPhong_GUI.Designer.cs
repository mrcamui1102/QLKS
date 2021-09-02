namespace QuanLyKhachSan.GUI
{
    partial class DatPhong_GUI
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.dgvdp = new System.Windows.Forms.DataGridView();
            this.madp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiendatcoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnxoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnluu = new DevExpress.XtraEditors.SimpleButton();
            this.btnsua = new DevExpress.XtraEditors.SimpleButton();
            this.btnthem = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtpngaydat = new System.Windows.Forms.DateTimePicker();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dtpngaydi = new System.Windows.Forms.DateTimePicker();
            this.dtpngayden = new System.Windows.Forms.DateTimePicker();
            this.txttiencoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtmanv = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtmadp = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ckbtrangtrai = new System.Windows.Forms.CheckBox();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtLpDat = new DevExpress.XtraEditors.TextEdit();
            this.txtsoluong = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.btnClearAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnClearOne = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddOne = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddAll = new DevExpress.XtraEditors.SimpleButton();
            this.listDatphong = new System.Windows.Forms.ListBox();
            this.listPhong = new System.Windows.Forms.ListBox();
            this.cbloaiphong = new System.Windows.Forms.ComboBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttiencoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmadp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLpDat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.dgvdp);
            this.groupControl3.Location = new System.Drawing.Point(13, 230);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(771, 253);
            this.groupControl3.TabIndex = 5;
            this.groupControl3.Text = "Bảng danh sách";
            // 
            // dgvdp
            // 
            this.dgvdp.AllowUserToAddRows = false;
            this.dgvdp.AllowUserToDeleteRows = false;
            this.dgvdp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madp,
            this.manv,
            this.makh,
            this.loaiphong,
            this.ngaydat,
            this.ngayden,
            this.ngaydi,
            this.tiendatcoc,
            this.soluong,
            this.trangthai});
            this.dgvdp.Location = new System.Drawing.Point(12, 23);
            this.dgvdp.Name = "dgvdp";
            this.dgvdp.ReadOnly = true;
            this.dgvdp.Size = new System.Drawing.Size(745, 215);
            this.dgvdp.TabIndex = 0;
            this.dgvdp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdp_CellClick);
            // 
            // madp
            // 
            this.madp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.madp.DataPropertyName = "madp";
            this.madp.HeaderText = "Mã DP";
            this.madp.Name = "madp";
            this.madp.ReadOnly = true;
            this.madp.Width = 62;
            // 
            // manv
            // 
            this.manv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã NV";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            this.manv.Width = 62;
            // 
            // makh
            // 
            this.makh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Mã KH";
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            this.makh.Width = 62;
            // 
            // loaiphong
            // 
            this.loaiphong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loaiphong.DataPropertyName = "tenlp";
            this.loaiphong.HeaderText = "Loại phòng";
            this.loaiphong.Name = "loaiphong";
            this.loaiphong.ReadOnly = true;
            this.loaiphong.Width = 84;
            // 
            // ngaydat
            // 
            this.ngaydat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngaydat.DataPropertyName = "ngaydat";
            this.ngaydat.HeaderText = "Ngày đặt";
            this.ngaydat.Name = "ngaydat";
            this.ngaydat.ReadOnly = true;
            this.ngaydat.Width = 76;
            // 
            // ngayden
            // 
            this.ngayden.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngayden.DataPropertyName = "ngayden";
            this.ngayden.HeaderText = "Ngày đến";
            this.ngayden.Name = "ngayden";
            this.ngayden.ReadOnly = true;
            this.ngayden.Width = 78;
            // 
            // ngaydi
            // 
            this.ngaydi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngaydi.DataPropertyName = "ngaydi";
            this.ngaydi.HeaderText = "Ngày đi";
            this.ngaydi.Name = "ngaydi";
            this.ngaydi.ReadOnly = true;
            this.ngaydi.Width = 68;
            // 
            // tiendatcoc
            // 
            this.tiendatcoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tiendatcoc.DataPropertyName = "tiendatcoc";
            this.tiendatcoc.HeaderText = "Đặt cọc";
            this.tiendatcoc.Name = "tiendatcoc";
            this.tiendatcoc.ReadOnly = true;
            this.tiendatcoc.Width = 69;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Width = 74;
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Tr.Thái";
            this.trangthai.Name = "trangthai";
            this.trangthai.ReadOnly = true;
            this.trangthai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.trangthai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.trangthai.Width = 67;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnxoa);
            this.groupControl2.Controls.Add(this.btnluu);
            this.groupControl2.Controls.Add(this.btnsua);
            this.groupControl2.Controls.Add(this.btnthem);
            this.groupControl2.Location = new System.Drawing.Point(641, 6);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(143, 218);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Tác vụ";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(26, 166);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(91, 30);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Thanh toán";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Location = new System.Drawing.Point(26, 120);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(91, 30);
            this.btnluu.TabIndex = 2;
            this.btnluu.Text = "Lưu";
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(26, 76);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(91, 30);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(26, 31);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(91, 30);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtmakh);
            this.groupControl1.Controls.Add(this.dtpngaydat);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.dtpngaydi);
            this.groupControl1.Controls.Add(this.dtpngayden);
            this.groupControl1.Controls.Add(this.txttiencoc);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtmanv);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtmadp);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(13, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(258, 218);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông tin đặt phòng";
            // 
            // dtpngaydat
            // 
            this.dtpngaydat.Enabled = false;
            this.dtpngaydat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaydat.Location = new System.Drawing.Point(96, 104);
            this.dtpngaydat.Name = "dtpngaydat";
            this.dtpngaydat.Size = new System.Drawing.Size(138, 21);
            this.dtpngaydat.TabIndex = 11;
            this.dtpngaydat.Value = new System.DateTime(2014, 12, 17, 15, 43, 37, 0);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(28, 110);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 13);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Ngày đặt:";
            // 
            // dtpngaydi
            // 
            this.dtpngaydi.Enabled = false;
            this.dtpngaydi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaydi.Location = new System.Drawing.Point(96, 162);
            this.dtpngaydi.Name = "dtpngaydi";
            this.dtpngaydi.Size = new System.Drawing.Size(138, 21);
            this.dtpngaydi.TabIndex = 5;
            // 
            // dtpngayden
            // 
            this.dtpngayden.Enabled = false;
            this.dtpngayden.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngayden.Location = new System.Drawing.Point(96, 133);
            this.dtpngayden.Name = "dtpngayden";
            this.dtpngayden.Size = new System.Drawing.Size(138, 21);
            this.dtpngayden.TabIndex = 4;
            // 
            // txttiencoc
            // 
            this.txttiencoc.Enabled = false;
            this.txttiencoc.Location = new System.Drawing.Point(96, 190);
            this.txttiencoc.Name = "txttiencoc";
            this.txttiencoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttiencoc.Properties.Appearance.Options.UseFont = true;
            this.txttiencoc.Size = new System.Drawing.Size(138, 20);
            this.txttiencoc.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(27, 195);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(62, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Tiền đặt cọc:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Location = new System.Drawing.Point(28, 167);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Ngày đi:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(28, 138);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Ngày đến:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(28, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Mã KH:";
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.Location = new System.Drawing.Point(96, 50);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmanv.Properties.Appearance.Options.UseFont = true;
            this.txtmanv.Size = new System.Drawing.Size(138, 20);
            this.txtmanv.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(28, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Mã NV:";
            // 
            // txtmadp
            // 
            this.txtmadp.Enabled = false;
            this.txtmadp.Location = new System.Drawing.Point(96, 22);
            this.txtmadp.Name = "txtmadp";
            this.txtmadp.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmadp.Properties.Appearance.Options.UseFont = true;
            this.txtmadp.Size = new System.Drawing.Size(138, 20);
            this.txtmadp.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(28, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(34, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã DP:";
            // 
            // ckbtrangtrai
            // 
            this.ckbtrangtrai.AutoSize = true;
            this.ckbtrangtrai.Enabled = false;
            this.ckbtrangtrai.Location = new System.Drawing.Point(17, 180);
            this.ckbtrangtrai.Name = "ckbtrangtrai";
            this.ckbtrangtrai.Size = new System.Drawing.Size(148, 17);
            this.ckbtrangtrai.TabIndex = 7;
            this.ckbtrangtrai.Text = "Trạng thái (đã trả phòng)";
            this.ckbtrangtrai.UseVisualStyleBackColor = true;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.txtLpDat);
            this.groupControl4.Controls.Add(this.txtsoluong);
            this.groupControl4.Controls.Add(this.labelControl8);
            this.groupControl4.Controls.Add(this.btnClearAll);
            this.groupControl4.Controls.Add(this.btnClearOne);
            this.groupControl4.Controls.Add(this.btnAddOne);
            this.groupControl4.Controls.Add(this.btnAddAll);
            this.groupControl4.Controls.Add(this.listDatphong);
            this.groupControl4.Controls.Add(this.listPhong);
            this.groupControl4.Controls.Add(this.cbloaiphong);
            this.groupControl4.Controls.Add(this.ckbtrangtrai);
            this.groupControl4.Location = new System.Drawing.Point(277, 6);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(358, 218);
            this.groupControl4.TabIndex = 6;
            this.groupControl4.Text = "Chi tiết đặt phòng";
            // 
            // txtLpDat
            // 
            this.txtLpDat.Enabled = false;
            this.txtLpDat.Location = new System.Drawing.Point(208, 31);
            this.txtLpDat.Name = "txtLpDat";
            this.txtLpDat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLpDat.Properties.Appearance.Options.UseFont = true;
            this.txtLpDat.Size = new System.Drawing.Size(136, 20);
            this.txtLpDat.TabIndex = 18;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Enabled = false;
            this.txtsoluong.Location = new System.Drawing.Point(286, 177);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoluong.Properties.Appearance.Options.UseFont = true;
            this.txtsoluong.Size = new System.Drawing.Size(58, 20);
            this.txtsoluong.TabIndex = 16;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(208, 181);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(72, 13);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "Tổng số lượng:";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Appearance.Options.UseFont = true;
            this.btnClearAll.Enabled = false;
            this.btnClearAll.Location = new System.Drawing.Point(164, 149);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(35, 20);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "|<";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClearOne
            // 
            this.btnClearOne.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOne.Appearance.Options.UseFont = true;
            this.btnClearOne.Enabled = false;
            this.btnClearOne.Location = new System.Drawing.Point(164, 120);
            this.btnClearOne.Name = "btnClearOne";
            this.btnClearOne.Size = new System.Drawing.Size(35, 20);
            this.btnClearOne.TabIndex = 14;
            this.btnClearOne.Text = "<";
            this.btnClearOne.Click += new System.EventHandler(this.btnClearOne_Click);
            // 
            // btnAddOne
            // 
            this.btnAddOne.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOne.Appearance.Options.UseFont = true;
            this.btnAddOne.Enabled = false;
            this.btnAddOne.Location = new System.Drawing.Point(164, 90);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(35, 20);
            this.btnAddOne.TabIndex = 13;
            this.btnAddOne.Text = ">";
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAll.Appearance.Options.UseFont = true;
            this.btnAddAll.Enabled = false;
            this.btnAddAll.Location = new System.Drawing.Point(164, 61);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(35, 20);
            this.btnAddAll.TabIndex = 12;
            this.btnAddAll.Text = ">|";
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // listDatphong
            // 
            this.listDatphong.FormattingEnabled = true;
            this.listDatphong.Location = new System.Drawing.Point(208, 61);
            this.listDatphong.Name = "listDatphong";
            this.listDatphong.Size = new System.Drawing.Size(136, 108);
            this.listDatphong.TabIndex = 11;
            this.listDatphong.DataSourceChanged += new System.EventHandler(this.listDatphong_DataSourceChanged);
            // 
            // listPhong
            // 
            this.listPhong.FormattingEnabled = true;
            this.listPhong.Location = new System.Drawing.Point(17, 61);
            this.listPhong.Name = "listPhong";
            this.listPhong.Size = new System.Drawing.Size(136, 108);
            this.listPhong.TabIndex = 10;
            // 
            // cbloaiphong
            // 
            this.cbloaiphong.FormattingEnabled = true;
            this.cbloaiphong.Location = new System.Drawing.Point(17, 31);
            this.cbloaiphong.Name = "cbloaiphong";
            this.cbloaiphong.Size = new System.Drawing.Size(136, 21);
            this.cbloaiphong.TabIndex = 9;
            this.cbloaiphong.SelectedIndexChanged += new System.EventHandler(this.cbloaiphong_SelectedIndexChanged);
            // 
            // txtmakh
            // 
            this.txtmakh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmakh.Enabled = false;
            this.txtmakh.Location = new System.Drawing.Point(96, 76);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(137, 21);
            this.txtmakh.TabIndex = 3;
            // 
            // DatPhong_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "DatPhong_GUI";
            this.Size = new System.Drawing.Size(797, 518);
            this.Load += new System.EventHandler(this.DatPhong_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txttiencoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmanv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmadp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLpDat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoluong.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.DataGridView dgvdp;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnxoa;
        private DevExpress.XtraEditors.SimpleButton btnluu;
        private DevExpress.XtraEditors.SimpleButton btnsua;
        private DevExpress.XtraEditors.SimpleButton btnthem;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txttiencoc;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtmanv;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtmadp;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.CheckBox ckbtrangtrai;
        private System.Windows.Forms.DateTimePicker dtpngaydi;
        private System.Windows.Forms.DateTimePicker dtpngayden;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.ComboBox cbloaiphong;
        private System.Windows.Forms.ListBox listPhong;
        private System.Windows.Forms.ListBox listDatphong;
        private DevExpress.XtraEditors.SimpleButton btnClearAll;
        private DevExpress.XtraEditors.SimpleButton btnClearOne;
        private DevExpress.XtraEditors.SimpleButton btnAddOne;
        private DevExpress.XtraEditors.SimpleButton btnAddAll;
        private DevExpress.XtraEditors.TextEdit txtsoluong;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.DateTimePicker dtpngaydat;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.DataGridViewTextBoxColumn madp;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayden;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiendatcoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewCheckBoxColumn trangthai;
        private DevExpress.XtraEditors.TextEdit txtLpDat;
        private System.Windows.Forms.TextBox txtmakh;
    }
}
