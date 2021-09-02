using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyKhachSan.BLL;
using QuanLyKhachSan.DTO;
using QuanLyKhachSan.DAL;
using System.Collections;

namespace QuanLyKhachSan.GUI
{
    public partial class DatPhong_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        LoaiPhong_BLL lpbl = new LoaiPhong_BLL();
        Phong_BLL pbl = new Phong_BLL();
        DatPhong_BLL dpbl = new DatPhong_BLL();
        ChiTietDatPhong_BLL ctdpbl = new ChiTietDatPhong_BLL();
        HoaDon_BLL hdbl = new HoaDon_BLL();
        DBAccess db = new DBAccess();
        string tenlp = "";
        public static string madatphong = "";
        int t = 0;
        ArrayList arr = new ArrayList();
        ArrayList arr1 = new ArrayList();
        
        public DatPhong_GUI()
        {
            InitializeComponent();
        }

        private DatPhong_DTO getdatadp()
        {
            DatPhong_DTO dp = new DatPhong_DTO();
            dp.Madp = txtmadp.Text;
            dp.Manv = txtmanv.Text;
            dp.Makh = txtmakh.Text;
            dp.Tenlp = cbloaiphong.SelectedValue.ToString();
            dp.Ngaydat = dtpngaydat.Value;
            dp.Ngayden = dtpngayden.Value;
            dp.Ngaydi = dtpngaydi.Value;
            dp.Tiendatcoc = int.Parse(txttiencoc.Text);
            dp.Soluong = int.Parse(txtsoluong.Text);
            dp.Trangthai = ckbtrangtrai.Checked;
            return dp;
        }

        private CTDP_DTO getdatactdp(ArrayList arr, int i)
        {
            CTDP_DTO ctdp = new CTDP_DTO();
            ctdp.Madp = txtmadp.Text;
            ctdp.Maphong = arr[i].ToString();
            return ctdp;
        }

        private void showtxtdp()
        {
            txtmakh.Enabled = true;
            dtpngayden.Enabled = true;
            dtpngaydi.Enabled = true;
        }

        private void hidetxtdp()
        {
            txtmakh.Enabled = false;
            dtpngayden.Enabled = false;
            dtpngaydi.Enabled = false;
        }

        private void cleartxtdp()
        {
            txtmakh.Text = "";
            dtpngaydat.Value = DateTime.Today;
            dtpngayden.Value = DateTime.Today;
            dtpngaydi.Value = DateTime.Today;
            ckbtrangtrai.Checked = false;
            txttiencoc.Text = "";
            txtLpDat.Text = "";
            txtsoluong.Text = "";
            txtmakh.Focus();
        }

        private void limitdate()
        {
            dtpngayden.MinDate = DateTime.Today;
            dtpngaydi.MinDate = DateTime.Today;
        }

        private void nolimitdate()
        {
            dtpngayden.MinDate = Convert.ToDateTime("01/01/1753");
            dtpngaydi.MinDate = Convert.ToDateTime("01/01/1753");
        }

        private void clearbinddp()
        {
            txtmadp.DataBindings.Clear();
            txtmanv.DataBindings.Clear();
            txtmakh.DataBindings.Clear();
            txtLpDat.DataBindings.Clear();
            dtpngaydat.DataBindings.Clear();
            dtpngayden.DataBindings.Clear();
            dtpngaydi.DataBindings.Clear();
            txttiencoc.DataBindings.Clear();
            txtsoluong.DataBindings.Clear();
            ckbtrangtrai.DataBindings.Clear();
            listDatphong.DataBindings.Clear();
            dgvdp.DataBindings.Clear();
        }

        private void bindatadp()
        {
            BindingSource bsdp = new BindingSource();
            bsdp.DataSource = dpbl.dsdp();
            clearbinddp();
            dgvdp.DataSource = bsdp;
            txtmadp.DataBindings.Add("Text", bsdp, "madp");
            txtmanv.DataBindings.Add("Text", bsdp, "manv");
            txtmakh.DataBindings.Add("Text", bsdp, "makh");
            txtLpDat.DataBindings.Add("Text", bsdp, "tenlp");
            dtpngaydat.DataBindings.Add("Value", bsdp, "ngaydat");
            dtpngayden.DataBindings.Add("Value", bsdp, "ngayden");
            dtpngaydi.DataBindings.Add("Value", bsdp, "ngaydi");
            txttiencoc.DataBindings.Add("Text", bsdp, "tiendatcoc");
            txtsoluong.DataBindings.Add("Text", bsdp, "soluong");
            ckbtrangtrai.DataBindings.Add("Checked", bsdp, "trangthai");
            bindatalistdatphong();
        }

