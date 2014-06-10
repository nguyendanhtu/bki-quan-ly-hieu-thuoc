using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPUserService;
using IP.Core.IPData;
using IP.Core.IPSystemAdmin;
using IP.Core.IPCommon;
using IP.Core.IPException;
//using IP.Core.IPUserService;
using IP.Core.IPData;
using IP.Core.IPData.DBNames;
using IP.Core.IPSystemAdmin;
using BKI_QLHT;
using BKI_QLHT.DS.CDBNames;
using BKI_QLHT.DS;
using BKI_QLHT.US;

namespace BKI_QLHT.HeThong
{
    public partial class F168_Phan_quyen_he_thong : Form
    {
        public F168_Phan_quyen_he_thong()
        {
            InitializeComponent();
            format_control();
        }

      
        #region Members
        US_HT_PHAN_QUYEN m_us_user = new US_HT_PHAN_QUYEN();
        DataEntryFormMode m_e_form_mode;
        #endregion

        #region Private method
        private void format_control()
        {
            set_inital_form_load();
            set_define_events();
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }
        private void set_inital_form_load()
        {
            load_data_2_cbo_user_group();
            load_data_to_lst_danh_sach_form();
            
        }
         
        private void load_data_2_cbo_user_group()
        {
            US_HT_USER_GROUP v_us = new US_HT_USER_GROUP();
            DS_HT_USER_GROUP v_ds = new DS_HT_USER_GROUP();
            v_us.FillDataset(v_ds);
            m_cbo_nhom_nguoi_su_dung.ValueMember = HT_USER_GROUP.ID;
            m_cbo_nhom_nguoi_su_dung.DisplayMember = HT_USER_GROUP.USER_GROUP_NAME;
            m_cbo_nhom_nguoi_su_dung.DataSource = v_ds.HT_USER_GROUP;            
        }
        private void load_data_to_lst_danh_sach_form()
        {
            US_HT_FORM v_us_ht_form = new US_HT_FORM();
            DS_HT_FORM v_ds_ht_form = new DS_HT_FORM();
            v_us_ht_form.FillDataset(v_ds_ht_form, "order by DISPLAY_NAME");
            m_lst_danh_sach_form.DisplayMember = HT_FORM.DISPLAY_NAME;
            m_lst_danh_sach_form.ValueMember = HT_FORM.ID;
            m_lst_danh_sach_form.DataSource = v_ds_ht_form.HT_FORM;
        }
        private void load_data_to_lst_danh_sach_control_by_form(decimal v_id_form, decimal v_id_user_group)
        {
            //m_lst_dang_sach_control.Items.Clear();
            US_HT_FORM_CONTROL v_us = new US_HT_FORM_CONTROL();
            DS_HT_FORM_CONTROL v_ds = new DS_HT_FORM_CONTROL();
            v_us.FillDataset(v_ds, " WHERE ID_FORM = " + v_id_form + " AND ID not in (select ID_CONTROL FROM HT_PHAN_QUYEN WHERE ID_USER_GROUP = " + v_id_user_group + ") order by CONTROL_DISPLAY");
            m_lst_dang_sach_control.DisplayMember = HT_FORM_CONTROL.CONTROL_DISPLAY;
            m_lst_dang_sach_control.ValueMember = HT_FORM_CONTROL.ID;
            m_lst_dang_sach_control.DataSource = v_ds.HT_FORM_CONTROL;
        }
        private void load_data_to_lst_danh_sach_control_by_form_dadung(decimal v_id_form, decimal v_id_user_group)
        {
            //m_lst_dang_sach_control.Items.Clear();
            BKI_QLHT.US.US_V_HT_PHAN_QUYEN v_us = new BKI_QLHT.US.US_V_HT_PHAN_QUYEN();
            BKI_QLHT.DS.DS_V_HT_PHAN_QUYEN v_ds = new BKI_QLHT.DS.DS_V_HT_PHAN_QUYEN();
            v_us.FillDataset(v_ds, " WHERE ID_USER_GROUP = " + v_id_user_group + " AND ID_FORM = " + v_id_form + " order by CONTROL_DISPLAY");
            m_lst_danh_sach_form_duoc_dung.DisplayMember = V_HT_PHAN_QUYEN.CONTROL_DISPLAY;
            m_lst_danh_sach_form_duoc_dung.ValueMember = V_HT_PHAN_QUYEN.ID_QUYEN;
            m_lst_danh_sach_form_duoc_dung.DataSource = v_ds.V_HT_PHAN_QUYEN;
        }
        private void load_control_to_form()
        {
            decimal v_id_form = (decimal)m_lst_danh_sach_form.SelectedValue;
            decimal v_id_user_group = (decimal)m_cbo_nhom_nguoi_su_dung.SelectedValue;
            load_data_to_lst_danh_sach_control_by_form(v_id_form, v_id_user_group);
            load_data_to_lst_danh_sach_control_by_form_dadung(v_id_form, v_id_user_group);
        }
        private void get_control_left_2_right()
        {
            US_HT_PHAN_QUYEN v_us = new US_HT_PHAN_QUYEN();
            decimal v_id_control = (decimal)m_lst_dang_sach_control.SelectedValue;
            decimal v_id_user_group = (decimal)m_cbo_nhom_nguoi_su_dung.SelectedValue;
            v_us.dcID_CONTROL = v_id_control;
            v_us.dcID_USER_GROUP = v_id_user_group;
            v_us.Insert();
        }
        private void get_control_all_left_2_right()
        {
            decimal v_id_user_group = (decimal)m_cbo_nhom_nguoi_su_dung.SelectedValue;
            foreach (DataRowView item in m_lst_dang_sach_control.Items)
            {
                decimal v_id_control = CIPConvert.ToDecimal((item)[V_HT_FORM_CONTROL.ID]);
                US_HT_PHAN_QUYEN v_us = new US_HT_PHAN_QUYEN();
                v_us.dcID_CONTROL = v_id_control;
                v_us.dcID_USER_GROUP = v_id_user_group;
                v_us.Insert();
            }
            
        }
        private void get_control_right_2_left()
        {
            US_HT_PHAN_QUYEN v_us = new US_HT_PHAN_QUYEN();
            decimal v_id_control = (decimal)m_lst_danh_sach_form_duoc_dung.SelectedValue;
            
            v_us.dcID = v_id_control;
            v_us.Delete();
        }
        private void get_control_all_right_2_left()
        {
            
            foreach (DataRowView item in m_lst_danh_sach_form_duoc_dung.Items)
            {
                decimal v_id_control = CIPConvert.ToDecimal((item)[V_HT_PHAN_QUYEN.ID_QUYEN]);
                US_HT_PHAN_QUYEN v_us = new US_HT_PHAN_QUYEN();
                v_us.dcID = v_id_control;
                v_us.Delete();
            }

        }
        #endregion

