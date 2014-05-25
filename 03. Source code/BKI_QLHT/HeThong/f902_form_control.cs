using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;
using BKI_QLHT.US;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

namespace BKI_QLHT.HeThong
{
    public partial class f902_form_control : Form
    {
        public f902_form_control()
        {
            InitializeComponent();
            format_control();
        }

        #region Public Interface

        #endregion

        #region Data Structure
        private enum e_col_Number
        {
            DISPLAY_NAME = 0,
            CONTROL_NAME = 1,
            CONTROL_TYPE = 2,
            CONTROL_TEXT = 3,
            CONTROL_DISPLAY = 4
        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        US_V_HT_FORM_CONTROL m_us_v_ht_form_control = new US_V_HT_FORM_CONTROL();
        DS_V_HT_FORM_CONTROL m_ds_v_ht_form_control = new DS_V_HT_FORM_CONTROL();
        #endregion

        #region Private Methods
        private void update_data_from_grid()
        {
            for (int i = 1; i < m_fg.Rows.Count; i++)
            {
                grid2us_object(m_us_v_ht_form_control, i);
                US_HT_FORM_CONTROL v_us_ht_form_control = new US_HT_FORM_CONTROL();
                v_us_ht_form_control.dcID = m_us_v_ht_form_control.dcID;
                v_us_ht_form_control.dcID_FORM = m_us_v_ht_form_control.dcID_FORM;
                v_us_ht_form_control.strCONTROL_DISPLAY = m_us_v_ht_form_control.strCONTROL_DISPLAY;
                v_us_ht_form_control.strCONTROL_NAME = m_us_v_ht_form_control.strCONTROL_NAME;
                v_us_ht_form_control.strCONTROL_TEXT = m_us_v_ht_form_control.strCONTROL_TEXT;
                v_us_ht_form_control.strCONTROL_TYPE = m_us_v_ht_form_control.strCONTROL_TYPE;
                v_us_ht_form_control.Update();
            }
            BaseMessages.MsgBox_Infor("Bạn đã cập nhật thành công!");
        }
        private void format_control()
        {
            CControlFormat.setC1FlexFormat(m_fg);
            CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
            m_fg.AllowEditing = true;
            CGridUtils.AllowEditingCols(4, 4, m_fg);
            CGridUtils.DisAllowEditingCols(0, 3, m_fg);
            define_event();
        }
        private void load_data_from_database_to_dataset()
        {
            m_us_v_ht_form_control.FillDataset(m_ds_v_ht_form_control, "order by display_name");
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_HT_FORM_CONTROL.DISPLAY_NAME, e_col_Number.DISPLAY_NAME);
            v_htb.Add(V_HT_FORM_CONTROL.CONTROL_NAME, e_col_Number.CONTROL_NAME);
            v_htb.Add(V_HT_FORM_CONTROL.CONTROL_TYPE, e_col_Number.CONTROL_TYPE);
            v_htb.Add(V_HT_FORM_CONTROL.CONTROL_TEXT, e_col_Number.CONTROL_TEXT);
            v_htb.Add(V_HT_FORM_CONTROL.CONTROL_DISPLAY, e_col_Number.CONTROL_DISPLAY);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds_v_ht_form_control.V_HT_FORM_CONTROL.NewRow());
            return v_obj_trans;
        }
        private void define_event()
        {
            this.Load += f902_form_control_Load;
            m_cbo_form.SelectedIndexChanged += m_cbo_form_SelectedIndexChanged;
            m_cmd_cap_nhat.Click += m_cmd_cap_nhat_Click;
        }


