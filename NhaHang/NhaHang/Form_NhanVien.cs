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
    public partial class Form_NhanVien : Office2007RibbonForm
    {
        public Form_NhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);

        }

        private void Form_NhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.dataDori.NGUOIDUNG);
            // TODO: This line of code loads data into the 'dataDori.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.dataDori.NGUOIDUNG);
            // TODO: This line of code loads data into the 'dataDori.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.dataDori.NHANVIEN);

            maNVTextBox.Enabled = false;
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, true);

        }
        bool co;
        private void btnThem_Click(object sender, EventArgs e)
        {
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, false);
            co = true;
            tenNVTextBox.Focus();
            this.nHANVIENBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.dataDori);

        }
       
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //nGUOIDUNGTableAdapter.DeleteQueryND(tenDangNhapTextBox.Text);
                nHANVIENBindingSource.RemoveCurrent();
                tableAdapterManager.UpdateAll(dataDori);
            }
            catch
            {
                MessageBox.Show("Không thể Xóa Nhân Viên Này");
                this.nHANVIENTableAdapter.Fill(this.dataDori.NHANVIEN);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, false);
            tenNVTextBox.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            nHANVIENBindingSource.CancelEdit();
            xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, true);
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.nHANVIENBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dataDori);
                if (co==true)
                {
                    nGUOIDUNGTableAdapter.Insert(tenDangNhapTextBox.Text, "1", true);
                }
                xulianhien.Instance.battac(btnThem, btn_xoa, btnSua, btnHuy, btn_Luu, panel_tt, true);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
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

        private void nHANVIENBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);

        }
    }
}
