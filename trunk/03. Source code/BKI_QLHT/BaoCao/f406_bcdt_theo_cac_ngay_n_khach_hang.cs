///************************************************
/// Generated by: TuNA
/// Date: 15-05-2014 12:04:11
/// Goal: Create Form for V_BC_DOANH_THU_THEO_CAC_NGAY_N_KHACH_HANG
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
using System.Globalization;

namespace BKI_QLHT
{



	public class f406_bcdt_theo_cac_ngay_n_khach_hang : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
        private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        internal SIS.Controls.Button.SiSButton m_cmd_xuat_excel;
        private Label label7;
        private DateTimePicker m_dat_den_ngay;
        private DateTimePicker m_dat_tu_ngay;
        private Label label6;
        private Label label5;
        internal SIS.Controls.Button.SiSButton m_cmd_search;
        private TextBox m_txt_tim_kiem;
        private Label m_lbl_nguoi_lam_bc;
        private Label m_lbl_ngay_lam_bc;
        private Label label3;
        private Label m_lbl_nguoi_lam_bao_cao;
        private Label m_lbl_doanh_thu;
        private Label label2;
        private Label m_lbl_count;
        private Label label1;
		private System.ComponentModel.IContainer components;

		public f406_bcdt_theo_cac_ngay_n_khach_hang()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f406_bcdt_theo_cac_ngay_n_khach_hang));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.m_cmd_xuat_excel = new SIS.Controls.Button.SiSButton();
            this.label7 = new System.Windows.Forms.Label();
            this.m_dat_den_ngay = new System.Windows.Forms.DateTimePicker();
            this.m_dat_tu_ngay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_cmd_search = new SIS.Controls.Button.SiSButton();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_lbl_nguoi_lam_bc = new System.Windows.Forms.Label();
            this.m_lbl_ngay_lam_bc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_lbl_nguoi_lam_bao_cao = new System.Windows.Forms.Label();
            this.m_lbl_doanh_thu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_lbl_count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 373);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(864, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
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
            this.m_cmd_exit.Location = new System.Drawing.Point(772, 4);
            this.m_cmd_exit.Name = "m_cmd_exit";
            this.m_cmd_exit.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_exit.TabIndex = 11;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Location = new System.Drawing.Point(0, 135);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(864, 238);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
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
            this.m_cmd_xuat_excel.TabIndex = 33;
            this.m_cmd_xuat_excel.Text = "Xuất ra Excel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2846;
            this.label7.Text = "Đến ngày";
            // 
            // m_dat_den_ngay
            // 
            this.m_dat_den_ngay.Checked = false;
            this.m_dat_den_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_den_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_den_ngay.Location = new System.Drawing.Point(537, 49);
            this.m_dat_den_ngay.Name = "m_dat_den_ngay";
            this.m_dat_den_ngay.ShowCheckBox = true;
            this.m_dat_den_ngay.Size = new System.Drawing.Size(106, 20);
            this.m_dat_den_ngay.TabIndex = 2845;
            // 
            // m_dat_tu_ngay
            // 
            this.m_dat_tu_ngay.Checked = false;
            this.m_dat_tu_ngay.CustomFormat = "dd/MM/yyyy";
            this.m_dat_tu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_dat_tu_ngay.Location = new System.Drawing.Point(242, 49);
            this.m_dat_tu_ngay.Name = "m_dat_tu_ngay";
            this.m_dat_tu_ngay.ShowCheckBox = true;
            this.m_dat_tu_ngay.Size = new System.Drawing.Size(106, 20);
            this.m_dat_tu_ngay.TabIndex = 2844;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2843;
            this.label6.Text = "Từ ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2842;
            this.label5.Text = "Tìm kiếm";
            // 
            // m_cmd_search
            // 
            this.m_cmd_search.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_search.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_search.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_search.ImageIndex = 18;
            this.m_cmd_search.ImageList = this.ImageList;
            this.m_cmd_search.Location = new System.Drawing.Point(663, 13);
            this.m_cmd_search.Name = "m_cmd_search";
            this.m_cmd_search.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_search.TabIndex = 2841;
            this.m_cmd_search.Text = "Tìm kiếm";
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.m_txt_tim_kiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.m_txt_tim_kiem.ForeColor = System.Drawing.SystemColors.GrayText;
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(242, 18);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(401, 20);
            this.m_txt_tim_kiem.TabIndex = 2840;
            // 
            // m_lbl_nguoi_lam_bc
            // 
            this.m_lbl_nguoi_lam_bc.AutoSize = true;
            this.m_lbl_nguoi_lam_bc.Location = new System.Drawing.Point(777, 88);
            this.m_lbl_nguoi_lam_bc.Name = "m_lbl_nguoi_lam_bc";
            this.m_lbl_nguoi_lam_bc.Size = new System.Drawing.Size(63, 13);
            this.m_lbl_nguoi_lam_bc.TabIndex = 2839;
            this.m_lbl_nguoi_lam_bc.Text = "m_lbl_nguoi";
            // 
            // m_lbl_ngay_lam_bc
            // 
            this.m_lbl_ngay_lam_bc.AutoSize = true;
            this.m_lbl_ngay_lam_bc.Location = new System.Drawing.Point(777, 110);
            this.m_lbl_ngay_lam_bc.Name = "m_lbl_ngay_lam_bc";
            this.m_lbl_ngay_lam_bc.Size = new System.Drawing.Size(60, 13);
            this.m_lbl_ngay_lam_bc.TabIndex = 2838;
            this.m_lbl_ngay_lam_bc.Text = "m_lbl_ngay";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 2837;
            this.label3.Text = "Ngày làm báo cáo";
            // 
            // m_lbl_nguoi_lam_bao_cao
            // 
            this.m_lbl_nguoi_lam_bao_cao.AutoSize = true;
            this.m_lbl_nguoi_lam_bao_cao.Location = new System.Drawing.Point(660, 88);
            this.m_lbl_nguoi_lam_bao_cao.Name = "m_lbl_nguoi_lam_bao_cao";
            this.m_lbl_nguoi_lam_bao_cao.Size = new System.Drawing.Size(96, 13);
            this.m_lbl_nguoi_lam_bao_cao.TabIndex = 2836;
            this.m_lbl_nguoi_lam_bao_cao.Text = "Người làm báo cáo";
            // 
            // m_lbl_doanh_thu
            // 
            this.m_lbl_doanh_thu.AutoSize = true;
            this.m_lbl_doanh_thu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_doanh_thu.Location = new System.Drawing.Point(209, 110);
            this.m_lbl_doanh_thu.Name = "m_lbl_doanh_thu";
            this.m_lbl_doanh_thu.Size = new System.Drawing.Size(28, 13);
            this.m_lbl_doanh_thu.TabIndex = 2835;
            this.m_lbl_doanh_thu.Text = "000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2834;
            this.label2.Text = "Tổng doanh thu";
            // 
            // m_lbl_count
            // 
            this.m_lbl_count.AutoSize = true;
            this.m_lbl_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lbl_count.Location = new System.Drawing.Point(209, 88);
            this.m_lbl_count.Name = "m_lbl_count";
            this.m_lbl_count.Size = new System.Drawing.Size(28, 13);
            this.m_lbl_count.TabIndex = 2833;
            this.m_lbl_count.Text = "000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 2832;
            this.label1.Text = "Số kết quả trong báo cáo";
            // 
            // f406_bcdt_theo_cac_ngay_n_khach_hang
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(864, 409);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.m_dat_den_ngay);
            this.Controls.Add(this.m_dat_tu_ngay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_cmd_search);
            this.Controls.Add(this.m_txt_tim_kiem);
            this.Controls.Add(this.m_lbl_nguoi_lam_bc);
            this.Controls.Add(this.m_lbl_ngay_lam_bc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_lbl_nguoi_lam_bao_cao);
            this.Controls.Add(this.m_lbl_doanh_thu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_lbl_count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_fg);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.Name = "f406_bcdt_theo_cac_ngay_n_khach_hang";
            this.Text = "f406_bcdt_theo_cac_ngay_n_khach_hang";
            this.Load += new System.EventHandler(this.f406_bcdt_theo_cac_ngay_n_khach_hang_Load);
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
			MA_KHACH_HANG = 2
