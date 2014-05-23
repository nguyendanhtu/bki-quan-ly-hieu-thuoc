using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BKI_QLHT.DS;
using BKI_QLHT.US;
using BKI_QLHT.DS.CDBNames;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

namespace BKI_QLHT.DanhMuc
{
    public partial class f106_dm_don_vi_kinh_doanh : Form
    {
        public f106_dm_don_vi_kinh_doanh()
        {
            InitializeComponent();
            format_control();
        }

        #region Public interface

        #endregion

        #region Members
        US_DM_DON_VI_KINH_DOANH m_us_don_vi_kinh_doanh = new US_DM_DON_VI_KINH_DOANH();
        DS_DM_DON_VI_KINH_DOANH m_ds_don_vi_kinh_doanh = new DS_DM_DON_VI_KINH_DOANH();
        #endregion

        #region Private method
        private void format_control()
        {
            Load_data_2_form();
        }

        private void Load_data_2_form()
        {
            m_us_don_vi_kinh_doanh.FillDataset(m_ds_don_vi_kinh_doanh);
            m_lbl_ma_nha_thuoc.Text = m_ds_don_vi_kinh_doanh.Tables[0].Rows[0]["MA_VIET_TAT"].ToString();
            m_txt_ten_nha_thuoc.Text = m_ds_don_vi_kinh_doanh.Tables[0].Rows[0][2].ToString();
            m_txt_dia_chi.Text = m_ds_don_vi_kinh_doanh.Tables[0].Rows[0][4].ToString();
            m_txt_ma_so_thue.Text = m_ds_don_vi_kinh_doanh.Tables[0].Rows[0][3].ToString();
            m_txt_so_dien_thoai.Text = m_ds_don_vi_kinh_doanh.Tables[0].Rows[0][5].ToString();
            m_txt_ghi_chu.Text = m_ds_don_vi_kinh_doanh.Tables[0].Rows[0][6].ToString();
        }
        private bool check_validate()
        {
            if (!CValidateTextBox.IsValid(m_txt_ten_nha_thuoc, DataType.StringType, allowNull.NO, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_ma_so_thue, DataType.StringType, allowNull.NO, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_dia_chi, DataType.StringType, allowNull.NO, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_so_dien_thoai, DataType.StringType, allowNull.NO, true)) return false;
            return true;
        }

        #endregion



        private void update_don_vi_kinh_doanh()
        {
            m_form_2_us();
            m_us_don_vi_kinh_doanh.Update();
        }

        private void m_form_2_us()
        {
            m_us_don_vi_kinh_doanh.strTEN_DAY_DU = m_txt_ten_nha_thuoc.Text;
            m_us_don_vi_kinh_doanh.strDIA_CHI = m_txt_dia_chi.Text;
            m_us_don_vi_kinh_doanh.strMA_SO_THUE = m_txt_ma_so_thue.Text;
            m_us_don_vi_kinh_doanh.strSDT = m_txt_so_dien_thoai.Text;
            m_us_don_vi_kinh_doanh.strGHI_CHU_2 = m_txt_ghi_chu.Text;
        }



        #region Event
        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            if (!check_validate()) { BaseMessages.MsgBox_Error("Bạn chưa nhập đủ dữ liệu"); return; };
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu lại cập nhật không?",
                "Quản lý bán thuốc", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    update_don_vi_kinh_doanh();
                    BaseMessages.MsgBox_Infor("Đã lưu cập nhật");
                    return;
                }
                if (result == DialogResult.No)
                {
                    return;
                }

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }


        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
