using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLHT.DS;
using BKI_QLHT.US;
using BKI_QLHT.DS.CDBNames;
using IP.Core.IPCommon;
using IP.Core.IPData;
using IP.Core.IPUserService;
using System.IO;

namespace BKI_QLHT.DanhMuc
{
    public partial class f404_v_dm_nhasx_detail : Form
    {
        #region Public Interface
                public f404_v_dm_nhasx_detail()
        {
            InitializeComponent();
            format_control();
        }
        public void get_us(ref US_DM_NCC_NSX_NHASX op_us)
        {
            op_us = m_us;
        }
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;

            this.ShowDialog();
        }
        public void display_for_update(US_DM_NCC_NSX_NHASX ip_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = ip_us;
            us_object_2_form(m_us);
            this.ShowDialog();
        }
        #endregion
        #region Members
        private DataEntryFormMode m_e_form_mode;
        private US_DM_NCC_NSX_NHASX m_us_1= new US_DM_NCC_NSX_NHASX();
        private US_V_DM_NHASX m_v_us = new US_V_DM_NHASX();
        private DS_V_DM_NHASX m_v_ds = new DS_V_DM_NHASX();
        private US_DM_NCC_NSX_NHASX m_us = new US_DM_NCC_NSX_NHASX();
        private DS_DM_NCC_NSX_NHASX m_ds = new DS_DM_NCC_NSX_NHASX();
        #endregion
        #region Private Methods
        private void refresh_control()
        {
            if (m_e_form_mode == DataEntryFormMode.InsertDataState)
            {
                m_txt_diachi.Text = "";
                m_txt_ma_nhasx.Text = "";
                m_txt_sdt.Text = "";
                m_txt_ten_nhasx.Text = "";

            }
            else
                us_object_2_form(m_us_1);
        }

        private void us_object_2_form(US_DM_NCC_NSX_NHASX ip_us_v_dm_nhasx)
        {
            //m_us.dcID = ip_us_v_dm_nhasx.dcID;
            m_txt_ten_nhasx.Text = ip_us_v_dm_nhasx.strTEN_NCC;
            m_txt_sdt.Text=ip_us_v_dm_nhasx.strSDT;
            m_txt_ma_nhasx.Text = ip_us_v_dm_nhasx.strMA_NCC;
            m_txt_diachi.Text=ip_us_v_dm_nhasx.strDIA_CHI;
            
            
        }
        //private void us_object_2_form(US_DM_NCC_NSX_NHASX ip_us_v_dm_nhasx)
        //{
        //    m_us.dcID = ip_us_v_dm_nhasx.dcID;
        //    m_txt_ten_nhasx.Text = ip_us_v_dm_nhasx.strTEN_NCC;
        //    m_txt_sdt.Text = ip_us_v_dm_nhasx.strSDT;
        //    m_txt_ma_nhasx.Text = ip_us_v_dm_nhasx.strMA_NCC;
        //    m_txt_diachi.Text = ip_us_v_dm_nhasx.strDIA_CHI;
                //}
        private void format_control()
        {
            CControlFormat.setFormStyle(this);
            set_define_events();


        }
        private bool check_data_is_ok()
        {
            if (!CValidateTextBox.IsValid(m_txt_ma_nhasx, DataType.StringType, allowNull.NO, true))
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập mã nhà sản xuất");
                //    return false;
                return false;
            }
            
            return true;
        }
        private void form_2_us_object()
        {
            m_us.strDIA_CHI=m_txt_diachi.Text.Trim();
            m_us.strMA_NCC=m_txt_ma_nhasx.Text.Trim();
            m_us.strSDT=m_txt_sdt.Text.Trim();
            m_us.strTEN_NCC=m_txt_ten_nhasx.Text.Trim();
            
        }

        private void save_data()
        {
            //form_2_us_object();
            switch (m_e_form_mode)
            {

                case DataEntryFormMode.UpdateDataState:
                    if (check_data_is_ok() == false)

                        return;

                    else
                    {
                        form_2_us_object();
                        m_us.Update();
                    }

                    break;
                case DataEntryFormMode.InsertDataState:
                    
                    //if (check_trung_ma_nhasx(m_txt_ma_nhasx.Text))
                    //{
                    //    BaseMessages.MsgBox_Error(217);
                    //    m_txt_ma_nhasx.BackColor = Color.Bisque;
                    //    m_txt_ma_nhasx.Focus();
                    //    m_txt_ma_nhasx.SelectAll();
                    //    return;
                    //}
                    //else
                    {
                        m_txt_ma_nhasx.BackColor = Color.White;
                        if (check_data_is_ok() == false)
                            return;
                        else
                        {
                            form_2_us_object();
                            m_us.Insert();
                        }

                    }

                    break;
                default: break;
            }
            BaseMessages.MsgBox_Infor("Cập nhật dữ liệu thành công!");
            this.Close();
        }
        
        //private bool check_trung_ma_nhasx(string ip_str_ma_nhasx)
        //{
        //    DS_V_DM_NHASX v_ds = new DS_V_DM_NHASX();
    
        //    decimal count_ma_nhasx;
        //    m_v_us.FillDataset_By_Ma_nhasx(v_ds, ip_str_ma_nhasx);
        //    count_ma_nhasx = v_ds.V_DM_NHASX.Count;
        //    if (count_ma_nhasx > 0)
        //        return true;
        //    return false;
        //}
       

        private void fomat_control()
        {
            CControlFormat.setFormStyle(this);
            set_define_events();
        }
        private void refresh()
        {
            try
            {
                refresh_control();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion
        #region Events
        private void set_define_events()
        {
            //this.Load += new System.EventHandler(this.f503_v_dm_thuoc_de_Load);
            this.m_cmd_save.Click += new EventHandler(m_cmd_save_Click);
            this.m_cmd_refresh.Click += new EventHandler(m_cmd_refresh_Click);
            this.m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
        }

        protected void m_cmd_save_Click(object sender, EventArgs e)
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

        protected void m_cmd_refresh_Click(object sender, EventArgs e)
        {
            try
            {
                refresh();
            }
            catch (Exception v_e)
            {
                
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        protected void m_cmd_exit_Click(object sender, EventArgs e)
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

