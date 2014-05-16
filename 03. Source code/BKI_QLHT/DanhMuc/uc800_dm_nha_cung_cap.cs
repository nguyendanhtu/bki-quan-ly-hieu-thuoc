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


namespace BKI_QLHT.DanhMuc
{
    public partial class uc800_dm_nha_cung_cap : UserControl
    {
        public uc800_dm_nha_cung_cap()
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
        DS_V_DM_NCC_NSX_NHASX_1 m_ds = new DS_V_DM_NCC_NSX_NHASX_1();
        US_V_DM_NCC_NSX_NHASX_1 m_us = new US_V_DM_NCC_NSX_NHASX_1();
        US_DM_NCC_NSX_NHASX m_us_dm_ncc = new US_DM_NCC_NSX_NHASX();
        DS_DM_NCC_NSX_NHASX m_ds_dm_ncc = new DS_DM_NCC_NSX_NHASX();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_grv_nha_cung_cap);
            set_define_events();
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_grv_nha_cung_cap);
            load_data_2_grid();
            grid2us_object(m_us_dm_ncc,m_grv_nha_cung_cap.Row);
            m_us = new US_V_DM_NCC_NSX_NHASX_1(m_us_dm_ncc.dcID);
            load_data_2_thong_tin_chi_tiet(m_us);
        }

        private void load_data_2_thong_tin_chi_tiet(US_V_DM_NCC_NSX_NHASX_1 m_us)
        {
            m_lbl_ten_nha_cung_cap.Text = m_us.strTEN_NCC;
            m_lbl_ma_nha_cung_cap.Text = m_us.strMA_NCC;
            m_lbl_sdt.Text = m_us.strSDT;
            m_lbl_dia_chi.Text = m_us.strDIA_CHI;
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_NCC_NSX_NHASX_1.TEN_NCC, e_col_Number.TEN_NCC);
            v_htb.Add(V_DM_NCC_NSX_NHASX_1.DIA_CHI, e_col_Number.DIA_CHI);
            v_htb.Add(V_DM_NCC_NSX_NHASX_1.SDT, e_col_Number.SDT);
            v_htb.Add(V_DM_NCC_NSX_NHASX_1.MA_NCC, e_col_Number.MA_NCC);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_NCC_NSX_NHASX_1.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_DM_NCC_NSX_NHASX_1();
            m_us.FillDataset(m_ds,"where ID_LOAI_DM=1");
            m_grv_nha_cung_cap.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_grv_nha_cung_cap, m_obj_trans);
            m_grv_nha_cung_cap.Redraw = true;
        }
        private void grid2us_object(US_DM_NCC_NSX_NHASX i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_grv_nha_cung_cap.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_DM_NCC_NSX_NHASX_1 i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_grv_nha_cung_cap.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_dm_ncc_nsx_nhasx_1()
        {
            	f800_dm_nha_cung_cap_DE v_fDE = new  f800_dm_nha_cung_cap_DE();								
            	v_fDE.display_for_insert();
            load_data_2_grid();
            v_fDE.get_us(ref m_us_dm_ncc);
            if (m_us_dm_ncc.strMA_NCC != "")
            {
                WinFormControls.set_focus_for_grid(m_grv_nha_cung_cap, m_us_dm_ncc.strMA_NCC, 2);
                grid2us_object(m_us_dm_ncc, m_grv_nha_cung_cap.Row);
                m_us = new US_V_DM_NCC_NSX_NHASX_1(m_us_dm_ncc.dcID);
                load_data_2_thong_tin_chi_tiet(m_us);
            }
        }

        private void update_v_dm_ncc_nsx_nhasx_1()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_nha_cung_cap)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_nha_cung_cap, m_grv_nha_cung_cap.Row)) return;
            grid2us_object(m_us_dm_ncc, m_grv_nha_cung_cap.Row);
            	f800_dm_nha_cung_cap_DE v_fDE = new f800_dm_nha_cung_cap_DE();
            	v_fDE.display_for_update(m_us_dm_ncc);
            load_data_2_grid();
            grid2us_object(m_us_dm_ncc, m_grv_nha_cung_cap.Row);
            m_us = new US_V_DM_NCC_NSX_NHASX_1(m_us_dm_ncc.dcID);
            load_data_2_thong_tin_chi_tiet(m_us);
        }

        private void delete_v_dm_ncc_nsx_nhasx_1()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_nha_cung_cap)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_nha_cung_cap, m_grv_nha_cung_cap.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_DM_NCC_NSX_NHASX v_us = new US_DM_NCC_NSX_NHASX();
            grid2us_object(v_us, m_grv_nha_cung_cap.Row);
            US_V_DM_NCC_NSX_NHASX_1 v_v_us = new US_V_DM_NCC_NSX_NHASX_1(v_us.dcID);
            if (v_v_us.dcID_NHA_CUNG_CAP ==0)
            {
                try
                {
                    v_us.BeginTransaction();
                    v_us.Delete();
                    v_us.CommitTransaction();
                    m_grv_nha_cung_cap.Rows.Remove(m_grv_nha_cung_cap.Row);
                    grid2us_object(m_us_dm_ncc, m_grv_nha_cung_cap.Row);
                    m_us = new US_V_DM_NCC_NSX_NHASX_1(m_us_dm_ncc.dcID);
                    load_data_2_thong_tin_chi_tiet(m_us);
                }
                catch (Exception v_e)
                {
                    v_us.Rollback();
                    CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                        new CDBClientDBExceptionInterpret());
                    v_objErrHandler.showErrorMessage();
                }
            }
            else
            {
                MessageBox.Show("Nhà cung cấp đã được sử dụng. Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void view_v_dm_ncc_nsx_nhasx_1()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_nha_cung_cap)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_nha_cung_cap, m_grv_nha_cung_cap.Row)) return;
            grid2us_object(m_us_dm_ncc, m_grv_nha_cung_cap.Row);
            //	f800_DM_NHA_CUNG_CAP_DE v_fDE = new f800_DM_NHA_CUNG_CAP_DE();			
            //	v_fDE.display(m_us);
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            this.Load += new EventHandler(f800_DM_NHA_CUNG_CAP_Load);
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //

        #region events
        private void f800_DM_NHA_CUNG_CAP_Load(object sender, System.EventArgs e)
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
               // this.Close();
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
                insert_v_dm_ncc_nsx_nhasx_1();
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
                update_v_dm_ncc_nsx_nhasx_1();
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
                delete_v_dm_ncc_nsx_nhasx_1();
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
                view_v_dm_ncc_nsx_nhasx_1();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_grv_nha_cung_cap_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_nha_cung_cap)) return;
                if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_nha_cung_cap, m_grv_nha_cung_cap.Row)) return;
                grid2us_object(m_us_dm_ncc, m_grv_nha_cung_cap.Row);
                m_us = new US_V_DM_NCC_NSX_NHASX_1(m_us_dm_ncc.dcID);
                load_data_2_thong_tin_chi_tiet(m_us);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_tim_kiem_Click(object sender, EventArgs e)
        {
            try
            {
                US_V_DM_NCC_NSX_NHASX_1 v_us_v_dm_ncc = new US_V_DM_NCC_NSX_NHASX_1();
                DS_V_DM_NCC_NSX_NHASX_1 v_ds_v_dm_ncc = new DS_V_DM_NCC_NSX_NHASX_1();
                v_us_v_dm_ncc.FillDatasetSearch(v_ds_v_dm_ncc, m_txt_tu_khoa.Text, 1);
                m_grv_nha_cung_cap.Redraw = false;
                CGridUtils.Dataset2C1Grid(v_ds_v_dm_ncc, m_grv_nha_cung_cap, m_obj_trans);
                m_grv_nha_cung_cap.Redraw = true;
                if (v_ds_v_dm_ncc.V_DM_NCC_NSX_NHASX_1.Count != 0)
                {
                    //WinFormControls.set_focus_for_grid(m_grv_dm_nha_san_xuat,v_us_v_dm_ncc.strTEN_NCC, 1);
                    //grid2us_object(m_us_dm_ncc, m_grv_dm_nha_san_xuat.Row);
                    decimal id = CIPConvert.ToDecimal(v_ds_v_dm_ncc.Tables[0].Rows[0]["ID"]);
                    m_us = new US_V_DM_NCC_NSX_NHASX_1(id);
                    //m_us_dm_ncc = new US_DM_NCC_NSX_NHASX(id);
                    load_data_2_thong_tin_chi_tiet(m_us);
                }
                else
                {
                    m_lbl_ten_nha_cung_cap.Text = "";
                    m_lbl_ma_nha_cung_cap.Text = "";
                    m_lbl_sdt.Text = "";
                    m_lbl_dia_chi.Text = "";
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_tu_khoa_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    US_V_DM_NCC_NSX_NHASX_1 v_us_v_dm_ncc = new US_V_DM_NCC_NSX_NHASX_1();
                    DS_V_DM_NCC_NSX_NHASX_1 v_ds_v_dm_ncc = new DS_V_DM_NCC_NSX_NHASX_1();
                    v_us_v_dm_ncc.FillDatasetSearch(v_ds_v_dm_ncc, m_txt_tu_khoa.Text, 1);
                    m_grv_nha_cung_cap.Redraw = false;
                    CGridUtils.Dataset2C1Grid(v_ds_v_dm_ncc, m_grv_nha_cung_cap, m_obj_trans);
                    m_grv_nha_cung_cap.Redraw = true;
                    if (v_ds_v_dm_ncc.V_DM_NCC_NSX_NHASX_1.Count != 0)
                    {
                        //WinFormControls.set_focus_for_grid(m_grv_dm_nha_san_xuat,v_us_v_dm_ncc.strTEN_NCC, 1);
                        //grid2us_object(m_us_dm_ncc, m_grv_dm_nha_san_xuat.Row);
                        decimal id = CIPConvert.ToDecimal(v_ds_v_dm_ncc.Tables[0].Rows[0]["ID"]);
                        m_us = new US_V_DM_NCC_NSX_NHASX_1(id);
                        //m_us_dm_ncc = new US_DM_NCC_NSX_NHASX(id);
                        load_data_2_thong_tin_chi_tiet(m_us);
                    }
                    else
                    {
                        m_lbl_ten_nha_cung_cap.Text = "";
                        m_lbl_ma_nha_cung_cap.Text = "";
                        m_lbl_sdt.Text = "";
                        m_lbl_dia_chi.Text = "";
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_grv_nha_cung_cap_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                {
                    grid2us_object(m_us_dm_ncc, m_grv_nha_cung_cap.Row);
                    m_us = new US_V_DM_NCC_NSX_NHASX_1(m_us_dm_ncc.dcID);
                    load_data_2_thong_tin_chi_tiet(m_us);
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }
        #endregion

    }
}
