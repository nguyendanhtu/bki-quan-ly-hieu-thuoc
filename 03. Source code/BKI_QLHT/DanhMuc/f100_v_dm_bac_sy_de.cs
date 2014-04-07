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
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;
using IP.Core.IPUserService;
using IP.Core.IPData;

namespace BKI_QLHT.DanhMuc
{
    public partial class f100_v_dm_bac_sy_de : Form
    {
        
        #region Public interface
        public f100_v_dm_bac_sy_de()
        {
            InitializeComponent();
            Load_cbo_benh_vien();
        }
        public void display_for_insert()
        {
            m_e = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_DM_BAC_SY ip_m_us_dm_bac_sy)
        {
            m_e = DataEntryFormMode.UpdateDataState;
            m_us_dm_bac_sy = ip_m_us_dm_bac_sy;
            m_us_obj_to_form();
            this.ShowDialog();
        }
        #endregion

        #region Members
        US_DM_BAC_SY m_us_dm_bac_sy = new US_DM_BAC_SY();
        DS_DM_BAC_SY m_ds_dm_bac_sy = new DS_DM_BAC_SY();
        DataEntryFormMode m_e = new DataEntryFormMode();
        #endregion

        #region Private method
        private void m_us_obj_to_form()
        {
            m_txt_ho_ten.Text = m_us_dm_bac_sy.strHO_TEN;
            m_txt_dia_chi.Text = m_us_dm_bac_sy.strDIA_CHI;
            m_txt_dien_thoai.Text = m_us_dm_bac_sy.strDIEN_THOAI;
        }
        private void Load_cbo_benh_vien()
        {

            US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_cm_dm_tu_dien.FillDatasetByIdLoaiTuDien(v_ds_cm_dm_tu_dien,2);
            m_cbo_benh_vien.DataSource = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN;
            m_cbo_benh_vien.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_benh_vien.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
        }
        private void m_form_to_us_obj()
        {
            m_us_dm_bac_sy.strHO_TEN = m_txt_ho_ten.Text;
            m_us_dm_bac_sy.strDIA_CHI = m_txt_dia_chi.Text;
            m_us_dm_bac_sy.strDIEN_THOAI = m_txt_dien_thoai.Text;
            m_us_dm_bac_sy.dcBENH_VIEN = Convert.ToDecimal(m_cbo_benh_vien.SelectedValue);
        }
        #endregion

        #region Event
   
        private void m_cmd_cap_nhat_Click(object sender, EventArgs e)
        {
            m_form_to_us_obj();
            switch (m_e)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_bac_sy.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_bac_sy.Update();
                    break;
                default: m_us_dm_bac_sy.Insert();
                    break;
            }
            this.Close();
        }
        private void m_cmd_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
