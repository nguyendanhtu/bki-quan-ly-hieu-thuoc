using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

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
    public partial class uc_f100_dm_bac_sy : UserControl
    {
        public uc_f100_dm_bac_sy()
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
            HO_TEN = 1
,
            BENH_VIEN = 5
                ,
            DIA_CHI = 3
                ,
            TEN_NGAN = 2
                ,
            ID_LOAI_TU_DIEN = 6
                , DIEN_THOAI = 4

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_BAC_SY m_ds_v_dm_bac_sy = new DS_V_DM_BAC_SY();
        US_V_DM_BAC_SY m_us_v_dm_bac_sy = new US_V_DM_BAC_SY();
        DS_DM_BAC_SY m_ds_dm_bac_sy = new DS_DM_BAC_SY();
        US_DM_BAC_SY m_us_dm_bac_sy = new US_DM_BAC_SY();
        bool m_trang_thai = false;
        #endregion

        #region Private Methods
        private void format_controls()
        {
            //CControlFormat.setFormStyle(this);
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            set_define_events();
            Load_cbo_benh_vien();
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
            v_htb.Add(V_DM_BAC_SY.HO_TEN, e_col_Number.HO_TEN);
            v_htb.Add(V_DM_BAC_SY.BENH_VIEN, e_col_Number.BENH_VIEN);
            v_htb.Add(V_DM_BAC_SY.DIA_CHI, e_col_Number.DIA_CHI);
            v_htb.Add(V_DM_BAC_SY.TEN_NGAN, e_col_Number.TEN_NGAN);
            v_htb.Add(V_DM_BAC_SY.ID_LOAI_TU_DIEN, e_col_Number.ID_LOAI_TU_DIEN);
            v_htb.Add(V_DM_BAC_SY.DIEN_THOAI, e_col_Number.DIEN_THOAI);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_v_dm_bac_sy.V_DM_BAC_SY.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds_v_dm_bac_sy = new DS_V_DM_BAC_SY();
            m_us_v_dm_bac_sy.FillDataset(m_ds_v_dm_bac_sy);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_v_dm_bac_sy, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_DM_BAC_SY i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
        private void v_grid2us_object(US_V_DM_BAC_SY i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_DM_BAC_SY i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_dm_bac_sy()
        {
            f100_v_dm_bac_sy_de v_frm_de = new f100_v_dm_bac_sy_de();
            v_frm_de.display_for_insert();
            load_data_2_grid();
        }
        private void update_dm_bac_sy()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            v_grid2us_object(m_us_v_dm_bac_sy, m_fg.Row);
            grid2us_object(m_us_dm_bac_sy, m_fg.Row);
            f100_v_dm_bac_sy_de v_frm_de = new f100_v_dm_bac_sy_de();
            v_frm_de.display_for_update(m_us_dm_bac_sy);
            load_data_2_grid();
        }

        private void delete_dm_bac_sy()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_DM_BAC_SY v_us = new US_DM_BAC_SY();
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

        private void view_v_dm_bac_sy()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us_dm_bac_sy, m_fg.Row);
            //	f100_V_DM_BAC_SY_DE v_fDE = new f100_V_DM_BAC_SY_DE();			
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
        private void load_thong_tin_chi_tiet()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            v_grid2us_object(m_us_v_dm_bac_sy, m_fg.Row);
            m_lbl_ho_ten.Text = m_us_v_dm_bac_sy.strHO_TEN;
            m_lbl_dia_chi.Text = m_us_v_dm_bac_sy.strDIA_CHI;
            m_lbl_benh_vien.Text = m_us_v_dm_bac_sy.strTEN_NGAN;
            m_lbl_dien_thoai.Text = m_us_v_dm_bac_sy.strDIEN_THOAI;
        }
        private void Load_cbo_benh_vien()
        {

            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 2);
            m_cbo_tk_bac_sy.DataSource = v_ds.CM_DM_TU_DIEN;
            m_cbo_tk_bac_sy.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_tk_bac_sy.DisplayMember = CM_DM_TU_DIEN.TEN;
            DataRow v_dr = v_ds.CM_DM_TU_DIEN.NewRow();
            v_dr[CM_DM_TU_DIEN.ID] = -1;
            v_dr[CM_DM_TU_DIEN.TEN] = "----------------Tất cả----------------";
            v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "";
            v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = "2";
            v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "";
            v_ds.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
            m_cbo_tk_bac_sy.SelectedIndex = 0;
            m_trang_thai = true;
        }
        #endregion

        #region Event
        private void uc_f100_V_DM_BAC_SY_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
                load_thong_tin_chi_tiet();
                this.Focus();
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
                insert_dm_bac_sy();
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
                update_dm_bac_sy();
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
                delete_dm_bac_sy();
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
                view_v_dm_bac_sy();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_Tim_Kiem_Click(object sender, EventArgs e)
        {
            string v_str_tu_khoa = m_txt_tim_kiem.Text.Trim();
            decimal v_dc_benh_vien = CIPConvert.ToDecimal(m_cbo_tk_bac_sy.SelectedValue);
            US_V_DM_BAC_SY v_us_v_dm_bac_sy = new US_V_DM_BAC_SY();
            DS_V_DM_BAC_SY v_ds_v_dm_bac_sy = new DS_V_DM_BAC_SY();
            v_us_v_dm_bac_sy.FillDatasetSearch(v_ds_v_dm_bac_sy, v_str_tu_khoa, v_dc_benh_vien);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_v_dm_bac_sy, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }

        private void m_fg_Click(object sender, EventArgs e)
        {

            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            v_grid2us_object(m_us_v_dm_bac_sy, m_fg.Row);
            m_lbl_ho_ten.Text = m_us_v_dm_bac_sy.strHO_TEN;
            m_lbl_dia_chi.Text = m_us_v_dm_bac_sy.strDIA_CHI;
            m_lbl_benh_vien.Text = m_us_v_dm_bac_sy.strTEN_NGAN;
            m_lbl_dien_thoai.Text = m_us_v_dm_bac_sy.strDIEN_THOAI;
        }
        private void m_txt_tim_kiem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {

                    string v_str_tu_khoa = m_txt_tim_kiem.Text.Trim();
                    decimal v_dc_benh_vien = CIPConvert.ToDecimal(m_cbo_tk_bac_sy.SelectedValue);
                    US_V_DM_BAC_SY v_us_v_dm_bac_sy = new US_V_DM_BAC_SY();
                    DS_V_DM_BAC_SY v_ds_v_dm_bac_sy = new DS_V_DM_BAC_SY();
                    v_us_v_dm_bac_sy.FillDatasetSearch(v_ds_v_dm_bac_sy, v_str_tu_khoa, v_dc_benh_vien);
                    m_fg.Redraw = false;
                    CGridUtils.Dataset2C1Grid(v_ds_v_dm_bac_sy, m_fg, m_obj_trans);
                    m_fg.Redraw = true;
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }


        #endregion

        private void uc_f100_dm_bac_sy_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyData)
                {
                    case Keys.F3:
                        insert_dm_bac_sy();
                        break;

                    case Keys.F4:
                        update_dm_bac_sy();
                        break;

                    case Keys.F6:
                        delete_dm_bac_sy();
                        break;

                    case Keys.Escape:
                        this.Controls.Clear();
                        break;

                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cbo_tk_bac_sy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_trang_thai == true)
            {
                string v_str_tu_khoa = m_txt_tim_kiem.Text;
                decimal v_dc_benh_vien = CIPConvert.ToDecimal(m_cbo_tk_bac_sy.SelectedValue);
                US_V_DM_BAC_SY v_us_v_dm_bac_sy = new US_V_DM_BAC_SY();
                DS_V_DM_BAC_SY v_ds_v_dm_bac_sy = new DS_V_DM_BAC_SY();
                v_us_v_dm_bac_sy.FillDatasetSearch(v_ds_v_dm_bac_sy, v_str_tu_khoa, v_dc_benh_vien);
                m_fg.Redraw = false;
                CGridUtils.Dataset2C1Grid(v_ds_v_dm_bac_sy, m_fg, m_obj_trans);
                m_fg.Redraw = true;
            }
        }

       
    }
}
