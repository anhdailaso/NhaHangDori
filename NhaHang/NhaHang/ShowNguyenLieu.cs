using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BUSDLL;

namespace NhaHang
{
    public partial class ShowNguyenLieu : UserControl
    {
        public ShowNguyenLieu()
        {
            InitializeComponent();
        }
        public event EventHandler PicherClick = null;
        public void loadmonnguyenlieu(Byte[] anh, String ten,string dvt, double soluong,string ma)
        {
            this.Tag = ma;
            var stream = new MemoryStream(anh);
            pictureBox1.Image = Image.FromStream(stream);
            labelX1.Text = ten;
            labelX2.Text = soluong.ToString() + " /" + dvt;
            //this.Tag = ma;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            bientoancuc.manguyenlieu = this.Tag.ToString();
            if (PicherClick != null) PicherClick(sender, e);

        }

    }
}
