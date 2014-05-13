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
    public partial class txt_search_thuoc : UserControl
    {
        public System.Data.DataSet m_ds;

        private string displayMember;

        public string DisplayMember
        {
            get { return displayMember; }
            set { displayMember = value; }
        }
        public void xoa_trang()
        {
            this.m_list_suggest.DataSource = null;
            this.m_txt_search.Text = null;
            m_list_suggest.Visible = false;
            this.Height = m_txt_search.Height;
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

        public txt_search_thuoc()
        {
            InitializeComponent();
            this.Height = m_txt_search.Height;
            set_define_event();
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
        #endregion

        #region Events
        private void m_txt_search_Click(object sender, EventArgs e)
        {
            //this.Height = m_txt_search.Width;
            //this.Width = m_txt_search.Width;
            //m_list_suggest.Visible = true;
            //m_list_suggest.Focus();
        }
        private void m_txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (!m_txt_search.Text.Trim().Equals(""))
                    {
                        DataTable dm_thuoc = m_ds.Tables[0];
                        var v_query =
                            from thuoc in dm_thuoc.AsEnumerable()
                            where (thuoc.Field<string>(DisplayMember).ToLower().Contains(m_txt_search.Text.Trim().ToLower()))
                            select thuoc;
                        if (v_query.Count()>0)
                        {
                            DataTable v_dt = v_query.CopyToDataTable();
                            m_list_suggest.DataSource = v_dt;
                            m_list_suggest.DisplayMember = DisplayMember;
                            m_list_suggest.ValueMember = ValueMember;
                        }
                        else
                        {
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
                if (e.KeyData==Keys.Tab&&m_txt_search.Text.Trim().Equals(""))
                {
                    m_list_suggest.DataSource = null;
                    m_list_suggest.Visible = false;
                    this.Height = m_txt_search.Height;
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

                    this.OnKeyDown(new KeyEventArgs(Keys.Enter));
                    this.Focus();
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
                        //m_list_suggest.Focus();
                        this.OnKeyDown(new KeyEventArgs(Keys.Enter));
                        this.Focus();
                    }
                }
                else if (e.KeyData!=Keys.Down && e.KeyData!=Keys.Up)
                {
                    m_txt_search.Select(m_txt_search.Text.Length, 0);
                    m_txt_search.Focus();
                }
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        #endregion

        private void m_txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!m_txt_search.Text.Trim().Equals(""))
                {
                    DataTable dm_thuoc = m_ds.Tables[0];
                    var v_query =
                        from thuoc in dm_thuoc.AsEnumerable()
                        where (thuoc.Field<string>(DisplayMember).ToLower().Contains(m_txt_search.Text.Trim().ToLower()))
                        select thuoc;
                    if (v_query.Count() > 0)
                    {
                        DataTable v_dt = v_query.CopyToDataTable();
                        m_list_suggest.DataSource = v_dt;
                        m_list_suggest.DisplayMember = DisplayMember;
                        m_list_suggest.ValueMember = ValueMember;
                    }
                    else
                    {
                        m_list_suggest.DataSource = null;
                        m_txt_search.Focus();
                        return;

                    }
                }
                this.Height = m_txt_search.Width;
                this.Width = m_txt_search.Width;
                m_list_suggest.Visible = true;
                //m_list_suggest.Focus();
                m_txt_search.Focus();
            }
            catch (System.Exception v_e)
            {
            	CSystemLog_301.ExceptionHandle(v_e);
            }
        }
    }
}
