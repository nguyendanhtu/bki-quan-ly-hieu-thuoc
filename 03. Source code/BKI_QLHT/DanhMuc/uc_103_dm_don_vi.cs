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

namespace BKI_QLHT.DanhMuc
{
    public partial class uc_103_dm_don_vi : UserControl
    {
        public uc_103_dm_don_vi()
        {
            InitializeComponent();
            format_controls();
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
            MA_SO_THUE = 3
,
            GHI_CHU_1 = 12
                ,
            ID = 15
                ,
            GHI_CHU_3 = 14
                ,
            ID_DV_CAP_TREN = 10
                ,
            GHI_CHU_2 = 13
                ,
            MA_VIET_TAT_DV_CAP_TREN = 11
                ,
            TEN_DAY_DU = 2
                ,
            MA_VIET_TAT = 1
                ,
            TEN = 9
                ,
            ID_LOAI_TU_DIEN = 8
                ,
            DIA_CHI = 4
                ,
            ID_DON_VI_CAP_TREN = 5
                ,
            ID_LOAI_DON_VI = 6
                , ID_TU_DIEN = 7

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_DON_VI m_ds_v_dm_don_vi = new DS_V_DM_DON_VI();
        US_V_DM_DON_VI m_us_v_dm_don_vi = new US_V_DM_DON_VI();
        US_DM_DON_VI m_us_dm_don_vi = new US_DM_DON_VI();
        DS_DM_DON_VI m_ds_dm_don_vi = new DS_DM_DON_VI();
        #endregion

        #region Private Methods
        private void format_controls()
        {
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
            v_htb.Add(V_DM_DON_VI.MA_SO_THUE, e_col_Number.MA_SO_THUE);
            v_htb.Add(V_DM_DON_VI.GHI_CHU_1, e_col_Number.GHI_CHU_1);
            v_htb.Add(V_DM_DON_VI.ID, e_col_Number.ID);
            v_htb.Add(V_DM_DON_VI.GHI_CHU_3, e_col_Number.GHI_CHU_3);
            v_htb.Add(V_DM_DON_VI.ID_DV_CAP_TREN, e_col_Number.ID_DV_CAP_TREN);
            v_htb.Add(V_DM_DON_VI.GHI_CHU_2, e_col_Number.GHI_CHU_2);
            v_htb.Add(V_DM_DON_VI.MA_VIET_TAT_DV_CAP_TREN, e_col_Number.MA_VIET_TAT_DV_CAP_TREN);
            v_htb.Add(V_DM_DON_VI.TEN_DAY_DU, e_col_Number.TEN_DAY_DU);
            v_htb.Add(V_DM_DON_VI.MA_VIET_TAT, e_col_Number.MA_VIET_TAT);
            v_htb.Add(V_DM_DON_VI.TEN, e_col_Number.TEN);
            v_htb.Add(V_DM_DON_VI.ID_LOAI_TU_DIEN, e_col_Number.ID_LOAI_TU_DIEN);
            v_htb.Add(V_DM_DON_VI.DIA_CHI, e_col_Number.DIA_CHI);
            v_htb.Add(V_DM_DON_VI.ID_DON_VI_CAP_TREN, e_col_Number.ID_DON_VI_CAP_TREN);
            v_htb.Add(V_DM_DON_VI.ID_LOAI_DON_VI, e_col_Number.ID_LOAI_DON_VI);
            v_htb.Add(V_DM_DON_VI.ID_TU_DIEN, e_col_Number.ID_TU_DIEN);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_v_dm_don_vi.V_DM_DON_VI.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds_v_dm_don_vi = new DS_V_DM_DON_VI();
            m_us_v_dm_don_vi.FillDataset(m_ds_v_dm_don_vi);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_v_dm_don_vi, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_DM_DON_VI i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
        private void v_grid2us_object(US_V_DM_DON_VI i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_DM_DON_VI i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }
        private void load_thong_tin_chi_tiet()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            v_grid2us_object(m_us_v_dm_don_vi, m_fg.Row);
            m_lbl_ma_viet_tat.Text = m_us_v_dm_don_vi.strMA_VIET_TAT;
            m_lbl_ten_day_du.Text = m_us_v_dm_don_vi.strTEN_DAY_DU;
            m_lbl_ma_so_thue.Text = m_us_v_dm_don_vi.strMA_SO_THUE;
            m_lbl_ma_dv_cap_tren.Text = m_us_v_dm_don_vi.strMA_VIET_TAT_DV_CAP_TREN;
            m_lbl_dia_chi.Text = m_us_v_dm_don_vi.strDIA_CHI;
            m_lbl_loai_don_vi.Text = m_us_v_dm_don_vi.strTEN;
            m_lbl_ghi_chu1.Text = m_us_v_dm_don_vi.strGHI_CHU_1;
            m_lbl_ghi_chu2.Text = m_us_v_dm_don_vi.strGHI_CHU_2;
            m_lbl_ghi_chu3.Text = m_us_v_dm_don_vi.strGHI_CHU_3;
        }

        private void load_data_2_cbo_tk_ma_dv_cap_tren()
        {
            US_DM_DON_VI v_us = new US_DM_DON_VI();
            DS_DM_DON_VI v_ds = new DS_DM_DON_VI();
            v_us.FillDataset(v_ds);
            m_cbo_tk_ma_dv_cap_tren.DataSource = v_ds.DM_DON_VI;
            m_cbo_tk_ma_dv_cap_tren.ValueMember = DM_DON_VI.ID_DON_VI_CAP_TREN;
            m_cbo_tk_ma_dv_cap_tren.DisplayMember = DM_DON_VI.MA_VIET_TAT;
            DataRow v_dr = v_ds.DM_DON_VI.NewRow();
            v_dr[DM_DON_VI.ID] = -1;
            v_dr[DM_DON_VI.MA_VIET_TAT] = "----------Tất cả-----------";
            v_dr[DM_DON_VI.ID_LOAI_DON_VI] = "-1";
            v_dr[DM_DON_VI.ID_DON_VI_CAP_TREN] = "-1";
            v_dr[DM_DON_VI.TEN_DAY_DU] = "";
            v_dr[DM_DON_VI.MA_SO_THUE] = "";
            v_dr[DM_DON_VI.DIA_CHI] = "";
            v_ds.DM_DON_VI.Rows.InsertAt(v_dr, 0);
            m_cbo_tk_ma_dv_cap_tren.SelectedIndex = 0;
        }

        private void load_data_2_cbo_tk_loai_don_vi()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 4);
            m_cbo_tk_loai_don_vi.DataSource = v_ds.CM_DM_TU_DIEN;
            m_cbo_tk_loai_don_vi.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_tk_loai_don_vi.DisplayMember = CM_DM_TU_DIEN.TEN;
            DataRow v_dr = v_ds.CM_DM_TU_DIEN.NewRow();
            v_dr[CM_DM_TU_DIEN.ID] = -1;
            v_dr[CM_DM_TU_DIEN.TEN] = "--------------Tất cả--------------";
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "";
            v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = "4";
            v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "";
            v_ds.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
            m_cbo_tk_loai_don_vi.SelectedIndex = 0;
        }


