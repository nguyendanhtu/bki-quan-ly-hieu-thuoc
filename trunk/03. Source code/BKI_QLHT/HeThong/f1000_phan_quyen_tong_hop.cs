using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

namespace BKI_QLHT.HeThong
{
    public partial class f1000_phan_quyen_tong_hop : Form
    {
        public f1000_phan_quyen_tong_hop()
        {
            InitializeComponent();
        }

        private void m_cmd_them_user_Click(object sender, EventArgs e)
        {
            try
            {
                f999_ht_nguoi_su_dung v_frm = new f999_ht_nguoi_su_dung();
                v_frm.Show();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_them_quyen_he_thong_Click(object sender, EventArgs e)
        {
            try
            {
                f993_phan_quyen_he_thong v_frm = new f993_phan_quyen_he_thong();
                v_frm.Show();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_them_chuc_nang_Click(object sender, EventArgs e)
        {
            try
            {
                f100_TuDien v_frm = new f100_TuDien();
                v_frm.Show();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_cap_nhat_danh_sach_form_Click(object sender, EventArgs e)
        {
            try
            {
                f990_ht_form v_frm = new f990_ht_form();
                v_frm.Show();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_loai_control_trong_form_theo_chuc_nang_Click(object sender, EventArgs e)
        {
            try
            {
                f991_v_ht_control_in_form v_frm = new f991_v_ht_control_in_form();
                v_frm.Show();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_phan_quyen_cho_nhom_Click(object sender, EventArgs e)
        {
            try
            {
                f995_ht_phan_quyen_cho_nhom v_frm = new f995_ht_phan_quyen_cho_nhom();
                v_frm.Show();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_thuc_hien_phan_quyen_Click(object sender, EventArgs e)
        {
            try
            {
                f994_phan_quyen_detail v_frm = new f994_phan_quyen_detail();
                v_frm.Show();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
