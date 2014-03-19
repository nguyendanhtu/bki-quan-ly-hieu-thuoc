using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using BKI_QLHT;
using BKI_QLHT.DS;
using BKI_QLHT.US;
using IP.Core.IPCommon;
using IP.Core.IPExcelReport;
using IP.Core.IPSystemAdmin;
using BKI_QLHT.HeThong;

namespace BKI_QLHT
{
    public partial class f400_Main : Form
    {
        public f400_Main()
        {
            InitializeComponent();
            format_controls();
        }

        #region Public Interface

        public void display(ref IPConstants.HowUserWantTo_Exit_MainForm v_exitmode)
        {
            try
            {
                ShowDialog();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        #endregion

        #region Private Method

        private void format_controls()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            set_define_events();
            ShowInTaskbar = true;
        }

        #endregion

        // Event handlers

        private void set_define_events()
        {
            this.Load += new System.EventHandler(this.f400_Main_Load);
        }
        private void f400_Main_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        
    }
}
