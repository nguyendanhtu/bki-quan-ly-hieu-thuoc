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

using BKI_QLHT.DS;
using BKI_QLHT.US;
using BKI_QLHT.DS.CDBNames;

using C1.Win.C1FlexGrid;
using IP.Core.IPSystemAdmin;

namespace BKI_QLHT
{
    public partial  class f511_gd_nhap_thuoc : Form
    {
        public f511_gd_nhap_thuoc()
        {
            InitializeComponent();
            format_control();

        }

        
        #region Public Interface
        
        #endregion
        #region Member

        #endregion
        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            set_define_event();
        }

        private void set_define_event()
        {
            this.Load += new System.EventHandler(this.f511_gd_nhap_thuoc_Load);
        }
        public void set_inital_form_load() {
            load_data_2_cbo_ten_thuoc();

        }
        private void load_data_2_cbo_ten_thuoc(){
            US_DM_THUOC v_us_dm_thuoc = new US_DM_THUOC();
            DS_DM_THUOC v_ds_dm_thuoc = new DS_DM_THUOC();
            v_us_dm_thuoc.FillDataset(v_ds_dm_thuoc);
            m_cbo_ten_thuoc.DataSource = v_ds_dm_thuoc.DM_THUOC;
            m_cbo_ten_thuoc.ValueMember = DM_THUOC.ID;
            m_cbo_ten_thuoc.DisplayMember = DM_THUOC.TEN_THUOC;
        }
        #endregion

        
        #region Event
        private void f511_gd_nhap_thuoc_Load(object sender, EventArgs e)
        {
            set_inital_form_load();
        }
        #endregion
    }
}
