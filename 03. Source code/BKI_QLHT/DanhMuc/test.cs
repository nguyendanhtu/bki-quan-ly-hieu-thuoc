using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLHT.US;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;

namespace BKI_QLHT.DanhMuc
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }
        private void test_Load(object sender, EventArgs e)
        {
            load_data_to_text_box_search();
        }

        private void load_data_to_text_box_search()
        {
            US_DM_THUOC v_us = new US_DM_THUOC();
            DS_DM_THUOC v_ds = new DS_DM_THUOC();
            v_us.FillDataset(v_ds);
            m_txts_ten_thuoc.load_data_to_list(v_ds, DM_THUOC.TEN_THUOC, DM_THUOC.ID);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_data_to_text_box_search();
        }


    }
}
