using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

            this.reportViewer1.RefreshReport();
        }
    }
}
