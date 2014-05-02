using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using IP.Core.IPSystemAdmin;
using IP.Core.IPCommon;

using BKI_QLHT.US;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;

namespace BKI_QLHT.NghiepVu
{
    public partial class uc108_v_gd_giao_dich_detail : UserControl
    {
        #region Public Interface
        public uc108_v_gd_giao_dich_detail()
        {
            InitializeComponent();
            format_control();

        }

        public String gen_Ma_GD()
        {
            string username = System.IO.File.ReadAllText(@"..\user_login.txt");
            string ydate = DateTime.Now.Year.ToString();
            string mdate = DateTime.Now.Month.ToString();
            string ddate = DateTime.Now.Day.ToString();
            string hdate = DateTime.Now.Hour.ToString();
            string Mdate = DateTime.Now.Minute.ToString();
            string Sdate = DateTime.Now.Second.ToString();
            string datetime = ydate + mdate + ddate + hdate + Mdate + Sdate;
            return "PX_" + username + "_" + datetime;
        }
        #endregion


        #region Members
        decimal tong_tien = 0;
        decimal tong_tien_thanh_toan = 0;
        US_GD_GIAO_DICH_DETAIL m_us_giao_dich_detail = new US_GD_GIAO_DICH_DETAIL();
        DS_GD_GIAO_DICH_DETAIL m_ds_giao_dich_detail = new DS_GD_GIAO_DICH_DETAIL();
        #endregion


        #region Private Method
        private void format_control()
        {
            m_lbl_Ma_GD_text.Text = gen_Ma_GD();
            //CControlFormat.setFormStyle(this);
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            m_grv_quan_ly_ban_thuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            m_grv_quan_ly_ban_thuoc.RowsDefaultCellStyle.BackColor = Color.Bisque;
            m_grv_quan_ly_ban_thuoc.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            m_grv_quan_ly_ban_thuoc.CellBorderStyle = DataGridViewCellBorderStyle.None;
            m_grv_quan_ly_ban_thuoc.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            m_grv_quan_ly_ban_thuoc.DefaultCellStyle.SelectionForeColor = Color.White;
            m_grv_quan_ly_ban_thuoc.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            m_grv_quan_ly_ban_thuoc.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            m_grv_quan_ly_ban_thuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            m_grv_quan_ly_ban_thuoc.AllowUserToResizeColumns = false;
            //CControlFormat.setC1FixedRowsFormat(m_grv_quan_ly_ban_thuoc);
            set_define_events();
            //this.KeyPreview = true;
            load_cbo_ten_khach_hang();
            load_cbo_bac_sy();
            load_ten_thuoc();
        }

        private void load_ten_thuoc()
        {
            US_V_DM_THUOC v_us = new US_V_DM_THUOC();
            DS_V_DM_THUOC v_ds = new DS_V_DM_THUOC();
            v_us.FillDataset(v_ds);
            txt_search_thuoc1.load_data_to_list(v_ds, V_DM_THUOC.DISPLAY, V_DM_THUOC.ID);
        }
        private void set_define_events()
        {
            //m_cmd_them.Click += new EventHandler(m_cmd_them_Click);
        //    m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
        //    m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
        //    m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
        }

        
        private void load_cbo_don_vi_tinh()
        {
            US_V_GD_DON_VI_TINH_THUOC v_us_v_gd_don_vi_tinh_thuoc = new US_V_GD_DON_VI_TINH_THUOC();
            DS_V_GD_DON_VI_TINH_THUOC v_ds_v_gd_don_vi_tinh_thuoc = new DS_V_GD_DON_VI_TINH_THUOC();
            decimal v_id_thuoc = txt_search_thuoc1.dcID;
            v_us_v_gd_don_vi_tinh_thuoc.FillDataset(v_ds_v_gd_don_vi_tinh_thuoc, "where ID_THUOC = "+v_id_thuoc);
            m_cbo_don_vi_tinh.DataSource = v_ds_v_gd_don_vi_tinh_thuoc.V_GD_DON_VI_TINH_THUOC;
            m_cbo_don_vi_tinh.ValueMember = V_GD_DON_VI_TINH_THUOC.ID;
            m_cbo_don_vi_tinh.DisplayMember = V_GD_GIAO_DICH_DETAIL.TEN_DON_VI;
            
        }

        private void load_cbo_bac_sy()
        {
            US_DM_BAC_SY v_us = new US_DM_BAC_SY();
            DS_DM_BAC_SY v_ds = new DS_DM_BAC_SY();
            v_us.FillDataset(v_ds);
            m_cbo_ten_bac_sy.DataSource = v_ds.DM_BAC_SY;
            m_cbo_ten_bac_sy.ValueMember = DM_BAC_SY.ID;
            m_cbo_ten_bac_sy.DisplayMember = DM_BAC_SY.HO_TEN;
            DataRow v_dr = v_ds.DM_BAC_SY.NewRow();
            v_dr[DM_BAC_SY.ID] = -1;
            v_dr[DM_BAC_SY.HO_TEN] = "Không theo đơn bác sĩ";
            v_dr[DM_BAC_SY.BENH_VIEN] = 2;
            v_ds.DM_BAC_SY.Rows.InsertAt(v_dr, 0);
            m_cbo_ten_bac_sy.SelectedIndex = 0;
        }

