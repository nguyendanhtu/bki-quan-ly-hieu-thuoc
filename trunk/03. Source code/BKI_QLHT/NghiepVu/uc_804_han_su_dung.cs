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
            tdvsd = 3
,
            tdvgd = 4
                ,
            HAN_SU_DUNG = 5
                ,
            TEN_THUOC = 1
                , SO_DU = 2

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
            m_fg.Tree.Column = (int)e_col_Number.TEN_THUOC;
            m_fg.Cols[(int)e_col_Number.tdvsd].Visible = false;
            //m_fg.Cols[(int)e_col_Number.TEN_DANH_MUC].Visible = false;
            //m_fg.Cols[0].Caption = "STT";
            //m_fg.Cols[6].Caption = "Số dư";
            m_fg.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.SimpleLeaf;
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
            //v_htb.Add(V_HAN_SU_DUNG.tdvsd, e_col_Number.tdvsd);
            //v_htb.Add(V_HAN_SU_DUNG.tdvgd, e_col_Number.tdvgd);
            v_htb.Add(V_HAN_SU_DUNG.HAN_SU_DUNG, e_col_Number.HAN_SU_DUNG);
            v_htb.Add(V_HAN_SU_DUNG.TEN_THUOC, e_col_Number.TEN_THUOC);
            v_htb.Add(V_HAN_SU_DUNG.SO_DU, e_col_Number.SO_DU);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_HAN_SU_DUNG.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_HAN_SU_DUNG();
            m_us.dcSO_DU = m_us.dcSO_LUONG_NHAP - m_us.dcSO_LUONG_BAN;
            m_us.FillDataset(m_ds);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
              , 0
              , (int)e_col_Number.TEN_THUOC // chỗ này là tên trường mà mình nhóm
              , (int)e_col_Number.SO_DU // chỗ này là tên trường mà mình Count
              , "{0}"
              );
            m_fg.Redraw = true;
        }
        private void grid2us_object(US_V_HAN_SU_DUNG i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_HAN_SU_DUNG i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
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
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
            //	frm_V_HAN_SU_DUNG_DE v_fDE = new frm_V_HAN_SU_DUNG_DE();
            //	v_fDE.display(m_us);
            load_data_2_grid();
        }

        private void delete_v_han_su_dung()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_V_HAN_SU_DUNG v_us = new US_V_HAN_SU_DUNG();
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

        private void view_v_han_su_dung()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            grid2us_object(m_us, m_fg.Row);
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
                v_us_v_han_su_dung.FillDataset(v_ds_v_han_su_dung, "where DATEDIFF(month,GETDATE(),HAN_SU_DUNG)<1 AND DATEDIFF(month,GETDATE(),HAN_SU_DUNG)>=0");
            }
            if (m_cbo_thoi_gian.Text == "Từ  1 tháng đến 3 tháng")
            {
                v_us_v_han_su_dung.FillDataset(v_ds_v_han_su_dung, "where DATEDIFF(month,GETDATE(),HAN_SU_DUNG)>=1 AND DATEDIFF(month,GETDATE(),HAN_SU_DUNG)<=3");
            }
            if (m_cbo_thoi_gian.Text == "Trên 3 tháng")
            {
                v_us_v_han_su_dung.FillDataset(v_ds_v_han_su_dung, "where DATEDIFF(month,GETDATE(),HAN_SU_DUNG)>3");
            }
            m_grv_han_su_dung.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_v_han_su_dung, m_grv_han_su_dung, m_obj_trans);
            m_grv_han_su_dung.Redraw = true;

        }

        
    }
}
