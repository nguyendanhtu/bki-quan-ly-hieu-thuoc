namespace BKI_QLHT
{
    partial class f996_ht_nhom_nguoi_su_dung_de
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f996_ht_nhom_nguoi_su_dung_de));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_control = new System.Windows.Forms.Panel();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_lbl_ten_nhom = new System.Windows.Forms.Label();
            this.m_txt_ten_nhom = new System.Windows.Forms.TextBox();
            this.m_txt_mo_ta = new System.Windows.Forms.TextBox();
            this.m_lbl_mo_ta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            // m_pnl_control
            // 
            this.m_pnl_control.Controls.Add(this.m_cmd_save);
            this.m_pnl_control.Controls.Add(this.m_cmd_exit);
            this.m_pnl_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_control.Location = new System.Drawing.Point(0, 195);
            this.m_pnl_control.Name = "m_pnl_control";
            this.m_pnl_control.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_control.Size = new System.Drawing.Size(391, 36);
            this.m_pnl_control.TabIndex = 2;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_save.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_save.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Blue;
            this.m_cmd_save.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_save.ImageIndex = 10;
            this.m_cmd_save.ImageList = this.ImageList;
            this.m_cmd_save.Location = new System.Drawing.Point(202, 4);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_save.TabIndex = 0;
            this.m_cmd_save.Text = "&Lưu";
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Blue;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 11;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(290, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(97, 28);
            this.m_cmd_exit.TabIndex = 1;
            this.m_cmd_exit.Text = "Trở về (Esc)";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // m_lbl_ten_nhom
            // 
            this.m_lbl_ten_nhom.AutoSize = true;
            this.m_lbl_ten_nhom.Location = new System.Drawing.Point(35, 71);
            this.m_lbl_ten_nhom.Name = "m_lbl_ten_nhom";
            this.m_lbl_ten_nhom.Size = new System.Drawing.Size(55, 13);
            this.m_lbl_ten_nhom.TabIndex = 3;
            this.m_lbl_ten_nhom.Text = "Tên nhóm";
            // 
            // m_txt_ten_nhom
            // 
            this.m_txt_ten_nhom.Location = new System.Drawing.Point(104, 69);
            this.m_txt_ten_nhom.Name = "m_txt_ten_nhom";
            this.m_txt_ten_nhom.Size = new System.Drawing.Size(245, 20);
            this.m_txt_ten_nhom.TabIndex = 4;
            this.m_txt_ten_nhom.Click += new System.EventHandler(this.m_txt_ten_nhom_Click);
            // 
            // m_txt_mo_ta
            // 
            this.m_txt_mo_ta.Location = new System.Drawing.Point(104, 105);
            this.m_txt_mo_ta.Multiline = true;
            this.m_txt_mo_ta.Name = "m_txt_mo_ta";
            this.m_txt_mo_ta.Size = new System.Drawing.Size(245, 71);
            this.m_txt_mo_ta.TabIndex = 6;
            this.m_txt_mo_ta.Click += new System.EventHandler(this.m_txt_mo_ta_Click);
            // 
            // m_lbl_mo_ta
            // 
            this.m_lbl_mo_ta.AutoSize = true;
            this.m_lbl_mo_ta.Location = new System.Drawing.Point(56, 105);
            this.m_lbl_mo_ta.Name = "m_lbl_mo_ta";
            this.m_lbl_mo_ta.Size = new System.Drawing.Size(34, 13);
            this.m_lbl_mo_ta.TabIndex = 5;
            this.m_lbl_mo_ta.Text = "Mô tả";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.MaximumSize = new System.Drawing.Size(5000, 4643);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 52);
            this.label1.TabIndex = 24;
            this.label1.Text = "CẬP NHẬT NHÓM NGƯỜI SỬ DỤNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // f996_ht_nhom_nguoi_su_dung_de
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_txt_mo_ta);
            this.Controls.Add(this.m_lbl_mo_ta);
            this.Controls.Add(this.m_txt_ten_nhom);
            this.Controls.Add(this.m_lbl_ten_nhom);
            this.Controls.Add(this.m_pnl_control);
            this.Name = "f996_ht_nhom_nguoi_su_dung_de";
            this.Text = "F996 -Cập nhật thông tin nhóm người sử dụng";
            this.m_pnl_control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ImageList ImageList;
        internal System.Windows.Forms.Panel m_pnl_control;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private System.Windows.Forms.Label m_lbl_ten_nhom;
        private System.Windows.Forms.TextBox m_txt_ten_nhom;
        private System.Windows.Forms.TextBox m_txt_mo_ta;
        private System.Windows.Forms.Label m_lbl_mo_ta;
        private System.Windows.Forms.Label label1;
    }
}