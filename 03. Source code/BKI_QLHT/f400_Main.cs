using System;
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
using DevComponents.DotNetBar;


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

        #endregion

        #region Members

        #endregion

        #region Private Method
        private void format_dotnetbar_menu()
        {
            CAppContext_201 v_context = new CAppContext_201();
            foreach (Control v_sub_control in m_ribbonControl_Main.Controls)
            {
                if (v_sub_control.GetType().Name == "RibbonPanel")
                {
                    foreach (Control v_sub_sub_control in v_sub_control.Controls)
                    {
                        if (v_sub_sub_control.GetType().Name == "RibbonBar")
                        {
                            RibbonBar v_rp = (RibbonBar)v_sub_sub_control;
                            int v_dem = 0;
                            for (int i = 0; i < v_rp.Items.Count; i++)
                            {
                                if (v_context.CanUseControl(this.Name, v_rp.Items[i].Name, v_rp.Items[i].GetType().Name))
                                {
                                    v_rp.Items[i].Visible = true;
                                    v_rp.Items[i].Enabled = true;
                                    v_dem++;
                                    
                                }
                                else
                                {
                                    //v_rp.Items[i].Visible = false;
                                    //v_rp.Items[i].Enabled = false;
                                }
                              
                            }
                            if (v_dem == 0) v_rp.Visible = false;
                            
                        }

                    }
                }
            }
        }
        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            format_dotnetbar_menu();
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
            //f101_dm_nhom_khach_hang frm = new f101_dm_nhom_khach_hang();
            //frm.ShowDialog();
            m_Panel_Content.Controls.Clear();
            uc_f101_dm_nhom_khach_hang uc_frm = new uc_f101_dm_nhom_khach_hang();
            uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
            m_Panel_Content.Controls.Add(uc_frm);
        }

        private void m_cmd_item_danh_muc_nha_cung_cap_Click(object sender, EventArgs e)
        {
            //f800_dm_nha_cung_cap frm = new f800_dm_nha_cung_cap();
            //frm.ShowDialog();
            m_Panel_Content.Controls.Clear();
            uc_800_dm_nha_cung_cap v_frm=new uc_800_dm_nha_cung_cap();
            v_frm.Dock = System.Windows.Forms.DockStyle.Fill;
            m_Panel_Content.Controls.Add(v_frm);
        }


        private void m_cmd_item_phan_quyen_he_thong_Click(object sender, EventArgs e)
        {
            f993_phan_quyen_he_thong v_frm = new f993_phan_quyen_he_thong();
            v_frm.display();
        }

        private void m_cmd_item_danh_muc_control_Click(object sender, EventArgs e)
        {
            f991_v_ht_control_in_form v_frm = new f991_v_ht_control_in_form();
            v_frm.display();
        }

        private void m_cmd_item_phan_quyen_chi_tiet_Click(object sender, EventArgs e)
        {
            f994_phan_quyen_detail v_frm = new f994_phan_quyen_detail();
            v_frm.ShowDialog();
        }

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
        private void m_cmd_item_nhat_ki_he_thong_Click(object sender, EventArgs e)
        {
           
        }

        private void m_cmd_item_phan_quyen_cho_nhom_Click(object sender, EventArgs e)
        {
            try
            {
                f995_ht_phan_quyen_cho_nhom frm = new f995_ht_phan_quyen_cho_nhom();
                frm.ShowDialog();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_item_tu_dien_he_thong_Click(object sender, EventArgs e)
        {
            try
            {
                IP.Core.IPSystemAdmin.f100_TuDien v_frm = new f100_TuDien();
                v_frm.ShowDialog();
                
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

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
            //f100_V_DM_BAC_SY v_frm_f100_V_DM_BAC_SY = new f100_V_DM_BAC_SY();
            //v_frm_f100_V_DM_BAC_SY.ShowDialog();
            m_Panel_Content.Controls.Clear();
            uc_f100_dm_bac_sy uc_frm = new uc_f100_dm_bac_sy();
            uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
            m_Panel_Content.Controls.Add(uc_frm);
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

        //private void m_menu_item_he_thong_nguoi_su_dung_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        f999_ht_nguoi_su_dung frm = new f999_ht_nguoi_su_dung();
        //        frm.Show();
        //    }
        //    catch (System.Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }

        //}

        //private void m_menu_item_he_thong_nhom_nguoi_su__dung_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        f997_ht_nhom_nguoi_su_dung frm = new f997_ht_nhom_nguoi_su_dung();
        //        frm.Show();
        //    }
        //    catch (System.Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }


        //}

        //private void m_menu_item_he_thong_nhat_ky_he_thong_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //    }
        //    catch (System.Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }

        //}

        //private void m_menu_item_he_thong_phan_quyen_cho_nhom_Click(object sender, EventArgs e)
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

        //private void m_menu_item_tu_dien_he_thong_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //    }
        //    catch (System.Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }

        //}

        //private void m_menu_item_he_thong_thoat_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Application.Exit();
        //    }
        //    catch (System.Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }

        //}

        //private void m_menu_item_danh_muc_bac_si_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        f100_V_DM_BAC_SY v_frm_f100_V_DM_BAC_SY = new f100_V_DM_BAC_SY();
        //        v_frm_f100_V_DM_BAC_SY.ShowDialog();
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

        //private void m_menu_item_danh_muc_thuoc_Click(object sender, EventArgs e)
        //{
        //    f500_dm_danh_muc_thuoc frm = new f500_dm_danh_muc_thuoc();
        //    frm.ShowDialog();
        //}

        //private void m_menu_item_danh_muc_nha_cung_cap_Click(object sender, EventArgs e)
        //{
        //    f800_dm_nha_cung_cap frm = new f800_dm_nha_cung_cap();
        //    frm.ShowDialog();
        //}

        //private void m_menu_item_danh_muc_khach_hang_Click(object sender, EventArgs e)
        //{
        //    f801_dm_khach_hang frm = new f801_dm_khach_hang();
        //    frm.ShowDialog();
        //}

        //private void m_menu_item_danh_muc_nhom_khach_hang_Click(object sender, EventArgs e)
        //{
        //    f101_dm_nhom_khach_hang frm = new f101_dm_nhom_khach_hang();
        //    frm.ShowDialog();
        //}

        //private void m_menu_item_danh_muc_nhom_thuoc_Click(object sender, EventArgs e)
        //{
        //    f501_v_dm_nhom_thuoc frm = new f501_v_dm_nhom_thuoc();
        //    frm.ShowDialog();
        //}

        //private void m_menu_item_thuoc_Click(object sender, EventArgs e)
        //{
        //    f502_v_dm_thuoc frm = new f502_v_dm_thuoc();
        //    frm.ShowDialog();
        //}

        //private void m_menu_item_he_thong_danh_muc_control_Click(object sender, EventArgs e)
        //{
        //    f991_v_ht_control_in_form v_frm = new f991_v_ht_control_in_form();
        //    v_frm.display();
        //}

        //private void m_menu_item_he_thong_phan_quyen_he_thong_Click(object sender, EventArgs e)
        //{
        //    f993_phan_quyen_he_thong v_frm = new f993_phan_quyen_he_thong();
        //    v_frm.display();
        //}

        //private void m_menu_item_he_thong_phan_quyen_chi_tiet_Click(object sender, EventArgs e)
        //{
        //    f994_phan_quyen_detail v_frm = new f994_phan_quyen_detail();
        //    v_frm.ShowDialog();
        //}






    }     
}