        private void DatPhong_GUI_Load(object sender, EventArgs e)
        {
            DataTable dtblp = new DataTable();
            dtblp = lpbl.dslp();
            cbloaiphong.DataSource = dtblp;
            cbloaiphong.DisplayMember = "tenlp";
            cbloaiphong.ValueMember = "tenlp";
            bindatalistphong();
            bindatadp();
        }

        private void bindatalistphong()
        {
            BindingSource bsp = new BindingSource();
            tenlp = cbloaiphong.SelectedValue.ToString();
            bsp.DataSource = pbl.dsph(tenlp);
            listPhong.DataBindings.Clear();
            listPhong.DataSource = bsp;
            listPhong.DisplayMember = "maphong";
            listPhong.ValueMember = "maphong";
        }

        private void bindatalistdatphong()
        {
            BindingSource bsctdp = new BindingSource();
            bsctdp.DataSource = ctdpbl.dsdpct(txtmadp.Text);
            listDatphong.DataSource = bsctdp;
            listDatphong.DisplayMember = "maphong";
            listDatphong.ValueMember = "maphong";
        }

        private void cbloaiphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnthem.Text == "Hủy bỏ")
            {
                txtLpDat.Text = cbloaiphong.SelectedValue.ToString();
                txttiencoc.Text = lpbl.getTiendatcoc(cbloaiphong.SelectedValue.ToString(), int.Parse(txtsoluong.Text)).ToString();
            }
            bindatalistphong();
        }

        private void dgvdp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bindatalistdatphong();
            txtmadp.Text = dgvdp.CurrentRow.Cells[0].Value.ToString();
            txtmanv.Text = dgvdp.CurrentRow.Cells[1].Value.ToString();
            txtmakh.Text = dgvdp.CurrentRow.Cells[2].Value.ToString();
            txtLpDat.Text = dgvdp.CurrentRow.Cells[3].Value.ToString();
            dtpngaydat.Value = Convert.ToDateTime(dgvdp.CurrentRow.Cells[4].Value);
            dtpngayden.Value = Convert.ToDateTime(dgvdp.CurrentRow.Cells[5].Value);
            dtpngaydi.Value = Convert.ToDateTime(dgvdp.CurrentRow.Cells[6].Value);
            txttiencoc.Text = dgvdp.CurrentRow.Cells[7].Value.ToString();
            txtsoluong.Text = dgvdp.CurrentRow.Cells[8].Value.ToString();
            ckbtrangtrai.Checked = Convert.ToBoolean(dgvdp.CurrentRow.Cells[9].Value);
        }

        private string setmadp()
        {
            int id;
            id = int.Parse(db.GetLastID("datphong", "madp").Substring(2, 3));
            if (id < 9)
                return "DP00" + (id + 1).ToString();
            else
                if (id < 99)
                    return "DP0" + (id + 1).ToString();
                else
                    return "DP" + (id + 1).ToString();
        }

        private void enablemove()
        {
            btnAddAll.Enabled = true;
            btnAddOne.Enabled = true;
            btnClearOne.Enabled = true;
            btnClearAll.Enabled = true;
        }

        private void disablemove()
        {
            btnAddAll.Enabled = false;
            btnAddOne.Enabled = false;
            btnClearOne.Enabled = false;
            btnClearAll.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            t = 1;
            if (btnthem.Text == "Thêm")
            {
                limitdate();
                btnthem.Text = "Hủy bỏ";
                enablemove();
                showtxtdp();
                cleartxtdp();
                listDatphong.DataSource = null;
                listDatphong.DataBindings.Clear();
                txtmadp.Text = setmadp();
                txtmanv.Text = frmLogin.mnv;
                txtLpDat.Text = cbloaiphong.SelectedValue.ToString();
                btnluu.Enabled = true;
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                dgvdp.Enabled = false;
            }
            else
            {
                nolimitdate();
                btnthem.Text = "Thêm";
                arr.Clear();
                arr1.Clear();
                disablemove();
                hidetxtdp();
                bindatadp();
                bindatalistphong();
                btnluu.Enabled = false;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                dgvdp.Enabled = true;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            t = 2;
            if (btnsua.Text == "Sửa")
            {
                btnsua.Text = "Hủy bỏ";
                showtxtdp();
                txtmakh.Focus();
                btnthem.Enabled = false;
                btnxoa.Enabled = false;
                btnluu.Enabled = true;
                dgvdp.Enabled = false;
            }
            else
            {
                btnsua.Text = "Sửa";
                hidetxtdp();
                btnthem.Enabled = true;
                btnxoa.Enabled = true;
                btnluu.Enabled = false;
                dgvdp.Enabled = true;
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (db.checkExist("khachhang", "makh", txtmakh.Text))
            {
                if (t == 1)
                {
                    DatPhong_DTO dp = getdatadp();
                    if (dpbl.adddp(dp))
                    {
                        int d = 0;
                        if (arr.Count == 0)
                        {
                            setarr1();
                            for (int i = 0; i < arr1.Count; i++)
                            {
                                if (ctdpbl.addctdp(getdatactdp(arr1, i)))
                                {
                                    pbl.capnhatphong(arr1[i].ToString());
                                    lpbl.truslph(cbloaiphong.SelectedValue.ToString());
                                    d++;
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < arr.Count; i++)
                            {
                                if (ctdpbl.addctdp(getdatactdp(arr, i)))
                                {
                                    pbl.capnhatphong(arr[i].ToString());
                                    lpbl.truslph(cbloaiphong.SelectedValue.ToString());
                                    d++;
                                }
                            }
                        }
                        if (d != 0)
                            MessageBox.Show("Đặt phòng thành công!");
                        else
                            MessageBox.Show("Đặt phòng thất bại!");
                        bindatadp();
                        hidetxtdp();
                        arr.Clear();
                        arr1.Clear();
                        disablemove();
                        bindatalistphong();
                        btnthem.Text = "Thêm";
                        btnthem.Enabled = true;
                        btnsua.Enabled = true;
                        btnxoa.Enabled = true;
                        btnluu.Enabled = false;
                        dgvdp.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra. Đặt phòng thất bại!");
                    }
                }
                if (t == 2)
                {
                    DatPhong_DTO dp = getdatadp();
                    if (dpbl.editdp(dp))
                    {
                        //DataTable dtb = (ctdpbl.dsdpct(txtmadp.Text));
                        //for (int i = 0; i < dtb.Rows.Count; i++)
                        //{
                        //    DataRow r = dtb.Rows[i];
                        //    pbl.traphong(r[0].ToString());
                        //    lpbl.congslph(txtLpDat.Text);
                        //}
                        MessageBox.Show("Chỉnh sửa thành công!");
                        bindatadp();
                        hidetxtdp();
                        btnsua.Text = "Sửa";
                        btnthem.Enabled = true;
                        btnxoa.Enabled = true;
                        btnluu.Enabled = false;
                        dgvdp.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra. Chỉnh sửa thất bại!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Mã khách hàng không đúng! Vui lòng nhập lại.");
            }
        }

        private int getTongtien()
        {
            int tg = 0;
            tg = lpbl.getGiaphong(txtLpDat.Text)*int.Parse(txtsoluong.Text);
            return tg;
        }

        private string getmahd()
        {
            int id;
            id = int.Parse(db.GetLastID("hoadon", "mahd").Substring(2, 3));
            if (id < 9)
                return "HD00" + (id + 1).ToString();
            else
                if (id < 99)
                    return "HD0" + (id + 1).ToString();
                else
                    return "HD" + (id + 1).ToString();
        }

        private HoaDon_DTO getdatahd()
        {
            HoaDon_DTO hd = new HoaDon_DTO();
            hd.Mahd = getmahd();
            hd.Madp = txtmadp.Text;
            hd.Ngaylap = DateTime.Today;
            hd.Tongtien = getTongtien();
            return hd;
        }

        public ArrayList getdspd()
        {
            ArrayList a = new ArrayList();
            DataTable dtb = ctdpbl.dsdpct(txtmadp.Text);
            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                DataRow r = dtb.Rows[i];
                a.Add(r[0].ToString());
            }
            return a;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (ckbtrangtrai.Checked == false)
            {
                if (MessageBox.Show("Phòng chưa trả!"+System.Environment.NewLine+"Bạn có muốn cập nhật trạng thái phòng và thanh toán?.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    madatphong = txtmadp.Text;
                    if (dpbl.capnhattrangthai(txtmadp.Text, true))
                    {
                        for (int i = 0; i < getdspd().Count; i++)
                        {
                            pbl.traphong(getdspd()[i].ToString());
                            lpbl.congslph(txtLpDat.Text);
                        }
                        HoaDon_DTO hd = getdatahd();
                        if (hdbl.laphoadon(hd))
                        {
                            MessageBox.Show("Cập nhật thành công!");
                            new frmReportHD().Show();
                        }
                    }
                }
            }
            else
            {
                madatphong = txtmadp.Text;
                new frmReportHD().Show();
            }
        }

        private void setarr1()
        {
            DataTable dtb = new DataTable();
            tenlp = cbloaiphong.SelectedValue.ToString();
            dtb = pbl.dsph(tenlp);

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                DataRow r = dtb.Rows[i];
                arr1.Add(r[0]);
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            arr.Clear();
            arr1.Clear();
            btnClearOne.Enabled = false;
            btnAddOne.Enabled = false;
            BindingSource bsp = new BindingSource();
            tenlp = cbloaiphong.SelectedValue.ToString();
            bsp.DataSource = pbl.dsph(tenlp);
            listDatphong.DataBindings.Clear();
            listDatphong.DataSource = bsp;
            listDatphong.DisplayMember = "maphong";
            listDatphong.ValueMember = "maphong";
            listPhong.DataSource = null;
            listPhong.DataBindings.Clear();
            txtsoluong.Text = pbl.dsph(tenlp).Rows.Count.ToString();
            txttiencoc.Text = lpbl.getTiendatcoc(cbloaiphong.SelectedValue.ToString(), int.Parse(txtsoluong.Text)).ToString();
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            if (arr1.Count == 0)
            {
                setarr1();
            }

            listDatphong.DataSource = null;
            listDatphong.DataBindings.Clear();
            if (listPhong.SelectedIndex > -1)
            {
                arr.Add(listPhong.SelectedValue);
                arr1.RemoveAt(listPhong.SelectedIndex);
            }
            listPhong.ClearSelected();
            BindingSource bsOne = new BindingSource();
            bsOne.DataSource = arr;
            listDatphong.DataSource = bsOne;

            listPhong.DataSource = null;
            listPhong.DataBindings.Clear();
            listPhong.DataSource = arr1;

            if (arr.Count != 0)
                btnClearOne.Enabled = true;

            if (arr1.Count == 0)
                btnAddOne.Enabled = false;
            else
                btnAddOne.Enabled = true;
        }

        private void btnClearOne_Click(object sender, EventArgs e)
        {
            string tmp = arr[listDatphong.SelectedIndex].ToString();
            arr.RemoveAt(listDatphong.SelectedIndex);
            arr1.Add(tmp);
            listPhong.DataSource = null;
            listPhong.DataBindings.Clear();
            listPhong.DataSource = arr1;
            listDatphong.DataSource = null;
            listDatphong.DataBindings.Clear();
            listDatphong.DataSource = arr;
            btnAddOne.Enabled = true;
            if (arr.Count == 0)
                btnClearOne.Enabled = false;
            else
                btnClearOne.Enabled = true;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            arr.Clear();
            arr1.Clear();
            btnAddOne.Enabled = true;
            btnClearOne.Enabled = false;
            bindatalistphong();
            listDatphong.DataSource = null;
            listDatphong.DataBindings.Clear();
            txtsoluong.Text = "0";
        }

        private void listDatphong_DataSourceChanged(object sender, EventArgs e)
        {
            txtsoluong.Text = arr.Count.ToString();
            txttiencoc.Text = lpbl.getTiendatcoc(cbloaiphong.SelectedValue.ToString(), int.Parse(txtsoluong.Text)).ToString();
        }
    }
}
