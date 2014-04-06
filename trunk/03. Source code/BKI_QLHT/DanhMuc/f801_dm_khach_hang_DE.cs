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
    public partial class f801_dm_khach_hang_DE : Form
    {
        public f801_dm_khach_hang_DE()
        {
            InitializeComponent();
            Load_Data_to_m_cbo_nhom_khach_hang();
        }

        
        #region public interfaces
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();

        }
        public void display_for_update(US_V_DM_KHACH_HANG m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_khach_hang.dcID = m_us.dcID;
            m_us_dm_khach_hang.strTEN_KHACH_HANG = m_us.strTEN_KHACH_HANG;
            m_us_dm_khach_hang.strMA_KHACH_HANG = m_us.strMA_KHACH_HANG;
            m_us_dm_khach_hang.strSDT = m_us.strSDT;
            m_us_dm_khach_hang.strMA_SO_THUE = m_us.strMA_SO_THUE;
            m_us_dm_khach_hang.strDIA_CHI = m_us.strDIA_CHI;
            m_us_dm_khach_hang.dcID_NHOM_KHACH_HANG = m_us.dcID_NHOM_KHACH_HANG;
            us_obj_2_form();
            this.ShowDialog();
        }

        
        #endregion


        #region members
        DataEntryFormMode m_e_form_mode;
        US_DM_KHACH_HANG m_us_dm_khach_hang = new US_DM_KHACH_HANG();
        #endregion


        #region private methods
       private void form_2_us_obj()
        {
            m_us_dm_khach_hang.strTEN_KHACH_HANG = m_txt_ten_khach_hang.Text;
            m_us_dm_khach_hang.strMA_KHACH_HANG = m_txt_ma_khach_hang.Text;
            m_us_dm_khach_hang.strDIA_CHI = m_txt_dia_chi.Text;
            m_us_dm_khach_hang.strSDT = m_txt_so_dien_thoai.Text;
            m_us_dm_khach_hang.strMA_SO_THUE = m_txt_ma_so_thue.Text;
            m_us_dm_khach_hang.dcID_NHOM_KHACH_HANG = CIPConvert.ToDecimal(m_cbo_nhom_khach_hang.SelectedValue);
        }
       private void us_obj_2_form()
        {
            m_txt_ten_khach_hang.Text = m_us_dm_khach_hang.strTEN_KHACH_HANG;
            m_txt_ma_khach_hang.Text = m_us_dm_khach_hang.strMA_KHACH_HANG;
            m_txt_so_dien_thoai.Text = m_us_dm_khach_hang.strSDT;
            m_txt_dia_chi.Text = m_us_dm_khach_hang.strDIA_CHI;
            m_txt_ma_so_thue.Text = m_us_dm_khach_hang.strMA_SO_THUE;
            m_cbo_nhom_khach_hang.SelectedValue = m_us_dm_khach_hang.dcID_NHOM_KHACH_HANG;
        }
       private void Load_Data_to_m_cbo_nhom_khach_hang()
       {
           US_DM_NHOM_KHACH_HANG v_us = new US_DM_NHOM_KHACH_HANG();
           DS_DM_NHOM_KHACH_HANG v_ds = new DS_DM_NHOM_KHACH_HANG();
           v_us.FillDataset(v_ds);
           m_cbo_nhom_khach_hang.DataSource = v_ds.Tables[0];
           m_cbo_nhom_khach_hang.ValueMember = DM_NHOM_KHACH_HANG.ID;
           m_cbo_nhom_khach_hang.DisplayMember = DM_NHOM_KHACH_HANG.TEN_NHOM;
       }
        

        #endregion

      

        #region events
       private void m_cmd_save_Click(object sender, EventArgs e)
       {
           form_2_us_obj();
           switch (m_e_form_mode)
           {
               case DataEntryFormMode.InsertDataState:
                   m_us_dm_khach_hang.Insert();
                   this.Close();
                   break;
               case DataEntryFormMode.SelectDataState:
                   break;
               case DataEntryFormMode.UpdateDataState:
                   m_us_dm_khach_hang.Update();
                   this.Close();
                   break;
               case DataEntryFormMode.ViewDataState:
                   break;
               default:
                   break;
           }
       }
       private void m_cmd_exit_Click(object sender, EventArgs e)
       {
           this.Close();
       }
        #endregion

       
    }
}
