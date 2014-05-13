namespace BKI_QLHT.DanhMuc
{
    partial class txt_search_thuoc
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
            this.m_txt_search = new System.Windows.Forms.TextBox();
            this.m_list_suggest = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // m_txt_search
            // 
            this.m_txt_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_txt_search.Location = new System.Drawing.Point(0, 0);
            this.m_txt_search.Name = "m_txt_search";
            this.m_txt_search.Size = new System.Drawing.Size(367, 20);
            this.m_txt_search.TabIndex = 0;
            this.m_txt_search.TextChanged += new System.EventHandler(this.m_txt_search_TextChanged);
            // 
            // m_list_suggest
            // 
            this.m_list_suggest.FormattingEnabled = true;
            this.m_list_suggest.ItemHeight = 14;
            this.m_list_suggest.Location = new System.Drawing.Point(1, 21);
            this.m_list_suggest.Name = "m_list_suggest";
            this.m_list_suggest.Size = new System.Drawing.Size(366, 88);
            this.m_list_suggest.TabIndex = 1;
            // 
            // txt_search_thuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_list_suggest);
            this.Controls.Add(this.m_txt_search);
            this.Name = "txt_search_thuoc";
            this.Size = new System.Drawing.Size(367, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_txt_search;
        private System.Windows.Forms.ListBox m_list_suggest;
    }
}
