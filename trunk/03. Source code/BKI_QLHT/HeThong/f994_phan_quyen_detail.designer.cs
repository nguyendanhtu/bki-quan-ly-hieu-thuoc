namespace BKI_QLHT
{
    partial class f994_phan_quyen_detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f994_phan_quyen_detail));
            this.label1 = new System.Windows.Forms.Label();
            this.m_cbo_nhom_quyen = new System.Windows.Forms.ComboBox();
            this.m_txt_form = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_cbo_chuc_nang = new System.Windows.Forms.ComboBox();
            this.m_pnl_control = new System.Windows.Forms.Panel();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.label4 = new System.Windows.Forms.Label();
            this.m_cmd_chon_form = new SIS.Controls.Button.SiSButton();
            this.m_pnl_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn quyền";
            // 
            // m_cbo_nhom_quyen
            // 
            this.m_cbo_nhom_quyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_nhom_quyen.FormattingEnabled = true;
            this.m_cbo_nhom_quyen.Location = new System.Drawing.Point(127, 124);
            this.m_cbo_nhom_quyen.Name = "m_cbo_nhom_quyen";
            this.m_cbo_nhom_quyen.Size = new System.Drawing.Size(147, 22);
            this.m_cbo_nhom_quyen.TabIndex = 1;
            // 
            // m_txt_form
            // 
            this.m_txt_form.BackColor = System.Drawing.SystemColors.Info;
            this.m_txt_form.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_txt_form.Location = new System.Drawing.Point(127, 74);
            this.m_txt_form.Name = "m_txt_form";
            this.m_txt_form.ReadOnly = true;
            this.m_txt_form.Size = new System.Drawing.Size(207, 20);
            this.m_txt_form.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chọn form";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chọn chức năng";
            // 
            // m_cbo_chuc_nang
            // 
            this.m_cbo_chuc_nang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_chuc_nang.FormattingEnabled = true;
            this.m_cbo_chuc_nang.Location = new System.Drawing.Point(127, 172);
            this.m_cbo_chuc_nang.Name = "m_cbo_chuc_nang";
            this.m_cbo_chuc_nang.Size = new System.Drawing.Size(147, 22);
            this.m_cbo_chuc_nang.TabIndex = 5;
            // 
            // m_pnl_control
            // 
            this.m_pnl_control.Controls.Add(this.m_cmd_save);
            this.m_pnl_control.Controls.Add(this.m_cmd_exit);
            this.m_pnl_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_control.Location = new System.Drawing.Point(0, 219);
            this.m_pnl_control.Name = "m_pnl_control";
            this.m_pnl_control.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_control.Size = new System.Drawing.Size(442, 39);
            this.m_pnl_control.TabIndex = 6;
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
            this.m_cmd_save.Location = new System.Drawing.Point(262, 4);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(88, 31);
            this.m_cmd_save.TabIndex = 0;
            this.m_cmd_save.Text = "&Lưu";
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
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
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Blue;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 11;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(350, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 31);
            this.m_cmd_exit.TabIndex = 1;
            this.m_cmd_exit.Text = "Trở về (Esc)";
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.MaximumSize = new System.Drawing.Size(5000, 5000);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(442, 56);
            this.label4.TabIndex = 25;
            this.label4.Text = "PHÂN QUYỀN CHI TIẾT CHO FORM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_cmd_chon_form
            // 
            this.m_cmd_chon_form.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_chon_form.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_chon_form.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Blue;
            this.m_cmd_chon_form.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_chon_form.ImageIndex = 5;
            this.m_cmd_chon_form.ImageList = this.ImageList;
            this.m_cmd_chon_form.Location = new System.Drawing.Point(340, 72);
            this.m_cmd_chon_form.Name = "m_cmd_chon_form";
            this.m_cmd_chon_form.Size = new System.Drawing.Size(88, 22);
            this.m_cmd_chon_form.TabIndex = 26;
            this.m_cmd_chon_form.Text = "Chọn form";
            this.m_cmd_chon_form.Click += new System.EventHandler(this.m_cmd_chon_form_Click);
            // 
            // f994_phan_quyen_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 258);
            this.Controls.Add(this.m_cmd_chon_form);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_pnl_control);
            this.Controls.Add(this.m_cbo_chuc_nang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_txt_form);
            this.Controls.Add(this.m_cbo_nhom_quyen);
            this.Controls.Add(this.label1);
            this.Name = "f994_phan_quyen_detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F994 - Phân quyền chi tiết";
            this.Load += new System.EventHandler(this.f994_phan_quyen_detail_Load);
            this.m_pnl_control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox m_cbo_nhom_quyen;
        private System.Windows.Forms.TextBox m_txt_form;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox m_cbo_chuc_nang;
        internal System.Windows.Forms.Panel m_pnl_control;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Label label4;
        internal SIS.Controls.Button.SiSButton m_cmd_chon_form;
    }
}