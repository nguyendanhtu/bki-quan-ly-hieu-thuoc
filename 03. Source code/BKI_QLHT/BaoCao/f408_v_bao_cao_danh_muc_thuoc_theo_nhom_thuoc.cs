///************************************************
/// Generated by: TuNA
/// Date: 01-05-2014 04:00:11
/// Goal: Create Form for V_DM_THUOC
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
using IP.Core.IPSystemAdmin;
using IP.Core.IPExcelReport;
using BKI_QLHT.US;
using BKI_QLHT.DS;
using BKI_QLHT.DanhMuc;
using BKI_QLHT.DS.CDBNames;
using System.Web;
using C1.Win.C1FlexGrid;


namespace BKI_QLHT
{



	public class f408_v_bao_cao_danh_muc_thuoc_theo_nhom_thuoc : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_exit;
		internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private TextBox m_txt_tim_kiem;
        private Label m_lbl_nguoi_lam_bao_cao;
        private Label label2;
        private Label label3;
        private Label m_lbl_ngay_lam_bc;
        private Label m_lbl_nguoi_lam_bc;
		private System.ComponentModel.IContainer components;

		public f408_v_bao_cao_danh_muc_thuoc_theo_nhom_thuoc()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f408_v_bao_cao_danh_muc_thuoc_theo_nhom_thuoc));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_lbl_nguoi_lam_bao_cao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_lbl_ngay_lam_bc = new System.Windows.Forms.Label();
            this.m_lbl_nguoi_lam_bc = new System.Windows.Forms.Label();
            this.m_pnl_out_place_dm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).BeginInit();
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
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_xuat_excel);
            this.m_pnl_out_place_dm.Controls.Add(this.m_cmd_exit);
            this.m_pnl_out_place_dm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 435);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(928, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_xuat_excel
            // 
            this.m_cmd_xuat_excel.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_xuat_excel.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_xuat_excel.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_xuat_excel.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_xuat_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_xuat_excel.ImageIndex = 19;
            this.m_cmd_xuat_excel.ImageList = this.ImageList;
            this.m_cmd_xuat_excel.Location = new System.Drawing.Point(4, 4);
            this.m_cmd_xuat_excel.Name = "m_cmd_xuat_excel";
            this.m_cmd_xuat_excel.Size = new System.Drawing.Size(115, 28);
            this.m_cmd_xuat_excel.TabIndex = 21;
            this.m_cmd_xuat_excel.Text = "Xuất ra Excel";
            //this.m_cmd_xuat_excel.Click += new System.EventHandler(this.m_cmd_xuat_excel_Click);
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
            this.m_cmd_exit.Location = new System.Drawing.Point(836, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Location = new System.Drawing.Point(0, 75);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(924, 354);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 18;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(657, 7);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 2695;
            this.m_cmd_search.Text = "Tìm kiếm";
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_txt_tim_kiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_tim_kiem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(236, 12);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(401, 20);
            this.m_txt_tim_kiem.TabIndex = 2694;
            // 
            // m_lbl_nguoi_lam_bao_cao
            // 
            this.m_lbl_nguoi_lam_bao_cao.AutoSize = true;
            this.m_lbl_nguoi_lam_bao_cao.Location = new System.Drawing.Point(111, 45);
            this.m_lbl_nguoi_lam_bao_cao.Name = "m_lbl_nguoi_lam_bao_cao";
            this.m_lbl_nguoi_lam_bao_cao.Size = new System.Drawing.Size(96, 13);
            this.m_lbl_nguoi_lam_bao_cao.TabIndex = 2697;
            this.m_lbl_nguoi_lam_bao_cao.Text = "Người làm báo cáo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2698;
            this.label2.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2700;
            this.label3.Text = "Ngày làm báo cáo";
            // 
            // m_lbl_ngay_lam_bc
            // 
            this.m_lbl_ngay_lam_bc.AutoSize = true;
            this.m_lbl_ngay_lam_bc.Location = new System.Drawing.Point(577, 45);
            this.m_lbl_ngay_lam_bc.Name = "m_lbl_ngay_lam_bc";
            this.m_lbl_ngay_lam_bc.Size = new System.Drawing.Size(60, 13);
            this.m_lbl_ngay_lam_bc.TabIndex = 2701;
            this.m_lbl_ngay_lam_bc.Text = "m_lbl_ngay";
            // 
            // m_lbl_nguoi_lam_bc
            // 
            this.m_lbl_nguoi_lam_bc.AutoSize = true;
            this.m_lbl_nguoi_lam_bc.Location = new System.Drawing.Point(233, 45);
            this.m_lbl_nguoi_lam_bc.Name = "m_lbl_nguoi_lam_bc";
            this.m_lbl_nguoi_lam_bc.Size = new System.Drawing.Size(63, 13);
            this.m_lbl_nguoi_lam_bc.TabIndex = 2702;
            this.m_lbl_nguoi_lam_bc.Text = "m_lbl_nguoi";
            // 
            // f408_v_bao_cao_danh_muc_thuoc_theo_nhom_thuoc
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(928, 471);
            this.Controls.Add(this.m_lbl_nguoi_lam_bc);
            this.Controls.Add(this.m_lbl_ngay_lam_bc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_lbl_nguoi_lam_bao_cao);
            this.Controls.Add(this.m_cmd_search);
            this.Controls.Add(this.m_txt_tim_kiem);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f408_v_bao_cao_danh_muc_thuoc_theo_nhom_thuoc";
            this.Text = "f408_v_bao_cao_danh_muc_thuoc_theo_nhom_thuoc";
            this.Load += new System.EventHandler(this.f408_v_bao_cao_danh_muc_thuoc_theo_nhom_thuoc_Load);
            this.m_pnl_out_place_dm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_fg)).EndInit();
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
			TT_THUOC = 3
