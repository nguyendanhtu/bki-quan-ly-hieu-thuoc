using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPData;
using IP.Core.IPUserService;
using BKI_QLHT.US;
using BKI_QLHT.DS.CDBNames;
using BKI_QLHT.DS;
using IP.Core.IPSystemAdmin;


namespace BKI_QLHT
{
    public partial class f516_v_dm_benh_vien_de : Form
    {
        public f516_v_dm_benh_vien_de()
        {
            InitializeComponent();
            format_control();
        }

        #region Member
        US_CM_DM_TU_DIEN m_us_tu_dien = new US_CM_DM_TU_DIEN();
        DS_CM_DM_TU_DIEN m_ds_tu_dien = new DS_CM_DM_TU_DIEN();
        DS_V_DM_BENH_VIEN m_ds_v = new DS_V_DM_BENH_VIEN();
        US_V_DM_BENH_VIEN m_us_v = new US_V_DM_BENH_VIEN();
        DataEntryFormMode m_e_for_mode = DataEntryFormMode.InsertDataState;
        #endregion
        #region Public interface
        public void display_for_insert()
        {
            m_e_for_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_V_DM_BENH_VIEN ip_us_v)
        {
            m_e_for_mode = DataEntryFormMode.UpdateDataState;
            us_obj_2_form(ip_us_v);
            this.ShowDialog();
        }
        #endregion

        #region Private method
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            set_define_events();
        }

        private void set_define_events()
        {
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            this.m_cmd_huy.Click += new System.EventHandler(this.m_cmd_huy_Click);
        }
        private void us_obj_2_form(US_V_DM_BENH_VIEN ip_us_v)
        {
            m_us_tu_dien.dcID = ip_us_v.dcID;
            m_txt_ma_benh_vien.Text = ip_us_v.strMA_TU_DIEN;
            m_txt_ten_benh_vien.Text = ip_us_v.strTEN_NGAN;
            m_txt_so_dien_thoai.Text = ip_us_v.strTEN;
            m_txt_dia_chi.Text = ip_us_v.strGHI_CHU;
        }
        private void form_2_us_obj() 
        {
            m_us_tu_dien.dcID_LOAI_TU_DIEN = ID_LOAI_TU_DIEN.BENH_VIEN;
            m_us_tu_dien.strMA_TU_DIEN = m_txt_ma_benh_vien.Text;
            m_us_tu_dien.strTEN_NGAN = m_txt_ten_benh_vien.Text;
            m_us_tu_dien.strTEN = m_txt_so_dien_thoai.Text;
            m_us_tu_dien.strGHI_CHU = m_txt_dia_chi.Text;
        }
        private void save_data() 
        {
            if (!check_validate()) return;
            form_2_us_obj();
            switch (m_e_for_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_tu_dien.Insert();
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_tu_dien.Update();
                    break;

            }
            xoa_trang();
            BaseMessages.MsgBox_Infor("Cập nhật thành công");
            this.Close();
        }

        private void xoa_trang()
        {
            m_txt_ma_benh_vien.Clear();
            m_txt_ten_benh_vien.Clear();
            m_txt_so_dien_thoai.Clear();
            m_txt_dia_chi.Clear();
        }

        private bool check_validate()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_benh_vien, DataType.StringType, allowNull.NO, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_ten_benh_vien, DataType.StringType, allowNull.NO, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_so_dien_thoai, DataType.StringType, allowNull.NO, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_dia_chi, DataType.StringType, allowNull.NO, true)) return false;
            return true;
        }
        
        #endregion

        

        #region Event
        //private void f516_v_dm_benh_vien_de_Load(object sender, EventArgs e)
        //{

        //}

        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_huy_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion



    }
}
