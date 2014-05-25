using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPData;
using IP.Core.IPUserService;
using BKI_QLHT.US;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;
using IP.Core.IPCommon;
using System.Collections;
using IP.Core.IPException;
using IP.Core.IPSystemAdmin;

namespace BKI_QLHT.HeThong
{
    public partial class f901_phan_quyen_su_dung_form_cho_nhom_nguoi_su_dung : Form
    {
        public f901_phan_quyen_su_dung_form_cho_nhom_nguoi_su_dung()
        {
            InitializeComponent();
            format_control();
        }

        #region Public Interface

        #endregion

        #region Data Structures
        private enum e_col_Number
        {
            USER_GROUP_NAME = 0,
            DISPLAY_NAME = 1,
            CONTROL_NAME = 2,
            CONTROL_TYPE = 3,
            CONTROL_TEXT = 4,
            CONTROL_DISPLAY = 5
        }
        #endregion

        #region Members
        DS_HT_FORM m_ds_ht_form = new DS_HT_FORM();
        DS_HT_FORM m_ds_ht_form_duoc_dung = new DS_HT_FORM();
        US_HT_FORM m_us_ht_form = new US_HT_FORM();
        ITransferDataRow m_obj_trans;
        DS_V_HT_FORM_CONTROL m_ds_v_ht_form_control = new DS_V_HT_FORM_CONTROL();
        US_V_HT_FORM_CONTROL m_us_v_ht_form_control = new US_V_HT_FORM_CONTROL();

        BKI_QLHT.DS.DS_V_HT_PHAN_QUYEN m_ds_v_ht_phan_quyen = new BKI_QLHT.DS.DS_V_HT_PHAN_QUYEN();
        BKI_QLHT.US.US_V_HT_PHAN_QUYEN m_us_v_ht_phan_quyen = new BKI_QLHT.US.US_V_HT_PHAN_QUYEN();
        #endregion

        #region Private Methods
        private void format_control()
        {
            set_define_events();
            CControlFormat.setC1FlexFormat(m_fg);
            CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
        }
        private void set_inital_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_to_cbo_nhom_nguoi_su_dung();
            load_data_to_lst_danh_sach_form();
            update_data_lst_danh_sach_form_duoc_su_dung();
            load_data_to_lst_form_tab_2();
            //load_data_control_to_data_set();
        }

