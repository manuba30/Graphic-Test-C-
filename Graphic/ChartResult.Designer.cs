namespace Graphic
{
    partial class ChartResult
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
            this.pointBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.technaxDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.technaxDataSet = new Graphic.technaxDataSet();
            this.avgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnTests = new System.Windows.Forms.Button();
            this.pointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pointTableAdapter = new Graphic.technaxDataSetTableAdapters.pointTableAdapter();
            this.pointBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.avgTableAdapter = new Graphic.technaxDataSetTableAdapters.avgTableAdapter();
            this.chartInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technaxDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technaxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pointBindingSource2
            // 
            this.pointBindingSource2.DataMember = "point";
            this.pointBindingSource2.DataSource = this.technaxDataSetBindingSource;
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
            // avgBindingSource
            // 
            this.avgBindingSource.DataMember = "avg";
            this.avgBindingSource.DataSource = this.technaxDataSetBindingSource;
            // 
            // btnTests
            // 
            this.btnTests.Location = new System.Drawing.Point(52, 415);
            this.btnTests.Name = "btnTests";
            this.btnTests.Size = new System.Drawing.Size(75, 23);
            this.btnTests.TabIndex = 1;
            this.btnTests.Text = "Tests";
            this.btnTests.UseVisualStyleBackColor = true;
            // 
            // pointBindingSource
            // 
            this.pointBindingSource.DataMember = "point";
            this.pointBindingSource.DataSource = this.technaxDataSetBindingSource;
            // 
            // pointTableAdapter
            // 
            this.pointTableAdapter.ClearBeforeFill = true;
            // 
            // pointBindingSource1
            // 
            this.pointBindingSource1.DataMember = "point";
            this.pointBindingSource1.DataSource = this.technaxDataSetBindingSource;
            // 
            // avgTableAdapter
            // 
            this.avgTableAdapter.ClearBeforeFill = true;
            // 
            // chartInfo
            // 
            chartArea1.Name = "ChartArea1";
            this.chartInfo.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartInfo.Legends.Add(legend1);
            this.chartInfo.Location = new System.Drawing.Point(42, 36);
            this.chartInfo.Name = "chartInfo";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartInfo.Series.Add(series1);
            this.chartInfo.Size = new System.Drawing.Size(721, 323);
            this.chartInfo.TabIndex = 2;
            this.chartInfo.Text = "chart1";
            // 
            // ChartResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartInfo);
            this.Controls.Add(this.btnTests);
            this.Name = "ChartResult";
            this.Text = "ChartResult";
            this.Load += new System.EventHandler(this.ChartResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technaxDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technaxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTests;
        private System.Windows.Forms.BindingSource technaxDataSetBindingSource;
        private technaxDataSet technaxDataSet;
        private System.Windows.Forms.BindingSource pointBindingSource;
        private technaxDataSetTableAdapters.pointTableAdapter pointTableAdapter;
        private System.Windows.Forms.BindingSource pointBindingSource1;
        private System.Windows.Forms.BindingSource avgBindingSource;
        private technaxDataSetTableAdapters.avgTableAdapter avgTableAdapter;
        private System.Windows.Forms.BindingSource pointBindingSource2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInfo;
    }
}