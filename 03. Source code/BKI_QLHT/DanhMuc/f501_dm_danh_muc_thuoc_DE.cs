using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using BKI_QLHT.US;
using BKI_QLHT.DS.CDBNames;
using BKI_QLHT.DS;

namespace BKI_QLHT
{
    public partial class f501_dm_danh_muc_thuoc_DE : Form
    {
        public f501_dm_danh_muc_thuoc_DE()
        {
            InitializeComponent();
        }
        #region Public Interface
        public void display_for_insert()
        {
            m_e_for_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_DM_DANH_MUC_THUOC m_us)
        {
            m_e_for_mode = DataEntryFormMode.UpdateDataState;
            m_us_danh_muc_thuoc = m_us;
            us_obj_2_form();
            this.ShowDialog();
        }
        #endregion
        #region Member
        DataEntryFormMode m_e_for_mode=DataEntryFormMode.InsertDataState;
        US_DM_DANH_MUC_THUOC m_us_danh_muc_thuoc = new US_DM_DANH_MUC_THUOC();
        DS_DM_DANH_MUC_THUOC m_ds_danh_muc_thuoc = new DS_DM_DANH_MUC_THUOC();
        #endregion
        #region Private Method
        private void form_2_us_obj() {
            m_us_danh_muc_thuoc.strTEN_DANH_MUC = m_txt_danh_muc.Text;
            m_us_danh_muc_thuoc.strGHI_CHU = m_txt_ghi_chu.Text;
        }
        private void us_obj_2_form() {
            m_txt_danh_muc.Text = m_us_danh_muc_thuoc.strTEN_DANH_MUC;
            m_txt_ghi_chu.Text = m_us_danh_muc_thuoc.strGHI_CHU;
        }
        private void save_data()
        {
            form_2_us_obj();
            switch (m_e_for_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_danh_muc_thuoc.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_danh_muc_thuoc.Update();
                    break;
                
            }
            xoa_trang();
            BaseMessages.MsgBox_Infor("Cập nhật thành công");
            this.Close();
            

        }
        private void xoa_trang() {
            
                m_txt_danh_muc.Clear();
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
        #endregion

        
    }
    
}
