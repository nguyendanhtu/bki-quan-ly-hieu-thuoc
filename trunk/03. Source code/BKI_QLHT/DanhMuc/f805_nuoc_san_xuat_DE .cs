﻿using System;
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
    public partial class f805_nuoc_san_xuat_DE : Form
    {
        public f805_nuoc_san_xuat_DE()
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
        #endregion


        #region members
        DataEntryFormMode m_e_form_mode;
        US_V_DM_NCC_NSX_NHASX_1 m_us_v_dm_ncc = new US_V_DM_NCC_NSX_NHASX_1();
        DS_V_DM_NCC_NSX_NHASX_1 m_ds_v_dm_ncc = new DS_V_DM_NCC_NSX_NHASX_1();
        US_DM_NCC_NSX_NHASX m_us_dm_ncc = new US_DM_NCC_NSX_NHASX();
        internal ImageList ImageList;
        private IContainer components;
        private Label label1;
        internal SIS.Controls.Button.SiSButton m_cmd_thoat;
        private Panel m_pnl_control;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
        private TextBox m_txt_sdt;
        DS_DM_NCC_NSX_NHASX m_ds_dm_ncc = new DS_DM_NCC_NSX_NHASX();
        #endregion
        

        #region private methods
        private bool check_validate()
        {
            if (!CValidateTextBox.IsValid(m_txt_ten_nha_cung_cap, DataType.StringType, allowNull.NO, true)) return false;
            return true;
        }
        private void form_2_us_obj()
        {
            m_us_dm_ncc.strTEN_NCC =m_txt_ten_nha_cung_cap.Text ;
            m_us_dm_ncc.strSDT = m_txt_sdt.Text;
            m_us_dm_ncc.dcID_LOAI_DM = 2;
        }
        private void us_obj_2_form()
        {
            m_txt_ten_nha_cung_cap.Text = m_us_dm_ncc.strTEN_NCC;
            m_txt_sdt.Text = m_us_dm_ncc.strSDT;
        }
        private void defineEvent()
        {
            
        }
        private void save_data()
        {
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    m_us_dm_ncc.Insert();
                    this.Close();
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_dm_ncc.Update();
                    this.Close();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
        }

        #endregion


        #region events  
        private void m_txt_sdt_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (check_validate())
                    {
                        save_data();
                    }
                    else
                    {
                        BaseMessages.MsgBox_Infor("Bạn cần nhập tên nước sản xuất");
                    }
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
                    m_txt_sdt.Focus();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_save_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (check_validate())
                {
                    form_2_us_obj();
                    switch (m_e_form_mode)
                    {
                        case DataEntryFormMode.InsertDataState:
                            m_us_dm_ncc.Insert();
                            this.Close();
                            break;
                        case DataEntryFormMode.SelectDataState:
                            break;
                        case DataEntryFormMode.UpdateDataState:
                            m_us_dm_ncc.Update();
                            this.Close();
                            break;
                        case DataEntryFormMode.ViewDataState:
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    BaseMessages.MsgBox_Infor("Bạn cần nhập tên nước sản xuất");
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

        #endregion

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f805_nuoc_san_xuat_DE));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.m_cmd_thoat = new SIS.Controls.Button.SiSButton();
            this.m_pnl_control = new System.Windows.Forms.Panel();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.m_txt_sdt = new System.Windows.Forms.TextBox();
            this.m_txt_ten_nha_cung_cap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_pnl_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(213, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thông tin nước sản xuất";
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_thoat.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_thoat.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_thoat.ImageIndex = 12;
            this.m_cmd_thoat.ImageList = this.ImageList;
            this.m_cmd_thoat.Location = new System.Drawing.Point(389, 22);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_thoat.TabIndex = 4;
            this.m_cmd_thoat.Text = "Thoát (Esc)";
            this.m_cmd_thoat.Click += new System.EventHandler(this.m_cmd_thoat_Click_1);
            // 
            // m_pnl_control
            // 
            this.m_pnl_control.Controls.Add(this.m_cmd_save);
            this.m_pnl_control.Controls.Add(this.m_cmd_thoat);
            this.m_pnl_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_control.Location = new System.Drawing.Point(0, 184);
            this.m_pnl_control.Name = "m_pnl_control";
            this.m_pnl_control.Size = new System.Drawing.Size(612, 72);
            this.m_pnl_control.TabIndex = 24;
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_save.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_save.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_save.ImageIndex = 10;
            this.m_cmd_save.ImageList = this.ImageList;
            this.m_cmd_save.Location = new System.Drawing.Point(98, 22);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_save.TabIndex = 3;
            this.m_cmd_save.Text = "Lưu";
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click_1);
            // 
            // m_txt_sdt
            // 
            this.m_txt_sdt.Location = new System.Drawing.Point(207, 137);
            this.m_txt_sdt.Name = "m_txt_sdt";
            this.m_txt_sdt.Size = new System.Drawing.Size(284, 20);
            this.m_txt_sdt.TabIndex = 2;
            this.m_txt_sdt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.m_txt_sdt_KeyUp);
            // 
            // m_txt_ten_nha_cung_cap
            // 
            this.m_txt_ten_nha_cung_cap.Location = new System.Drawing.Point(207, 83);
            this.m_txt_ten_nha_cung_cap.Name = "m_txt_ten_nha_cung_cap";
            this.m_txt_ten_nha_cung_cap.Size = new System.Drawing.Size(284, 20);
            this.m_txt_ten_nha_cung_cap.TabIndex = 1;
            this.m_txt_ten_nha_cung_cap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.m_txt_ten_nha_cung_cap_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.Location = new System.Drawing.Point(133, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(69, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên nước sản xuất";
            // 
            // f805_nuoc_san_xuat_DE
            // 
            this.ClientSize = new System.Drawing.Size(612, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_pnl_control);
            this.Controls.Add(this.m_txt_sdt);
            this.Controls.Add(this.m_txt_ten_nha_cung_cap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "f805_nuoc_san_xuat_DE";
            this.m_pnl_control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private TextBox m_txt_ten_nha_cung_cap;
        private Label label5;
        private Label label2;

       

        
        

    }
}