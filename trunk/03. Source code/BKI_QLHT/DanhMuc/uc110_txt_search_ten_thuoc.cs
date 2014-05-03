using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BKI_QLHT.DS;
using IP.Core.IPCommon;

namespace BKI_QLHT.DanhMuc
{
    public partial class uc110_txt_search_ten_thuoc : UserControl
    {
        public uc110_txt_search_ten_thuoc()
        {
            InitializeComponent();
        }
          public System.Data.DataSet m_ds;

        private string displayMember;

        public string DisplayMember
        {
            get { return displayMember; }
            set { displayMember = value; }
        }
        private decimal DcID;

        public decimal dcID
        {
            get { return DcID; }
            set { DcID = value; }
        }
        
        private string text;

        public string Text1
        {
            get { return text; }
            set { text = value; }
        }

        public string valueMember;
        public string ValueMember
        {
            get { return valueMember; }
            set { valueMember = value; }
        }

        public string m_str_query;
        public string str_query
        {
            get { return m_str_query; }
            set { m_str_query = value; }
        }


        #region Methods
        private void set_define_event()
        {
            this.m_txt_search.Click += new System.EventHandler(this.m_txt_search_Click);
            this.m_txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_txt_search_KeyDown);
            this.m_list_suggest.Click += new System.EventHandler(this.m_list_suggest_Click);
            this.m_list_suggest.SelectedIndexChanged += new System.EventHandler(this.m_list_suggest_SelectedIndexChanged);
            this.m_list_suggest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_list_suggest_KeyDown);
        }
        public void load_data_to_list(DataSet ip_ds, string DisplayMember, string ValueMember)
        {
            m_ds = ip_ds;
            displayMember = DisplayMember;
            valueMember = ValueMember;

            m_list_suggest.DisplayMember = DisplayMember;
            m_list_suggest.ValueMember = ValueMember;
            m_list_suggest.DataSource = m_ds.Tables[0];
        }
        //private void load_cbo_don_vi_tinh()
        //{
        //    decimal v_id_thuoc = CIPConvert.ToDecimal(valueMember);
        //    m_us_v_gd_giao_dich_detai.FillDataset(m_ds_v_gd_giao_dich_detail, "where id = " + v_id_thuoc + "");
        //    m_cbo_don_vi_tinh.DataSource = m_ds_v_gd_giao_dich_detail.V_GD_GIAO_DICH_DETAIL;
        //    m_cbo_don_vi_tinh.ValueMember = V_GD_GIAO_DICH_DETAIL.ID;
        //    m_cbo_don_vi_tinh.DisplayMember = V_GD_GIAO_DICH_DETAIL.TEN_DON_VI;
        //}
        #endregion

        #region Events
        private void m_txt_search_Click(object sender, EventArgs e)
        {
            this.Height = m_txt_search.Width;
            this.Width = m_txt_search.Width;
            m_list_suggest.Visible = true;
            m_list_suggest.Focus();
        }
        private void m_txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (!m_txt_search.Text.Trim().Equals(""))
                    {
                        //m_list_suggest.Items.Clear();

                        //DataRow[] v_drows = m_ds.Tables[0].Select("ten_thuoc like '*vitamin*'");
                        //DataSet v_ds = new DataSet();

                        DataTable dm_thuoc = m_ds.Tables[0];
                        var v_query =
                            from thuoc in dm_thuoc.AsEnumerable()
                            where (thuoc.Field<string>(DisplayMember).ToLower().Contains(m_txt_search.Text.Trim().ToLower()))
                            select thuoc;
                        //int row_count = 0;
                        //foreach (var v_thuoc in v_query)
                        //{
                        //    v_ds.Tables[0].Rows.Add((DataRow)v_thuoc);
                        //    row_count++;
                        //}
                        if (v_query.Count()>0)
                        {
                            DataTable v_dt = v_query.CopyToDataTable();
                            //v_ds.Tables.Add(v_dt);
                            //v_ds.Tables[0].Rows.Clear();
                            //for (int i = 0; i < v_drows.Length; i++)
                            //{
                            //    v_ds.Tables[0].Rows.Add(v_drows[i]);
                            //}

                            m_list_suggest.DataSource = v_dt;
                            m_list_suggest.DisplayMember = DisplayMember;
                            m_list_suggest.ValueMember = ValueMember;
                        }
                        else
                        {
                            //m_list_suggest.Items.Clear();
                            m_list_suggest.DataSource = null;
                            m_txt_search.Focus();
                            return;

                        }
                       





                    }
                    this.Height = m_txt_search.Width;
                    this.Width = m_txt_search.Width;
                    m_list_suggest.Visible = true;
                    m_list_suggest.Focus();
                }
                if (e.KeyData == Keys.Down || e.KeyData == Keys.Up)
                {
                    m_list_suggest.Focus();
                    this.Height = m_txt_search.Width;
                    this.Width = m_txt_search.Width;
                    m_list_suggest.Visible = true;
                }
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_list_suggest_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (m_list_suggest.Items.Count > 0)
            //{
            //    m_txt_search.Text = m_list_suggest.Text;
            //    m_list_suggest.Visible = false;
            //    this.Height = m_txt_search.Height;
            //    m_list_suggest.Focus();
            //}

        }
        private void m_list_suggest_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_list_suggest.Items.Count > 0)
                {
                    this.Text1 = m_list_suggest.Text;
                    m_txt_search.Text = m_list_suggest.Text;
                    this.dcID = CIPConvert.ToDecimal(m_list_suggest.SelectedValue);
                    m_list_suggest.Visible = false;
                    this.Height = m_txt_search.Height;
                    m_list_suggest.Focus();
                }
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_list_suggest_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {

                    if (m_list_suggest.Items.Count > 0)
                    {
                        this.Text1 = m_list_suggest.Text;
                        m_txt_search.Text = m_list_suggest.Text;
                        this.dcID = CIPConvert.ToDecimal(m_list_suggest.SelectedValue);
                        m_list_suggest.Visible = false;
                        this.Height = m_txt_search.Height;
                        m_list_suggest.Focus();
                    }
                }
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        #endregion
    }
}
