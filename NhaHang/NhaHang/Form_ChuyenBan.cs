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
    public partial class Form_ChuyenBan : Office2007RibbonForm
    {
        public Form_ChuyenBan()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);
            

        }
        void loadbanan()
        {
            bANTableAdapter.FillByMaKhu(dataDori.BAN,Convert.ToInt32(bientoancuc.makhuvuc));
            var banhet = dataDori.BAN.Where(p => p.TinhTrang.Equals("Hết")).ToList();
            foreach (var item in banhet)
            {
                ShowBan ban = new ShowBan();
                ban.ButtonClick += Ban_ButtonClick;
                ban.Size = new Size(92, 118);
                ban.loadban(item.MaB.ToString(), item.TinhTrang);
                flowLayoutPanel1.Controls.Add(ban);
            }
           
        }
        void loadbanancon()
        {
            bANTableAdapter.FillByMaKhu(dataDori.BAN, Convert.ToInt32(bientoancuc.makhuvuc));
            var banhet = dataDori.BAN.Where(p => p.TinhTrang.Equals("Còn")).ToList();
            foreach (var item in banhet)
            {
                ShowBan ban = new ShowBan();
                ban.ButtonClick += Ban_ButtonClick1; ;
                ban.Size = new Size(92, 118);
                ban.loadban(item.MaB.ToString(), item.TinhTrang);
                flowLayoutPanel2.Controls.Add(ban);
            }
        }

        private void Ban_ButtonClick1(object sender, EventArgs e)
        {
           //ShowBan a= sender;
           // a.Enabled = true;
        }

        private void Ban_ButtonClick(object sender, EventArgs e)
        {
            resset();
            loadbanancon();
        }
        public void resset()
        {
            foreach (ShowMon item in flowLayoutPanel2.Controls) item.Dispose();
            {

                flowLayoutPanel2.Controls.Clear();
            }
        }

        private void Form_ChuyenBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.BAN' table. You can move, or remove it, as needed.
            this.bANTableAdapter.Fill(this.dataDori.BAN);
            loadbanan();

        }
    }
}
