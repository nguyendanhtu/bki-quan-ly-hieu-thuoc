///************************************************
/// Generated by: Huytd
/// Date: 01/04/2014 02:17:05
/// Goal: Create Form for V_DM_BAC_SY
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
using BKI_QLHT.DanhMuc;

using C1.Win.C1FlexGrid;

namespace BKI_QLHT
{



	public class f100_V_DM_BAC_SY : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.ImageList ImageList;
		internal System.Windows.Forms.Panel m_pnl_out_place_dm;
		private C1.Win.C1FlexGrid.C1FlexGrid m_fg;
		internal SIS.Controls.Button.SiSButton m_cmd_delete;
		internal SIS.Controls.Button.SiSButton m_cmd_update;
		internal SIS.Controls.Button.SiSButton m_cmd_insert;
        internal SIS.Controls.Button.SiSButton m_cmd_exit;
        private GroupBox groupBox1;
        private TextBox m_txt_tim_kiem;
        internal SIS.Controls.Button.SiSButton m_cmd_Tim_Kiem;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label m_lbl_dien_thoai;
        private Label m_lbl_dia_chi;
        private Label m_lbl_benh_vien;
        private Label m_lbl_ho_ten;
		private System.ComponentModel.IContainer components;

		public f100_V_DM_BAC_SY()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f100_V_DM_BAC_SY));
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_pnl_out_place_dm = new System.Windows.Forms.Panel();
            this.m_cmd_insert = new SIS.Controls.Button.SiSButton();
            this.m_cmd_update = new SIS.Controls.Button.SiSButton();
            this.m_cmd_delete = new SIS.Controls.Button.SiSButton();
            this.m_cmd_exit = new SIS.Controls.Button.SiSButton();
            this.m_fg = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_txt_tim_kiem = new System.Windows.Forms.TextBox();
            this.m_cmd_Tim_Kiem = new SIS.Controls.Button.SiSButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_lbl_dien_thoai = new System.Windows.Forms.Label();
            this.m_lbl_dia_chi = new System.Windows.Forms.Label();
            this.m_lbl_benh_vien = new System.Windows.Forms.Label();
            this.m_lbl_ho_ten = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.m_pnl_out_place_dm.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_pnl_out_place_dm.Location = new System.Drawing.Point(0, 373);
            this.m_pnl_out_place_dm.Name = "m_pnl_out_place_dm";
            this.m_pnl_out_place_dm.Padding = new System.Windows.Forms.Padding(4);
            this.m_pnl_out_place_dm.Size = new System.Drawing.Size(686, 36);
            this.m_pnl_out_place_dm.TabIndex = 19;
            // 
            // m_cmd_insert
            // 
            this.m_cmd_insert.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_insert.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_insert.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_insert.ImageIndex = 2;
            this.m_cmd_insert.ImageList = this.ImageList;
            this.m_cmd_insert.Location = new System.Drawing.Point(331, 4);
            this.m_cmd_insert.Name = "m_cmd_insert";
            this.m_cmd_insert.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_insert.TabIndex = 3;
            this.m_cmd_insert.Text = "&Thêm";
            // 
            // m_cmd_update
            // 
            this.m_cmd_update.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_update.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_update.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_update.ImageIndex = 3;
            this.m_cmd_update.ImageList = this.ImageList;
            this.m_cmd_update.Location = new System.Drawing.Point(419, 4);
            this.m_cmd_update.Name = "m_cmd_update";
            this.m_cmd_update.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_update.TabIndex = 4;
            this.m_cmd_update.Text = "&Sửa";
            // 
            // m_cmd_delete
            // 
            this.m_cmd_delete.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_delete.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_delete.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_delete.ImageIndex = 4;
            this.m_cmd_delete.ImageList = this.ImageList;
            this.m_cmd_delete.Location = new System.Drawing.Point(507, 4);
            this.m_cmd_delete.Name = "m_cmd_delete";
            this.m_cmd_delete.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_delete.TabIndex = 5;
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
            this.m_cmd_exit.TabIndex = 6;
            this.m_cmd_exit.Text = "Thoát (Esc)";
            // 
            // m_fg
            // 
            this.m_fg.ColumnInfo = resources.GetString("m_fg.ColumnInfo");
            this.m_fg.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_fg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_fg.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_fg.Location = new System.Drawing.Point(3, 93);
            this.m_fg.Name = "m_fg";
            this.m_fg.Size = new System.Drawing.Size(680, 155);
            this.m_fg.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("m_fg.Styles"));
            this.m_fg.TabIndex = 20;
            this.m_fg.Click += new System.EventHandler(this.m_fg_Click);
            this.m_fg.DoubleClick += new System.EventHandler(this.m_cmd_update_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.m_txt_tim_kiem);
            this.groupBox1.Controls.Add(this.m_cmd_Tim_Kiem);
            this.groupBox1.Controls.Add(this.m_fg);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 251);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bác sĩ";
            // 
            // m_txt_tim_kiem
            // 
            this.m_txt_tim_kiem.Location = new System.Drawing.Point(81, 41);
            this.m_txt_tim_kiem.Name = "m_txt_tim_kiem";
            this.m_txt_tim_kiem.Size = new System.Drawing.Size(247, 23);
            this.m_txt_tim_kiem.TabIndex = 1;
            // 
            // m_cmd_Tim_Kiem
            // 
            this.m_cmd_Tim_Kiem.AdjustImageLocation = new System.Drawing.Point(0, 0);
            this.m_cmd_Tim_Kiem.BtnShape = SIS.Controls.Button.emunType.BtnShape.Rectangle;
            this.m_cmd_Tim_Kiem.BtnStyle = SIS.Controls.Button.emunType.XPStyle.Default;
            this.m_cmd_Tim_Kiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_cmd_Tim_Kiem.ImageIndex = 18;
            this.m_cmd_Tim_Kiem.ImageList = this.ImageList;
            this.m_cmd_Tim_Kiem.Location = new System.Drawing.Point(355, 36);
            this.m_cmd_Tim_Kiem.Name = "m_cmd_Tim_Kiem";
            this.m_cmd_Tim_Kiem.Size = new System.Drawing.Size(88, 28);
            this.m_cmd_Tim_Kiem.TabIndex = 2;
            this.m_cmd_Tim_Kiem.Text = "Tìm kiếm";
            this.m_cmd_Tim_Kiem.Click += new System.EventHandler(this.m_cmd_Tim_Kiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_lbl_dien_thoai);
            this.groupBox2.Controls.Add(this.m_lbl_dia_chi);
            this.groupBox2.Controls.Add(this.m_lbl_benh_vien);
            this.groupBox2.Controls.Add(this.m_lbl_ho_ten);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 116);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết thông tin bác sỹ";
            // 
            // m_lbl_dien_thoai
            // 
            this.m_lbl_dien_thoai.AutoSize = true;
            this.m_lbl_dien_thoai.Location = new System.Drawing.Point(379, 71);
            this.m_lbl_dien_thoai.Name = "m_lbl_dien_thoai";
            this.m_lbl_dien_thoai.Size = new System.Drawing.Size(20, 16);
            this.m_lbl_dien_thoai.TabIndex = 2;
            this.m_lbl_dien_thoai.Text = "...";
            // 
            // m_lbl_dia_chi
            // 
            this.m_lbl_dia_chi.AutoSize = true;
            this.m_lbl_dia_chi.Location = new System.Drawing.Point(379, 30);
            this.m_lbl_dia_chi.Name = "m_lbl_dia_chi";
            this.m_lbl_dia_chi.Size = new System.Drawing.Size(20, 16);
            this.m_lbl_dia_chi.TabIndex = 2;
            this.m_lbl_dia_chi.Text = "...";
            // 
            // m_lbl_benh_vien
            // 
            this.m_lbl_benh_vien.AutoSize = true;
            this.m_lbl_benh_vien.Location = new System.Drawing.Point(144, 71);
            this.m_lbl_benh_vien.Name = "m_lbl_benh_vien";
            this.m_lbl_benh_vien.Size = new System.Drawing.Size(20, 16);
            this.m_lbl_benh_vien.TabIndex = 2;
            this.m_lbl_benh_vien.Text = "...";
            // 
            // m_lbl_ho_ten
            // 
            this.m_lbl_ho_ten.AutoSize = true;
            this.m_lbl_ho_ten.Location = new System.Drawing.Point(144, 30);
            this.m_lbl_ho_ten.Name = "m_lbl_ho_ten";
            this.m_lbl_ho_ten.Size = new System.Drawing.Size(20, 16);
            this.m_lbl_ho_ten.TabIndex = 2;
            this.m_lbl_ho_ten.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bệnh viện:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // f100_V_DM_BAC_SY
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(686, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_pnl_out_place_dm);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "f100_V_DM_BAC_SY";
            this.Text = "Danh sách bác sĩ";
            this.Load += new System.EventHandler(this.f100_V_DM_BAC_SY_Load);
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
			HO_TEN = 1
