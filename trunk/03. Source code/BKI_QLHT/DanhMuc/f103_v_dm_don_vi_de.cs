using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPData;
using IP.Core.IPUserService;

using BKI_QLHT.US;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;


namespace BKI_QLHT.DanhMuc
{
    public partial class f103_v_dm_don_vi_de : Form
    {
        #region public interface
        public f103_v_dm_don_vi_de()
        {
            InitializeComponent();
            load_data_2_cbo_loai_don_vi();
            load_data_2_cbo_ma_dv_cap_tren();
        }

        public void display_for_insert()
        {
            m_e = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US_DM_DON_VI ip_us_dm_don_vi)
        {
            m_e = DataEntryFormMode.UpdateDataState;
            ip_us_dm_don_vi = m_us_dm_don_vi;
            m_us_obj_2_form();
            this.ShowDialog();
        }
        #endregion

        #region Members
        US_DM_DON_VI m_us_dm_don_vi = new US_DM_DON_VI();
        DS_DM_DON_VI m_ds_dm_don_vi = new DS_DM_DON_VI();
        US_V_DM_DON_VI m_us_v_dm_don_vi = new US_V_DM_DON_VI();
        DataEntryFormMode m_e = new DataEntryFormMode();
        #endregion

        #region Private method
        private void f103_v_dm_don_vi_de_Load(object sender, EventArgs e)
        {

        }
        
        private void m_form_2_us_obj()
        {
            m_us_dm_don_vi.strMA_VIET_TAT = m_txt_ma_viet_tat.Text;
            m_us_dm_don_vi.strTEN_DAY_DU = m_txt_ten_day_du.Text;
            m_us_dm_don_vi.strMA_SO_THUE = m_txt_ma_so_thue.Text;
            m_us_dm_don_vi.strDIA_CHI = m_txt_dia_chi.Text;
            m_us_dm_don_vi.strGHI_CHU_1 = m_txt_ghi_chu1.Text;
            m_us_dm_don_vi.strGHI_CHU_2 = m_txt_ghi_chu2.Text;
            m_us_dm_don_vi.strGHI_CHU_3 = m_txt_ghi_chu3.Text;
            m_us_dm_don_vi.dcID_LOAI_DON_VI = Convert.ToDecimal(m_cbo_loai_don_vi.SelectedValue);
            m_us_dm_don_vi.dcID_DON_VI_CAP_TREN = Convert.ToDecimal(m_cbo_ma_dv_cap_tren.SelectedValue);
        }


        private void m_us_obj_2_form()
        {
            m_us_v_dm_don_vi.dcID = m_us_dm_don_vi.dcID;
            m_txt_ma_viet_tat.Text = m_us_dm_don_vi.strMA_VIET_TAT;
            m_txt_ten_day_du.Text = m_us_dm_don_vi.strTEN_DAY_DU;
            m_txt_dia_chi.Text = m_us_dm_don_vi.strDIA_CHI;
            m_txt_ghi_chu1.Text = m_us_dm_don_vi.strGHI_CHU_1;
            m_txt_ghi_chu2.Text = m_us_dm_don_vi.strGHI_CHU_2;
            m_txt_ghi_chu3.Text = m_us_dm_don_vi.strGHI_CHU_3;
            m_cbo_loai_don_vi.Text = m_us_v_dm_don_vi.strTEN;
            m_cbo_ma_dv_cap_tren.Text = m_us_v_dm_don_vi.strMA_VIET_TAT_DV_CAP_TREN;
            m_txt_ma_so_thue.Text = m_us_dm_don_vi.strMA_SO_THUE;
        }
        private void load_data_2_cbo_ma_dv_cap_tren()
        {
            US_DM_DON_VI v_us = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds = new DS_DM_DON_VI();
            v_us.FillDataset(v_ds);
            m_cbo_ma_dv_cap_tren.DataSource = v_ds.DM_DON_VI;
            m_cbo_ma_dv_cap_tren.ValueMember = DM_DON_VI.ID_DON_VI_CAP_TREN;
            m_cbo_ma_dv_cap_tren.DisplayMember = DM_DON_VI.MA_VIET_TAT;
        }

        private void load_data_2_cbo_loai_don_vi()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 4);
            m_cbo_loai_don_vi.DataSource = v_ds.CM_DM_TU_DIEN;
            m_cbo_loai_don_vi.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_loai_don_vi.DisplayMember = CM_DM_TU_DIEN.TEN;
        }
        #endregion

        #region Event

        private void m_cmd_cap_nhat_Click(object sender, EventArgs e)
        {
            m_form_2_us_obj();
            try
            {
                switch (m_e)
                { 
                    case DataEntryFormMode.InsertDataState:
                        m_us_dm_don_vi.Insert();
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        m_us_dm_don_vi.Update();
                        break;
                    default: m_us_dm_don_vi.Insert();
                        break;
                }
                this.Close();
            }
            catch(Exception v_e)
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
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            
        }

        #endregion
    }
}
