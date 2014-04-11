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
    public partial class uc_800_dm_nha_cung_cap : UserControl
    {
        public uc_800_dm_nha_cung_cap()
        {
            InitializeComponent();
            format_controls();
        }
     

        #region Data Structure
        private enum e_col_Number
        {
            TEN_NCC = 1
,
            DIA_CHI = 3
                ,
            SDT = 4
                , MA_NCC = 2

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_DM_NHA_CUNG_CAP m_ds = new DS_DM_NHA_CUNG_CAP();
        US_DM_NHA_CUNG_CAP m_us = new US_DM_NHA_CUNG_CAP();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_grv_dm_nha_cung_cap);
            set_define_events();
            //this.KeyPreview = true;
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            this.Load += new System.EventHandler(this.uc800_dm_nha_cung_cap_Load);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_grv_dm_nha_cung_cap);
            load_data_2_grid();
            grid2us_object(m_us, m_grv_dm_nha_cung_cap.Row);
            load_data_2_thong_tin_chi_tiet(m_us);
        }

        private void load_data_2_thong_tin_chi_tiet(US_DM_NHA_CUNG_CAP m_us)
        {
            m_lbl_ten_nha_cung_cap.Text = m_us.strTEN_NCC;
            m_lbl_ma_nha_cung_cap.Text = m_us.strMA_NCC;
            m_lbl_dia_chi.Text = m_us.strDIA_CHI;
            m_lbl_so_dien_thoai.Text = m_us.strSDT;
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(DM_NHA_CUNG_CAP.TEN_NCC, e_col_Number.TEN_NCC);
            v_htb.Add(DM_NHA_CUNG_CAP.DIA_CHI, e_col_Number.DIA_CHI);
            v_htb.Add(DM_NHA_CUNG_CAP.SDT, e_col_Number.SDT);
            v_htb.Add(DM_NHA_CUNG_CAP.MA_NCC, e_col_Number.MA_NCC);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.DM_NHA_CUNG_CAP.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_DM_NHA_CUNG_CAP();
            m_us.FillDataset(m_ds);
            m_grv_dm_nha_cung_cap.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_grv_dm_nha_cung_cap, m_obj_trans);
            m_grv_dm_nha_cung_cap.Redraw = true;
        }
        private void grid2us_object(US_DM_NHA_CUNG_CAP i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_grv_dm_nha_cung_cap.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_DM_NHA_CUNG_CAP i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_grv_dm_nha_cung_cap.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_dm_nha_cung_cap()
        {
            f800_dm_nha_cung_cap_DE v_fDE = new f800_dm_nha_cung_cap_DE();
            v_fDE.display_for_insert();
            load_data_2_grid();
        }

        private void update_dm_nha_cung_cap()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_dm_nha_cung_cap)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_dm_nha_cung_cap, m_grv_dm_nha_cung_cap.Row)) return;
            grid2us_object(m_us, m_grv_dm_nha_cung_cap.Row);
            f800_dm_nha_cung_cap_DE v_fDE = new f800_dm_nha_cung_cap_DE();
            v_fDE.display_for_update(m_us);
            load_data_2_grid();
        }

        private void delete_dm_nha_cung_cap()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_dm_nha_cung_cap)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_dm_nha_cung_cap, m_grv_dm_nha_cung_cap.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_DM_NHA_CUNG_CAP v_us = new US_DM_NHA_CUNG_CAP();
            grid2us_object(v_us, m_grv_dm_nha_cung_cap.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_grv_dm_nha_cung_cap.Rows.Remove(m_grv_dm_nha_cung_cap.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_dm_nha_cung_cap()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_dm_nha_cung_cap)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_dm_nha_cung_cap, m_grv_dm_nha_cung_cap.Row)) return;
            grid2us_object(m_us, m_grv_dm_nha_cung_cap.Row);
            //	f800_dm_nha_cung_cap_DE v_fDE = new f800_dm_nha_cung_cap_DE();			
            //	v_fDE.display(m_us);
        }

        #endregion

        #region Events
        private void uc800_dm_nha_cung_cap_Load(object sender, System.EventArgs e)
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
                //this.
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
                insert_dm_nha_cung_cap();
               
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
                update_dm_nha_cung_cap();
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
                delete_dm_nha_cung_cap();
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
                view_dm_nha_cung_cap();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_search_Click_1(object sender, EventArgs e)
        {
            string v_str_ten_nha_cung_cap = m_txt_ten_nha_cung_cap.Text;
            US_DM_NHA_CUNG_CAP v_us_dm_nha_cung_cap = new US_DM_NHA_CUNG_CAP();
            DS_DM_NHA_CUNG_CAP v_ds_dm_nha_cung_cap = new DS_DM_NHA_CUNG_CAP();
            v_us_dm_nha_cung_cap.FillDatasetSearch(v_ds_dm_nha_cung_cap, v_str_ten_nha_cung_cap);
            m_grv_dm_nha_cung_cap.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_dm_nha_cung_cap, m_grv_dm_nha_cung_cap, m_obj_trans);
            m_grv_dm_nha_cung_cap.Redraw = true;
        }

        private void m_grv_dm_nha_cung_cap_Click(object sender, EventArgs e)
        {
            grid2us_object(m_us, m_grv_dm_nha_cung_cap.Row);
            load_data_2_thong_tin_chi_tiet(m_us);
        }
        #endregion

        private void m_cmd_exit_Click_1(object sender, EventArgs e)
        {

        }


    }
}
