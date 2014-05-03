namespace BKI_QLHT.DanhMuc
{
    partial class uc110_txt_search_ten_thuoc
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
            this.m_list_suggest = new System.Windows.Forms.ListBox();
            this.m_txt_search = new System.Windows.Forms.TextBox();
            this.m_cbo_don_vi_tinh = new System.Windows.Forms.ComboBox();
            this.m_lbl_don_vi_tinh = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_list_suggest
            // 
            this.m_list_suggest.FormattingEnabled = true;
            this.m_list_suggest.Location = new System.Drawing.Point(0, 23);
            this.m_list_suggest.Name = "m_list_suggest";
            this.m_list_suggest.Size = new System.Drawing.Size(370, 95);
            this.m_list_suggest.TabIndex = 3;
            // 
            // m_txt_search
            // 
            this.m_txt_search.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_txt_search.Location = new System.Drawing.Point(0, 0);
            this.m_txt_search.Name = "m_txt_search";
            this.m_txt_search.Size = new System.Drawing.Size(370, 20);
            this.m_txt_search.TabIndex = 2;
            // 
            // m_cbo_don_vi_tinh
            // 
            this.m_cbo_don_vi_tinh.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cbo_don_vi_tinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_cbo_don_vi_tinh.FormattingEnabled = true;
            this.m_cbo_don_vi_tinh.Location = new System.Drawing.Point(520, 0);
            this.m_cbo_don_vi_tinh.Name = "m_cbo_don_vi_tinh";
            this.m_cbo_don_vi_tinh.Size = new System.Drawing.Size(139, 21);
            this.m_cbo_don_vi_tinh.TabIndex = 4;
            // 
            // m_lbl_don_vi_tinh
            // 
            this.m_lbl_don_vi_tinh.AutoSize = true;
            this.m_lbl_don_vi_tinh.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_don_vi_tinh.Location = new System.Drawing.Point(428, 4);
            this.m_lbl_don_vi_tinh.Name = "m_lbl_don_vi_tinh";
            this.m_lbl_don_vi_tinh.Size = new System.Drawing.Size(69, 16);
            this.m_lbl_don_vi_tinh.TabIndex = 5;
            this.m_lbl_don_vi_tinh.Text = "Đơn vị tính";
            // 
            // uc110_txt_search_ten_thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_lbl_don_vi_tinh);
            this.Controls.Add(this.m_cbo_don_vi_tinh);
            this.Controls.Add(this.m_list_suggest);
            this.Controls.Add(this.m_txt_search);
            this.Name = "uc110_txt_search_ten_thuoc";
            this.Size = new System.Drawing.Size(659, 119);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox m_list_suggest;
        private System.Windows.Forms.TextBox m_txt_search;
        private System.Windows.Forms.ComboBox m_cbo_don_vi_tinh;
        private System.Windows.Forms.Label m_lbl_don_vi_tinh;
    }
}
