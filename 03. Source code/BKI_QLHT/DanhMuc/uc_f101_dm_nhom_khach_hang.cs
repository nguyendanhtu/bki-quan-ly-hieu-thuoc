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

using BKI_QLHT;
using BKI_QLHT.DanhMuc;
using BKI_QLHT.DS;
using BKI_QLHT.US;
using BKI_QLHT.DS.CDBNames;

using C1.Win.C1FlexGrid;

namespace BKI_QLHT.DanhMuc
{
    public partial class uc_f101_dm_nhom_khach_hang : UserControl
    {
        public uc_f101_dm_nhom_khach_hang()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface
        public void display()
        {
            
        }
        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            TEN_NHOM = 3
,
            ID = 1
                , MA_NHOM = 2

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_DM_NHOM_KHACH_HANG m_ds_dm_nhom_khach_hang = new DS_DM_NHOM_KHACH_HANG();
        US_DM_NHOM_KHACH_HANG m_us_dm_nhom_khach_hang = new US_DM_NHOM_KHACH_HANG();
        #endregion

        #region Private Methods
        private void format_controls()
        {
        //    CControlFormat.setFormStyle(this);
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
            v_htb.Add(DM_NHOM_KHACH_HANG.TEN_NHOM, e_col_Number.TEN_NHOM);
            v_htb.Add(DM_NHOM_KHACH_HANG.ID, e_col_Number.ID);
            v_htb.Add(DM_NHOM_KHACH_HANG.MA_NHOM, e_col_Number.MA_NHOM);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_dm_nhom_khach_hang.DM_NHOM_KHACH_HANG.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds_dm_nhom_khach_hang = new DS_DM_NHOM_KHACH_HANG();
            m_us_dm_nhom_khach_hang.FillDataset(m_ds_dm_nhom_khach_hang);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_dm_nhom_khach_hang, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_DM_NHOM_KHACH_HANG i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_DM_NHOM_KHACH_HANG i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_dm_nhom_khach_hang()
        {
            f101_dm_nhom_khach_hang_de v_fDE = new f101_dm_nhom_khach_hang_de();
            v_fDE.display_for_insert();
            load_data_2_grid();
        }

        private void update_dm_nhom_khach_hang()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us_dm_nhom_khach_hang, m_fg.Row);
            f101_dm_nhom_khach_hang_de v_fDE = new f101_dm_nhom_khach_hang_de();
            v_fDE.display_for_update(m_us_dm_nhom_khach_hang);
            load_data_2_grid();
        }

        private void delete_dm_nhom_khach_hang()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_DM_NHOM_KHACH_HANG v_us = new US_DM_NHOM_KHACH_HANG();
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

        private void view_dm_nhom_khach_hang()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us_dm_nhom_khach_hang, m_fg.Row);
            //	f101_dm_nhom_khach_hang_DE v_fDE = new f101_dm_nhom_khach_hang_DE();			
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
        private void Load_thong_tin_chi_tiet()
        {
            grid2us_object(m_us_dm_nhom_khach_hang, m_fg.Row);
            m_lbl_ma_nhom.Text = m_us_dm_nhom_khach_hang.strMA_NHOM;
            m_lbl_ten_nhom.Text = m_us_dm_nhom_khach_hang.strTEN_NHOM;
        }
        #endregion

        #region Event
        private void uc_f101_dm_nhom_khach_hang_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
                Load_thong_tin_chi_tiet();
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

                insert_dm_nhom_khach_hang();
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
                update_dm_nhom_khach_hang();
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
                delete_dm_nhom_khach_hang();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tim_kiem_Click(object sender, EventArgs e)
        {
            string v_str_tu_khoa = m_text_tim_kiem.Text.Trim();
            US_DM_NHOM_KHACH_HANG v_us_dm_nhom_khach_hang = new US_DM_NHOM_KHACH_HANG();
            DS_DM_NHOM_KHACH_HANG v_ds_dm_nhom_khach_hang = new DS_DM_NHOM_KHACH_HANG();
            v_us_dm_nhom_khach_hang.FillDatasetSearch(v_ds_dm_nhom_khach_hang, v_str_tu_khoa);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_dm_nhom_khach_hang, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }

        private void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                update_dm_nhom_khach_hang();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_fg_Click(object sender, EventArgs e)
        {
            grid2us_object(m_us_dm_nhom_khach_hang, m_fg.Row);
            m_lbl_ma_nhom.Text = m_us_dm_nhom_khach_hang.strMA_NHOM;
            m_lbl_ten_nhom.Text = m_us_dm_nhom_khach_hang.strTEN_NHOM;
        }
        #endregion
    }
}
