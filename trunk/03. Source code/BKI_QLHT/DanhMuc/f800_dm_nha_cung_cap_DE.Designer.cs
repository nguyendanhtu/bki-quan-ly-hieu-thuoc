namespace BKI_QLHT
{
    partial class f800_dm_nha_cung_cap_DE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f800_dm_nha_cung_cap_DE));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_txt_ten_nha_cung_cap = new System.Windows.Forms.TextBox();
            this.m_txt_dia_chi = new System.Windows.Forms.TextBox();
            this.m_txt_sdt = new System.Windows.Forms.TextBox();
            this.m_cmd_thoat = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.m_pnl_control = new System.Windows.Forms.Panel();
            this.m_pnl_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(190, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số điện thoại";
            // 
            // m_txt_ten_nha_cung_cap
            // 
            this.m_txt_ten_nha_cung_cap.Location = new System.Drawing.Point(207, 101);
            this.m_txt_ten_nha_cung_cap.Name = "m_txt_ten_nha_cung_cap";
            this.m_txt_ten_nha_cung_cap.Size = new System.Drawing.Size(284, 20);
            this.m_txt_ten_nha_cung_cap.TabIndex = 1;
            this.m_txt_ten_nha_cung_cap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.m_txt_ten_nha_cung_cap_KeyUp);
            // 
            // m_txt_dia_chi
            // 
            this.m_txt_dia_chi.Location = new System.Drawing.Point(207, 143);
            this.m_txt_dia_chi.Name = "m_txt_dia_chi";
            this.m_txt_dia_chi.Size = new System.Drawing.Size(284, 20);
            this.m_txt_dia_chi.TabIndex = 2;
            this.m_txt_dia_chi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.m_txt_dia_chi_KeyUp);
            // 
            // m_txt_sdt
            // 
            this.m_txt_sdt.Location = new System.Drawing.Point(207, 192);
            this.m_txt_sdt.Name = "m_txt_sdt";
            this.m_txt_sdt.Size = new System.Drawing.Size(284, 20);
            this.m_txt_sdt.TabIndex = 3;
            this.m_txt_sdt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_txt_sdt_KeyDown);
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_thoat.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_thoat.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_thoat.ImageIndex = 12;
            this.m_cmd_thoat.ImageList = this.ImageList;
            this.m_cmd_thoat.Location = new System.Drawing.Point(389, 22);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_thoat.TabIndex = 5;
            this.m_cmd_thoat.Text = "Thoát (Esc)";
            this.m_cmd_thoat.Click += new System.EventHandler(this.m_cmd_thoat_Click_1);
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
            // m_cmd_save
            // 
            this.m_cmd_save.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_save.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_save.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_save.ImageIndex = 10;
            this.m_cmd_save.ImageList = this.ImageList;
            this.m_cmd_save.Location = new System.Drawing.Point(98, 22);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_save.TabIndex = 4;
            this.m_cmd_save.Text = "Lưu";
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click_1);
            // 
            // m_pnl_control
            // 
            this.m_pnl_control.Controls.Add(this.m_cmd_save);
            this.m_pnl_control.Controls.Add(this.m_cmd_thoat);
            this.m_pnl_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_control.Location = new System.Drawing.Point(0, 242);
            this.m_pnl_control.Name = "m_pnl_control";
            this.m_pnl_control.Size = new System.Drawing.Size(572, 72);
            this.m_pnl_control.TabIndex = 14;
            // 
            // f800_dm_nha_cung_cap_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_pnl_control);
            this.Controls.Add(this.m_txt_sdt);
            this.Controls.Add(this.m_txt_dia_chi);
            this.Controls.Add(this.m_txt_ten_nha_cung_cap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "f800_dm_nha_cung_cap_DE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin nhà cung cấp";
            this.Enter += new System.EventHandler(this.m_cmd_save_Click_1);
            this.m_pnl_control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_txt_ten_nha_cung_cap;
        private System.Windows.Forms.TextBox m_txt_dia_chi;
        private System.Windows.Forms.TextBox m_txt_sdt;
        internal SIS.Controls.Button.SiSButton m_cmd_thoat;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
        private System.Windows.Forms.Panel m_pnl_control;
        internal System.Windows.Forms.ImageList ImageList;
    }
}