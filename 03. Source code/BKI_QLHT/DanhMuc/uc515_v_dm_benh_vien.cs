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

using BKI_QLHT.US;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;

using C1.Win.C1FlexGrid;
using IP.Core.IPSystemAdmin;

namespace BKI_QLHT
{
    public partial class uc515_v_dm_benh_vien : UserControl
    {
        public uc515_v_dm_benh_vien()
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
            MA_TU_DIEN = 2
,
            TEN_NGAN = 1
                ,
            GHI_CHU = 4
                , TEN = 3

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_BENH_VIEN m_ds = new DS_V_DM_BENH_VIEN();
        US_V_DM_BENH_VIEN m_us = new US_V_DM_BENH_VIEN();
        US_CM_DM_TU_DIEN m_us_tu_dien = new US_CM_DM_TU_DIEN();
        DS_CM_DM_TU_DIEN m_ds_tu_dien = new DS_CM_DM_TU_DIEN();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_fg);
            set_define_events();
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_BENH_VIEN.MA_TU_DIEN, e_col_Number.MA_TU_DIEN);
            v_htb.Add(V_DM_BENH_VIEN.TEN_NGAN, e_col_Number.TEN_NGAN);
            v_htb.Add(V_DM_BENH_VIEN.GHI_CHU, e_col_Number.GHI_CHU);
            v_htb.Add(V_DM_BENH_VIEN.TEN, e_col_Number.TEN);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_BENH_VIEN.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_DM_BENH_VIEN();
            m_us.FillDataset(m_ds);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_V_DM_BENH_VIEN i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_DM_BENH_VIEN i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_dm_benh_vien()
        {
            f516_v_dm_benh_vien_de v_fDE = new f516_v_dm_benh_vien_de();
            v_fDE.display_for_insert();
            load_data_2_grid();
        }

        private void update_v_dm_benh_vien()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            f516_v_dm_benh_vien_de v_fDE = new f516_v_dm_benh_vien_de();
            v_fDE.display_for_update(m_us);
            load_data_2_grid();
        }

        private void delete_v_dm_benh_vien()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_DM_BENH_VIEN v_us = new US_V_DM_BENH_VIEN();
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

        private void view_v_dm_benh_vien()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	f515_v_dm_benh_vien_DE v_fDE = new f515_v_dm_benh_vien_DE();			
            //	v_fDE.display(m_us);
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            this.Load += new System.EventHandler(this.uc515_v_dm_benh_vien_Load);
            //m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        #region Event

        private void uc515_v_dm_benh_vien_Load(object sender, System.EventArgs e)
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
                insert_v_dm_benh_vien();
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
                update_v_dm_benh_vien();
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
                delete_v_dm_benh_vien();
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
                view_v_dm_benh_vien();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion
    }
}
