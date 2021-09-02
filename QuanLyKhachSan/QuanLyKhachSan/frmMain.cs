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
using QuanLyKhachSan.GUI;

namespace QuanLyKhachSan
{
    public partial class frmMain : Form
    {
        AddTab clsAddTab= new AddTab();
        public static frmLogin flg;

        public frmMain()
        {
            InitializeComponent();
        }

        private void noLogin()
        {
            RibbonControl.Enabled = false;
            navBarControl.Enabled = false;
        }

        private void quyenB()
        {
            bbtnAdmin.Enabled = false;
            bbtnAddNV.Enabled = false;
        }

        private void quyenC()
        {
            bbtnAdmin.Enabled = false;
            bbtnAddNV.Enabled = false;
            bbtnAddKH.Enabled = false;
            bbtnQuanLyPhong.Enabled = false;
            bbtnDatPhong.Enabled = false;
            bbtnDSNV.Enabled = false;
            bbtnDSKH.Enabled = false;
            nbiThemkh.Enabled = false;
            nbiDatphong.Enabled = false;
            nbiThongtinKH.Enabled = false;
            nbiQuanlyphong.Enabled = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            if (frmLogin.qnv == "B")
            {
                quyenB();
            }
            if (frmLogin.qnv == "C")
            {
                quyenC();
            }
            UserLookAndFeel.Default.SetSkinStyle("Visual Studio 2013 Blue");
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl.TabPages)
            {
                if (tab.Text == "Home")
                {
                    xtraTabControl.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl, "Home", new Home_GUI());
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time.Caption = "Lúc này: "+DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }

        private void xtraTabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl.TabPages.Count > 0)
            {
                bandango.Caption = "Bạn đang ở: "+ e.Page.Text;
            }
            else
            {
                bandango.Caption = "Bạn đang ở: Home";
            }
        }

        private void bbtnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            this.Dispose(true);
            flg = new frmLogin();
            flg.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bbtnAddNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl.TabPages)
            {
                if (tab.Text == "Thêm nhân viên")
                {
                    xtraTabControl.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl, "Thêm nhân viên", new AddNV_GUI());
            }
        }

        private void bbtnAddKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl.TabPages)
            {
                if (tab.Text == "Thêm khách hàng")
                {
                    xtraTabControl.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl, "Thêm khách hàng", new AddKH_GUI());
            }
        }

        private void xtraTabControl_ControlAdded(object sender, ControlEventArgs e)
        {
            xtraTabControl.SelectedTabPageIndex = xtraTabControl.TabPages.Count - 1;
        }

        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControl.TabPages.RemoveAt(xtraTabControl.SelectedTabPageIndex);
        }

        private void nbiThemkh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl.TabPages)
            {
                if (tab.Text == "Thêm khách hàng")
                {
                    xtraTabControl.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl, "Thêm khách hàng", new AddKH_GUI());
            }
        }

        private void bbtnDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl.TabPages)
            {
                if (tab.Text == "Đặt phòng")
                {
                    xtraTabControl.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl, "Đặt phòng", new DatPhong_GUI());
            }
        }

        private void nbiDatphong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl.TabPages)
            {
                if (tab.Text == "Đặt phòng")
                {
                    xtraTabControl.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl, "Đặt phòng", new DatPhong_GUI());
            }
        }

        private void bbtnAddPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl.TabPages)
            {
                if (tab.Text == "Quản lý phòng")
                {
                    xtraTabControl.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl, "Quản lý phòng", new Phong_GUI());
            }
        }

        private void nbiThongtinphong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl.TabPages)
            {
                if (tab.Text == "Quản lý phòng")
                {
                    xtraTabControl.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl, "Quản lý phòng", new Phong_GUI());
            }
        }

        private void bbtnAdmin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl.TabPages)
            {
                if (tab.Text == "Quản trị viên")
                {
                    xtraTabControl.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl, "Quản trị viên", new Admin_GUI());
            }
        }

        private void nbiThongtinKH_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            int t = 0;
            foreach (DevExpress.XtraTab.XtraTabPage tab in xtraTabControl.TabPages)
            {
                if (tab.Text == "Thông tin khách hàng")
                {
                    xtraTabControl.SelectedTabPage = tab;
                    t = 1;
                }
            }
            if (t != 1)
            {
                clsAddTab.setTab(xtraTabControl, "Thông tin khách hàng", new InfoKH_GUI());
            }
        }

        private void bbtnDSNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmDSNV().Show();
        }

        private void bbtnDSKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmDSKH().Show();
        }
    }
}
