using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLHT.US;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;
using IP.Core.IPCommon;
using System.Collections;

namespace BKI_QLHT
{
    public partial class f505_v_dm_nhom_thuoc_de : Form
    {
        public f505_v_dm_nhom_thuoc_de()
        {
            InitializeComponent();
            load_data_2_cbo();
        }
        #region Public Interface
        public void display_for_insert()
        {
            m_e_for_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_V_DM_NHOM_THUOC ip_v_us)
        {
            m_e_for_mode = DataEntryFormMode.UpdateDataState;
            us_obj_2_form(ip_v_us);
            this.ShowDialog();
        }
        #endregion
        #region Member
        DS_V_DM_NHOM_THUOC m_ds_v = new DS_V_DM_NHOM_THUOC();
        US_V_DM_NHOM_THUOC m_us_v = new US_V_DM_NHOM_THUOC();
        US_DM_NHOM_THUOC m_us_nhom_thuoc = new US_DM_NHOM_THUOC();
        DataEntryFormMode m_e_for_mode = DataEntryFormMode.InsertDataState;

        #endregion
        #region Private Method
        private void load_data_2_cbo()
        {
            US_DM_DANH_MUC_THUOC v_us_dm = new US_DM_DANH_MUC_THUOC();
            DS_DM_DANH_MUC_THUOC v_ds_dm = new DS_DM_DANH_MUC_THUOC();
            v_us_dm.FillDataset(v_ds_dm);
            m_cbo_danh_muc.DataSource = v_ds_dm.DM_DANH_MUC_THUOC;
            m_cbo_danh_muc.ValueMember = DM_DANH_MUC_THUOC.ID;
            m_cbo_danh_muc.DisplayMember = DM_DANH_MUC_THUOC.TEN_DANH_MUC;

        }
        private void form_2_us_obj()
        {
            m_us_nhom_thuoc.strTEN_NHOM = m_txt_nhom_thuoc.Text;
            //m_us.strTEN_DANH_MUC=m_cbo_danh_muc_thuoc.Text;
            m_us_nhom_thuoc.strGHI_CHU = m_txt_ghi_chu.Text;
            m_us_nhom_thuoc.dcID_DANH_MUC_THUOC = CIPConvert.ToDecimal(m_cbo_danh_muc.SelectedValue);
        }
        private void us_obj_2_form(US_V_DM_NHOM_THUOC ip_us_v_dm)
        {
            m_us_nhom_thuoc.dcID = ip_us_v_dm.dcID;
            m_cbo_danh_muc.SelectedValue = ip_us_v_dm.dcID_DANH_MUC_THUOC;
            m_txt_nhom_thuoc.Text = ip_us_v_dm.strTEN_NHOM;
            m_txt_ghi_chu.Text = ip_us_v_dm.strGHI_CHU;
        }
        private void save_data()
        {
            form_2_us_obj();
            switch (m_e_for_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_nhom_thuoc.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_nhom_thuoc.Update();
                    break;

            }
            xoa_trang();
            BaseMessages.MsgBox_Infor("Cập nhật thành công");
            this.Close();


        }
        private void xoa_trang()
        {

            m_txt_nhom_thuoc.Clear();
            m_cbo_danh_muc.SelectedIndex = 0;
            m_txt_ghi_chu.Clear();
            m_e_for_mode = DataEntryFormMode.InsertDataState;

        }
        #endregion

       
        #region Event
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
        #endregion

        private void m_cmd_huy_Click(object sender, EventArgs e)
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



        
    }
}
