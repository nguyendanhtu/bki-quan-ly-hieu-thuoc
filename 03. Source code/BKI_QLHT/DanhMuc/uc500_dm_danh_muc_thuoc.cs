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
    public partial class uc500_dm_danh_muc_thuoc : UserControl
    {
        public uc500_dm_danh_muc_thuoc()
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
            TEN_DANH_MUC = 1
, GHI_CHU = 2

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_DM_DANH_MUC_THUOC m_ds = new DS_DM_DANH_MUC_THUOC();
        US_DM_DANH_MUC_THUOC m_us = new US_DM_DANH_MUC_THUOC();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            //CControlFormat.setFormStyle(this);
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_grv_danh_muc_thuoc);
            set_define_events();
            //this.KeyPreview = true;

        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_grv_danh_muc_thuoc);
            load_data_2_grid();
            grid2us_object(m_us, m_grv_danh_muc_thuoc.Row);
            //load_data_2_thong_tin();

        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(DM_DANH_MUC_THUOC.TEN_DANH_MUC, e_col_Number.TEN_DANH_MUC);
            v_htb.Add(DM_DANH_MUC_THUOC.GHI_CHU, e_col_Number.GHI_CHU);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.DM_DANH_MUC_THUOC.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_DM_DANH_MUC_THUOC();
            m_us.FillDataset(m_ds);
            m_grv_danh_muc_thuoc.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_grv_danh_muc_thuoc, m_obj_trans);
            m_grv_danh_muc_thuoc.Redraw = true;
        }
        private void grid2us_object(US_DM_DANH_MUC_THUOC i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_grv_danh_muc_thuoc.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_DM_DANH_MUC_THUOC i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_grv_danh_muc_thuoc.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_dm_danh_muc_thuoc()
        {
            f501_dm_danh_muc_thuoc_DE v_fDE = new f501_dm_danh_muc_thuoc_DE();								
            v_fDE.display_for_insert();
            load_data_2_grid();
        }

        private void update_dm_danh_muc_thuoc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_danh_muc_thuoc)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_danh_muc_thuoc, m_grv_danh_muc_thuoc.Row)) return;
            grid2us_object(m_us, m_grv_danh_muc_thuoc.Row);
            f501_dm_danh_muc_thuoc_DE v_fDE = new f501_dm_danh_muc_thuoc_DE();
            v_fDE.display_for_update(m_us);
            load_data_2_grid();
        }

        private void delete_dm_danh_muc_thuoc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_danh_muc_thuoc)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_danh_muc_thuoc, m_grv_danh_muc_thuoc.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_DM_DANH_MUC_THUOC v_us = new US_DM_DANH_MUC_THUOC();
            grid2us_object(v_us, m_grv_danh_muc_thuoc.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_grv_danh_muc_thuoc.Rows.Remove(m_grv_danh_muc_thuoc.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }
        private void load_grid_search() {
            string v_str_tu_khoa = m_txt_tu_khoa.Text;
            US_DM_DANH_MUC_THUOC v_us_danh_muc_thuoc = new US_DM_DANH_MUC_THUOC();
            DS_DM_DANH_MUC_THUOC v_ds_danh_muc_thuoc = new DS_DM_DANH_MUC_THUOC();
            v_us_danh_muc_thuoc.FillDataseSearch(v_ds_danh_muc_thuoc, v_str_tu_khoa);
            m_grv_danh_muc_thuoc.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_danh_muc_thuoc, m_grv_danh_muc_thuoc, m_obj_trans);
            m_grv_danh_muc_thuoc.Redraw = true;
        }

        //private void view_dm_danh_muc_thuoc()
        //{
        //    if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_danh_muc_thuoc)) return;
        //    if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_danh_muc_thuoc, m_grv_danh_muc_thuoc.Row)) return;
        //    grid2us_object(m_us, m_grv_danh_muc_thuoc.Row);
        //    //	test_dm_danh_muc_thuoc_DE v_fDE = new test_dm_danh_muc_thuoc_DE();			
        //    //	v_fDE.display(m_us);
        //}
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            //m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
            this.Load += new System.EventHandler(this.usercontrol_Load);
        }
        //private void load_data_2_thong_tin() {
        //    if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_danh_muc_thuoc)) return;
        //    if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_danh_muc_thuoc, m_grv_danh_muc_thuoc.Row)) return;
        //    grid2us_object(m_us, m_grv_danh_muc_thuoc.Row);
        //    m_lbl_ten_danh_mục.Text = m_us.strTEN_DANH_MUC;
        //    m_lbl_ghi_chu.Text = m_us.strGHI_CHU;
        //}
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        #region Event
        private void test_dm_danh_muc_thuoc_Load(object sender, System.EventArgs e)
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
                //this.Close();
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
                insert_dm_danh_muc_thuoc();
                //load_data_2_thong_tin();
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
                update_dm_danh_muc_thuoc();
                //load_data_2_thong_tin();
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
                delete_dm_danh_muc_thuoc();
                //load_data_2_thong_tin();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        //private void m_cmd_view_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        view_dm_danh_muc_thuoc();
        //    }
        //    catch (Exception v_e)
        //    {
        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}
        private void usercontrol_Load(object sender, System.EventArgs e)
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

        private void uc500_dm_danh_muc_thuoc_Load(object sender, EventArgs e)
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

        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_grid_search();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_grv_danh_muc_thuoc_Click(object sender, EventArgs e)
        {
            try
            {
                grid2us_object(m_us, m_grv_danh_muc_thuoc.Row);
                //load_data_2_thong_tin();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_grv_danh_muc_thuoc_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                update_dm_danh_muc_thuoc();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_tu_khoa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                load_grid_search();
            }
        }

        //private void m_txt_tu_khoa_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    string v_str_tu_khoa = m_txt_tu_khoa.Text;
        //    US_DM_DANH_MUC_THUOC v_us_danh_muc_thuoc = new US_DM_DANH_MUC_THUOC();
        //    DS_DM_DANH_MUC_THUOC v_ds_danh_muc_thuoc = new DS_DM_DANH_MUC_THUOC();
        //    v_us_danh_muc_thuoc.FillDataseSearch(v_ds_danh_muc_thuoc, v_str_tu_khoa);
        //    m_grv_danh_muc_thuoc.Redraw = false;
        //    CGridUtils.Dataset2C1Grid(v_ds_danh_muc_thuoc, m_grv_danh_muc_thuoc, m_obj_trans);
        //    m_grv_danh_muc_thuoc.Redraw = true;
        //}
        #endregion
       
    }
}
