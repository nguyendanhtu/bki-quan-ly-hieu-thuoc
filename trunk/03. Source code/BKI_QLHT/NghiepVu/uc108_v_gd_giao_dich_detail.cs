using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPSystemAdmin;
using IP.Core.IPCommon;

namespace BKI_QLHT.NghiepVu
{
    public partial class uc108_v_gd_giao_dich_detail : UserControl
    {
        public uc108_v_gd_giao_dich_detail()
        {
            InitializeComponent();
            format_control();
        }

        private void format_control()
        {
            //CControlFormat.setFormStyle(this);
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            //CControlFormat.setC1FlexFormat(m_fg);
            set_define_events();
            //this.KeyPreview = true;
        }

        private void set_define_events()
        {
            
        }


       

   

  
    }
}
