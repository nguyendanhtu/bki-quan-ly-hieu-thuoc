using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using IP.Core.IPData;

using BKI_QLHT.DS;
using BKI_QLHT.US;
using BKI_QLHT.DS.CDBNames;

namespace BKI_QLHT.DanhMuc
{
    public partial class f102_v_dm_don_vi_tinh_de : Form
    {
        #region Members
        US_DM_DON_VI_TINH m_us_dm_don_vi_tinh = new US_DM_DON_VI_TINH();
        DS_DM_DON_VI_TINH m_ds_dm_don_vi_tinh = new DS_DM_DON_VI_TINH();
        DataEntryFormMode m_e = new DataEntryFormMode();
        US_V_DM_DON_VI_TINH m_us_v_dm_don_vi_tinh = new US_V_DM_DON_VI_TINH();
        #endregion

        public f102_v_dm_don_vi_tinh_de()
        {
            InitializeComponent();
            load_data_2_cbo_nguoi_lap();
            load_data_2_cbo_trang_thai();
        }

        private void load_data_2_cbo_trang_thai()
        {
            US_CM_DM_TU_DIEN v_us_dm_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_dm_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_dm_tu_dien.FillDatasetByIdLoaiTuDien(v_ds_dm_tu_dien,3);
            m_cbo_trang_thai.DataSource = v_ds_dm_tu_dien.CM_DM_TU_DIEN;
            m_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
        }

        private void load_data_2_cbo_nguoi_lap()
        {
            BKI_QLHT.US.US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_su_dung = new BKI_QLHT.US.US_HT_NGUOI_SU_DUNG();
            DS_HT_NGUOI_SU_DUNG v_ds_ht_nguoi_su_dung = new DS_HT_NGUOI_SU_DUNG();
            v_us_ht_nguoi_su_dung.FillDataset(v_ds_ht_nguoi_su_dung);
            m_cbo_nguoi_lap.DataSource = v_ds_ht_nguoi_su_dung.HT_NGUOI_SU_DUNG;
            m_cbo_nguoi_lap.ValueMember = HT_NGUOI_SU_DUNG.ID;
            m_cbo_nguoi_lap.DisplayMember = HT_NGUOI_SU_DUNG.TEN;
        }

        private void m_cmd_cap_nhat_Click(object sender, EventArgs e)
        {
            m_form_2_us_obj();
            try 
            {
                switch (m_e)
                {
                    case DataEntryFormMode.InsertDataState:
                        m_us_dm_don_vi_tinh.Insert();
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        m_us_dm_don_vi_tinh.Update();
                        break;
                    default: m_us_dm_don_vi_tinh.Insert();
                        break;
                }
                this.Close();

            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_form_2_us_obj()
        {
            m_us_dm_don_vi_tinh.strTEN_NHOM = m_txt_ma_nhom.Text;
            m_us_dm_don_vi_tinh.strMA_NHOM = m_txt_ten_nhom.Text;
            m_us_dm_don_vi_tinh.dcID_NGUOI_LAP = Convert.ToDecimal(m_cbo_nguoi_lap.SelectedValue);
            m_us_dm_don_vi_tinh.dcID_TRANG_THAI = Convert.ToDecimal(m_cbo_trang_thai.SelectedValue);
            m_us_dm_don_vi_tinh.datNGAY_LAP = m_dt_ngay_lap.Value;
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

        public void display_for_insert()
        {
            m_e = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }

        public void display_for_update(US_DM_DON_VI_TINH ip_us_dm_don_vi_tinh)
        {
            m_e = DataEntryFormMode.UpdateDataState;
            m_us_dm_don_vi_tinh = ip_us_dm_don_vi_tinh;
            m_us_obj_2_form();
            this.ShowDialog();
        }

        private void m_us_obj_2_form()
        {
            m_txt_ma_nhom.Text = m_us_dm_don_vi_tinh.strMA_NHOM;
            m_txt_ten_nhom.Text = m_us_dm_don_vi_tinh.strTEN_NHOM;
            m_cbo_nguoi_lap.Text = m_us_v_dm_don_vi_tinh.strTEN;
            m_cbo_trang_thai.Text = m_us_v_dm_don_vi_tinh.strTRANG_THAI;
        }
    }
}
