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
using IP.Core.IPSystemAdmin;

using BKI_QLHT.US;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;
using BKI_QLHT.DanhMuc;

using C1.Win.C1FlexGrid;

namespace BKI_QLHT
{
    public partial class uc_102_dm_don_vi_tinh : UserControl
    {
        public uc_102_dm_don_vi_tinh()
        {
            InitializeComponent();
        }
        #region Public Interface
        public void display()
        {
            this.Show();
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            ID_NGUOI_SU_DUNG = 9
,
            ID_NGUOI_LAP = 6
                ,
            MA_NHOM = 2
                ,
            TRANG_THAI = 4
                ,
            TEN_NHOM = 1
                ,
            NGAY_LAP = 5
                ,
            ID_TRANG_THAI = 7
                ,
            ID_LOAI_TU_DIEN = 8
                ,
            TEN = 3
                , ID_TU_DIEN = 10

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_DON_VI_TINH m_ds_v_dm_don_vi_tinh = new DS_V_DM_DON_VI_TINH();
        US_V_DM_DON_VI_TINH m_us_v_dm_don_vi_tinh = new US_V_DM_DON_VI_TINH();
        US_DM_DON_VI_TINH m_us_dm_don_vi_tinh = new US_DM_DON_VI_TINH();
        DS_DM_DON_VI_TINH m_ds_dm_don_vi_tinh = new DS_DM_DON_VI_TINH();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            //CControlFormat.setFormStyle(this);
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            set_define_events();
            //this.KeyPreview = true;
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
        }

        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_DON_VI_TINH.ID_NGUOI_SU_DUNG, e_col_Number.ID_NGUOI_SU_DUNG);
            v_htb.Add(V_DM_DON_VI_TINH.ID_NGUOI_LAP, e_col_Number.ID_NGUOI_LAP);
            v_htb.Add(V_DM_DON_VI_TINH.MA_NHOM, e_col_Number.MA_NHOM);
            v_htb.Add(V_DM_DON_VI_TINH.TRANG_THAI, e_col_Number.TRANG_THAI);
            v_htb.Add(V_DM_DON_VI_TINH.TEN_NHOM, e_col_Number.TEN_NHOM);
            v_htb.Add(V_DM_DON_VI_TINH.NGAY_LAP, e_col_Number.NGAY_LAP);
            v_htb.Add(V_DM_DON_VI_TINH.ID_TRANG_THAI, e_col_Number.ID_TRANG_THAI);
            v_htb.Add(V_DM_DON_VI_TINH.ID_LOAI_TU_DIEN, e_col_Number.ID_LOAI_TU_DIEN);
            v_htb.Add(V_DM_DON_VI_TINH.TEN, e_col_Number.TEN);
            v_htb.Add(V_DM_DON_VI_TINH.ID_TU_DIEN, e_col_Number.ID_TU_DIEN);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_v_dm_don_vi_tinh.V_DM_DON_VI_TINH.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds_v_dm_don_vi_tinh = new DS_V_DM_DON_VI_TINH();
            m_us_v_dm_don_vi_tinh.FillDataset(m_ds_v_dm_don_vi_tinh);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_v_dm_don_vi_tinh, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_DM_DON_VI_TINH i_us
        , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
        private void v_grid2us_object(US_V_DM_DON_VI_TINH i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_DM_DON_VI_TINH i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }
        private void load_data_2_cbo_trang_thai()
        {
            US_CM_DM_TU_DIEN v_us_dm_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_dm_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_dm_tu_dien.FillDatasetByIdLoaiTuDien(v_ds_dm_tu_dien, 3);
            DataRow v_dr = v_ds_dm_tu_dien.CM_DM_TU_DIEN.NewRow();
            v_dr[CM_DM_TU_DIEN.ID] = -1;
            v_dr[CM_DM_TU_DIEN.TEN] = "------------Tất cả------------";
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "";
            v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = "3";
            v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "";
            v_ds_dm_tu_dien.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
            m_cbo_tim_kiem_trang_thai.DataSource = v_ds_dm_tu_dien.CM_DM_TU_DIEN;
            m_cbo_tim_kiem_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_tim_kiem_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_tim_kiem_trang_thai.SelectedIndex = 0;
        }

