using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace NhaHang
{
    public partial class Form_Main : Office2007RibbonForm
    {
        public Form_Main()
        {
            InitializeComponent();
        }
        //hàm dùng chung
        public void additem(Form kh, string s)
        {
            foreach (TabItem tabPage in tabControl1.Tabs)
                if (tabPage.Text == s)
                {
                    TabItem t = tabControl1.CreateTab(s);
                    kh.TopLevel = false;
                    kh.Dock = DockStyle.Fill;
                    t.AttachedControl.Controls.Add(kh);
                    kh.Show();
                    tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
                    //tabControl1.SelectedTab = tabPage;
                    tabControl1.Tabs.Remove(tabPage);
                    return;
                }
            TabItem tt = tabControl1.CreateTab(s);
            kh.TopLevel = false;
            kh.Dock = DockStyle.Fill;
            tt.AttachedControl.Controls.Add(kh);
            kh.Show();
            tabControl1.SelectedTabIndex = tabControl1.Tabs.Count - 1;
        }
        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Login login = new Form_Login();
            login.ShowDialog();
        }
        private void btn_doipass_Click(object sender, EventArgs e)
        {

        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("bạn có muốn đóng chương trình", "đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dl == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //quản lý khách hàng
        private void btn_khach_Click(object sender, EventArgs e)
        {
            FormKhachHang kh = new FormKhachHang();
            additem(kh, "Quản Lý Khách Hàng");
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            Form_NhanVien kh = new Form_NhanVien();
            additem(kh, "Quản Lý Khách Hàng");
        }

        private void btn_khuvuc_Click(object sender, EventArgs e)
        {
            Form_QLBan kh = new Form_QLBan();
            additem(kh, "Quản Lý Khách Hàng");
        }

        private void btn_nguyen_l_Click(object sender, EventArgs e)
        {
            Form_QLKhoNguyenLieu kh = new Form_QLKhoNguyenLieu();
            additem(kh, "Quản Lý Khách Hàng");
        }

        private void btn_addND_Click(object sender, EventArgs e)
        {
            Form_NhomND kh = new Form_NhomND();
            additem(kh, "Quản Lý Khách Hàng");
        }
        private void btn_phanquyen_Click(object sender, EventArgs e)
        {
            Form_PhanQuyen kh = new Form_PhanQuyen();
            additem(kh, "Quản Lý Khách Hàng");
        }
        //sự kiện đóng tab
        private void tabControl1_TabItemClose_1(object sender, TabStripActionEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn đóng tab " + tabControl1.SelectedTab.Text + "", "Đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dl == DialogResult.Yes)
            {
                tabControl1.Tabs.Remove(tabControl1.SelectedTab);
            }
        }
        //chỉnh mầu
        //chỉnh mầu
        private void buttonItem_metro_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
        }
        private void buttonItem_offic_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
        }
        private void btn_window_Click(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
        }
        private void customColorBlender1_SelectedColorChanged_1(object sender, EventArgs e)
        {
            styleManager1.ManagerColorTint = customColorBlender1.SelectedColor;
        }
    }
}
