///************************************************
/// Generated by: DungNT
/// Date: 31/03/2014 03:23:10
/// Goal: Create Form for DM_DANH_MUC_THUOC
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
using IP.Core.IPSystemAdmin;

namespace BKI_QLHT
{



	public class f500_dm_danh_muc_thuoc : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_grv_danh_muc_thuoc;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
        internal SIS.Controls.Button.SiSButton m_cmd_update;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private TextBox m_txt_tu_khoa;
        internal SIS.Controls.Button.SiSButton m_cmd_huy;
        internal SIS.Controls.Button.SiSButton m_cmd_save;
        private Label label2;
        private Label label1;
        private TextBox m_txt_ghi_chu;
        private TextBox m_txt_ten_danh_muc;
        private Label label5;
		private System.ComponentModel.IContainer components;

		public f500_dm_danh_muc_thuoc()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f500_dm_danh_muc_thuoc));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_grv_danh_muc_thuoc = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_txt_tu_khoa = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.m_cmd_huy = new SIS.Controls.Button.SiSButton();
            this.m_cmd_save = new SIS.Controls.Button.SiSButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_txt_ghi_chu = new System.Windows.Forms.TextBox();
            this.m_txt_ten_danh_muc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_muc_thuoc)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_update);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_delete);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 399);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(686, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
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
            this.m_cmd_update.Location = new System.Drawing.Point(418, 4);
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
            this.m_cmd_delete.Location = new System.Drawing.Point(506, 4);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(594, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_grv_danh_muc_thuoc
            // 
            this.m_grv_danh_muc_thuoc.ColumnInfo = resources.GetString("m_grv_danh_muc_thuoc.ColumnInfo");
            this.m_grv_danh_muc_thuoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_grv_danh_muc_thuoc.Location = new System.Drawing.Point(0, 233);
            this.m_grv_danh_muc_thuoc.Name = "m_grv_danh_muc_thuoc";
            this.m_grv_danh_muc_thuoc.Size = new System.Drawing.Size(686, 166);
            this.m_grv_danh_muc_thuoc.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_grv_danh_muc_thuoc.Styles"));
            this.m_grv_danh_muc_thuoc.TabIndex = 20;
            this.m_grv_danh_muc_thuoc.DoubleClick += new System.EventHandler(this.m_fg_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(243, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Danh sách danh mục thuốc";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.m_cmd_search);
            this.panel1.Controls.Add(this.m_txt_tu_khoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(8, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 72);
            this.panel1.TabIndex = 23;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 5;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(355, 36);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 25);
            this.m_cmd_search.TabIndex = 24;
            this.m_cmd_search.Text = "&Tìm kiếm";
            this.m_cmd_search.Click += new System.EventHandler(this.m_cmd_search_Click);
            // 
            // m_txt_tu_khoa
            // 
            this.m_txt_tu_khoa.Location = new System.Drawing.Point(110, 36);
            this.m_txt_tu_khoa.Name = "m_txt_tu_khoa";
            this.m_txt_tu_khoa.Size = new System.Drawing.Size(226, 20);
            this.m_txt_tu_khoa.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 34);
            this.panel2.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(239, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cập nhật thông tin Danh mục thuốc";
            // 
            // m_cmd_huy
            // 
            this.m_cmd_huy.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_huy.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_huy.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_huy.ImageIndex = 9;
            this.m_cmd_huy.ImageList = this.ImageList;
            this.m_cmd_huy.Location = new System.Drawing.Point(397, 115);
            this.m_cmd_huy.Name = "m_cmd_huy";
            this.m_cmd_huy.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_huy.TabIndex = 30;
            this.m_cmd_huy.Text = "&Hủy";
            this.m_cmd_huy.Click += new System.EventHandler(this.m_cmd_huy_Click);
            // 
            // m_cmd_save
            // 
            this.m_cmd_save.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_save.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_save.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_save.ImageIndex = 10;
            this.m_cmd_save.ImageList = this.ImageList;
            this.m_cmd_save.Location = new System.Drawing.Point(303, 115);
            this.m_cmd_save.Name = "m_cmd_save";
            this.m_cmd_save.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_save.TabIndex = 29;
            this.m_cmd_save.Text = "&Lưu";
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(125, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ghi chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(125, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tên danh mục";
            // 
            // m_txt_ghi_chu
            // 
            this.m_txt_ghi_chu.Location = new System.Drawing.Point(255, 82);
            this.m_txt_ghi_chu.Name = "m_txt_ghi_chu";
            this.m_txt_ghi_chu.Size = new System.Drawing.Size(269, 20);
            this.m_txt_ghi_chu.TabIndex = 26;
            // 
            // m_txt_ten_danh_muc
            // 
            this.m_txt_ten_danh_muc.Location = new System.Drawing.Point(255, 48);
            this.m_txt_ten_danh_muc.Name = "m_txt_ten_danh_muc";
            this.m_txt_ten_danh_muc.Size = new System.Drawing.Size(269, 20);
            this.m_txt_ten_danh_muc.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(35, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Từ khóa";
            // 
            // f500_dm_danh_muc_thuoc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(686, 435);
            this.Controls.Add(this.m_cmd_huy);
            this.Controls.Add(this.m_cmd_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_txt_ghi_chu);
            this.Controls.Add(this.m_txt_ten_danh_muc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_grv_danh_muc_thuoc);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f500_dm_danh_muc_thuoc";
            this.Text = "f500_dm_danh_muc_thuoc";
            this.Load += new System.EventHandler(this.f500_dm_danh_muc_thuoc_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_danh_muc_thuoc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region Public Interface
		public void display(){			
			this.ShowDialog();
		}
		#endregion

		#region Data Structure
		private enum e_col_Number{
			TEN_DANH_MUC = 1,GHI_CHU = 2
		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;		
		DS_DM_DANH_MUC_THUOC m_ds = new DS_DM_DANH_MUC_THUOC();
		US_DM_DANH_MUC_THUOC m_us = new US_DM_DANH_MUC_THUOC();
        DataEntryFormMode m_e_form_mode=DataEntryFormMode.InsertDataState;
		#endregion

		#region Private Methods
		private void format_controls(){
            //m_pnl_danh_muc.Enabled = false;

            //CControlFormat.setFormStyle(this);
			CControlFormat.setC1FlexFormat(m_grv_danh_muc_thuoc);
            //CControlFormat.setFormStyle(this, new CAppContext_201(), IPFormStyle.DialogForm);
			set_define_events();
			this.KeyPreview = true;
		
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_grv_danh_muc_thuoc);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(DM_DANH_MUC_THUOC.TEN_DANH_MUC, e_col_Number.TEN_DANH_MUC);			v_htb.Add(DM_DANH_MUC_THUOC.GHI_CHU, e_col_Number.GHI_CHU);									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds.DM_DANH_MUC_THUOC.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds = new DS_DM_DANH_MUC_THUOC();			
			m_us.FillDataset(m_ds);
			m_grv_danh_muc_thuoc.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds, m_grv_danh_muc_thuoc, m_obj_trans);
			m_grv_danh_muc_thuoc.Redraw = true;
		}
		private void grid2us_object(US_DM_DANH_MUC_THUOC i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_grv_danh_muc_thuoc.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_DM_DANH_MUC_THUOC i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_grv_danh_muc_thuoc.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}
        private void save_data() {
            form_2_us_obj();
            switch(m_e_form_mode){
                case DataEntryFormMode.InsertDataState:
                m_us.Insert();
                break;
                case DataEntryFormMode.UpdateDataState:
                m_us.Update();
                break;
                default: m_us.Insert(); break;
            }
            m_txt_ten_danh_muc.Clear();
            m_txt_ghi_chu.Clear();
            load_data_2_grid();
            
        }


		private void insert_dm_danh_muc_thuoc(){			
		//	f500_dm_danh_muc_thuoc_DE v_fDE = new  f500_dm_danh_muc_thuoc_DE();
            m_txt_ten_danh_muc.Focus();					
            display_pnl_insert();
            load_data_2_grid();
		}

        private void display_pnl_insert()
        {
            m_e_form_mode = DataEntryFormMode.InsertDataState;
           
        }

        

        private void form_2_us_obj()
        {
            m_us.strTEN_DANH_MUC = m_txt_ten_danh_muc.Text;
            m_us.strGHI_CHU = m_txt_ghi_chu.Text;
        }
        private void us_obj_2_form() {
            m_txt_ghi_chu.Text = m_us.strGHI_CHU;
            m_txt_ten_danh_muc.Text = m_us.strTEN_DANH_MUC;
        }

		private void update_dm_danh_muc_thuoc(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_danh_muc_thuoc)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_danh_muc_thuoc, m_grv_danh_muc_thuoc.Row)) return;			
			grid2us_object(m_us, m_grv_danh_muc_thuoc.Row);
		//	f500_dm_danh_muc_thuoc_DE v_fDE = new f500_dm_danh_muc_thuoc_DE();
		   display_pnl_update(m_us);
           
			load_data_2_grid();
		}

        private void display_pnl_update(US_DM_DANH_MUC_THUOC m_us_test)
        {
            m_e_form_mode = DataEntryFormMode.UpdateDataState;
            m_us = m_us_test;
            us_obj_2_form();
        }
				
		private void delete_dm_danh_muc_thuoc(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_danh_muc_thuoc)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_danh_muc_thuoc, m_grv_danh_muc_thuoc.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_DM_DANH_MUC_THUOC v_us = new US_DM_DANH_MUC_THUOC();
			grid2us_object(v_us, m_grv_danh_muc_thuoc.Row);
			try {			
				v_us.BeginTransaction();    											
				v_us.Delete();                      								
				v_us.CommitTransaction();
				m_grv_danh_muc_thuoc.Rows.Remove(m_grv_danh_muc_thuoc.Row);				
			}
			catch (Exception v_e) {
				v_us.Rollback();
				CDBExceptionHandler v_objErrHandler = new CDBExceptionHandler(v_e,
					new CDBClientDBExceptionInterpret());
				v_objErrHandler.showErrorMessage();
			}
		}

		private void view_dm_danh_muc_thuoc(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_grv_danh_muc_thuoc)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_grv_danh_muc_thuoc, m_grv_danh_muc_thuoc.Row)) return;
			grid2us_object(m_us, m_grv_danh_muc_thuoc.Row);
		//	f500_dm_danh_muc_thuoc_DE v_fDE = new f500_dm_danh_muc_thuoc_DE();			
		 display_pnl_view(m_us);
		}

        private void display_pnl_view(US_DM_DANH_MUC_THUOC m_us_test)
        {
            m_us = m_us_test;
           m_cmd_save.Visible = false;
            us_obj_2_form();
        }
		private void set_define_events(){
			m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            //m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
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
		private void f500_dm_danh_muc_thuoc_Load(object sender, System.EventArgs e) {
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
               
				insert_dm_danh_muc_thuoc();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
                
				update_dm_danh_muc_thuoc();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_dm_danh_muc_thuoc();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
                
				view_dm_danh_muc_thuoc();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

        private void m_cmd_save_Click(object sender, EventArgs e)
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

        private void m_cmd_huy_Click(object sender, EventArgs e)
        {
            try
            {
                m_txt_ten_danh_muc.Clear();
                m_txt_ghi_chu.Clear();
                m_cmd_save.Visible= true;
                m_e_form_mode = DataEntryFormMode.InsertDataState;
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
                update_dm_danh_muc_thuoc();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            string v_str_tu_khoa = m_txt_tu_khoa.Text;
            US_DM_DANH_MUC_THUOC v_us_danh_muc_thuoc = new US_DM_DANH_MUC_THUOC();
            DS_DM_DANH_MUC_THUOC v_ds_danh_muc_thuoc = new DS_DM_DANH_MUC_THUOC();
            v_us_danh_muc_thuoc.FillDataseSearch(v_ds_danh_muc_thuoc, v_str_tu_khoa);
            m_grv_danh_muc_thuoc.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_danh_muc_thuoc, m_grv_danh_muc_thuoc, m_obj_trans);
            m_grv_danh_muc_thuoc.Redraw = true;
        }

        private void m_pnl_danh_muc_Paint(object sender, PaintEventArgs e)
        {

        }

	}
}

