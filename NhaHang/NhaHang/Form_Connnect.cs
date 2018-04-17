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
    }
}
