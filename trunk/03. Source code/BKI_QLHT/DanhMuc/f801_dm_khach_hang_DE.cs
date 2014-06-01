using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLHT.US;
using IP.Core.IPCommon;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;
using IP.Core.IPSystemAdmin;
namespace BKI_QLHT
{
    public partial class f801_dm_khach_hang_DE : Form
    {
        public f801_dm_khach_hang_DE()
        {
            InitializeComponent();
            format_controls();
            Load_Data_to_m_cbo_nhom_khach_hang();
        }

        
        #region public interfaces
        public void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
            this.ShowDialog();

        }
        public void display_for_update(US_V_DM_KHACH_HANG m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_dm_khach_hang.dcID = m_us.dcID;
            m_us_dm_khach_hang.strTEN_KHACH_HANG = m_us.strTEN_KHACH_HANG;
            m_us_dm_khach_hang.strMA_KHACH_HANG = m_us.strMA_KHACH_HANG;
            m_us_dm_khach_hang.strSDT = m_us.strSDT;
            m_us_dm_khach_hang.strMA_SO_THUE = m_us.strMA_SO_THUE;
            m_us_dm_khach_hang.strDIA_CHI = m_us.strDIA_CHI;
            m_us_dm_khach_hang.dcID_NHOM_KHACH_HANG = m_us.dcID_NHOM_KHACH_HANG;
            us_obj_2_form();
            this.ShowDialog();
            m_txt_ten_khach_hang.Focus();
        }
        public void get_us(ref US_DM_KHACH_HANG op_us)
        {
            op_us = m_us_dm_khach_hang;
        }
        
        #endregion


        #region members
        DataEntryFormMode m_e_form_mode;
        US_DM_KHACH_HANG m_us_dm_khach_hang = new US_DM_KHACH_HANG();
        #endregion


        #region private methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }
       private void form_2_us_obj()
        {
            m_us_dm_khach_hang.strTEN_KHACH_HANG = m_txt_ten_khach_hang.Text;
            m_us_dm_khach_hang.strMA_KHACH_HANG = "KH_" + m_txt_so_dien_thoai.Text;
            m_us_dm_khach_hang.strDIA_CHI = m_txt_dia_chi.Text;
            m_us_dm_khach_hang.strSDT = m_txt_so_dien_thoai.Text;
            m_us_dm_khach_hang.strMA_SO_THUE = m_txt_ma_so_thue.Text;
            m_us_dm_khach_hang.dcID_NHOM_KHACH_HANG = CIPConvert.ToDecimal(m_cbo_nhom_khach_hang.SelectedValue);
        }
       private void us_obj_2_form()
        {
            m_txt_ten_khach_hang.Text = m_us_dm_khach_hang.strTEN_KHACH_HANG;
            m_txt_so_dien_thoai.Text = m_us_dm_khach_hang.strSDT;
            m_txt_dia_chi.Text = m_us_dm_khach_hang.strDIA_CHI;
            m_txt_ma_so_thue.Text = m_us_dm_khach_hang.strMA_SO_THUE;
            m_cbo_nhom_khach_hang.SelectedValue = m_us_dm_khach_hang.dcID_NHOM_KHACH_HANG;
        }
       private void Load_Data_to_m_cbo_nhom_khach_hang()
       {
           US_DM_NHOM_KHACH_HANG v_us = new US_DM_NHOM_KHACH_HANG();
           DS_DM_NHOM_KHACH_HANG v_ds = new DS_DM_NHOM_KHACH_HANG();
           v_us.FillDataset(v_ds);
           m_cbo_nhom_khach_hang.DataSource = v_ds.Tables[0];
           m_cbo_nhom_khach_hang.ValueMember = DM_NHOM_KHACH_HANG.ID;
           m_cbo_nhom_khach_hang.DisplayMember = DM_NHOM_KHACH_HANG.TEN_NHOM;
       }
       private int check_validate()
       {
           if (m_txt_ten_khach_hang.Text == "")
           {
               return 1;
           }
           if (m_txt_so_dien_thoai.Text == "")
           {
               return 2;
           }
           return 0;
       }

