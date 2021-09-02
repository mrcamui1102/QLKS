using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyKhachSan.DAL;
using Microsoft.Reporting.WinForms;
using QuanLyKhachSan.GUI;

namespace QuanLyKhachSan
{
    public partial class frmReportHD : DevExpress.XtraEditors.XtraForm
    {
        DBAccess db = new DBAccess();

        public frmReportHD()
        {
            InitializeComponent();
        }

        private void frmReportHD_Load(object sender, EventArgs e)
        {
            bind();
            this.rpvHoadon.RefreshReport();
        }

        private DataTable getdata(string madp)
        {
            string sql = "select hd.mahd,hd.ngaylap,dp.madp,dp.makh,kh.hoten,dp.tenlp,dp.soluong,dp.ngayden,dp.ngaydi,hd.tongtien from hoadon as hd,datphong as dp,khachhang as kh where hd.madp=dp.madp and dp.makh = kh.makh and hd.madp = '" + madp + "'";
            DataTable dtb = db.getDS(sql);
            return dtb;
        }

        private void bind()
        {
            rpvHoadon.LocalReport.ReportEmbeddedResource = "QuanLyKhachSan.ReportHoaDon.rdlc";
            rpvHoadon.LocalReport.DataSources.Clear();
            ReportDataSource rpDataSource = new ReportDataSource("DataSetHoaDon", getdata(DatPhong_GUI.madatphong));
            rpvHoadon.LocalReport.DataSources.Add(rpDataSource);
            rpvHoadon.RefreshReport();
        }

        private void rpvHoadon_Load(object sender, EventArgs e)
        {

        }
    }
}