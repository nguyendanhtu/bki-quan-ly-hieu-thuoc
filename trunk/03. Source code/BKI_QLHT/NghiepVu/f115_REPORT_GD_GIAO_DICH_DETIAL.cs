using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BKI_QLHT.DanhMuc
{
    public partial class f115_REPORT_GD_GIAO_DICH_DETIAL : Form
    {
        public f115_REPORT_GD_GIAO_DICH_DETIAL()
        {
            InitializeComponent();
        }

        private void f115_REPORT_GD_GIAO_DICH_DETIAL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bKI_QLHTDataSet2.V_GD_GIAO_DICH_DETAIL' table. You can move, or remove it, as needed.
            this.v_GD_GIAO_DICH_DETAILTableAdapter.Fill(this.bKI_QLHTDataSet2.V_GD_GIAO_DICH_DETAIL);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
