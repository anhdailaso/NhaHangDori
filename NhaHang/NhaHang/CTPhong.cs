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
    public partial class CTPhong : Office2007RibbonForm
    {
        public CTPhong()
        {
            InitializeComponent();
        }
        private void pHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pHONGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);

        }

        private void CTPhong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.KHUVUCPHONG' table. You can move, or remove it, as needed.
            this.kHUVUCPHONGTableAdapter.Fill(this.dataDori.KHUVUCPHONG);
            // TODO: This line of code loads data into the 'dataDori.LOAIPHONG' table. You can move, or remove it, as needed.
            this.lOAIPHONGTableAdapter.Fill(this.dataDori.LOAIPHONG);
            // TODO: This line of code loads data into the 'dataDori.LOAIPHONG' table. You can move, or remove it, as needed.
            this.lOAIPHONGTableAdapter.Fill(this.dataDori.LOAIPHONG);
            // TODO: This line of code loads data into the 'dataDori.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.dataDori.PHONG);
            maPHTextBoxX.Enabled = false;
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, true);


        }
        bool co;
        private void btnThem_Click(object sender, EventArgs e)
        {
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, false);
            co = true;
            tenPHTextBoxX.Focus();
            this.pHONGBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.dataDori);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("bạn có muốn xóa phòng này", "xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
                {
                    this.pHONGBindingSource.RemoveCurrent();
                    this.tableAdapterManager.UpdateAll(this.dataDori);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("bạn không thể xóa khách hàng này");
                this.pHONGTableAdapter.Fill(this.dataDori.PHONG);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, false);
            tenPHTextBoxX.Focus();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pHONGBindingSource.EndEdit();
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
            this.pHONGBindingSource.CancelEdit();
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, true);

        }

        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
