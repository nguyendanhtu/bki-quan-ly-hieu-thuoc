using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLHT.DS;
using BKI_QLHT.US;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

namespace BKI_QLHT
{
        #region public interface
    public partial class f101_dm_nhom_khach_hang_de : Form
    {
        public f101_dm_nhom_khach_hang_de()
        {
            InitializeComponent();
            format_control();
        }

        private void format_control()
        {

            CControlFormat.setFormStyle(this, new CAppContext_201());
        }

        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US_DM_NHOM_KHACH_HANG ip_m_us_dm_nhom_khach_hang)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_nhom_khach_hang = ip_m_us_dm_nhom_khach_hang;
            m_us_obj_to_form();
            this.ShowDialog();
        }
    #endregion 
 
        #region Members
        DS_DM_NHOM_KHACH_HANG m_ds_dm_nhom_khach_hang = new DS_DM_NHOM_KHACH_HANG();
        US_DM_NHOM_KHACH_HANG m_us_dm_nhom_khach_hang = new US_DM_NHOM_KHACH_HANG();
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
        #endregion

        #region private method
        private void m_form_to_us_obj()
        {
            m_us_dm_nhom_khach_hang.strMA_NHOM = m_txt_ma_nhom.Text;
            m_us_dm_nhom_khach_hang.strTEN_NHOM = m_txt_ten_nhom.Text;
        }

        private void m_us_obj_to_form()
        {
            m_txt_ma_nhom.Text = m_us_dm_nhom_khach_hang.strMA_NHOM;
            m_txt_ten_nhom.Text = m_us_dm_nhom_khach_hang.strTEN_NHOM;
        }

        #endregion

        #region Event
        private void m_cmd_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void m_cmd_Cap_Nhat_Click(object sender, EventArgs e)
        {
            m_form_to_us_obj();
            try
            {

                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        m_us_dm_nhom_khach_hang.Insert();
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        m_us_dm_nhom_khach_hang.Update();
                        break;
                    default: m_us_dm_nhom_khach_hang.Insert(); ; break;
                }

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            this.Close();
        }
        #endregion

    }
}
