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
    public partial class Form_PhongAn : Office2007RibbonForm
    {
        public Form_PhongAn()
        {
            InitializeComponent();
        }

        private void lOAIPHONGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOAIPHONGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataDori);

        }

        private void Form_PhongAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDori.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.dataDori.PHONG);
            // TODO: This line of code loads data into the 'dataDori.LOAIPHONG' table. You can move, or remove it, as needed.
            this.lOAIPHONGTableAdapter.Fill(this.dataDori.LOAIPHONG);
            loadphongan();
        }
        void loadphongan()
        {
            for (int i = 0; i < pHONGTableAdapter.GetDataByPhongTheoKhu(Convert.ToInt32(bientoancuc.makhuvuc)).Rows.Count; i++)
            {
                ShowPhong phong = new ShowPhong();
                phong.ButtonClick += Phong_ButtonClick;
                phong.Size = new Size(92, 118);
                groupPanel1.Text = "danh sách bàn" + bientoancuc.makhuvuc + "";
                phong.loadphong(pHONGTableAdapter.GetDataByPhongTheoKhu(Convert.ToInt32(bientoancuc.makhuvuc)).Rows[i][1].ToString(),pHONGTableAdapter.GetDataByPhongTheoKhu(Convert.ToInt32(bientoancuc.makhuvuc)).Rows[i][6].ToString(),Convert.ToInt32(pHONGTableAdapter.GetDataByPhongTheoKhu(Convert.ToInt32(bientoancuc.makhuvuc)).Rows[i][3].ToString()), Convert.ToInt32(pHONGTableAdapter.GetDataByPhongTheoKhu(Convert.ToInt32(bientoancuc.makhuvuc)).Rows[i][2].ToString()));
                flowLayoutPanel1.Controls.Add(phong);
            }
        }
        public void ressetphong()
        {
            foreach (ShowPhong item in flowLayoutPanel1.Controls) item.Dispose();
            {
                flowLayoutPanel1.Controls.Clear();
            }
        }
        private void Phong_ButtonClick(object sender, EventArgs e)
        {
            
        }
        //tìm kiếm phòng theo điều kiện khách hàng
        private void buttonX2_Click(object sender, EventArgs e)
        {
            ressetphong();
            foreach (var item in pHONGTableAdapter.GetDataByALL(Convert.ToInt32(bientoancuc.makhuvuc), Convert.ToInt32(comboBoxEx2.SelectedValue),Convert.ToInt32(numericUpDown1.Value)))
            {
                ShowPhong phong = new ShowPhong();
                phong.ButtonClick += Phong_ButtonClick;
                phong.Size = new Size(92, 118);
                groupPanel1.Text = "danh sách bàn" + bientoancuc.makhuvuc + "";
                phong.loadphong(item.TenPH,item.TinhTrang,item.MaLP,item.SucChua);
                flowLayoutPanel1.Controls.Add(phong);
            }
        }
    }
}
