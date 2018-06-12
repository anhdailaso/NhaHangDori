namespace NhaHang
{
    partial class NguyenLieu
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
            System.Windows.Forms.Label maNLLabel;
            System.Windows.Forms.Label tenNLLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label maNCCLabel;
            System.Windows.Forms.Label kLTonLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NguyenLieu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_tt = new System.Windows.Forms.Panel();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.nGUYENLIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDori = new NhaHang.DataDori();
            this.nCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maNLTextBox = new System.Windows.Forms.TextBox();
            this.tenNLTextBox = new System.Windows.Forms.TextBox();
            this.dVTTextBox = new System.Windows.Forms.TextBox();
            this.kLTonTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.hinhAnhPictureBox = new System.Windows.Forms.PictureBox();
            this.btnChonHinh = new DevComponents.DotNetBar.ButtonX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nGUYENLIEUDataGridViewX = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.btnLast = new DevComponents.DotNetBar.ButtonX();
            this.btnFist = new DevComponents.DotNetBar.ButtonX();
            this.btnPre = new DevComponents.DotNetBar.ButtonX();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btn_Luu = new DevComponents.DotNetBar.ButtonX();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.nGUYENLIEUTableAdapter = new NhaHang.DataDoriTableAdapters.NGUYENLIEUTableAdapter();
            this.tableAdapterManager = new NhaHang.DataDoriTableAdapters.TableAdapterManager();
            this.nCCTableAdapter = new NhaHang.DataDoriTableAdapters.NCCTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            maNLLabel = new System.Windows.Forms.Label();
            tenNLLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            maNCCLabel = new System.Windows.Forms.Label();
            kLTonLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_tt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGUYENLIEUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCCBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnhPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGUYENLIEUDataGridViewX)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // maNLLabel
            // 
            maNLLabel.AutoSize = true;
            maNLLabel.Location = new System.Drawing.Point(23, 26);
            maNLLabel.Name = "maNLLabel";
            maNLLabel.Size = new System.Drawing.Size(88, 13);
            maNLLabel.TabIndex = 0;
            maNLLabel.Text = "Mã Nguyên Liệu:";
            // 
            // tenNLLabel
            // 
            tenNLLabel.AutoSize = true;
            tenNLLabel.Location = new System.Drawing.Point(23, 52);
            tenNLLabel.Name = "tenNLLabel";
            tenNLLabel.Size = new System.Drawing.Size(95, 13);
            tenNLLabel.TabIndex = 2;
            tenNLLabel.Text = "Tên Nguyên Liệu :";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(23, 78);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(71, 13);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "Đơn Vị Tính :";
            // 
            // maNCCLabel
            // 
            maNCCLabel.AutoSize = true;
            maNCCLabel.Location = new System.Drawing.Point(23, 104);
            maNCCLabel.Name = "maNCCLabel";
            maNCCLabel.Size = new System.Drawing.Size(83, 13);
            maNCCLabel.TabIndex = 6;
            maNCCLabel.Text = "Nhà Cung Cấp :";
            // 
            // kLTonLabel
            // 
            kLTonLabel.AutoSize = true;
            kLTonLabel.Location = new System.Drawing.Point(23, 130);
            kLTonLabel.Name = "kLTonLabel";
            kLTonLabel.Size = new System.Drawing.Size(83, 13);
            kLTonLabel.TabIndex = 10;
            kLTonLabel.Text = "Khối Lượn Tồn :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reflectionLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1288, 59);
            this.panel2.TabIndex = 28;
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.reflectionLabel1.Location = new System.Drawing.Point(488, 4);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(246, 50);
            this.reflectionLabel1.TabIndex = 0;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Quản Lý Nguyên Liệu</i></font></b>";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel_tt);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 471);
            this.panel1.TabIndex = 29;
            // 
            // panel_tt
            // 
            this.panel_tt.AutoScroll = true;
            this.panel_tt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_tt.Controls.Add(this.comboBoxEx1);
            this.panel_tt.Controls.Add(maNLLabel);
            this.panel_tt.Controls.Add(this.maNLTextBox);
            this.panel_tt.Controls.Add(tenNLLabel);
            this.panel_tt.Controls.Add(this.tenNLTextBox);
            this.panel_tt.Controls.Add(dVTLabel);
            this.panel_tt.Controls.Add(this.dVTTextBox);
            this.panel_tt.Controls.Add(maNCCLabel);
            this.panel_tt.Controls.Add(kLTonLabel);
            this.panel_tt.Controls.Add(this.kLTonTextBox);
            this.panel_tt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tt.Location = new System.Drawing.Point(0, 244);
            this.panel_tt.Name = "panel_tt";
            this.panel_tt.Size = new System.Drawing.Size(364, 223);
            this.panel_tt.TabIndex = 1;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.nGUYENLIEUBindingSource, "MaNCC", true));
            this.comboBoxEx1.DataSource = this.nCCBindingSource;
            this.comboBoxEx1.DisplayMember = "TenNCC";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(133, 101);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(186, 20);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 12;
            this.comboBoxEx1.ValueMember = "MaNCC";
            // 
            // nGUYENLIEUBindingSource
            // 
            this.nGUYENLIEUBindingSource.DataMember = "NGUYENLIEU";
            this.nGUYENLIEUBindingSource.DataSource = this.dataDori;
            // 
            // dataDori
            // 
            this.dataDori.DataSetName = "DataDori";
            this.dataDori.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nCCBindingSource
            // 
            this.nCCBindingSource.DataMember = "NCC";
            this.nCCBindingSource.DataSource = this.dataDori;
            // 
            // maNLTextBox
            // 
            this.maNLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nGUYENLIEUBindingSource, "MaNL", true));
            this.maNLTextBox.Location = new System.Drawing.Point(133, 23);
            this.maNLTextBox.Name = "maNLTextBox";
            this.maNLTextBox.Size = new System.Drawing.Size(186, 20);
            this.maNLTextBox.TabIndex = 1;
            // 
            // tenNLTextBox
            // 
            this.tenNLTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nGUYENLIEUBindingSource, "TenNL", true));
            this.tenNLTextBox.Location = new System.Drawing.Point(133, 49);
            this.tenNLTextBox.Name = "tenNLTextBox";
            this.tenNLTextBox.Size = new System.Drawing.Size(186, 20);
            this.tenNLTextBox.TabIndex = 3;
            // 
            // dVTTextBox
            // 
            this.dVTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nGUYENLIEUBindingSource, "DVT", true));
            this.dVTTextBox.Location = new System.Drawing.Point(133, 75);
            this.dVTTextBox.Name = "dVTTextBox";
            this.dVTTextBox.Size = new System.Drawing.Size(186, 20);
            this.dVTTextBox.TabIndex = 5;
            // 
            // kLTonTextBox
            // 
            this.kLTonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nGUYENLIEUBindingSource, "KLTon", true));
            this.kLTonTextBox.Location = new System.Drawing.Point(133, 127);
            this.kLTonTextBox.Name = "kLTonTextBox";
            this.kLTonTextBox.Size = new System.Drawing.Size(186, 20);
            this.kLTonTextBox.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.hinhAnhPictureBox);
            this.panel4.Controls.Add(this.btnChonHinh);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(364, 244);
            this.panel4.TabIndex = 0;
            // 
            // hinhAnhPictureBox
            // 
            this.hinhAnhPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.nGUYENLIEUBindingSource, "HinhAnh", true));
            this.hinhAnhPictureBox.Location = new System.Drawing.Point(35, 19);
            this.hinhAnhPictureBox.Name = "hinhAnhPictureBox";
            this.hinhAnhPictureBox.Size = new System.Drawing.Size(177, 186);
            this.hinhAnhPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hinhAnhPictureBox.TabIndex = 30;
            this.hinhAnhPictureBox.TabStop = false;
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
            this.btnChonHinh.Location = new System.Drawing.Point(236, 100);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnChonHinh.Size = new System.Drawing.Size(121, 42);
            this.btnChonHinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChonHinh.TabIndex = 29;
            this.btnChonHinh.Text = "chọn hình";
            this.btnChonHinh.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.nGUYENLIEUDataGridViewX);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel12);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(373, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(920, 471);
            this.panel3.TabIndex = 30;
            // 
            // nGUYENLIEUDataGridViewX
            // 
            this.nGUYENLIEUDataGridViewX.AutoGenerateColumns = false;
            this.nGUYENLIEUDataGridViewX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nGUYENLIEUDataGridViewX.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.nGUYENLIEUDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nGUYENLIEUDataGridViewX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn5});
            this.nGUYENLIEUDataGridViewX.DataSource = this.nGUYENLIEUBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nGUYENLIEUDataGridViewX.DefaultCellStyle = dataGridViewCellStyle2;
            this.nGUYENLIEUDataGridViewX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nGUYENLIEUDataGridViewX.EnableHeadersVisualStyles = false;
            this.nGUYENLIEUDataGridViewX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.nGUYENLIEUDataGridViewX.Location = new System.Drawing.Point(0, 81);
            this.nGUYENLIEUDataGridViewX.Name = "nGUYENLIEUDataGridViewX";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nGUYENLIEUDataGridViewX.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.nGUYENLIEUDataGridViewX.Size = new System.Drawing.Size(861, 386);
            this.nGUYENLIEUDataGridViewX.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNL";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaNL";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenNL";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenNL";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DVT";
            this.dataGridViewTextBoxColumn3.HeaderText = "DVT";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MaNCC";
            this.dataGridViewTextBoxColumn4.HeaderText = "MaNCC";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "HinhAnh";
            this.dataGridViewImageColumn1.HeaderText = "HinhAnh";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "KLTon";
            this.dataGridViewTextBoxColumn5.HeaderText = "KLTon";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.btnNext);
            this.panel6.Controls.Add(this.btnLast);
            this.panel6.Controls.Add(this.btnFist);
            this.panel6.Controls.Add(this.btnPre);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(861, 81);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(55, 386);
            this.panel6.TabIndex = 24;
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
            this.btnNext.Location = new System.Drawing.Point(6, 167);
            this.btnNext.Name = "btnNext";
            this.btnNext.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnNext.Size = new System.Drawing.Size(42, 68);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.TabIndex = 22;
            this.btnNext.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
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
            this.btnLast.Location = new System.Drawing.Point(6, 241);
            this.btnLast.Name = "btnLast";
            this.btnLast.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnLast.Size = new System.Drawing.Size(42, 68);
            this.btnLast.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLast.TabIndex = 23;
            this.btnLast.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
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
            this.btnFist.Location = new System.Drawing.Point(6, 19);
            this.btnFist.Name = "btnFist";
            this.btnFist.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnFist.Size = new System.Drawing.Size(42, 68);
            this.btnFist.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnFist.TabIndex = 20;
            this.btnFist.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
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
            this.btnPre.Location = new System.Drawing.Point(6, 93);
            this.btnPre.Name = "btnPre";
            this.btnPre.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnPre.Size = new System.Drawing.Size(42, 68);
            this.btnPre.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPre.TabIndex = 21;
            this.btnPre.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnThem);
            this.panel12.Controls.Add(this.btn_Luu);
            this.panel12.Controls.Add(this.btn_xoa);
            this.panel12.Controls.Add(this.btnHuy);
            this.panel12.Controls.Add(this.btnSua);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(916, 81);
            this.panel12.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTextSpacing = 1;
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(14, 16);
            this.btnThem.Name = "btnThem";
            this.btnThem.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnThem.Size = new System.Drawing.Size(99, 50);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageTextSpacing = 1;
            this.btn_Luu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Luu.Location = new System.Drawing.Point(329, 16);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_Luu.Size = new System.Drawing.Size(99, 50);
            this.btn_Luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Luu.TabIndex = 29;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageTextSpacing = 1;
            this.btn_xoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_xoa.Location = new System.Drawing.Point(119, 16);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_xoa.Size = new System.Drawing.Size(99, 50);
            this.btn_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_xoa.TabIndex = 27;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
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
            this.btnHuy.Location = new System.Drawing.Point(434, 16);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnHuy.Size = new System.Drawing.Size(99, 50);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 30;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.btnSua.Location = new System.Drawing.Point(224, 16);
            this.btnSua.Name = "btnSua";
            this.btnSua.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnSua.Size = new System.Drawing.Size(99, 50);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // nGUYENLIEUTableAdapter
            // 
            this.nGUYENLIEUTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.KHUVUCBANTableAdapter = null;
            this.tableAdapterManager.KHUVUCPHONGTableAdapter = null;
            this.tableAdapterManager.KHUVUCTableAdapter = null;
            this.tableAdapterManager.LOAIKHTableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.MANHINHTableAdapter = null;
            this.tableAdapterManager.MONANTableAdapter = null;
            this.tableAdapterManager.NCCTableAdapter = this.nCCTableAdapter;
            this.tableAdapterManager.NGUOIDUNGNHOMNGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = null;
            this.tableAdapterManager.NGUYENLIEUTableAdapter = this.nGUYENLIEUTableAdapter;
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
            // nCCTableAdapter
            // 
            this.nCCTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1298, 533);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "NguyenLieu";
            this.Text = "NguyenLieu";
            this.Load += new System.EventHandler(this.NguyenLieu_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel_tt.ResumeLayout(false);
            this.panel_tt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGUYENLIEUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCCBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hinhAnhPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nGUYENLIEUDataGridViewX)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel12;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btn_Luu;
        private DevComponents.DotNetBar.ButtonX btn_xoa;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private System.Windows.Forms.Panel panel6;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.ButtonX btnLast;
        private DevComponents.DotNetBar.ButtonX btnFist;
        private DevComponents.DotNetBar.ButtonX btnPre;
        private System.Windows.Forms.Panel panel_tt;
        private DevComponents.DotNetBar.ButtonX btnChonHinh;
        private DataDori dataDori;
        private System.Windows.Forms.BindingSource nGUYENLIEUBindingSource;
        private DataDoriTableAdapters.NGUYENLIEUTableAdapter nGUYENLIEUTableAdapter;
        private DataDoriTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maNLTextBox;
        private System.Windows.Forms.TextBox tenNLTextBox;
        private System.Windows.Forms.TextBox dVTTextBox;
        private System.Windows.Forms.TextBox kLTonTextBox;
        private System.Windows.Forms.PictureBox hinhAnhPictureBox;
        private DevComponents.DotNetBar.Controls.DataGridViewX nGUYENLIEUDataGridViewX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataDoriTableAdapters.NCCTableAdapter nCCTableAdapter;
        private System.Windows.Forms.BindingSource nCCBindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
    }
}