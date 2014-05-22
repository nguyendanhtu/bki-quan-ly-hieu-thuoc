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

namespace BKI_QLHT.HeThong
{
    public partial class f901_phan_quyen_su_dung_form_cho_nhom_nguoi_su_dung : Form
    {
        public f901_phan_quyen_su_dung_form_cho_nhom_nguoi_su_dung()
        {
            InitializeComponent();
            set_define_events();
        }

        #region Public Interface

        #endregion

        #region Data Structures

        #endregion

        #region Members
        DS_HT_FORM m_ds_ht_form = new DS_HT_FORM();
        DS_HT_FORM m_ds_ht_form_duoc_dung = new DS_HT_FORM();
        US_HT_FORM m_us_ht_form = new US_HT_FORM();
        #endregion

        #region Private Methods
        private void set_inital_form_load()
        {
            load_data_to_cbo_nhom_nguoi_su_dung();
            load_data_to_lst_danh_sach_form();
            load_data_to_lst_danh_sach_form_duoc_su_dung();
        }
        private void set_define_events()
        {
            this.Load += f901_phan_quyen_su_dung_form_cho_nhom_nguoi_su_dung_Load;
            m_cmd_left_2_right.Click += m_cmd_left_2_right_Click;
            m_cmd_left_2_right_all.Click += m_cmd_left_2_right_all_Click;
            m_cmd_right_2_left.Click += m_cmd_right_2_left_Click;
            m_cmd_right_2_left_all.Click += m_cmd_right_2_left_all_Click;
        }



        private void load_data_to_cbo_nhom_nguoi_su_dung()
        {
            US_HT_USER_GROUP v_us_ht_user_group = new US_HT_USER_GROUP();
            DS_HT_USER_GROUP v_ds_ht_user_group = new DS_HT_USER_GROUP();
            v_us_ht_user_group.FillDataset(v_ds_ht_user_group, "order by user_group_name");
            m_cbo_nhom_nguoi_su_dung.DisplayMember = HT_USER_GROUP.USER_GROUP_NAME;
            m_cbo_nhom_nguoi_su_dung.ValueMember = HT_USER_GROUP.ID;
            m_cbo_nhom_nguoi_su_dung.DataSource = v_ds_ht_user_group.HT_USER_GROUP;
        }
        private void load_data_to_lst_danh_sach_form_duoc_su_dung()
        {
            m_lst_danh_sach_form_duoc_dung.DisplayMember = HT_FORM.DISPLAY_NAME;
            m_lst_danh_sach_form_duoc_dung.ValueMember = HT_FORM.ID;
            m_ds_ht_form_duoc_dung.HT_FORM.DefaultView.Sort="display_name asc";
            m_lst_danh_sach_form_duoc_dung.DataSource = m_ds_ht_form_duoc_dung.HT_FORM;
        }
        private void load_data_to_2_dataset_danh_sach_form()
        {
            m_us_ht_form.FillDataset(m_ds_ht_form, "order by display_name");
        }
        private void load_data_to_lst_danh_sach_form()
        {
           
            m_lst_danh_sach_form.DisplayMember = HT_FORM.DISPLAY_NAME;
            m_lst_danh_sach_form.ValueMember = HT_FORM.ID;
            m_lst_danh_sach_form.DataSource = m_ds_ht_form.HT_FORM;
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
                var query = from dm_form in m_ds_ht_form.Tables[0].AsEnumerable()
                            where dm_form["ID"].ToString() ==
                           ((DataRowView)m_lst_danh_sach_form.SelectedItem)["ID"].ToString()
                            select dm_form;
                DataRow[] rows = query.ToArray<DataRow>();
                foreach (DataRow v_dr in rows)
                {
                    DataRow v_dr_form = m_ds_ht_form_duoc_dung.Tables[0].NewRow();
                    v_dr_form["ID"] = CIPConvert.ToDecimal(v_dr["ID"]);
                    v_dr_form["FORM_NAME"] = v_dr["FORM_NAME"].ToString();
                    v_dr_form["DISPLAY_NAME"] = v_dr["DISPLAY_NAME"].ToString();
                    m_ds_ht_form_duoc_dung.Tables["HT_FORM"].Rows.Add(v_dr_form);
                    m_ds_ht_form.Tables["HT_FORM"].Rows.Remove(v_dr);
                }
                load_data_to_lst_danh_sach_form_duoc_su_dung();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
    }
}
