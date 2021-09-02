using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    class AddTab
    {
        public void setTab(DevExpress.XtraTab.XtraTabControl XtraTabCha, string TabNameAdd, System.Windows.Forms.UserControl UserControl)
        {
            DevExpress.XtraTab.XtraTabPage TAbAdd = new DevExpress.XtraTab.XtraTabPage();
            TAbAdd.Name = "TestTab";
            TAbAdd.Text = TabNameAdd;
            TAbAdd.Controls.Add(UserControl);
            UserControl.Dock = DockStyle.Fill;
            XtraTabCha.TabPages.Add(TAbAdd);
        }
    }
}
