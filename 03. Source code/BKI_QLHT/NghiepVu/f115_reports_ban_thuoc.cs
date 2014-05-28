using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BKI_QLHT.DS;

namespace BKI_QLHT.NghiepVu
{
    public partial class f115_reports_ban_thuoc : Form
    {
        public f115_reports_ban_thuoc()
        {
            InitializeComponent();
        }

        private void f115_reports_ban_thuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bKI_QLHT_REPORT_BAN_THUOC.V_GD_GIAO_DICH_DETAIL' table. You can move, or remove it, as needed.
           

           
        }

        public void display_for_print(decimal m_id_giao_dich)
        {
            this.V_GD_GIAO_DICH_DETAILTableAdapter.Fill(this.bKI_QLHT_REPORT_BAN_THUOC.V_GD_GIAO_DICH_DETAIL, m_id_giao_dich);
            this.reportViewer1.RefreshReport();
            this.Show();
        }
    }
}
