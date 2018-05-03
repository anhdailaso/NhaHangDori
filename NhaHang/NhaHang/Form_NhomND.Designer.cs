namespace NhaHang
{
    partial class Form_NhomND
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Groud_ND = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbb_TenNhom = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_NhomNguongDung = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Thêm = new DevComponents.DotNetBar.ButtonX();
            this.btn_Xoa = new DevComponents.DotNetBar.ButtonX();
            this.btn_update = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGUOIDUNGNHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDori = new NhaHang.DataDori();
            this.nHOMNGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGUOIDUNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGUOIDUNGTableAdapter = new NhaHang.DataDoriTableAdapters.NGUOIDUNGTableAdapter();
            this.tableAdapterManager = new NhaHang.DataDoriTableAdapters.TableAdapterManager();
            this.nGUOIDUNGNHOMNGUOIDUNGTableAdapter = new NhaHang.DataDoriTableAdapters.NGUOIDUNGNHOMNGUOIDUNGTableAdapter();
            this.nHOMNGUOIDUNGTableAdapter = new NhaHang.DataDoriTableAdapters.NHOMNGUOIDUNGTableAdapter();
            this.Groud_ND.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGNHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Groud_ND
            // 
            this.Groud_ND.CanvasColor = System.Drawing.SystemColors.Control;
            this.Groud_ND.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.Groud_ND.Controls.Add(this.flowLayoutPanel1);
            this.Groud_ND.Dock = System.Windows.Forms.DockStyle.Left;
            this.Groud_ND.Location = new System.Drawing.Point(5, 79);
            this.Groud_ND.Name = "Groud_ND";
            this.Groud_ND.Size = new System.Drawing.Size(585, 422);
            // 
            // 
            // 
            this.Groud_ND.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.Groud_ND.Style.BackColorGradientAngle = 90;
            this.Groud_ND.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Groud_ND.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Groud_ND.Style.BorderBottomWidth = 1;
            this.Groud_ND.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Groud_ND.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Groud_ND.Style.BorderLeftWidth = 1;
            this.Groud_ND.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Groud_ND.Style.BorderRightWidth = 1;
            this.Groud_ND.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.Groud_ND.Style.BorderTopWidth = 1;
            this.Groud_ND.Style.CornerDiameter = 4;
            this.Groud_ND.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.Groud_ND.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.Groud_ND.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.Groud_ND.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.Groud_ND.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.Groud_ND.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Groud_ND.TabIndex = 12;
            this.Groud_ND.Text = "Chọn Người Dùng Để Thêm";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(579, 401);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cbb_TenNhom
            // 
            this.cbb_TenNhom.DataSource = this.nHOMNGUOIDUNGBindingSource;
            this.cbb_TenNhom.DisplayMember = "TenNhom";
            this.cbb_TenNhom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_TenNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_TenNhom.FormattingEnabled = true;
            this.cbb_TenNhom.ItemHeight = 20;
            this.cbb_TenNhom.Location = new System.Drawing.Point(425, 18);
            this.cbb_TenNhom.Name = "cbb_TenNhom";
            this.cbb_TenNhom.Size = new System.Drawing.Size(181, 26);
            this.cbb_TenNhom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbb_TenNhom.TabIndex = 2;
            this.cbb_TenNhom.ValueMember = "MaNhomNguoiDung";
            this.cbb_TenNhom.SelectedIndexChanged += new System.EventHandler(this.cbb_TenNhom_SelectedIndexChanged);
            // 
            // txt_NhomNguongDung
            // 
            // 
            // 
            // 
            this.txt_NhomNguongDung.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_NhomNguongDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NhomNguongDung.Location = new System.Drawing.Point(143, 18);
            this.txt_NhomNguongDung.Name = "txt_NhomNguongDung";
            this.txt_NhomNguongDung.Size = new System.Drawing.Size(276, 23);
            this.txt_NhomNguongDung.TabIndex = 1;
            this.txt_NhomNguongDung.Text = "Chọn Nhóm Người Dùng Để Thêm :";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.reflectionLabel1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(5, 1);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(1246, 78);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 13;
            // 
            // reflectionLabel1
            // 
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Location = new System.Drawing.Point(452, 12);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(372, 52);
            this.reflectionLabel1.TabIndex = 0;
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Thêm Người Dùng</i><font color=\"#B02B2C\">vào Nhóm Người Dùn" +
    "g</font></font></b>";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(590, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 422);
            this.panel1.TabIndex = 14;
            // 
            // nGUOIDUNGNHOMNGUOIDUNGDataGridViewX
            // 
            this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX.AutoGenerateColumns = false;
            this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX.DataSource = this.nGUOIDUNGNHOMNGUOIDUNGBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX.DefaultCellStyle = dataGridViewCellStyle1;
            this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX.Location = new System.Drawing.Point(143, 64);
            this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX.Name = "nGUOIDUNGNHOMNGUOIDUNGDataGridViewX";
            this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX.Size = new System.Drawing.Size(518, 358);
            this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX.TabIndex = 15;
            this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX_CellClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btn_Thêm);
            this.panel3.Controls.Add(this.btn_Xoa);
            this.panel3.Controls.Add(this.btn_update);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(143, 358);
            this.panel3.TabIndex = 15;
            // 
            // btn_Thêm
            // 
            this.btn_Thêm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Thêm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Thêm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Thêm.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Thêm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thêm.Location = new System.Drawing.Point(0, 160);
            this.btn_Thêm.Name = "btn_Thêm";
            this.btn_Thêm.Size = new System.Drawing.Size(139, 80);
            this.btn_Thêm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Thêm.TabIndex = 9;
            this.btn_Thêm.Text = "Thêm";
            this.btn_Thêm.Click += new System.EventHandler(this.btn_Thêm_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Xoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Location = new System.Drawing.Point(0, 80);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(139, 80);
            this.btn_Xoa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Xoa.TabIndex = 10;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_update
            // 
            this.btn_update.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_update.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_update.Location = new System.Drawing.Point(0, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(139, 80);
            this.btn_update.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Cập nhật";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cbb_TenNhom);
            this.panel2.Controls.Add(this.txt_NhomNguongDung);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 64);
            this.panel2.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaNhomNguoiDung";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenDangNhap";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenDangNhap";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "GhiChu";
            this.dataGridViewTextBoxColumn3.HeaderText = "GhiChu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // nGUOIDUNGNHOMNGUOIDUNGBindingSource
            // 
            this.nGUOIDUNGNHOMNGUOIDUNGBindingSource.DataMember = "NGUOIDUNGNHOMNGUOIDUNG";
            this.nGUOIDUNGNHOMNGUOIDUNGBindingSource.DataSource = this.dataDori;
            // 
            // dataDori
            // 
            this.dataDori.DataSetName = "DataDori";
            this.dataDori.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHOMNGUOIDUNGBindingSource
            // 
            this.nHOMNGUOIDUNGBindingSource.DataMember = "NHOMNGUOIDUNG";
            this.nHOMNGUOIDUNGBindingSource.DataSource = this.dataDori;
            // 
            // nGUOIDUNGBindingSource
            // 
            this.nGUOIDUNGBindingSource.DataMember = "NGUOIDUNG";
            this.nGUOIDUNGBindingSource.DataSource = this.dataDori;
            // 
            // nGUOIDUNGTableAdapter
            // 
            this.nGUOIDUNGTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.KHUVUCTableAdapter = null;
            this.tableAdapterManager.LOAIKHTableAdapter = null;
            this.tableAdapterManager.LOAIPHONGTableAdapter = null;
            this.tableAdapterManager.MANHINHTableAdapter = null;
            this.tableAdapterManager.MONANTableAdapter = null;
            this.tableAdapterManager.NCCTableAdapter = null;
            this.tableAdapterManager.NGUOIDUNGNHOMNGUOIDUNGTableAdapter = this.nGUOIDUNGNHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.NGUOIDUNGTableAdapter = this.nGUOIDUNGTableAdapter;
            this.tableAdapterManager.NGUYENLIEUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHOMMATableAdapter = null;
            this.tableAdapterManager.NHOMNGUOIDUNGTableAdapter = this.nHOMNGUOIDUNGTableAdapter;
            this.tableAdapterManager.PHANQUYENTableAdapter = null;
            this.tableAdapterManager.PHIEUDATMONTableAdapter = null;
            this.tableAdapterManager.PHIEUDATVETableAdapter = null;
            this.tableAdapterManager.PHIEUGIAOHANGTableAdapter = null;
            this.tableAdapterManager.PHIEUNHAPTableAdapter = null;
            this.tableAdapterManager.PHONGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NhaHang.DataDoriTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nGUOIDUNGNHOMNGUOIDUNGTableAdapter
            // 
            this.nGUOIDUNGNHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // nHOMNGUOIDUNGTableAdapter
            // 
            this.nHOMNGUOIDUNGTableAdapter.ClearBeforeFill = true;
            // 
            // Form_NhomND
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1256, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Groud_ND);
            this.Controls.Add(this.panelEx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_NhomND";
            this.Text = "Form_NhomND";
            this.Load += new System.EventHandler(this.Form_NhomND_Load);
            this.Groud_ND.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGNHOMNGUOIDUNGDataGridViewX)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGNHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHOMNGUOIDUNGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGUOIDUNGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel Groud_ND;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbb_TenNhom;
        private DevComponents.DotNetBar.LabelX txt_NhomNguongDung;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DataDori dataDori;
        private System.Windows.Forms.BindingSource nGUOIDUNGBindingSource;
        private DataDoriTableAdapters.NGUOIDUNGTableAdapter nGUOIDUNGTableAdapter;
        private DataDoriTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.ButtonX btn_Thêm;
        private DevComponents.DotNetBar.ButtonX btn_Xoa;
        private DevComponents.DotNetBar.ButtonX btn_update;
        private System.Windows.Forms.Panel panel2;
        private DataDoriTableAdapters.NHOMNGUOIDUNGTableAdapter nHOMNGUOIDUNGTableAdapter;
        private System.Windows.Forms.BindingSource nHOMNGUOIDUNGBindingSource;
        private DataDoriTableAdapters.NGUOIDUNGNHOMNGUOIDUNGTableAdapter nGUOIDUNGNHOMNGUOIDUNGTableAdapter;
        private System.Windows.Forms.BindingSource nGUOIDUNGNHOMNGUOIDUNGBindingSource;
        private DevComponents.DotNetBar.Controls.DataGridViewX nGUOIDUNGNHOMNGUOIDUNGDataGridViewX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}