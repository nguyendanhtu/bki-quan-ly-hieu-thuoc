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
using IP.Core.IPSystemAdmin;

namespace BKI_QLHT
{
    public partial class f802_v_gd_gia_DE : Form
    {
        public f802_v_gd_gia_DE()
        {
            InitializeComponent();
            format_controls();
            load_2_m_cbo_don_vi_tinh();
            load_2_m_cbo_don_vi_gia();
            load_2_m_cbo_trang_thai();
            load_2_m_cbo_ten_thuoc();
        }

        
        #region public interfaces
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_GD_GIA m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_v_dm_gia = m_us;
            us_obj_2_form();
            this.ShowDialog();
        }
        #endregion


        #region members
        DataEntryFormMode m_e_form_mode;
        US_GD_GIA m_us_v_dm_gia = new US_GD_GIA();
        #endregion

        #region private methods
        private void format_controls()
        {
            //CControlFormat.setFormStyle(this);
            CControlFormat.setFormStyle(this, new CAppContext_201());
            //CControlFormat.setC1FlexFormat(m_grv_gd_gia);
            //set_define_events();
            //this.KeyPreview = true;
        }
        private void form_2_us_obj()
        {
            m_us_v_dm_gia.dcID_THUOC =CIPConvert.ToDecimal(m_cbo_ten_thuoc.SelectedValue);
            m_us_v_dm_gia.dcGIA =decimal.Parse( m_txt_gia.Text);
            m_us_v_dm_gia.datNGAY_AP_DUNG = m_dat_ngay_ap_dung.Value;
            m_us_v_dm_gia.dcID_DON_VI_TINH= CIPConvert.ToDecimal(m_cbo_don_vi_tinh.SelectedValue);
            m_us_v_dm_gia.dcID_DON_VI_GIA = CIPConvert.ToDecimal(m_cbo_don_vi_gia.SelectedValue);
            m_us_v_dm_gia.dcID_TRANG_THAI = CIPConvert.ToDecimal(m_cbo_trang_thai.SelectedValue);
        }
    private void us_obj_2_form()
    {
        m_cbo_ten_thuoc.SelectedValue = m_us_v_dm_gia.dcID_THUOC;
        m_txt_gia.Text = m_us_v_dm_gia.dcGIA.ToString();
        m_dat_ngay_ap_dung.Value = m_us_v_dm_gia.datNGAY_AP_DUNG;
        m_cbo_don_vi_tinh.SelectedValue = m_us_v_dm_gia.dcID_DON_VI_TINH;
        m_cbo_don_vi_gia.SelectedValue = m_us_v_dm_gia.dcID_DON_VI_GIA;
        m_cbo_trang_thai.SelectedValue = m_us_v_dm_gia.dcID_TRANG_THAI;
    }
    private void load_2_m_cbo_don_vi_tinh()
    {
        DS_GD_DON_VI_TINH_THUOC v_ds = new DS_GD_DON_VI_TINH_THUOC();
        US_GD_DON_VI_TINH_THUOC v_us = new US_GD_DON_VI_TINH_THUOC();
        //v_us.FillDatasetbyIdLoaiDonVi(v_ds,14);
        m_cbo_don_vi_tinh.DataSource = v_ds.Tables[0];
        m_cbo_don_vi_tinh.ValueMember = GD_DON_VI_TINH_THUOC.ID;
        m_cbo_don_vi_tinh.DisplayMember = GD_DON_VI_TINH_THUOC.TEN_DON_VI;
    }
    private void load_2_m_cbo_don_vi_gia()
    {
        DS_GD_DON_VI_TINH_THUOC v_ds = new DS_GD_DON_VI_TINH_THUOC();
        US_GD_DON_VI_TINH_THUOC v_us = new US_GD_DON_VI_TINH_THUOC();
       // v_us.FillDatasetbyIdLoaiDonVi(v_ds, 13);
        m_cbo_don_vi_gia.DataSource = v_ds.Tables[0];
        m_cbo_don_vi_gia.ValueMember = GD_DON_VI_TINH_THUOC.ID;
        m_cbo_don_vi_gia.DisplayMember = GD_DON_VI_TINH_THUOC.TEN_DON_VI;
    }
    private void load_2_m_cbo_trang_thai()
    {
        US_CM_DM_TU_DIEN v_us_cm_dm_tu_dien = new US_CM_DM_TU_DIEN();
        DS_CM_DM_TU_DIEN v_ds_cm_dm_tu_dien = new DS_CM_DM_TU_DIEN();
        v_us_cm_dm_tu_dien.FillDatasetByIdLoaiTuDien(v_ds_cm_dm_tu_dien, 5);
        m_cbo_trang_thai.DataSource = v_ds_cm_dm_tu_dien.CM_DM_TU_DIEN;
        m_cbo_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
        m_cbo_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
    }
    private void load_2_m_cbo_ten_thuoc()
    {
        US_DM_THUOC v_us_thuoc = new US_DM_THUOC();
        DS_DM_THUOC v_ds_thuoc = new DS_DM_THUOC();
        v_us_thuoc.FillDataset(v_ds_thuoc);
        m_cbo_ten_thuoc.DataSource = v_ds_thuoc.DM_THUOC;
        m_cbo_ten_thuoc.ValueMember = DM_THUOC.ID;
        m_cbo_ten_thuoc.DisplayMember = DM_THUOC.TEN_THUOC;
    }
        #endregion

    private void m_cmd_save_Click(object sender, EventArgs e)
    {
        form_2_us_obj();
        switch (m_e_form_mode)
        {
            case DataEntryFormMode.InsertDataState:
                m_us_v_dm_gia.Insert();
                this.Close();
                break;
            case DataEntryFormMode.SelectDataState:
                break;
            case DataEntryFormMode.UpdateDataState:
                m_us_v_dm_gia.Update();
                this.Close();
                break;
            case DataEntryFormMode.ViewDataState:
                break;
            default:
                break;
        }
    }

        #region events
        #endregion

    
    }
}
