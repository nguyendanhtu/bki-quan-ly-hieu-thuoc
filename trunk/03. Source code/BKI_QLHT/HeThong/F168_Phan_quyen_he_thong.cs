using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using IP.Core.IPCommon;
using IP.Core.IPUserService;
using IP.Core.IPData;
using IP.Core.IPSystemAdmin;

namespace BKI_QLHT.HeThong
{
    public partial class F168_Phan_quyen_he_thong : Form
    {
        public F168_Phan_quyen_he_thong()
        {
            InitializeComponent();
            format_control();
        }

        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
        }
    }
}
