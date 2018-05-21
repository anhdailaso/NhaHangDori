namespace NhaHang
{
    partial class Form_ChuyenBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChuyenBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new DevComponents.DotNetBar.ButtonX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataDori = new NhaHang.DataDori();
            this.bANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bANTableAdapter = new NhaHang.DataDoriTableAdapters.BANTableAdapter();
            this.tableAdapterManager = new NhaHang.DataDoriTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_thoat);
            this.panel1.Controls.Add(this.reflectionLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 62);
            this.panel1.TabIndex = 3;
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
            this.reflectionLabel1.Text = "<b><font size=\"+6\"><i>Chuyển</i><font color=\"#B02B2C\">Bàn</font></font></b>";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 288);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 284);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(243, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 284);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.flowLayoutPanel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(303, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(273, 284);
            this.panel6.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(239, 280);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(269, 280);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // dataDori
            // 
            this.dataDori.DataSetName = "DataDori";
            this.dataDori.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bANBindingSource
            // 
            this.bANBindingSource.DataMember = "BAN";
            this.bANBindingSource.DataSource = this.dataDori;
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
            // Form_ChuyenBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 353);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_ChuyenBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_ChuyenBan";
            this.Load += new System.EventHandler(this.Form_ChuyenBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btn_thoat;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DataDori dataDori;
        private System.Windows.Forms.BindingSource bANBindingSource;
        private DataDoriTableAdapters.BANTableAdapter bANTableAdapter;
        private DataDoriTableAdapters.TableAdapterManager tableAdapterManager;
    }
}