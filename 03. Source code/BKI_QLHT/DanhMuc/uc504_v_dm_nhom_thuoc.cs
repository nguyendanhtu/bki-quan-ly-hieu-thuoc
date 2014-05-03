using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
    public partial class uc504_v_dm_nhom_thuoc : UserControl
    {
        public uc504_v_dm_nhom_thuoc()
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
            TEN_DANH_MUC = 2
,
            GHI_CHU = 3
                , TEN_NHOM = 1

        }
        #endregion
        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_NHOM_THUOC m_ds = new DS_V_DM_NHOM_THUOC();
        US_V_DM_NHOM_THUOC m_us = new US_V_DM_NHOM_THUOC();
        US_DM_NHOM_THUOC m_us_nhom_thuoc = new US_DM_NHOM_THUOC();
       
        #endregion
        #region Private Methods
        private void format_controls(){
            //CControlFormat.setFormStyle(this);
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
			CControlFormat.setC1FlexFormat(m_grv_nhom_thuoc);
			set_define_events();
            //this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object( m_grv_nhom_thuoc);
			load_data_2_grid();
            //load_data_2_cbo();
            load_data_2_cbo_tk();
            grid2us_object(m_us, m_grv_nhom_thuoc.Row);
            load_data_2_thong_tin(m_us);
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_DM_NHOM_THUOC.TEN_DANH_MUC, e_col_Number.TEN_DANH_MUC);			v_htb.Add(V_DM_NHOM_THUOC.GHI_CHU, e_col_Number.GHI_CHU);			v_htb.Add(V_DM_NHOM_THUOC.TEN_NHOM, e_col_Number.TEN_NHOM);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.V_DM_NHOM_THUOC.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_V_DM_NHOM_THUOC();
            string v_str_tim_kiem = m_txt_tim_kiem.Text;
            //m_us.FillDataset(m_ds);
            m_us.FillDatasetSearch(m_ds, get_danh_muc_thuoc(), v_str_tim_kiem);
            m_grv_nhom_thuoc.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_grv_nhom_thuoc, m_obj_trans);
            m_grv_nhom_thuoc.Redraw = true;
		}
		private void grid2us_object(US_V_DM_NHOM_THUOC i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_grv_nhom_thuoc.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_DM_NHOM_THUOC i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_grv_nhom_thuoc.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_v_dm_nhom_thuoc(){
            f505_v_dm_nhom_thuoc_de v_fDE = new f505_v_dm_nhom_thuoc_de();								
		    v_fDE.display_for_insert();
			load_data_2_grid();
		}

		private void update_v_dm_nhom_thuoc(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_nhom_thuoc)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_nhom_thuoc, m_grv_nhom_thuoc.Row)) return;
            grid2us_object(m_us, m_grv_nhom_thuoc.Row);
            f505_v_dm_nhom_thuoc_de v_fDE = new f505_v_dm_nhom_thuoc_de();
             v_fDE.display_for_update(m_us);
			load_data_2_grid();
		}
        private void delete_v_dm_nhom_thuoc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_nhom_thuoc)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_nhom_thuoc, m_grv_nhom_thuoc.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_DM_NHOM_THUOC v_us = new US_V_DM_NHOM_THUOC();
            grid2us_object(v_us, m_grv_nhom_thuoc.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_grv_nhom_thuoc.Rows.Remove(m_grv_nhom_thuoc.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_dm_nhom_thuoc()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_nhom_thuoc)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_nhom_thuoc, m_grv_nhom_thuoc.Row)) return;
            grid2us_object(m_us, m_grv_nhom_thuoc.Row);
            //	f504_v_dm_nhom_thuoc_DE v_fDE = new f504_v_dm_nhom_thuoc_DE();			
            //	v_fDE.display(m_us);
        }
        private void load_data_2_cbo_tk()
        {
            US_DM_DANH_MUC_THUOC v_us_dm = new US_DM_DANH_MUC_THUOC();
            DS_DM_DANH_MUC_THUOC v_ds_dm = new DS_DM_DANH_MUC_THUOC();
            v_us_dm.FillDataset(v_ds_dm);

            m_cbo_tk_danh_muc.DataSource = v_ds_dm.DM_DANH_MUC_THUOC;
            m_cbo_tk_danh_muc.ValueMember = DM_DANH_MUC_THUOC.ID;
            m_cbo_tk_danh_muc.DisplayMember = DM_DANH_MUC_THUOC.TEN_DANH_MUC;
            DataRow v_dr = v_ds_dm.DM_DANH_MUC_THUOC.NewRow();
            v_dr[DM_DANH_MUC_THUOC.ID] = -1;
            v_dr[DM_DANH_MUC_THUOC.TEN_DANH_MUC] = "---------------------------Tất cả------------------------";
            v_dr[DM_DANH_MUC_THUOC.GHI_CHU] = "";
            v_ds_dm.DM_DANH_MUC_THUOC.Rows.InsertAt(v_dr, 0);
            m_cbo_tk_danh_muc.SelectedIndex = 0;
        }
        private string get_danh_muc_thuoc()
        {
            if (m_cbo_tk_danh_muc.SelectedIndex != 0)
            {
                return m_cbo_tk_danh_muc.Text;
            }
            return "";
        }
        private void load_data_2_thong_tin(US_V_DM_NHOM_THUOC v_us) {
            m_ds = new DS_V_DM_NHOM_THUOC();
            m_lbl_danh_muc_thuoc.Text = v_us.strTEN_DANH_MUC;
            m_lbl_nhom_thuoc.Text = v_us.strTEN_NHOM;
            m_lbl_ghi_chu.Text = v_us.strGHI_CHU;
            
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            //m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
        }

        #endregion
        #region Events
        private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
                this.Visible = false;
                this.Controls.Clear();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_insert_Click(object sender, EventArgs e) {
			try{
				insert_v_dm_nhom_thuoc();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_v_dm_nhom_thuoc();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_v_dm_nhom_thuoc();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}
        private void uc504_v_dm_nhom_thuoc_Load(object sender, System.EventArgs e)
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

        private void m_cbo_tk_danh_muc_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (System.Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_search_Click(object sender, System.EventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (System.Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_grv_nhom_thuoc_Click(object sender, System.EventArgs e)
        {
            try
            {
                grid2us_object(m_us, m_grv_nhom_thuoc.Row);
                load_data_2_thong_tin(m_us);
            }
            catch (System.Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_tim_kiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                load_data_2_grid();
            }
            catch (System.Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_grv_nhom_thuoc_DoubleClick(object sender, System.EventArgs e)
        {
            try
            {
                update_v_dm_nhom_thuoc();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        private void uc504_v_dm_nhom_thuoc_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Control) {
                    switch (e.KeyCode) {
                        case Keys.F1: insert_v_dm_nhom_thuoc();
                            break;
                    }
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            } 
        }

        
    }
}
