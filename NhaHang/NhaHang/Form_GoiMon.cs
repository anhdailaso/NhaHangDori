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
    public partial class Form_GoiMon : Office2007RibbonForm
    {
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
                snl.loadmon((Byte[])item.HinhAnh, item.TenMA.ToString(),Convert.ToInt32(mONANTableAdapter.ScalarMinMonAnByNL(item.MaMA)),item.MaMA);
                flowLayoutPanel2.Controls.Add(snl);
                snl.ButtonClick += Snl_ButtonClick;
               
            }
        }

        private void Snl_ButtonClick(object sender, EventArgs e)
        {
            if(bientoancuc.tinhtrangban=="Còn")
            {
                MessageBox.Show("Bàn Này hiện tại chưa có khách");
            }
            {
                //kiểm tra món ăn trong bảng chi tiết
                var dem = dataDori.CT_MONAN.Count(p => p.MaMA.Equals(Convert.ToInt32(bientoancuc.mamonan))&& p.MaPD.Equals((Convert.ToInt32(bientoancuc.maphieudac))));
                if (dem == 1)
                {
                    cT_MONANTableAdapter.UpdateQuery(bientoancuc.soluongmongoi, Convert.ToInt32(bientoancuc.mamonan), Convert.ToInt32(bientoancuc.maphieudac));
                }
                else
                {
                    cT_MONANTableAdapter.InsertQuery(Convert.ToInt32(bientoancuc.mamonan), Convert.ToInt32(bientoancuc.maphieudac), bientoancuc.soluongmongoi);

                }
                //fill lại dữ liệu
                this.monAnTheoPDTableAdapter.Fill(this.dataDori.MonAnTheoPD, ((int)(System.Convert.ChangeType(bientoancuc.maphieudac, typeof(int)))));

               
                //update lại số lượng trong bảng Món ăn
                //update lại số lượng trong bảng nguyên liệu
            }
        }

        public void updateban()
        {
            bANTableAdapter.FillByMaKhu(dataDori.BAN,Convert.ToInt32(bientoancuc.makhuvuc));
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
        private void Ban_ButtonClick(object sender, EventArgs e)
        {
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
                    superTabControl1.Enabled = false;
                    pHIEUDATMONBindingSource.AddNew();

                }
                else
                {
                    groupPanel3.Enabled = false;
                    superTabControl1.Enabled = true;
                    pHIEUDATMONBindingSource.CancelEdit();
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
    }
}
