using System;
using System.Data;
using Microsoft.Reporting.WinForms;
using QuanLyKhachSan.DAL;
namespace QuanLyKhachSan
{
    public partial class frmDSKH : DevExpress.XtraEditors.XtraForm
    {
        DBAccess db = new DBAccess();
        public frmDSKH()
        {
            InitializeComponent();
        }
        private DataTable getdata()
        {
            string sql = "select * from khachhang";
            DataTable dtb = db.getDS(sql);
            return dtb;
        }

        private void bind()
        {
            rpvDSKH.LocalReport.ReportEmbeddedResource = "QuanLyKhachSan.ReportDSKH.rdlc";
            rpvDSKH.LocalReport.DataSources.Clear();
            ReportDataSource rpDataSource = new ReportDataSource("DataSetKhachHang", getdata());
            rpvDSKH.LocalReport.DataSources.Add(rpDataSource);
            rpvDSKH.RefreshReport();
        }
        private void frmDSKH_Load(object sender, EventArgs e)
        {
            bind();
            this.rpvDSKH.RefreshReport();
        }
    }
}