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
using BKI_QLHT.HeThong;

namespace BKI_QLHT
{
    public partial class f400_Main : Form
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

        private void format_controls()
        {
            CControlFormat.setFormStyle(this);
            set_define_events();
            ShowInTaskbar = true;
        }
        private void set_define_events()
        {
            this.Load += new System.EventHandler(this.f400_Main_Load);
            this.m_menu_item_he_thong_nguoi_su_dung.Click += new System.EventHandler(this.m_menu_item_he_thong_nguoi_su_dung_Click);
            this.m_menu_item_he_thong_nhom_nguoi_su__dung.Click += new System.EventHandler(this.m_menu_item_he_thong_nhom_nguoi_su__dung_Click);
            this.m_menu_item_he_thong_nhat_ky_he_thong.Click += new System.EventHandler(this.m_menu_item_he_thong_nhat_ky_he_thong_Click);
            this.m_menu_item_he_thong_phan_quyen_cho_nhom.Click += new System.EventHandler(this.m_menu_item_he_thong_phan_quyen_cho_nhom_Click);
            this.m_menu_item_tu_dien_he_thong.Click += new System.EventHandler(this.m_menu_item_tu_dien_he_thong_Click);
            this.m_menu_item_he_thong_thoat.Click += new System.EventHandler(this.m_menu_item_he_thong_thoat_Click);

        }
        #endregion

        #region Events
        private void f400_Main_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_menu_item_he_thong_nguoi_su_dung_Click(object sender, EventArgs e)
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

        private void m_menu_item_he_thong_nhom_nguoi_su__dung_Click(object sender, EventArgs e)
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

        private void m_menu_item_he_thong_nhat_ky_he_thong_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_menu_item_he_thong_phan_quyen_cho_nhom_Click(object sender, EventArgs e)
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

        private void m_menu_item_tu_dien_he_thong_Click(object sender, EventArgs e)
        {
            try
            {
            	
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }

        private void m_menu_item_he_thong_thoat_Click(object sender, EventArgs e)
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

    }
}
