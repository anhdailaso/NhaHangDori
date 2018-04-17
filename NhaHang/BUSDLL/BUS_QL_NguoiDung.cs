using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using DTODLL;
using DAODLL;
namespace BUSDLL
{
    public class BUS_QL_NguoiDung
    {
        private static BUS_QL_NguoiDung instance;
        public static BUS_QL_NguoiDung Instance
        { get
            { if (instance == null)
                    instance = new BUS_QL_NguoiDung();
                return instance;
            }
        }
        public void login(CheckBoxX ckb_ghinho, TextBoxX txt_id, TextBoxX txt_password,Form login, Form main)
        {
            if (string.IsNullOrEmpty(txt_id.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống ID" + txt_id.Text.ToLower(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_id.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Không được bỏ trống PassWord" + txt_password.Text.ToLower(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_password.Focus();
                return;
            }
            if (DAO_QL_NguoiDung.Instances.Check_Config() == 0)
            {
                ProcessLogin(ckb_ghinho,txt_id,txt_password,login,main);// Cấu hình phù hợp xử lý đăng nhập
            }
            if (DAO_QL_NguoiDung.Instances.Check_Config() == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại");// Xử lý cấu hình
            }
            if (DAO_QL_NguoiDung.Instances.Check_Config() == 2)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp");// Xử lý cấu hình
            }
        }
        public void ProcessLogin(CheckBoxX ckb_ghinho,TextBoxX txt_id,TextBoxX txt_password ,Form login, Form main)
        {
            string result;
            result = DAO_QL_NguoiDung.Instances.Check_User(txt_id.Text, txt_password.Text);
            if (result == "Invalid")
            {
                MessageBox.Show("Sai tài khoảng đăng nhập hoặc password", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
                if (result == "Disabled")
            {
                MessageBox.Show("tài khoản bị khóa");
                return;
            }
            if (ckb_ghinho.Checked == true)
            {
                bientoancuc.pass = txt_password.Text;
                bientoancuc.trangthai = true;
            }
            else
            {
                bientoancuc.trangthai = false;
            }
            //bientoancuc.manhanvien = nhan_Vien1TableAdapter.GetNhanVienTheoTenDN(txt_id.Text).Rows[0][0].ToString();
            bientoancuc.tendn = txt_id.Text;
            login.Hide();
            main.ShowDialog();
        }
        public void savecauhinh(ComboBoxEx cbb_server,ComboBoxEx cbb_data, TextBoxX txt_user,TextBoxX txt_pass)
        {
            DAO_QL_NguoiDung.Instances.ChangeConnectionString(cbb_server.Text, cbb_data.Text,
            txt_user.Text, txt_pass.Text);
            MessageBox.Show("bạn đã thây đổi cấu hình mới");
        }
    }
}
