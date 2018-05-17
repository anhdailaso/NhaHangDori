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
    public partial class CTBan : Office2007RibbonForm
    {
        public CTBan()
        {
            InitializeComponent();
        }

        private void bANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);

        }

        private void CTBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.KHUVUCBAN' table. You can move, or remove it, as needed.
            this.kHUVUCBANTableAdapter.Fill(this.dataDori.KHUVUCBAN);
            // TODO: This line of code loads data into the 'dataDori.KHUVUCBAN' table. You can move, or remove it, as needed.
            this.kHUVUCBANTableAdapter.Fill(this.dataDori.KHUVUCBAN);
            // TODO: This line of code loads data into the 'dataDori.KHUVUCBAN' table. You can move, or remove it, as needed.
            this.kHUVUCBANTableAdapter.Fill(this.dataDori.KHUVUCBAN);
            // TODO: This line of code loads data into the 'dataDori.BAN' table. You can move, or remove it, as needed.
            this.bANTableAdapter.Fill(this.dataDori.BAN);
            maBTextBoxX.Enabled = false;
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, true);


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, false);
            this.bANBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.dataDori);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("bạn có muốn xóa bàn này", "xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
                {
                    this.bANBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(this.dataDori);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("bạn không thể xóa khách hàng này");
                this.bANTableAdapter.Fill(this.dataDori.BAN);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, false);

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.bANBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataDori);
                xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, true);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.bANBindingSource.CancelEdit();
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, true);
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
