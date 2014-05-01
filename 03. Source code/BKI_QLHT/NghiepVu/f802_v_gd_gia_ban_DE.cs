using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using BKI_QLHT.DS;
using BKI_QLHT.US;
using BKI_QLHT.DS.CDBNames;
using IP.Core.IPSystemAdmin;

namespace BKI_QLHT
{
    public partial class f802_v_gd_gia_ban_DE : Form
    {
        public f802_v_gd_gia_ban_DE()
        {
            InitializeComponent();
            format_controls();
        }

        #region public interfaces
        public void display_for_update(US_V_GD_GIA_BAN m_us)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_v_gd_gia_ban = m_us;
            m_us_gd_gia_ban = new US_GD_GIA_BAN(m_us.dcID);
            us_obj_2_form();
            this.ShowDialog();
        }

        
        #endregion


        #region members
        DataEntryFormMode m_e_form_mode;
        US_GD_GIA_BAN m_us_gd_gia_ban = new US_GD_GIA_BAN();
        US_V_GD_GIA_BAN m_us_v_gd_gia_ban = new US_V_GD_GIA_BAN();
        DS_GD_GIA_BAN m_ds_gd_gia_ban = new DS_GD_GIA_BAN();
        #endregion


        #region private methods
        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }
        private void us_obj_2_form()
        {
            m_lbl_ten_thuoc.Text = m_us_v_gd_gia_ban.strTEN_THUOC;
            m_txt_gia.Text = m_us_v_gd_gia_ban.dcGIA_BAN.ToString();
            m_lbl_ten_don_vi.Text = m_us_v_gd_gia_ban.strTEN_DON_VI;
            m_lbl_gia_cu.Text = m_us_v_gd_gia_ban.dcGIA_BAN.ToString();
        }

        private void form_2_us_obj()
        {
            m_us_gd_gia_ban.dcGIA_BAN =CIPConvert.ToDecimal(m_txt_gia.Text);
        }
        #endregion

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            form_2_us_obj();
            switch (m_e_form_mode)
            {
                case DataEntryFormMode.InsertDataState:
                    break;
                case DataEntryFormMode.SelectDataState:
                    break;
                case DataEntryFormMode.UpdateDataState:
                    m_us_gd_gia_ban.Update();
                    this.Close();
                    break;
                case DataEntryFormMode.ViewDataState:
                    break;
                default:
                    break;
            }
        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region events

        #endregion
    }
}
