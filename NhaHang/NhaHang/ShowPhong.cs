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
    public partial class ShowPhong : UserControl
    {
      
        public ShowPhong()
        {
            InitializeComponent();
        }
        public event EventHandler ButtonClick = null;
        public void loadphong(string maphong,string tinhtrang,int loaiphong,int soluong)
        {
            labelX1.Text = maphong+" /"+soluong;
            if(loaiphong ==1)
            {
                labelX1.ForeColor = Color.Red;
            }
            else
            {
                labelX1.ForeColor = Color.Blue;
            }
            this.Tag = maphong;
            if (tinhtrang == "Còn")
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\image\\cuasanhmo.png");
            }
            else
                if (tinhtrang == "Hết")
                {
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\image\\cuasanhdong.jpg");
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\image\\dadac.png");
                }
        }

        private void ShowPhong_Load(object sender, EventArgs e)
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