        private void load_data_2_cbo_nguoi_lap()
        {
            IP.Core.IPUserService.US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_su_dung = new IP.Core.IPUserService.US_HT_NGUOI_SU_DUNG();
            DS_HT_NGUOI_SU_DUNG v_ds_ht_nguoi_su_dung = new DS_HT_NGUOI_SU_DUNG();
            v_us_ht_nguoi_su_dung.FillDataset(v_ds_ht_nguoi_su_dung);
            DataRow v_dr = v_ds_ht_nguoi_su_dung.HT_NGUOI_SU_DUNG.NewRow();
            v_dr[HT_NGUOI_SU_DUNG.ID] = -1;
            v_dr[HT_NGUOI_SU_DUNG.TEN] = "------------Tất cả------------";
            v_dr[HT_NGUOI_SU_DUNG.MAT_KHAU] = "";
            v_dr[HT_NGUOI_SU_DUNG.NGAY_TAO] = "01-01-2001";
            v_dr[HT_NGUOI_SU_DUNG.TEN_TRUY_CAP] = "";
            v_dr[HT_NGUOI_SU_DUNG.TRANG_THAI] = "";
            v_ds_ht_nguoi_su_dung.HT_NGUOI_SU_DUNG.Rows.InsertAt(v_dr, 0);
            m_cbo_tim_kiem_nguoi_lap.DataSource = v_ds_ht_nguoi_su_dung.HT_NGUOI_SU_DUNG;
            m_cbo_tim_kiem_nguoi_lap.ValueMember = IP.Core.IPData.DBNames.HT_NGUOI_SU_DUNG.ID;
            m_cbo_tim_kiem_nguoi_lap.DisplayMember = IP.Core.IPData.DBNames.HT_NGUOI_SU_DUNG.TEN;
            m_cbo_tim_kiem_nguoi_lap.SelectedIndex = 0;
        }
        private void load_data_thong_tin_chi_tiet()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            v_grid2us_object(m_us_v_dm_don_vi_tinh, m_fg.Row);
            m_lbl_ten_nhom.Text = m_us_v_dm_don_vi_tinh.strTEN_NHOM;
            m_lbl_ma_nhom.Text = m_us_v_dm_don_vi_tinh.strMA_NHOM;
            m_lbl_nguoi_lap.Text = m_us_v_dm_don_vi_tinh.strTEN;
            m_lbl_trang_thai.Text = m_us_v_dm_don_vi_tinh.strTRANG_THAI;
            m_lbl_ngay_lap.Text = Convert.ToString(m_us_v_dm_don_vi_tinh.datNGAY_LAP.Date);
        }

        private void insert_dm_don_vi_tinh()
        {
            f102_v_dm_don_vi_tinh_de v_fDE = new f102_v_dm_don_vi_tinh_de();
            v_fDE.display_for_insert();
            load_data_2_grid();
        }

        private void update_dm_don_vi_tinh()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            //m_us_dm_don_vi_tinh.dcID = m_us_v_dm_don_vi_tinh.dcID;
            grid2us_object(m_us_dm_don_vi_tinh, m_fg.Row);
            f102_v_dm_don_vi_tinh_de v_fDE = new f102_v_dm_don_vi_tinh_de();
            v_fDE.display_for_update(m_us_dm_don_vi_tinh);
            load_data_2_grid();
        }

        private void delete_v_dm_don_vi_tinh()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_DM_DON_VI_TINH v_us = new US_DM_DON_VI_TINH();
            grid2us_object(v_us, m_fg.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_dm_don_vi_tinh()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            v_grid2us_object(m_us_v_dm_don_vi_tinh, m_fg.Row);
            //	f102_V_DM_DON_VI_TINH_DE v_fDE = new f102_V_DM_DON_VI_TINH_DE();			
            //	v_fDE.display(m_us);
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            //m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
        }

        private void tim_kiem()
        {
            string v_str_tu_khoa = m_txt_tim_kiem.Text.Trim();
            decimal v_dc_id_trang_thai = Convert.ToDecimal(m_cbo_tim_kiem_trang_thai.SelectedValue);
            decimal v_dc_id_nguoi_su_dung = Convert.ToDecimal(m_cbo_tim_kiem_nguoi_lap.SelectedValue);
            US_V_DM_DON_VI_TINH v_us_v_dm_don_vi_tinh = new US_V_DM_DON_VI_TINH();
            DS_V_DM_DON_VI_TINH v_ds_v_dm_don_vi_tinh = new DS_V_DM_DON_VI_TINH();
            v_us_v_dm_don_vi_tinh.FillDatasetSearch(v_ds_v_dm_don_vi_tinh, v_str_tu_khoa, v_dc_id_trang_thai, v_dc_id_nguoi_su_dung);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_v_dm_don_vi_tinh, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        private void f102_V_DM_DON_VI_TINH_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
                load_data_2_cbo_nguoi_lap();
                load_data_2_cbo_trang_thai();
                load_data_thong_tin_chi_tiet();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Controls.Clear();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_dm_don_vi_tinh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                update_dm_don_vi_tinh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_v_dm_don_vi_tinh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                view_v_dm_don_vi_tinh();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_fg_Click(object sender, EventArgs e)
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            v_grid2us_object(m_us_v_dm_don_vi_tinh, m_fg.Row);
            m_lbl_ten_nhom.Text = m_us_v_dm_don_vi_tinh.strTEN_NHOM;
            m_lbl_ma_nhom.Text = m_us_v_dm_don_vi_tinh.strMA_NHOM;
            m_lbl_nguoi_lap.Text = m_us_v_dm_don_vi_tinh.strTEN;
            m_lbl_trang_thai.Text = m_us_v_dm_don_vi_tinh.strTRANG_THAI;
            m_lbl_ngay_lap.Text = Convert.ToString(m_us_v_dm_don_vi_tinh.datNGAY_LAP);
        }

        private void m_cmd_Tim_Kiem_Click(object sender, EventArgs e)
        {
            tim_kiem();
        }
    }
}
