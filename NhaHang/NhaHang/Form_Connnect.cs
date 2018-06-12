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
    public partial class Form_Connnect : Office2007RibbonForm
    {
        public Form_Connnect()
        {
            InitializeComponent();
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            BUS_QL_NguoiDung.Instance.savecauhinh(cbb_server, cbb_data,
            txt_user, txt_pass);
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Form_Login login = new Form_Login();
            login.ShowDialog();
            this.Hide();
        }
        private void cbb_server_DropDown(object sender, EventArgs e)
        {
            DataTable dt = BUS_QL_NguoiDung.Instance.GetServerName();
            cbb_server.Items.Clear();
            foreach (System.Data.DataRow row in dt.Rows)
            {
                foreach (System.Data.DataColumn col in dt.Columns)
                {
                    cbb_server.Items.Add(row[col]);
                }
            }
        }
        private bool CheckedBeforSearchNameDB()
        {
            if (txt_pass.Text != "" && txt_user.Text != "" && cbb_server.Text != "")
                return true;
            else
                return false;
        }
        private void cbb_data_DropDown(object sender, EventArgs e)
        {
            if (CheckedBeforSearchNameDB())
            {
                cbb_data.Items.Clear();
                List<string> _list = BUS_QL_NguoiDung.Instance.GetDatabaseName(cbb_server.Text,
                txt_user.Text, txt_pass.Text);
                if (_list == null)
                {
                    MessageBox.Show("Thông tin cấu hình chưa chính xác");
                    return;
                }
                foreach (string item in _list)
                {
                    cbb_data.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("bạn phải điều đầy đủ thông tin trên");
            }
        }
    }
}
