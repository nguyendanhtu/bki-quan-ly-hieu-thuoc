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

using BKI_QLHT.DS;
using BKI_QLHT.US;
using BKI_QLHT.DS.CDBNames;

using C1.Win.C1FlexGrid;
using IP.Core.IPSystemAdmin;
using System.Globalization;

namespace BKI_QLHT
{
    public partial class uc_804_han_su_dung : UserControl
    {
        public uc_804_han_su_dung()
        {
            InitializeComponent();
            format_controls();
        }
        #region Data Structure
        private enum e_col_Number
        {
            MA_GIAO_DICH = 3
,
            TEN_DON_VI = 5
                ,
            HAN_SD = 1
                ,
            TEN_THUOC = 2
                , SO_DU = 4

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_HAN_SU_DUNG m_ds = new DS_V_HAN_SU_DUNG();
        US_V_HAN_SU_DUNG m_us = new US_V_HAN_SU_DUNG();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_grv_han_su_dung);
            m_grv_han_su_dung.Tree.Column = (int)e_col_Number.HAN_SD;
            m_grv_han_su_dung.Cols[0].Caption = "STT";
            m_grv_han_su_dung.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.SimpleLeaf;
            set_define_events();

        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_grv_han_su_dung);
            load_data_2_grid();
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_HAN_SU_DUNG.MA_GIAO_DICH, e_col_Number.MA_GIAO_DICH);
            v_htb.Add(V_HAN_SU_DUNG.TEN_DON_VI, e_col_Number.TEN_DON_VI);
            v_htb.Add(V_HAN_SU_DUNG.HAN_SD, e_col_Number.HAN_SD);
            v_htb.Add(V_HAN_SU_DUNG.TEN_THUOC, e_col_Number.TEN_THUOC);
            v_htb.Add(V_HAN_SU_DUNG.SO_DU, e_col_Number.SO_DU);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_HAN_SU_DUNG.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_HAN_SU_DUNG();
            m_us.FillDataset(m_ds,"where DATEDIFF(day,GETDATE(),CONVERT(datetime,HAN_SD,103))<90 AND DATEDIFF(day,GETDATE(),CONVERT(datetime,HAN_SD,103))>=0 AND SO_DU>0 ORDER BY HAN_SD");
            m_grv_han_su_dung.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_grv_han_su_dung, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_grv_han_su_dung);
            m_grv_han_su_dung.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
              , 0
              , (int)e_col_Number.HAN_SD // chỗ này là tên trường mà mình nhóm
              , (int)e_col_Number.TEN_THUOC // chỗ này là tên trường mà mình Count
              , "{0}"
              );
            m_lbl_count.Text = m_ds.V_HAN_SU_DUNG.Count.ToString(CultureInfo.InvariantCulture);
            m_grv_han_su_dung.Redraw = true;
        }
        private void grid2us_object(US_V_HAN_SU_DUNG i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_grv_han_su_dung.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_HAN_SU_DUNG i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_grv_han_su_dung.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_han_su_dung()
        {
            //	frm_V_HAN_SU_DUNG_DE v_fDE = new  frm_V_HAN_SU_DUNG_DE();								
            //	v_fDE.display();
            load_data_2_grid();
        }

        private void update_v_han_su_dung()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_han_su_dung)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_han_su_dung, m_grv_han_su_dung.Row)) return;
            grid2us_object(m_us, m_grv_han_su_dung.Row);
            //	frm_V_HAN_SU_DUNG_DE v_fDE = new frm_V_HAN_SU_DUNG_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_han_su_dung()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_han_su_dung)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_han_su_dung, m_grv_han_su_dung.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_HAN_SU_DUNG v_us = new US_V_HAN_SU_DUNG();
            grid2us_object(v_us, m_grv_han_su_dung.Row);
            try
            {
                v_us.BeginTransaction();
                v_us.Delete();
                v_us.CommitTransaction();
                m_grv_han_su_dung.Rows.Remove(m_grv_han_su_dung.Row);
            }
            catch (Exception v_e)
            {
                v_us.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }

        private void view_v_han_su_dung()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_han_su_dung)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_han_su_dung, m_grv_han_su_dung.Row)) return;
            grid2us_object(m_us, m_grv_han_su_dung.Row);
            //	frm_V_HAN_SU_DUNG_DE v_fDE = new frm_V_HAN_SU_DUNG_DE();			
            //	v_fDE.display(m_us);
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            this.Load += new EventHandler(frm_V_HAN_SU_DUNG_Load);
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //
        #region events
        private void frm_V_HAN_SU_DUNG_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
                m_cbo_thoi_gian.Focus();
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
                insert_v_han_su_dung();
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
                update_v_han_su_dung();
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
                delete_v_han_su_dung();
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
                view_v_han_su_dung();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        private void m_cmd_tim_kiem_Click(object sender, EventArgs e)
        {
            US_V_HAN_SU_DUNG v_us_v_han_su_dung =new US_V_HAN_SU_DUNG();
            DS_V_HAN_SU_DUNG v_ds_v_han_su_dung=new DS_V_HAN_SU_DUNG();
            if (m_cbo_thoi_gian.Text == "Dưới 1 tháng")
            {
                v_us_v_han_su_dung.FillDataset(v_ds_v_han_su_dung, "where DATEDIFF(day,GETDATE(),CONVERT(datetime,HAN_SD,103))<30 AND DATEDIFF(day,GETDATE(),CONVERT(datetime,HAN_SD,103))>=0 AND SO_DU>0 ORDER BY HAN_SD");
            }
            if (m_cbo_thoi_gian.Text == "Từ  1 tháng đến 3 tháng")
            {
                v_us_v_han_su_dung.FillDataset(v_ds_v_han_su_dung, "where DATEDIFF(day,GETDATE(),CONVERT(datetime,HAN_SD,103))>=30 AND DATEDIFF(day,GETDATE(),CONVERT(datetime,HAN_SD,103))<=90 AND SO_DU>0 ORDER BY HAN_SD");
            }
            if (m_cbo_thoi_gian.Text == "Trên 3 tháng")
            {
                v_us_v_han_su_dung.FillDataset(v_ds_v_han_su_dung, "where DATEDIFF(day,GETDATE(),CONVERT(datetime,HAN_SD,103))>90 AND SO_DU>0 ORDER BY HAN_SD");
            }
            m_grv_han_su_dung.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_v_han_su_dung, m_grv_han_su_dung, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_grv_han_su_dung);
            m_grv_han_su_dung.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
              , 0
              , (int)e_col_Number.HAN_SD // chỗ này là tên trường mà mình nhóm
              , (int)e_col_Number.TEN_THUOC // chỗ này là tên trường mà mình Count
              , "{0}"
              );
            m_lbl_count.Text = m_ds.V_HAN_SU_DUNG.Count.ToString(CultureInfo.InvariantCulture);
            m_grv_han_su_dung.Redraw = true;

        }

        private void m_cbo_thoi_gian_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    US_V_HAN_SU_DUNG v_us_v_han_su_dung = new US_V_HAN_SU_DUNG();
                    DS_V_HAN_SU_DUNG v_ds_v_han_su_dung = new DS_V_HAN_SU_DUNG();
                    if (m_cbo_thoi_gian.Text == "Dưới 1 tháng")
                    {
                        v_us_v_han_su_dung.FillDataset(v_ds_v_han_su_dung, "where DATEDIFF(day,GETDATE(),CONVERT(datetime,HAN_SD,103))<30 AND DATEDIFF(day,GETDATE(),CONVERT(datetime,HAN_SD,103))>=0 AND SO_DU>0 ORDER BY HAN_SD");
                    }
                    if (m_cbo_thoi_gian.Text == "Từ  1 tháng đến 3 tháng")
                    {
                        v_us_v_han_su_dung.FillDataset(v_ds_v_han_su_dung, "where DATEDIFF(day,GETDATE(),CONVERT(datetime,HAN_SD,103))>=30 AND DATEDIFF(day,GETDATE(),CONVERT(datetime,HAN_SD,103))<=90 AND SO_DU>0 ORDER BY HAN_SD");
                    }
                    if (m_cbo_thoi_gian.Text == "Trên 3 tháng")
                    {
                        v_us_v_han_su_dung.FillDataset(v_ds_v_han_su_dung, "where DATEDIFF(day,GETDATE(),CONVERT(datetime,HAN_SD,103))>90 AND SO_DU>0 ORDER BY HAN_SD");
                    }
                    m_grv_han_su_dung.Redraw = false;
                    CGridUtils.Dataset2C1Grid(v_ds_v_han_su_dung, m_grv_han_su_dung, m_obj_trans);
                    CGridUtils.MakeSoTT(0, m_grv_han_su_dung);
                    m_grv_han_su_dung.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
                      , 0
                      , (int)e_col_Number.HAN_SD // chỗ này là tên trường mà mình nhóm
                      , (int)e_col_Number.TEN_THUOC // chỗ này là tên trường mà mình Count
                      , "{0}"
                      );
                    m_lbl_count.Text = v_ds_v_han_su_dung.V_HAN_SU_DUNG.Count.ToString(CultureInfo.InvariantCulture);
                    m_grv_han_su_dung.Redraw = true;
                }

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }    
    }
}
