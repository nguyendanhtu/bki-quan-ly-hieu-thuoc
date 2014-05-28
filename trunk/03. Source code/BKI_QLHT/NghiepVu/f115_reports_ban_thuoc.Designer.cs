namespace BKI_QLHT.NghiepVu
{
    partial class f115_reports_ban_thuoc
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
            this.bKIQLHTREPORTBANTHUOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bKI_QLHT_REPORT_BAN_THUOC = new BKI_QLHT.NghiepVu.BKI_QLHT_REPORT_BAN_THUOC();
            this.vGDGIAODICHDETAILTableAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.V_GD_GIAO_DICH_DETAILBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.V_GD_GIAO_DICH_DETAILTableAdapter = new BKI_QLHT.NghiepVu.BKI_QLHT_REPORT_BAN_THUOCTableAdapters.V_GD_GIAO_DICH_DETAILTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bKIQLHTREPORTBANTHUOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKI_QLHT_REPORT_BAN_THUOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGDGIAODICHDETAILTableAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_GD_GIAO_DICH_DETAILBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bKIQLHTREPORTBANTHUOCBindingSource
            // 
            this.bKIQLHTREPORTBANTHUOCBindingSource.DataSource = this.bKI_QLHT_REPORT_BAN_THUOC;
            this.bKIQLHTREPORTBANTHUOCBindingSource.Position = 0;
            // 
            // bKI_QLHT_REPORT_BAN_THUOC
            // 
            this.bKI_QLHT_REPORT_BAN_THUOC.DataSetName = "BKI_QLHT_REPORT_BAN_THUOC";
            this.bKI_QLHT_REPORT_BAN_THUOC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vGDGIAODICHDETAILTableAdapterBindingSource
            // 
            this.vGDGIAODICHDETAILTableAdapterBindingSource.DataSource = typeof(BKI_QLHT.DS.BKI_QLHT_REPORT_BAN_THUOCTableAdapters.V_GD_GIAO_DICH_DETAILTableAdapter);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DS_REPORT_BAN_THUOC";
            reportDataSource1.Value = this.V_GD_GIAO_DICH_DETAILBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BKI_QLHT.NghiepVu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(809, 488);
            this.reportViewer1.TabIndex = 0;
            // 
            // V_GD_GIAO_DICH_DETAILBindingSource
            // 
            this.V_GD_GIAO_DICH_DETAILBindingSource.DataMember = "V_GD_GIAO_DICH_DETAIL";
            this.V_GD_GIAO_DICH_DETAILBindingSource.DataSource = this.bKI_QLHT_REPORT_BAN_THUOC;
            // 
            // V_GD_GIAO_DICH_DETAILTableAdapter
            // 
            this.V_GD_GIAO_DICH_DETAILTableAdapter.ClearBeforeFill = true;
            // 
            // f115_reports_ban_thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 488);
            this.Controls.Add(this.reportViewer1);
            this.Name = "f115_reports_ban_thuoc";
            this.Text = "f115_reports_ban_thuoc";
            this.Load += new System.EventHandler(this.f115_reports_ban_thuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bKIQLHTREPORTBANTHUOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bKI_QLHT_REPORT_BAN_THUOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGDGIAODICHDETAILTableAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.V_GD_GIAO_DICH_DETAILBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vGDGIAODICHDETAILTableAdapterBindingSource;
        private System.Windows.Forms.BindingSource bKIQLHTREPORTBANTHUOCBindingSource;
        private BKI_QLHT_REPORT_BAN_THUOC bKI_QLHT_REPORT_BAN_THUOC;
        private System.Windows.Forms.BindingSource V_GD_GIAO_DICH_DETAILBindingSource;
        private BKI_QLHT_REPORT_BAN_THUOCTableAdapters.V_GD_GIAO_DICH_DETAILTableAdapter V_GD_GIAO_DICH_DETAILTableAdapter;
    }
}