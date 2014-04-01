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

namespace BKI_QLHT
{
    public partial class f800_dm_nha_cung_cap_DE : Form
    {
        public f800_dm_nha_cung_cap_DE()
        {
            InitializeComponent();
        }
        
        #region public interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_DM_NHA_CUNG_CAP m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_nha_cung_cap = m_us;
            us_obj_2_form();
            this.ShowDialog();
        }
        #endregion


        #region members
        DataEntryFormMode m_e_form_mode;
        US_DM_NHA_CUNG_CAP m_us_dm_nha_cung_cap = new US_DM_NHA_CUNG_CAP();
        #endregion
        

        #region private methods

        private void form_2_us_obj()
        {
            m_us_dm_nha_cung_cap.strTEN_NCC =m_txt_ten_nha_cung_cap.Text ;
            m_us_dm_nha_cung_cap.strMA_NCC = m_txt_ma_nha_cung_cap.Text;
            m_us_dm_nha_cung_cap.strSDT = m_txt_sdt.Text;
            m_us_dm_nha_cung_cap.strDIA_CHI = m_txt_dia_chi.Text;
        }
        private void us_obj_2_form()
        {
            m_txt_ten_nha_cung_cap.Text = m_us_dm_nha_cung_cap.strTEN_NCC;
            m_txt_ma_nha_cung_cap.Text = m_us_dm_nha_cung_cap.strMA_NCC;
            m_txt_sdt.Text = m_us_dm_nha_cung_cap.strSDT;
            m_txt_dia_chi.Text = m_us_dm_nha_cung_cap.strDIA_CHI;
        }
        private void defineEvent()
        {
            
        }
        #endregion


        #region events  
        private void m_cmd_save_Click_1(object sender, EventArgs e)
        {
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_nha_cung_cap.Insert();
                    this.Close();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_nha_cung_cap.Update();
                    this.Close();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
        }

        private void m_cmd_thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
