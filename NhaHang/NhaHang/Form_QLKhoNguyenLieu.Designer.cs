namespace NhaHang
{
    partial class Form_QLKhoNguyenLieu
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
            System.Windows.Forms.Label maNCCLabel;
            System.Windows.Forms.Label donViTinhLabel;
            System.Windows.Forms.Label tenNLLabel;
            System.Windows.Forms.Label maNhomNLLabel;
            System.Windows.Forms.Label soLuongTonLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_QLKhoNguyenLieu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btn_Luu = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.dongia = new DevComponents.Editors.DoubleInput();
            this.nhacungcap = new System.Windows.Forms.ComboBox();
            this.monan = new System.Windows.Forms.ComboBox();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.ngaynhap = new System.Windows.Forms.DateTimePicker();
            this.soluong = new System.Windows.Forms.NumericUpDown();
            this.maphieunhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.donViTinhTextBox = new System.Windows.Forms.TextBox();
            this.soLuongTonTextBox = new System.Windows.Forms.TextBox();
            this.tenNLTextBox = new System.Windows.Forms.TextBox();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.nguyenLieu2DataGridViewX = new DevComponents.DotNetBar.Controls.DataGridViewX();
            maNCCLabel = new System.Windows.Forms.Label();
            donViTinhLabel = new System.Windows.Forms.Label();
            tenNLLabel = new System.Windows.Forms.Label();
            maNhomNLLabel = new System.Windows.Forms.Label();
            soLuongTonLabel = new System.Windows.Forms.Label();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dongia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluong)).BeginInit();
            this.groupPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieu2DataGridViewX)).BeginInit();
            this.SuspendLayout();
            // 
            // maNCCLabel
            // 
            maNCCLabel.AutoSize = true;
            maNCCLabel.Location = new System.Drawing.Point(53, 55);
            maNCCLabel.Name = "maNCCLabel";
            maNCCLabel.Size = new System.Drawing.Size(80, 13);
            maNCCLabel.TabIndex = 0;
            maNCCLabel.Text = "Nhà Cung Cấp:";
            // 
            // donViTinhLabel
            // 
            donViTinhLabel.AutoSize = true;
            donViTinhLabel.Location = new System.Drawing.Point(53, 163);
            donViTinhLabel.Name = "donViTinhLabel";
            donViTinhLabel.Size = new System.Drawing.Size(68, 13);
            donViTinhLabel.TabIndex = 6;
            donViTinhLabel.Text = "Đơn Vị Tính:";
            // 
            // tenNLLabel
            // 
            tenNLLabel.AutoSize = true;
            tenNLLabel.Location = new System.Drawing.Point(53, 91);
            tenNLLabel.Name = "tenNLLabel";
            tenNLLabel.Size = new System.Drawing.Size(92, 13);
            tenNLLabel.TabIndex = 2;
            tenNLLabel.Text = "Tên Nguyên Liệu:";
            // 
            // maNhomNLLabel
            // 
            maNhomNLLabel.AutoSize = true;
            maNhomNLLabel.Location = new System.Drawing.Point(53, 200);
            maNhomNLLabel.Name = "maNhomNLLabel";
            maNhomNLLabel.Size = new System.Drawing.Size(101, 13);
            maNhomNLLabel.TabIndex = 8;
            maNhomNLLabel.Text = "Nhóm Nguyên Liệu:";
            // 
            // soLuongTonLabel
            // 
            soLuongTonLabel.AutoSize = true;
            soLuongTonLabel.Location = new System.Drawing.Point(53, 127);
            soLuongTonLabel.Name = "soLuongTonLabel";
            soLuongTonLabel.Size = new System.Drawing.Size(78, 13);
            soLuongTonLabel.TabIndex = 4;
            soLuongTonLabel.Text = "Số Lượng Tồn:";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.superTabControl1);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel2.Location = new System.Drawing.Point(415, 1);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(881, 311);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 19;
            this.groupPanel2.Text = "danh sách món ăn";
            // 
            // superTabControl1
            // 
            this.superTabControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.superTabControl1.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.superTabControl1.ControlBox.MenuBox.Name = "";
            this.superTabControl1.ControlBox.Name = "";
            this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.superTabControl1.ControlBox.MenuBox,
            this.superTabControl1.ControlBox.CloseBox});
            this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControl1.Location = new System.Drawing.Point(0, 0);
            this.superTabControl1.Name = "superTabControl1";
            this.superTabControl1.ReorderTabsEnabled = true;
            this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.superTabControl1.SelectedTabIndex = 2;
            this.superTabControl1.Size = new System.Drawing.Size(875, 290);
            this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.superTabControl1.TabIndex = 0;
            this.superTabControl1.Text = "superTabControl1";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.panel3);
            this.groupPanel1.Controls.Add(this.panel2);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupPanel1.Location = new System.Drawing.Point(5, 1);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(410, 594);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 18;
            this.groupPanel1.Text = "danh sách bàn en";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btn_Luu);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 449);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(404, 123);
            this.panel3.TabIndex = 1;
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
            this.btnHuy.Location = new System.Drawing.Point(213, 11);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnHuy.Size = new System.Drawing.Size(99, 50);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 28;
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
            this.btn_Luu.Location = new System.Drawing.Point(70, 11);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_Luu.Size = new System.Drawing.Size(99, 50);
            this.btn_Luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Luu.TabIndex = 27;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelX8);
            this.panel2.Controls.Add(this.dongia);
            this.panel2.Controls.Add(this.nhacungcap);
            this.panel2.Controls.Add(this.monan);
            this.panel2.Controls.Add(this.labelX7);
            this.panel2.Controls.Add(this.labelX6);
            this.panel2.Controls.Add(this.labelX5);
            this.panel2.Controls.Add(this.labelX4);
            this.panel2.Controls.Add(this.labelX3);
            this.panel2.Controls.Add(this.labelX2);
            this.panel2.Controls.Add(this.ngaynhap);
            this.panel2.Controls.Add(this.soluong);
            this.panel2.Controls.Add(this.maphieunhap);
            this.panel2.Controls.Add(this.labelX1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(404, 449);
            this.panel2.TabIndex = 0;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX8.ForeColor = System.Drawing.Color.Maroon;
            this.labelX8.Location = new System.Drawing.Point(160, 327);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(160, 23);
            this.labelX8.TabIndex = 16;
            this.labelX8.Text = ".000VND";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // dongia
            // 
            // 
            // 
            // 
            this.dongia.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dongia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dongia.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.dongia.Increment = 1D;
            this.dongia.Location = new System.Drawing.Point(160, 266);
            this.dongia.Name = "dongia";
            this.dongia.ShowUpDown = true;
            this.dongia.Size = new System.Drawing.Size(160, 21);
            this.dongia.TabIndex = 15;
            // 
            // nhacungcap
            // 
            this.nhacungcap.DisplayMember = "TenNCC";
            this.nhacungcap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nhacungcap.FormattingEnabled = true;
            this.nhacungcap.Location = new System.Drawing.Point(160, 132);
            this.nhacungcap.Name = "nhacungcap";
            this.nhacungcap.Size = new System.Drawing.Size(160, 23);
            this.nhacungcap.TabIndex = 14;
            this.nhacungcap.ValueMember = "MaNCC";
            // 
            // monan
            // 
            this.monan.DisplayMember = "TenNL";
            this.monan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monan.FormattingEnabled = true;
            this.monan.Location = new System.Drawing.Point(160, 86);
            this.monan.Name = "monan";
            this.monan.Size = new System.Drawing.Size(160, 23);
            this.monan.TabIndex = 13;
            this.monan.ValueMember = "MaNL";
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(44, 327);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "Tổng Công:";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(44, 261);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 21);
            this.labelX6.TabIndex = 11;
            this.labelX6.Text = "đơn giá";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(44, 223);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 21);
            this.labelX5.TabIndex = 10;
            this.labelX5.Text = "số lượng";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(44, 175);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 21);
            this.labelX4.TabIndex = 9;
            this.labelX4.Text = "ngày nhập";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(44, 132);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 21);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "nhà cung cấp";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(44, 89);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(88, 21);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "tên món ắn";
            // 
            // ngaynhap
            // 
            this.ngaynhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaynhap.Location = new System.Drawing.Point(160, 180);
            this.ngaynhap.Name = "ngaynhap";
            this.ngaynhap.Size = new System.Drawing.Size(160, 21);
            this.ngaynhap.TabIndex = 3;
            // 
            // soluong
            // 
            this.soluong.Location = new System.Drawing.Point(160, 223);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(160, 21);
            this.soluong.TabIndex = 2;
            // 
            // maphieunhap
            // 
            // 
            // 
            // 
            this.maphieunhap.Border.Class = "TextBoxBorder";
            this.maphieunhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.maphieunhap.Enabled = false;
            this.maphieunhap.Location = new System.Drawing.Point(160, 47);
            this.maphieunhap.Name = "maphieunhap";
            this.maphieunhap.Size = new System.Drawing.Size(160, 21);
            this.maphieunhap.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(44, 46);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(97, 21);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "mã phiếu nhập";
            // 
            // groupPanel4
            // 
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.panel1);
            this.groupPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel4.Location = new System.Drawing.Point(415, 312);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(390, 283);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 23;
            this.groupPanel4.Text = "groupPanel4";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(maNCCLabel);
            this.panel1.Controls.Add(donViTinhLabel);
            this.panel1.Controls.Add(this.donViTinhTextBox);
            this.panel1.Controls.Add(tenNLLabel);
            this.panel1.Controls.Add(this.soLuongTonTextBox);
            this.panel1.Controls.Add(maNhomNLLabel);
            this.panel1.Controls.Add(this.tenNLTextBox);
            this.panel1.Controls.Add(soLuongTonLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 262);
            this.panel1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DisplayMember = "TenNhomNL";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(193, 195);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(170, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.ValueMember = "MaNhomNL";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "TenNCC";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(193, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "MaNCC";
            // 
            // donViTinhTextBox
            // 
            this.donViTinhTextBox.Location = new System.Drawing.Point(193, 158);
            this.donViTinhTextBox.Name = "donViTinhTextBox";
            this.donViTinhTextBox.Size = new System.Drawing.Size(170, 20);
            this.donViTinhTextBox.TabIndex = 7;
            // 
            // soLuongTonTextBox
            // 
            this.soLuongTonTextBox.Location = new System.Drawing.Point(193, 122);
            this.soLuongTonTextBox.Name = "soLuongTonTextBox";
            this.soLuongTonTextBox.Size = new System.Drawing.Size(170, 20);
            this.soLuongTonTextBox.TabIndex = 5;
            // 
            // tenNLTextBox
            // 
            this.tenNLTextBox.Location = new System.Drawing.Point(193, 86);
            this.tenNLTextBox.Name = "tenNLTextBox";
            this.tenNLTextBox.Size = new System.Drawing.Size(170, 20);
            this.tenNLTextBox.TabIndex = 3;
            // 
            // groupPanel3
            // 
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.nguyenLieu2DataGridViewX);
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupPanel3.Location = new System.Drawing.Point(805, 312);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(491, 283);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 22;
            this.groupPanel3.Text = "Các Nguyên Liệu Sắp Hết Trong Kho";
            // 
            // nguyenLieu2DataGridViewX
            // 
            this.nguyenLieu2DataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nguyenLieu2DataGridViewX.DefaultCellStyle = dataGridViewCellStyle1;
            this.nguyenLieu2DataGridViewX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nguyenLieu2DataGridViewX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.nguyenLieu2DataGridViewX.Location = new System.Drawing.Point(0, 0);
            this.nguyenLieu2DataGridViewX.Name = "nguyenLieu2DataGridViewX";
            this.nguyenLieu2DataGridViewX.Size = new System.Drawing.Size(485, 262);
            this.nguyenLieu2DataGridViewX.TabIndex = 1;
            // 
            // Form_QLKhoNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 597);
            this.Controls.Add(this.groupPanel4);
            this.Controls.Add(this.groupPanel3);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Name = "Form_QLKhoNguyenLieu";
            this.Text = "Form_QLKhoNguyenLieu";
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dongia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soluong)).EndInit();
            this.groupPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nguyenLieu2DataGridViewX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.SuperTabControl superTabControl1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btn_Luu;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.Editors.DoubleInput dongia;
        private System.Windows.Forms.ComboBox nhacungcap;
        private System.Windows.Forms.ComboBox monan;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.DateTimePicker ngaynhap;
        private System.Windows.Forms.NumericUpDown soluong;
        private DevComponents.DotNetBar.Controls.TextBoxX maphieunhap;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox donViTinhTextBox;
        private System.Windows.Forms.TextBox soLuongTonTextBox;
        private System.Windows.Forms.TextBox tenNLTextBox;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.DataGridViewX nguyenLieu2DataGridViewX;
    }
}