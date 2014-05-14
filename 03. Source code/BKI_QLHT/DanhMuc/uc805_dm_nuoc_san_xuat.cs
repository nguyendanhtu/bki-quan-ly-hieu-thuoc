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


namespace BKI_QLHT.DanhMuc
{
    public partial class uc805_dm_nuoc_san_xuat : UserControl
    {
        public uc805_dm_nuoc_san_xuat()
        {
            InitializeComponent();
            format_controls();
        }
        #region Data Structure
        private enum e_col_Number
        {
            TEN_NCC = 1
,
            DIA_CHI = 3
                ,
            SDT = 4
                , MA_NCC = 2

        }
        #endregion

        #region Members
        ITransferDataRow m_obj_trans;
        DS_V_DM_NUOC_SX m_ds = new DS_V_DM_NUOC_SX();
        US_V_DM_NUOC_SX m_us = new US_V_DM_NUOC_SX();
        US_DM_NCC_NSX_NHASX m_us_dm_ncc = new US_DM_NCC_NSX_NHASX();
        internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal ImageList ImageList;
        private IContainer components;
        internal SIS.Controls.Button.SiSButton m_cmd_tim_kiem;
        private TextBox m_txt_tu_khoa;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        private C1FlexGrid m_grv_nha_cung_cap;
        internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private Label label2;
        private Label label1;
        internal Panel m_pnl_control;
        DS_DM_NCC_NSX_NHASX m_ds_dm_ncc = new DS_DM_NCC_NSX_NHASX();
        #endregion

