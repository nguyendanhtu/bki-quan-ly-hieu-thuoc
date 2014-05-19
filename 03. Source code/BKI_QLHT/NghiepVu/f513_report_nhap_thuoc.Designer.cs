namespace BKI_QLHT
{
    partial class f513_report_nhap_thuoc
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BKI_QLHTDataSet3 = new BKI_QLHT.BKI_QLHTDataSet3();
            this.V_GD_GIAO_DICH_NHAP_THUOC_DETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.V_GD_GIAO_DICH_NHAP_THUOC_DETAILTableAdapter = new BKI_QLHT.BKI_QLHTDataSet3TableAdapters.V_GD_GIAO_DICH_NHAP_THUOC_DETAILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BKI_QLHTDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_GD_GIAO_DICH_NHAP_THUOC_DETAILBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.V_GD_GIAO_DICH_NHAP_THUOC_DETAILBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BKI_QLHT.NghiepVu.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(663, 458);
            this.reportViewer1.TabIndex = 0;
            // 
            // BKI_QLHTDataSet3
            // 
            this.BKI_QLHTDataSet3.DataSetName = "BKI_QLHTDataSet3";
            this.BKI_QLHTDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // V_GD_GIAO_DICH_NHAP_THUOC_DETAILBindingSource
            // 
            this.V_GD_GIAO_DICH_NHAP_THUOC_DETAILBindingSource.DataMember = "V_GD_GIAO_DICH_NHAP_THUOC_DETAIL";
            this.V_GD_GIAO_DICH_NHAP_THUOC_DETAILBindingSource.DataSource = this.BKI_QLHTDataSet3;
            // 
            // V_GD_GIAO_DICH_NHAP_THUOC_DETAILTableAdapter
            // 
            this.V_GD_GIAO_DICH_NHAP_THUOC_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // f513_report_nhap_thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 458);
            this.Controls.Add(this.reportViewer1);
            this.Name = "f513_report_nhap_thuoc";
            this.Text = "f513_report_nhap_thuoc";
            this.Load += new System.EventHandler(this.f513_report_nhap_thuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BKI_QLHTDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_GD_GIAO_DICH_NHAP_THUOC_DETAILBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource V_GD_GIAO_DICH_NHAP_THUOC_DETAILBindingSource;
        private BKI_QLHTDataSet3 BKI_QLHTDataSet3;
        private BKI_QLHTDataSet3TableAdapters.V_GD_GIAO_DICH_NHAP_THUOC_DETAILTableAdapter V_GD_GIAO_DICH_NHAP_THUOC_DETAILTableAdapter;
    }
}