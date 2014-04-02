using System.Windows.Forms;
namespace BKI_QLHT
{
    partial class f400_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f400_Main));
            this.m_mst_menu = new System.Windows.Forms.MenuStrip();
            this.m_menuitem_hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menuitem_quantri = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menu_item_he_thong_nguoi_su_dung = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menu_item_he_thong_nhom_nguoi_su__dung = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menu_item_he_thong_nhat_ky_he_thong = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menu_item_he_thong_phan_quyen_cho_nhom = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menu_item_tu_dien_he_thong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.m_menu_item_he_thong_thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menuitem_danhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menu_item_danh_muc_bac_si = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menu_item_danh_muc_thuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menu_item_danh_muc_nha_cung_cap = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menu_item_danh_muc_khach_hang = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menu_item_danh_muc_nhom_khach_hang = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menu_item_danh_muc_nhom_thuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menuitem_nghiepvu = new System.Windows.Forms.ToolStripMenuItem();
            this.m_menuitem_baocao = new System.Windows.Forms.ToolStripMenuItem();
            this.m_lbl_du_an_sap_kt = new System.Windows.Forms.Label();
            this.m_lbl_thong_bao_hop_dong_sap_het_han = new System.Windows.Forms.Label();
            this.m_lbl_het_han_thu_viec = new System.Windows.Forms.Label();
            this.m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky = new System.Windows.Forms.Label();
            this.m_mst_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_mst_menu
            // 
            this.m_mst_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuitem_hethong,
            this.m_menuitem_danhmuc,
            this.m_menuitem_nghiepvu,
            this.m_menuitem_baocao});
            this.m_mst_menu.Location = new System.Drawing.Point(0, 0);
            this.m_mst_menu.Name = "m_mst_menu";
            this.m_mst_menu.Size = new System.Drawing.Size(1184, 24);
            this.m_mst_menu.TabIndex = 0;
            this.m_mst_menu.Text = "menuStrip1";
            // 
            // m_menuitem_hethong
            // 
            this.m_menuitem_hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menuitem_quantri,
            this.m_menu_item_tu_dien_he_thong,
            this.toolStripMenuItem1,
            this.m_menu_item_he_thong_thoat});
            this.m_menuitem_hethong.Name = "m_menuitem_hethong";
            this.m_menuitem_hethong.Size = new System.Drawing.Size(69, 20);
            this.m_menuitem_hethong.Text = "Hệ thống";
            // 
            // m_menuitem_quantri
            // 
            this.m_menuitem_quantri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menu_item_he_thong_nguoi_su_dung,
            this.m_menu_item_he_thong_nhom_nguoi_su__dung,
            this.m_menu_item_he_thong_nhat_ky_he_thong,
            this.m_menu_item_he_thong_phan_quyen_cho_nhom});
            this.m_menuitem_quantri.Name = "m_menuitem_quantri";
            this.m_menuitem_quantri.Size = new System.Drawing.Size(165, 22);
            this.m_menuitem_quantri.Text = "Quản trị";
            // 
            // m_menu_item_he_thong_nguoi_su_dung
            // 
            this.m_menu_item_he_thong_nguoi_su_dung.Name = "m_menu_item_he_thong_nguoi_su_dung";
            this.m_menu_item_he_thong_nguoi_su_dung.Size = new System.Drawing.Size(195, 22);
            this.m_menu_item_he_thong_nguoi_su_dung.Text = "Người sử dụng";
            // 
            // m_menu_item_he_thong_nhom_nguoi_su__dung
            // 
            this.m_menu_item_he_thong_nhom_nguoi_su__dung.Name = "m_menu_item_he_thong_nhom_nguoi_su__dung";
            this.m_menu_item_he_thong_nhom_nguoi_su__dung.Size = new System.Drawing.Size(195, 22);
            this.m_menu_item_he_thong_nhom_nguoi_su__dung.Text = "Nhóm người sử dụng";
            // 
            // m_menu_item_he_thong_nhat_ky_he_thong
            // 
            this.m_menu_item_he_thong_nhat_ky_he_thong.Name = "m_menu_item_he_thong_nhat_ky_he_thong";
            this.m_menu_item_he_thong_nhat_ky_he_thong.Size = new System.Drawing.Size(195, 22);
            this.m_menu_item_he_thong_nhat_ky_he_thong.Text = "Nhật ký hệ thống";
            // 
            // m_menu_item_he_thong_phan_quyen_cho_nhom
            // 
            this.m_menu_item_he_thong_phan_quyen_cho_nhom.Name = "m_menu_item_he_thong_phan_quyen_cho_nhom";
            this.m_menu_item_he_thong_phan_quyen_cho_nhom.Size = new System.Drawing.Size(195, 22);
            this.m_menu_item_he_thong_phan_quyen_cho_nhom.Text = "Phân quyền cho nhóm";
            // 
            // m_menu_item_tu_dien_he_thong
            // 
            this.m_menu_item_tu_dien_he_thong.Name = "m_menu_item_tu_dien_he_thong";
            this.m_menu_item_tu_dien_he_thong.Size = new System.Drawing.Size(165, 22);
            this.m_menu_item_tu_dien_he_thong.Text = "Từ điển hệ thống";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // m_menu_item_he_thong_thoat
            // 
            this.m_menu_item_he_thong_thoat.Name = "m_menu_item_he_thong_thoat";
            this.m_menu_item_he_thong_thoat.Size = new System.Drawing.Size(165, 22);
            this.m_menu_item_he_thong_thoat.Text = "Thoát";
            // 
            // m_menuitem_danhmuc
            // 
            this.m_menuitem_danhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_menu_item_danh_muc_bac_si,
            this.m_menu_item_danh_muc_thuoc,
            this.m_menu_item_danh_muc_nha_cung_cap,
            this.m_menu_item_danh_muc_khach_hang,
            this.m_menu_item_danh_muc_nhom_khach_hang,
            this.m_menu_item_danh_muc_nhom_thuoc});
            this.m_menuitem_danhmuc.Name = "m_menuitem_danhmuc";
            this.m_menuitem_danhmuc.Size = new System.Drawing.Size(74, 20);
            this.m_menuitem_danhmuc.Text = "Danh mục";
            // 
            // m_menu_item_danh_muc_bac_si
            // 
            this.m_menu_item_danh_muc_bac_si.Name = "m_menu_item_danh_muc_bac_si";
            this.m_menu_item_danh_muc_bac_si.Size = new System.Drawing.Size(229, 22);
            this.m_menu_item_danh_muc_bac_si.Text = "Danh sách bác sĩ";
            // 
            // m_menu_item_danh_muc_thuoc
            // 
            this.m_menu_item_danh_muc_thuoc.Name = "m_menu_item_danh_muc_thuoc";
            this.m_menu_item_danh_muc_thuoc.Size = new System.Drawing.Size(229, 22);
            this.m_menu_item_danh_muc_thuoc.Text = "Danh mục thuốc";
            this.m_menu_item_danh_muc_thuoc.Click += new System.EventHandler(this.m_menu_item_danh_muc_thuoc_Click);
            // 
            // m_menu_item_danh_muc_nha_cung_cap
            // 
            this.m_menu_item_danh_muc_nha_cung_cap.Name = "m_menu_item_danh_muc_nha_cung_cap";
            this.m_menu_item_danh_muc_nha_cung_cap.Size = new System.Drawing.Size(229, 22);
            this.m_menu_item_danh_muc_nha_cung_cap.Text = "Danh muc nhà cung cấp";
            this.m_menu_item_danh_muc_nha_cung_cap.Click += new System.EventHandler(this.m_menu_item_danh_muc_nha_cung_cap_Click);
            // 
            // m_menu_item_danh_muc_khach_hang
            // 
            this.m_menu_item_danh_muc_khach_hang.Name = "m_menu_item_danh_muc_khach_hang";
            this.m_menu_item_danh_muc_khach_hang.Size = new System.Drawing.Size(229, 22);
            this.m_menu_item_danh_muc_khach_hang.Text = "Danh mục  khách hàng";
            this.m_menu_item_danh_muc_khach_hang.Click += new System.EventHandler(this.m_menu_item_danh_muc_khach_hang_Click);
            // 
            // m_menu_item_danh_muc_nhom_khach_hang
            // 
            this.m_menu_item_danh_muc_nhom_khach_hang.Name = "m_menu_item_danh_muc_nhom_khach_hang";
            this.m_menu_item_danh_muc_nhom_khach_hang.Size = new System.Drawing.Size(229, 22);
            this.m_menu_item_danh_muc_nhom_khach_hang.Text = "Danh mục nhóm khách hàng";
            this.m_menu_item_danh_muc_nhom_khach_hang.Click += new System.EventHandler(this.m_menu_item_danh_muc_nhom_khach_hang_Click);
            // 
            // m_menu_item_danh_muc_nhom_thuoc
            // 
            this.m_menu_item_danh_muc_nhom_thuoc.Name = "m_menu_item_danh_muc_nhom_thuoc";
            this.m_menu_item_danh_muc_nhom_thuoc.Size = new System.Drawing.Size(229, 22);
            this.m_menu_item_danh_muc_nhom_thuoc.Text = "Danh mục nhóm thuốc";
            this.m_menu_item_danh_muc_nhom_thuoc.Click += new System.EventHandler(this.m_menu_item_danh_muc_nhom_thuoc_Click);
            // 
            // m_menuitem_nghiepvu
            // 
            this.m_menuitem_nghiepvu.Name = "m_menuitem_nghiepvu";
            this.m_menuitem_nghiepvu.Size = new System.Drawing.Size(74, 20);
            this.m_menuitem_nghiepvu.Text = "Nghiệp vụ";
            // 
            // m_menuitem_baocao
            // 
            this.m_menuitem_baocao.Name = "m_menuitem_baocao";
            this.m_menuitem_baocao.Size = new System.Drawing.Size(61, 20);
            this.m_menuitem_baocao.Text = "Báo cáo";
            // 
            // m_lbl_du_an_sap_kt
            // 
            this.m_lbl_du_an_sap_kt.AutoSize = true;
            this.m_lbl_du_an_sap_kt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_lbl_du_an_sap_kt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_lbl_du_an_sap_kt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_du_an_sap_kt.ForeColor = System.Drawing.Color.Red;
            this.m_lbl_du_an_sap_kt.Location = new System.Drawing.Point(0, 643);
            this.m_lbl_du_an_sap_kt.Name = "m_lbl_du_an_sap_kt";
            this.m_lbl_du_an_sap_kt.Size = new System.Drawing.Size(207, 18);
            this.m_lbl_du_an_sap_kt.TabIndex = 2;
            this.m_lbl_du_an_sap_kt.Text = "dự án sắp đến ngày kết thúc";
            // 
            // m_lbl_thong_bao_hop_dong_sap_het_han
            // 
            this.m_lbl_thong_bao_hop_dong_sap_het_han.AutoSize = true;
            this.m_lbl_thong_bao_hop_dong_sap_het_han.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_lbl_thong_bao_hop_dong_sap_het_han.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_lbl_thong_bao_hop_dong_sap_het_han.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.m_lbl_thong_bao_hop_dong_sap_het_han.ForeColor = System.Drawing.Color.Red;
            this.m_lbl_thong_bao_hop_dong_sap_het_han.Location = new System.Drawing.Point(0, 625);
            this.m_lbl_thong_bao_hop_dong_sap_het_han.Name = "m_lbl_thong_bao_hop_dong_sap_het_han";
            this.m_lbl_thong_bao_hop_dong_sap_het_han.Size = new System.Drawing.Size(165, 18);
            this.m_lbl_thong_bao_hop_dong_sap_het_han.TabIndex = 3;
            this.m_lbl_thong_bao_hop_dong_sap_het_han.Text = "Hợp đồng sắp hết hạn";
            // 
            // m_lbl_het_han_thu_viec
            // 
            this.m_lbl_het_han_thu_viec.AutoSize = true;
            this.m_lbl_het_han_thu_viec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_lbl_het_han_thu_viec.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_lbl_het_han_thu_viec.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.m_lbl_het_han_thu_viec.ForeColor = System.Drawing.Color.Red;
            this.m_lbl_het_han_thu_viec.Location = new System.Drawing.Point(0, 607);
            this.m_lbl_het_han_thu_viec.Name = "m_lbl_het_han_thu_viec";
            this.m_lbl_het_han_thu_viec.Size = new System.Drawing.Size(158, 18);
            this.m_lbl_het_han_thu_viec.TabIndex = 4;
            this.m_lbl_het_han_thu_viec.Text = "Thử việc sắp hết hạn";
            // 
            // m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky
            // 
            this.m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky.AutoSize = true;
            this.m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky.ForeColor = System.Drawing.Color.Red;
            this.m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky.Location = new System.Drawing.Point(0, 589);
            this.m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky.Name = "m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky";
            this.m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky.Size = new System.Drawing.Size(267, 18);
            this.m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky.TabIndex = 5;
            this.m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky.Text = "Hợp đồng đã hết hạn nhưng chưa ký";
            // 
            // f400_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky);
            this.Controls.Add(this.m_lbl_het_han_thu_viec);
            this.Controls.Add(this.m_lbl_thong_bao_hop_dong_sap_het_han);
            this.Controls.Add(this.m_lbl_du_an_sap_kt);
            this.Controls.Add(this.m_mst_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.m_mst_menu;
            this.Name = "f400_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F400 - Chương trình quản lý hiệu thuốc";
            this.m_mst_menu.ResumeLayout(false);
            this.m_mst_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip m_mst_menu;
        private System.Windows.Forms.ToolStripMenuItem m_menuitem_baocao;
        private System.Windows.Forms.ToolStripMenuItem m_menuitem_hethong;
        private System.Windows.Forms.ToolStripMenuItem m_menuitem_quantri;
        private System.Windows.Forms.ToolStripMenuItem m_menu_item_he_thong_nguoi_su_dung;
        private System.Windows.Forms.ToolStripMenuItem m_menu_item_he_thong_nhom_nguoi_su__dung;
        private System.Windows.Forms.ToolStripMenuItem m_menu_item_he_thong_nhat_ky_he_thong;
        private System.Windows.Forms.ToolStripMenuItem m_menu_item_tu_dien_he_thong;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem m_menu_item_he_thong_thoat;
        private System.Windows.Forms.ToolStripMenuItem m_menuitem_nghiepvu;
        private System.Windows.Forms.ToolStripMenuItem m_menuitem_danhmuc;
        private System.Windows.Forms.Label m_lbl_du_an_sap_kt;
        private System.Windows.Forms.Label m_lbl_thong_bao_hop_dong_sap_het_han;
        private Label m_lbl_het_han_thu_viec;
        private Label m_lbl_thong_bao_hdld_da_het_han_nhung_chua_ky;
        private ToolStripMenuItem m_menu_item_he_thong_phan_quyen_cho_nhom;
        private ToolStripMenuItem m_menu_item_danh_muc_bac_si;
        private ToolStripMenuItem m_menu_item_danh_muc_thuoc;
        private ToolStripMenuItem m_menu_item_danh_muc_nha_cung_cap;
        private ToolStripMenuItem m_menu_item_danh_muc_khach_hang;
        private ToolStripMenuItem m_menu_item_danh_muc_nhom_khach_hang;
        private ToolStripMenuItem m_menu_item_danh_muc_nhom_thuoc;
    }
}