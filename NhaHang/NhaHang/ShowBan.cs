using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NhaHang;
using BUSDLL;

namespace NhaHang
{
    public partial class ShowBan : UserControl
    {
      
        public ShowBan()
        {
            InitializeComponent();
        }
        public event EventHandler ButtonClick = null;
        public void loadban(string maban,string tinhtrang)
        {
            labelX1.Text = maban;
            this.Tag = maban;
            if (tinhtrang == "Còn")
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\image\\bantrong.png");
            }
            else
                if (tinhtrang == "Hết")
                {
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\image\\daco.png");
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\image\\dadac.png");
                }
        }

        private void ShowBan_Load(object sender, EventArgs e)
        {
            
            pictureBox1.Size = new Size(89,89);
            this.Size = new Size(91, 118);

        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            bientoancuc.mabantheokhu = this.Tag.ToString();
            if (ButtonClick != null) ButtonClick(sender, e);
        }
    }
}
