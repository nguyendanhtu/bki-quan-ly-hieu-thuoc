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
    public partial class uc801_dm_khach_hang : UserControl
    {
        public uc801_dm_khach_hang()
        {
            InitializeComponent();
            format_controls();
        }

        #region Data Structure
        private enum e_col_Number
        {
            MA_KHACH_HANG = 2
,
            DIA_CHI = 4
                ,
            TEN_KHACH_HANG = 1
                ,
            TEN_NHOM = 5
                ,
            SDT = 3
                , MA_SO_THUE = 6

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_KHACH_HANG m_ds = new DS_V_DM_KHACH_HANG();
        US_V_DM_KHACH_HANG m_us = new US_V_DM_KHACH_HANG();
        US_DM_KHACH_HANG m_us_dm_khach_hang = new US_DM_KHACH_HANG();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            //CControlFormat.setFormStyle(this);
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_grv_dm_khach_hang);
            set_define_events();
            //this.KeyPreview = true;
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            this.Load += new System.EventHandler(this.uc801_dm_khach_hang_Load);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_grv_dm_khach_hang);
            load_data_2_grid();
            grid2us_object(m_us, m_grv_dm_khach_hang.Row);
            load_data_2_thong_tin_chi_tiet(m_us);
            
        }

        private void load_data_2_thong_tin_chi_tiet(US_V_DM_KHACH_HANG m_us)
        {
            m_ds = new DS_V_DM_KHACH_HANG();
            m_lbl_ten_khach_hang.Text = m_us.strTEN_KHACH_HANG;
            m_lbl_ma_khach_hang.Text = m_us.strMA_KHACH_HANG;
            m_lbl_sdt.Text = m_us.strSDT;
            m_lbl_dia_chi.Text = m_us.strDIA_CHI;
            m_lbl_ma_so_thue.Text = m_us.strMA_SO_THUE;
            m_lbl_ten_nhom_khach_hang.Text = m_us.strTEN_NHOM;
            //US_V_DM_KHACH_HANG v_us = new US_V_DM_KHACH_HANG();
            //DS_V_DM_KHACH_HANG m_ds = new DS_V_DM_KHACH_HANG();
            //m_us.FillDataset(m_ds);
            //m_grv_dm_khach_hang.DataSource = m_ds.V_DM_KHACH_HANG;
            //m_lbl_ten_khach_hang.DataBindings.Clear();
            //m_lbl_ten_khach_hang.DataBindings.Add("Text", m_grv_dm_khach_hang.DataSource, "TEN_KHACH_HANG");

        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_KHACH_HANG.MA_KHACH_HANG, e_col_Number.MA_KHACH_HANG);
            v_htb.Add(V_DM_KHACH_HANG.DIA_CHI, e_col_Number.DIA_CHI);
            v_htb.Add(V_DM_KHACH_HANG.TEN_KHACH_HANG, e_col_Number.TEN_KHACH_HANG);
            v_htb.Add(V_DM_KHACH_HANG.TEN_NHOM, e_col_Number.TEN_NHOM);
            v_htb.Add(V_DM_KHACH_HANG.SDT, e_col_Number.SDT);
            v_htb.Add(V_DM_KHACH_HANG.MA_SO_THUE, e_col_Number.MA_SO_THUE);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_KHACH_HANG.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_DM_KHACH_HANG();
            m_us.FillDataset(m_ds);
            m_grv_dm_khach_hang.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_grv_dm_khach_hang, m_obj_trans);
            m_grv_dm_khach_hang.Redraw = true;
        }
        private void grid2us_object(US_V_DM_KHACH_HANG i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_grv_dm_khach_hang.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_DM_KHACH_HANG i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_grv_dm_khach_hang.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_dm_khach_hang()
        {
            f801_dm_khach_hang_DE v_fDE = new f801_dm_khach_hang_DE();
            v_fDE.display_for_insert();
            load_data_2_grid();
        }

        private void update_v_dm_khach_hang()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_dm_khach_hang)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_dm_khach_hang, m_grv_dm_khach_hang.Row)) return;
            grid2us_object(m_us, m_grv_dm_khach_hang.Row);
            f801_dm_khach_hang_DE v_fDE = new f801_dm_khach_hang_DE();
            v_fDE.display_for_update(m_us);
            load_data_2_grid();
        }

        private void delete_v_dm_khach_hang()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_dm_khach_hang)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_dm_khach_hang, m_grv_dm_khach_hang.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_DM_KHACH_HANG v_us = new US_V_DM_KHACH_HANG();
            grid2us_object(v_us, m_grv_dm_khach_hang.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_grv_dm_khach_hang.Rows.Remove(m_grv_dm_khach_hang.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_dm_khach_hang()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_dm_khach_hang)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_dm_khach_hang, m_grv_dm_khach_hang.Row)) return;
            grid2us_object(m_us, m_grv_dm_khach_hang.Row);
            //	f801_dm_khach_hang_DE v_fDE = new f801_dm_khach_hang_DE();			
            //	v_fDE.display(m_us);
        }
        //private void set_define_events()
        //{
        //    m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
        //    m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
        //    m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
        //    m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
        //}
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        #region events
        private void m_txt_tu_khoa_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    string v_str_tu_khoa = m_txt_tu_khoa.Text;
                    US_V_DM_KHACH_HANG v_us_v_dm_khach_hang = new US_V_DM_KHACH_HANG();
                    DS_V_DM_KHACH_HANG v_ds_v_dm_khach_hang = new DS_V_DM_KHACH_HANG();
                    v_us_v_dm_khach_hang.FillDatasetSearch(v_ds_v_dm_khach_hang, v_str_tu_khoa);
                    m_grv_dm_khach_hang.Redraw = false;
                    CGridUtils.Dataset2C1Grid(v_ds_v_dm_khach_hang, m_grv_dm_khach_hang, m_obj_trans);
                    m_grv_dm_khach_hang.Redraw = true;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_grv_dm_khach_hang_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    grid2us_object(m_us, m_grv_dm_khach_hang.Row);
                    load_data_2_thong_tin_chi_tiet(m_us);
                }
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void uc801_dm_khach_hang_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
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
                //this.Close();
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
                insert_v_dm_khach_hang();
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
                update_v_dm_khach_hang();
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
                delete_v_dm_khach_hang();
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
                view_v_dm_khach_hang();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_search_Click_1(object sender, EventArgs e)
        {
            try
            {
                string v_str_tu_khoa = m_txt_tu_khoa.Text;
                US_V_DM_KHACH_HANG v_us_v_dm_khach_hang = new US_V_DM_KHACH_HANG();
                DS_V_DM_KHACH_HANG v_ds_v_dm_khach_hang = new DS_V_DM_KHACH_HANG();
                v_us_v_dm_khach_hang.FillDatasetSearch(v_ds_v_dm_khach_hang, v_str_tu_khoa);
                m_grv_dm_khach_hang.Redraw = false;
                CGridUtils.Dataset2C1Grid(v_ds_v_dm_khach_hang, m_grv_dm_khach_hang, m_obj_trans);
                m_grv_dm_khach_hang.Redraw = true;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_grv_dm_khach_hang_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_dm_khach_hang)) return;
                if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_dm_khach_hang, m_grv_dm_khach_hang.Row)) return;
                grid2us_object(m_us, m_grv_dm_khach_hang.Row);
                load_data_2_thong_tin_chi_tiet(m_us);
            }
            catch(Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_exit_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                this.Controls.Clear();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

       
    }
}
