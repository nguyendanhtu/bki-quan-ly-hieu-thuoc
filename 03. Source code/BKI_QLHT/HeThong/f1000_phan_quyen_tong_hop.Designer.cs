namespace BKI_QLHT.HeThong
{
    partial class f1000_phan_quyen_tong_hop
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
            this.m_cmd_them_user = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.MaximumSize = new System.Drawing.Size(5000, 5000);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(857, 56);
            this.label1.TabIndex = 27;
            this.label1.Text = "PHÂN QUYỀN TỔNG HỢP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 14);
            this.label2.TabIndex = 28;
            this.label2.Text = "Bước 1: Thêm 1 user";
            // 
            // m_cmd_them_user
            // 
            this.m_cmd_them_user.Location = new System.Drawing.Point(170, 74);
            this.m_cmd_them_user.Name = "m_cmd_them_user";
            this.m_cmd_them_user.Size = new System.Drawing.Size(138, 23);
            this.m_cmd_them_user.TabIndex = 29;
            this.m_cmd_them_user.Text = "Bước 1: Thêm 1 user";
            this.m_cmd_them_user.UseVisualStyleBackColor = true;
            this.m_cmd_them_user.Click += new System.EventHandler(this.m_cmd_them_user_Click);
            // 
            // f1000_phan_quyen_tong_hop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 442);
            this.Controls.Add(this.m_cmd_them_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "f1000_phan_quyen_tong_hop";
            this.Text = "f1000_phan_quyen_tong_hop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button m_cmd_them_user;
    }
}