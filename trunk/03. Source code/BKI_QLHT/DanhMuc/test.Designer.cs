﻿namespace BKI_QLHT.DanhMuc
{
    partial class test
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
            this.m_txts_ten_thuoc = new BKI_QLHT.DanhMuc.txt_search_thuoc();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_txts_ten_thuoc
            // 
            this.m_txts_ten_thuoc.Location = new System.Drawing.Point(85, 175);
            this.m_txts_ten_thuoc.Name = "m_txts_ten_thuoc";
            this.m_txts_ten_thuoc.Size = new System.Drawing.Size(247, 20);
            this.m_txts_ten_thuoc.str_query = null;
            this.m_txts_ten_thuoc.TabIndex = 2;
            this.m_txts_ten_thuoc.ValueMember = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_txts_ten_thuoc);
            this.Name = "test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private txt_search_thuoc m_txts_ten_thuoc;
        private System.Windows.Forms.Button button1;
    }
}