        #region Private Methods
        private void format_controls()
        {
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            CControlFormat.setC1FlexFormat(m_grv_nha_cung_cap);
            set_define_events();
        }
        private void set_initial_form_load()
        {
            m_obj_trans = get_trans_object(m_grv_nha_cung_cap);
            load_data_2_grid();
            grid2us_object(m_us_dm_ncc,m_grv_nha_cung_cap.Row);
            m_us = new US_V_DM_NUOC_SX(m_us_dm_ncc.dcID);
        }
        private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg)
        {
            Hashtable v_htb = new Hashtable();
            v_htb.Add(V_DM_NUOC_SX.TEN_NCC, e_col_Number.TEN_NCC);
            v_htb.Add(V_DM_NUOC_SX.DIA_CHI, e_col_Number.DIA_CHI);
            v_htb.Add(V_DM_NCC.SDT, e_col_Number.SDT);
            v_htb.Add(V_DM_NUOC_SX.MA_NCC, e_col_Number.MA_NCC);

            ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg, v_htb, m_ds.V_DM_NUOC_SX.NewRow());
            return v_obj_trans;
        }
        private void load_data_2_grid()
        {
            m_ds = new DS_V_DM_NUOC_SX();
            m_us.FillDataset(m_ds,"where ID_LOAI_DM=2");
            m_grv_nha_cung_cap.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_ds, m_grv_nha_cung_cap, m_obj_trans);
            m_grv_nha_cung_cap.Redraw = true;
        }
        private void grid2us_object(US_DM_NCC_NSX_NHASX i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_grv_nha_cung_cap.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }


        private void us_object2grid(US_V_DM_NUOC_SX i_us
            , int i_grid_row)
        {
            DataRow v_dr = (DataRow)m_grv_nha_cung_cap.Rows[i_grid_row].UserData;
            i_us.Me2DataRow(v_dr);
            m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
        }


        private void insert_v_dm_ncc_nsx_nhasx_1()
        {
            	f805_nuoc_san_xuat_DE v_fDE = new  f805_nuoc_san_xuat_DE();								
            	v_fDE.display_for_insert();
            load_data_2_grid();
            v_fDE.get_us(ref m_us_dm_ncc);
            WinFormControls.set_focus_for_grid(m_grv_nha_cung_cap, m_us_dm_ncc.strTEN_NCC, 1);
        }

        private void update_v_dm_ncc_nsx_nhasx_1()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_nha_cung_cap)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_nha_cung_cap, m_grv_nha_cung_cap.Row)) return;
            grid2us_object(m_us_dm_ncc, m_grv_nha_cung_cap.Row);
            	f805_nuoc_san_xuat_DE v_fDE = new f805_nuoc_san_xuat_DE();
            	v_fDE.display_for_update(m_us_dm_ncc);
            load_data_2_grid();
        }

        private void delete_v_dm_ncc_nsx_nhasx_1()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_nha_cung_cap)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_nha_cung_cap, m_grv_nha_cung_cap.Row)) return;
            if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
            US_DM_NCC_NSX_NHASX v_us = new US_DM_NCC_NSX_NHASX();
            grid2us_object(v_us, m_grv_nha_cung_cap.Row);
            US_V_DM_NUOC_SX v_v_us = new US_V_DM_NUOC_SX(v_us.dcID);
            if (v_v_us.dcID_NUOC_SX ==0)
            {
                try
                {
                    v_us.BeginTransaction();
                    v_us.Delete();
                    v_us.CommitTransaction();
                    m_grv_nha_cung_cap.Rows.Remove(m_grv_nha_cung_cap.Row);
                }
                catch (Exception v_e)
                {
                    v_us.Rollback();
                    CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
                        new CDBClientDBExceptionInterpret());
                    v_objErrHandler.showErrorMessage();
                }
            }
            else
            {
                MessageBox.Show("Nước sản xuất đã được sử dụng. Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void view_v_dm_ncc_nsx_nhasx_1()
        {
            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_nha_cung_cap)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_nha_cung_cap, m_grv_nha_cung_cap.Row)) return;
            grid2us_object(m_us_dm_ncc, m_grv_nha_cung_cap.Row);
            //	f800_DM_NHA_CUNG_CAP_DE v_fDE = new f800_DM_NHA_CUNG_CAP_DE();			
            //	v_fDE.display(m_us);
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            this.Load += new EventHandler(f800_DM_NHA_CUNG_CAP_Load);
        }
        #endregion

        //
        //
        //		EVENT HANLDERS
        //
        //

        #region events
        private void m_grv_nha_cung_cap_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_nha_cung_cap)) return;
                if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_nha_cung_cap, m_grv_nha_cung_cap.Row)) return;
                grid2us_object(m_us_dm_ncc, m_grv_nha_cung_cap.Row);
                m_us = new US_V_DM_NUOC_SX(m_us_dm_ncc.dcID);
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_cmd_tim_kiem_Click_1(object sender, EventArgs e)
        {
            try
            {
                US_V_DM_NUOC_SX v_us_v_dm_ncc = new US_V_DM_NUOC_SX();
                DS_V_DM_NUOC_SX v_ds_v_dm_ncc = new DS_V_DM_NUOC_SX();
                v_us_v_dm_ncc.FillDatasetSearch(v_ds_v_dm_ncc, m_txt_tu_khoa.Text);
                m_grv_nha_cung_cap.Redraw = false;
                CGridUtils.Dataset2C1Grid(v_ds_v_dm_ncc, m_grv_nha_cung_cap, m_obj_trans);
                m_grv_nha_cung_cap.Redraw = true;
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_tu_khoa_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    US_V_DM_NUOC_SX v_us_v_dm_ncc = new US_V_DM_NUOC_SX();
                    DS_V_DM_NUOC_SX v_ds_v_dm_ncc = new DS_V_DM_NUOC_SX();
                    v_us_v_dm_ncc.FillDatasetSearch(v_ds_v_dm_ncc, m_txt_tu_khoa.Text);
                    m_grv_nha_cung_cap.Redraw = false;
                    CGridUtils.Dataset2C1Grid(v_ds_v_dm_ncc, m_grv_nha_cung_cap, m_obj_trans);
                    m_grv_nha_cung_cap.Redraw = true;
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_grv_nha_cung_cap_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    grid2us_object(m_us_dm_ncc, m_grv_nha_cung_cap.Row);
                    m_us = new US_V_DM_NUOC_SX(m_us_dm_ncc.dcID);
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void f800_DM_NHA_CUNG_CAP_Load(object sender, System.EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                this.Controls.Clear();
               // this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                insert_v_dm_ncc_nsx_nhasx_1();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_update_Click(object sender, EventArgs e)
        {
            try
            {
                update_v_dm_ncc_nsx_nhasx_1();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                delete_v_dm_ncc_nsx_nhasx_1();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_view_Click(object sender, EventArgs e)
        {
            try
            {
                view_v_dm_ncc_nsx_nhasx_1();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        #endregion

        

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc805_dm_nuoc_san_xuat));
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_cmd_tim_kiem = new SIS.Controls.Button.SiSButton();
            this.m_txt_tu_khoa = new System.Windows.Forms.TextBox();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_grv_nha_cung_cap = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_pnl_control = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_nha_cung_cap)).BeginInit();
            this.m_pnl_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(789, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "");
            this.ImageList.Images.SetKeyName(1, "");
            this.ImageList.Images.SetKeyName(2, "");
            this.ImageList.Images.SetKeyName(3, "");
            this.ImageList.Images.SetKeyName(4, "");
            this.ImageList.Images.SetKeyName(5, "");
            this.ImageList.Images.SetKeyName(6, "");
            this.ImageList.Images.SetKeyName(7, "");
            this.ImageList.Images.SetKeyName(8, "");
            this.ImageList.Images.SetKeyName(9, "");
            this.ImageList.Images.SetKeyName(10, "");
            this.ImageList.Images.SetKeyName(11, "");
            this.ImageList.Images.SetKeyName(12, "");
            this.ImageList.Images.SetKeyName(13, "");
            this.ImageList.Images.SetKeyName(14, "");
            this.ImageList.Images.SetKeyName(15, "");
            this.ImageList.Images.SetKeyName(16, "");
            this.ImageList.Images.SetKeyName(17, "");
            this.ImageList.Images.SetKeyName(18, "");
            this.ImageList.Images.SetKeyName(19, "");
            this.ImageList.Images.SetKeyName(20, "");
            this.ImageList.Images.SetKeyName(21, "");
            // 
            // m_cmd_tim_kiem
            // 
            this.m_cmd_tim_kiem.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_tim_kiem.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_tim_kiem.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_tim_kiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_tim_kiem.ImageIndex = 5;
            this.m_cmd_tim_kiem.ImageList = this.ImageList;
            this.m_cmd_tim_kiem.Location = new System.Drawing.Point(789, 57);
            this.m_cmd_tim_kiem.Name = "m_cmd_tim_kiem";
            this.m_cmd_tim_kiem.Size = new System.Drawing.Size(88, 22);
            this.m_cmd_tim_kiem.TabIndex = 42;
            this.m_cmd_tim_kiem.Text = "Tìm kiếm";
            this.m_cmd_tim_kiem.Click += new System.EventHandler(this.m_cmd_tim_kiem_Click_1);
            // 
            // m_txt_tu_khoa
            // 
            this.m_txt_tu_khoa.Location = new System.Drawing.Point(419, 56);
            this.m_txt_tu_khoa.Name = "m_txt_tu_khoa";
            this.m_txt_tu_khoa.Size = new System.Drawing.Size(328, 20);
            this.m_txt_tu_khoa.TabIndex = 41;
            this.m_txt_tu_khoa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.m_txt_tu_khoa_KeyUp);
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(877, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_grv_nha_cung_cap
            // 
            this.m_grv_nha_cung_cap.ColumnInfo = resources.GetString("m_grv_nha_cung_cap.ColumnInfo");
            this.m_grv_nha_cung_cap.Location = new System.Drawing.Point(0, 99);
            this.m_grv_nha_cung_cap.Name = "m_grv_nha_cung_cap";
            this.m_grv_nha_cung_cap.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.m_grv_nha_cung_cap.Size = new System.Drawing.Size(1125, 429);
            this.m_grv_nha_cung_cap.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_nha_cung_cap.Styles"));
            this.m_grv_nha_cung_cap.TabIndex = 38;
            this.m_grv_nha_cung_cap.Click += new System.EventHandler(this.m_grv_nha_cung_cap_Click);
            this.m_grv_nha_cung_cap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.m_grv_nha_cung_cap_KeyUp);
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(965, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 14;
            this.m_cmd_delete.Text = "&Xoá";
            // 
            // m_cmd_exit
            // 
            this.m_cmd_exit.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_exit.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_exit.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_exit.ImageIndex = 12;
            this.m_cmd_exit.ImageList = this.ImageList;
            this.m_cmd_exit.Location = new System.Drawing.Point(1053, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(320, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Từ khóa :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(459, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 23);
            this.label1.TabIndex = 39;
            this.label1.Text = "Thông tin nước sản xuất ";
            // 
            // m_pnl_control
            // 
            this.m_pnl_control.Controls.Add(this.m_cmd_insert);
            this.m_pnl_control.Controls.Add(this.m_cmd_update);
            this.m_pnl_control.Controls.Add(this.m_cmd_delete);
            this.m_pnl_control.Controls.Add(this.m_cmd_exit);
            this.m_pnl_control.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_control.Location = new System.Drawing.Point(0, 534);
            this.m_pnl_control.Name = "m_pnl_control";
            this.m_pnl_control.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_control.Size = new System.Drawing.Size(1145, 36);
            this.m_pnl_control.TabIndex = 37;
            // 
            // uc805_dm_nuoc_san_xuat
            // 
            this.Controls.Add(this.m_cmd_tim_kiem);
            this.Controls.Add(this.m_txt_tu_khoa);
            this.Controls.Add(this.m_grv_nha_cung_cap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_pnl_control);
            this.Name = "uc805_dm_nuoc_san_xuat";
            this.Size = new System.Drawing.Size(1145, 570);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_nha_cung_cap)).EndInit();
            this.m_pnl_control.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

    }
}
