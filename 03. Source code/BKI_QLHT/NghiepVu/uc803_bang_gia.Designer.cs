namespace BKI_QLHT.NghiepVu
{
    partial class uc803_bang_gia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc803_bang_gia));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_grv_bang_gia = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_pnl_control = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siSButton1 = new SIS.Controls.Button.SiSButton();
            this.m_txts_ten_thuoc = new BKI_QLHT.DanhMuc.txt_search_thuoc();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_bang_gia)).BeginInit();
            this.m_pnl_control.SuspendLayout();
            this.SuspendLayout();
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
            // m_grv_bang_gia
            // 
            this.m_grv_bang_gia.ColumnInfo = resources.GetString("m_grv_bang_gia.ColumnInfo");
            this.m_grv_bang_gia.Location = new System.Drawing.Point(0, 146);
            this.m_grv_bang_gia.Name = "m_grv_bang_gia";
            this.m_grv_bang_gia.Size = new System.Drawing.Size(1133, 382);
            this.m_grv_bang_gia.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_bang_gia.Styles"));
            this.m_grv_bang_gia.TabIndex = 22;
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(1053, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_pnl_control
            // 
            this.m_pnl_control.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_control.Controls.Add(this.m_cmd_exit);
            this.m_pnl_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_control.Location = new System.Drawing.Point(0, 534);
            this.m_pnl_control.Name = "m_pnl_control";
            this.m_pnl_control.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_control.Size = new System.Drawing.Size(1145, 36);
            this.m_pnl_control.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(522, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Bảng giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(299, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên thuốc :";
            // 
            // siSButton1
            // 
            this.siSButton1.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.siSButton1.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.siSButton1.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.siSButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.siSButton1.ImageIndex = 5;
            this.siSButton1.ImageList = this.ImageList;
            this.siSButton1.Location = new System.Drawing.Point(796, 85);
            this.siSButton1.Name = "siSButton1";
            this.siSButton1.Size = new System.Drawing.Size(88, 21);
            this.siSButton1.TabIndex = 26;
            this.siSButton1.Text = "Tìm kiếm";
            // 
            // m_txts_ten_thuoc
            // 
            this.m_txts_ten_thuoc.dcID = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.m_txts_ten_thuoc.DisplayMember = null;
            this.m_txts_ten_thuoc.Location = new System.Drawing.Point(395, 86);
            this.m_txts_ten_thuoc.Name = "m_txts_ten_thuoc";
            this.m_txts_ten_thuoc.Size = new System.Drawing.Size(367, 20);
            this.m_txts_ten_thuoc.str_query = null;
            this.m_txts_ten_thuoc.TabIndex = 1;
            this.m_txts_ten_thuoc.Text1 = null;
            this.m_txts_ten_thuoc.ValueMember = null;
            this.m_txts_ten_thuoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_txts_ten_thuoc_KeyDown);
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xuat_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xuat_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xuat_excel.ImageIndex = 19;
            this.m_cmd_xuat_excel.ImageList = this.ImageList;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(113, 28);
            this.m_cmd_xuat_excel.TabIndex = 12;
            this.m_cmd_xuat_excel.Text = "Xuất ra Excel";
            // 
            // uc803_bang_gia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.siSButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_txts_ten_thuoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_grv_bang_gia);
            this.Controls.Add(this.m_pnl_control);
            this.Name = "uc803_bang_gia";
            this.Size = new System.Drawing.Size(1145, 570);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_bang_gia)).EndInit();
            this.m_pnl_control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ImageList ImageList;
        private C1.Win.C1FlexGrid.C1FlexGrid m_grv_bang_gia;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal System.Windows.Forms.Panel m_pnl_control;
        private System.Windows.Forms.Label label1;
        private DanhMuc.txt_search_thuoc m_txts_ten_thuoc;
        private System.Windows.Forms.Label label2;
        internal SIS.Controls.Button.SiSButton siSButton1;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
    }
}
