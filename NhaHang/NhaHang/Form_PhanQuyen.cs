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
    public partial class Form_PhanQuyen : Office2007RibbonForm
    {
        int manguoidung;
        public Form_PhanQuyen()
        {
            InitializeComponent();
        }

        private void Form_PhanQuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.MANHINH' table. You can move, or remove it, as needed.
            this.mANHINHTableAdapter.Fill(this.dataDori.MANHINH);
            // TODO: This line of code loads data into the 'dataDori.PHANQUYEN' table. You can move, or remove it, as needed.
            this.pHANQUYENTableAdapter.Fill(this.dataDori.PHANQUYEN);
            // TODO: This line of code loads data into the 'dataDori.NHOMNGUOIDUNG' table. You can move, or remove it, as needed.
            this.nHOMNGUOIDUNGTableAdapter.Fill(this.dataDori.NHOMNGUOIDUNG);

        }

        private void nHOMNGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHOMNGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);

        }
        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.phanQuyen1TableAdapter.Fill(this.dataDori.PhanQuyen1, ((int)(System.Convert.ChangeType(maNhomNguoiDungTextBoxX.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void nHOMNGUOIDUNGDataGridViewX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            manguoidung = Convert.ToInt32(nHOMNGUOIDUNGDataGridViewX.CurrentRow.Cells[0].Value.ToString());
            try
            {
                this.phanQuyen1TableAdapter.Fill(this.dataDori.PhanQuyen1, manguoidung);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
        //cập nhật phân quyền
        private void btn_them_Click(object sender, EventArgs e)
        {
            bool a;
            for (int i = 0; i < mANHINHTableAdapter.GetData().Rows.Count; i++)
            {
                if (pHANQUYENTableAdapter.Kiemtra(manguoidung, Convert.ToInt32(phanQuyen1DataGridViewX.Rows[i].Cells[0].Value.ToString())) == 1)
                {
                    if (phanQuyen1DataGridViewX.Rows[i].Cells[2].Value.ToString() == "False")
                    {
                        a = false;
                    }
                    else
                    {
                        a = true;
                    }
                    pHANQUYENTableAdapter.UpdatePhanQuyen(a, manguoidung, Convert.ToInt32(phanQuyen1DataGridViewX.Rows[i].Cells[0].Value.ToString()));
                }
                else
                {
                    if (phanQuyen1DataGridViewX.Rows[i].Cells[2].Value.ToString() == "" || phanQuyen1DataGridViewX.Rows[i].Cells[2].Value.ToString() == "false")
                    {
                        a = false;
                    }
                    else
                    {
                        a = true;
                    }
                    pHANQUYENTableAdapter.Insert(manguoidung,Convert.ToInt32(phanQuyen1DataGridViewX.Rows[i].Cells[0].Value.ToString()), a);

                }

            }
            this.pHANQUYENTableAdapter.Fill(this.dataDori.PHANQUYEN);
        }
    }
}
