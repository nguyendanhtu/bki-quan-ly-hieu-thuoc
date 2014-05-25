﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using BKI_QLHT;
using BKI_QLHT.DS;
using BKI_QLHT.US;
using IP.Core.IPCommon;
using IP.Core.IPExcelReport;
using IP.Core.IPSystemAdmin;
using BKI_QLHT.DanhMuc;
using BKI_QLHT.NghiepVu;
using DevComponents.DotNetBar;
using BKI_QLHT.HeThong;



namespace BKI_QLHT
{
    public partial class f400_Main : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public f400_Main()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface

        public void display(ref IPConstants.HowUserWantTo_Exit_MainForm v_exitmode)
        {
            try
            {
                ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        #endregion

        #region Data Structure
        US_V_HT_PHAN_QUYEN m_us_v_ht_phan_quyen = new US_V_HT_PHAN_QUYEN();
        #endregion

        #region Members

        #endregion

        #region Private Method
        private void format_dotnetbar_menu()
        {
            foreach (Control v_sub_control in m_ribbonControl_Main.Controls)
            {
                int v_dem = 0;
                if (v_sub_control.GetType().Name == "RibbonPanel")
                {
                    foreach (Control v_sub_sub_control in v_sub_control.Controls)
                    {
                        if (v_sub_sub_control.GetType().Name == "RibbonBar")
                        {
                            RibbonBar v_rp = (RibbonBar)v_sub_sub_control;
                           
                            for (int i = 0; i < v_rp.Items.Count; i++)
                            {

                                if (m_us_v_ht_phan_quyen.is_having_quyen_menu(v_rp.Items[i].Name))
                                {
                                    v_rp.Items[i].Visible = true;
                                    v_rp.Items[i].Enabled = true;
                                    v_dem++;

                                }
                                else
                                {
                                    v_rp.Items[i].Visible = false;
                                    v_rp.Items[i].Enabled = false;
                                }

                            }
                            if (v_dem == 0) v_rp.Visible = false;
                        }
                      
                    }
                    if (v_dem == 0) v_sub_control.Visible = false;
                }
            }
        }
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            this.MinimizeBox = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            //ScrollBar vScrollBar1 = new VScrollBar();
            //vScrollBar1.Dock = DockStyle.Right;
            //vScrollBar1.Scroll += (sender, e) => { m_Panel_Content.VerticalScroll.Value = vScrollBar1.Value; };
            //m_Panel_Content.Controls.Add(vScrollBar1);
            //format_dotnetbar_menu();
            set_define_events();
            ShowInTaskbar = true;
        }
        private void set_define_events()
        {
            this.Load += new System.EventHandler(this.f400_Main_Load);
            //this.m_menu_item_he_thong_nguoi_su_dung.Click += new System.EventHandler(this.m_menu_item_he_thong_nguoi_su_dung_Click);
            //this.m_menu_item_he_thong_nhom_nguoi_su__dung.Click += new System.EventHandler(this.m_menu_item_he_thong_nhom_nguoi_su__dung_Click);
            //this.m_menu_item_he_thong_nhat_ky_he_thong.Click += new System.EventHandler(this.m_menu_item_he_thong_nhat_ky_he_thong_Click);
            //this.m_menu_item_he_thong_phan_quyen_cho_nhom.Click += new System.EventHandler(this.m_menu_item_he_thong_phan_quyen_cho_nhom_Click);
            //this.m_menu_item_tu_dien_he_thong.Click += new System.EventHandler(this.m_menu_item_tu_dien_he_thong_Click);
            //this.m_menu_item_he_thong_thoat.Click += new System.EventHandler(this.m_menu_item_he_thong_thoat_Click);
            //this.m_menu_item_danh_muc_bac_si.Click += new System.EventHandler(this.m_menu_item_danh_muc_bac_si_Click);


        }
        #endregion

        #region Events
        private void f400_Main_Load(object sender, EventArgs e)
        {
            try
            {
                //format_dotnetbar_menu();
                uc_f05_Image_Main uc_frm = new uc_f05_Image_Main();
                uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
                m_Panel_Content.Controls.Add(uc_frm);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_item_danh_muc_thuoc_Click(object sender, EventArgs e)
        {
            //f500_dm_danh_muc_thuoc frm = new f500_dm_danh_muc_thuoc();
            //frm.ShowDialog();
            m_Panel_Content.Controls.Clear();
            uc500_dm_danh_muc_thuoc uc_frm = new uc500_dm_danh_muc_thuoc();
            uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
            m_Panel_Content.Controls.Add(uc_frm);
        }

        private void m_cmd_item_danh_muc_nhom_thuoc_Click(object sender, EventArgs e)
        {
            //f504_v_dm_nhom_thuoc frm = new f504_v_dm_nhom_thuoc();
            //frm.ShowDialog();
            m_Panel_Content.Controls.Clear();
            uc504_v_dm_nhom_thuoc uc_frm = new uc504_v_dm_nhom_thuoc();
            uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
            m_Panel_Content.Controls.Add(uc_frm);
        }

        private void m_cmd_item_chi_tiet_thuoc_Click(object sender, EventArgs e)
        {
            //f502_v_dm_thuoc frm = new f502_v_dm_thuoc();
            //frm.ShowDialog();
            m_Panel_Content.Controls.Clear();
            uc502_v_dm_thuoc uc_frm = new uc502_v_dm_thuoc();
            uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
            m_Panel_Content.Controls.Add(uc_frm);
        }

        private void m_cmd_item_danh_muc_khach_hang_Click(object sender, EventArgs e)
        {
            m_Panel_Content.Controls.Clear();
            uc801_dm_khach_hang v_frm = new uc801_dm_khach_hang();
            v_frm.Dock = System.Windows.Forms.DockStyle.Fill;
            m_Panel_Content.Controls.Add(v_frm);
        }

        private void m_cmd_nhom_khach_hang_Click(object sender, EventArgs e)
        {
            try
            {
                //f101_dm_nhom_khach_hang frm = new f101_dm_nhom_khach_hang();
                //frm.ShowDialog();
                m_Panel_Content.Controls.Clear();
                uc_f101_dm_nhom_khach_hang uc_frm = new uc_f101_dm_nhom_khach_hang();
                uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
                m_Panel_Content.Controls.Add(uc_frm);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_item_danh_muc_nha_cung_cap_Click(object sender, EventArgs e)
        {
            //f800_dm_nha_cung_cap frm = new f800_dm_nha_cung_cap();
            //frm.ShowDialog();
            m_Panel_Content.Controls.Clear();
            uc800_dm_nha_cung_cap v_frm = new uc800_dm_nha_cung_cap();
            v_frm.Dock = System.Windows.Forms.DockStyle.Fill;
            m_Panel_Content.Controls.Add(v_frm);
        }


        private void m_cmd_item_phan_quyen_he_thong_Click(object sender, EventArgs e)
        {
            //f993_phan_quyen_he_thong v_frm = new f993_phan_quyen_he_thong();
            f901_phan_quyen_su_dung_form_cho_nhom_nguoi_su_dung v_frm = new f901_phan_quyen_su_dung_form_cho_nhom_nguoi_su_dung();
            v_frm.Show();
        }

        private void m_cmd_item_danh_muc_control_Click(object sender, EventArgs e)
        {
            //f991_v_ht_control_in_form v_frm = new f991_v_ht_control_in_form();
            f902_form_control v_frm = new f902_form_control();
            v_frm.Show();
        }

        //private void m_cmd_item_phan_quyen_chi_tiet_Click(object sender, EventArgs e)
        //{
        //    f994_phan_quyen_detail v_frm = new f994_phan_quyen_detail();
        //    v_frm.ShowDialog();
        //}

        private void m_cmd_item_nguoi_su_dung_Click(object sender, EventArgs e)
        {
            try
            {
                f999_ht_nguoi_su_dung frm = new f999_ht_nguoi_su_dung();
                frm.Show();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_item_nhom_nguoi_su_dung_Click(object sender, EventArgs e)
        {
            try
            {
                f997_ht_nhom_nguoi_su_dung frm = new f997_ht_nhom_nguoi_su_dung();
                frm.Show();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        //private void m_cmd_item_nhat_ki_he_thong_Click(object sender, EventArgs e)
        //{
        //   try
        //   {
        //       //test v_frm = new test();
        //       //f1000_phan_quyen_tong_hop v_frm = new f1000_phan_quyen_tong_hop();
        //       f901_phan_quyen_su_dung_form_cho_nhom_nguoi_su_dung v_frm = new f901_phan_quyen_su_dung_form_cho_nhom_nguoi_su_dung();
        //       v_frm.ShowDialog();
        //   }
        //   catch (System.Exception v_e)
        //   {
        //    CSystemLog_301.ExceptionHandle(v_e);
        //   }
        //}

        //private void m_cmd_item_phan_quyen_cho_nhom_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        f995_ht_phan_quyen_cho_nhom frm = new f995_ht_phan_quyen_cho_nhom();
        //        frm.ShowDialog();
        //    }
        //    catch (System.Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }

        //}

        //private void m_cmd_item_tu_dien_he_thong_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        IP.Core.IPSystemAdmin.f100_TuDien v_frm = new f100_TuDien();
        //        v_frm.ShowDialog();

        //    }
        //    catch (System.Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        private void m_cmd_item_thoat_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmt_thoat_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }


        #endregion


        private void m_cmd_item_danh_muc_bac_sy_Click(object sender, EventArgs e)
        {
            try
            {
                //f100_V_DM_BAC_SY v_frm_f100_V_DM_BAC_SY = new f100_V_DM_BAC_SY();
                //v_frm_f100_V_DM_BAC_SY.ShowDialog();
                m_Panel_Content.Controls.Clear();
                uc_f100_dm_bac_sy uc_frm = new uc_f100_dm_bac_sy();
                uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
                m_Panel_Content.Controls.Add(uc_frm);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_item_ht_form_Click(object sender, EventArgs e)
        {
            try
            {
                f990_ht_form v_frm = new f990_ht_form();
                v_frm.ShowDialog();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_don_vi_tinh_Click(object sender, EventArgs e)
        {
            try
            {
                f102_V_DM_DON_VI_TINH v_frm = new f102_V_DM_DON_VI_TINH();
                v_frm.ShowDialog();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_don_vi_Click(object sender, EventArgs e)
        {
            try
            {
                //m_Panel_Content.Controls.Clear();
                //uc_103_dm_don_vi uc_frm = new uc_103_dm_don_vi();
                //uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
                //m_Panel_Content.Controls.Add(uc_frm);
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }



        private void m_cmd_quan_ly_thuoc_het_han_Click(object sender, EventArgs e)
        {

        }



        private void cmd_item_quan_ly_nhap_thuoc_Click(object sender, EventArgs e)
        {
            //f511_gd_nhap_thuoc frm = new f511_gd_nhap_thuoc();
            ////test frm = new test();
            //frm.ShowDialog();
            m_Panel_Content.Controls.Clear();
            uc512_giao_dich_nhap_thuoc uc_frm = new uc512_giao_dich_nhap_thuoc();
            uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
            m_Panel_Content.Controls.Add(uc_frm);
        }



        private void m_cmd_item_quan_ly_gia_Click(object sender, EventArgs e)
        {
            try
            {
                m_Panel_Content.Controls.Clear();
                uc_802_gd_gia_ban uc_frm = new uc_802_gd_gia_ban();
                uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
                m_Panel_Content.Controls.Add(uc_frm);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_quan_ly_thuoc_ban_le_Click(object sender, EventArgs e)
        {
            try
            {
                m_Panel_Content.Controls.Clear();
                uc108_v_gd_giao_dich_detail uc_frm = new uc108_v_gd_giao_dich_detail();
                uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
                m_Panel_Content.Controls.Add(uc_frm);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_quan_ly_so_du_Click(object sender, EventArgs e)
        {
            try
            {
                m_Panel_Content.Controls.Clear();
                uc807_v_so_du uc_frm = new uc807_v_so_du();
                uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
                m_Panel_Content.Controls.Add(uc_frm);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }




        private void m_cmd_quan_ly_thuoc_het_han_Click_1(object sender, EventArgs e)
        {
            try
            {
                m_Panel_Content.Controls.Clear();
                uc_804_han_su_dung uc_frm = new uc_804_han_su_dung();
                uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
                m_Panel_Content.Controls.Add(uc_frm);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }




        private void m_cmd_nuoc_san_xuat_Click(object sender, EventArgs e)
        {
            try
            {
                m_Panel_Content.Controls.Clear();
                uc805_dm_nuoc_san_xuat uc_frm = new uc805_dm_nuoc_san_xuat();
                uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
                m_Panel_Content.Controls.Add(uc_frm);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_nha_san_xuat_Click(object sender, EventArgs e)
        {
            try
            {
                m_Panel_Content.Controls.Clear();
                uc806_dm_nha_san_xuat uc_frm = new uc806_dm_nha_san_xuat();
                uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
                m_Panel_Content.Controls.Add(uc_frm);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void f400_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn cập nhật thống kê không?",
                "Quản lý bán thuốc", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {

                BaseMessages.MsgBox_Infor("Đã cập nhật");
                return;

            }
            if (result == DialogResult.No)
            {
                BaseMessages.MsgBox_Infor("Chưa cập nhật");
                return;
            }
        }


        private void m_cmd_don_vi_kinh_doanh_Click(object sender, EventArgs e)
        {
            try
            {

                m_Panel_Content.Controls.Clear();
                uc106_dm_don_vi_kinh_doanh uc_frm = new uc106_dm_don_vi_kinh_doanh();
                uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
                m_Panel_Content.Controls.Add(uc_frm);
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_dm_benh_vien_Click(object sender, EventArgs e)
        {
            m_Panel_Content.Controls.Clear();
            uc515_v_dm_benh_vien uc_frm = new uc515_v_dm_benh_vien();
            uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
            m_Panel_Content.Controls.Add(uc_frm);
            //f515_v_dm_benh_vien frm = new f515_v_dm_benh_vien();
            //frm.ShowDialog();

        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                f441_bcdt_bac_sy_de v_frm = new f441_bcdt_bac_sy_de();
                v_frm.ShowDialog();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            try
            {
                f442_bcdt_bac_sy v_frm = new f442_bcdt_bac_sy();
                v_frm.ShowDialog();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            try
            {
                f443_bcdt_ncc v_frm = new f443_bcdt_ncc();
                v_frm.ShowDialog();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {
                f444_bcdt_ngay_khach_hang v_frm = new f444_bcdt_ngay_khach_hang();
                v_frm.ShowDialog();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try
            {
                f445_bcdt_ngay_nhan_vien v_frm = new f445_bcdt_ngay_nhan_vien();
                v_frm.ShowDialog();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            try
            {
                f446_bcdt_ngay_nv_de v_frm = new f446_bcdt_ngay_nv_de();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            try
            {
                f447_bcdt_nhan_vien v_frm = new f447_bcdt_nhan_vien();
                v_frm.ShowDialog();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            try
            {
                f448_bcdt_ngay_nhom_thuoc v_frm = new f448_bcdt_ngay_nhom_thuoc();
                v_frm.ShowDialog();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                f449_bcdt_nhom_thuoc_ten_thuoc v_frm = new f449_bcdt_nhom_thuoc_ten_thuoc();
                v_frm.ShowDialog();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                f450_bc_xuat v_frm = new f450_bc_xuat();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                f451_bcnt_ngay_va_hsx v_frm = new f451_bcnt_ngay_va_hsx();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                f452_bcnt_ngay_va_nhan_vien v_frm = new f452_bcnt_ngay_va_nhan_vien();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                f455_bcnt_ncc_de v_frm = new f455_bcnt_ncc_de();

                v_frm.ShowDialog();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                f454_bcnt_nhan_vien_de v_frm = new f454_bcnt_nhan_vien_de();
                v_frm.ShowDialog();
            }
            catch (System.Exception ex)
            {
                CSystemLog_301.ExceptionHandle(ex);
            }
        }

        private void m_cmd_bc_dm_thuoc_theo_nhom_thuoc_Click(object sender, EventArgs e)
        {
            try
            {
                f408_v_bao_cao_danh_muc_thuoc_theo_nhom_thuoc v_frm = new f408_v_bao_cao_danh_muc_thuoc_theo_nhom_thuoc();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bc_dm_thuoc_theo_hsx_Click(object sender, EventArgs e)
        {
            try
            {
                f409_bao_cao_danh_muc_thuoc_theo_hsx v_frm = new f409_bao_cao_danh_muc_thuoc_theo_hsx();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bc_dm_thuoc_theo_ncc_Click(object sender, EventArgs e)
        {
            try
            {
                f410_bao_cao_danh_muc_thuoc_theo_ncc v_frm = new f410_bao_cao_danh_muc_thuoc_theo_ncc();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bc_dm_thuoc_theo_nsx_Click(object sender, EventArgs e)
        {
            try
            {
                f411_bao_cao_danh_muc_thuoc_theo_nsx v_frm = new f411_bao_cao_danh_muc_thuoc_theo_nsx();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bc_kiem_ke_kho_Click(object sender, EventArgs e)
        {
            try
            {
                f412_bao_cao_kiem_ke_kho v_frm = new f412_bao_cao_kiem_ke_kho();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bc_dm_bac_sy_theo_benh_vien_Click(object sender, EventArgs e)
        {
            try
            {
                f413_v_bao_cao_danh_muc_bac_sy v_frm = new f413_v_bao_cao_danh_muc_bac_sy();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bc_dm_khach_hang_Click(object sender, EventArgs e)
        {
            try
            {
                f414_bao_cao_danh_muc_khach_hang v_frm = new f414_bao_cao_danh_muc_khach_hang();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bc_nhap_thuoc_theo_gia_Click(object sender, EventArgs e)
        {
            try
            {
                f440_bcnt_theo_gia v_frm = new f440_bcnt_theo_gia();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bc_nhap_thuoc_theo_ncc_Click(object sender, EventArgs e)
        {

        }

        private void m_cmd_bc_nhap_thuoc_theo_nhan_vien_Click(object sender, EventArgs e)
        {
            try
            {
                f423_bcnt_theo_cac_nv_va_ngay v_frm = new f423_bcnt_theo_cac_nv_va_ngay();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bc_nhap_thuoc_theo_hsx_Click(object sender, EventArgs e)
        {
            try
            {
                f425_bcnt_theo_cac_HSX_de v_frm = new f425_bcnt_theo_cac_HSX_de();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bc_doanh_thu_theo_bac_sy_Click(object sender, EventArgs e)
        {
            try
            {
                f402_bao_cao_doanh_thu_theo_cac_bac_sy v_frm = new f402_bao_cao_doanh_thu_theo_cac_bac_sy();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_bc_doanh_thu_theo_ncc_Click(object sender, EventArgs e)
        {
            try
            {
                f403_bao_cao_doanh_thu_theo_cac_ncc v_frm = new f403_bao_cao_doanh_thu_theo_cac_ncc();
                v_frm.ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_thong_tin_lien_he_Click(object sender, EventArgs e)
        {
            f521_thong_tin_lien_he v_frm = new f521_thong_tin_lien_he();
            v_frm.ShowDialog();
        }

    }     
}
