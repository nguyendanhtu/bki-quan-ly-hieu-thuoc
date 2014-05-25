using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;

using BKI_QLHT.DS;
using BKI_QLHT.US;
using BKI_QLHT.DS.CDBNames;

using C1.Win.C1FlexGrid;
using IP.Core.IPSystemAdmin;

namespace BKI_QLHT.NghiepVu
{
    public partial class uc808_canh_bao_thuoc_sap_het_han : UserControl
    {
        public uc808_canh_bao_thuoc_sap_het_han()
        {
            InitializeComponent();
            load_thuoc_sap_het_han();
            format_controls();
        }

        private void format_controls()
        {
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            
        }

        private void load_thuoc_sap_het_han()
        {
            US_V_HAN_SU_DUNG v_us = new US_V_HAN_SU_DUNG();
            DS_V_HAN_SU_DUNG v_ds = new DS_V_HAN_SU_DUNG();
            v_us.FillDataset(v_ds, "where DATEDIFF(day,GETDATE(),CONVERT(datetime,HAN_SD,103))>=0 AND SO_DU>0 ORDER BY HAN_SD");
            switch (v_ds.Tables[0].Rows.Count)
            {
                case 0: BaseMessages.MsgBox_Infor("Không có thuốc sắp hết hạn trong 3 tháng tới"); break;
                case 1:
                m_lbl_thuoc_1.Text= CIPConvert.ToStr(v_ds.Tables[0].Rows[0]["TEN_THUOC"]);
            m_lbl_hsd_1.Text = CIPConvert.ToStr(v_ds.Tables[0].Rows[0]["HAN_SD"]);
            m_lbl_hsd_2.Text = "";
            m_lbl_hsd_3.Text = "";
            m_lbl_thuoc_2.Text = "";
            m_lbl_thuoc_3.Text = "";break;
                case 2:
                     m_lbl_thuoc_1.Text= CIPConvert.ToStr(v_ds.Tables[0].Rows[0]["TEN_THUOC"]);
            m_lbl_hsd_1.Text = CIPConvert.ToStr(v_ds.Tables[0].Rows[0]["HAN_SD"]);
            m_lbl_thuoc_2.Text = CIPConvert.ToStr(v_ds.Tables[0].Rows[1]["TEN_THUOC"]);
            m_lbl_hsd_2.Text = CIPConvert.ToStr(v_ds.Tables[0].Rows[1]["HAN_SD"]);
            m_lbl_hsd_3.Text = "";
            m_lbl_thuoc_3.Text = "";break;
                default:
            m_lbl_thuoc_1.Text= CIPConvert.ToStr(v_ds.Tables[0].Rows[0]["TEN_THUOC"]);
            m_lbl_hsd_1.Text = CIPConvert.ToStr(v_ds.Tables[0].Rows[0]["HAN_SD"]);
            m_lbl_thuoc_2.Text = CIPConvert.ToStr(v_ds.Tables[0].Rows[1]["TEN_THUOC"]);
            m_lbl_hsd_2.Text = CIPConvert.ToStr(v_ds.Tables[0].Rows[1]["HAN_SD"]);
            m_lbl_hsd_3.Text = CIPConvert.ToStr(v_ds.Tables[0].Rows[2]["HAN_SD"]);
            m_lbl_thuoc_3.Text = CIPConvert.ToStr(v_ds.Tables[0].Rows[2]["TEN_THUOC"]);
            break;
            }
            
            
        }


        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                //m_Panel_Content.Controls.Clear();
                //uc_802_gd_gia_ban uc_frm = new uc_802_gd_gia_ban();
                //uc_frm.Dock = System.Windows.Forms.DockStyle.Fill;
                //m_Panel_Content.Controls.Add(uc_frm);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

    }
}
