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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_txt_ten_nha_cung_cap = new System.Windows.Forms.TextBox();
            this.m_txt_ma_nha_cung_cap = new System.Windows.Forms.TextBox();
            this.m_txt_dia_chi = new System.Windows.Forms.TextBox();
            this.m_txt_sdt = new System.Windows.Forms.TextBox();
            this.m_cmd_save = new System.Windows.Forms.Button();
            this.m_cmd_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 29);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhà cung cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 232);
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
            this.m_txt_ten_nha_cung_cap.TabIndex = 5;
            // 
            // m_txt_ma_nha_cung_cap
            // 
            this.m_txt_ma_nha_cung_cap.Location = new System.Drawing.Point(207, 139);
            this.m_txt_ma_nha_cung_cap.Name = "m_txt_ma_nha_cung_cap";
            this.m_txt_ma_nha_cung_cap.Size = new System.Drawing.Size(284, 20);
            this.m_txt_ma_nha_cung_cap.TabIndex = 6;
            // 
            // m_txt_dia_chi
            // 
            this.m_txt_dia_chi.Location = new System.Drawing.Point(207, 185);
            this.m_txt_dia_chi.Name = "m_txt_dia_chi";
            this.m_txt_dia_chi.Size = new System.Drawing.Size(284, 20);
            this.m_txt_dia_chi.TabIndex = 8;
            // 
            // m_txt_sdt
            // 
            this.m_txt_sdt.Location = new System.Drawing.Point(207, 229);
            this.m_txt_sdt.Name = "m_txt_sdt";
            this.m_txt_sdt.Size = new System.Drawing.Size(284, 20);
            this.m_txt_sdt.TabIndex = 9;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.Location = new System.Drawing.Point(131, 284);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_save.TabIndex = 10;
            this.m_cmd_save.Text = "Lưu";
            this.m_cmd_save.UseVisualStyleBackColor = true;
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Location = new System.Drawing.Point(361, 284);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(75, 23);
            this.m_cmd_thoat.TabIndex = 11;
            this.m_cmd_thoat.Text = "Thoát";
            this.m_cmd_thoat.UseVisualStyleBackColor = true;
            this.m_cmd_thoat.Click += new System.EventHandler(this.m_cmd_thoat_Click);
            // 
            // f800_dm_nha_cung_cap_DE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 319);
            this.Controls.Add(this.m_cmd_thoat);
            this.Controls.Add(this.m_cmd_save);
            this.Controls.Add(this.m_txt_sdt);
            this.Controls.Add(this.m_txt_dia_chi);
            this.Controls.Add(this.m_txt_ma_nha_cung_cap);
            this.Controls.Add(this.m_txt_ten_nha_cung_cap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "f800_dm_nha_cung_cap_DE";
            this.Text = "Thông tin nhà cung cấp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_txt_ten_nha_cung_cap;
        private System.Windows.Forms.TextBox m_txt_ma_nha_cung_cap;
        private System.Windows.Forms.TextBox m_txt_dia_chi;
        private System.Windows.Forms.TextBox m_txt_sdt;
        private System.Windows.Forms.Button m_cmd_save;
        private System.Windows.Forms.Button m_cmd_thoat;
    }
}