,TUYEN_SU_DUNG_8 = 9
,TUYEN_SU_DUNG_7 = 8
,TUYEN_SU_DUNG_6 = 7
,TEN_NHOM = 1
,TUYEN_SU_DUNG_5 = 6
,TT_HOAT_CHAT = 2
,DUONG_DUNG_DANG_DUNG = 5
,TEN_THUOC = 4

		}			
		#endregion

		#region Members
        ITransferDataRow m_obj_trans;
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.ViewDataState;
        DS_V_DM_THUOC m_v_ds = new DS_V_DM_THUOC();
        US_V_DM_THUOC m_v_us = new US_V_DM_THUOC();
        US_DM_THUOC m_us = new US_DM_THUOC();
        DS_DM_THUOC m_ds = new DS_DM_THUOC();
        private const String m_str_tim_kiem = "Nhập nhóm thuốc, tên thuốc cần tìm";
        

		#endregion

		#region Private Methods
        private void load_data_2_lbl()
        {
            Decimal CUI = CAppContext_201.getCurrentUserID();
            IP.Core.IPUserService.US_HT_NGUOI_SU_DUNG v_us=new IP.Core.IPUserService.US_HT_NGUOI_SU_DUNG(CUI);
            m_lbl_ngay_lam_bc.ForeColor = Color.Red;
            m_lbl_nguoi_lam_bc.ForeColor = Color.Red;
            m_lbl_nguoi_lam_bc.Text = v_us.strTEN.Trim();
            m_lbl_ngay_lam_bc.Text = DateTime.Now.Date.ToShortDateString();
        }
        private void load_custom_source_2_m_txt_tim_kiem()
        {
            int count = m_v_ds.Tables["V_DM_THUOC"].Rows.Count;
            AutoCompleteStringCollection v_acsc_search = new AutoCompleteStringCollection();
            foreach (DataRow dr in m_v_ds.V_DM_THUOC)
            {
                v_acsc_search.Add(dr[V_DM_THUOC.TEN_NHOM].ToString());
                v_acsc_search.Add(dr[V_DM_THUOC.TEN_THUOC].ToString());
                //v_acsc_search.Add(dr[V_DM_NHASX.MA_NHASX].ToString());
            }
            m_txt_tim_kiem.AutoCompleteCustomSource = v_acsc_search;
        }
		private void format_controls(){
            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_fg.Tree.Column = (int)e_col_Number.TEN_NHOM;
            m_fg.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.SimpleLeaf;

            set_define_events();
            this.KeyPreview = true;			
		}
		private void set_initial_form_load(){						
			m_obj_trans = get_trans_object(m_fg);
			load_data_2_grid();		
		}	
		private ITransferDataRow get_trans_object(C1.Win.C1FlexGrid.C1FlexGrid i_fg){
			Hashtable v_htb = new Hashtable();
			v_htb.Add(V_DM_THUOC.TT_THUOC, e_col_Number.TT_THUOC);
			v_htb.Add(V_DM_THUOC.TUYEN_SU_DUNG_8, e_col_Number.TUYEN_SU_DUNG_8);
			v_htb.Add(V_DM_THUOC.TUYEN_SU_DUNG_7, e_col_Number.TUYEN_SU_DUNG_7);
			v_htb.Add(V_DM_THUOC.TUYEN_SU_DUNG_6, e_col_Number.TUYEN_SU_DUNG_6);
			v_htb.Add(V_DM_THUOC.TEN_NHOM, e_col_Number.TEN_NHOM);
			v_htb.Add(V_DM_THUOC.TUYEN_SU_DUNG_5, e_col_Number.TUYEN_SU_DUNG_5);
			v_htb.Add(V_DM_THUOC.TT_HOAT_CHAT, e_col_Number.TT_HOAT_CHAT);
			v_htb.Add(V_DM_THUOC.DUONG_DUNG_DANG_DUNG, e_col_Number.DUONG_DUNG_DANG_DUNG);
			v_htb.Add(V_DM_THUOC.TEN_THUOC, e_col_Number.TEN_THUOC);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_v_ds.V_DM_THUOC.NewRow());
			return v_obj_trans;			
		}
        //private void load_data_2_cbo_nguoi_lam_bc()
        //{
        //    US_CM_DM_TU_DIEN v_us_dm_tu_dien = new US_CM_DM_TU_DIEN();
        //    DS_CM_DM_TU_DIEN v_ds_dm_tu_dien = new DS_CM_DM_TU_DIEN();
        //    v_us_dm_tu_dien.FillDatasetByIdLoaiTuDien(v_ds_dm_tu_dien, 3);
        //    DataRow v_dr = v_ds_dm_tu_dien.CM_DM_TU_DIEN.NewRow();
        //    v_dr[CM_DM_TU_DIEN.ID] = -1;
        //    v_dr[CM_DM_TU_DIEN.TEN] = "------------Tất cả------------";
        //    v_dr[CM_DM_TU_DIEN.MA_TU_DIEN] = "";
        //    v_dr[CM_DM_TU_DIEN.ID_LOAI_TU_DIEN] = "3";
        //    v_dr[CM_DM_TU_DIEN.TEN_NGAN] = "";
        //    v_ds_dm_tu_dien.CM_DM_TU_DIEN.Rows.InsertAt(v_dr, 0);
        //    m_cbo_tim_kiem_trang_thai.DataSource = v_ds_dm_tu_dien.CM_DM_TU_DIEN;
        //    m_cbo_tim_kiem_trang_thai.ValueMember = CM_DM_TU_DIEN.ID;
        //    m_cbo_tim_kiem_trang_thai.DisplayMember = CM_DM_TU_DIEN.TEN;
        //    m_cbo_tim_kiem_trang_thai.SelectedIndex = 0;
        //}
		private void load_data_2_grid(){
            m_v_ds.Clear();
            //m_v_ds = new DS_V_DM_NHASX();
            if (m_txt_tim_kiem.Text.Trim() == m_str_tim_kiem || m_txt_tim_kiem.Text.Trim() == "") m_v_us.FillDatasetSearch_1(m_v_ds, "");
            else m_v_us.FillDatasetSearch_1(m_v_ds, m_txt_tim_kiem.Text.Trim());
            //m_us.FillDataset(m_ds);
            var v_str_search = m_txt_tim_kiem.Text.Trim();
            if (v_str_search.Equals(m_str_tim_kiem))
            {
                v_str_search = "";
            }
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(m_v_ds, m_fg, m_obj_trans);
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
              , 0
              , (int)e_col_Number.TEN_NHOM // chỗ này là tên trường mà mình nhóm
              , (int)e_col_Number.TEN_THUOC // chỗ này là tên trường mà mình Count
              , "{0}"
              );

            m_fg.Redraw = true;
            set_search_format_before();
		}
        private void set_search_format_before()
        {
            if (m_txt_tim_kiem.Text == "")
            {
                m_txt_tim_kiem.Text = m_str_tim_kiem;
                m_txt_tim_kiem.ForeColor = Color.Gray;
            }

        }
        private void set_search_format_after()
        {
            if (m_txt_tim_kiem.Text == m_str_tim_kiem)
            {
                m_txt_tim_kiem.Text = "";
            }
            m_txt_tim_kiem.ForeColor = Color.Black;
        }
		private void grid2us_object(US_V_DM_THUOC i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_DM_THUOC i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		
		private void set_define_events(){
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_xuat_excel.Click += new EventHandler(m_cmd_xuat_excel_Click);
            m_txt_tim_kiem.KeyDown += m_txt_tim_kiem_KeyDown;
            m_txt_tim_kiem.MouseClick += m_txt_tim_kiem_MouseClick;
            m_txt_tim_kiem.Leave += m_txt_tim_kiem_Leave;
		}
        private void export_2_excel()
        {
            CExcelReport v_obj_excel_rpt = new CExcelReport("f408_bao_cao_danh_muc_thuoc_theo_nhom_thuoc.xlsx", 9, 1);
            //người làm báo cáo
            v_obj_excel_rpt.AddFindAndReplaceItem("<nguoi_xuat_bao_cao>", m_lbl_nguoi_lam_bc.Text.Trim());
            //ngày làm báo cáo
            v_obj_excel_rpt.AddFindAndReplaceItem("<ngay_xuat_bao_cao>",m_lbl_ngay_lam_bc.Text.Trim());
            v_obj_excel_rpt.FindAndReplace(false);
            v_obj_excel_rpt.Export2ExcelWithoutFixedRows(m_fg, 1, m_fg.Cols.Count - 1, true);
        }
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f408_v_bao_cao_danh_muc_thuoc_theo_nhom_thuoc_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
                load_data_2_lbl();
                //m_lbl_ngay_lam_bc.text = DateTime.Today;
                load_custom_source_2_m_txt_tim_kiem();
               
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		
		}

        private void m_txt_tim_kiem_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                set_search_format_after();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_txt_tim_kiem_Leave(object sender, EventArgs e)
        {
            try
            {
                set_search_format_before();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_txt_tim_kiem_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    load_data_2_grid();
                }
                else
                {
                    set_search_format_after();
                }
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_search_Click(object sender, EventArgs e)
        {
            try
            {
                load_custom_source_2_m_txt_tim_kiem();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }


        private void m_cmd_xuat_excel_Click(object sender, EventArgs e)
        {
            try
            {
                export_2_excel();
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
                this.Close();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

	}
}

