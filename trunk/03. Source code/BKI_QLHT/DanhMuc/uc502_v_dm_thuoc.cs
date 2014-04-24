﻿using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using BKI_QLHT.US;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;

using C1.Win.C1FlexGrid;
using IP.Core.IPSystemAdmin;

namespace BKI_QLHT
{
    public partial class uc502_v_dm_thuoc : UserControl
    {
        public uc502_v_dm_thuoc()
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
            TUYEN_SU_DUNG_8 = 10
,
            TT_THUOC = 5
                ,
            THUOC_THAY_THE = 11
                ,
            TUYEN_SU_DUNG_7 = 9
                ,
            TUYEN_SU_DUNG_6 = 8
                ,
            TT_HOAT_CHAT = 4
                ,
            TUYEN_SU_DUNG_5 = 7
                ,
            TEN_NHOM = 2
                ,
            DUONG_DUNG_DANG_DUNG = 6
                ,
            TEN_THUOC = 1
                , TEN_DANH_MUC = 3

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_THUOC m_ds = new DS_V_DM_THUOC();
        US_V_DM_THUOC m_us = new US_V_DM_THUOC();
        US_DM_THUOC m_us_t = new US_DM_THUOC();
        DS_DM_THUOC m_ds_t = new DS_DM_THUOC();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            //CControlFormat.setFormStyle(this);
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            set_define_events();
            load_data_2_cbo_danh_muc();
            load_data_2_cbo_nhom_thuoc();

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
            v_htb.Add(V_DM_THUOC.TUYEN_SU_DUNG_8, e_col_Number.TUYEN_SU_DUNG_8);
            v_htb.Add(V_DM_THUOC.TT_THUOC, e_col_Number.TT_THUOC);
            v_htb.Add(V_DM_THUOC.THUOC_THAY_THE, e_col_Number.THUOC_THAY_THE);
            v_htb.Add(V_DM_THUOC.TUYEN_SU_DUNG_7, e_col_Number.TUYEN_SU_DUNG_7);
            v_htb.Add(V_DM_THUOC.TUYEN_SU_DUNG_6, e_col_Number.TUYEN_SU_DUNG_6);
            v_htb.Add(V_DM_THUOC.TT_HOAT_CHAT, e_col_Number.TT_HOAT_CHAT);
            v_htb.Add(V_DM_THUOC.TUYEN_SU_DUNG_5, e_col_Number.TUYEN_SU_DUNG_5);
            v_htb.Add(V_DM_THUOC.TEN_NHOM, e_col_Number.TEN_NHOM);
            v_htb.Add(V_DM_THUOC.DUONG_DUNG_DANG_DUNG, e_col_Number.DUONG_DUNG_DANG_DUNG);
            v_htb.Add(V_DM_THUOC.TEN_THUOC, e_col_Number.TEN_THUOC);
            v_htb.Add(V_DM_THUOC.TEN_DANH_MUC, e_col_Number.TEN_DANH_MUC);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds._V_DM_THUOC.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_DM_THUOC();
            m_us.FillDataset(m_ds);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_DM_THUOC i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_DM_THUOC i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_dm_thuoc()
        {
            f503_v_dm_thuoc_de v_fDE = new f503_v_dm_thuoc_de();
            v_fDE.display_for_insert();
            load_data_2_grid();
        }

        private void update_v_dm_thuoc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us_t, m_fg.Row);
            f503_v_dm_thuoc_de v_fDE = new f503_v_dm_thuoc_de();
            v_fDE.display_for_update(m_us_t);
            load_data_2_grid();
        }

        private void delete_v_dm_thuoc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_DM_THUOC v_us = new US_DM_THUOC();
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

        private void view_v_dm_thuoc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us_t, m_fg.Row);
            //	f502_v_dm_thuoc_DE v_fDE = new f502_v_dm_thuoc_DE();			
            //	v_fDE.display(m_us);
        }
        private void load_data_2_cbo_danh_muc()
        {
            US_DM_DANH_MUC_THUOC v_us_dm = new US_DM_DANH_MUC_THUOC();
            DS_DM_DANH_MUC_THUOC v_ds_dm = new DS_DM_DANH_MUC_THUOC();
            v_us_dm.FillDataset(v_ds_dm);


            m_cbo_danh_muc_tk.DataSource = v_ds_dm.DM_DANH_MUC_THUOC;
            m_cbo_danh_muc_tk.ValueMember = DM_DANH_MUC_THUOC.ID;
            m_cbo_danh_muc_tk.DisplayMember = DM_DANH_MUC_THUOC.TEN_DANH_MUC;
            DataRow v_dr = v_ds_dm.DM_DANH_MUC_THUOC.NewRow();
            v_dr[DM_DANH_MUC_THUOC.ID] = -1;
            v_dr[DM_DANH_MUC_THUOC.TEN_DANH_MUC] = "------------------------Tất cả----------------------";
            v_dr[DM_DANH_MUC_THUOC.GHI_CHU] = "";
            v_ds_dm.DM_DANH_MUC_THUOC.Rows.InsertAt(v_dr, 0);
            m_cbo_danh_muc_tk.SelectedIndex = 0;
        }
        private void load_data_2_cbo_nhom_thuoc()
        {
            US_DM_NHOM_THUOC v_us = new US_DM_NHOM_THUOC();
            DS_DM_NHOM_THUOC v_ds = new DS_DM_NHOM_THUOC();
            v_us.FillDataset(v_ds);
            m_cbo_nhom_thuoc_tk.DataSource = v_ds.DM_NHOM_THUOC;
            m_cbo_nhom_thuoc_tk.ValueMember = DM_NHOM_THUOC.ID;
            m_cbo_nhom_thuoc_tk.DisplayMember = DM_NHOM_THUOC.TEN_NHOM;
            DataRow v_dr = v_ds.DM_NHOM_THUOC.NewRow();
            v_dr[DM_NHOM_THUOC.ID] = -1;
            v_dr[DM_NHOM_THUOC.TEN_NHOM] = "------------------------Tất cả----------------------";
            v_dr[DM_NHOM_THUOC.ID_DANH_MUC_THUOC] = -1;
            v_dr[DM_NHOM_THUOC.GHI_CHU] = "";
            v_ds.DM_NHOM_THUOC.Rows.InsertAt(v_dr, 0);
            m_cbo_nhom_thuoc_tk.SelectedIndex = 0;

        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            this.Load += new System.EventHandler(this.uc502_v_dm_Load);
            //m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
        }

        #endregion
        private void uc502_v_dm_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (System.Exception v_e)
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
                insert_v_dm_thuoc();
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
                update_v_dm_thuoc();
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
                delete_v_dm_thuoc();
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
                view_v_dm_thuoc();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}