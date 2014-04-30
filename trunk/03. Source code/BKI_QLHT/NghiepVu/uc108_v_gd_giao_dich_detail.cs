using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPSystemAdmin;
using IP.Core.IPCommon;

using BKI_QLHT.US;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;

namespace BKI_QLHT.NghiepVu
{
    public partial class uc108_v_gd_giao_dich_detail : UserControl
    {
        public uc108_v_gd_giao_dich_detail()
        {
            InitializeComponent();
            format_control();
        }
        public String gen_Ma_GD()
        {
            string username = System.IO.File.ReadAllText(@"..\user_login.txt");
            string ydate = DateTime.Now.Year.ToString();
            string mdate = DateTime.Now.Month.ToString();
            string ddate = DateTime.Now.Day.ToString();
            string hdate = DateTime.Now.Hour.ToString();
            string Mdate = DateTime.Now.Minute.ToString();
            string Sdate = DateTime.Now.Second.ToString();
            string datetime = ydate + mdate + ddate + hdate + Mdate + Sdate;
            return "PX_" + username + "_" + datetime;
        }
        private void format_control()
        {
            m_lbl_Ma_GD_text.Text = gen_Ma_GD();
            //CControlFormat.setFormStyle(this);
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            m_fg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //CControlFormat.setC1FlexFormat(m_fg);
            set_define_events();
            //this.KeyPreview = true;
            load_cbo_ten_khach_hang();
            load_cbo_bac_sy();
            load_cbo_don_vi_tinh();
        }

        private void load_cbo_don_vi_tinh()
        {
            US_GD_DON_VI_TINH_THUOC v_us = new US_GD_DON_VI_TINH_THUOC();
            DS_GD_DON_VI_TINH_THUOC v_ds = new DS_GD_DON_VI_TINH_THUOC();
            v_us.FillDataset(v_ds);
            m_cbo_don_vi_tinh.DataSource = v_ds.GD_DON_VI_TINH_THUOC;
            m_cbo_don_vi_tinh.ValueMember = GD_DON_VI_TINH_THUOC.ID;
            m_cbo_don_vi_tinh.DisplayMember = GD_DON_VI_TINH_THUOC.TEN_DON_VI;
        }

        private void load_cbo_bac_sy()
        {
            US_DM_BAC_SY v_us = new US_DM_BAC_SY();
            DS_DM_BAC_SY v_ds = new DS_DM_BAC_SY();
            v_us.FillDataset(v_ds);
            m_cbo_ten_bac_sy.DataSource = v_ds.DM_BAC_SY;
            m_cbo_ten_bac_sy.ValueMember = DM_BAC_SY.ID;
            m_cbo_ten_bac_sy.DisplayMember = DM_BAC_SY.HO_TEN;
            DataRow v_dr = v_ds.DM_BAC_SY.NewRow();
            v_dr[DM_BAC_SY.ID] = -1;
            v_dr[DM_BAC_SY.HO_TEN]="Không theo đơn bác sĩ";
            v_dr[DM_BAC_SY.BENH_VIEN] = 2;
            v_ds.DM_BAC_SY.Rows.InsertAt(v_dr, 0);
            m_cbo_ten_bac_sy.SelectedIndex = 0;
        }

        private void set_define_events()
        {
            
        }

        private void uc_f108_v_gd_giao_dich_detail_Load(object sender, EventArgs e)
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

        private void load_cbo_ten_khach_hang()
        {
            US_DM_KHACH_HANG v_us = new US_DM_KHACH_HANG();
            DS_DM_KHACH_HANG v_ds = new DS_DM_KHACH_HANG();
            v_us.FillDataset(v_ds);
            m_cbo_ten_khach_hang.ValueMember = DM_KHACH_HANG.ID;
            m_cbo_ten_khach_hang.DisplayMember = DM_KHACH_HANG.TEN_KHACH_HANG;
            m_cbo_ten_khach_hang.DataSource = v_ds.DM_KHACH_HANG;
            //m_lbl_dia_chi_text
            m_lbl_dia_chi_text.Text = v_us.strDIA_CHI;
            m_lbl_SDT_text.Text = v_us.strSDT;
        }

       

        private void set_initial_form_load()
        {
            
        }

        private void m_selectIndex_khach_hang(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(m_cbo_ten_khach_hang.SelectedValue) == 1)
            {
                m_lbl_dia_chi.Visible = false;
                m_lbl_dia_chi_text.Visible = false;
                m_lbl_SDT.Visible = false;
                m_lbl_SDT_text.Visible = false;
            }
            else
            {
                m_lbl_dia_chi.Visible = true;
                m_lbl_dia_chi_text.Visible = true;
                m_lbl_SDT.Visible = true;
                m_lbl_SDT_text.Visible = true;
            }
        }

  

       

   

  
    }
}
