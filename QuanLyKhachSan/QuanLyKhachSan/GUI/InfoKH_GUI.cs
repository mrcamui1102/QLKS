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
using QuanLyKhachSan.DAL;

namespace QuanLyKhachSan.GUI
{
    public partial class InfoKH_GUI : DevExpress.XtraEditors.XtraUserControl
    {
        DBAccess db = new DBAccess();
        string and_or1 = "";
        string and_or2 = "";
        string dk0 = "";
        string dk1 = "";
        string dk2 = "";
        string dk3 = "";
        string txt0 = "";
        string txt1 = "";
        string txt2 = "";
        string txt3 = "";
        public InfoKH_GUI()
        {
            InitializeComponent();
        }

        private void gettxtcb()
        {
            txt0 = txtCoBan.Text;
        }

        private void gettxtnc()
        {
            txt1 = txtNangCao1.Text;
            txt2 = txtNangCao2.Text;
            txt3 = txtNangCao3.Text;
        }

        private void getData1(string dk, string txt)
        {
            dgvkh.DataBindings.Clear();
            string sql = "Select * From khachhang Where " + dk + " like '%" + txt + "%'";
            DataTable dtb = db.getDS(sql);
            dgvkh.DataSource = dtb;
        }

        private void getData2(string dk1, string dk2, string txt1, string txt2, string ao1)
        {
            dgvkh.DataBindings.Clear();
            string sql = "Select * From khachhang Where " + dk1 + " like '%" + txt1 + "%' " + ao1 + " " + dk2 + " like '%" + txt2 + "%'";
            DataTable dtb = db.getDS(sql);
            dgvkh.DataSource = dtb;
        }

        private void getData3(string dk1, string dk2, string dk3, string txt1, string txt2, string txt3, string ao1, string ao2)
        {
            dgvkh.DataBindings.Clear();
            string sql = "Select * From khachhang Where " + dk1 + " like '%" + txt1 + "%' " + ao1 + " " + dk2 + " like '%" + txt2 + "%' " + ao2 + " " + dk3 + " like '%" + txt3 + "%'";
            DataTable dtb = db.getDS(sql);
            dgvkh.DataSource = dtb;
        }

        private void btnCoBan_Click(object sender, EventArgs e)
        {
            gettxtcb();
            if (dk0 == "")
            {
                MessageBox.Show("Chưa chọn điều kiện!");
            }
            else
            {
                getData1(dk0, txt0);
            }

        }

        private void btnNangCao_Click(object sender, EventArgs e)
        {
            gettxtnc();
            if(dk1 == "" && dk2 == "" && dk3 == ""){
                MessageBox.Show("Chọn ít nhất 1 điều kiện!");
            }
            else
            {
                if (dk1 != "" && dk2 == "" && dk3 == "")
                {
                    getData1(dk1,txt1);
                }
                else
                {
                    if (dk1 == "" && dk2 != "" && dk3 == "")
                    {
                        getData1(dk2, txt2);
                    }
                    else
                    {
                        if (dk1 == "" && dk2 == "" && dk3 != "")
                        {
                            getData1(dk3, txt3);
                        }
                    }
                }

            }

            if (dk1 != "" && dk2 != "" && dk3 != "")
            {
                if (and_or1 == "" || and_or2 == "")
                {
                    MessageBox.Show("Chọn 2 điều kiện kết hợp AND và OR");
                }
                else
                {
                    getData3(dk1, dk2, dk3, txt1, txt2, txt3, and_or1, and_or2);
                }
            }
            else
            {
                if (dk1 != "" && dk2 != "" && dk3 == "")
                {
                    if (and_or1 == "")
                    {
                        MessageBox.Show("Chọn 1 điều kiện kết hợp AND và OR");
                    }
                    else
                    {
                        getData2(dk1, dk2, txt1, txt2, and_or1);
                    }
                }
                else
                {
                    if (dk1 == "" && dk2 != "" && dk3 != "")
                    {
                        if (and_or2 == "")
                        {
                            MessageBox.Show("Chọn 1 điều kiện kết hợp AND và OR");
                        }
                        else
                        {
                            getData2(dk2, dk3, txt2, txt3, and_or2);
                        }
                    }
                }
            }
        }

        private void cbDkDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            dk0 = cbDkDG.SelectedItem.ToString();
        }

        private void cbDkNC1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dk1 = cbDkNC1.SelectedItem.ToString();
        }

        private void cbDkNC2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dk2 = cbDkNC2.SelectedItem.ToString();
        }

        private void cbDkNC3_SelectedIndexChanged(object sender, EventArgs e)
        {
            dk3 = cbDkNC3.SelectedItem.ToString();
        }

        private void cbAO1_SelectedIndexChanged(object sender, EventArgs e)
        {
            and_or1 = cbAO1.SelectedItem.ToString();
        }

        private void cbAO2_SelectedIndexChanged(object sender, EventArgs e)
        {
            and_or2 = cbAO2.SelectedItem.ToString();
        }
    }
}
