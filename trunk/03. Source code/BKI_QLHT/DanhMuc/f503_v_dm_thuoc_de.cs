using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLHT.US;
using IP.Core.IPCommon;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;

namespace BKI_QLHT
{

    public partial class f503_v_dm_thuoc_de : Form
    {


        public f503_v_dm_thuoc_de()
        {
            InitializeComponent();
            load_data_2_cbo_danh_muc();
            load_data_2_cbo_nhom_thuoc();
        }


        #region Public Interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_DM_THUOC ip_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_thuoc = ip_us;
            us_obj_2_form(m_us_dm_thuoc);
            this.ShowDialog();
        }
        #endregion
        #region Members
        US_DM_THUOC m_us_dm_thuoc = new US_DM_THUOC();
        DataEntryFormMode m_e_form_mode;
        #endregion
        #region Private Methods
        private void load_data_2_cbo_danh_muc()
        {
            US_DM_DANH_MUC_THUOC v_us = new US_DM_DANH_MUC_THUOC();
            DS_DM_DANH_MUC_THUOC v_ds = new DS_DM_DANH_MUC_THUOC();
            v_us.FillDataset(v_ds);
            m_cbo_danh_muc_thuoc.DataSource = v_ds.DM_DANH_MUC_THUOC;
            m_cbo_danh_muc_thuoc.ValueMember = DM_DANH_MUC_THUOC.ID;
            m_cbo_danh_muc_thuoc.DisplayMember = DM_DANH_MUC_THUOC.TEN_DANH_MUC;
        }
        private void load_data_2_cbo_nhom_thuoc()
        {
            US_DM_NHOM_THUOC v_us = new US_DM_NHOM_THUOC();
            DS_DM_NHOM_THUOC v_ds = new DS_DM_NHOM_THUOC();
            v_us.FillDataset(v_ds);
            m_cbo_nhom_thuoc.DataSource = v_ds.DM_NHOM_THUOC;
            m_cbo_nhom_thuoc.ValueMember = DM_NHOM_THUOC.ID;
            m_cbo_nhom_thuoc.DisplayMember = DM_NHOM_THUOC.TEN_NHOM;
           

        }
        private void form_2_us_obj()
        {
            m_us_dm_thuoc.strTEN_THUOC = m_txt_ten_thuoc.Text;
            m_us_dm_thuoc.strTHUOC_THAY_THE = m_txt_thuoc_thay_the.Text;
            m_us_dm_thuoc.dcID_NHOM_THUOC = CIPConvert.ToDecimal(m_cbo_nhom_thuoc.SelectedValue);
            m_us_dm_thuoc.dcID_DANH_MUC_THUOC = CIPConvert.ToDecimal(m_cbo_nhom_thuoc.SelectedValue);
            //m_us_dm_thuoc.strTUYEN_SU_DUNG_5 = m_txt_tuyen_su_dung.Text;
            m_us_dm_thuoc.strDUONG_DUNG_DANG_DUNG = m_txt_cach_dung.Text;
            //m_us_dm_thuoc.strTUYEN_SU_DUNG_6 = m_txt_tuyen_su_dung.Text;
            //m_us_dm_thuoc.strTUYEN_SU_DUNG_7 = m_txt_tuyen_su_dung.Text;
            //m_us_dm_thuoc.strTUYEN_SU_DUNG_8 = m_txt_tuyen_su_dung.Text;
            m_us_dm_thuoc.dcTT_THUOC = CIPConvert.ToDecimal(m_txt_tt_thuoc.Text);
            m_us_dm_thuoc.dcTT_HOAT_CHAT = CIPConvert.ToDecimal(m_txt_tt_hoat_chat.Text);
            if (m_chk_tuyen_su_dung_5.Checked == true) m_us_dm_thuoc.strTUYEN_SU_DUNG_5 = "+";
            if (m_chk_tuyen_su_dung_6.Checked == true) m_us_dm_thuoc.strTUYEN_SU_DUNG_6 = "+";
            if (m_chk_tuyen_su_dung_7.Checked == true) m_us_dm_thuoc.strTUYEN_SU_DUNG_7 = "+";
            if (m_chk_tuyen_su_dung_8.Checked == true) m_us_dm_thuoc.strTUYEN_SU_DUNG_8 = "+";
        }
        private void us_obj_2_form(US_DM_THUOC ip_us_dm_thuoc)
        {

            m_txt_ten_thuoc.Text = ip_us_dm_thuoc.strTEN_THUOC;
            m_txt_thuoc_thay_the.Text = ip_us_dm_thuoc.strTHUOC_THAY_THE;
            m_cbo_nhom_thuoc.SelectedValue = ip_us_dm_thuoc.dcID_NHOM_THUOC;
            m_cbo_danh_muc_thuoc.SelectedValue = ip_us_dm_thuoc.dcID_DANH_MUC_THUOC;
            m_txt_cach_dung.Text = ip_us_dm_thuoc.strDUONG_DUNG_DANG_DUNG;
            m_txt_tt_hoat_chat.Text = CIPConvert.ToStr(ip_us_dm_thuoc.dcTT_HOAT_CHAT);
            m_txt_tt_thuoc.Text = CIPConvert.ToStr(ip_us_dm_thuoc.dcTT_THUOC);
            //m_txt_tuyen_su_dung.Text = ip_us_dm_thuoc.strTUYEN_SU_DUNG_5;

            if (m_us_dm_thuoc.strTUYEN_SU_DUNG_5 == "+") m_chk_tuyen_su_dung_5.Checked = true;
            if (m_us_dm_thuoc.strTUYEN_SU_DUNG_6 == "+") m_chk_tuyen_su_dung_6.Checked = true;
            if (m_us_dm_thuoc.strTUYEN_SU_DUNG_7 == "+") m_chk_tuyen_su_dung_7.Checked = true;
            if (m_us_dm_thuoc.strTUYEN_SU_DUNG_8 == "+") m_chk_tuyen_su_dung_8.Checked = true;

        }
        private void save_data()
        {

            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_thuoc.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_thuoc.Update();
                    break;


            }
            this.Close();
        }
        #endregion

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #region Event

        #endregion






    }
}
