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
    public partial class NguyenLieu : Office2007RibbonForm
    {
        public NguyenLieu()
        {
            InitializeComponent();
        }

        private void nGUYENLIEUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUYENLIEUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);

        }

        private void NguyenLieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.NCC' table. You can move, or remove it, as needed.
            this.nCCTableAdapter.Fill(this.dataDori.NCC);
            // TODO: This line of code loads data into the 'dataDori.NCC' table. You can move, or remove it, as needed.
            this.nCCTableAdapter.Fill(this.dataDori.NCC);
            // TODO: This line of code loads data into the 'dataDori.NGUYENLIEU' table. You can move, or remove it, as needed.
            this.nGUYENLIEUTableAdapter.Fill(this.dataDori.NGUYENLIEU);
            maNLTextBox.Enabled = false;
            kLTonTextBox.Enabled = false;
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, true);

        }
        bool co;
        private void btnThem_Click(object sender, EventArgs e)
        {
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, false);
            co = true;
            tenNLTextBox.Focus();
            this.nGUYENLIEUBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.dataDori);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //nGUOIDUNGTableAdapter.DeleteQueryND(tenDangNhapTextBox.Text);
                nGUYENLIEUBindingSource.RemoveCurrent();
                tableAdapterManager.UpdateAll(dataDori);
            }
            catch
            {
                MessageBox.Show("Không thể Xóa nguyên liệu này");
                this.nGUYENLIEUTableAdapter.Fill(this.dataDori.NGUYENLIEU);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, false);
            tenNLTextBox.Focus();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.nGUYENLIEUBindingSource.EndEdit();
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
            nGUYENLIEUBindingSource.CancelEdit();
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
    }
}