        #region Event
        private void set_define_events()
        {
            this.Load += new EventHandler(F168_Phan_quyen_he_thong_Load);
            m_lst_danh_sach_form.SelectedValueChanged += new EventHandler(m_lst_danh_sach_form_SelectedValueChanged);
            m_cbo_nhom_nguoi_su_dung.SelectedValueChanged += new EventHandler(m_cbo_nhom_nguoi_su_dung_SelectedValueChanged);
            m_cmd_left_2_right.Click += new EventHandler(m_cmd_left_2_right_Click);
            m_cmd_left_2_right_all.Click += new EventHandler(m_cmd_left_2_right_all_Click);
            m_cmd_right_2_left.Click += new EventHandler(m_cmd_right_2_left_Click);
            m_cmd_right_2_left_all.Click+=new EventHandler(m_cmd_right_2_left_all_Click);
        }

        void m_cmd_right_2_left_all_Click(object sender, EventArgs e)
        {
            try
            {
                get_control_all_right_2_left();
                load_control_to_form();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_right_2_left_Click(object sender, EventArgs e)
        {
            try
            {
                get_control_right_2_left();
                load_control_to_form();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_left_2_right_all_Click(object sender, EventArgs e)
        {
            try
            {
                get_control_all_left_2_right();
                load_control_to_form();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_cmd_left_2_right_Click(object sender, EventArgs e)
        {
            try
            {
                get_control_left_2_right();
                load_control_to_form();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        void m_cbo_nhom_nguoi_su_dung_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                load_control_to_form();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        void m_lst_danh_sach_form_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                load_control_to_form();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void F168_Phan_quyen_he_thong_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