,TEN_KHACH_HANG = 3
,DOANH_THU = 6
,NGAY_GIAO_DICH = 1
,TONG_SO_LUONG_BAN = 4
,DON_VI_TINH = 5

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;
        DataEntryFormMode m_e_form_mode = DataEntryFormMode.ViewDataState;
        private const String m_str_tim_kiem = "Nhập mã khách hàng, tên khách hàng cần tìm";
        DateTime v_dat_ngay_bd;
        DateTime v_dat_ngay_kt;
		DS_V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG m_v_ds = new DS_V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG();
		US_V_BC_DOANH_THU_THEO_CAC_NGAY_N_KHACH_HANG m_v_us = new US_V_BC_DOANH_THU_THEO_CAC_NGAY_N_KHACH_HANG();
		#endregion

		#region Private Methods
        private void load_data_2_lbl()
        {
            Decimal CUI = CAppContext_201.getCurrentUserID();
            IP.Core.IPUserService.US_HT_NGUOI_SU_DUNG v_us = new IP.Core.IPUserService.US_HT_NGUOI_SU_DUNG(CUI);
            //m_lbl_ngay_lam_bc.ForeColor = Color.Red;
            //m_lbl_nguoi_lam_bc.ForeColor = Color.Red;
            m_lbl_count.ForeColor = Color.Red;
            m_lbl_doanh_thu.ForeColor = Color.Red;
            m_lbl_nguoi_lam_bc.Text = v_us.strTEN.Trim();
            m_lbl_ngay_lam_bc.Text = DateTime.Now.Date.ToShortDateString();
        }
        private void load_custom_source_2_m_txt_tim_kiem()
        {
            int count = m_v_ds.Tables["V_BC_DOANH_THU_THEO_CAC_NGAY_N_KHACH_HANG"].Rows.Count;
            AutoCompleteStringCollection v_acsc_search = new AutoCompleteStringCollection();
            foreach (DataRow dr in m_v_ds.V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG)
            {
                v_acsc_search.Add(dr[V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG.MA_KHACH_HANG].ToString());
                v_acsc_search.Add(dr[V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG.TEN_KHACH_HANG].ToString());
            }
            m_txt_tim_kiem.AutoCompleteCustomSource = v_acsc_search;
        }
        private void format_controls()
        {

            CControlFormat.setFormStyle(this);
            CControlFormat.setC1FlexFormat(m_fg);
            CGridUtils.AddSave_Excel_Handlers(m_fg);
            CGridUtils.AddSearch_Handlers(m_fg);
            m_fg.Tree.Column = (int)e_col_Number.MA_KHACH_HANG;
            m_fg.Cols[(int)e_col_Number.NGAY_GIAO_DICH].Visible = false;
            m_fg.Cols[0].Caption = "STT";
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
			v_htb.Add(V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG.MA_KHACH_HANG, e_col_Number.MA_KHACH_HANG);
			v_htb.Add(V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG.TEN_KHACH_HANG, e_col_Number.TEN_KHACH_HANG);
			v_htb.Add(V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG.DOANH_THU, e_col_Number.DOANH_THU);
			v_htb.Add(V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG.NGAY_GIAO_DICH, e_col_Number.NGAY_GIAO_DICH);
			v_htb.Add(V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG.TONG_SO_LUONG_BAN, e_col_Number.TONG_SO_LUONG_BAN);
			v_htb.Add(V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG.DON_VI_TINH, e_col_Number.DON_VI_TINH);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_v_ds.V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){
            m_v_ds.Clear();
            if (!m_dat_tu_ngay.Checked)
            {
                v_dat_ngay_bd = new DateTime(1970, 1, 1);
            }
            else
            {
                v_dat_ngay_bd = m_dat_tu_ngay.Value;
            }

            if (!m_dat_den_ngay.Checked)
            {
                v_dat_ngay_kt = new DateTime(2050, 12, 31);
            }
            else
            {
                v_dat_ngay_kt = m_dat_den_ngay.Value;
            }

            if (m_txt_tim_kiem.Text.Trim() == m_str_tim_kiem || m_txt_tim_kiem.Text.Trim() == "") m_v_us.FillDatasetSearch(m_v_ds, "", v_dat_ngay_bd, v_dat_ngay_kt);
            else m_v_us.FillDatasetSearch(m_v_ds, m_txt_tim_kiem.Text.Trim(), v_dat_ngay_bd, v_dat_ngay_kt);

            //m_v_us.FillDataset(m_v_ds);
            var v_str_search = m_txt_tim_kiem.Text.Trim();
            if (v_str_search.Equals(m_str_tim_kiem))
            {
                v_str_search = "";
            }
            m_fg.Redraw = true;
            decimal v_dc_tong_doanh_thu = 0;
            //m_v_us.get_tong_doanh_thu(v_dc_tong_doanh_thu);
            for (int i = 0; i < m_v_ds.V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG.Count; i++)
            {
                v_dc_tong_doanh_thu += CIPConvert.ToDecimal(m_v_ds.Tables[0].Rows[i][V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG.DOANH_THU]);
            }
            m_lbl_doanh_thu.Text = CIPConvert.ToStr(v_dc_tong_doanh_thu, "#,###.##") + "   VNĐ";

            CGridUtils.Dataset2C1Grid(m_v_ds, m_fg, m_obj_trans);
            CGridUtils.MakeSoTT(0, m_fg);
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Count // chỗ này dùng hàm count tức là để đếm, có thể dùng các hàm khác thay thế
              , 0
              , (int)e_col_Number.NGAY_GIAO_DICH // chỗ này là tên trường mà mình nhóm
              , (int)e_col_Number.TEN_KHACH_HANG // chỗ này là tên trường mà mình Count
              , "{0}"
              );
            m_fg.Subtotal(C1.Win.C1FlexGrid.AggregateEnum.Sum
                , 0
                , (int)e_col_Number.NGAY_GIAO_DICH
                , (int)e_col_Number.DOANH_THU
                , "{0}"
                );
            m_lbl_count.Text = m_v_ds.V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG.Count.ToString(CultureInfo.InvariantCulture);
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
		private void grid2us_object(US_V_BC_DOANH_THU_THEO_CAC_NGAY_N_KHACH_HANG i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}

	
		private void us_object2grid(US_V_BC_DOANH_THU_THEO_CAC_NGAY_N_KHACH_HANG i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}

        private void export_2_excel()
        {
            DS_DM_DON_VI_KINH_DOANH v_ds = new DS_DM_DON_VI_KINH_DOANH();
            US_DM_DON_VI_KINH_DOANH v_us = new US_DM_DON_VI_KINH_DOANH();
            v_us.FillDataset(v_ds);
            v_us.DataRow2Me((DataRow)v_ds.DM_DON_VI_KINH_DOANH.Rows[0]);
            String m_str_ten_don_vi = v_us.strTEN_DAY_DU;
            String m_str_dia_chi = v_us.strDIA_CHI;
            String m_str_so_dien_thoai = v_us.strSDT;

            CExcelReport v_obj_excel_rpt = new CExcelReport("f402_bao_cao_doanh_thu_theo_cac_bac_sy.xlsx", 10, 1);
            //người làm báo cáo
            v_obj_excel_rpt.AddFindAndReplaceItem("<nguoi_xuat_bao_cao>", m_lbl_nguoi_lam_bc.Text.Trim());
            //ngày làm báo cáo
            v_obj_excel_rpt.AddFindAndReplaceItem("<ten_don_vi>", m_str_ten_don_vi);
            v_obj_excel_rpt.AddFindAndReplaceItem("<dia_chi>", m_str_dia_chi);
            v_obj_excel_rpt.AddFindAndReplaceItem("<so_dien_thoai>", m_str_so_dien_thoai);
            v_obj_excel_rpt.AddFindAndReplaceItem("<ngay_xuat_bao_cao>", m_lbl_ngay_lam_bc.Text.Trim());
            v_obj_excel_rpt.AddFindAndReplaceItem("<tong_doanh_thu>", m_lbl_doanh_thu.Text);
            v_obj_excel_rpt.FindAndReplace(false);
            v_obj_excel_rpt.Export2ExcelWithoutFixedRows(m_fg, 0, m_fg.Cols.Count - 1, true);
        }
        private void set_define_events()
        {
            m_cmd_exit.Click += new EventHandler(m_cmd_exit_Click);
            m_cmd_xuat_excel.Click += new EventHandler(m_cmd_xuat_excel_Click);
            m_cmd_search.Click += new EventHandler(m_cmd_search_Click);
            m_txt_tim_kiem.KeyDown += m_txt_tim_kiem_KeyDown;
            m_txt_tim_kiem.MouseClick += m_txt_tim_kiem_MouseClick;
            m_txt_tim_kiem.Leave += m_txt_tim_kiem_Leave;
        }
		#endregion

//
		//
		//		EVENT HANLDERS
		//
		//
		private void f406_bcdt_theo_cac_ngay_n_khach_hang_Load(object sender, System.EventArgs e) {
			try{
				set_initial_form_load();
                load_data_2_lbl();
                load_custom_source_2_m_txt_tim_kiem();
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

                load_data_2_grid();
            }
            catch (Exception v_e)
            {
                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

	}
}

