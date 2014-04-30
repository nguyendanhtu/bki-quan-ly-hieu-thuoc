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

        private void format_control()
        {
            //CControlFormat.setFormStyle(this);
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            m_fg.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //CControlFormat.setC1FlexFormat(m_fg);
            set_define_events();
            //this.KeyPreview = true;
            load_cbo_ten_khach_hang();
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
