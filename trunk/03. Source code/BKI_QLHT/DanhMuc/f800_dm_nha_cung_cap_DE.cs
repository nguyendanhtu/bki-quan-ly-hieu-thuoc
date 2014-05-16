using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLHT.US;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;


namespace BKI_QLHT
{
    public partial class f800_dm_nha_cung_cap_DE : Form
    {
        public f800_dm_nha_cung_cap_DE()
        {
            InitializeComponent();
            format_controls();
        }

        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }
        
        #region public interface
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();
        }
        public void display_for_update(US_DM_NCC_NSX_NHASX ip_us_dm_ncc)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_ncc = ip_us_dm_ncc;
            us_obj_2_form();
            this.ShowDialog();
        }
        public void get_us(ref US_DM_NCC_NSX_NHASX op_us)
        {
            op_us = m_us_dm_ncc;
        }
        #endregion


        #region members
        DataEntryFormMode m_e_form_mode;
        US_V_DM_NCC_NSX_NHASX_1 m_us_v_dm_ncc = new US_V_DM_NCC_NSX_NHASX_1();
        DS_V_DM_NCC_NSX_NHASX_1 m_ds_v_dm_ncc = new DS_V_DM_NCC_NSX_NHASX_1();
        US_DM_NCC_NSX_NHASX m_us_dm_ncc = new US_DM_NCC_NSX_NHASX();
        DS_DM_NCC_NSX_NHASX m_ds_dm_ncc = new DS_DM_NCC_NSX_NHASX();
        #endregion
        

        #region private methods
        private int check_validate()
        {
            //if (!CValidateTextBox.IsValid(m_txt_ten_nha_cung_cap, DataType.StringType, allowNull.NO, true)) return false;
            //if (!CValidateTextBox.IsValid(m_txt_sdt, DataType.StringType, allowNull.NO, true)) return false;
            if (m_txt_ten_nha_cung_cap.Text == "")
            {
                return 1;
            }
            if (m_txt_sdt.Text == "")
            {
                return 2;
            }
            return 0;
        }
        private void form_2_us_obj()
        {
            m_us_dm_ncc.strTEN_NCC =m_txt_ten_nha_cung_cap.Text ;
            m_us_dm_ncc.strMA_NCC = "NCC_" + m_txt_sdt.Text;
            m_us_dm_ncc.strSDT = m_txt_sdt.Text;
            m_us_dm_ncc.strDIA_CHI = m_txt_dia_chi.Text;
            m_us_dm_ncc.dcID_LOAI_DM = 1;
        }
        private void us_obj_2_form()
        {
            m_txt_ten_nha_cung_cap.Text = m_us_dm_ncc.strTEN_NCC;
            m_txt_sdt.Text = m_us_dm_ncc.strSDT;
            m_txt_dia_chi.Text = m_us_dm_ncc.strDIA_CHI;
        }
        private void defineEvent()
        {
            
        }
        private void save_data()
        {
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    form_2_us_obj();
                    DS_DM_NCC_NSX_NHASX v_ds_dm_ncc = new DS_DM_NCC_NSX_NHASX();
                    US_DM_NCC_NSX_NHASX v_us_dm_ncc = new US_DM_NCC_NSX_NHASX();
                    v_us_dm_ncc.FillDataseByMaNCC(v_ds_dm_ncc, m_us_dm_ncc.strMA_NCC);
                    if (v_ds_dm_ncc.DM_NCC_NSX_NHASX.Count == 0)
                    {
                        m_us_dm_ncc.Insert();
                        BaseMessages.MsgBox_Infor("Thêm mới thành công");
                        this.Close();
                    }
                    else
                    {
                        BaseMessages.MsgBox_Infor("Số điện thoại này đã được sử dụng. Vui lòng nhập lại");
                        m_txt_sdt.Focus();
                    }
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_ncc = new US_DM_NCC_NSX_NHASX(m_us_dm_ncc.dcID);
                    if (m_us_dm_ncc.strMA_NCC != "NCC_" + m_txt_sdt.Text)
                    {
                        form_2_us_obj();
                        DS_DM_NCC_NSX_NHASX v_ds = new DS_DM_NCC_NSX_NHASX();
                        US_DM_NCC_NSX_NHASX v_us = new US_DM_NCC_NSX_NHASX();
                        v_us.FillDataseByMaNCC(v_ds, m_us_dm_ncc.strMA_NCC);
                        if (v_ds.DM_NCC_NSX_NHASX.Count == 0)
                        {
                            m_us_dm_ncc.Update();
                            BaseMessages.MsgBox_Infor("Thay đổi thành công");
                            this.Close();
                        }
                        else
                        {
                            BaseMessages.MsgBox_Infor("Số điện thoại này đã được sử dụng. Vui lòng nhập lại");
                            m_txt_sdt.Focus();
                        }
                    }
                    else
                    {
                        form_2_us_obj();
                        m_us_dm_ncc.Update();
                        BaseMessages.MsgBox_Infor("Thay đổi thành công");
                        this.Close();
                    }
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
            }
           
        #endregion


        #region events  
        private void m_cmd_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (check_validate()==1)
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập tên nhà cung cấp");
                    m_txt_ten_nha_cung_cap.Focus();
                }
                else
                {
                if(check_validate()==2)
                {
                    BaseMessages.MsgBox_Infor("Bạn chưa nhập số điện thoại");
                    m_txt_sdt.Focus();
                }
                    else
                {
                    switch (m_e_form_mode)
                    {
                        case DataEntryFormMode.InsertDataState:
                            form_2_us_obj();
                            DS_DM_NCC_NSX_NHASX v_ds_dm_ncc = new DS_DM_NCC_NSX_NHASX();
                            US_DM_NCC_NSX_NHASX v_us_dm_ncc= new US_DM_NCC_NSX_NHASX();
                            v_us_dm_ncc.FillDataseByMaNCC(v_ds_dm_ncc, m_us_dm_ncc.strMA_NCC);
                            if (v_ds_dm_ncc.DM_NCC_NSX_NHASX.Count == 0)
                            {
                                m_us_dm_ncc.Insert();
                                BaseMessages.MsgBox_Infor("Thêm mới thành công");
                                this.Close();
                            }
                            else
                            {
                                BaseMessages.MsgBox_Infor("Số điện thoại này đã được sử dụng. Vui lòng nhập lại");
                                m_txt_sdt.Focus();
                            }
                            break;
                        case DataEntryFormMode.SelectDataState:
                            break;
                        case DataEntryFormMode.UpdateDataState:
                            m_us_dm_ncc = new US_DM_NCC_NSX_NHASX(m_us_dm_ncc.dcID);
                            if (m_us_dm_ncc.strMA_NCC != "NCC_" + m_txt_sdt.Text)
                            {
                                form_2_us_obj();
                                DS_DM_NCC_NSX_NHASX v_ds = new DS_DM_NCC_NSX_NHASX();
                                US_DM_NCC_NSX_NHASX v_us = new US_DM_NCC_NSX_NHASX();
                                v_us.FillDataseByMaNCC(v_ds, m_us_dm_ncc.strMA_NCC);
                                if (v_ds.DM_NCC_NSX_NHASX.Count == 0)
                                {
                                    m_us_dm_ncc.Update();
                                    BaseMessages.MsgBox_Infor("Thay đổi thành công");
                                    this.Close();
                                }
                                else
                                {
                                    BaseMessages.MsgBox_Infor("Số điện thoại này đã được sử dụng. Vui lòng nhập lại");
                                    m_txt_sdt.Focus();
                                }
                            }
                            else
                            {
                                form_2_us_obj();
                                m_us_dm_ncc.Update();
                                BaseMessages.MsgBox_Infor("Thay đổi thành công");
                                this.Close();
                            }
                            break;
                        case DataEntryFormMode.ViewDataState:
                            break;
                        default:
                            break;
                    }
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_thoat_Click_1(object sender, EventArgs e)
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

        private void m_txt_sdt_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (check_validate() == 1)
                    {
                        BaseMessages.MsgBox_Infor("Bạn chưa nhập tên nhà cung cấp");
                        m_txt_ten_nha_cung_cap.Focus();
                    }
                    else
                    {
                        if (check_validate() == 2)
                        {
                            BaseMessages.MsgBox_Infor("Bạn chưa nhập số điện thoại");
                            m_txt_sdt.Focus();
                        }
                        else
                        {
                            save_data();
                        }
                    }
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_dia_chi_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    m_txt_sdt.Focus();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_ten_nha_cung_cap_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    m_txt_dia_chi.Focus();
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
