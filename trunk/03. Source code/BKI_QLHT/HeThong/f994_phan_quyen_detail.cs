using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;
using BKI_QLHT.US;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;
using IP.Core.IPUserService;
using IP.Core.IPData;

namespace BKI_QLHT
{
    public partial class f994_phan_quyen_detail : Form
    {


        public f994_phan_quyen_detail()
        {
            InitializeComponent();
            format_control();
        }


        private void load_data_to_cbo_form_name()
        {
            US_HT_FORM v_us_ht_form = new US_HT_FORM();
            DS_HT_FORM v_ds_ht_form = new DS_HT_FORM();
            v_us_ht_form.FillDataset(v_ds_ht_form,
                "where form_name like N'%" + m_txt_loc_form.Text.Trim()
            + "%' or display_name like N'%" + m_txt_loc_form.Text.Trim()
            + "%' order by form_name");
            if (v_ds_ht_form.HT_FORM.Count < 1)
            {
                m_cbo_form_name.DataSource = null;
                m_cbo_form_name.ValueMember = HT_FORM.FORM_NAME;
                m_cbo_form_name.DisplayMember = HT_FORM.FORM_NAME;
            }
            else
            {
                m_cbo_form_name.DataSource = v_ds_ht_form.HT_FORM;
                m_cbo_form_name.ValueMember = HT_FORM.FORM_NAME;
                m_cbo_form_name.DisplayMember = HT_FORM.FORM_NAME;
            }
        }
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_cmd_save_Click(object sender, EventArgs e)
        {



            US_V_HT_CONTROL_IN_FORM v_us = new US_V_HT_CONTROL_IN_FORM();
            DS_V_HT_CONTROL_IN_FORM v_ds = new DS_V_HT_CONTROL_IN_FORM();

            v_us.FillDatasetByIdChucNangAndFormName(v_ds, CIPConvert.ToDecimal(m_cbo_chuc_nang.SelectedValue),
              m_cbo_form_name.SelectedValue.ToString());

            US_HT_PHAN_QUYEN_DETAIL v_us_ht_pq_detail;
            for (int i = 0; i < v_ds.Tables[0].Rows.Count; i++)
            {
                v_us_ht_pq_detail = new US_HT_PHAN_QUYEN_DETAIL();
                DataRow v_dr = v_ds.Tables[0].Rows[i];
                v_us_ht_pq_detail.dcID_PHAN_QUYEN_HT = CIPConvert.ToDecimal(m_cbo_nhom_quyen.SelectedValue);
                v_us_ht_pq_detail.strCONTROL_NAME = v_dr[V_HT_CONTROL_IN_FORM.CONTROL_NAME].ToString();
                v_us_ht_pq_detail.strCONTROL_TYPE = v_dr[V_HT_CONTROL_IN_FORM.CONTROL_TYPE].ToString();
                v_us_ht_pq_detail.strENABLED_YN = "Y";
                v_us_ht_pq_detail.strFORM_NAME = v_dr[V_HT_CONTROL_IN_FORM.FORM_NAME].ToString();
                v_us_ht_pq_detail.strVISIBLE_YN = "Y";
                //kiem tra xem da luu control chua, neu co roi thi khong them control nay nua
                if (m_cbo_form_name.SelectedValue != null && m_cbo_chuc_nang.SelectedValue != null)
                {
                    US_HT_PHAN_QUYEN_DETAIL v_us_ht_phan_quyen_detail = new US_HT_PHAN_QUYEN_DETAIL();
                    DS_HT_PHAN_QUYEN_DETAIL v_ds_ht_phan_quyen_detail = new DS_HT_PHAN_QUYEN_DETAIL();
                    v_us_ht_phan_quyen_detail.FillDataset(v_ds_ht_phan_quyen_detail, "where form_name='"
                        + ((DataRowView)m_cbo_form_name.Items[m_cbo_form_name.SelectedIndex])[HT_FORM.FORM_NAME].ToString()
                        + "' and id_phan_quyen_ht=" + m_cbo_chuc_nang.SelectedValue
                        + "and control_name='" + v_us_ht_pq_detail.strCONTROL_NAME
                        + "' and control_type='" + v_us_ht_pq_detail.strCONTROL_TYPE + "'");
                    if (v_ds_ht_phan_quyen_detail.HT_PHAN_QUYEN_DETAIL.Count == 0)
                        v_us_ht_pq_detail.Insert();
                }

            }
            BaseMessages.MsgBox_Infor("Dữ liệu đã được cập nhật");
            //   this.Close();
        }

        private void f994_phan_quyen_detail_Load(object sender, EventArgs e)
        {
            load_data_to_cbo_form_name();
            load_data_2_cbo_nhom_quyen();
            load_data_2_cbo_chuc_nang();
        }

        private void load_data_2_cbo_chuc_nang()
        {
            US_CM_DM_TU_DIEN v_us = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds = new DS_CM_DM_TU_DIEN();
            v_us.FillDatasetByIdLoaiTuDien(v_ds, 1);//3 là id loại từ điển phân quyền
            m_cbo_chuc_nang.DataSource = v_ds.Tables[0];
            m_cbo_chuc_nang.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_chuc_nang.DisplayMember = CM_DM_TU_DIEN.TEN_NGAN;
        }

        private void load_data_2_cbo_nhom_quyen()
        {
            US_HT_PHAN_QUYEN_HE_THONG v_us = new US_HT_PHAN_QUYEN_HE_THONG();
            DS_HT_PHAN_QUYEN_HE_THONG v_ds = new DS_HT_PHAN_QUYEN_HE_THONG();
            v_us.FillDataset(v_ds);
            m_cbo_nhom_quyen.DataSource = v_ds.Tables[0];
            m_cbo_nhom_quyen.ValueMember = HT_PHAN_QUYEN_HE_THONG.ID;
            m_cbo_nhom_quyen.DisplayMember = HT_PHAN_QUYEN_HE_THONG.MA_PHAN_QUYEN;
        }

        private void m_cmd_chon_form_Click(object sender, EventArgs e)
        {
            f990_ht_form v_frm = new f990_ht_form();
            v_frm.show_2_choose(this);
        }

        private void m_txt_loc_form_TextChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_to_cbo_form_name();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_loc_form_Enter(object sender, EventArgs e)
        {
            try
            {
                m_txt_loc_form.Text = "";
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
