using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_QLHT
{
    public partial class f115_report_ban_thuoc : Form
    {
        public f115_report_ban_thuoc()
        {
            InitializeComponent();
        }

        private void f115_report_ban_thuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BKI_QLHT_REPORT_BAN_THUOC.V_GD_GIAO_DICH_DETAIL' table. You can move, or remove it, as needed.
            this.V_GD_GIAO_DICH_DETAILTableAdapter.Fill(this.BKI_QLHT_REPORT_BAN_THUOC.V_GD_GIAO_DICH_DETAIL);

            this.reportViewer1.RefreshReport();
        }
    }
}
