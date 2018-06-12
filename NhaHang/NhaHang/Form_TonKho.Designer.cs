namespace NhaHang
{
    partial class Form_TonKho
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.nGUYENLIEUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDori = new NhaHang.DataDori();
            this.nGUYENLIEUTableAdapter = new NhaHang.DataDoriTableAdapters.NGUYENLIEUTableAdapter();
            this.tableAdapterManager = new NhaHang.DataDoriTableAdapters.TableAdapterManager();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.nGUYENLIEUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.NCCTableAdapter = null;
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
            // chart1
            // 
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.LogarithmBase = 20D;
            chartArea1.AxisX.Title = "Tên Nguyên Liệu";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY.Title = "KL(Còn)";
            chartArea1.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.nGUYENLIEUBindingSource;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(5, 1);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.CustomProperties = "PixelPointWidth=19, DrawingStyle=Cylinder, MinPixelPointWidth=19, LabelStyle=Bott" +
    "om, MaxPixelPointWidth=19";
            series1.EmptyPointStyle.AxisLabel = "TenNL";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "NguyenLieu";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.XValueMember = "TenNL";
            series1.YValueMembers = "KLTon";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(936, 269);
            this.chart1.SuppressExceptions = true;
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Thống Kê Nguyên Liệu Dạng Bánh Xe";
            this.chart1.Titles.Add(title1);
            // 
            // chart2
            // 
            chartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.LogarithmBase = 20D;
            chartArea2.AxisX.Title = "Tên Nguyên Liệu";
            chartArea2.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.AxisY.Title = "KL(Còn)";
            chartArea2.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.DataSource = this.nGUYENLIEUBindingSource;
            this.chart2.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(5, 270);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.CustomProperties = "PixelPointWidth=19, DrawingStyle=Cylinder, MinPixelPointWidth=19, LabelStyle=Bott" +
    "om, MaxPixelPointWidth=19";
            series2.EmptyPointStyle.AxisLabel = "TenNL";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "NguyenLieu";
            series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.XValueMember = "TenNL";
            series2.YValueMembers = "KLTon";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(936, 319);
            this.chart2.SuppressExceptions = true;
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            title2.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "Thống Kê Nguyên Liệu Dạng Cọt";
            this.chart2.Titles.Add(title2);
            // 
            // Form_TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 483);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_TonKho";
            this.Text = "Form_TonKho";
            this.Load += new System.EventHandler(this.Form_TonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nGUYENLIEUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataDori dataDori;
        private System.Windows.Forms.BindingSource nGUYENLIEUBindingSource;
        private DataDoriTableAdapters.NGUYENLIEUTableAdapter nGUYENLIEUTableAdapter;
        private DataDoriTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}