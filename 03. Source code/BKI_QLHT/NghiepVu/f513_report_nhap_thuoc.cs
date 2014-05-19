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
    public partial class f513_report_nhap_thuoc : Form
    {
        public f513_report_nhap_thuoc()
        {
            InitializeComponent();
        }

        private void f513_report_nhap_thuoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BKI_QLHTDataSet3.V_GD_GIAO_DICH_NHAP_THUOC_DETAIL' table. You can move, or remove it, as needed.

           
        }
        public void display_form_print_nhap_thuoc(decimal ip_id_giao_dich)
        {

            this.V_GD_GIAO_DICH_NHAP_THUOC_DETAILTableAdapter.Fill(this.BKI_QLHTDataSet3.V_GD_GIAO_DICH_NHAP_THUOC_DETAIL,ip_id_giao_dich);

            this.reportViewer1.RefreshReport();
            this.Show();
        }
    }
}