,BENH_VIEN = 5
,DIA_CHI = 3
,TEN_NGAN = 2
,ID_LOAI_TU_DIEN = 6
,DIEN_THOAI = 4

		}			
		#endregion

		#region Members
		ITransferDataRow m_obj_trans;
		DS_V_DM_BAC_SY m_ds_v_dm_bac_sy = new DS_V_DM_BAC_SY();
		US_V_DM_BAC_SY m_us_v_dm_bac_sy = new US_V_DM_BAC_SY();
        DS_DM_BAC_SY m_ds_dm_bac_sy = new DS_DM_BAC_SY();
        US_DM_BAC_SY m_us_dm_bac_sy = new US_DM_BAC_SY();
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
			v_htb.Add(V_DM_BAC_SY.HO_TEN, e_col_Number.HO_TEN);
			v_htb.Add(V_DM_BAC_SY.BENH_VIEN, e_col_Number.BENH_VIEN);
			v_htb.Add(V_DM_BAC_SY.DIA_CHI, e_col_Number.DIA_CHI);
			v_htb.Add(V_DM_BAC_SY.TEN_NGAN, e_col_Number.TEN_NGAN);
			v_htb.Add(V_DM_BAC_SY.ID_LOAI_TU_DIEN, e_col_Number.ID_LOAI_TU_DIEN);
			v_htb.Add(V_DM_BAC_SY.DIEN_THOAI, e_col_Number.DIEN_THOAI);
									
			ITransferDataRow v_obj_trans = new CC1TransferDataRow(i_fg,v_htb,m_ds_v_dm_bac_sy.V_DM_BAC_SY.NewRow());
			return v_obj_trans;			
		}
		private void load_data_2_grid(){						
			m_ds_v_dm_bac_sy = new DS_V_DM_BAC_SY();			
			m_us_v_dm_bac_sy.FillDataset(m_ds_v_dm_bac_sy);
			m_fg.Redraw = false;
			CGridUtils.Dataset2C1Grid(m_ds_v_dm_bac_sy, m_fg, m_obj_trans);
			m_fg.Redraw = true;
		}
		private void grid2us_object(US_DM_BAC_SY i_us
			, int i_grid_row) {
			DataRow v_dr;
			v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			m_obj_trans.GridRow2DataRow(i_grid_row,v_dr);
			i_us.DataRow2Me(v_dr);
		}
        private void v_grid2us_object(US_V_DM_BAC_SY i_us
            , int i_grid_row)
        {
            DataRow v_dr;
            v_dr = (DataRow)m_fg.Rows[i_grid_row].UserData;
            m_obj_trans.GridRow2DataRow(i_grid_row, v_dr);
            i_us.DataRow2Me(v_dr);
        }

	
		private void us_object2grid(US_DM_BAC_SY i_us
			, int i_grid_row) {
			DataRow v_dr = (DataRow) m_fg.Rows[i_grid_row].UserData;
			i_us.Me2DataRow(v_dr);
			m_obj_trans.DataRow2GridRow(v_dr, i_grid_row);
		}


		private void insert_dm_bac_sy(){			
            f100_v_dm_bac_sy_de v_frm_de = new f100_v_dm_bac_sy_de();
            v_frm_de.display_for_insert();
			load_data_2_grid();
		}
		private void update_dm_bac_sy(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;			
			grid2us_object(m_us_dm_bac_sy, m_fg.Row);
            f100_v_dm_bac_sy_de v_frm_de = new f100_v_dm_bac_sy_de();
            v_frm_de.display_for_update(m_us_dm_bac_sy);
			load_data_2_grid();
		}
				
		private void delete_dm_bac_sy(){
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted)  return;
			US_DM_BAC_SY v_us = new US_DM_BAC_SY();
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

		private void view_v_dm_bac_sy(){			
			if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
			if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
			grid2us_object(m_us_dm_bac_sy, m_fg.Row);
		//	f100_V_DM_BAC_SY_DE v_fDE = new f100_V_DM_BAC_SY_DE();			
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

        #region Event
        private void f100_V_DM_BAC_SY_Load(object sender, System.EventArgs e) {
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
                insert_dm_bac_sy();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_update_Click(object sender, EventArgs e) {
			try{
				update_dm_bac_sy();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_delete_Click(object sender, EventArgs e) {
			try{
				delete_dm_bac_sy();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

		private void m_cmd_view_Click(object sender, EventArgs e) {
			try{
				view_v_dm_bac_sy();
			}
			catch (Exception v_e){
				CSystemLog_301.ExceptionHandle(v_e);
			}
		}

        private void m_cmd_Tim_Kiem_Click(object sender, EventArgs e)
        {
            string v_str_tu_khoa = m_txt_tim_kiem.Text.Trim();
            US_V_DM_BAC_SY v_us_v_dm_bac_sy = new US_V_DM_BAC_SY();
            DS_V_DM_BAC_SY v_ds_v_dm_bac_sy = new DS_V_DM_BAC_SY();
            v_us_v_dm_bac_sy.FillDatasetSearch(v_ds_v_dm_bac_sy, v_str_tu_khoa);
            m_fg.Redraw = false;
            CGridUtils.Dataset2C1Grid(v_ds_v_dm_bac_sy, m_fg, m_obj_trans);
            m_fg.Redraw = true;
        }

        private void m_fg_Click(object sender, EventArgs e)
        {

            if (!CGridUtils.IsThere_Any_NonFixed_Row(m_fg)) return;
            if (!CGridUtils.isValid_NonFixed_RowIndex(m_fg, m_fg.Row)) return;
            v_grid2us_object(m_us_v_dm_bac_sy, m_fg.Row);
            m_lbl_ho_ten.Text = m_us_v_dm_bac_sy.strHO_TEN;
            m_lbl_dia_chi.Text = m_us_v_dm_bac_sy.strDIA_CHI;
            m_lbl_benh_vien.Text = m_us_v_dm_bac_sy.strTEN_NGAN;
            m_lbl_dien_thoai.Text = m_us_v_dm_bac_sy.strDIEN_THOAI;
        }
        #endregion
    }
}