        private void load_data_control_to_data_set()
        {
            m_us_v_ht_form_control.FillDataset(m_ds_v_ht_form_control);
        }
        private void set_define_events()
        {
            this.Load += f901_phan_quyen_su_dung_form_cho_nhom_nguoi_su_dung_Load;
            m_cmd_left_2_right.Click += m_cmd_left_2_right_Click;
            m_cmd_left_2_right_all.Click += m_cmd_left_2_right_all_Click;
            m_cmd_right_2_left.Click += m_cmd_right_2_left_Click;
            m_cmd_right_2_left_all.Click += m_cmd_right_2_left_all_Click;
            m_lst_form.SelectedIndexChanged += m_lst_form_SelectedIndexChanged;
            m_cmd_them_control.Click += m_cmd_them_control_Click;
            m_cmd_xoa_control.Click += m_cmd_xoa_control_Click;

        }





        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_HT_PHAN_QUYEN.USER_GROUP_NAME, e_col_Number.USER_GROUP_NAME);
            v_htb.Add(V_HT_PHAN_QUYEN.DISPLAY_NAME, e_col_Number.DISPLAY_NAME);
            v_htb.Add(V_HT_PHAN_QUYEN.CONTROL_NAME, e_col_Number.CONTROL_NAME);
            v_htb.Add(V_HT_PHAN_QUYEN.CONTROL_TYPE, e_col_Number.CONTROL_TYPE);
            v_htb.Add(V_HT_PHAN_QUYEN.CONTROL_TEXT, e_col_Number.CONTROL_TEXT);
            v_htb.Add(V_HT_PHAN_QUYEN.CONTROL_DISPLAY, e_col_Number.CONTROL_DISPLAY);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_v_ht_phan_quyen.V_HT_PHAN_QUYEN.NewRow());
            return v_obj_trans;
        }

        private void load_data_to_grid_control()
        {

            if (m_lst_form.SelectedItem != null)
            {
                m_ds_v_ht_phan_quyen.Clear();
                m_us_v_ht_phan_quyen.FillDataset(m_ds_v_ht_phan_quyen, "where id_form="
               + ((DataRowView)m_lst_form.SelectedItem)[V_HT_FORM_CONTROL.ID].ToString()
               + " and id_user_group=" + ((DataRowView)m_cbo_nhom_nguoi_su_dung.SelectedItem)[HT_USER_GROUP.ID].ToString()
               + " order by control_name");
            }
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_v_ht_phan_quyen, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }
        private void load_data_to_lst_control()
        {
            if (m_lst_form.SelectedValue != null)
            {
                m_ds_v_ht_form_control.Clear();
                m_us_v_ht_form_control.FillDataset(m_ds_v_ht_form_control, "where id_form="
                    + ((DataRowView)m_lst_form.SelectedItem)[HT_FORM.ID].ToString()
                    + " and control_name not in(select control_name from v_ht_phan_quyen)"
                    + "order by control_display");
                m_lst_control.DisplayMember = V_HT_FORM_CONTROL.CONTROL_TEXT;
                m_lst_control.ValueMember = V_HT_FORM_CONTROL.ID;
                m_lst_control.DataSource = m_ds_v_ht_form_control.V_HT_FORM_CONTROL;
                load_data_to_grid_control();
            }

        }
        private void load_data_to_lst_form_tab_2()
        {
            m_lst_form.DisplayMember = HT_FORM.DISPLAY_NAME;
            m_lst_form.ValueMember = HT_FORM.ID;
            m_ds_ht_form_duoc_dung.HT_FORM.DefaultView.Sort = "display_name asc";
            m_lst_form.DataSource = m_ds_ht_form_duoc_dung.HT_FORM;
        }
        private void load_data_to_cbo_nhom_nguoi_su_dung()
        {
            US_HT_USER_GROUP v_us_ht_user_group = new US_HT_USER_GROUP();
            BKI_QLHT.DS.DS_HT_USER_GROUP v_ds_ht_user_group = new BKI_QLHT.DS.DS_HT_USER_GROUP();
            v_us_ht_user_group.FillDataset(v_ds_ht_user_group, "order by user_group_name");
            m_cbo_nhom_nguoi_su_dung.DisplayMember = HT_USER_GROUP.USER_GROUP_NAME;
            m_cbo_nhom_nguoi_su_dung.ValueMember = HT_USER_GROUP.ID;
            m_cbo_nhom_nguoi_su_dung.DataSource = v_ds_ht_user_group.HT_USER_GROUP;
        }
        private void update_data_lst_danh_sach_form_duoc_su_dung()
        {
            m_lst_danh_sach_form_duoc_dung.DisplayMember = HT_FORM.DISPLAY_NAME;
            m_lst_danh_sach_form_duoc_dung.ValueMember = HT_FORM.ID;
            m_ds_ht_form_duoc_dung.HT_FORM.DefaultView.Sort = "display_name asc";
            m_lst_danh_sach_form_duoc_dung.DataSource = m_ds_ht_form_duoc_dung.HT_FORM;
        }
        private void update_data_lst_danh_sach_form()
        {
            m_lst_danh_sach_form.DisplayMember = HT_FORM.DISPLAY_NAME;
            m_lst_danh_sach_form.ValueMember = HT_FORM.ID;
            m_ds_ht_form.HT_FORM.DefaultView.Sort = "display_name asc";
            m_lst_danh_sach_form.DataSource = m_ds_ht_form.HT_FORM;
        }
        private void load_data_to_2_dataset_danh_sach_form()
        {
            m_us_ht_form.FillDataset(m_ds_ht_form, "order by display_name");
        }
        private void load_data_to_lst_danh_sach_form()
        {
            m_us_ht_form.FillDataset(m_ds_ht_form, "order by display_name");
            m_lst_danh_sach_form.DisplayMember = HT_FORM.DISPLAY_NAME;
            m_lst_danh_sach_form.ValueMember = HT_FORM.ID;
            m_lst_danh_sach_form.DataSource = m_ds_ht_form.HT_FORM;
        }

        private void grid2us_object(BKI_QLHT.US.US_V_HT_PHAN_QUYEN i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
        private void delete_control()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;

            grid2us_object(m_us_v_ht_phan_quyen, m_fg.Row);
            try
            {
                US_HT_PHAN_QUYEN v_us_ht_phan_quyen = new US_HT_PHAN_QUYEN(m_us_v_ht_phan_quyen.dcID_QUYEN);
                v_us_ht_phan_quyen.BeginTransaction();
                v_us_ht_phan_quyen.Delete();
                v_us_ht_phan_quyen.CommitTransaction();
                m_fg.Rows.Remove(m_fg.Row);
            }
            catch (Exception v_e)
            {
                m_us_v_ht_phan_quyen.Rollback();
                CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                    new CDBClientDBExceptionInterpret());
                v_objErrHandler.showErrorMessage();
            }
        }
        #endregion

        #region Events
        protected void f901_phan_quyen_su_dung_form_cho_nhom_nguoi_su_dung_Load(object sender, EventArgs e)
        {
            try
            {
                set_inital_form_load();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_right_2_left_all_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < m_ds_ht_form_duoc_dung.HT_FORM.Count; i++)
                {
                    DataRow v_dr_form = m_ds_ht_form_duoc_dung.HT_FORM.Rows[i];
                    m_ds_ht_form.HT_FORM.ImportRow(v_dr_form);
                    m_ds_ht_form_duoc_dung.HT_FORM.Rows[i].Delete();
                    m_ds_ht_form_duoc_dung.HT_FORM.AcceptChanges();
                    m_ds_ht_form.HT_FORM.AcceptChanges();
                    update_data_lst_danh_sach_form();
                    //update_data_lst_danh_sach_form_duoc_su_dung();
                }

                if (m_ds_ht_form_duoc_dung.HT_FORM.Count == 0)
                    m_ds_v_ht_form_control.Clear();
                else load_data_to_lst_control();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_right_2_left_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < m_ds_ht_form_duoc_dung.HT_FORM.Count; i++)
                {
                    if (m_ds_ht_form_duoc_dung.HT_FORM.Rows[i][HT_FORM.ID].ToString().Equals(
                        ((DataRowView)m_lst_danh_sach_form_duoc_dung.SelectedItem)[HT_FORM.ID].ToString()))
                    {
                        DataRow v_dr_form = m_ds_ht_form_duoc_dung.HT_FORM.Rows[i];
                        m_ds_ht_form.HT_FORM.ImportRow(v_dr_form);
                        m_ds_ht_form_duoc_dung.HT_FORM.Rows[i].Delete();
                        m_ds_ht_form_duoc_dung.HT_FORM.AcceptChanges();
                        m_ds_ht_form.HT_FORM.AcceptChanges();
                        update_data_lst_danh_sach_form();
                        //update_data_lst_danh_sach_form_duoc_su_dung();
                        break;
                    }
                }

                if (m_ds_ht_form_duoc_dung.HT_FORM.Count == 0)
                    m_ds_v_ht_form_control.Clear();
                else load_data_to_lst_control();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_left_2_right_all_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < m_ds_ht_form.HT_FORM.Count; i++)
                {
                    DataRow v_dr_form = m_ds_ht_form.HT_FORM.Rows[i];
                    m_ds_ht_form_duoc_dung.HT_FORM.ImportRow(v_dr_form);
                    m_ds_ht_form.HT_FORM.Rows[i].Delete();
                    m_ds_ht_form_duoc_dung.HT_FORM.AcceptChanges();
                    m_ds_ht_form.HT_FORM.AcceptChanges();
                    //update_data_lst_danh_sach_form();
                    update_data_lst_danh_sach_form_duoc_su_dung();
                }
                if (m_ds_ht_form_duoc_dung.HT_FORM.Count == 0)
                    m_ds_v_ht_form_control.Clear();
                else load_data_to_lst_control();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_left_2_right_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < m_ds_ht_form.HT_FORM.Count; i++)
                {
                    if (m_ds_ht_form.HT_FORM.Rows[i][HT_FORM.ID].ToString().Equals(
                        ((DataRowView)m_lst_danh_sach_form.SelectedItem)[HT_FORM.ID].ToString()))
                    {
                        DataRow v_dr_form = m_ds_ht_form.HT_FORM.Rows[i];
                        m_ds_ht_form_duoc_dung.HT_FORM.ImportRow(v_dr_form);
                        m_ds_ht_form.HT_FORM.Rows[i].Delete();
                        m_ds_ht_form_duoc_dung.HT_FORM.AcceptChanges();
                        m_ds_ht_form.HT_FORM.AcceptChanges();
                        //update_data_lst_danh_sach_form();
                        update_data_lst_danh_sach_form_duoc_su_dung();
                        break;
                    }
                }
                if (m_ds_ht_form_duoc_dung.HT_FORM.Count == 0)
                    m_ds_v_ht_form_control.Clear();
                else load_data_to_lst_control();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_lst_form_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_to_lst_control();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_xoa_control_Click(object sender, EventArgs e)
        {
            try
            {
                delete_control();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_them_control_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_lst_control.SelectedItem != null)
                {
                    US_HT_PHAN_QUYEN v_us_ht_phan_quyen = new US_HT_PHAN_QUYEN();
                    v_us_ht_phan_quyen.dcID_USER_GROUP = CIPConvert.ToDecimal(((DataRowView)m_cbo_nhom_nguoi_su_dung.SelectedItem)[HT_USER_GROUP.ID]);
                    v_us_ht_phan_quyen.dcID_CONTROL = CIPConvert.ToDecimal(((DataRowView)m_lst_control.SelectedItem)[V_HT_FORM_CONTROL.ID]);
                    DS_HT_PHAN_QUYEN v_ds_ht_phan_quyen = new DS_HT_PHAN_QUYEN();
                    v_us_ht_phan_quyen.FillDataset(v_ds_ht_phan_quyen, "where id_user_group=" + v_us_ht_phan_quyen.dcID_USER_GROUP
                        + " and id_control = " + v_us_ht_phan_quyen.dcID_CONTROL);
                    if (v_ds_ht_phan_quyen.HT_PHAN_QUYEN.Count < 1)
                    {
                        v_us_ht_phan_quyen.Insert();
                        load_data_to_grid_control();
                        BaseMessages.MsgBox_Infor("Bạn đã thêm mới thành công!");
                    }
                    else
                        BaseMessages.MsgBox_Infor("Bạn đã thêm control này rồi!");
                    load_data_to_lst_control();
                }
                else BaseMessages.MsgBox_Infor("Form này không có control mới nào để phân quyền!");

            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
