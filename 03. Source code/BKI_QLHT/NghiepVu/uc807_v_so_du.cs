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

namespace BKI_QLHT.NghiepVu
{
    public partial class uc807_v_so_du : UserControl
    {
        public uc807_v_so_du()
        {
            InitializeComponent();
            format_controls();
        }

        
        #region Data Structure
        private enum e_col_Number
        {
            TEN_DON_VI = 3
,
            TEN_THUOC = 1
                , SO_DU = 2

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_SO_DU m_ds = new DS_V_SO_DU();
        US_V_SO_DU m_us = new US_V_SO_DU();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_grv_so_du);
            set_define_events();
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_grv_so_du);
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_SO_DU.TEN_DON_VI, e_col_Number.TEN_DON_VI);
            v_htb.Add(V_SO_DU.TEN_THUOC, e_col_Number.TEN_THUOC);
            v_htb.Add(V_SO_DU.SO_DU, e_col_Number.SO_DU);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_SO_DU.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_SO_DU();
            m_us.FillDataset(m_ds,"where SO_DU>0 AND MOI_NHAT_YN='Y' ORDER BY SO_DU");
            m_grv_so_du.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_grv_so_du, m_obj_trans);
            m_grv_so_du.Redraw = true;
        }
        private void load_data_to_text_box_search()
        {
            US_V_DM_THUOC v_us = new US_V_DM_THUOC();
            DS_V_DM_THUOC v_ds = new DS_V_DM_THUOC();
            v_us.FillDataset(v_ds);
            m_txts_ten_thuoc.load_data_to_list(v_ds, V_DM_THUOC.DISPLAY, V_DM_THUOC.ID);
        }
        private void grid2us_object(US_V_SO_DU i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_grv_so_du.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_SO_DU i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_grv_so_du.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_so_du()
        {
            //	f807_v_so_du_DE v_fDE = new  f807_v_so_du_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_v_so_du()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_so_du)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_so_du, m_grv_so_du.Row)) return;
            grid2us_object(m_us, m_grv_so_du.Row);
            //	f807_v_so_du_DE v_fDE = new f807_v_so_du_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_so_du()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_so_du)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_so_du, m_grv_so_du.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_SO_DU v_us = new US_V_SO_DU();
            grid2us_object(v_us, m_grv_so_du.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_grv_so_du.Rows.Remove(m_grv_so_du.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_so_du()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_so_du)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_so_du, m_grv_so_du.Row)) return;
            grid2us_object(m_us, m_grv_so_du.Row);
            //	f807_v_so_du_DE v_fDE = new f807_v_so_du_DE();			
            //	v_fDE.display(m_us);
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.Load += new EventHandler(f807_v_so_du_Load);
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //

        #region events
        private void f807_v_so_du_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
                load_data_to_text_box_search();
                m_txts_ten_thuoc.Focus();
        {
            US_V_DM_THUOC v_us = new US_V_DM_THUOC();
            DS_V_DM_THUOC v_ds = new DS_V_DM_THUOC();
            v_us.FillDataset(v_ds);
            m_txts_ten_thuoc.load_data_to_list(v_ds, V_DM_THUOC.DISPLAY, V_DM_THUOC.ID);
        }
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
                this.Visible = false;
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
                insert_v_so_du();
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
                update_v_so_du();
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
                delete_v_so_du();
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
                view_v_so_du();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        private void m_txts_ten_thuoc_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                DS_V_SO_DU v_ds = new DS_V_SO_DU();
                US_V_SO_DU v_us = new US_V_SO_DU();
                v_us.FillDataset(v_ds, "where SO_DU>0 AND MOI_NHAT_YN='Y' AND V_SO_DU.ID_THUOC=" + m_txts_ten_thuoc.dcID);
                m_grv_so_du.Redraw = false;
                CGridUtils.Dataset2C1Grid(v_ds, m_grv_so_du, m_obj_trans);
                m_grv_so_du.Redraw = true;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