        private void set_inital_form_load()
        {
            m_obj_trans = get_trans_object(m_fg);
            load_data_to_cbo_form();
            load_data_from_database_to_dataset();
            add_control_unsave_to_dataset();
            update_data_from_dataset_to_database();
            load_data_to_grid();
        }
        private void load_data_to_cbo_form()
        {
            US_HT_FORM v_us_ht_form = new US_HT_FORM();
            DS_HT_FORM v_ds_ht_form = new DS_HT_FORM();
            v_us_ht_form.FillDataset(v_ds_ht_form, "order by display_name");
            m_cbo_form.DisplayMember = HT_FORM.DISPLAY_NAME;
            m_cbo_form.ValueMember = HT_FORM.ID;
            m_cbo_form.DataSource = v_ds_ht_form.HT_FORM;
        }
        private void add_control_unsave_to_dataset()
        {
            Type formType = typeof(Form);
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
                if (formType.IsAssignableFrom(type))
                {
                    for (int i = 0; i < m_cbo_form.Items.Count; i++)
                    {
                        if (type.Name == ((DataRowView)m_cbo_form.Items[i])[HT_FORM.FORM_NAME].ToString())
                        {

                            object lateBound = Activator.CreateInstance(type);
                            System.Windows.Forms.Form oForm = (System.Windows.Forms.Form)lateBound;

                            foreach (Control v_control in oForm.Controls)
                            {
                                if (v_control.GetType().Name == "SiSButton" | v_control.GetType().Name == "Button")
                                {
                                    if (m_cbo_form.SelectedValue != null)
                                    {
                                        DataRow v_dr = m_ds_v_ht_form_control.V_HT_FORM_CONTROL.NewRow();

                                        DataRow[] rows = m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Select("form_name = '" +
                                             ((DataRowView)m_cbo_form.Items[i])[HT_FORM.FORM_NAME].ToString()
                                             + "'  and control_name= '" + v_control.Name + "'");
                                        if (rows.Count() < 1)
                                        {
                                            v_dr[V_HT_FORM_CONTROL.ID] = -m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Count;
                                            v_dr[V_HT_FORM_CONTROL.ID_FORM] = CIPConvert.ToDecimal(((DataRowView)m_cbo_form.Items[i])[HT_FORM.ID].ToString());
                                            v_dr[V_HT_FORM_CONTROL.FORM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.FORM_NAME].ToString();
                                            v_dr[V_HT_FORM_CONTROL.DISPLAY_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.DISPLAY_NAME].ToString();
                                            v_dr[V_HT_FORM_CONTROL.MENU_ITEM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.MENU_ITEM_NAME].ToString();
                                            v_dr[V_HT_FORM_CONTROL.CONTROL_NAME] = v_control.Name;
                                            v_dr[V_HT_FORM_CONTROL.CONTROL_TEXT] = v_control.Text;
                                            v_dr[V_HT_FORM_CONTROL.CONTROL_TYPE] = v_control.GetType().Name;
                                            m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Rows.Add(v_dr);

                                        }
                                        else
                                        {
                                            rows[0].BeginEdit();
                                            rows[0][V_HT_FORM_CONTROL.ID] = rows[0][V_HT_FORM_CONTROL.ID];
                                            rows[0][V_HT_FORM_CONTROL.ID_FORM] = CIPConvert.ToDecimal(((DataRowView)m_cbo_form.Items[i])[HT_FORM.ID].ToString());
                                            rows[0][V_HT_FORM_CONTROL.FORM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.FORM_NAME].ToString();
                                            rows[0][V_HT_FORM_CONTROL.DISPLAY_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.DISPLAY_NAME].ToString();
                                            rows[0][V_HT_FORM_CONTROL.MENU_ITEM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.MENU_ITEM_NAME].ToString();
                                            rows[0][V_HT_FORM_CONTROL.CONTROL_NAME] = v_control.Name;
                                            rows[0][V_HT_FORM_CONTROL.CONTROL_TEXT] = v_control.Text;
                                            rows[0][V_HT_FORM_CONTROL.CONTROL_TYPE] = v_control.GetType().Name;
                                            rows[0].EndEdit();
                                        }


                                    }

                                }
                                else if (v_control.GetType().Name == "Panel")
                                {
                                    foreach (Control v_control_child in v_control.Controls)
                                    {
                                        if (v_control_child.GetType().Name == "SiSButton" | v_control_child.GetType().Name == "Button")
                                        {
                                            if (m_cbo_form.SelectedValue != null)
                                            {
                                                DataRow v_dr = m_ds_v_ht_form_control.V_HT_FORM_CONTROL.NewRow();

                                                DataRow[] rows = m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Select("form_name = '" +
                                                     ((DataRowView)m_cbo_form.Items[i])[HT_FORM.FORM_NAME].ToString()
                                                     + "'  and control_name= '" + v_control_child.Name + "'");
                                                if (rows.Count() < 1)
                                                {
                                                    v_dr[V_HT_FORM_CONTROL.ID] = -m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Count;
                                                    v_dr[V_HT_FORM_CONTROL.ID_FORM] = CIPConvert.ToDecimal(((DataRowView)m_cbo_form.Items[i])[HT_FORM.ID].ToString());
                                                    v_dr[V_HT_FORM_CONTROL.FORM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.FORM_NAME].ToString();
                                                    v_dr[V_HT_FORM_CONTROL.DISPLAY_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.DISPLAY_NAME].ToString();
                                                    v_dr[V_HT_FORM_CONTROL.MENU_ITEM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.MENU_ITEM_NAME].ToString();
                                                    v_dr[V_HT_FORM_CONTROL.CONTROL_NAME] = v_control_child.Name;
                                                    v_dr[V_HT_FORM_CONTROL.CONTROL_TEXT] = v_control_child.Text;
                                                    v_dr[V_HT_FORM_CONTROL.CONTROL_TYPE] = v_control_child.GetType().Name;
                                                    m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Rows.Add(v_dr);

                                                }
                                                else
                                                {
                                                    rows[0].BeginEdit();
                                                    rows[0][V_HT_FORM_CONTROL.ID] = rows[0][V_HT_FORM_CONTROL.ID];
                                                    rows[0][V_HT_FORM_CONTROL.ID_FORM] = CIPConvert.ToDecimal(((DataRowView)m_cbo_form.Items[i])[HT_FORM.ID].ToString());
                                                    rows[0][V_HT_FORM_CONTROL.FORM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.FORM_NAME].ToString();
                                                    rows[0][V_HT_FORM_CONTROL.DISPLAY_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.DISPLAY_NAME].ToString();
                                                    rows[0][V_HT_FORM_CONTROL.MENU_ITEM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.MENU_ITEM_NAME].ToString();
                                                    rows[0][V_HT_FORM_CONTROL.CONTROL_NAME] = v_control_child.Name;
                                                    rows[0][V_HT_FORM_CONTROL.CONTROL_TEXT] = v_control_child.Text;
                                                    rows[0][V_HT_FORM_CONTROL.CONTROL_TYPE] = v_control_child.GetType().Name;
                                                    rows[0].EndEdit();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }


            // load control trong user control
            Type ucType = typeof(UserControl);
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
                if (ucType.IsAssignableFrom(type))
                {
                    for (int i = 0; i < m_cbo_form.Items.Count; i++)
                    {
                        if (type.Name == ((DataRowView)m_cbo_form.Items[i])[HT_FORM.FORM_NAME].ToString())
                        {

                            object lateBound = Activator.CreateInstance(type);
                            System.Windows.Forms.UserControl oForm = (System.Windows.Forms.UserControl)lateBound;

                            foreach (Control v_control in oForm.Controls)
                            {
                                if (v_control.GetType().Name == "SiSButton" | v_control.GetType().Name == "Button")
                                {
                                    if (m_cbo_form.SelectedValue != null)
                                    {

                                        if (m_cbo_form.SelectedValue != null)
                                        {
                                            DataRow v_dr = m_ds_v_ht_form_control.V_HT_FORM_CONTROL.NewRow();

                                            DataRow[] rows = m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Select("form_name = '" +
                                                 ((DataRowView)m_cbo_form.Items[i])[HT_FORM.FORM_NAME].ToString()
                                                 + "'  and control_name= '" + v_control.Name + "'");
                                            if (rows.Count() < 1)
                                            {
                                                v_dr[V_HT_FORM_CONTROL.ID] = -m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Count;
                                                v_dr[V_HT_FORM_CONTROL.ID_FORM] = CIPConvert.ToDecimal(((DataRowView)m_cbo_form.Items[i])[HT_FORM.ID].ToString());
                                                v_dr[V_HT_FORM_CONTROL.FORM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.FORM_NAME].ToString();
                                                v_dr[V_HT_FORM_CONTROL.DISPLAY_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.DISPLAY_NAME].ToString();
                                                v_dr[V_HT_FORM_CONTROL.MENU_ITEM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.MENU_ITEM_NAME].ToString();
                                                v_dr[V_HT_FORM_CONTROL.CONTROL_NAME] = v_control.Name;
                                                v_dr[V_HT_FORM_CONTROL.CONTROL_TEXT] = v_control.Text;
                                                v_dr[V_HT_FORM_CONTROL.CONTROL_TYPE] = v_control.GetType().Name;
                                                m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Rows.Add(v_dr);

                                            }
                                            else
                                            {
                                                rows[0].BeginEdit();
                                                rows[0][V_HT_FORM_CONTROL.ID] = rows[0][V_HT_FORM_CONTROL.ID];
                                                rows[0][V_HT_FORM_CONTROL.ID_FORM] = CIPConvert.ToDecimal(((DataRowView)m_cbo_form.Items[i])[HT_FORM.ID].ToString());
                                                rows[0][V_HT_FORM_CONTROL.FORM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.FORM_NAME].ToString();
                                                rows[0][V_HT_FORM_CONTROL.DISPLAY_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.DISPLAY_NAME].ToString();
                                                rows[0][V_HT_FORM_CONTROL.MENU_ITEM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.MENU_ITEM_NAME].ToString();
                                                rows[0][V_HT_FORM_CONTROL.CONTROL_NAME] = v_control.Name;
                                                rows[0][V_HT_FORM_CONTROL.CONTROL_TEXT] = v_control.Text;
                                                rows[0][V_HT_FORM_CONTROL.CONTROL_TYPE] = v_control.GetType().Name;
                                                rows[0].EndEdit();
                                            }
                                        }
                                    }

                                }
                                else if (v_control.GetType().Name == "Panel" | v_control.GetType().Name == "GroupBox")
                                {
                                    foreach (Control v_control_child in v_control.Controls)
                                    {
                                        if (v_control_child.GetType().Name == "SiSButton" | v_control_child.GetType().Name == "Button")
                                        {
                                            if (m_cbo_form.SelectedValue != null)
                                            {
                                                if (m_cbo_form.SelectedValue != null)
                                                {
                                                    DataRow v_dr = m_ds_v_ht_form_control.V_HT_FORM_CONTROL.NewRow();

                                                    DataRow[] rows = m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Select("form_name = '" +
                                                         ((DataRowView)m_cbo_form.Items[i])[HT_FORM.FORM_NAME].ToString()
                                                         + "'  and control_name= '" + v_control_child.Name + "'");
                                                    if (rows.Count() < 1)
                                                    {
                                                        v_dr[V_HT_FORM_CONTROL.ID] = -m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Count;
                                                        v_dr[V_HT_FORM_CONTROL.ID_FORM] = CIPConvert.ToDecimal(((DataRowView)m_cbo_form.Items[i])[HT_FORM.ID].ToString());
                                                        v_dr[V_HT_FORM_CONTROL.FORM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.FORM_NAME].ToString();
                                                        v_dr[V_HT_FORM_CONTROL.DISPLAY_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.DISPLAY_NAME].ToString();
                                                        v_dr[V_HT_FORM_CONTROL.MENU_ITEM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.MENU_ITEM_NAME].ToString();
                                                        v_dr[V_HT_FORM_CONTROL.CONTROL_NAME] = v_control_child.Name;
                                                        v_dr[V_HT_FORM_CONTROL.CONTROL_TEXT] = v_control_child.Text;
                                                        v_dr[V_HT_FORM_CONTROL.CONTROL_TYPE] = v_control_child.GetType().Name;
                                                        m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Rows.Add(v_dr);

                                                    }
                                                    else
                                                    {
                                                        rows[0].BeginEdit();
                                                        rows[0][V_HT_FORM_CONTROL.ID] = rows[0][V_HT_FORM_CONTROL.ID];
                                                        rows[0][V_HT_FORM_CONTROL.ID_FORM] = CIPConvert.ToDecimal(((DataRowView)m_cbo_form.Items[i])[HT_FORM.ID].ToString());
                                                        rows[0][V_HT_FORM_CONTROL.FORM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.FORM_NAME].ToString();
                                                        rows[0][V_HT_FORM_CONTROL.DISPLAY_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.DISPLAY_NAME].ToString();
                                                        rows[0][V_HT_FORM_CONTROL.MENU_ITEM_NAME] = ((DataRowView)m_cbo_form.Items[i])[HT_FORM.MENU_ITEM_NAME].ToString();
                                                        rows[0][V_HT_FORM_CONTROL.CONTROL_NAME] = v_control_child.Name;
                                                        rows[0][V_HT_FORM_CONTROL.CONTROL_TEXT] = v_control_child.Text;
                                                        rows[0][V_HT_FORM_CONTROL.CONTROL_TYPE] = v_control_child.GetType().Name;
                                                        rows[0].EndEdit();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

        }
        private void grid2us_object(US_V_HT_FORM_CONTROL i_us
           , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }
        private void update_data_from_dataset_to_database()
        {
            DS_V_HT_FORM_CONTROL v_ds_v_ht_form_control = new DS_V_HT_FORM_CONTROL();
            m_us_v_ht_form_control.FillDataset(v_ds_v_ht_form_control);
            // xoá những control không còn tồn tại nhưng vẫn được lưu trong database
            for (int i = 0; i < v_ds_v_ht_form_control.V_HT_FORM_CONTROL.Count; i++)
            {
                bool v_b_exist = true;
                for (int j = 0; j < m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Count;j++ )
                {
                    if (v_ds_v_ht_form_control.V_HT_FORM_CONTROL.Rows[i] != m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Rows[j])
                    {
                        v_b_exist = false;
                        break;
                    }
                }
                if (v_b_exist==false)
                {
                    m_us_v_ht_form_control.DataRow2Me(v_ds_v_ht_form_control.V_HT_FORM_CONTROL.Rows[i]);
                    US_HT_FORM_CONTROL v_us_ht_form_control = new US_HT_FORM_CONTROL();
                    v_us_ht_form_control.DeleteByID(m_us_v_ht_form_control.dcID);
                }
            }
            // cập nhật những thay đổi của control, thêm những control mới chưa thêm
            for (int i = 0; i < m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Count; i++)
            {
                DataRow v_dr = m_ds_v_ht_form_control.V_HT_FORM_CONTROL.Rows[i];
                m_us_v_ht_form_control.DataRow2Me(v_dr);
                US_HT_FORM_CONTROL v_us_ht_form_control = new US_HT_FORM_CONTROL();
                v_us_ht_form_control.dcID = m_us_v_ht_form_control.dcID;
                v_us_ht_form_control.dcID_FORM = m_us_v_ht_form_control.dcID_FORM;
                v_us_ht_form_control.strCONTROL_DISPLAY = m_us_v_ht_form_control.strCONTROL_DISPLAY;
                v_us_ht_form_control.strCONTROL_NAME = m_us_v_ht_form_control.strCONTROL_NAME;
                v_us_ht_form_control.strCONTROL_TEXT = m_us_v_ht_form_control.strCONTROL_TEXT;
                v_us_ht_form_control.strCONTROL_TYPE = m_us_v_ht_form_control.strCONTROL_TYPE;
                if (v_us_ht_form_control.dcID < 0)
                    v_us_ht_form_control.Insert();
                else
                    v_us_ht_form_control.Update();
            }
        }
        private void load_data_to_grid()
        {
            m_ds_v_ht_form_control.Clear();
            m_us_v_ht_form_control.FillDataset(m_ds_v_ht_form_control, "where form_name='" +
                ((DataRowView)m_cbo_form.Items[m_cbo_form.SelectedIndex])[HT_FORM.FORM_NAME].ToString() + "' order by display_name");
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds_v_ht_form_control, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }




        #endregion

        #region Events
        void f902_form_control_Load(object sender, EventArgs e)
        {
            try
            {
                set_inital_form_load();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cmd_cap_nhat_Click(object sender, EventArgs e)
        {
            try
            {
                update_data_from_grid();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        void m_cbo_form_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                load_data_to_grid();
            }
            catch (System.Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        #endregion
        }
    }
}
