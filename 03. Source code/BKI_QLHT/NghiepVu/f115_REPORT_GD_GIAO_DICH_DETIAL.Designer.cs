namespace BKI_QLHT.DanhMuc
{
    partial class f115_REPORT_GD_GIAO_DICH_DETIAL
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
            this.bKIQLHTDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bKI_QLHTDataSet = new BKI_QLHT.BKI_QLHTDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bKI_QLHTDataSet2 = new BKI_QLHT.BKI_QLHTDataSet2();
            this.vGDGIAODICHDETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_GD_GIAO_DICH_DETAILTableAdapter = new BKI_QLHT.BKI_QLHTDataSet2TableAdapters.V_GD_GIAO_DICH_DETAILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bKIQLHTDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKI_QLHTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKI_QLHTDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGDGIAODICHDETAILBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bKIQLHTDataSetBindingSource
            // 
            this.bKIQLHTDataSetBindingSource.DataSource = this.bKI_QLHTDataSet;
            this.bKIQLHTDataSetBindingSource.Position = 0;
            // 
            // bKI_QLHTDataSet
            // 
            this.bKI_QLHTDataSet.DataSetName = "BKI_QLHTDataSet";
            this.bKI_QLHTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_Report115";
            reportDataSource1.Value = this.vGDGIAODICHDETAILBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BKI_QLHT.NghiepVu.f115_Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(742, 478);
            this.reportViewer1.TabIndex = 0;
            // 
            // bKI_QLHTDataSet2
            // 
            this.bKI_QLHTDataSet2.DataSetName = "BKI_QLHTDataSet2";
            this.bKI_QLHTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vGDGIAODICHDETAILBindingSource
            // 
            this.vGDGIAODICHDETAILBindingSource.DataMember = "V_GD_GIAO_DICH_DETAIL";
            this.vGDGIAODICHDETAILBindingSource.DataSource = this.bKI_QLHTDataSet2;
            // 
            // v_GD_GIAO_DICH_DETAILTableAdapter
            // 
            this.v_GD_GIAO_DICH_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // f115_REPORT_GD_GIAO_DICH_DETIAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 478);
            this.Controls.Add(this.reportViewer1);
            this.Name = "f115_REPORT_GD_GIAO_DICH_DETIAL";
            this.Text = "f115_REPORT_GD_GIAO_DICH_DETIAL";
            this.Load += new System.EventHandler(this.f115_REPORT_GD_GIAO_DICH_DETIAL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bKIQLHTDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKI_QLHTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKI_QLHTDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGDGIAODICHDETAILBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bKIQLHTDataSetBindingSource;
        private BKI_QLHTDataSet bKI_QLHTDataSet;
        private BKI_QLHTDataSet2 bKI_QLHTDataSet2;
        private System.Windows.Forms.BindingSource vGDGIAODICHDETAILBindingSource;
        private BKI_QLHTDataSet2TableAdapters.V_GD_GIAO_DICH_DETAILTableAdapter v_GD_GIAO_DICH_DETAILTableAdapter;
    }
}