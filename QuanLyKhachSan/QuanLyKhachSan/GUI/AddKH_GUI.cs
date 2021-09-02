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

namespace QuanLyKhachSan.GUI
{
    public partial class AddKH_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        KhachHang_BLL khbl = new KhachHang_BLL();
        DBAccess db = new DBAccess();
        int t = 0;

        public AddKH_GUI()
        {
            InitializeComponent();
        }

        private KhachHang_DTO getdatakh()
        {
            KhachHang_DTO kh = new KhachHang_DTO();
            kh.Makh = txtmakh.Text;
            kh.Hoten = txthoten.Text;
            kh.Cmnd = txtcmnd.Text;
            kh.Sdt = txtsdt.Text;
            kh.Email = txtemail.Text;
            kh.Diachi = txtdc.Text;
            return kh;
        }

        private void showtxtkh()
        {
            txthoten.Enabled = true;
            txtcmnd.Enabled = true;
            txtsdt.Enabled = true;
            txtemail.Enabled = true;
            txtdc.Enabled = true;
        }

        private void hidetxtkh()
        {
            txthoten.Enabled = false;
            txtcmnd.Enabled = false;
            txtsdt.Enabled = false;
            txtemail.Enabled = false;
            txtdc.Enabled = false;
        }

        private void cleartxtkh()
        {
            txthoten.Text = "";
            txtcmnd.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
            txtdc.Text = "";
            txthoten.Focus();
        }

        private void clearbindkh()
        {
            txtmakh.DataBindings.Clear();
            txthoten.DataBindings.Clear();
            txtsdt.DataBindings.Clear();
            txtcmnd.DataBindings.Clear();
            txtemail.DataBindings.Clear();
            txtdc.DataBindings.Clear();
            dgvkh.DataBindings.Clear();
        }

        private void bindatakh()
        {
            BindingSource bskh = new BindingSource();
            bskh.DataSource = khbl.dskh();
            clearbindkh();
            txtmakh.DataBindings.Add("Text", bskh, "makh");
            txthoten.DataBindings.Add("Text", bskh, "hoten");
            txtcmnd.DataBindings.Add("Text", bskh, "cmnd");
            txtsdt.DataBindings.Add("Text", bskh, "sdt");
            txtemail.DataBindings.Add("Text", bskh, "email");
            txtdc.DataBindings.Add("Text", bskh, "diachi");
            dgvkh.DataSource = bskh;
        }

        private string setmakh()
        {
            int id;
            id = int.Parse(db.GetLastID("khachhang", "makh").Substring(2,3));
            if (id < 9)
                return "KH00" + (id + 1).ToString();
            else
                if(id < 99)
                    return "KH0" + (id + 1).ToString();
                else
                    return "KH" + (id + 1).ToString();
        }

        private void AddKH_GUI_Load(object sender, EventArgs e)
        {
            DataTable dtbkh = new DataTable();
            dtbkh = khbl.dskh();
            dgvkh.DataSource = dtbkh;
            txtmakh.Text = dgvkh.Rows[0].Cells[0].Value.ToString();
            txthoten.Text = dgvkh.Rows[0].Cells[1].Value.ToString();
            txtcmnd.Text = dgvkh.Rows[0].Cells[2].Value.ToString();
            txtsdt.Text = dgvkh.Rows[0].Cells[3].Value.ToString();
            txtemail.Text = dgvkh.Rows[0].Cells[4].Value.ToString();
            txtdc.Text = dgvkh.Rows[0].Cells[5].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            t = 1;
            if (btnthem.Text == "Thêm")
            {
                btnthem.Text = "Hủy bỏ";
                showtxtkh();
                cleartxtkh();
                txtmakh.Text = setmakh();
                btnluu.Enabled = true;
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                dgvkh.Enabled = false;
            }
            else
            {
                btnthem.Text = "Thêm";
                hidetxtkh();
                bindatakh();
                btnluu.Enabled = false;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                dgvkh.Enabled = true;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            t = 2;
            if (btnsua.Text == "Sửa")
            {
                btnsua.Text = "Hủy bỏ";
                showtxtkh();
                txthoten.Focus();
                btnthem.Enabled = false;
                btnxoa.Enabled = false;
                btnluu.Enabled = true;
                dgvkh.Enabled = false;
            }
            else
            {
                btnsua.Text = "Sửa";
                hidetxtkh();
                btnthem.Enabled = true;
                btnxoa.Enabled = true;
                btnluu.Enabled = false;
                dgvkh.Enabled = true;
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (t == 1)
            {
                KhachHang_DTO kh = getdatakh();
                if (khbl.addkh(kh))
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    bindatakh();
                    hidetxtkh();
                    btnthem.Text = "Thêm";
                    btnthem.Enabled = true;
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                    btnluu.Enabled = false;
                    dgvkh.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra. Thêm khách hàng thất bại!");
                }
            }
            if (t == 2)
            {
                KhachHang_DTO kh = getdatakh();
                if (khbl.editkh(kh))
                {
                    MessageBox.Show("Chỉnh sửa khách hàng thành công!");
                    bindatakh();
                    hidetxtkh();
                    btnsua.Text = "Sửa";
                    btnthem.Enabled = true;
                    btnxoa.Enabled = true;
                    btnluu.Enabled = false;
                    dgvkh.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra. Chỉnh sửa khách hàng thất bại!");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa khách hàng: " + txtmakh.Text + " - " + txthoten.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                KhachHang_DTO kh = getdatakh();
                if (db.checkExist("datphong", "makh", txtmakh.Text))
                {
                    MessageBox.Show("Chỉ có thể xóa khách hàng với số lần đặt phòng là 0!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
                else
                {
                    if (khbl.deletekh(kh))
                    {
                        MessageBox.Show("Xóa khách hàng thành công!");
                        bindatakh();
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại!");
                    }
                }
            }
        }

        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakh.Text = dgvkh.CurrentRow.Cells[0].Value.ToString();
            txthoten.Text = dgvkh.CurrentRow.Cells[1].Value.ToString();
            txtcmnd.Text = dgvkh.CurrentRow.Cells[2].Value.ToString();
            txtsdt.Text = dgvkh.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dgvkh.CurrentRow.Cells[4].Value.ToString();
            txtdc.Text = dgvkh.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