        #endregion

      

        #region events
       private void m_cmd_save_Click(object sender, EventArgs e)
       {
           try
           {
               if (check_validate() == 1)
               {
                   BaseMessages.MsgBox_Infor("Bạn chưa nhập tên khách hàng");
                   m_txt_ten_khach_hang.Focus();
               }
               else
               {
                   if (check_validate() == 2)
                   {
                       BaseMessages.MsgBox_Infor("Bạn chưa nhập số điện thoại");
                       m_txt_so_dien_thoai.Focus();
                   }
                   else
                   {
                       switch (m_e_form_mode)
                       {
                           case DataEntryFormMode.InsertDataState:
                               form_2_us_obj();
                               DS_DM_KHACH_HANG v_ds_dm_khach_hang = new DS_DM_KHACH_HANG();
                               US_DM_KHACH_HANG v_us_dm_hang_sx = new US_DM_KHACH_HANG();
                               v_us_dm_hang_sx.FillDatasetSearchByMaKH(v_ds_dm_khach_hang, m_us_dm_khach_hang.strMA_KHACH_HANG);
                               if (v_ds_dm_khach_hang.DM_KHACH_HANG.Count == 0)
                               {
                                   m_us_dm_khach_hang.Insert();
                                   BaseMessages.MsgBox_Infor("Thêm mới thành công");
                                   this.Close();
                               }
                               else
                               {
                                   BaseMessages.MsgBox_Infor("Số điện thoại này đã được sử dụng. Vui lòng nhập lại");
                                   m_txt_so_dien_thoai.Focus();
                               }
                               break;
                           case DataEntryFormMode.SelectDataState:
                               break;
                           case DataEntryFormMode.UpdateDataState:
                               m_us_dm_khach_hang = new US_DM_KHACH_HANG(m_us_dm_khach_hang.dcID);
                               if (m_us_dm_khach_hang.strMA_KHACH_HANG != "KH_" + m_txt_so_dien_thoai.Text)
                               {
                                   form_2_us_obj();
                                   DS_DM_KHACH_HANG v_ds = new DS_DM_KHACH_HANG();
                                   US_DM_KHACH_HANG v_us = new US_DM_KHACH_HANG();
                                   v_us.FillDatasetSearchByMaKH(v_ds, m_us_dm_khach_hang.strMA_KHACH_HANG);
                                   if (v_ds.DM_KHACH_HANG.Count == 0)
                                   {
                                       m_us_dm_khach_hang.Update();
                                       BaseMessages.MsgBox_Infor("Thay đổi thành công");
                                       this.Close();
                                   }
                                   else
                                   {
                                       BaseMessages.MsgBox_Infor("Số điện thoại này đã được sử dụng. Vui lòng nhập lại");
                                       m_txt_so_dien_thoai.Focus();
                                   }
                               }
                               else
                               {
                                   form_2_us_obj();
                                    m_us_dm_khach_hang.Update();
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
       private void m_cmd_exit_Click(object sender, EventArgs e)
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
       private void m_txt_ten_khach_hang_KeyUp(object sender, KeyEventArgs e)
       {
           try
           {
               if (e.KeyCode == Keys.Enter)
               {
                   m_txt_so_dien_thoai.Focus();
               }
           }
           catch(Exception v_e)
           {
               CSystemLog_301.ExceptionHandle(v_e);
           }

       }

       private void m_txt_so_dien_thoai_KeyUp(object sender, KeyEventArgs e)
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

       private void m_txt_dia_chi_KeyUp(object sender, KeyEventArgs e)
       {
           try
           {
               if (e.KeyCode == Keys.Enter)
               {
                   m_txt_ma_so_thue.Focus();
               }
           }
           catch (Exception v_e)
           {
               CSystemLog_301.ExceptionHandle(v_e);
           }
       }

       private void m_txt_ma_so_thue_KeyUp(object sender, KeyEventArgs e)
       {
           try
           {
               if (e.KeyCode == Keys.Enter)
               {
                   m_cbo_nhom_khach_hang.Focus();
               }
           }
           catch (Exception v_e)
           {
               CSystemLog_301.ExceptionHandle(v_e);
           }
       }

       private void m_cbo_nhom_khach_hang_KeyUp(object sender, KeyEventArgs e)
       {
           try
           {
               if (e.KeyCode == Keys.Enter)
               {
                   if (check_validate() == 1)
                   {
                       BaseMessages.MsgBox_Infor("Bạn chưa nhập tên khách hàng");
                       m_txt_ten_khach_hang.Focus();
                   }
                   else
                   {
                       if (check_validate() == 2)
                       {
                           BaseMessages.MsgBox_Infor("Bạn chưa nhập số điện thoại");
                           m_txt_so_dien_thoai.Focus();
                       }
                       else
                       {
                           switch (m_e_form_mode)
                           {
                               case DataEntryFormMode.InsertDataState:
                                   form_2_us_obj();
                                   DS_DM_KHACH_HANG v_ds_dm_khach_hang = new DS_DM_KHACH_HANG();
                                   US_DM_KHACH_HANG v_us_dm_hang_sx = new US_DM_KHACH_HANG();
                                   v_us_dm_hang_sx.FillDatasetSearchByMaKH(v_ds_dm_khach_hang, m_us_dm_khach_hang.strMA_KHACH_HANG);
                                   if (v_ds_dm_khach_hang.DM_KHACH_HANG.Count == 0)
                                   {
                                       m_us_dm_khach_hang.Insert();
                                       BaseMessages.MsgBox_Infor("Thêm mới thành công");
                                       this.Close();
                                   }
                                   else
                                   {
                                       BaseMessages.MsgBox_Infor("Số điện thoại này đã được sử dụng. Vui lòng nhập lại");
                                       m_txt_so_dien_thoai.Focus();
                                   }
                                   break;
                               case DataEntryFormMode.SelectDataState:
                                   break;
                               case DataEntryFormMode.UpdateDataState:
                                   m_us_dm_khach_hang = new US_DM_KHACH_HANG(m_us_dm_khach_hang.dcID);
                                   if (m_us_dm_khach_hang.strMA_KHACH_HANG != "KH_" + m_txt_so_dien_thoai.Text)
                                   {
                                       form_2_us_obj();
                                       DS_DM_KHACH_HANG v_ds = new DS_DM_KHACH_HANG();
                                       US_DM_KHACH_HANG v_us = new US_DM_KHACH_HANG();
                                       v_us.FillDatasetSearchByMaKH(v_ds, m_us_dm_khach_hang.strMA_KHACH_HANG);
                                       if (v_ds.DM_KHACH_HANG.Count == 0)
                                       {
                                           m_us_dm_khach_hang.Update();
                                           BaseMessages.MsgBox_Infor("Thay đổi thành công");
                                           this.Close();
                                       }
                                       else
                                       {
                                           BaseMessages.MsgBox_Infor("Số điện thoại này đã được sử dụng. Vui lòng nhập lại");
                                           m_txt_so_dien_thoai.Focus();
                                       }
                                   }
                                   else
                                   {
                                       form_2_us_obj();
                                       m_us_dm_khach_hang.Update();
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
           }
           catch (Exception v_e)
           {
               CSystemLog_301.ExceptionHandle(v_e);
           }
       }

       private void m_txt_so_dien_thoai_KeyPress(object sender, KeyPressEventArgs e)
       {
           if (e.KeyChar < '0' || e.KeyChar > '9')
           {
               if (e.KeyChar != (char)8 && !Char.IsControl(e.KeyChar))
               {
                   BaseMessages.MsgBox_Infor("Bạn đã nhập chữ '" + e.KeyChar + "'..Xin vui lòng chỉ nhập số");
                   e.KeyChar = (char)0;
               }
           }
       }
        #endregion

       

    }
}
