namespace NhaHang
{
    partial class FormKhachHang
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label maKHLabel;
            System.Windows.Forms.Label tenKHLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label soCMNDLabel;
            System.Windows.Forms.Label diemTichLuyLabel;
            System.Windows.Forms.Label maLKHLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kHACHHANGDataGridViewX = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDori = new NhaHang.DataDori();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLast = new DevComponents.DotNetBar.ButtonX();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.btnPre = new DevComponents.DotNetBar.ButtonX();
            this.btnFist = new DevComponents.DotNetBar.ButtonX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_tt = new System.Windows.Forms.Panel();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lOAIKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maKHTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tenKHTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.diaChiTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.sDTTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.emailTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.soCMNDTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.diemTichLuyTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_huy = new DevComponents.DotNetBar.ButtonX();
            this.btn_them = new DevComponents.DotNetBar.ButtonX();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonX();
            this.btn_luu = new DevComponents.DotNetBar.ButtonX();
            this.btn_sua = new DevComponents.DotNetBar.ButtonX();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.kHACHHANGTableAdapter = new NhaHang.DataDoriTableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new NhaHang.DataDoriTableAdapters.TableAdapterManager();
            this.lOAIKHTableAdapter = new NhaHang.DataDoriTableAdapters.LOAIKHTableAdapter();
            maKHLabel = new System.Windows.Forms.Label();
            tenKHLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            soCMNDLabel = new System.Windows.Forms.Label();
            diemTichLuyLabel = new System.Windows.Forms.Label();
            maLKHLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGDataGridViewX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDori)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_tt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIKHBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // maKHLabel
            // 
            maKHLabel.AutoSize = true;
            maKHLabel.Location = new System.Drawing.Point(182, 32);
            maKHLabel.Name = "maKHLabel";
            maKHLabel.Size = new System.Drawing.Size(43, 13);
            maKHLabel.TabIndex = 0;
            maKHLabel.Text = "Ma KH:";
            // 
            // tenKHLabel
            // 
            tenKHLabel.AutoSize = true;
            tenKHLabel.Location = new System.Drawing.Point(182, 58);
            tenKHLabel.Name = "tenKHLabel";
            tenKHLabel.Size = new System.Drawing.Size(47, 13);
            tenKHLabel.TabIndex = 2;
            tenKHLabel.Text = "Ten KH:";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(182, 84);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(44, 13);
            diaChiLabel.TabIndex = 4;
            diaChiLabel.Text = "Dia Chi:";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(182, 110);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(32, 13);
            sDTLabel.TabIndex = 6;
            sDTLabel.Text = "SDT:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(182, 136);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // soCMNDLabel
            // 
            soCMNDLabel.AutoSize = true;
            soCMNDLabel.Location = new System.Drawing.Point(182, 162);
            soCMNDLabel.Name = "soCMNDLabel";
            soCMNDLabel.Size = new System.Drawing.Size(58, 13);
            soCMNDLabel.TabIndex = 10;
            soCMNDLabel.Text = "So CMND:";
            // 
            // diemTichLuyLabel
            // 
            diemTichLuyLabel.AutoSize = true;
            diemTichLuyLabel.Location = new System.Drawing.Point(182, 188);
            diemTichLuyLabel.Name = "diemTichLuyLabel";
            diemTichLuyLabel.Size = new System.Drawing.Size(78, 13);
            diemTichLuyLabel.TabIndex = 12;
            diemTichLuyLabel.Text = "Diem Tich Luy:";
            // 
            // maLKHLabel
            // 
            maLKHLabel.AutoSize = true;
            maLKHLabel.Location = new System.Drawing.Point(182, 214);
            maLKHLabel.Name = "maLKHLabel";
            maLKHLabel.Size = new System.Drawing.Size(49, 13);
            maLKHLabel.TabIndex = 14;
            maLKHLabel.Text = "Ma LKH:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reflectionLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1263, 54);
            this.panel1.TabIndex = 2;
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.reflectionLabel1.Location = new System.Drawing.Point(432, 3);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(267, 48);
            this.reflectionLabel1.TabIndex = 0;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Quản Lý</i><font color=\"#B02B2C\"> Khách Hàng</font></font><" +
    "/b>";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1263, 484);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.kHACHHANGDataGridViewX);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(578, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(685, 484);
            this.panel4.TabIndex = 1;
            // 
            // kHACHHANGDataGridViewX
            // 
            this.kHACHHANGDataGridViewX.AutoGenerateColumns = false;
            this.kHACHHANGDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kHACHHANGDataGridViewX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.kHACHHANGDataGridViewX.DataSource = this.kHACHHANGBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.kHACHHANGDataGridViewX.DefaultCellStyle = dataGridViewCellStyle1;
            this.kHACHHANGDataGridViewX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kHACHHANGDataGridViewX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.kHACHHANGDataGridViewX.Location = new System.Drawing.Point(0, 0);
            this.kHACHHANGDataGridViewX.Name = "kHACHHANGDataGridViewX";
            this.kHACHHANGDataGridViewX.Size = new System.Drawing.Size(597, 484);
            this.kHACHHANGDataGridViewX.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaKH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenKH";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn3.HeaderText = "DiaChi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn4.HeaderText = "SDT";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SoCMND";
            this.dataGridViewTextBoxColumn6.HeaderText = "SoCMND";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DiemTichLuy";
            this.dataGridViewTextBoxColumn7.HeaderText = "DiemTichLuy";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MaLKH";
            this.dataGridViewTextBoxColumn8.HeaderText = "MaLKH";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // kHACHHANGBindingSource
            // 
            this.kHACHHANGBindingSource.DataMember = "KHACHHANG";
            this.kHACHHANGBindingSource.DataSource = this.dataDori;
            // 
            // dataDori
            // 
            this.dataDori.DataSetName = "DataDori";
            this.dataDori.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnLast);
            this.panel7.Controls.Add(this.btnNext);
            this.panel7.Controls.Add(this.btnPre);
            this.panel7.Controls.Add(this.btnFist);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(597, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(88, 484);
            this.panel7.TabIndex = 0;
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
            this.btnLast.Location = new System.Drawing.Point(25, 349);
            this.btnLast.Name = "btnLast";
            this.btnLast.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnLast.Size = new System.Drawing.Size(42, 68);
            this.btnLast.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLast.TabIndex = 19;
            this.btnLast.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
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
            this.btnNext.Location = new System.Drawing.Point(25, 275);
            this.btnNext.Name = "btnNext";
            this.btnNext.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnNext.Size = new System.Drawing.Size(42, 68);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.TabIndex = 18;
            this.btnNext.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
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
            this.btnPre.Location = new System.Drawing.Point(25, 201);
            this.btnPre.Name = "btnPre";
            this.btnPre.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnPre.Size = new System.Drawing.Size(42, 68);
            this.btnPre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPre.TabIndex = 17;
            this.btnPre.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
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
            this.btnFist.Location = new System.Drawing.Point(25, 127);
            this.btnFist.Name = "btnFist";
            this.btnFist.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnFist.Size = new System.Drawing.Size(42, 68);
            this.btnFist.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFist.TabIndex = 16;
            this.btnFist.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel_tt);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(578, 484);
            this.panel3.TabIndex = 0;
            // 
            // panel_tt
            // 
            this.panel_tt.AutoScroll = true;
            this.panel_tt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_tt.Controls.Add(this.comboBoxEx1);
            this.panel_tt.Controls.Add(maKHLabel);
            this.panel_tt.Controls.Add(this.maKHTextBoxX);
            this.panel_tt.Controls.Add(tenKHLabel);
            this.panel_tt.Controls.Add(this.tenKHTextBoxX);
            this.panel_tt.Controls.Add(diaChiLabel);
            this.panel_tt.Controls.Add(this.diaChiTextBoxX);
            this.panel_tt.Controls.Add(sDTLabel);
            this.panel_tt.Controls.Add(this.sDTTextBoxX);
            this.panel_tt.Controls.Add(emailLabel);
            this.panel_tt.Controls.Add(this.emailTextBoxX);
            this.panel_tt.Controls.Add(soCMNDLabel);
            this.panel_tt.Controls.Add(this.soCMNDTextBoxX);
            this.panel_tt.Controls.Add(diemTichLuyLabel);
            this.panel_tt.Controls.Add(this.diemTichLuyTextBoxX);
            this.panel_tt.Controls.Add(maLKHLabel);
            this.panel_tt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tt.Location = new System.Drawing.Point(0, 142);
            this.panel_tt.Name = "panel_tt";
            this.panel_tt.Size = new System.Drawing.Size(574, 338);
            this.panel_tt.TabIndex = 18;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kHACHHANGBindingSource, "MaLKH", true));
            this.comboBoxEx1.DataSource = this.lOAIKHBindingSource;
            this.comboBoxEx1.DisplayMember = "TenLKH";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(266, 214);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(121, 20);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 15;
            this.comboBoxEx1.ValueMember = "MaLKH";
            // 
            // lOAIKHBindingSource
            // 
            this.lOAIKHBindingSource.DataMember = "LOAIKH";
            this.lOAIKHBindingSource.DataSource = this.dataDori;
            // 
            // maKHTextBoxX
            // 
            // 
            // 
            // 
            this.maKHTextBoxX.Border.Class = "TextBoxBorder";
            this.maKHTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.maKHTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "MaKH", true));
            this.maKHTextBoxX.Location = new System.Drawing.Point(266, 29);
            this.maKHTextBoxX.Name = "maKHTextBoxX";
            this.maKHTextBoxX.Size = new System.Drawing.Size(121, 20);
            this.maKHTextBoxX.TabIndex = 1;
            // 
            // tenKHTextBoxX
            // 
            // 
            // 
            // 
            this.tenKHTextBoxX.Border.Class = "TextBoxBorder";
            this.tenKHTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tenKHTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "TenKH", true));
            this.tenKHTextBoxX.Location = new System.Drawing.Point(266, 55);
            this.tenKHTextBoxX.Name = "tenKHTextBoxX";
            this.tenKHTextBoxX.Size = new System.Drawing.Size(121, 20);
            this.tenKHTextBoxX.TabIndex = 3;
            // 
            // diaChiTextBoxX
            // 
            // 
            // 
            // 
            this.diaChiTextBoxX.Border.Class = "TextBoxBorder";
            this.diaChiTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diaChiTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "DiaChi", true));
            this.diaChiTextBoxX.Location = new System.Drawing.Point(266, 81);
            this.diaChiTextBoxX.Name = "diaChiTextBoxX";
            this.diaChiTextBoxX.Size = new System.Drawing.Size(121, 20);
            this.diaChiTextBoxX.TabIndex = 5;
            // 
            // sDTTextBoxX
            // 
            // 
            // 
            // 
            this.sDTTextBoxX.Border.Class = "TextBoxBorder";
            this.sDTTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.sDTTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "SDT", true));
            this.sDTTextBoxX.Location = new System.Drawing.Point(266, 107);
            this.sDTTextBoxX.Name = "sDTTextBoxX";
            this.sDTTextBoxX.Size = new System.Drawing.Size(121, 20);
            this.sDTTextBoxX.TabIndex = 7;
            // 
            // emailTextBoxX
            // 
            // 
            // 
            // 
            this.emailTextBoxX.Border.Class = "TextBoxBorder";
            this.emailTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.emailTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "Email", true));
            this.emailTextBoxX.Location = new System.Drawing.Point(266, 133);
            this.emailTextBoxX.Name = "emailTextBoxX";
            this.emailTextBoxX.Size = new System.Drawing.Size(121, 20);
            this.emailTextBoxX.TabIndex = 9;
            // 
            // soCMNDTextBoxX
            // 
            // 
            // 
            // 
            this.soCMNDTextBoxX.Border.Class = "TextBoxBorder";
            this.soCMNDTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.soCMNDTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "SoCMND", true));
            this.soCMNDTextBoxX.Location = new System.Drawing.Point(266, 159);
            this.soCMNDTextBoxX.Name = "soCMNDTextBoxX";
            this.soCMNDTextBoxX.Size = new System.Drawing.Size(121, 20);
            this.soCMNDTextBoxX.TabIndex = 11;
            // 
            // diemTichLuyTextBoxX
            // 
            // 
            // 
            // 
            this.diemTichLuyTextBoxX.Border.Class = "TextBoxBorder";
            this.diemTichLuyTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.diemTichLuyTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kHACHHANGBindingSource, "DiemTichLuy", true));
            this.diemTichLuyTextBoxX.Location = new System.Drawing.Point(266, 185);
            this.diemTichLuyTextBoxX.Name = "diemTichLuyTextBoxX";
            this.diemTichLuyTextBoxX.Size = new System.Drawing.Size(121, 20);
            this.diemTichLuyTextBoxX.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_huy);
            this.panel6.Controls.Add(this.btn_them);
            this.panel6.Controls.Add(this.btn_xoa);
            this.panel6.Controls.Add(this.btn_luu);
            this.panel6.Controls.Add(this.btn_sua);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 71);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(574, 71);
            this.panel6.TabIndex = 1;
            // 
            // btn_huy
            // 
            this.btn_huy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_huy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_huy.Image")));
            this.btn_huy.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btn_huy.ImageTextSpacing = 1;
            this.btn_huy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_huy.Location = new System.Drawing.Point(471, 7);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_huy.Size = new System.Drawing.Size(99, 50);
            this.btn_huy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_huy.TabIndex = 26;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_them
            // 
            this.btn_them.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_them.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageTextSpacing = 1;
            this.btn_them.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_them.Location = new System.Drawing.Point(3, 7);
            this.btn_them.Name = "btn_them";
            this.btn_them.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_them.Size = new System.Drawing.Size(99, 50);
            this.btn_them.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_them.TabIndex = 22;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageTextSpacing = 1;
            this.btn_xoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_xoa.Location = new System.Drawing.Point(120, 7);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_xoa.Size = new System.Drawing.Size(99, 50);
            this.btn_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_xoa.TabIndex = 23;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_luu.Image")));
            this.btn_luu.ImageTextSpacing = 1;
            this.btn_luu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_luu.Location = new System.Drawing.Point(349, 7);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_luu.Size = new System.Drawing.Size(99, 50);
            this.btn_luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_luu.TabIndex = 25;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_sua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_sua.Image = ((System.Drawing.Image)(resources.GetObject("btn_sua.Image")));
            this.btn_sua.ImageFixedSize = new System.Drawing.Size(32, 32);
            this.btn_sua.ImageTextSpacing = 1;
            this.btn_sua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_sua.Location = new System.Drawing.Point(232, 7);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_sua.Size = new System.Drawing.Size(99, 50);
            this.btn_sua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_sua.TabIndex = 24;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBoxX1);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.labelX1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(574, 71);
            this.panel5.TabIndex = 0;
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxX1.Location = new System.Drawing.Point(255, 23);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(223, 26);
            this.textBoxX1.TabIndex = 7;
            this.textBoxX1.TextChanged += new System.EventHandler(this.textBoxX1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(232, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(7, 24);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(217, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Nhập tên khách hàng cần tìm:";
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANTableAdapter = null;
            this.tableAdapterManager.CONGTHUCMATableAdapter = null;
            this.tableAdapterManager.CT_CONGTHUCTableAdapter = null;
            this.tableAdapterManager.CT_DICHVUTableAdapter = null;
            this.tableAdapterManager.CT_MONANTableAdapter = null;
            this.tableAdapterManager.CT_PHIEUGIAOHANGTableAdapter = null;
            this.tableAdapterManager.CT_PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = this.kHACHHANGTableAdapter;
            this.tableAdapterManager.KHUVUCTableAdapter = null;
            this.tableAdapterManager.LOAIKHTableAdapter = this.lOAIKHTableAdapter;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.MANHINHTableAdapter = null;
            this.tableAdapterManager.MONANTableAdapter = null;
            this.tableAdapterManager.NCCTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGNHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NGUYENLIEUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMMATableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATMONTableAdapter = null;
            this.tableAdapterManager.PHIEUDATVETableAdapter = null;
            this.tableAdapterManager.PHIEUGIAOHANGTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NhaHang.DataDoriTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOAIKHTableAdapter
            // 
            this.lOAIKHTableAdapter.ClearBeforeFill = true;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 541);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGDataGridViewX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDori)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_tt.ResumeLayout(false);
            this.panel_tt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAIKHBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private DevComponents.DotNetBar.ButtonX btnLast;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.ButtonX btnPre;
        private DevComponents.DotNetBar.ButtonX btnFist;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private DevComponents.DotNetBar.ButtonX btn_huy;
        private DevComponents.DotNetBar.ButtonX btn_them;
        private DevComponents.DotNetBar.ButtonX btn_xoa;
        private DevComponents.DotNetBar.ButtonX btn_luu;
        private DevComponents.DotNetBar.ButtonX btn_sua;
        private System.Windows.Forms.Panel panel5;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_tt;
        private DataDori dataDori;
        private System.Windows.Forms.BindingSource kHACHHANGBindingSource;
        private DataDoriTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private DataDoriTableAdapters.TableAdapterManager tableAdapterManager;
        private DevComponents.DotNetBar.Controls.TextBoxX maKHTextBoxX;
        private DevComponents.DotNetBar.Controls.TextBoxX tenKHTextBoxX;
        private DevComponents.DotNetBar.Controls.TextBoxX diaChiTextBoxX;
        private DevComponents.DotNetBar.Controls.TextBoxX sDTTextBoxX;
        private DevComponents.DotNetBar.Controls.TextBoxX emailTextBoxX;
        private DevComponents.DotNetBar.Controls.TextBoxX soCMNDTextBoxX;
        private DevComponents.DotNetBar.Controls.TextBoxX diemTichLuyTextBoxX;
        private DevComponents.DotNetBar.Controls.DataGridViewX kHACHHANGDataGridViewX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataDoriTableAdapters.LOAIKHTableAdapter lOAIKHTableAdapter;
        private System.Windows.Forms.BindingSource lOAIKHBindingSource;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
    }
}