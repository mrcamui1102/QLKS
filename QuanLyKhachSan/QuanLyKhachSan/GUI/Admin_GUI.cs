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
using QuanLyKhachSan.DAL;

namespace QuanLyKhachSan.GUI
{
    public partial class Admin_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        Admin_BLL adbl = new Admin_BLL();
        DBAccess db = new DBAccess();
        string id = "";

        public Admin_GUI()
        {
            InitializeComponent();
        }

        private void bindDataAd()
        {
            DataRow r = adbl.infoAdmin(frmLogin.mnv);
            txtmanv.Text = r[0].ToString();
            txtchucvu.Text = r[1].ToString();
            txthoten.Text = r[2].ToString();
            txtngaysinh.Text = r[3].ToString();
            txtgioitinh.Text = r[4].ToString();
            txtsdt.Text = r[5].ToString();
            txtcmnd.Text = r[6].ToString();
            txtemail.Text = r[7].ToString();
            txtdc.Text = r[8].ToString();
            txtqqt.Text = r[9].ToString();
            txtmkqt.Text = r[10].ToString();
        }

        private void bindDataCbNV()
        {
            DataTable dtb = adbl.dsnvpq();
            cbmanv.DataSource = dtb;
            cbmanv.ValueMember = "manv";
            cbmanv.DisplayMember = "manv";
        }

        private void Admin_GUI_Load(object sender, EventArgs e)
        {
            bindDataAd();
            bindDataCbNV();
            if (db.checkExist("quyennv", "manv", cbmanv.SelectedValue.ToString()))
            {
                txtqh.Text = adbl.quyennv(cbmanv.SelectedValue.ToString());
            }
            else
            {
                txtqh.Text = "Chưa phân quyền";
            }
        }

        private void cbmanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (db.checkExist("quyennv", "manv", cbmanv.SelectedValue.ToString()))
            {
                txtqh.Text = adbl.quyennv(cbmanv.SelectedValue.ToString());
            }
            else
            {
                txtqh.Text = "Chưa phân quyền";
            }
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            panelpq.Enabled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string sql = "Insert Into quyennv Values('"+cbmanv.SelectedValue.ToString()+"','"+id+"','"+txtmknv.Text+"')";
            string sql2 = "Update quyennv set id='" + id + "',matkhau='" + txtmknv.Text + "' where manv = '" + cbmanv.SelectedValue.ToString() + "'";
            if (txtmknv.Text.Length == 3)
            {
                thongbao.Text = "";
                if (!db.checkExist("quyennv", "manv", cbmanv.SelectedValue.ToString()))
                {
                    if (db.ExecuteQuery(sql))
                    {
                        rdbqt.Checked = false;
                        rdbnv.Checked = false;
                        rdbkhach.Checked = false;
                        txtmknv.Text = "";
                        panelpq.Enabled = false;
                        thongbao.Text = "";
                    }
                }
                else
                {
                    if (db.ExecuteQuery(sql2))
                    {
                        rdbqt.Checked = false;
                        rdbnv.Checked = false;
                        rdbkhach.Checked = false;
                        txtmknv.Text = "";
                        panelpq.Enabled = false;
                        thongbao.Text = "";
                    }
                }
            }
            else
            {
                thongbao.Text = "Mật khẩu gồm 3 ký tự!";
            }
        }

        private void rdbqt_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Text == "Quản trị")
                id = "A";
            else
                if (rdb.Text == "Nhân viên")
                    id = "B";
                else
                    id = "C";
        }

        private void txtmknv_TextChanged(object sender, EventArgs e)
        {
            if (txtmknv.Text.Length != 3)
            {
                thongbao.Text = "Mật khẩu gồm 3 ký tự!";
            }
            else
            {
                thongbao.Text = "";
            }

        }
    }
}
