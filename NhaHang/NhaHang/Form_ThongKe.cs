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

namespace NhaHang
{
    public partial class Form_ThongKe : Office2007RibbonForm
    {
        public Form_ThongKe()
        {
            InitializeComponent();
        }

        private void Form_ThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter.Fill(this.dataDori.PHIEUNHAP);
            // TODO: This line of code loads data into the 'dataDori.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.dataDori.HOADON);
            // TODO: This line of code loads data into the 'dataDori.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.dataDori.HOADON);
            // TODO: This line of code loads data into the 'dataDori.CT_DICHVU' table. You can move, or remove it, as needed.
            var tongtienhd = dataDori.HOADON.Sum(p => p.TongTien);
            labelX5.Text = String.Format("{0:0,0 vnđ}", tongtienhd);

            var tongtienpn = dataDori.PHIEUNHAP.Sum(p => p.TongTien);
            labelX6.Text = String.Format("{0:0,0 vnđ}", tongtienpn);

        }

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);

        }

        private void hOADONBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hOADONTableAdapter.FillByDate(dataDori.HOADON,dateTimePicker1.Value.ToString(),dateTimePicker2.Value.ToString());
            pHIEUNHAPTableAdapter.FillByByNgay(dataDori.PHIEUNHAP, dateTimePicker1.Value.ToString(), dateTimePicker2.Value.ToString());

            var tongtienhd = dataDori.HOADON.Sum(p => p.TongTien);
            labelX5.Text = String.Format("{0:0,0 vnđ}", tongtienhd);

            var tongtienpn = dataDori.PHIEUNHAP.Sum(p => p.TongTien);
            labelX6.Text = String.Format("{0:0,0 vnđ}", tongtienpn);
        }
    }
}
