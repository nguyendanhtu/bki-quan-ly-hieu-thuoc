namespace BKI_QLHT
{
    partial class uc_802_gd_gia_ban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_802_gd_gia_ban));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_control = new System.Windows.Forms.Panel();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_grv_v_gd_gia = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_cmd_refresh = new SIS.Controls.Button.SiSButton();
            this.m_txts_ten_thuoc = new BKI_QLHT.DanhMuc.txt_search_thuoc();
            this.m_pnl_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_v_gd_gia)).BeginInit();
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
            // m_pnl_control
            // 
            this.m_pnl_control.Controls.Add(this.m_cmd_update);
            this.m_pnl_control.Controls.Add(this.m_cmd_exit);
            this.m_pnl_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_control.Location = new System.Drawing.Point(0, 534);
            this.m_pnl_control.Name = "m_pnl_control";
            this.m_pnl_control.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_control.Size = new System.Drawing.Size(1145, 36);
            this.m_pnl_control.TabIndex = 21;
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(965, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
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
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click_1);
            // 
            // m_grv_v_gd_gia
            // 
            this.m_grv_v_gd_gia.ColumnInfo = resources.GetString("m_grv_v_gd_gia.ColumnInfo");
            this.m_grv_v_gd_gia.Location = new System.Drawing.Point(0, 161);
            this.m_grv_v_gd_gia.Name = "m_grv_v_gd_gia";
            this.m_grv_v_gd_gia.Size = new System.Drawing.Size(1141, 371);
            this.m_grv_v_gd_gia.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_v_gd_gia.Styles"));
            this.m_grv_v_gd_gia.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(468, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Thông tin giá thuốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(303, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Tên thuốc :";
            // 
            // m_cmd_refresh
            // 
            this.m_cmd_refresh.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_refresh.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_refresh.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_refresh.ImageIndex = 9;
            this.m_cmd_refresh.ImageList = this.ImageList;
            this.m_cmd_refresh.Location = new System.Drawing.Point(764, 103);
            this.m_cmd_refresh.Name = "m_cmd_refresh";
            this.m_cmd_refresh.Size = new System.Drawing.Size(88, 22);
            this.m_cmd_refresh.TabIndex = 26;
            this.m_cmd_refresh.Text = "Refresh";
            this.m_cmd_refresh.Click += new System.EventHandler(this.m_cmd_refresh_Click);
            // 
            // m_txts_ten_thuoc
            // 
            this.m_txts_ten_thuoc.dcID = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.m_txts_ten_thuoc.DisplayMember = null;
            this.m_txts_ten_thuoc.Location = new System.Drawing.Point(393, 105);
            this.m_txts_ten_thuoc.Name = "m_txts_ten_thuoc";
            this.m_txts_ten_thuoc.Size = new System.Drawing.Size(335, 20);
            this.m_txts_ten_thuoc.str_query = null;
            this.m_txts_ten_thuoc.TabIndex = 25;
            this.m_txts_ten_thuoc.Text1 = null;
            this.m_txts_ten_thuoc.ValueMember = null;
            this.m_txts_ten_thuoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_txts_ten_thuoc_KeyDown);
            // 
            // uc_802_gd_gia_ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_cmd_refresh);
            this.Controls.Add(this.m_txts_ten_thuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_pnl_control);
            this.Controls.Add(this.m_grv_v_gd_gia);
            this.Name = "uc_802_gd_gia_ban";
            this.Size = new System.Drawing.Size(1145, 570);
            this.m_pnl_control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_v_gd_gia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ImageList ImageList;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal System.Windows.Forms.Panel m_pnl_control;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private C1.Win.C1FlexGrid.C1FlexGrid m_grv_v_gd_gia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DanhMuc.txt_search_thuoc m_txts_ten_thuoc;
        internal SIS.Controls.Button.SiSButton m_cmd_refresh;

    }
}
