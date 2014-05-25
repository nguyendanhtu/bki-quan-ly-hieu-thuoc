using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPException;
using IP.Core.IPData;
using IP.Core.IPUserService;
using IP.Core.IPSystemAdmin;

using BKI_QLHT.US;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;

using C1.Win.C1FlexGrid;
using BKI_QLHT;
using System.Reflection;
using System.Collections.Generic;

namespace BKI_QLHT
{
    public partial class f521_thong_tin_lien_he : Form
    {
        public f521_thong_tin_lien_he()
        {
            InitializeComponent();
            format_control();
        }
        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            set_define_events();
            this.Text = "F521_Thông tin liên hệ";
        }

        private void set_define_events()
        {
            m_cmd_tro_ve.Click += new EventHandler(m_cmd_tro_ve_Click);
        }

        #endregion
        #region Events
        private void m_cmd_tro_ve_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
