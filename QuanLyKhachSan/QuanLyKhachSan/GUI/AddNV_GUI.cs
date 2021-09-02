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
    public partial class AddNV_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        NhanVien_BLL nvbl = new NhanVien_BLL();
        ChucVu_BLL cvbl = new ChucVu_BLL();
        DBAccess db = new DBAccess();
        string macv = "";
        int t = 0;

        public AddNV_GUI()
        {
            InitializeComponent();
        }
        private NhanVien_DTO getdatanv()
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Manv = txtmanv.Text;
            nv.Macv = cbChucvu.SelectedValue.ToString();
            nv.Hoten = txthoten.Text;
            nv.Ngaysinh = dtpngaysinh.Value;
            nv.Gioitinh = txtgioitinh.Text;
            nv.Sdt = txtsdt.Text;
            nv.Cmnd = txtcmnd.Text;
            nv.Email = txtemail.Text;
            nv.Diachi = txtdc.Text;
            return nv;
        }

        private void showtxtnv()
        {
            txthoten.Enabled = true;
            dtpngaysinh.Enabled = true;
            txtgioitinh.Enabled = true;
            txtcmnd.Enabled = true;
            txtsdt.Enabled = true;
            txtemail.Enabled = true;
            txtdc.Enabled = true;
        }

        private void hidetxtnv()
        {
            txthoten.Enabled = false;
            dtpngaysinh.Enabled = false;
            txtgioitinh.Enabled = false;
            txtcmnd.Enabled = false;
            txtsdt.Enabled = false;
            txtemail.Enabled = false;
            txtdc.Enabled = false;
        }

        private void cleartxtnv()
        {
            txthoten.Text = "";
            dtpngaysinh.Value = DateTime.Today;
            txtgioitinh.Text = "";
            txtcmnd.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
            txtdc.Text = "";
            cbChucvu.Focus();
        }

        private void clearbindnv()
        {
            txtmanv.DataBindings.Clear();
            txthoten.DataBindings.Clear();
            dtpngaysinh.DataBindings.Clear();
            txtgioitinh.DataBindings.Clear();
            txtsdt.DataBindings.Clear();
            txtcmnd.DataBindings.Clear();
            txtemail.DataBindings.Clear();
            txtdc.DataBindings.Clear();
            dgvnv.DataBindings.Clear();
        }

        private void bindatanv()
        {
            BindingSource bindSourceNV = new BindingSource();
            macv = cbChucvu.SelectedValue.ToString();
            bindSourceNV.DataSource = nvbl.dsnv(macv);
            clearbindnv();
            txtmanv.DataBindings.Add("Text", bindSourceNV, "manv");
            txthoten.DataBindings.Add("Text", bindSourceNV, "hoten");
            dtpngaysinh.DataBindings.Add("Value", bindSourceNV, "ngaysinh");
            txtgioitinh.DataBindings.Add("Text", bindSourceNV, "gioitinh");
            txtsdt.DataBindings.Add("Text", bindSourceNV, "sdt");
            txtcmnd.DataBindings.Add("Text", bindSourceNV, "cmnd");
            txtemail.DataBindings.Add("Text", bindSourceNV, "email");
            txtdc.DataBindings.Add("Text", bindSourceNV, "diachi");
            dgvnv.DataSource = bindSourceNV;
        }
        private string setmanv()
        {
            int id;
            id = int.Parse(db.GetLastID("nhanvien", "manv").Substring(2, 3));
            if (id < 9)
                return "NV00" + (id + 1).ToString();
            else
                if (id < 99)
                    return "NV0" + (id + 1).ToString();
                else
                    return "NV" + (id + 1).ToString();
        }
        private void AddNV_GUI_Load(object sender, EventArgs e)
        {
            DataTable dtbcv = new DataTable();
            dtbcv = cvbl.dscv();
            cbChucvu.DataSource = dtbcv;
            cbChucvu.DisplayMember = "tencv";
            cbChucvu.ValueMember = "macv";

            cbChucvu.SelectedIndex = 0;
            string macv01 = cbChucvu.SelectedValue.ToString();
            DataTable dtbnv = new DataTable();
            dtbnv = nvbl.dsnv(macv01);
            dgvnv.DataSource = dtbnv;
            txtmanv.Text = dgvnv.Rows[0].Cells[0].Value.ToString();
            txthoten.Text = dgvnv.Rows[0].Cells[1].Value.ToString();
            dtpngaysinh.Value = Convert.ToDateTime(dgvnv.Rows[0].Cells[2].Value);
            txtgioitinh.Text = dgvnv.Rows[0].Cells[3].Value.ToString();
            txtsdt.Text = dgvnv.Rows[0].Cells[4].Value.ToString();
            txtcmnd.Text = dgvnv.Rows[0].Cells[5].Value.ToString();
            txtdc.Text = dgvnv.Rows[0].Cells[6].Value.ToString();
            txtemail.Text = dgvnv.Rows[0].Cells[7].Value.ToString();
        }

        private void cbChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btnthem.Text != "Hủy bỏ" && btnsua.Text != "Hủy bỏ")
            {
                bindatanv();
            }
        }

        private void dgvkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.Text = dgvnv.CurrentRow.Cells[0].Value.ToString();
            txthoten.Text = dgvnv.CurrentRow.Cells[1].Value.ToString();
            dtpngaysinh.Value = Convert.ToDateTime(dgvnv.CurrentRow.Cells[2].Value);
            txtgioitinh.Text = dgvnv.CurrentRow.Cells[3].Value.ToString();
            txtsdt.Text = dgvnv.CurrentRow.Cells[4].Value.ToString();
            txtcmnd.Text = dgvnv.CurrentRow.Cells[5].Value.ToString();
            txtdc.Text = dgvnv.CurrentRow.Cells[6].Value.ToString();
            txtemail.Text = dgvnv.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            dgvnv.ClearSelection();
            t = 1;
            if (btnthem.Text == "Thêm")
            {
                btnthem.Text = "Hủy bỏ";
                showtxtnv();
                cleartxtnv();
                txtmanv.Text = setmanv();
                btnluu.Enabled = true;
                btnsua.Enabled = false;
                btnxoa.Enabled = false;
                dgvnv.Enabled = false;
            }
            else
            {
                btnthem.Text = "Thêm";
                hidetxtnv();
                bindatanv();
                btnluu.Enabled = false;
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                dgvnv.Enabled = true;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            dgvnv.ClearSelection();
            t = 2;
            if (btnsua.Text == "Sửa")
            {
                btnsua.Text = "Hủy bỏ";
                showtxtnv();
                txthoten.Focus();
                btnthem.Enabled = false;
                btnxoa.Enabled = false;
                btnluu.Enabled = true;
                dgvnv.Enabled = false;
            }
            else
            {
                btnsua.Text = "Sửa";
                hidetxtnv();
                btnthem.Enabled = true;
                btnxoa.Enabled = true;
                btnluu.Enabled = false;
                dgvnv.Enabled = true;
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (t == 1)
            {
                NhanVien_DTO nv = getdatanv();
                if (nvbl.addnv(nv))
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                    bindatanv();
                    hidetxtnv();
                    btnthem.Text = "Thêm";
                    btnthem.Enabled = true;
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                    btnluu.Enabled = false;
                    dgvnv.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra. Thêm nhân viên thất bại!");
                }
            }
            if (t == 2)
            {
                NhanVien_DTO nv = getdatanv();
                if (nvbl.editnv(nv))
                {
                    MessageBox.Show("Chỉnh sửa nhân viên thành công!");
                    bindatanv();
                    hidetxtnv();
                    btnsua.Text = "Sửa";
                    btnthem.Enabled = true;
                    btnxoa.Enabled = true;
                    btnluu.Enabled = false;
                    dgvnv.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra. Chỉnh sửa nhân viên thất bại!");
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa nhân viên: " + txtmanv.Text + " - " + txthoten.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NhanVien_DTO nv = getdatanv();
                if (db.checkExist("quyennv", "manv", txtmanv.Text))
                {
                    MessageBox.Show("Chỉ có thể xóa nhân viên chưa phân quyền!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (nvbl.deletenv(nv))
                    {
                        MessageBox.Show("Xóa nhân viên thành công!");
                        bindatanv();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!");
                    }
                }
            }
        }
    }
}