        private void m_cbo_don_vi_tinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_cbo_don_vi_tinh();
        }

        private void txt_search_thuoc1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                    load_cbo_don_vi_tinh();
                load_don_gia();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_ti_le_chiet_khau_TextChanged(object sender, EventArgs e)
        {
            decimal v_ti_le_chiet_khau = CIPConvert.ToDecimal(m_txt_ti_le_chiet_khau.Text);
            decimal tong_tien_thanh_toan = tong_tien - (tong_tien * v_ti_le_chiet_khau) / 100;
            m_txt_tong_tien_thanh_toan.Text = string.Format("{0:0,#}", CIPConvert.ToDecimal(tong_tien_thanh_toan)) + " " + "VNĐ";
        }
        private void load_cbo_ten_khach_hang()
        {
            US_DM_KHACH_HANG v_us = new US_DM_KHACH_HANG();
            DS_DM_KHACH_HANG v_ds = new DS_DM_KHACH_HANG();
            v_us.FillDataset(v_ds);
            m_cbo_ten_khach_hang.ValueMember = DM_KHACH_HANG.ID;
            m_cbo_ten_khach_hang.DisplayMember = DM_KHACH_HANG.TEN_KHACH_HANG;
            m_cbo_ten_khach_hang.DataSource = v_ds.DM_KHACH_HANG;


        }

        private void load_khach_ban_buon()
        {
            US_DM_KHACH_HANG v_us = new US_DM_KHACH_HANG();
            DS_DM_KHACH_HANG v_ds = new DS_DM_KHACH_HANG();
            int v_id_kh = Convert.ToInt32(m_cbo_ten_khach_hang.SelectedValue);
            v_us.FillDatasetByIDKhachBanBuon(v_ds, v_id_kh);
            DataRow v_dr = v_ds.Tables[0].Rows[0];
            m_lbl_dia_chi_text.Text = v_dr["DIA_CHI"].ToString();
            m_lbl_SDT_text.Text = v_dr["SDT"].ToString();
        }
       
        #endregion


        #region Events

        private void uc_f108_v_gd_giao_dich_detail_Load(object sender, EventArgs e)
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

        private void set_initial_form_load()
        {

        }

        private void m_selectIndex_khach_hang(object sender, EventArgs e)
        {
            load_khach_ban_buon();
            if (Convert.ToDecimal(m_cbo_ten_khach_hang.SelectedValue) == 1)
            {
                m_lbl_dia_chi.Visible = false;
                m_lbl_dia_chi_text.Visible = false;
                m_lbl_SDT.Visible = false;
                m_lbl_SDT_text.Visible = false;
            }
            else
            {
                m_lbl_dia_chi.Visible = true;
                m_lbl_dia_chi_text.Visible = true;
                m_lbl_SDT.Visible = true;
                m_lbl_SDT_text.Visible = true;

            }
        }

        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            int n = m_grv_quan_ly_ban_thuoc.Rows.Add();
            m_grv_quan_ly_ban_thuoc.Rows[n].Cells[0].Value = n + 1;
            m_grv_quan_ly_ban_thuoc.Rows[n].Cells[1].Value = txt_search_thuoc1.Text1;
            m_grv_quan_ly_ban_thuoc.Rows[n].Cells[2].Value = m_txt_so_luong.Text;
            m_grv_quan_ly_ban_thuoc.Rows[n].Cells[3].Value = m_cbo_don_vi_tinh.Text;
            m_grv_quan_ly_ban_thuoc.Rows[n].Cells[4].Value = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_don_gia.Text.ToString().Replace(",",""))) + " " + "VNĐ";
            m_grv_quan_ly_ban_thuoc.Rows[n].Cells[5].Value = string.Format("{0:#,###}", CIPConvert.ToDecimal(int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_don_gia.Text.ToString().Replace(",","")))) + " " + "VNĐ";
            tong_tien += int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_don_gia.Text.Trim().Replace(",", ""));
            m_txt_tong_tien.Text = string.Format("{0:0,#}", CIPConvert.ToDecimal(tong_tien)) + " " + "VNĐ";
            //restart_form();
        }

        private void load_don_gia()
        {
            US_V_GD_DON_VI_TINH_THUOC v_us_v_gd_don_vi_tinh_thuoc = new US_V_GD_DON_VI_TINH_THUOC();
            DS_V_GD_DON_VI_TINH_THUOC v_ds_v_gd_don_vi_tinh_thuoc = new DS_V_GD_DON_VI_TINH_THUOC();
            decimal don_gia;
            decimal v_id_don_vi_tinh_thuoc =CIPConvert.ToDecimal(m_cbo_don_vi_tinh.SelectedValue);
            v_us_v_gd_don_vi_tinh_thuoc.FillDataset(v_ds_v_gd_don_vi_tinh_thuoc, "where ID = " + v_id_don_vi_tinh_thuoc);
            DataRow v_dr = v_ds_v_gd_don_vi_tinh_thuoc.Tables[0].Rows[0];
            don_gia = CIPConvert.ToDecimal(v_dr[V_GD_DON_VI_TINH_THUOC.GIA_BAN]);
            m_txt_don_gia.Text = don_gia.ToString();
            m_txt_don_gia.Text = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_don_gia.Text.Trim()));
        }
        #endregion

     }



    }
