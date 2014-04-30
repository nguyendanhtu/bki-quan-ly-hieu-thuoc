using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using BKI_QLHT.DS;
using BKI_QLHT.US;
using BKI_QLHT.DS.CDBNames;

using C1.Win.C1FlexGrid;
using IP.Core.IPSystemAdmin;

namespace BKI_QLHT
{
    public partial  class f511_gd_nhap_thuoc : Form
    {
        public f511_gd_nhap_thuoc()
        {
            InitializeComponent();
            format_control();

        }

        
        #region Public Interface
        
        #endregion
        #region Member

        #endregion
        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            set_define_event();
            m_grv_nhap_thuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void set_define_event()
        {
            this.Load += new System.EventHandler(this.f511_gd_nhap_thuoc_Load);
            this.m_cbo_don_vi_tinh.SelectedIndexChanged += new System.EventHandler(this.m_cbo_don_vi_tinh_SelectedIndexChanged);
            this.m_cbo_dv_cap_2.SelectedIndexChanged += new System.EventHandler(this.m_cbo_dv_cap_2_SelectedIndexChanged);
            this.m_cbo_dv_cap_3.SelectedIndexChanged += new System.EventHandler(this.m_cbo_dv_cap_3_SelectedIndexChanged);
            this.m_cbo_dv_cap_4.SelectedIndexChanged += new System.EventHandler(this.m_cbo_dv_cap_4_SelectedIndexChanged);
        }
        public void set_inital_form_load() {
            load_data_2_cbo_ten_thuoc();
            load_data_2_cbo_don_vi_tinh();
            load_data_2_dv_cap_2();
            load_data_2_dv_cap_3();
            load_data_2_dv_cap_4();
            load_data_2_dv_cap_5();
            load_data_2_cbo_nha_cung_cap();
            load_data_2_cbo_nuoc_sx();
            load_data_2_cbo_hang_sx();
            load_data_2_label();
        }
        private void load_data_2_cbo_ten_thuoc(){
            US_DM_THUOC v_us_dm_thuoc = new US_DM_THUOC();
            DS_DM_THUOC v_ds_dm_thuoc = new DS_DM_THUOC();
            v_us_dm_thuoc.FillDataset(v_ds_dm_thuoc);
            m_cbo_ten_thuoc.DataSource = v_ds_dm_thuoc.DM_THUOC;
            m_cbo_ten_thuoc.ValueMember = DM_THUOC.ID;
            m_cbo_ten_thuoc.DisplayMember = DM_THUOC.TEN_THUOC;
        }
        private void load_data_2_cbo_don_vi_tinh() {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.FillDataset(v_ds_tu_dien, "where id_loai_tu_dien=8");
            m_cbo_don_vi_tinh.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_don_vi_tinh.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_don_vi_tinh.DisplayMember = CM_DM_TU_DIEN.TEN;
        }
        private void load_data_2_dv_cap_2() {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.FillDataset(v_ds_tu_dien, "where id_loai_tu_dien=8");
            m_cbo_dv_cap_2.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_dv_cap_2.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_dv_cap_2.DisplayMember = CM_DM_TU_DIEN.TEN;

        }
        private void load_data_2_dv_cap_3()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.FillDataset(v_ds_tu_dien, "where id_loai_tu_dien=8");
            m_cbo_dv_cap_4.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_dv_cap_4.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_dv_cap_4.DisplayMember = CM_DM_TU_DIEN.TEN;

        }
        private void load_data_2_dv_cap_4()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.FillDataset(v_ds_tu_dien, "where id_loai_tu_dien=8");
            m_cbo_dv_cap_3.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_dv_cap_3.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_dv_cap_3.DisplayMember = CM_DM_TU_DIEN.TEN;

        }
        private void load_data_2_dv_cap_5()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.FillDataset(v_ds_tu_dien, "where id_loai_tu_dien=8");
            m_cbo_dv_cap_5.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_dv_cap_5.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_dv_cap_5.DisplayMember = CM_DM_TU_DIEN.TEN;

        }
        private void load_data_2_cbo_nha_cung_cap() {
            US_DM_NCC_NSX_NHASX v_us = new US_DM_NCC_NSX_NHASX();
            DS_DM_NCC_NSX_NHASX v_ds = new DS_DM_NCC_NSX_NHASX();
            v_us.FillDataset(v_ds, "where id_loai_dm=1");
            m_cbo_nha_cung_cap.DataSource = v_ds.DM_NCC_NSX_NHASX;
            m_cbo_nha_cung_cap.ValueMember = DM_NCC_NSX_NHASX.ID;
            m_cbo_nha_cung_cap.DisplayMember = DM_NCC_NSX_NHASX.TEN_NCC;
        }
        private void load_data_2_cbo_hang_sx()
        {
            US_DM_NCC_NSX_NHASX v_us = new US_DM_NCC_NSX_NHASX();
            DS_DM_NCC_NSX_NHASX v_ds = new DS_DM_NCC_NSX_NHASX();
            v_us.FillDataset(v_ds, "where id_loai_dm=3");
            m_cbo_hang_san_xuat.DataSource = v_ds.DM_NCC_NSX_NHASX;
            m_cbo_hang_san_xuat.ValueMember = DM_NCC_NSX_NHASX.ID;
            m_cbo_hang_san_xuat.DisplayMember = DM_NCC_NSX_NHASX.TEN_NCC;
        }
        private void load_data_2_cbo_nuoc_sx()
        {
            US_DM_NCC_NSX_NHASX v_us = new US_DM_NCC_NSX_NHASX();
            DS_DM_NCC_NSX_NHASX v_ds = new DS_DM_NCC_NSX_NHASX();
            v_us.FillDataset(v_ds, "where id_loai_dm=2");
            m_cbo_nuoc_san_xuat.DataSource = v_ds.DM_NCC_NSX_NHASX;
            m_cbo_nuoc_san_xuat.ValueMember = DM_NCC_NSX_NHASX.ID;
            m_cbo_nuoc_san_xuat.DisplayMember = DM_NCC_NSX_NHASX.TEN_NCC;
        }
        private void load_data_2_label()
        {
            m_lbl_dv_tinh_nhap.Text ="1"+" "+ m_cbo_don_vi_tinh.Text;
            m_lbl_dv_tinh_ban.Text = "1" + " " + m_cbo_don_vi_tinh.Text;
            m_lbl_don_vi_cap_2.Text = "1" + " " + m_cbo_dv_cap_2.Text;
            m_lbl_don_vi_cap_3.Text = "1" + " " + m_cbo_dv_cap_4.Text;
            m_lbl_don_vi_cap_4.Text = "1" + " " + m_cbo_dv_cap_3.Text;
        }
        

        #endregion

        
        #region Event
        private void f511_gd_nhap_thuoc_Load(object sender, EventArgs e)
        {
            set_inital_form_load();
        }
        private void m_cbo_dv_cap_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_lbl_don_vi_cap_2.Text = "1" + " " + m_cbo_dv_cap_2.Text;
            m_cbo_dv_cap_3.Text = m_cbo_dv_cap_2.Text;
            m_cbo_dv_cap_4.Text = m_cbo_dv_cap_2.Text;
            m_cbo_dv_cap_5.Text = m_cbo_dv_cap_2.Text;

        }
        private void m_cbo_dv_cap_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_lbl_don_vi_cap_3.Text = "1" + " " + m_cbo_dv_cap_3.Text;
            m_cbo_dv_cap_4.Text = m_cbo_dv_cap_3.Text;
            m_cbo_dv_cap_5.Text = m_cbo_dv_cap_4.Text;
        }

        private void m_cbo_dv_cap_4_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_lbl_don_vi_cap_4.Text = "1" + " " + m_cbo_dv_cap_4.Text;
            m_cbo_dv_cap_5.Text = m_cbo_dv_cap_4.Text;
        }

        private void m_cbo_don_vi_tinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_lbl_dv_tinh_ban.Text = "1" + " " + m_cbo_don_vi_tinh.Text;
            m_lbl_dv_tinh_nhap.Text = "1" + " " + m_cbo_don_vi_tinh.Text;
        }
        #endregion

        

        
    }
}
