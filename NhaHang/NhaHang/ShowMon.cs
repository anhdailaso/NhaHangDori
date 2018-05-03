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
using System.IO;

namespace NhaHang
{
    public partial class ShowMon : UserControl
    {
        public ShowMon()
        {
            InitializeComponent();
        }
        public event EventHandler ButtonClick = null;
        public void loadmon(Byte[] anh,String ten,int soluong,string ma)
        {    
            var stream = new MemoryStream(anh);
            pictureBox1.Image = Image.FromStream(stream);         
            labelX1.Text = ten;
            numericUpDown1.Maximum =Convert.ToDecimal(soluong);
            numericUpDown1.Value = Convert.ToDecimal(soluong);
            this.Tag = ma;
            
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            //bientoancuc.mamonan = this.Tag.ToString();
            //bientoancuc.soluongmongoi = Int32.Parse(numericUpDown1.Value.ToString());
            //bientoancuc.soluoncon = (int)numericUpDown1.Maximum - bientoancuc.soluongmongoi;
            //if (ButtonClick != null) ButtonClick(sender, e);
            //if (bientoancuc.co == true)
            //{
                
            //    numericUpDown1.Value = numericUpDown1.Maximum - bientoancuc.soluongmongoi;
            //    numericUpDown1.Maximum = numericUpDown1.Value;
      
              
            //}
            //else
            //{ return; }
        }
        
    }
}
