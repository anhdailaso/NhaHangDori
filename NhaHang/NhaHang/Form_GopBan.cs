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
    public partial class Form_GopBan : Office2007RibbonForm
    {

        public Form_GopBan()
        {
            InitializeComponent();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //btn gop bàn
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            //button hủy
        }

        private void bANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);

        }

        private void Form_GopBan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.BAN' table. You can move, or remove it, as needed.
            this.bANTableAdapter.Fill(this.dataDori.BAN);
            loadbananhet();
        }
        void loadbananhet()
        {
            bANTableAdapter.FillByMaKhu(dataDori.BAN, Convert.ToInt32(bientoancuc.makhuvuc));
            var banhet = dataDori.BAN.Where(p => p.TinhTrang.Equals("Hết")).ToList();
            foreach (var item in banhet)
            {
                ShowBan ban = new ShowBan();
                ban.ButtonClick += Ban_ButtonClick; ;
                ban.Size = new Size(92, 118);
                ban.loadban(item.MaB.ToString(), item.TinhTrang);
                flowLayoutPanel1.Controls.Add(ban);
            }
        }
        public void ressetbanhet()
        {
            foreach (ShowBan item in flowLayoutPanel1.Controls) item.Dispose();
            {
                flowLayoutPanel1.Controls.Clear();
            }
        }
        private void Ban_ButtonClick(object sender, EventArgs e)
        {
            PictureBox a = (PictureBox)sender;
            if (a.BackColor == Control.DefaultBackColor)
            {
                a.BackColor = Color.Blue;
            }
            else
            {
                a.BackColor = Control.DefaultBackColor;
            }
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
            List<int> bangop = new List<int>();
            //gộp bàn
            foreach (ShowBan item in flowLayoutPanel1.Controls)
            {
                if (item.BackColor == Color.Blue)
                {
                    bangop.Add(Convert.ToInt32(item.Tag));
                }
            }
            if (bangop != null)
            {

                for (int i = 0; i < bangop.Count; i++)
                {
                    if (i > 0)
                    {
                        bANTableAdapter.GetDataGopBan(bangop[0], bangop[i]);
                    }
                }
            }
            //reset load lại
            ressetbanhet();
            loadbananhet();

        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
            //huyt gộp
        }
    }
}
