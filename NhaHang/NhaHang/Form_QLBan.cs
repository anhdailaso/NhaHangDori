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
    public partial class Form_QLBan : Office2007RibbonForm
    {
        bool co = true;
        public Form_QLBan()
        {
            InitializeComponent();
        }

        private void kHUVUCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHUVUCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);
        }
        private void Form_QLBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.BAN' table. You can move, or remove it, as needed.
            this.bANTableAdapter.Fill(this.dataDori.BAN);
            // TODO: This line of code loads data into the 'dataDori.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.dataDori.PHONG);
            this.kHUVUCTableAdapter.Fill(this.dataDori.KHUVUC);
            maKVTextBoxX.Enabled = false;
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel6, true);
            loadkv();
        }
        public void loadkv()
        {
            tabControl1.Tabs.Clear();
            for (int i = 0; i < dataDori.KHUVUC.Rows.Count; i++)
            {
               TabItem newTab = tabControl1.CreateTab(dataDori.KHUVUC.Rows[i][1].ToString());
                newTab.Click += NewTab_Click;
                TabControlPanel panel = (TabControlPanel)newTab.AttachedControl;
                FlowLayoutPanel flow = new FlowLayoutPanel();
                flow.Dock = DockStyle.Fill;
                if (dataDori.KHUVUC.Rows[i][2].ToString() == "ban")
                {
                    loadban(Convert.ToInt32(dataDori.KHUVUC.Rows[i][0].ToString()), flow);
                }
            else
                {
                    loadphong(Convert.ToInt32(dataDori.KHUVUC.Rows[i][0].ToString()), flow);
                }
                panel.Controls.Add(flow);
            }
        }

        private void NewTab_Click(object sender, EventArgs e)
        {
           if(sender is TabItem)
            {
                string tinhtrang = dataDori.KHUVUC.Where(p => p.TenKV.Equals(sender.ToString())).Select(p => p.TinhTrang).FirstOrDefault().ToString();
                bientoancuc.loaikhu = tinhtrang;
            }
        }

        public void loadban(int makhu, FlowLayoutPanel flow)
        {
            var ban = dataDori.BAN.Where(p=>p.MaKV.Equals(makhu)).ToList();
            foreach (var item in ban)
            {
                Button a = new Button();
                //a.Image = Image.FromFile(@"C:\Users\truon\Desktop\winform\NhaHang\NhaHang\image\bantrong.png");
                a.Image = Image.FromFile(Application.StartupPath + "\\image\\bantrong.png");
                a.Size = new Size(134, 117);
                a.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                a.TextAlign = ContentAlignment.BottomCenter;
                a.ForeColor = Color.Red;
                a.Text = item.MaB.ToString();
                flow.Controls.Add(a);
            }
        }
        public void loadphong(int makhu, FlowLayoutPanel flow)
        {
            var ban = dataDori.PHONG.Where(p => p.MaKV.Equals(makhu)).ToList();
            
            foreach (var item in ban)
            {
                Button a = new Button();
                //a.Image = Image.FromFile(@"C:\Users\truon\Desktop\winform\NhaHang\NhaHang\image\bantrong.png");
                if (item.MaLP == 1)
                {
                    a.Image = Image.FromFile(Application.StartupPath + "\\image\\cuavang.jpg");
                }
                else
                {
                    a.Image = Image.FromFile(Application.StartupPath + "\\image\\cuado.jpg");
                }
                a.Size = new Size(134, 117);
                a.Font = new Font("Microsoft Sans Serif", 15, FontStyle.Bold);
                a.TextAlign = ContentAlignment.BottomCenter;
                a.ForeColor = Color.Blue;
                a.Text = item.TenPH.ToString();
                System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
                // Set up the delays for the ToolTip.
                toolTip1.AutoPopDelay = 5000;
                toolTip1.InitialDelay = 1000;
                toolTip1.ReshowDelay = 500;
                // Force the ToolTip text to be displayed whether or not the form is active.
                toolTip1.ShowAlways = true;
                // Set up the ToolTip text for the Button and Checkbox.
                toolTip1.SetToolTip(a, "Số lượng có thể chứa là : "+item.SucChua.ToString()+"");
                flow.Controls.Add(a);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel6, false);
            co = true;
            tenKVTextBoxX.Focus();
            this.kHUVUCBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.dataDori);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("bạn có muốn xóa khách hàng này", "xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
                {
                    this.kHUVUCBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(this.dataDori);
                    loadkv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("bạn không thể xóa khách hàng này");
                this.kHUVUCTableAdapter.Fill(this.dataDori.KHUVUC);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel6, false);
            tenKVTextBoxX.Focus();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.kHUVUCBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataDori);
                xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel6, true);
                loadkv();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.kHUVUCBindingSource.CancelEdit();
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel6, true);
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (bientoancuc.loaikhu == "ban")
            {
                CTBan ban = new CTBan();
                ban.ShowDialog();
            }
            else
            {
                CTPhong phong = new CTPhong();
                phong.ShowDialog();
            }
        }
        private void reloatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.BAN' table. You can move, or remove it, as needed.
            this.bANTableAdapter.Fill(this.dataDori.BAN);
            // TODO: This line of code loads data into the 'dataDori.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.dataDori.PHONG);
            this.kHUVUCTableAdapter.Fill(this.dataDori.KHUVUC);
            loadkv();
        }
    }
}
