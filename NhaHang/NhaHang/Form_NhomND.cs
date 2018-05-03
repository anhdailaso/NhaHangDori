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
    public partial class Form_NhomND : Office2007RibbonForm
    {
        public Form_NhomND()
        {
            InitializeComponent();
            btn_Xoa.Enabled = false;
            btn_update.Enabled = false;

        }

        private void nGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);

        }

        private void Form_NhomND_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.dataDori.NHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'dataDori.NGUOIDUNGNHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGNHOMNGUOIDUNGTableAdapter.Fill(this.dataDori.NGUOIDUNGNHOMNGUOIDUNG);
            // TODO: This line of code loads data into the 'dataDori.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.dataDori.NGUOIDUNG);
            loadND();
            //loadcompobox();
        }

        //tạo bút tun người dùng
        public void taoND(Button nd)
        {
            nd.BackgroundImage = new Bitmap(Application.StartupPath + @"\image\User2.png");
            nd.Size = new Size(106, 122);
            nd.BackgroundImageLayout = ImageLayout.None;
            nd.TextAlign = ContentAlignment.BottomCenter;
            flowLayoutPanel1.Controls.Add(nd);
            nd.Click += nd_Click;
        }
        //kiểm tra đã chọn hay chưa
        void nd_Click(object sender, EventArgs e)
        {
            Button a = sender as Button;
            a.BackgroundImage = new Bitmap(Application.StartupPath + @"\image\User.png");
            a.Tag = a.Text;
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    item.Enabled = false;
                }
            }
        }
        //load người dùng
        public void loadND()
        {

            for (int i = 0; i < this.dataDori.NGUOIDUNG.Rows.Count; i++)
            {
                Button nd = new Button();
                nd.Text = this.dataDori.NGUOIDUNG.Rows[i][0].ToString();
                taoND(nd);
                eneable(false);
            }
            //flowLayoutPanel1.Enabled = false;

        }
        public void eneable(bool a)
        {
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    item.Enabled = a;
                    item.Tag = "";
                }
            }
        }
        private void update()
        {
            try
            {

                this.nGUOIDUNGNHOMNGUOIDUNGTableAdapter.FillByMaNhomMD(this.dataDori.NGUOIDUNGNHOMNGUOIDUNG, Convert.ToInt32(cbb_TenNhom.SelectedValue.ToString()));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cbb_TenNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
            
        }

        private void btn_Thêm_Click(object sender, EventArgs e)
        {
            eneable(true);
            btn_update.Enabled = true;
            btn_Thêm.Enabled = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (nGUOIDUNGNHOMNGUOIDUNGDataGridViewX.Rows.Count == 0)
                MessageBox.Show("cần chọn dữ liệu cần xóa");
            else
            {
                nGUOIDUNGNHOMNGUOIDUNGTableAdapter.DeleteQueryNguoiDungNhomNguoiDung(Convert.ToInt32(nGUOIDUNGNHOMNGUOIDUNGDataGridViewX.CurrentRow.Cells[0].Value.ToString()), nGUOIDUNGNHOMNGUOIDUNGDataGridViewX.CurrentRow.Cells[1].Value.ToString());
                DialogResult dl = MessageBox.Show("xóa thành công", "delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (dl == DialogResult.OK)
                {
                    update();
                }
            }
        }
        public string user()
        {
            string s = "";
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    if (item.Tag.ToString() != "")
                    {
                        s = item.Text;
                    }
                }

            }
            return s;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            btn_update.Enabled = false;
            btn_Thêm.Enabled = true;
            //đang cập nhât
            try
            {
                nGUOIDUNGNHOMNGUOIDUNGTableAdapter.Insert(Convert.ToInt32(cbb_TenNhom.SelectedValue.ToString()), user(), "có quyền trong phạm vi nào đó");
                DialogResult dl = MessageBox.Show("Thêm thành công", "delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                if (dl == DialogResult.OK)
                {
                    update();
                }
            }
            catch
            {
                DialogResult dl = MessageBox.Show("Thêm Thất bại , trùng", "delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // sâu khi cập nhât
            flowLayoutPanel1.Controls.Clear();
            loadND();
            eneable(false);
        }

        private void nGUOIDUNGNHOMNGUOIDUNGDataGridViewX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Xoa.Enabled = true;
        }
    }
}
