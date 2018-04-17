namespace NhaHang
{
    partial class Form_NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label hinhanhLabel;
            System.Windows.Forms.Label tendnLabel;
            System.Windows.Forms.Label sdtLabel;
            System.Windows.Forms.Label dChiLabel;
            System.Windows.Forms.Label ten_nvLabel;
            System.Windows.Forms.Label ma_nvLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NhanVien));
            this.panel2 = new System.Windows.Forms.Panel();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btn_Luu = new DevComponents.DotNetBar.ButtonX();
            this.pan_thongtin = new System.Windows.Forms.Panel();
            this.btnChonHinh = new DevComponents.DotNetBar.ButtonX();
            this.hinhanhPictureBox = new System.Windows.Forms.PictureBox();
            this.tendnTextBox = new System.Windows.Forms.TextBox();
            this.sdtTextBox = new System.Windows.Forms.TextBox();
            this.dChiTextBox = new System.Windows.Forms.TextBox();
            this.ten_nvTextBox = new System.Windows.Forms.TextBox();
            this.ma_nvTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nhan_VienDataGridView = new System.Windows.Forms.DataGridView();
            this.btnFist = new DevComponents.DotNetBar.ButtonX();
            this.btnLast = new DevComponents.DotNetBar.ButtonX();
            this.btnPre = new DevComponents.DotNetBar.ButtonX();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            hinhanhLabel = new System.Windows.Forms.Label();
            tendnLabel = new System.Windows.Forms.Label();
            sdtLabel = new System.Windows.Forms.Label();
            dChiLabel = new System.Windows.Forms.Label();
            ten_nvLabel = new System.Windows.Forms.Label();
            ma_nvLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pan_thongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanhPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhan_VienDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hinhanhLabel
            // 
            hinhanhLabel.AutoSize = true;
            hinhanhLabel.Location = new System.Drawing.Point(3, 131);
            hinhanhLabel.Name = "hinhanhLabel";
            hinhanhLabel.Size = new System.Drawing.Size(88, 13);
            hinhanhLabel.TabIndex = 26;
            hinhanhLabel.Text = "Hình Nhân Viên :";
            // 
            // tendnLabel
            // 
            tendnLabel.AutoSize = true;
            tendnLabel.Location = new System.Drawing.Point(260, 388);
            tendnLabel.Name = "tendnLabel";
            tendnLabel.Size = new System.Drawing.Size(90, 13);
            tendnLabel.TabIndex = 11;
            tendnLabel.Text = "Tên Đăng Nhập :";
            // 
            // sdtLabel
            // 
            sdtLabel.AutoSize = true;
            sdtLabel.Location = new System.Drawing.Point(260, 359);
            sdtLabel.Name = "sdtLabel";
            sdtLabel.Size = new System.Drawing.Size(81, 13);
            sdtLabel.TabIndex = 9;
            sdtLabel.Text = "Số Điện Thoại :";
            // 
            // dChiLabel
            // 
            dChiLabel.AutoSize = true;
            dChiLabel.Location = new System.Drawing.Point(7, 414);
            dChiLabel.Name = "dChiLabel";
            dChiLabel.Size = new System.Drawing.Size(47, 13);
            dChiLabel.TabIndex = 7;
            dChiLabel.Text = "Địa Chỉ :";
            // 
            // ten_nvLabel
            // 
            ten_nvLabel.AutoSize = true;
            ten_nvLabel.Location = new System.Drawing.Point(7, 385);
            ten_nvLabel.Name = "ten_nvLabel";
            ten_nvLabel.Size = new System.Drawing.Size(85, 13);
            ten_nvLabel.TabIndex = 5;
            ten_nvLabel.Text = "Tên Nhân Viên :";
            // 
            // ma_nvLabel
            // 
            ma_nvLabel.AutoSize = true;
            ma_nvLabel.Location = new System.Drawing.Point(7, 356);
            ma_nvLabel.Name = "ma_nvLabel";
            ma_nvLabel.Size = new System.Drawing.Size(78, 13);
            ma_nvLabel.TabIndex = 3;
            ma_nvLabel.Text = "Mã Nhân Viên:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reflectionLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1291, 59);
            this.panel2.TabIndex = 27;
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.reflectionLabel1.Location = new System.Drawing.Point(488, 3);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(246, 50);
            this.reflectionLabel1.TabIndex = 0;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Quản Lý</i><font color=\"#B02B2C\"> Nhân Viên</font></font></" +
    "b>";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btn_xoa);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btn_Luu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(529, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(767, 77);
            this.panel3.TabIndex = 31;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTextSpacing = 1;
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(114, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnThem.Size = new System.Drawing.Size(99, 50);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // btn_xoa
            // 
            this.btn_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageTextSpacing = 1;
            this.btn_xoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_xoa.Location = new System.Drawing.Point(219, 6);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_xoa.Size = new System.Drawing.Size(99, 50);
            this.btn_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_xoa.TabIndex = 22;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnSua.ImageTextSpacing = 1;
            this.btnSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSua.Location = new System.Drawing.Point(324, 6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnSua.Size = new System.Drawing.Size(99, 50);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnHuy.ImageTextSpacing = 1;
            this.btnHuy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHuy.Location = new System.Drawing.Point(534, 6);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnHuy.Size = new System.Drawing.Size(99, 50);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // btn_Luu
            // 
            this.btn_Luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageTextSpacing = 1;
            this.btn_Luu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Luu.Location = new System.Drawing.Point(429, 6);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_Luu.Size = new System.Drawing.Size(99, 50);
            this.btn_Luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Luu.TabIndex = 24;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // pan_thongtin
            // 
            this.pan_thongtin.Controls.Add(this.btnChonHinh);
            this.pan_thongtin.Controls.Add(this.hinhanhPictureBox);
            this.pan_thongtin.Controls.Add(hinhanhLabel);
            this.pan_thongtin.Controls.Add(this.tendnTextBox);
            this.pan_thongtin.Controls.Add(tendnLabel);
            this.pan_thongtin.Controls.Add(this.sdtTextBox);
            this.pan_thongtin.Controls.Add(sdtLabel);
            this.pan_thongtin.Controls.Add(this.dChiTextBox);
            this.pan_thongtin.Controls.Add(dChiLabel);
            this.pan_thongtin.Controls.Add(this.ten_nvTextBox);
            this.pan_thongtin.Controls.Add(ten_nvLabel);
            this.pan_thongtin.Controls.Add(this.ma_nvTextBox);
            this.pan_thongtin.Controls.Add(ma_nvLabel);
            this.pan_thongtin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pan_thongtin.Location = new System.Drawing.Point(5, 60);
            this.pan_thongtin.Name = "pan_thongtin";
            this.pan_thongtin.Size = new System.Drawing.Size(524, 534);
            this.pan_thongtin.TabIndex = 30;
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChonHinh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChonHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonHinh.Image = ((System.Drawing.Image)(resources.GetObject("btnChonHinh.Image")));
            this.btnChonHinh.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnChonHinh.ImageTextSpacing = 1;
            this.btnChonHinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnChonHinh.Location = new System.Drawing.Point(209, 283);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnChonHinh.Size = new System.Drawing.Size(121, 42);
            this.btnChonHinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChonHinh.TabIndex = 28;
            this.btnChonHinh.Text = "chọn hình";
            this.btnChonHinh.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // hinhanhPictureBox
            // 
            this.hinhanhPictureBox.Location = new System.Drawing.Point(97, 20);
            this.hinhanhPictureBox.Name = "hinhanhPictureBox";
            this.hinhanhPictureBox.Size = new System.Drawing.Size(401, 246);
            this.hinhanhPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhanhPictureBox.TabIndex = 27;
            this.hinhanhPictureBox.TabStop = false;
            // 
            // tendnTextBox
            // 
            this.tendnTextBox.Location = new System.Drawing.Point(357, 385);
            this.tendnTextBox.Name = "tendnTextBox";
            this.tendnTextBox.Size = new System.Drawing.Size(160, 20);
            this.tendnTextBox.TabIndex = 12;
            // 
            // sdtTextBox
            // 
            this.sdtTextBox.Location = new System.Drawing.Point(357, 356);
            this.sdtTextBox.Name = "sdtTextBox";
            this.sdtTextBox.Size = new System.Drawing.Size(160, 20);
            this.sdtTextBox.TabIndex = 10;
            // 
            // dChiTextBox
            // 
            this.dChiTextBox.Location = new System.Drawing.Point(99, 411);
            this.dChiTextBox.Name = "dChiTextBox";
            this.dChiTextBox.Size = new System.Drawing.Size(146, 20);
            this.dChiTextBox.TabIndex = 8;
            // 
            // ten_nvTextBox
            // 
            this.ten_nvTextBox.Location = new System.Drawing.Point(99, 382);
            this.ten_nvTextBox.Name = "ten_nvTextBox";
            this.ten_nvTextBox.Size = new System.Drawing.Size(146, 20);
            this.ten_nvTextBox.TabIndex = 6;
            // 
            // ma_nvTextBox
            // 
            this.ma_nvTextBox.Location = new System.Drawing.Point(99, 353);
            this.ma_nvTextBox.Name = "ma_nvTextBox";
            this.ma_nvTextBox.Size = new System.Drawing.Size(146, 20);
            this.ma_nvTextBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nhan_VienDataGridView);
            this.panel1.Controls.Add(this.btnFist);
            this.panel1.Controls.Add(this.btnLast);
            this.panel1.Controls.Add(this.btnPre);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Location = new System.Drawing.Point(535, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 462);
            this.panel1.TabIndex = 32;
            // 
            // nhan_VienDataGridView
            // 
            this.nhan_VienDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nhan_VienDataGridView.Location = new System.Drawing.Point(3, 3);
            this.nhan_VienDataGridView.Name = "nhan_VienDataGridView";
            this.nhan_VienDataGridView.Size = new System.Drawing.Size(687, 412);
            this.nhan_VienDataGridView.TabIndex = 2;
            // 
            // btnFist
            // 
            this.btnFist.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnFist.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnFist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFist.Image = ((System.Drawing.Image)(resources.GetObject("btnFist.Image")));
            this.btnFist.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnFist.ImageTextSpacing = 1;
            this.btnFist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFist.Location = new System.Drawing.Point(708, 52);
            this.btnFist.Name = "btnFist";
            this.btnFist.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnFist.Size = new System.Drawing.Size(42, 68);
            this.btnFist.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFist.TabIndex = 17;
            this.btnFist.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // btnLast
            // 
            this.btnLast.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLast.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnLast.ImageTextSpacing = 1;
            this.btnLast.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLast.Location = new System.Drawing.Point(708, 274);
            this.btnLast.Name = "btnLast";
            this.btnLast.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnLast.Size = new System.Drawing.Size(42, 68);
            this.btnLast.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLast.TabIndex = 20;
            this.btnLast.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // btnPre
            // 
            this.btnPre.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPre.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPre.Image = ((System.Drawing.Image)(resources.GetObject("btnPre.Image")));
            this.btnPre.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnPre.ImageTextSpacing = 1;
            this.btnPre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPre.Location = new System.Drawing.Point(708, 126);
            this.btnPre.Name = "btnPre";
            this.btnPre.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnPre.Size = new System.Drawing.Size(42, 68);
            this.btnPre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPre.TabIndex = 18;
            this.btnPre.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btnNext.ImageTextSpacing = 1;
            this.btnNext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnNext.Location = new System.Drawing.Point(708, 200);
            this.btnNext.Name = "btnNext";
            this.btnNext.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnNext.Size = new System.Drawing.Size(42, 68);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.TabIndex = 19;
            this.btnNext.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // Form_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pan_thongtin);
            this.Controls.Add(this.panel2);
            this.Name = "Form_NhanVien";
            this.Text = "Form_NhanVien";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pan_thongtin.ResumeLayout(false);
            this.pan_thongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhanhPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nhan_VienDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btn_xoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btn_Luu;
        private System.Windows.Forms.Panel pan_thongtin;
        private DevComponents.DotNetBar.ButtonX btnChonHinh;
        private System.Windows.Forms.PictureBox hinhanhPictureBox;
        private System.Windows.Forms.TextBox tendnTextBox;
        private System.Windows.Forms.TextBox sdtTextBox;
        private System.Windows.Forms.TextBox dChiTextBox;
        private System.Windows.Forms.TextBox ten_nvTextBox;
        private System.Windows.Forms.TextBox ma_nvTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView nhan_VienDataGridView;
        private DevComponents.DotNetBar.ButtonX btnFist;
        private DevComponents.DotNetBar.ButtonX btnLast;
        private DevComponents.DotNetBar.ButtonX btnPre;
        private DevComponents.DotNetBar.ButtonX btnNext;
    }
}