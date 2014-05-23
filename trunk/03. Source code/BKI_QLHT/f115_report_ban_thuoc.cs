//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows.Forms;

//using BKI_QLHT.DS;
//using BKI_QLHT.US;
//namespace BKI_QLHT
//{
//    public partial class f115_report_ban_thuoc : Form
//    {
//        public f115_report_ban_thuoc()
//        {
//            InitializeComponent();
//        }

//        private void f115_report_ban_thuoc_Load(object sender, EventArgs e)
//        {
            
//        }
    
//        public void display_for_print(decimal m_id_giao_dich)
//        {
//            this.V_GD_GIAO_DICH_DETAILTableAdapter.Fill(this.BKI_QLHT_REPORT_BAN_THUOC.V_GD_GIAO_DICH_DETAIL,m_id_giao_dich);
//            this.reportViewer1.RefreshReport();
//            this.Show();
//        }
//    }
//}
