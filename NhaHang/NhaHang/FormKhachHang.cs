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
    public partial class FormKhachHang : Office2007RibbonForm
    {
        bool co = true;
        public FormKhachHang()
        {
            InitializeComponent();
        }
        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);
        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.LOAIKH' table. You can move, or remove it, as needed.
            this.lOAIKHTableAdapter.Fill(this.dataDori.LOAIKH);
            // TODO: This line of code loads data into the 'dataDori.LOAIKH' table. You can move, or remove it, as needed.
            this.lOAIKHTableAdapter.Fill(this.dataDori.LOAIKH);
            // TODO: This line of code loads data into the 'dataDori.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.dataDori.KHACHHANG);
            maKHTextBoxX.Enabled = false;
            xulianhien.Instance.battac(btn_them, btn_xoa, btn_sua,btn_huy, btn_luu, panel_tt, true);
        }
            
        private void btn_them_Click(object sender, EventArgs e)
        {
            xulianhien.Instance.battac(btn_them, btn_xoa, btn_sua, btn_huy, btn_luu, panel_tt, false);
            co = true;
            tenKHTextBoxX.Focus();
            this.kHACHHANGBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.dataDori);

            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("bạn có muốn xóa khách hàng này", "xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
                {
                    this.kHACHHANGBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(this.dataDori);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("bạn không thể xóa khách hàng này");
                this.kHACHHANGTableAdapter.Fill(this.dataDori.KHACHHANG);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            xulianhien.Instance.battac(btn_them, btn_xoa, btn_sua, btn_huy, btn_luu, panel_tt, false);
            tenKHTextBoxX.Focus();
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.kHACHHANGBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataDori);
                xulianhien.Instance.battac(btn_them, btn_xoa, btn_sua, btn_huy, btn_luu, panel_tt, true);
            }
            catch(Exception ex)
            {
                throw (ex); 
            }

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.kHACHHANGBindingSource.CancelEdit();
            xulianhien.Instance.battac(btn_them, btn_xoa, btn_sua, btn_huy, btn_luu, panel_tt, true);
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.kHACHHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                kHACHHANGTableAdapter.FillBy(this.dataDori.KHACHHANG, "%" + textBoxX1.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
