///************************************************
/// Generated by: Huytd
/// Date: 01/04/2014 06:00:06
/// Goal: Create Form for DM_NHOM_KHACH_HANG
///************************************************


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

using BKI_QLHT.US;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;

using C1.Win.C1FlexGrid;

namespace BKI_QLHT
{



	public class f101_dm_nhom_khach_hang : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private GroupBox groupBox1;
        private TextBox m_text_tim_kiem;
        internal SIS.Controls.Button.SiSButton m_cmd_tim_kiem;
        private GroupBox groupBox2;
        internal SIS.Controls.Button.SiSButton m_cmd_Cap_Nhat;
        internal SIS.Controls.Button.SiSButton m_cmd_huy;
        private TextBox m_txt_ten_nhom;
        private Label label2;
        private TextBox m_txt_ma_nhom;
        private Label label1;
		private System.ComponentModel.IContainer components;

		public f101_dm_nhom_khach_hang()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			format_controls();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f101_dm_nhom_khach_hang));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_text_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_cmd_tim_kiem = new SIS.Controls.Button.SiSButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_cmd_Cap_Nhat = new SIS.Controls.Button.SiSButton();
            this.m_cmd_huy = new SIS.Controls.Button.SiSButton();
            this.m_txt_ten_nhom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_txt_ma_nhom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // m_pnl_out_place_dm
            // 
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_insert);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 373);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(528, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
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
            this.m_cmd_insert.Location = new System.Drawing.Point(172, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 12;
            this.m_cmd_insert.Text = "&Thêm";
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
            this.m_cmd_update.Location = new System.Drawing.Point(260, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 13;
            this.m_cmd_update.Text = "&Sửa";
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
            this.m_cmd_delete.Location = new System.Drawing.Point(348, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(436, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Location = new System.Drawing.Point(0, 58);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(508, 176);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            this.m_fg.DoubleClick += new System.EventHandler(this.m_fg_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_text_tim_kiem);
            this.groupBox1.Controls.Add(this.m_cmd_tim_kiem);
            this.groupBox1.Controls.Add(this.m_fg);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 234);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách nhóm khách hàng";
            // 
            // m_text_tim_kiem
            // 
            this.m_text_tim_kiem.Location = new System.Drawing.Point(38, 22);
            this.m_text_tim_kiem.Multiline = true;
            this.m_text_tim_kiem.Name = "m_text_tim_kiem";
            this.m_text_tim_kiem.Size = new System.Drawing.Size(265, 25);
            this.m_text_tim_kiem.TabIndex = 23;
            // 
            // m_cmd_tim_kiem
            // 
            this.m_cmd_tim_kiem.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_tim_kiem.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_tim_kiem.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_tim_kiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_tim_kiem.ImageIndex = 18;
            this.m_cmd_tim_kiem.ImageList = this.ImageList;
            this.m_cmd_tim_kiem.Location = new System.Drawing.Point(330, 22);
            this.m_cmd_tim_kiem.Name = "m_cmd_tim_kiem";
            this.m_cmd_tim_kiem.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_tim_kiem.TabIndex = 22;
            this.m_cmd_tim_kiem.Text = "Tìm kiếm";
            this.m_cmd_tim_kiem.Click += new System.EventHandler(this.m_cmd_tim_kiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_cmd_Cap_Nhat);
            this.groupBox2.Controls.Add(this.m_cmd_huy);
            this.groupBox2.Controls.Add(this.m_txt_ten_nhom);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.m_txt_ma_nhom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 133);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cập nhật nhóm khách hàng";
            // 
            // m_cmd_Cap_Nhat
            // 
            this.m_cmd_Cap_Nhat.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_Cap_Nhat.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_Cap_Nhat.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_Cap_Nhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_Cap_Nhat.ImageIndex = 10;
            this.m_cmd_Cap_Nhat.ImageList = this.ImageList;
            this.m_cmd_Cap_Nhat.Location = new System.Drawing.Point(96, 99);
            this.m_cmd_Cap_Nhat.Name = "m_cmd_Cap_Nhat";
            this.m_cmd_Cap_Nhat.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_Cap_Nhat.TabIndex = 15;
            this.m_cmd_Cap_Nhat.Text = "&Cập nhật";
            this.m_cmd_Cap_Nhat.Click += new System.EventHandler(this.m_cmd_Cap_Nhat_Click);
            // 
            // m_cmd_huy
            // 
            this.m_cmd_huy.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_huy.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_huy.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_huy.ImageIndex = 4;
            this.m_cmd_huy.ImageList = this.ImageList;
            this.m_cmd_huy.Location = new System.Drawing.Point(190, 99);
            this.m_cmd_huy.Name = "m_cmd_huy";
            this.m_cmd_huy.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_huy.TabIndex = 16;
            this.m_cmd_huy.Text = "&Hủy";
            this.m_cmd_huy.Click += new System.EventHandler(this.m_cmd_huy_Click);
            // 
            // m_txt_ten_nhom
            // 
            this.m_txt_ten_nhom.Location = new System.Drawing.Point(96, 61);
            this.m_txt_ten_nhom.Name = "m_txt_ten_nhom";
            this.m_txt_ten_nhom.Size = new System.Drawing.Size(236, 20);
            this.m_txt_ten_nhom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhóm";
            // 
            // m_txt_ma_nhom
            // 
            this.m_txt_ma_nhom.Location = new System.Drawing.Point(96, 28);
            this.m_txt_ma_nhom.Name = "m_txt_ma_nhom";
            this.m_txt_ma_nhom.Size = new System.Drawing.Size(236, 20);
            this.m_txt_ma_nhom.TabIndex = 1;
            this.m_txt_ma_nhom.TextChanged += new System.EventHandler(this.m_txt_ma_nhom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhóm";
            // 
            // f101_dm_nhom_khach_hang
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(528, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "f101_dm_nhom_khach_hang";
            this.Text = "f101-Danh sách nhóm khách hàng";
            this.Load += new System.EventHandler(this.f101_dm_nhom_khach_hang_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
		#endregion

		#region Data Structure
		private enum e_col_Number{
			TEN_NHOM = 3
,ID = 1
,MA_NHOM = 2

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_DM_NHOM_KHACH_HANG m_ds_dm_nhom_khach_hang = new DS_DM_NHOM_KHACH_HANG();
		US_DM_NHOM_KHACH_HANG m_us_dm_nhom_khach_hang = new US_DM_NHOM_KHACH_HANG();
        DataEntryFormMode m_e_form_mode = new DataEntryFormMode();
		#endregion

		#region Private Methods
		private void format_controls(){
			CControlFormat.setFormStyle(this);
			CControlFormat.setC1FlexFormat(m_fg);
			set_define_events();
			this.KeyPreview = true;		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(DM_NHOM_KHACH_HANG.TEN_NHOM, e_col_Number.TEN_NHOM);
			v_htb.Add(DM_NHOM_KHACH_HANG.ID, e_col_Number.ID);
			v_htb.Add(DM_NHOM_KHACH_HANG.MA_NHOM, e_col_Number.MA_NHOM);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds_dm_nhom_khach_hang.DM_NHOM_KHACH_HANG.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds_dm_nhom_khach_hang = new DS_DM_NHOM_KHACH_HANG();			
			m_us_dm_nhom_khach_hang.FillDataset(m_ds_dm_nhom_khach_hang);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds_dm_nhom_khach_hang, m_fg, m_obj_trans);
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_DM_NHOM_KHACH_HANG i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_DM_NHOM_KHACH_HANG i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_dm_nhom_khach_hang(){			
		//	f101_dm_nhom_khach_hang_DE v_fDE = new  f101_dm_nhom_khach_hang_DE();	
            m_txt_ma_nhom.Focus();				
            display_for_insert();
			load_data_2_grid();
		}

        private void display_for_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
        }

		private void update_dm_nhom_khach_hang(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us_dm_nhom_khach_hang, m_fg.Row);
		//	f101_dm_nhom_khach_hang_DE v_fDE = new f101_dm_nhom_khach_hang_DE();
            display_for_update(m_us_dm_nhom_khach_hang);
			load_data_2_grid();
		}

        private void display_for_update(US_DM_NHOM_KHACH_HANG m_us_dm_nhom_khach_hang)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us_obj_to_form();

        }

        private void m_us_obj_to_form()
        {
            m_txt_ma_nhom.Text = m_us_dm_nhom_khach_hang.strMA_NHOM;
            m_txt_ten_nhom.Text = m_us_dm_nhom_khach_hang.strTEN_NHOM;
        }
				
		private void delete_dm_nhom_khach_hang(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_DM_NHOM_KHACH_HANG v_us = new US_DM_NHOM_KHACH_HANG();
			grid2us_object(v_us, m_fg.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_fg.Rows.Remove(m_fg.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_dm_nhom_khach_hang(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us_dm_nhom_khach_hang, m_fg.Row);
		//	f101_dm_nhom_khach_hang_DE v_fDE = new f101_dm_nhom_khach_hang_DE();			
		//	v_fDE.display(m_us);
		}
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
			m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
			m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
			m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
            //m_cmd_view.Click += new EventHandler(m_cmd_view_Click);
		}
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f101_dm_nhom_khach_hang_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}

		private void m_cmd_exit_Click(object sender, EventArgs e) {
			try{
				this.Close();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_insert_Click(object sender, EventArgs e) {
			try{
				insert_dm_nhom_khach_hang();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_dm_nhom_khach_hang();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_dm_nhom_khach_hang();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_dm_nhom_khach_hang();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

        private void m_cmd_Cap_Nhat_Click(object sender, EventArgs e)
        {
            try
            {
                save_data();
                m_e_form_mode = DataEntryFormMode.InsertDataState;
                
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
           
        }

        private void save_data()
        {
            try
            {
                m_form_to_us_obj();
                switch (m_e_form_mode)
                {
                    case DataEntryFormMode.InsertDataState:
                        m_us_dm_nhom_khach_hang.Insert();
                        break;
                    case DataEntryFormMode.UpdateDataState:
                        m_us_dm_nhom_khach_hang.Update();
                        break;
                    default: m_us_dm_nhom_khach_hang.Insert(); ; break;
                }
                
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
            m_txt_ma_nhom.Clear();
            m_txt_ten_nhom.Clear();
            load_data_2_grid();
        }

        private void m_form_to_us_obj()
        {
            m_us_dm_nhom_khach_hang.strMA_NHOM = m_txt_ma_nhom.Text;
            m_us_dm_nhom_khach_hang.strTEN_NHOM = m_txt_ten_nhom.Text;
        }

        private void m_cmd_huy_Click(object sender, EventArgs e)
        {
            m_txt_ma_nhom.Clear();
            m_txt_ten_nhom.Clear();
        }

        private void m_cmd_tim_kiem_Click(object sender, EventArgs e)
        {
            string v_str_tu_khoa = m_text_tim_kiem.Text;
            US_DM_NHOM_KHACH_HANG v_us_dm_nhom_khach_hang = new US_DM_NHOM_KHACH_HANG();
            DS_DM_NHOM_KHACH_HANG v_ds_dm_nhom_khach_hang = new DS_DM_NHOM_KHACH_HANG();
            v_us_dm_nhom_khach_hang.FillDatasetSearch(v_ds_dm_nhom_khach_hang, v_str_tu_khoa);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_dm_nhom_khach_hang, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }

        private void m_txt_ma_nhom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                insert_dm_nhom_khach_hang();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_fg_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                update_dm_nhom_khach_hang();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

	}
}

