namespace BKI_QLHT
{
    partial class uc500_dm_danh_muc_thuoc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc500_dm_danh_muc_thuoc));
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_grv_danh_muc_thuoc = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_pnl_control = new System.Windows.Forms.Panel();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_txt_tu_khoa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_muc_thuoc)).BeginInit();
            this.m_pnl_control.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Blue;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(790, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Blue;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(878, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_grv_danh_muc_thuoc
            // 
            this.m_grv_danh_muc_thuoc.ColumnInfo = resources.GetString("m_grv_danh_muc_thuoc.ColumnInfo");
            this.m_grv_danh_muc_thuoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_grv_danh_muc_thuoc.Location = new System.Drawing.Point(0, 107);
            this.m_grv_danh_muc_thuoc.Name = "m_grv_danh_muc_thuoc";
            this.m_grv_danh_muc_thuoc.Size = new System.Drawing.Size(1146, 427);
            this.m_grv_danh_muc_thuoc.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_danh_muc_thuoc.Styles"));
            this.m_grv_danh_muc_thuoc.TabIndex = 24;
            this.m_grv_danh_muc_thuoc.Click += new System.EventHandler(this.m_grv_danh_muc_thuoc_Click);
            this.m_grv_danh_muc_thuoc.DoubleClick += new System.EventHandler(this.m_grv_danh_muc_thuoc_DoubleClick);
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Blue;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(966, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Xoá";
            // 
            // m_pnl_control
            // 
            this.m_pnl_control.Controls.Add(this.m_cmd_insert);
            this.m_pnl_control.Controls.Add(this.m_cmd_update);
            this.m_pnl_control.Controls.Add(this.m_cmd_delete);
            this.m_pnl_control.Controls.Add(this.m_cmd_exit);
            this.m_pnl_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_control.Location = new System.Drawing.Point(0, 534);
            this.m_pnl_control.Name = "m_pnl_control";
            this.m_pnl_control.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_control.Size = new System.Drawing.Size(1146, 36);
            this.m_pnl_control.TabIndex = 23;
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Blue;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(1054, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(631, 61);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 25);
            this.m_cmd_search.TabIndex = 34;
            this.m_cmd_search.Text = "&Tìm kiếm";
            this.m_cmd_search.Click += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // m_txt_tu_khoa
            // 
            this.m_txt_tu_khoa.Location = new System.Drawing.Point(390, 65);
            this.m_txt_tu_khoa.Name = "m_txt_tu_khoa";
            this.m_txt_tu_khoa.Size = new System.Drawing.Size(226, 20);
            this.m_txt_tu_khoa.TabIndex = 33;
            this.m_txt_tu_khoa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.m_txt_tu_khoa_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(373, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Danh sách danh mục thuốc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(311, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Từ khóa";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.m_txt_tu_khoa);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 101);
            this.panel1.TabIndex = 43;
            // 
            // uc500_dm_danh_muc_thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_grv_danh_muc_thuoc);
            this.Controls.Add(this.m_pnl_control);
            this.Name = "uc500_dm_danh_muc_thuoc";
            this.Size = new System.Drawing.Size(1146, 570);
            this.Load += new System.EventHandler(this.uc500_dm_danh_muc_thuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_muc_thuoc)).EndInit();
            this.m_pnl_control.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal System.Windows.Forms.ImageList ImageList;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        private C1.Win.C1FlexGrid.C1FlexGrid m_grv_danh_muc_thuoc;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal System.Windows.Forms.Panel m_pnl_control;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private System.Windows.Forms.TextBox m_txt_tu_khoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}
