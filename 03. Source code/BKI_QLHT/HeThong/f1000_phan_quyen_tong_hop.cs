using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IP.Core.IPCommon;

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
    }
}
