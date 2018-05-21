namespace NhaHang
{
    partial class CTBan
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
            System.Windows.Forms.Label maBLabel;
            System.Windows.Forms.Label maKVLabel;
            System.Windows.Forms.Label maPDLabel;
            System.Windows.Forms.Label tinhTrangLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTBan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btn_xoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btn_Luu = new DevComponents.DotNetBar.ButtonX();
            this.panel_tt = new System.Windows.Forms.Panel();
            this.comboBoxEx1 = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.bANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDori = new NhaHang.DataDori();
            this.kHUVUCBANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maBTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.maPDTextBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tinhTrangComboBoxEx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.bANDataGridViewX = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bANTableAdapter = new NhaHang.DataDoriTableAdapters.BANTableAdapter();
            this.tableAdapterManager = new NhaHang.DataDoriTableAdapters.TableAdapterManager();
            this.kHUVUCBANTableAdapter = new NhaHang.DataDoriTableAdapters.KHUVUCBANTableAdapter();
            maBLabel = new System.Windows.Forms.Label();
            maKVLabel = new System.Windows.Forms.Label();
            maPDLabel = new System.Windows.Forms.Label();
            tinhTrangLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel_tt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUVUCBANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANDataGridViewX)).BeginInit();
            this.SuspendLayout();
            // 
            // maBLabel
            // 
            maBLabel.AutoSize = true;
            maBLabel.Location = new System.Drawing.Point(54, 18);
            maBLabel.Name = "maBLabel";
            maBLabel.Size = new System.Drawing.Size(35, 13);
            maBLabel.TabIndex = 0;
            maBLabel.Text = "Ma B:";
            // 
            // maKVLabel
            // 
            maKVLabel.AutoSize = true;
            maKVLabel.Location = new System.Drawing.Point(54, 44);
            maKVLabel.Name = "maKVLabel";
            maKVLabel.Size = new System.Drawing.Size(42, 13);
            maKVLabel.TabIndex = 2;
            maKVLabel.Text = "Ma KV:";
            // 
            // maPDLabel
            // 
            maPDLabel.AutoSize = true;
            maPDLabel.Location = new System.Drawing.Point(323, 18);
            maPDLabel.Name = "maPDLabel";
            maPDLabel.Size = new System.Drawing.Size(43, 13);
            maPDLabel.TabIndex = 4;
            maPDLabel.Text = "Ma PD:";
            // 
            // tinhTrangLabel
            // 
            tinhTrangLabel.AutoSize = true;
            tinhTrangLabel.Location = new System.Drawing.Point(323, 44);
            tinhTrangLabel.Name = "tinhTrangLabel";
            tinhTrangLabel.Size = new System.Drawing.Size(62, 13);
            tinhTrangLabel.TabIndex = 6;
            tinhTrangLabel.Text = "Tinh Trang:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.reflectionLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 64);
            this.panel1.TabIndex = 2;
            // 
            // btn_thoat
            // 
            this.btn_thoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.btn_thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_thoat.BackgroundImage")));
            this.btn_thoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageFixedSize = new System.Drawing.Size(23, 23);
            this.btn_thoat.Location = new System.Drawing.Point(491, 10);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(15);
            this.btn_thoat.Size = new System.Drawing.Size(80, 34);
            this.btn_thoat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "<b>thoát</b>";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Location = new System.Drawing.Point(216, 3);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reflectionLabel1.Size = new System.Drawing.Size(169, 58);
            this.reflectionLabel1.TabIndex = 0;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Quảng Lý</i><font color=\"#B02B2C\">Phòng</font></font></b>";
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.btnThem);
            this.panel12.Controls.Add(this.btn_xoa);
            this.panel12.Controls.Add(this.btnSua);
            this.panel12.Controls.Add(this.btnHuy);
            this.panel12.Controls.Add(this.btn_Luu);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(5, 65);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(581, 62);
            this.panel12.TabIndex = 3;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTextSpacing = 1;
            this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnThem.Location = new System.Drawing.Point(22, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnThem.Size = new System.Drawing.Size(99, 50);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageTextSpacing = 1;
            this.btn_xoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_xoa.Location = new System.Drawing.Point(127, 6);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_xoa.Size = new System.Drawing.Size(99, 50);
            this.btn_xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_xoa.TabIndex = 42;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(232, 6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnSua.Size = new System.Drawing.Size(99, 50);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 43;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnHuy.Location = new System.Drawing.Point(442, 6);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btnHuy.Size = new System.Drawing.Size(99, 50);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 45;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Luu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageTextSpacing = 1;
            this.btn_Luu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Luu.Location = new System.Drawing.Point(337, 6);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.btn_Luu.Size = new System.Drawing.Size(99, 50);
            this.btn_Luu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Luu.TabIndex = 44;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Left;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // panel_tt
            // 
            this.panel_tt.AutoScroll = true;
            this.panel_tt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_tt.Controls.Add(this.comboBoxEx1);
            this.panel_tt.Controls.Add(maBLabel);
            this.panel_tt.Controls.Add(this.maBTextBoxX);
            this.panel_tt.Controls.Add(maKVLabel);
            this.panel_tt.Controls.Add(maPDLabel);
            this.panel_tt.Controls.Add(this.maPDTextBoxX);
            this.panel_tt.Controls.Add(tinhTrangLabel);
            this.panel_tt.Controls.Add(this.tinhTrangComboBoxEx);
            this.panel_tt.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_tt.Location = new System.Drawing.Point(5, 127);
            this.panel_tt.Name = "panel_tt";
            this.panel_tt.Size = new System.Drawing.Size(581, 76);
            this.panel_tt.TabIndex = 4;
            // 
            // comboBoxEx1
            // 
            this.comboBoxEx1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bANBindingSource, "MaKV", true));
            this.comboBoxEx1.DataSource = this.kHUVUCBANBindingSource;
            this.comboBoxEx1.DisplayMember = "TenKV";
            this.comboBoxEx1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxEx1.FormattingEnabled = true;
            this.comboBoxEx1.ItemHeight = 14;
            this.comboBoxEx1.Location = new System.Drawing.Point(122, 44);
            this.comboBoxEx1.Name = "comboBoxEx1";
            this.comboBoxEx1.Size = new System.Drawing.Size(121, 20);
            this.comboBoxEx1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboBoxEx1.TabIndex = 8;
            this.comboBoxEx1.ValueMember = "MaKV";
            // 
            // bANBindingSource
            // 
            this.bANBindingSource.DataMember = "BAN";
            this.bANBindingSource.DataSource = this.dataDori;
            // 
            // dataDori
            // 
            this.dataDori.DataSetName = "DataDori";
            this.dataDori.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHUVUCBANBindingSource
            // 
            this.kHUVUCBANBindingSource.DataMember = "KHUVUCBAN";
            this.kHUVUCBANBindingSource.DataSource = this.dataDori;
            // 
            // maBTextBoxX
            // 
            // 
            // 
            // 
            this.maBTextBoxX.Border.Class = "TextBoxBorder";
            this.maBTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.maBTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bANBindingSource, "MaB", true));
            this.maBTextBoxX.Location = new System.Drawing.Point(122, 15);
            this.maBTextBoxX.Name = "maBTextBoxX";
            this.maBTextBoxX.Size = new System.Drawing.Size(121, 20);
            this.maBTextBoxX.TabIndex = 1;
            // 
            // maPDTextBoxX
            // 
            // 
            // 
            // 
            this.maPDTextBoxX.Border.Class = "TextBoxBorder";
            this.maPDTextBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.maPDTextBoxX.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bANBindingSource, "MaPD", true));
            this.maPDTextBoxX.Location = new System.Drawing.Point(391, 15);
            this.maPDTextBoxX.Name = "maPDTextBoxX";
            this.maPDTextBoxX.Size = new System.Drawing.Size(121, 20);
            this.maPDTextBoxX.TabIndex = 5;
            // 
            // tinhTrangComboBoxEx
            // 
            this.tinhTrangComboBoxEx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bANBindingSource, "TinhTrang", true));
            this.tinhTrangComboBoxEx.DisplayMember = "Text";
            this.tinhTrangComboBoxEx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.tinhTrangComboBoxEx.FormattingEnabled = true;
            this.tinhTrangComboBoxEx.ItemHeight = 14;
            this.tinhTrangComboBoxEx.Location = new System.Drawing.Point(391, 41);
            this.tinhTrangComboBoxEx.Name = "tinhTrangComboBoxEx";
            this.tinhTrangComboBoxEx.Size = new System.Drawing.Size(121, 20);
            this.tinhTrangComboBoxEx.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.tinhTrangComboBoxEx.TabIndex = 7;
            // 
            // bANDataGridViewX
            // 
            this.bANDataGridViewX.AutoGenerateColumns = false;
            this.bANDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bANDataGridViewX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.bANDataGridViewX.DataSource = this.bANBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bANDataGridViewX.DefaultCellStyle = dataGridViewCellStyle1;
            this.bANDataGridViewX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bANDataGridViewX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.bANDataGridViewX.Location = new System.Drawing.Point(5, 203);
            this.bANDataGridViewX.Name = "bANDataGridViewX";
            this.bANDataGridViewX.Size = new System.Drawing.Size(581, 244);
            this.bANDataGridViewX.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaB";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaB";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MaKV";
            this.dataGridViewTextBoxColumn2.HeaderText = "MaKV";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaPD";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaPD";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TinhTrang";
            this.dataGridViewTextBoxColumn4.HeaderText = "TinhTrang";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bANTableAdapter
            // 
            this.bANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANTableAdapter = this.bANTableAdapter;
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
            // kHUVUCBANTableAdapter
            // 
            this.kHUVUCBANTableAdapter.ClearBeforeFill = true;
            // 
            // CTBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(591, 449);
            this.Controls.Add(this.bANDataGridViewX);
            this.Controls.Add(this.panel_tt);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CTBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTBan";
            this.Load += new System.EventHandler(this.CTBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel_tt.ResumeLayout(false);
            this.panel_tt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHUVUCBANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANDataGridViewX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btn_thoat;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private System.Windows.Forms.Panel panel12;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btn_xoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btn_Luu;
        private System.Windows.Forms.Panel panel_tt;
        private DataDori dataDori;
        private System.Windows.Forms.BindingSource bANBindingSource;
        private DataDoriTableAdapters.BANTableAdapter bANTableAdapter;
        private DataDoriTableAdapters.TableAdapterManager tableAdapterManager;
        private DevComponents.DotNetBar.Controls.DataGridViewX bANDataGridViewX;
        private DevComponents.DotNetBar.Controls.TextBoxX maBTextBoxX;
        private DevComponents.DotNetBar.Controls.TextBoxX maPDTextBoxX;
        private DevComponents.DotNetBar.Controls.ComboBoxEx tinhTrangComboBoxEx;
        private DevComponents.DotNetBar.Controls.ComboBoxEx comboBoxEx1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource kHUVUCBANBindingSource;
        private DataDoriTableAdapters.KHUVUCBANTableAdapter kHUVUCBANTableAdapter;
    }
}