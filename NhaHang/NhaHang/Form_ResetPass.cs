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
    public partial class Form_ResetPass : Office2007RibbonForm
    {
        public Form_ResetPass()
        {
            InitializeComponent();
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (txt_tenDN.Text != "" && txt_passcu.Text != "" && txt_passmoi.Text != "" && txt_xatnhan.Text != "")
            {
                if (txt_xatnhan.Text == txt_passmoi.Text)
                {
                    if (kiemtra() == true)
                    {
                        this.nGUOIDUNGTableAdapter.CapNhatPass(txt_passmoi.Text, txt_tenDN.Text);
                        MessageBox.Show("đổi pass thành công", "thành công", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("tài khoản của bạn không đúng");
                    }
                }
                else MessageBox.Show("kiểm tra lại xác nhận mật khẩu");
            }
            else
            {
                MessageBox.Show("Bạn Phải Nhập Đủ Thông tin");
            }
        }
        public bool kiemtra()
        {
            bool s = false;
            try
            {
                int? n = nGUOIDUNGTableAdapter.KiemTra(txt_tenDN.Text, txt_passcu.Text);
                if (n == 1)
                    s = true;
                else
                    s = false;
            }

            catch
            {
                MessageBox.Show("Bạn đã nhập sai vui lòng nhập lại", "Nhập lại", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            return s;
        }
        private void nGUOIDUNGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUOIDUNGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);

        }

        private void Form_ResetPass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.NGUOIDUNG' table. You can move, or remove it, as needed.
            this.nGUOIDUNGTableAdapter.Fill(this.dataDori.NGUOIDUNG);

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
