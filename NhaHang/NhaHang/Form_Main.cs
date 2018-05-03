using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSDLL;
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
        private void btn_kho_Click(object sender, EventArgs e)
        {
            NguyenLieu kh = new NguyenLieu();
            additem(kh, "Quản Lý Kho Nguyên Liệu");
        }
        private void btn_thucdon_Click(object sender, EventArgs e)
        {
            Form_MonAn kh = new Form_MonAn();
            additem(kh, "Quản Lý Mốn Ăn");
        }
        private void kHUVUCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHUVUCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.KHUVUC' table. You can move, or remove it, as needed.
            this.kHUVUCTableAdapter.Fill(this.dataDori.KHUVUC);
        }

        private void ribbonTabItem_goimon_Click(object sender, EventArgs e)
        {
            ribbonPanel5.Controls.Clear();
            this.kHUVUCTableAdapter.Fill(this.dataDori.KHUVUC);
            loadKhuvuc();
        }
        public void loadKhuvuc()
        {
            for (int i = 0; i < dataDori.KHUVUC.Rows.Count; i++)
            {
                taoKhu(dataDori.KHUVUC.Rows[i][1].ToString(), dataDori.KHUVUC.Rows[i][0].ToString());
            }
        }
        public void taoKhu(string ten, string ma)
        {
            RibbonBar bar = new RibbonBar();
            bar.Tag = ma.ToString();
            bar.MinimumSize = new Size(90, 90);
            bar.Size = new Size(97, 93);
            bar.Text = ten;
            Button btn = new Button();
            Image im = Image.FromFile(Application.StartupPath + "\\image\\icon2.png");
            btn.Image = im;
            btn.Width = 97;
            btn.Height = 80;
            btn.Click += btn_Click;
            btn.Tag = ma;
            bar.Controls.Add(btn);
            ribbonPanel5.Controls.Add(bar);
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bientoancuc.makhuvuc = (string)bt.Tag;
            Form_GoiMon kh = new Form_GoiMon();
            additem(kh, "Hệ Thống Quản Lý thông tin dịch vụ");
        }
    }
}
