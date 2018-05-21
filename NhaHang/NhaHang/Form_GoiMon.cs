using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSDLL;
using DevComponents.DotNetBar;

namespace NhaHang
{
    public partial class Form_GoiMon : Office2007RibbonForm
    {
        double tientra;
        double tong;
        double tien;
        double tienkhach;

        public Form_GoiMon()
        {
            InitializeComponent();
        }

        private void bANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);
        }
        private void Form_GoiMon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.dataDori.NHANVIEN);
            // TODO: This line of code loads data into the 'dataDori.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.dataDori.HOADON);
            // TODO: This line of code loads data into the 'dataDori.MonAnTheoPD' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dataDori.KHACHHANG' table. You can move, or remove it, as needed.
            this.kHACHHANGTableAdapter.Fill(this.dataDori.KHACHHANG);
            groupPanel3.Enabled = false;
            superTabControl1.Enabled = false;
            // TODO: This line of code loads data into the 'dataDori.MONAN' table. You can move, or remove it, as needed.
            this.mONANTableAdapter.Fill(this.dataDori.MONAN);
            // TODO: This line of code loads data into the 'dataDori.PHIEUDATMON' table. You can move, or remove it, as needed.
            this.pHIEUDATMONTableAdapter.Fill(this.dataDori.PHIEUDATMON);
            // TODO: This line of code loads data into the 'dataDori.CT_MONAN' table. You can move, or remove it, as needed.
            this.cT_MONANTableAdapter.Fill(this.dataDori.CT_MONAN);
            tatcacmoan();
            // TODO: This line of code loads data into the 'dataDori.BAN' table. You can move, or remove it, as needed.
            this.bANTableAdapter.Fill(this.dataDori.BAN);
            loadbanan();
        }
        public void tatcacmoan()
        {
            var nl = dataDori.MONAN.Select(p => p).ToList();
            foreach (var item in nl)
            {
                ShowMon snl = new ShowMon();
                //int sl = item.KLTon.ToString() == "" ? 0 : Int32.Parse(item.KLTon.ToString());
                snl.loadmon((Byte[])item.HinhAnh, item.TenMA.ToString(), Convert.ToInt32(mONANTableAdapter.ScalarMinMonAnByNL(item.MaMA)), item.MaMA);
                flowLayoutPanel2.Controls.Add(snl);
                snl.ButtonClick += Snl_ButtonClick;

            }
        }
        private void Snl_ButtonClick(object sender, EventArgs e)
        {
            if (bientoancuc.tinhtrangban == "Còn")
            {
                MessageBox.Show("Bàn Này hiện tại chưa có khách");
            }
            else
            {
                //kiểm tra món ăn trong bảng chi tiết
                var dem = dataDori.CT_MONAN.Count(p => p.MaMA.Equals(Convert.ToInt32(bientoancuc.mamonan)) && p.MaPD.Equals((Convert.ToInt32(bientoancuc.maphieudac))));
                if (dem == 1)
                {
                    cT_MONANTableAdapter.UpdateQuery(bientoancuc.soluongmongoi, Convert.ToInt32(bientoancuc.mamonan), Convert.ToInt32(bientoancuc.maphieudac));
                }
                else
                {
                    cT_MONANTableAdapter.InsertQuery(Convert.ToInt32(bientoancuc.mamonan), Convert.ToInt32(bientoancuc.maphieudac), bientoancuc.soluongmongoi);
                    bANTableAdapter.UpdateQueryGoiMon(Convert.ToInt32(bientoancuc.mabantheokhu));
                    ressetban();
                    loadbanan();
                }
                //fill lại dữ liệu
                this.monAnTheoPDTableAdapter.Fill(this.dataDori.MonAnTheoPD, ((int)(System.Convert.ChangeType(bientoancuc.maphieudac, typeof(int)))));
                //update lại số lượng trong bảng Món ăn
                monAnTheoPDTableAdapter.cap_nhat_theo_nguyen_lieu(bientoancuc.soluongmongoi, Convert.ToInt32(bientoancuc.mamonan));
                resset();
                tatcacmoan();
                //update lại số lượng nguyen lieu
            }
        }
        public void updateban()
        {
            bANTableAdapter.FillByMaKhu(dataDori.BAN, Convert.ToInt32(bientoancuc.makhuvuc));
            this.tableAdapterManager.UpdateAll(this.dataDori);
            //phieuDatBanTableAdapter.Fill(dataDori.PhieuDatBan);
            //xoaban();
            loadbanan();
        }
        void loadbanan()
        {
            for (int i = 0; i < bANTableAdapter.GetDataByMaKhu(Convert.ToInt32(bientoancuc.makhuvuc)).Rows.Count; i++)
            {
                ShowBan ban = new ShowBan();
                ban.ButtonClick += Ban_ButtonClick;
                ban.Size = new Size(92, 118);
                groupPanel1.Text = "danh sách bàn" + bientoancuc.makhuvuc + "";
                ban.loadban(bANTableAdapter.GetDataByMaKhu(Convert.ToInt32(bientoancuc.makhuvuc)).Rows[i][0].ToString(), bANTableAdapter.GetDataByMaKhu(Convert.ToInt32(bientoancuc.makhuvuc)).Rows[i][3].ToString());
                flowLayoutPanel1.Controls.Add(ban);
            }
        }
        public void resset()
        {
            foreach (ShowMon item in flowLayoutPanel2.Controls) item.Dispose();
            {
                flowLayoutPanel2.Controls.Clear();
            }
        }
        public void ressetban()
        {
            foreach (ShowMon item in flowLayoutPanel2.Controls) item.Dispose();
            {
                flowLayoutPanel1.Controls.Clear();
            }
        }
        private void Ban_ButtonClick(object sender, EventArgs e)
        {
            this.bANTableAdapter.Fill(this.dataDori.BAN);
            try
            {
                bientoancuc.maphieudac = bANTableAdapter.GetDataByMaBan(Convert.ToInt32(bientoancuc.mabantheokhu))[0][2].ToString();
                groupPanel4.Text = bientoancuc.mabantheokhu;
                var tinhtrang = dataDori.BAN.Where(p => p.MaB.Equals(Convert.ToInt32(bientoancuc.mabantheokhu))).Select(p => p.TinhTrang).FirstOrDefault();
                bientoancuc.tinhtrangban = tinhtrang;
                if (tinhtrang == "Còn")
                {
                    this.monAnTheoPDTableAdapter.Fill(this.dataDori.MonAnTheoPD, ((int)(System.Convert.ChangeType(-1, typeof(int)))));
                    groupPanel3.Enabled = true;
                    btn_dacban.Enabled = true;
                    buttonX1.Enabled = false;
                    superTabControl1.Enabled = false;
                    pHIEUDATMONBindingSource.AddNew();

                }
                else
                if (tinhtrang == "Hết")
                {
                    groupPanel3.Enabled = false;
                    superTabControl1.Enabled = true;
                    pHIEUDATMONBindingSource.CancelEdit();
                    this.pHIEUDATMONTableAdapter.FillByMa(this.dataDori.PHIEUDATMON, Convert.ToInt32(bientoancuc.maphieudac));
                    this.monAnTheoPDTableAdapter.Fill(this.dataDori.MonAnTheoPD, ((int)(System.Convert.ChangeType(bientoancuc.maphieudac, typeof(int)))));
                }
                else
                {
                    superTabControl1.Enabled = true;
                    groupPanel3.Enabled = true;
                    btn_dacban.Enabled = false;
                    buttonX1.Enabled = true;
                    this.pHIEUDATMONTableAdapter.FillByMa(this.dataDori.PHIEUDATMON, Convert.ToInt32(bientoancuc.maphieudac));
                    this.monAnTheoPDTableAdapter.Fill(this.dataDori.MonAnTheoPD, ((int)(System.Convert.ChangeType(bientoancuc.maphieudac, typeof(int)))));
                }

                //this.monAnTheoBanTableAdapter.FillMonAnTheoBan(this.dataNhaHang.MonAnTheoBan, bientoancuc.mabantheokhu);
                //if ((int)banAnTableAdapter.demtheotinhtrangdadac(bientoancuc.mabantheokhu, bientoancuc.makhuvuc) == 1)
                //{
                //    panel3.Enabled = true;
                //    tienkhac.ResetText();
                //    numericUpDown1.Value = 1;
                //    tienphaitra.Text = "VND";
                //}
                //else
                //{
                //    panel3.Enabled = false;
                //}
            }
            catch
            {
            }
        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                mONANTableAdapter.FillByTenMon(this.dataDori.MONAN, "%" + textBoxX1.Text + "%");
                resset();
                tatcacmoan();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btn_dacban_Click(object sender, EventArgs e)
        {
            //thêm phiếu đặt
            try
            {
                pHIEUDATMONTableAdapter.Insert(dateTimePicker1.Value, gioDatDateTimePicker.Value.TimeOfDay, 0, Convert.ToDouble(tienCocTextBoxX.Text), Convert.ToInt32(comboBoxEx1.SelectedValue), DateTime.Now, "Còn");
                this.tableAdapterManager.UpdateAll(this.dataDori);
            }
            catch (Exception)
            {
                throw;
            }
            this.pHIEUDATMONTableAdapter.Fill(this.dataDori.PHIEUDATMON);
            var mapd = dataDori.PHIEUDATMON.Max(p => p.MaPD);
            bANTableAdapter.UpdateQueryPDBan(mapd, Convert.ToInt32(bientoancuc.mabantheokhu));
            ressetban();
            loadbanan();

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //cập nhật tình trạng của bàn
            bANTableAdapter.UpdateQueryHuyDat(Convert.ToInt32(bientoancuc.mabantheokhu));
            ressetban();
            loadbanan();

        }

        private void tienkhac_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tientra = 0;
                tientra = double.Parse(tienkhac.Text) - tong;
                tienkhach = double.Parse(tienkhac.Text);
                tienphaitra.Text = String.Format("{0:0,0 vnđ}", tientra);
            }
            catch { }
        }

        private void monAnTheoPDDataGridViewX_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            sulihoadon();
        }
        public void sulihoadon()
        {
            if (monAnTheoPDDataGridViewX.Rows.Count > 0)
            {
                tien = dataDori.MonAnTheoPD.Sum(p => p.ThanhTien);
                tong = tien + (tien * 10 / 100);
                thuevat.Text = String.Format("{0:0,0 vnđ}", tien * 10 / 100);
                labletongtien.Text = String.Format("{0:0,0 vnđ}", tien);
                tongtien.Text = String.Format("{0:0,0 vnđ}", tong);
            }
            else
            {
                return;
            }
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            //xuất report
            try
            {
                PrintDialog _PrintDialog = new PrintDialog();
                PrintDocument _PrintDocument = new PrintDocument();
                _PrintDialog.Document = _PrintDocument;
                _PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(_CreateReceipt);
                DialogResult result = _PrintDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _PrintDocument.Print();
                    //cập nhật tình trạng bàn
                    bANTableAdapter.UpdateQueryHuyDat(Convert.ToInt32(bientoancuc.mabantheokhu));
                    ressetban();
                    loadbanan();
                    //xóa số lượng món trong phiếu đặt
                    //thanh toán
                    hOADONTableAdapter.Insert(DateTime.Now, tien, tien * 10 / 100, tien + (tien * 10 / 100),Convert.ToInt32(bientoancuc.maphieudac), bientoancuc.manhanvien);
                    //hoaDonTableAdapter.Insert(mahd, bientoancuc.maphieudac, (DateTime)dateTimePicker1.Value, (decimal)tien, (double)numericUpDown1.Value, (decimal)tong, bientoancuc.manhanvien);
                }
            }
            catch (Exception)
            {

            }

        }
        private void _CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //lấy mã hóa đơn
            //this.pHIEUDATMONTableAdapter.Fill(this.dataDori.PHIEUDATMON);
            //var mapd = dataDori.PHIEUDATMON.Max(p => p.MaPD);
            hOADONTableAdapter.Fill(this.dataDori.HOADON);
            var mahd = dataDori.HOADON.Max(p => p.MaPD);

            //lấy Tên Nhân Viên theo mã
            var manv = dataDori.NHANVIEN.Where(p => p.MaNV.Equals(bientoancuc.manhanvien)).Select(p => p.TenNV).FirstOrDefault();

            Graphics graphic = e.Graphics;
            Font font = new Font("Courier New", 12);
            float FontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString("HÓA ĐƠN NHÀ HÀNG LONG PHỤNG", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);

            graphic.DrawString("Mã Hóa Đơn:", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(mahd.ToString(), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);
            offset = offset + (int)FontHeight + 5;
            string top = "Tên Sản Phẩm".PadRight(20) + "Số Lượng".PadRight(10) + "Thành Tiền";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent    
            for (int i = 0; i < monAnTheoPDTableAdapter.GetData(Convert.ToInt32(bientoancuc.maphieudac)).Rows.Count; i++)
            {
                graphic.DrawString(monAnTheoPDTableAdapter.GetData(Convert.ToInt32(bientoancuc.maphieudac)).Rows[i][0].ToString(), font, new SolidBrush(Color.Black), startX, startY + offset);
                graphic.DrawString(monAnTheoPDTableAdapter.GetData(Convert.ToInt32(bientoancuc.maphieudac)).Rows[i][1].ToString(), font, new SolidBrush(Color.Black), startX + 220, startY + offset);
                graphic.DrawString(monAnTheoPDTableAdapter.GetData(Convert.ToInt32(bientoancuc.maphieudac)).Rows[i][3].ToString(), font, new SolidBrush(Color.Black), startX + 320, startY + offset);
                offset = offset + (int)FontHeight + 5; //make the spacing consistent  
            }
            offset = offset + 20; //make some room so that the total stands out.
            graphic.DrawString("---------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent              


            graphic.DrawString("Tổng Hóa Đơn", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(String.Format("{0:0,0 vnđ}", tien), font, new SolidBrush(Color.Black), startX + 250, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent   

            graphic.DrawString("Thuế Vat", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(String.Format("{0:0,0 vnđ}", tien*10/100), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent   
            graphic.DrawString("Tổng Thanh Toán", new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(String.Format("{0:0,0 vnđ}", tong), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("TIỀN Khách Đưa ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(String.Format("{0:0,0 vnđ}", tienkhach), font, new SolidBrush(Color.Black), startX + 250, startY + offset);



            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("TIỀN TRẢ ", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(String.Format("{0:0,0 vnđ}", tientra), font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            //lấy tên nhân viên theo mã
            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("nhân viên thu tiền:", font, new SolidBrush(Color.Black), startX, startY + offset);
            graphic.DrawString(manv, font, new SolidBrush(Color.Black), startX + 250, startY + offset);

            offset = offset + (int)FontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString(" CẢM ƠN BẠN ĐÃ GHÉ THĂM!,", font, new SolidBrush(Color.Black), startX + 30, startY + offset);
            offset = offset + (int)FontHeight + 5; //make the spacing consistent              
            graphic.DrawString("HI VỌNG BẠN SẼ GHÉ THĂM LẠI!", font, new SolidBrush(Color.Black), startX + 25, startY + offset);

        }
        //hàm chuyển đổi sang tiền tệ
        //public static string _DoiSoSangDonViTienTe(int _object)
        //{
        //    return _object.ToString() + ".000VND";
        //}

        private void tienkhac_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    if (tienkhac.Text.Equals("0"))
            //        return;
            //    double temp = Convert.ToDouble(tienkhac.Text);
            //    tienkhac.Text = temp.ToString("#,###");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi:" + ex);
            //}

        }
        //chuyển bàn
        private void chuyểnBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ChuyenBan frm = new Form_ChuyenBan();
            frm.ShowDialog();
        }
        //gộp bàn
        private void gộpBànToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //reload
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
