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
            additem(kh, "Quản Lý Nhân Viên");
        }

        private void btn_khuvuc_Click(object sender, EventArgs e)
        {
            Form_QLBan kh = new Form_QLBan();
            additem(kh, "Quản Lý Khu Vực");
        }

        private void btn_nguyen_l_Click(object sender, EventArgs e)
        {
            Form_QLKhoNguyenLieu kh = new Form_QLKhoNguyenLieu();
            additem(kh, "Quản Lý Nguyên Liệu");
        }

        private void btn_addND_Click(object sender, EventArgs e)
        {
            Form_NhomND kh = new Form_NhomND();
            additem(kh, "Quản Lý Thêm Người Dùng");
        }
        private void btn_phanquyen_Click(object sender, EventArgs e)
        {
            Form_PhanQuyen kh = new Form_PhanQuyen();
            additem(kh, "Phân Quyền Hệ Thống");
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
            // TODO: This line of code loads data into the 'dataDori.NGUOIDUNGNHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGNHOMNGUOIDUNGTableAdapter.Fill(this.dataDori.NGUOIDUNGNHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'dataDori.PHANQUYEN' table. You can move, or remove it, as needed.
            this.pHANQUYENTableAdapter.Fill(this.dataDori.PHANQUYEN);
            // TODO: This line of code loads data into the 'dataDori.KHUVUC' table. You can move, or remove it, as needed.
            this.kHUVUCTableAdapter.Fill(this.dataDori.KHUVUC);
            loadKhuvuc();
            List<string> nhomND = getma();
            foreach (string item in nhomND)
            {
                int n = (int)pHANQUYENTableAdapter.GetDataPQ(Convert.ToInt32(item.ToString())).Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    string s = pHANQUYENTableAdapter.GetDataPQ(Convert.ToInt32(item)).Rows[i][1].ToString().Trim();
                    suli(s, Convert.ToBoolean(pHANQUYENTableAdapter.GetDataPQ(Convert.ToInt32(item)).Rows[i][2].ToString()));
                }
            }
            // TODO: This line of code loads data into the 'dataDori.NGUOIDUNGNHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGNHOMNGUOIDUNGTableAdapter.Fill(this.dataDori.NGUOIDUNGNHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'dataDori.PHANQUYEN' table. You can move, or remove it, as needed.
            this.pHANQUYENTableAdapter.Fill(this.dataDori.PHANQUYEN);
            // TODO: This line of code loads data into the 'dataDori.KHUVUC' table. You can move, or remove it, as needed.
            this.kHUVUCTableAdapter.Fill(this.dataDori.KHUVUC);
        }
        private List<String> getma()
        {
            List<String> a = new List<string>();
            for (int i = 0; i < nGUOIDUNGNHOMNGUOIDUNGTableAdapter.manguoidung(bientoancuc.tendn).Rows.Count; i++)
            {
                a.Add(nGUOIDUNGNHOMNGUOIDUNGTableAdapter.manguoidung(bientoancuc.tendn).Rows[i][0].ToString());
            }
            return a;
        }
        public void suli(string maMH, bool x)
        {
            if (x == false)
            {
                foreach (BaseItem item in ribbonControl1.Items)
                {
                    RibbonTabItem ribbonTab = item as RibbonTabItem;

                    if (ribbonTab != null)
                    {
                        RibbonPanel panel = ribbonTab.Panel;

                        foreach (Control panelControl in panel.Controls)
                        {
                            RibbonBar ribbonBar = panelControl as RibbonBar;

                            if (ribbonBar != null && Convert.ToString(ribbonBar.Tag) == maMH)
                            {
                                foreach (BaseItem items in ribbonBar.Items)
                                {
                                    items.Enabled = false;
                                }
                                foreach (var itema in maMH)
                                {

                                }
                                //foreach (BaseItem ribbonBarItem in ribbonBar.Items)
                                //    ribbonBarItem.Enabled = false;
                            }
                        }
                    }
                }
            }
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
            var loai = dataDori.KHUVUC.Where(p => p.MaKV.Equals(Convert.ToInt32(bt.Tag))).Select(p => p.TinhTrang).FirstOrDefault();
            if (loai == "ban")
            {
                Form_GoiMon kh = new Form_GoiMon();
                additem(kh, "Hệ Thống Quản Lý Dịch Vụ Bàn");
            }
            else
            {
                Form_PhongAn kh = new Form_PhongAn();
                additem(kh, "Hệ Thống Quản Lý Phòng");
            }
        }
        private void buttonItem_metro_Click_1(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
        }

        private void buttonItem_offic_Click_1(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
        }

        private void btn_window_Click_1(object sender, EventArgs e)
        {
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
        }

        private void customColorBlender1_SelectedColorChanged(object sender, EventArgs e)
        {
            styleManager1.ManagerColorTint = customColorBlender1.SelectedColor;
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            Form_ThongKe kh = new Form_ThongKe();
            additem(kh, "Thống Kê Hóa Đơn Phiếu Nhập");
        }

        private void btn_addND_Click_1(object sender, EventArgs e)
        {
            Form_NhomND kh = new Form_NhomND();
            additem(kh, "Thêm Người Dùng vào Nhóm Người Dùng");
        }

        private void btn_tonkho_Click(object sender, EventArgs e)
        {
            Form_TonKho kh = new Form_TonKho();
            additem(kh, "Thêm Thống Kê Tồn Kho");
        }
    }
}
