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
using BUSDLL;

namespace NhaHang
{
    public partial class Form_MonAn : Office2007RibbonForm
    {
        public Form_MonAn()
        {
            InitializeComponent();
        }
        private void mONANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mONANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);
        }
        private void Form_MonAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.NGUYENLIEU' table. You can move, or remove it, as needed.
            this.nGUYENLIEUTableAdapter.Fill(this.dataDori.NGUYENLIEU);
            // TODO: This line of code loads data into the 'dataDori.CT_CONGTHUC' table. You can move, or remove it, as needed.
            //this.cT_CONGTHUCTableAdapter.FillByMa(this.dataDori.CT_CONGTHUC,(int)mONANDataGridViewX.CurrentRow.Cells[0].Value);
            // TODO: This line of code loads data into the 'dataDori.CONGTHUCMA' table. You can move, or remove it, as needed.
            this.cONGTHUCMATableAdapter.Fill(this.dataDori.CONGTHUCMA);
            // TODO: This line of code loads data into the 'dataDori.NHOMMA' table. You can move, or remove it, as needed.
            this.nHOMMATableAdapter.Fill(this.dataDori.NHOMMA);
            // TODO: This line of code loads data into the 'dataDori.MONAN' table. You can move, or remove it, as needed.
            this.mONANTableAdapter.Fill(this.dataDori.MONAN);
            maMATextBoxX.Enabled = false;
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, true);
            tatcanguyenlieu();
            battac(buttonX1, buttonX2, panel11, true);
        }
        public void tatcanguyenlieu()
        {
            var nl = dataDori.NGUYENLIEU.Select(p => p).ToList();
            foreach (var item in nl)
            {
                ShowNguyenLieu snl = new ShowNguyenLieu();
                int sl = item.KLTon.ToString() == "" ? 0 : (int)(item.KLTon);
                snl.loadmonnguyenlieu((Byte[])item.HinhAnh, item.TenNL.ToString(),12,item.MaNL.ToString());
                snl.PicherClick += snl_PicherClick;
                flowLayoutPanel1.Controls.Add(snl);
            }
        }
        void snl_PicherClick(object sender, EventArgs e)
        {
            maNLTextBoxX.Text = bientoancuc.manguyenlieu;
            //try
            //{
            //    this.cT_CONGTHUCTableAdapter.FillByMa(this.dataDori.CT_CONGTHUC, Convert.ToInt32(bientoancuc.manguyenlieu));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }
        bool co;
        private void btnThem_Click(object sender, EventArgs e)
        {
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, false);
            co = true;
            tenMATextBoxX.Focus();
            this.mONANBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.dataDori);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //nGUOIDUNGTableAdapter.DeleteQueryND(tenDangNhapTextBox.Text);
                mONANBindingSource.RemoveCurrent();
                tableAdapterManager.UpdateAll(dataDori);
            }
            catch
            {
                MessageBox.Show("Không thể Xóa Nhân Viên Này");
                this.mONANTableAdapter.Fill(this.dataDori.MONAN);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, false);
            tenMATextBoxX.Focus();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.mONANBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataDori);
                if (co == true)
                {
                    cONGTHUCMATableAdapter.Insert(Convert.ToInt32(maMATextBoxX.Text.ToString()));
                }
                xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, true);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            mONANBindingSource.CancelEdit();
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, true);
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(file))
                return;
            Image img = Image.FromFile(file);
            hinhAnhPictureBox.Image = img;
        }
        private void mONANDataGridViewX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cT_CONGTHUCTableAdapter.FillByMa(this.dataDori.CT_CONGTHUC, (int)mONANDataGridViewX.CurrentRow.Cells[0].Value);
        }
        //rresset
        public void resset()
        {
            foreach (ShowNguyenLieu item in flowLayoutPanel1.Controls) item.Dispose();
            {
                flowLayoutPanel1.Controls.Clear();
            }
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                nGUYENLIEUTableAdapter.FillByTen(this.dataDori.NGUYENLIEU, "%" + textBoxX1.Text + "%");
                resset();
                tatcanguyenlieu();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            battac(buttonX1, buttonX2, panel11, false);
            co = true;
            khoiLuongTextBoxX.Focus();
            this.cT_CONGTHUCBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.dataDori);
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                cT_CONGTHUCBindingSource.RemoveCurrent();
                tableAdapterManager.UpdateAll(dataDori);
            }
            catch
            {
                MessageBox.Show("Không thể Xóa Nhân nguyên liệu này");
                this.mONANTableAdapter.Fill(this.dataDori.MONAN);
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.cT_CONGTHUCBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataDori);
                battac(buttonX1, buttonX2, panel11, true);
            }
            catch (Exception ex)
            {
                cT_CONGTHUCBindingSource.CancelEdit();
                battac(buttonX1, buttonX2, panel11, true);
            }
        }
        public void battac(ButtonX them, ButtonX sua, Panel dulieu, bool a)
        {
            them.Enabled = sua.Enabled = a;
            dulieu.Enabled = !a;
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
