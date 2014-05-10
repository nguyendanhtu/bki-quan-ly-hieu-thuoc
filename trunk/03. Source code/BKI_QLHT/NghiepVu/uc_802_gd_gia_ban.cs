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
    public partial class uc_802_gd_gia_ban : UserControl
    {
        public uc_802_gd_gia_ban()
        {
            InitializeComponent();
            format_controls();
        }

        #region Data Structure
        private enum e_col_Number
        {
            GIA_BAN = 3
,
            TEN_DON_VI = 2
                , TEN_THUOC = 1

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_GD_GIA_BAN m_ds = new DS_V_GD_GIA_BAN();
        US_V_GD_GIA_BAN m_us = new US_V_GD_GIA_BAN();
        US_GD_GIA_BAN m_us_gd_gia_ban = new US_GD_GIA_BAN();
        DS_GD_GIA_BAN m_ds_gd_gia_ban = new DS_GD_GIA_BAN();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_grv_v_gd_gia);
            set_define_events();
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_grv_v_gd_gia);
            //load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_GD_GIA_BAN.GIA_BAN, e_col_Number.GIA_BAN);
            v_htb.Add(V_GD_GIA_BAN.TEN_DON_VI, e_col_Number.TEN_DON_VI);
            v_htb.Add(V_GD_GIA_BAN.TEN_THUOC, e_col_Number.TEN_THUOC);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_GD_GIA_BAN.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            //m_ds = new DS_V_GD_GIA_BAN();
            //m_us.FillDataset(m_ds);
            //m_grv_v_gd_gia.Redraw = false;
            //CGridUtils.Dataset2C1Grid(m_ds, m_grv_v_gd_gia, m_obj_trans);
            //m_grv_v_gd_gia.Redraw = true;
            decimal dc_id = m_txts_ten_thuoc.dcID;
            US_V_GD_GIA_BAN v_us_v_gd_gia_ban = new US_V_GD_GIA_BAN();
            DS_V_GD_GIA_BAN v_ds_v_gd_gia_ban = new DS_V_GD_GIA_BAN();
            v_us_v_gd_gia_ban.FillDatasetbyTenThuoc(v_ds_v_gd_gia_ban, dc_id);
            m_grv_v_gd_gia.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_v_gd_gia_ban, m_grv_v_gd_gia, m_obj_trans);
            m_grv_v_gd_gia.Redraw = true;
        }
        private void grid2us_object(US_V_GD_GIA_BAN i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_grv_v_gd_gia.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_GD_GIA_BAN i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_grv_v_gd_gia.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }

        private void load_data_to_text_box_search()
        {
            US_V_DM_THUOC v_us = new US_V_DM_THUOC();
            DS_V_DM_THUOC v_ds = new DS_V_DM_THUOC();
            v_us.FillDataset(v_ds);
            m_txts_ten_thuoc.load_data_to_list(v_ds, V_DM_THUOC.DISPLAY, V_DM_THUOC.ID);
        }

        private void insert_v_gd_gia_ban()
        {
            //	f802_v_gd_gia_ban_DE v_fDE = new  f802_v_gd_gia_ban_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_v_gd_gia_ban()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_v_gd_gia)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_v_gd_gia, m_grv_v_gd_gia.Row)) return;
            grid2us_object(m_us, m_grv_v_gd_gia.Row);
                f802_v_gd_gia_ban_DE v_fDE = new f802_v_gd_gia_ban_DE();
                v_fDE.display_for_update(m_us);
            load_data_2_grid();
        }

        private void delete_v_gd_gia_ban()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_v_gd_gia)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_v_gd_gia, m_grv_v_gd_gia.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_GD_GIA_BAN v_us = new US_V_GD_GIA_BAN();
            grid2us_object(v_us, m_grv_v_gd_gia.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_grv_v_gd_gia.Rows.Remove(m_grv_v_gd_gia.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_gd_gia_ban()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_v_gd_gia)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_v_gd_gia, m_grv_v_gd_gia.Row)) return;
            grid2us_object(m_us, m_grv_v_gd_gia.Row);
            //	f802_v_gd_gia_ban_DE v_fDE = new f802_v_gd_gia_ban_DE();			
            //	v_fDE.display(m_us);
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            this.Load += new System.EventHandler(this.uc_802_gd_gia_ban_Load);
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //

        #region events
        private void uc_802_gd_gia_ban_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
                load_data_to_text_box_search();
                m_txts_ten_thuoc.Focus();
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
                insert_v_gd_gia_ban();
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
                update_v_gd_gia_ban();
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
                delete_v_gd_gia_ban();
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
                view_v_gd_gia_ban();
            }
            catch (Exception v_e)
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

        private void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_to_text_box_search();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txts_ten_thuoc_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                decimal dc_id = m_txts_ten_thuoc.dcID;
                US_V_GD_GIA_BAN v_us_v_gd_gia_ban = new US_V_GD_GIA_BAN();
                DS_V_GD_GIA_BAN v_ds_v_gd_gia_ban = new DS_V_GD_GIA_BAN();
                v_us_v_gd_gia_ban.FillDatasetbyTenThuoc(v_ds_v_gd_gia_ban, dc_id);
                m_grv_v_gd_gia.Redraw = false;
                CGridUtils.Dataset2C1Grid(v_ds_v_gd_gia_ban, m_grv_v_gd_gia, m_obj_trans);
                m_grv_v_gd_gia.Redraw = true;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        

        //private void m_cmd_update_Click_1(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        update_v_gd_gia_ban();
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}
    }
}
