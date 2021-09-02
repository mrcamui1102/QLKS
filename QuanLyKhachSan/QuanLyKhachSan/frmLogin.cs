using DevExpress.LookAndFeel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.DAL;


namespace QuanLyKhachSan
{
    public partial class frmLogin : Form
    {
        public static string qnv = "";
        public static string mnv = "";
        public static frmMain fm;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Visual Studio 2013 Blue");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            string strGetAd = "Select * From quyennv Where manv = '" + txtUser.Text + "' and matkhau = '" + txtPass.Text + "'";
            try
            {
                DBAccess d = new DBAccess();
                DataTable dtb = d.getDS(strGetAd);
                if (dtb.Rows.Count > 0)
                {
                    DataRow q = dtb.Rows[0];
                    mnv = q["manv"].ToString();
                    qnv = q["id"].ToString();
                    string sql = "Select hoten From nhanvien Where manv = '" + txtUser.Text + "'";
                    DataTable dt = d.getDS(sql);
                    DataRow r = dt.Rows[0];
                    MessageBox.Show("Xin chào " + r["hoten"].ToString() + "!","Xin chào",MessageBoxButtons.OK);
                    this.Hide();
                    this.Dispose(false);
                    fm = new frmMain();
                    fm.Show();
                }
                else
                    MessageBox.Show("Mã nhân viên hoặc mật khẩu không chính xác!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
