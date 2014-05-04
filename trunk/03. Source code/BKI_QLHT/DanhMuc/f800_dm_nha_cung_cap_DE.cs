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
using IP.Core.IPSystemAdmin;


namespace BKI_QLHT
{
    public partial class f800_dm_nha_cung_cap_DE : Form
    {
        public f800_dm_nha_cung_cap_DE()
        {
            InitializeComponent();
            format_controls();
        }

        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }
        
        #region public interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_DM_NCC_NSX_NHASX ip_us_dm_ncc)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_ncc = ip_us_dm_ncc;
            us_obj_2_form();
            this.ShowDialog();
        }
        #endregion


        #region members
        DataEntryFormMode m_e_form_mode;
        US_V_DM_NCC_NSX_NHASX_1 m_us_v_dm_ncc = new US_V_DM_NCC_NSX_NHASX_1();
        DS_V_DM_NCC_NSX_NHASX_1 m_ds_v_dm_ncc = new DS_V_DM_NCC_NSX_NHASX_1();
        US_DM_NCC_NSX_NHASX m_us_dm_ncc = new US_DM_NCC_NSX_NHASX();
        DS_DM_NCC_NSX_NHASX m_ds_dm_ncc = new DS_DM_NCC_NSX_NHASX();
        #endregion
        

        #region private methods

        private void form_2_us_obj()
        {
            m_us_dm_ncc.strTEN_NCC =m_txt_ten_nha_cung_cap.Text ;
            m_us_dm_ncc.strMA_NCC = "NCC_" + m_txt_sdt.Text;
            m_us_dm_ncc.strSDT = m_txt_sdt.Text;
            m_us_dm_ncc.strDIA_CHI = m_txt_dia_chi.Text;
            m_us_dm_ncc.dcID_LOAI_DM = 1;
        }
        private void us_obj_2_form()
        {
            m_txt_ten_nha_cung_cap.Text = m_us_dm_ncc.strTEN_NCC;
            m_txt_sdt.Text = m_us_dm_ncc.strSDT;
            m_txt_dia_chi.Text = m_us_dm_ncc.strDIA_CHI;
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
                    m_us_dm_ncc.Insert();
                    this.Close();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_ncc.Update();
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

        private void save_data()
        {
             form_2_us_obj();
             switch (m_e_form_mode)
             {
                 case DataEntryFormMode.InsertDataState:
                     m_us_dm_ncc.Insert();
                     this.Close();
                     break;
                 case DataEntryFormMode.SelectDataState:
                     break;
                 case DataEntryFormMode.UpdateDataState:
                     m_us_dm_ncc.Update();
                     this.Close();
                     break;
                 case DataEntryFormMode.ViewDataState:
                     break;
                 default:
                     break;
             }
        }
        private void m_txt_sdt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                save_data();
            }
        }

        private void m_txt_dia_chi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                save_data();
            }
        }

        private void m_txt_ten_nha_cung_cap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                save_data();
            }
        }


    }
}
