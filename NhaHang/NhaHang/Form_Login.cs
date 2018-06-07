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
    public partial class Form_Login : Office2007RibbonForm
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        //thoát
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("bạn có muốn đóng chương trình", "đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (dl == DialogResult.Yes)
                Application.Exit();

        }
        //connet
        private void btn_connect_Click(object sender, EventArgs e)
        {
            Form_Connnect con = new Form_Connnect();
            this.Hide();
            con.ShowDialog();
        }
        //resetpass
        private void btn_resserpass_Click(object sender, EventArgs e)
        {
            Form_ResetPass reset = new Form_ResetPass();
            this.Hide();
            reset.ShowDialog();
        }
        //save password
        private void ckb_ghinho_CheckedChanged(object sender, EventArgs e)
        {

        }
        //login 
        private void btn_login_Click(object sender, EventArgs e)
        {
            Form_Main main = new Form_Main();
            BUS_QL_NguoiDung.Instance.login(ckb_ghinho, txt_id, txt_password,this,main);
        }
    }
}
