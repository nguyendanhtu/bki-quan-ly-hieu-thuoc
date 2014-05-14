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
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_bang_gia)).BeginInit();
            this.m_pnl_out_place_dm.SuspendLayout();
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
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 534);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(1145, 36);
            this.m_pnl_out_place_dm.TabIndex = 21;
            // 
            // uc803_bang_gia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_grv_bang_gia);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "uc803_bang_gia";
            this.Size = new System.Drawing.Size(1145, 570);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_bang_gia)).EndInit();
            this.m_pnl_out_place_dm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.ImageList ImageList;
        private C1.Win.C1FlexGrid.C1FlexGrid m_grv_bang_gia;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal System.Windows.Forms.Panel m_pnl_out_place_dm;
    }
}