        private void insert_v_dm_don_vi()
        {
            f103_v_dm_don_vi_de v_fDE = new f103_v_dm_don_vi_de();
            v_fDE.display_for_insert();
            load_data_2_grid();
        }

        private void update_v_dm_don_vi()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us_dm_don_vi, m_fg.Row);
            f103_v_dm_don_vi_de v_fDE = new f103_v_dm_don_vi_de();
            v_fDE.display_for_update(m_us_dm_don_vi);
            load_data_2_grid();
        }

        private void delete_v_dm_don_vi()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_DM_DON_VI v_us = new US_DM_DON_VI();
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

        private void view_v_dm_don_vi()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us_dm_don_vi, m_fg.Row);
            //	f103_V_DM_DON_VI_DE v_fDE = new f103_V_DM_DON_VI_DE();			
            //	v_fDE.display(m_us);
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
          
        }
        #endregion

        #region Event
        private void uc_103_V_DM_DON_VI_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
                load_data_2_cbo_tk_loai_don_vi();
                load_data_2_cbo_tk_ma_dv_cap_tren();
                load_thong_tin_chi_tiet();
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
                insert_v_dm_don_vi();
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
                update_v_dm_don_vi();
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
                delete_v_dm_don_vi();
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
                view_v_dm_don_vi();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_fg_Click(object sender, EventArgs e)
        {
            load_thong_tin_chi_tiet();
        }

        private void m_cmd_tim_kiem_Click(object sender, EventArgs e)
        {
            string v_tu_khoa = m_txt_tim_kiem.Text.Trim();
            decimal v_ip_cbo_loai_don_vi = Convert.ToDecimal(m_cbo_tk_loai_don_vi.SelectedValue);
            decimal v_ip_cbo_ma_dv_cap_tren = Convert.ToDecimal(m_cbo_tk_ma_dv_cap_tren.SelectedValue);
            US_V_DM_DON_VI v_us_v_dm_don_vi = new US_V_DM_DON_VI();
            DS_V_DM_DON_VI v_ds_v_dm_don_vi = new DS_V_DM_DON_VI();
            v_us_v_dm_don_vi.FillDatasetSearch(v_ds_v_dm_don_vi, v_tu_khoa, v_ip_cbo_loai_don_vi, v_ip_cbo_ma_dv_cap_tren);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_v_dm_don_vi, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        #endregion
    }

}
