namespace Graphic
{
    partial class Results
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
            this.dataGridViewIds = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courbeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.technaxDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technaxDataSet = new Graphic.technaxDataSet();
            this.pointBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.technaxDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.pointBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.technaxDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTests = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.pointTableAdapter = new Graphic.technaxDataSetTableAdapters.pointTableAdapter();
            this.courbeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courbeTableAdapter = new Graphic.technaxDataSetTableAdapters.courbeTableAdapter();
            this.chartInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courbeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technaxDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technaxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technaxDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technaxDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courbeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIds
            // 
            this.dataGridViewIds.AutoGenerateColumns = false;
            this.dataGridViewIds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn});
            this.dataGridViewIds.DataSource = this.courbeBindingSource1;
            this.dataGridViewIds.Location = new System.Drawing.Point(12, 23);
            this.dataGridViewIds.Name = "dataGridViewIds";
            this.dataGridViewIds.Size = new System.Drawing.Size(117, 376);
            this.dataGridViewIds.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // courbeBindingSource1
            // 
            this.courbeBindingSource1.DataMember = "courbe";
            this.courbeBindingSource1.DataSource = this.technaxDataSetBindingSource;
            // 
            // technaxDataSetBindingSource
            // 
            this.technaxDataSetBindingSource.DataSource = this.technaxDataSet;
            this.technaxDataSetBindingSource.Position = 0;
            // 
            // technaxDataSet
            // 
            this.technaxDataSet.DataSetName = "technaxDataSet";
            this.technaxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pointBindingSource2
            // 
            this.pointBindingSource2.DataMember = "point";
            this.pointBindingSource2.DataSource = this.technaxDataSetBindingSource2;
            // 
            // technaxDataSetBindingSource2
            // 
            this.technaxDataSetBindingSource2.DataSource = this.technaxDataSet;
            this.technaxDataSetBindingSource2.Position = 0;
            // 
            // pointBindingSource1
            // 
            this.pointBindingSource1.DataMember = "point";
            this.pointBindingSource1.DataSource = this.technaxDataSetBindingSource1;
            // 
            // technaxDataSetBindingSource1
            // 
            this.technaxDataSetBindingSource1.DataSource = this.technaxDataSet;
            this.technaxDataSetBindingSource1.Position = 0;
            // 
            // pointBindingSource
            // 
            this.pointBindingSource.DataMember = "point";
            this.pointBindingSource.DataSource = this.technaxDataSet;
            // 
            // btnTests
            // 
            this.btnTests.Location = new System.Drawing.Point(12, 415);
            this.btnTests.Name = "btnTests";
            this.btnTests.Size = new System.Drawing.Size(75, 23);
            this.btnTests.TabIndex = 2;
            this.btnTests.Text = "Tests";
            this.btnTests.UseVisualStyleBackColor = true;
            this.btnTests.Click += new System.EventHandler(this.btnTests_Click);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(690, 415);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(75, 23);
            this.btnChart.TabIndex = 3;
            this.btnChart.Text = "chart results";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // pointTableAdapter
            // 
            this.pointTableAdapter.ClearBeforeFill = true;
            // 
            // courbeBindingSource
            // 
            this.courbeBindingSource.DataMember = "courbe";
            this.courbeBindingSource.DataSource = this.technaxDataSetBindingSource1;
            // 
            // courbeTableAdapter
            // 
            this.courbeTableAdapter.ClearBeforeFill = true;
            // 
            // chartInfo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartInfo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartInfo.Legends.Add(legend1);
            this.chartInfo.Location = new System.Drawing.Point(239, 23);
            this.chartInfo.Name = "chartInfo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartInfo.Series.Add(series1);
            this.chartInfo.Size = new System.Drawing.Size(535, 376);
            this.chartInfo.TabIndex = 4;
            this.chartInfo.Text = "chart1";
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartInfo);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.btnTests);
            this.Controls.Add(this.dataGridViewIds);
            this.Name = "Results";
            this.Text = "Results";
            this.Activated += new System.EventHandler(this.Results_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courbeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technaxDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technaxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technaxDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technaxDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courbeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIds;
        private System.Windows.Forms.Button btnTests;
        private System.Windows.Forms.Button btnChart;
        private technaxDataSet technaxDataSet;
        private System.Windows.Forms.BindingSource pointBindingSource;
        private technaxDataSetTableAdapters.pointTableAdapter pointTableAdapter;
        private System.Windows.Forms.BindingSource pointBindingSource1;
        private System.Windows.Forms.BindingSource technaxDataSetBindingSource1;
        private System.Windows.Forms.BindingSource technaxDataSetBindingSource;
        private System.Windows.Forms.BindingSource courbeBindingSource;
        private technaxDataSetTableAdapters.courbeTableAdapter courbeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource courbeBindingSource1;
        private System.Windows.Forms.BindingSource pointBindingSource2;
        private System.Windows.Forms.BindingSource technaxDataSetBindingSource2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo;
    }
}