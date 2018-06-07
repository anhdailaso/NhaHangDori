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
    public partial class Form_QLKhoNguyenLieu : Office2007RibbonForm
    {
        public Form_QLKhoNguyenLieu()
        {
            InitializeComponent();
        }
        private void Form_QLKhoNguyenLieu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.CT_PHIEUNHAP' table. You can move, or remove it, as needed.
            this.cT_PHIEUNHAPTableAdapter.Fill(this.dataDori.CT_PHIEUNHAP);
            // TODO: This line of code loads data into the 'dataDori.PHIEUNHAP' table. You can move, or remove it, as needed.
            this.pHIEUNHAPTableAdapter.Fill(this.dataDori.PHIEUNHAP);
            // TODO: This line of code loads data into the 'dataDori.PHIEUNHAP' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataDori.NCC' table. You can move, or remove it, as needed.
            this.nCCTableAdapter.Fill(this.dataDori.NCC);
            // TODO: This line of code loads data into the 'dataDori.NGUYENLIEU' table. You can move, or remove it, as needed.
            this.nGUYENLIEUTableAdapter.Fill(this.dataDori.NGUYENLIEU);
            tatcanguyenlieu();
            nguyenlieuganhet();

        }
        private void nGUYENLIEUBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nGUYENLIEUBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);

        }
        public void tatcanguyenlieu()
        {

            var nl = dataDori.NGUYENLIEU.Select(p => p).ToList();
            foreach (var item in nl)
            {
                ShowNguyenLieu snl = new ShowNguyenLieu();
                double sl = Math.Round(item.KLTon,2);
                snl.loadmonnguyenlieu((Byte[])item.HinhAnh,item.TenNL.ToString(),item.DVT,sl,item.MaNL.ToString());
                snl.PicherClick += snl_PicherClick;
                flowLayoutPanel1.Controls.Add(snl);
            }
        }
        public void nguyenlieuganhet()
        {
            var nl = dataDori.NGUYENLIEU.Where(p => p.KLTon < 10).ToList();
            foreach (var item in nl)
            {
                ShowNguyenLieu snl = new ShowNguyenLieu();
                double sl = Math.Round(item.KLTon, 2);
                snl.loadmonnguyenlieu((Byte[])item.HinhAnh, item.TenNL.ToString(), item.DVT, sl, item.MaNL.ToString());
                snl.PicherClick += snl_PicherClick;
                flowLayoutPanel2.Controls.Add(snl);
            }
        }

        void snl_PicherClick(object sender, EventArgs e)
        {
            groupPanel1.Text = "Nhập nguyên liệu cho có mã " + bientoancuc.manguyenlieu;
            groupPanel4.Text = "Chi tiết nguyên liệu có mã " + bientoancuc.manguyenlieu;
            try
            {
                this.nGUYENLIEUTableAdapter.FillNguyenLieuTheoMa(this.dataDori.NGUYENLIEU,Convert.ToInt32(bientoancuc.manguyenlieu));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void maPNNumericUpDown_ValueChanged_1(object sender, EventArgs e)
        {
            cT_PHIEUNHAPTableAdapter.FillBy(dataDori.CT_PHIEUNHAP, (int)maPNNumericUpDown.Value);
            var tien = dataDori.PHIEUNHAP.Where(P => P.MaPN.Equals((int)maPNNumericUpDown.Value)).Select(p=>p.TongTien).FirstOrDefault();
            tongTienTextBoxX.Text = tien.ToString();
        }
        public void resset()
        {
            foreach (ShowNguyenLieu item in flowLayoutPanel1.Controls) item.Dispose();
            {
                flowLayoutPanel1.Controls.Clear();
            }
            foreach (ShowNguyenLieu item in flowLayoutPanel2.Controls) item.Dispose();
            {
                flowLayoutPanel2.Controls.Clear();
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.cT_PHIEUNHAPBindingSource.CancelEdit();
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            //kiểm tra mã đã có tồn tại bên phiếu nhập chưa nếu chưa có thêm mới có rồi thì thôi
            var kiemtra = dataDori.PHIEUNHAP.Where(p => p.MaPN.Equals((int)maPNNumericUpDown.Value)).Count();
            if (kiemtra == 0)
            {
                pHIEUNHAPTableAdapter.Insert(ngayLapDateTimePicker.Value, double.Parse(tongTienTextBoxX.Text), (int)comboBoxEx2.SelectedValue,bientoancuc.manhanvien, gioLapDateTimePicker.Value.TimeOfDay);
            }
            try
            {
                int manl = (int)maNLComboBoxEx.SelectedValue;
               int mapn= (int)maPNNumericUpDown.Value;
                cT_PHIEUNHAPTableAdapter.Insert(mapn, manl, Convert.ToDouble(soLuongNumericUpDown.Value), double.Parse(donGiaNhapTextBoxX.Text));
                cT_PHIEUNHAPTableAdapter.FillBy(dataDori.CT_PHIEUNHAP, mapn);
                nGUYENLIEUTableAdapter.UpdateSL(Convert.ToDouble(soLuongNumericUpDown.Value),manl);
                this.tableAdapterManager.UpdateAll(this.dataDori);
                resset();
                this.nGUYENLIEUTableAdapter.Fill(this.dataDori.NGUYENLIEU);
                this.cT_PHIEUNHAPTableAdapter.Fill(this.dataDori.CT_PHIEUNHAP);
                tatcanguyenlieu();
                nguyenlieuganhet();
                var tongtien = dataDori.CT_PHIEUNHAP.Where(p=>p.MaPN.Equals(1)).Sum(p => p.SoLuong * p.DonGiaNhap);
                pHIEUNHAPTableAdapter.UpdateTongTien(tongtien, mapn);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("trùng khóa");
            }
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
