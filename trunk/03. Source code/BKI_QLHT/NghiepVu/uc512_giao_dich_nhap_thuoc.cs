﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
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
using System.Collections.Generic;
using System.Globalization;


namespace BKI_QLHT
{
    public partial class uc512_giao_dich_nhap_thuoc : UserControl
    {
        public uc512_giao_dich_nhap_thuoc()
        {
            InitializeComponent();
            format_control();
        }

        #region Public Interface
        public String gen_Ma_GD()
        {
            string username = CAppContext_201.getCurrentUserName();
            string ydate = DateTime.Now.Year.ToString();
            string mdate = DateTime.Now.Month.ToString();
            string ddate = DateTime.Now.Day.ToString();
            string hdate = DateTime.Now.Hour.ToString();
            string Mdate = DateTime.Now.Minute.ToString();
            string Sdate = DateTime.Now.Second.ToString();
            string datetime = ydate + mdate + ddate + hdate + Mdate + Sdate;
            return "PN_" + username + "_" + datetime;
        }
        public class data
        {
            public string ten_thuoc;
            public DateTime ngay_nhap;
            public DateTime ngay_sx;
            public DateTime han_sd;
            public string nha_cung_cap;
            public string hang_sx;
            public string nuoc_sx;
            public int so_luong;
            public int sd_so_luong;
            public decimal ID_thuoc;
            public decimal ID_don_vi_thuoc;
            public int gia;
            public string don_vi_cap_1;
            public string don_vi_cap_2;
            public string don_vi_cap_3;
            public string don_vi_cap_4;
            public decimal ID_dv_cap_1;
            public decimal ID_dv_cap_2;
            public decimal ID_dv_cap_3;
            public decimal ID_dv_cap_4;
            public decimal ID_nhom_dv_tinh;
            public string quy_doi_1;
            public string quy_doi_2;
            public string quy_doi_3;
            public decimal id_nha_cc;
            public decimal id_hang_sx;
            public decimal id_nuoc_sx;
            public string ma_giao_dich;
            public decimal id_giao_dich;
            public int gia_ban;
            public string ten_don_vi_tinh_thuoc;
            public decimal gia_ban_dv_cap_2;

            public decimal id_don_vi_thuoc_nhap;
        }
        #endregion

        #region Member
        long tong_tien = 0;
        List<data> list = new List<data>();
        decimal m_id_giao_dich;
        bool m_trang_thai = false;
        int m_grv_s_i;
        US_DM_DON_VI_TINH m_us_don_vi_tinh = new US_DM_DON_VI_TINH();
        #endregion

        #region Private Method
        private void format_control()
        {
            //CControlFormat.setFormStyle(this, new CAppContext_201());
            CControlFormat.setUserControlStyle(this, new CAppContext_201());
            set_define_event();
            m_lbl_canh_bao_hsd.ForeColor = Color.Red;
            m_grv_nhap_thuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            m_grv_nhap_thuoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            m_grv_nhap_thuoc.RowsDefaultCellStyle.BackColor = Color.Bisque;
            m_grv_nhap_thuoc.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            //m_grv_nhap_thuoc.CellBorderStyle = DataGridViewCellBorderStyle.None;
            m_grv_nhap_thuoc.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            m_grv_nhap_thuoc.DefaultCellStyle.SelectionForeColor = Color.White;
            m_grv_nhap_thuoc.DefaultCellStyle.ForeColor = Color.RoyalBlue;
            m_grv_nhap_thuoc.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            m_grv_nhap_thuoc.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //m_grv_nhap_thuoc.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //m_grv_nhap_thuoc.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            m_grv_nhap_thuoc.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            m_grv_nhap_thuoc.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            m_grv_nhap_thuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //m_grv_nhap_thuoc.AllowUserToResizeColumns = false;
            m_lbl_ma_giao_dich.Text = gen_Ma_GD();
        }
        public void set_inital_form_load()
        {
            //load_cbo_ten_thuoc();
            load_ten_thuoc();

            load_cbo_don_vi_tinh_start();
            load_cbo_dv_cap_2_start();
            load_cbo_dv_cap_3_start();
            load_cbo_dv_cap_4_start();
            //load_data_2_dv_cap_2();
            //load_data_2_dv_cap_3();
            //load_data_2_dv_cap_4();
            //load_data_to_text_box_search();
            load_data_2_cbo_nha_cung_cap();
            load_data_2_cbo_nuoc_sx();
            load_data_2_cbo_hang_sx();
            load_data_2_label();
        }
        //private void load_cbo_ten_thuoc()
        //{
        //    US_V_DM_THUOC v_us_dm_thuoc = new US_V_DM_THUOC();
        //    DS_V_DM_THUOC v_ds_dm_thuoc = new DS_V_DM_THUOC();
        //    v_us_dm_thuoc.FillDataset(v_ds_dm_thuoc);
        //    DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
        //    cell.DataSource = v_ds_dm_thuoc.V_DM_THUOC;
        //    //m_grv_nhap_thuoc.Cells[cbo_test].DataSource = v_ds_dm_thuoc.V_DM_THUOC;

        //    cell.ValueMember = V_DM_THUOC.ID;
        //    cell.DisplayMember = V_DM_THUOC.DISPLAY;

        //}
        private void load_cbo_don_vi_tinh_start()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.FillDataset(v_ds_tu_dien, "where id_loai_tu_dien=" + ID_LOAI_TU_DIEN.DON_VI_TINH);
            m_cbo_don_vi_tinh.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_don_vi_tinh.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_don_vi_tinh.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_don_vi_tinh.Enabled = true;
        }
        private void load_cbo_dv_cap_2_start()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.FillDataset(v_ds_tu_dien, "where id_loai_tu_dien=" + ID_LOAI_TU_DIEN.DON_VI_TINH);
            m_cbo_dv_cap_2.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_dv_cap_2.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_dv_cap_2.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_dv_cap_2.Enabled = true;
        }
        private void load_cbo_dv_cap_3_start()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.FillDataset(v_ds_tu_dien, "where id_loai_tu_dien=" + ID_LOAI_TU_DIEN.DON_VI_TINH);
            m_cbo_dv_cap_3.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_dv_cap_3.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_dv_cap_3.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_dv_cap_3.Enabled = true;
        }
        private void load_cbo_dv_cap_4_start()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.FillDataset(v_ds_tu_dien, "where id_loai_tu_dien=" + ID_LOAI_TU_DIEN.DON_VI_TINH);
            m_cbo_dv_cap_4.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_dv_cap_4.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_dv_cap_4.DisplayMember = CM_DM_TU_DIEN.TEN;
            m_cbo_dv_cap_4.Enabled = true;
        }
        private void load_data_2_cbo_don_vi_tinh()
        {
            if (m_txt_search_thuoc1.Text1 != "")
            {
                US_DM_DON_VI_TINH v_us_don_vi_tinh = new US_DM_DON_VI_TINH();
                DS_DM_DON_VI_TINH v_ds_don_vi_tinh = new DS_DM_DON_VI_TINH();
                v_us_don_vi_tinh.FillDataset(v_ds_don_vi_tinh, "where ID_THUOC=" + m_txt_search_thuoc1.dcID);
                if (v_ds_don_vi_tinh.DM_DON_VI_TINH.Count != 0)
                {
                    decimal id_nhom_don_vi = CIPConvert.ToDecimal(v_ds_don_vi_tinh.Tables[0].Rows[0]["ID"].ToString());
                    load_cbo_don_vi_tinh(id_nhom_don_vi);
                }
                else load_cbo_don_vi_tinh_start();
            }
            else load_cbo_don_vi_tinh_start();


        }
        private void load_data_2_dv_cap_2()
        {
            if (m_txt_search_thuoc1.Text1 != "")
            {
                US_DM_DON_VI_TINH v_us_don_vi_tinh = new US_DM_DON_VI_TINH();
                DS_DM_DON_VI_TINH v_ds_don_vi_tinh = new DS_DM_DON_VI_TINH();
                v_us_don_vi_tinh.FillDataset(v_ds_don_vi_tinh, "where ID_THUOC=" + m_txt_search_thuoc1.dcID);
                if (v_ds_don_vi_tinh.DM_DON_VI_TINH.Count != 0)
                {
                    decimal id_nhom_don_vi = CIPConvert.ToDecimal(v_ds_don_vi_tinh.Tables[0].Rows[0]["ID"].ToString());
                    load_cbo_dv_cap_2(id_nhom_don_vi);
                }
                else load_cbo_dv_cap_2_start();
            }
            else load_cbo_dv_cap_2_start();

        }
        private void load_data_2_dv_cap_3()
        {
            if (m_txt_search_thuoc1.Text1 != "")
            {
                US_DM_DON_VI_TINH v_us_don_vi_tinh = new US_DM_DON_VI_TINH();
                DS_DM_DON_VI_TINH v_ds_don_vi_tinh = new DS_DM_DON_VI_TINH();
                v_us_don_vi_tinh.FillDataset(v_ds_don_vi_tinh, "where ID_THUOC=" + m_txt_search_thuoc1.dcID);
                if (v_ds_don_vi_tinh.DM_DON_VI_TINH.Count != 0)
                {
                    decimal id_nhom_don_vi = CIPConvert.ToDecimal(v_ds_don_vi_tinh.Tables[0].Rows[0]["ID"].ToString());
                    load_cbo_dv_cap_3(id_nhom_don_vi);
                }
                else load_cbo_dv_cap_3_start();
            }
            else load_cbo_dv_cap_3_start();

        }
        private void load_data_2_dv_cap_4()
        {
            if (m_txt_search_thuoc1.Text1 != "")
            {
                US_DM_DON_VI_TINH v_us_don_vi_tinh = new US_DM_DON_VI_TINH();
                DS_DM_DON_VI_TINH v_ds_don_vi_tinh = new DS_DM_DON_VI_TINH();
                v_us_don_vi_tinh.FillDataset(v_ds_don_vi_tinh, "where ID_THUOC=" + m_txt_search_thuoc1.dcID);
                if (v_ds_don_vi_tinh.DM_DON_VI_TINH.Count != 0)
                {
                    decimal id_nhom_don_vi = CIPConvert.ToDecimal(v_ds_don_vi_tinh.Tables[0].Rows[0]["ID"].ToString());
                    load_cbo_dv_cap_4(id_nhom_don_vi);
                }
                else load_cbo_dv_cap_4_start();
            }
            else load_cbo_dv_cap_4_start();

        }
        private void load_data_2_cbo_don_vi()
        {

            load_data_2_cbo_don_vi_tinh();
            load_data_2_dv_cap_2();
            load_data_2_dv_cap_3();
            load_data_2_dv_cap_4();
        }
        private void load_cbo_don_vi_tinh(decimal ip_id_nhom_dv_tinh)
        {
            US_GD_DON_VI_TINH_THUOC v_us_v_gd_don_vi_tinh_thuoc = new US_GD_DON_VI_TINH_THUOC();
            DS_GD_DON_VI_TINH_THUOC v_ds_v_gd_don_vi_tinh_thuoc = new DS_GD_DON_VI_TINH_THUOC();

            v_us_v_gd_don_vi_tinh_thuoc.FillDataset(v_ds_v_gd_don_vi_tinh_thuoc, "where ID_NHOM_DON_VI_TINH = " + ip_id_nhom_dv_tinh);
            if (v_ds_v_gd_don_vi_tinh_thuoc.GD_DON_VI_TINH_THUOC.Count != 0)
            {

                m_cbo_don_vi_tinh.DataSource = v_ds_v_gd_don_vi_tinh_thuoc.GD_DON_VI_TINH_THUOC;
                m_cbo_don_vi_tinh.ValueMember = GD_DON_VI_TINH_THUOC.ID;
                m_cbo_don_vi_tinh.DisplayMember = GD_DON_VI_TINH_THUOC.TEN_DON_VI;
            }
            else
            {
                load_cbo_don_vi_tinh_start();
            }
        }
        private void load_cbo_dv_cap_2(decimal ip_id_nhom_dv_tinh)
        {
            US_GD_DON_VI_TINH_THUOC v_us_v_gd_don_vi_tinh_thuoc = new US_GD_DON_VI_TINH_THUOC();
            DS_GD_DON_VI_TINH_THUOC v_ds_v_gd_don_vi_tinh_thuoc = new DS_GD_DON_VI_TINH_THUOC();

            v_us_v_gd_don_vi_tinh_thuoc.FillDataset(v_ds_v_gd_don_vi_tinh_thuoc, "where ID_NHOM_DON_VI_TINH = " + ip_id_nhom_dv_tinh);
            if (v_ds_v_gd_don_vi_tinh_thuoc.GD_DON_VI_TINH_THUOC.Count != 0)
            {
                m_cbo_dv_cap_2.DataSource = v_ds_v_gd_don_vi_tinh_thuoc.GD_DON_VI_TINH_THUOC;
                m_cbo_dv_cap_2.ValueMember = GD_DON_VI_TINH_THUOC.ID;
                m_cbo_dv_cap_2.DisplayMember = GD_DON_VI_TINH_THUOC.TEN_DON_VI;
                m_cbo_dv_cap_2.Enabled = false;
            }
            else
            {
                load_cbo_dv_cap_2_start();
            }
        }
        private void load_cbo_dv_cap_3(decimal ip_id_nhom_dv_tinh)
        {
            US_GD_DON_VI_TINH_THUOC v_us_v_gd_don_vi_tinh_thuoc = new US_GD_DON_VI_TINH_THUOC();
            DS_GD_DON_VI_TINH_THUOC v_ds_v_gd_don_vi_tinh_thuoc = new DS_GD_DON_VI_TINH_THUOC();

            v_us_v_gd_don_vi_tinh_thuoc.FillDataset(v_ds_v_gd_don_vi_tinh_thuoc, "where ID_NHOM_DON_VI_TINH = " + ip_id_nhom_dv_tinh);
            if (v_ds_v_gd_don_vi_tinh_thuoc.GD_DON_VI_TINH_THUOC.Count != 0)
            {
                m_cbo_dv_cap_3.DataSource = v_ds_v_gd_don_vi_tinh_thuoc.GD_DON_VI_TINH_THUOC;
                m_cbo_dv_cap_3.ValueMember = GD_DON_VI_TINH_THUOC.ID;
                m_cbo_dv_cap_3.DisplayMember = GD_DON_VI_TINH_THUOC.TEN_DON_VI;
                m_cbo_dv_cap_3.Enabled = false;

            }
            else
            {
                load_cbo_dv_cap_3_start();
            }
        }
        private void load_cbo_dv_cap_4(decimal ip_id_nhom_dv_tinh)
        {
            US_GD_DON_VI_TINH_THUOC v_us_v_gd_don_vi_tinh_thuoc = new US_GD_DON_VI_TINH_THUOC();
            DS_GD_DON_VI_TINH_THUOC v_ds_v_gd_don_vi_tinh_thuoc = new DS_GD_DON_VI_TINH_THUOC();

            v_us_v_gd_don_vi_tinh_thuoc.FillDataset(v_ds_v_gd_don_vi_tinh_thuoc, "where ID_NHOM_DON_VI_TINH = " + ip_id_nhom_dv_tinh);
            if (v_ds_v_gd_don_vi_tinh_thuoc.GD_DON_VI_TINH_THUOC.Count != 0)
            {
                m_cbo_dv_cap_4.DataSource = v_ds_v_gd_don_vi_tinh_thuoc.GD_DON_VI_TINH_THUOC;
                m_cbo_dv_cap_4.ValueMember = GD_DON_VI_TINH_THUOC.ID;
                m_cbo_dv_cap_4.DisplayMember = GD_DON_VI_TINH_THUOC.TEN_DON_VI;
                m_cbo_dv_cap_4.Enabled = false;

            }
            else
            {
                load_cbo_dv_cap_4_start();
            }
        }
        private void load_ten_thuoc()
        {
            US_V_DM_THUOC v_us = new US_V_DM_THUOC();
            DS_V_DM_THUOC v_ds = new DS_V_DM_THUOC();
            v_us.FillDataset(v_ds);
            m_txt_search_thuoc1.load_data_to_list(v_ds, V_DM_THUOC.DISPLAY, V_DM_THUOC.ID);
        }
        private void load_data_2_cbo_nha_cung_cap()
        {
            US_DM_NCC_NSX_NHASX v_us = new US_DM_NCC_NSX_NHASX();
            DS_DM_NCC_NSX_NHASX v_ds = new DS_DM_NCC_NSX_NHASX();
            v_us.FillDataset(v_ds, "where id_loai_dm=1");
            m_cbo_nha_cung_cap.DataSource = v_ds.DM_NCC_NSX_NHASX;
            m_cbo_nha_cung_cap.ValueMember = DM_NCC_NSX_NHASX.ID;
            m_cbo_nha_cung_cap.DisplayMember = DM_NCC_NSX_NHASX.TEN_NCC;
        }
        private void load_data_2_cbo_hang_sx()
        {
            US_DM_NCC_NSX_NHASX v_us = new US_DM_NCC_NSX_NHASX();
            DS_DM_NCC_NSX_NHASX v_ds = new DS_DM_NCC_NSX_NHASX();
            v_us.FillDataset(v_ds, "where id_loai_dm=3");
            m_cbo_hang_san_xuat.DataSource = v_ds.DM_NCC_NSX_NHASX;
            m_cbo_hang_san_xuat.ValueMember = DM_NCC_NSX_NHASX.ID;
            m_cbo_hang_san_xuat.DisplayMember = DM_NCC_NSX_NHASX.TEN_NCC;
        }
        private void load_data_2_cbo_nuoc_sx()
        {
            US_DM_NCC_NSX_NHASX v_us = new US_DM_NCC_NSX_NHASX();
            DS_DM_NCC_NSX_NHASX v_ds = new DS_DM_NCC_NSX_NHASX();
            v_ds.Clear();
            v_us.FillDataset(v_ds, "where id_loai_dm=2");
            m_cbo_nuoc_san_xuat.ValueMember = DM_NCC_NSX_NHASX.ID;
            m_cbo_nuoc_san_xuat.DisplayMember = DM_NCC_NSX_NHASX.TEN_NCC;
            m_cbo_nuoc_san_xuat.DataSource = v_ds.DM_NCC_NSX_NHASX;

        }
        private void load_data_2_label()
        {
            m_lbl_dv_tinh_nhap.Text = "1" + " " + m_cbo_don_vi_tinh.Text;
            m_lbl_dv_tinh_ban.Text = "1" + " " + m_cbo_don_vi_tinh.Text;
            m_lbl_don_vi_cap_2.Text = "1" + " " + m_cbo_dv_cap_2.Text;
            m_lbl_don_vi_cap_3.Text = "1" + " " + m_cbo_dv_cap_4.Text;

        }      
        private void load_don_gia_ban()
        {
            US_V_GD_DON_VI_TINH_THUOC v_us_v_gd_don_vi_tinh_thuoc = new US_V_GD_DON_VI_TINH_THUOC();
            DS_V_GD_DON_VI_TINH_THUOC v_ds_v_gd_don_vi_tinh_thuoc = new DS_V_GD_DON_VI_TINH_THUOC();
            US_GD_GIA_BAN v_us_gia_ban = new US_GD_GIA_BAN();
            DS_GD_GIA_BAN v_ds_gia_ban = new DS_GD_GIA_BAN();
            decimal don_gia;
            decimal id_thuoc = m_txt_search_thuoc1.dcID;
            decimal v_id_don_vi_tinh = CIPConvert.ToDecimal(m_cbo_don_vi_tinh.SelectedValue);
            v_ds_v_gd_don_vi_tinh_thuoc.Clear();
            v_us_gia_ban.FillDataset(v_ds_gia_ban, "where ID_THUOC = '" + id_thuoc + "' and ID_DON_VI_TINH=" + v_id_don_vi_tinh);
            if (v_ds_gia_ban.GD_GIA_BAN.Count != 0)
            {
                don_gia = CIPConvert.ToDecimal(v_ds_gia_ban.Tables[0].Rows[0]["GIA_BAN"]);
                m_txt_gia_ban.Text = don_gia.ToString();
                m_txt_gia_ban.Text = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_gia_ban.Text.Trim()));
            }
            else
            {
                m_txt_gia_ban.Text = "";
            }



        }
        private void load_quy_doi()
        {
            US_DM_DON_VI_TINH v_us_don_vi_tinh = new US_DM_DON_VI_TINH();
            DS_DM_DON_VI_TINH v_ds_don_vi_tinh = new DS_DM_DON_VI_TINH();
            decimal v_id_thuoc = m_txt_search_thuoc1.dcID;
            v_us_don_vi_tinh.FillDataset(v_ds_don_vi_tinh, "where ID_THUOC=" + v_id_thuoc);
            if (v_ds_don_vi_tinh.DM_DON_VI_TINH.Count != 0)
            {
                decimal v_id_nhom_don_vi_tinh = CIPConvert.ToDecimal(v_ds_don_vi_tinh.Tables[0].Rows[0]["ID"]);
                US_GD_DON_VI_TINH_THUOC v_us_gd_don_vi_tinh_thuoc = new US_GD_DON_VI_TINH_THUOC();
                DS_GD_DON_VI_TINH_THUOC v_ds_gd_don_vi_tinh_thuoc = new DS_GD_DON_VI_TINH_THUOC();
                v_ds_gd_don_vi_tinh_thuoc.Clear();
                v_us_gd_don_vi_tinh_thuoc.FillDataset(v_ds_gd_don_vi_tinh_thuoc, "where ID_NHOM_DON_VI_TINH=" + v_id_nhom_don_vi_tinh);
                int count = v_ds_gd_don_vi_tinh_thuoc.GD_DON_VI_TINH_THUOC.Count;
                if (count > 1)
                {
                    m_cbo_dv_cap_2.SelectedValue = v_ds_gd_don_vi_tinh_thuoc.Tables[0].Rows[1]["ID"];
                    m_txt_quy_doi_1.Text = v_ds_gd_don_vi_tinh_thuoc.Tables[0].Rows[1]["QUY_DOI"].ToString();
                }
                if (count > 2)
                {
                    m_cbo_dv_cap_3.SelectedValue = v_ds_gd_don_vi_tinh_thuoc.Tables[0].Rows[2]["ID"];
                    m_txt_quy_doi_2.Text = v_ds_gd_don_vi_tinh_thuoc.Tables[0].Rows[2]["QUY_DOI"].ToString();
                }
                else
                {
                    m_cbo_dv_cap_3.SelectedValue = m_cbo_dv_cap_2.SelectedValue;
                    m_txt_quy_doi_2.Text = "1";
                    m_txt_quy_doi_2.Enabled = false;
                }
                if (count == 4)
                {
                    m_cbo_dv_cap_4.SelectedValue = v_ds_gd_don_vi_tinh_thuoc.Tables[0].Rows[3]["ID"];
                    m_txt_quy_doi_3.Text = v_ds_gd_don_vi_tinh_thuoc.Tables[0].Rows[3]["QUY_DOI"].ToString();
                }
                else
                {
                    m_cbo_dv_cap_4.SelectedValue = m_cbo_dv_cap_3.SelectedValue;
                    m_txt_quy_doi_3.Text = "1";
                    m_txt_quy_doi_3.Enabled = false;
                }


            }
            else
            {
                restart_quy_doi();
            }
        }
        private void add_list()
        {
            data v_data = new data();
            //string gia_nha_convert = m_txt_gia_nhap.Text.Remove(m_txt_gia_nhap.Text.IndexOf(','));
            v_data.ten_thuoc = m_txt_search_thuoc1.Text1;
            v_data.ngay_nhap = DateTime.Now;
            v_data.ngay_sx = m_dtp_ngay_san_xuat.Value;
            v_data.han_sd = m_dtp_han_su_dung.Value;
            v_data.nha_cung_cap = m_cbo_nha_cung_cap.Text;
            v_data.hang_sx = m_cbo_hang_san_xuat.Text;
            v_data.nuoc_sx = m_cbo_nuoc_san_xuat.Text;
            v_data.ID_thuoc = m_txt_search_thuoc1.dcID;
            v_data.so_luong = int.Parse(m_txt_so_luong.Text);
            v_data.sd_so_luong = int.Parse(m_txt_so_luong.Text) * int.Parse(m_txt_quy_doi_1.Text) * int.Parse(m_txt_quy_doi_2.Text) * int.Parse(m_txt_quy_doi_3.Text);
            v_data.gia = int.Parse(m_txt_gia_nhap.Text.Trim().Replace(",", "").Replace(".", ""));
            v_data.gia_ban = int.Parse(m_txt_gia_ban.Text.Trim().Replace(",", "").Replace(".", ""));
            //v_data.ID_don_vi_thuoc = CIPConvert.ToDecimal(m_cbo_dv_cap_4.SelectedValue);
            v_data.quy_doi_1 = m_txt_quy_doi_1.Text;
            v_data.quy_doi_2 = m_txt_quy_doi_2.Text;
            v_data.quy_doi_3 = m_txt_quy_doi_3.Text;
            v_data.don_vi_cap_2 = m_cbo_dv_cap_2.Text;
            v_data.don_vi_cap_3 = m_cbo_dv_cap_3.Text;
            v_data.don_vi_cap_4 = m_cbo_dv_cap_4.Text;
            v_data.id_nha_cc = CIPConvert.ToDecimal(m_cbo_nha_cung_cap.SelectedValue);
            v_data.id_nuoc_sx = CIPConvert.ToDecimal(m_cbo_nuoc_san_xuat.SelectedValue);
            v_data.id_hang_sx = CIPConvert.ToDecimal(m_cbo_hang_san_xuat.SelectedValue);
            v_data.ma_giao_dich = m_lbl_ma_giao_dich.Text;
            v_data.ten_don_vi_tinh_thuoc = m_cbo_don_vi_tinh.Text;
            list.Add(v_data);
        }
        private void load_data_2_don_vi_tinh(US_DM_DON_VI_TINH ip_us_dm_dv_tinh)
        {

            DS_DM_DON_VI_TINH m_ds_dm_dv_tinh = new DS_DM_DON_VI_TINH();

            foreach (data v_list in list)
            {
                m_ds_dm_dv_tinh.Clear();
                ip_us_dm_dv_tinh.FillDataset(m_ds_dm_dv_tinh, "where id_thuoc=" + v_list.ID_thuoc);
                if (m_ds_dm_dv_tinh.DM_DON_VI_TINH.Count == 0)
                {
                    ip_us_dm_dv_tinh.dcID_THUOC = v_list.ID_thuoc;
                    ip_us_dm_dv_tinh.strMA_NHOM = v_list.ID_thuoc.ToString() + v_list.ten_thuoc;
                    ip_us_dm_dv_tinh.datNGAY_LAP = v_list.ngay_nhap;
                    ip_us_dm_dv_tinh.dcID_TRANG_THAI = 12;
                    ip_us_dm_dv_tinh.Insert();
                    v_list.ID_nhom_dv_tinh = ip_us_dm_dv_tinh.dcID;
                }
                else
                {
                    v_list.ID_nhom_dv_tinh = CIPConvert.ToDecimal(m_ds_dm_dv_tinh.Tables[0].Rows[0]["ID"]);
                }

            }
        }
        private void load_data_2_gd_dv_tinh_thuoc(US_GD_DON_VI_TINH_THUOC ip_us_gd_dv_tinh_thuoc)
        {

            DS_GD_DON_VI_TINH_THUOC v_ds_gd_dv_tinh_thuoc = new DS_GD_DON_VI_TINH_THUOC();
            foreach (data v_list in list)
            {

                v_ds_gd_dv_tinh_thuoc.Clear();
                ip_us_gd_dv_tinh_thuoc.FillDataset(v_ds_gd_dv_tinh_thuoc, "where id_nhom_don_vi_tinh=" + v_list.ID_nhom_dv_tinh);
                if (v_ds_gd_dv_tinh_thuoc.GD_DON_VI_TINH_THUOC.Count == 0)
                {
                    ip_us_gd_dv_tinh_thuoc.strTEN_DON_VI = "Thùng";
                    ip_us_gd_dv_tinh_thuoc.dcID_NHOM_DON_VI_TINH = v_list.ID_nhom_dv_tinh;
                    ip_us_gd_dv_tinh_thuoc.dcQUY_DOI = 1;
                    ip_us_gd_dv_tinh_thuoc.Insert();
                    ip_us_gd_dv_tinh_thuoc.dcID_DON_VI_CHA = ip_us_gd_dv_tinh_thuoc.dcID;
                    ip_us_gd_dv_tinh_thuoc.Update();
                    v_list.ID_dv_cap_1 = ip_us_gd_dv_tinh_thuoc.dcID;
                    if (v_list.ten_don_vi_tinh_thuoc == ip_us_gd_dv_tinh_thuoc.strTEN_DON_VI)
                    {
                        v_list.id_don_vi_thuoc_nhap = ip_us_gd_dv_tinh_thuoc.dcID;
                    }
                    decimal id_dv_cha = ip_us_gd_dv_tinh_thuoc.dcID;
                    ip_us_gd_dv_tinh_thuoc.strTEN_DON_VI = v_list.don_vi_cap_2;
                    ip_us_gd_dv_tinh_thuoc.dcID_NHOM_DON_VI_TINH = v_list.ID_nhom_dv_tinh;
                    ip_us_gd_dv_tinh_thuoc.dcID_DON_VI_CHA = id_dv_cha;
                    ip_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_list.quy_doi_1);
                    ip_us_gd_dv_tinh_thuoc.Insert();
                    v_list.ID_dv_cap_2 = ip_us_gd_dv_tinh_thuoc.dcID;
                    if (v_list.ten_don_vi_tinh_thuoc == ip_us_gd_dv_tinh_thuoc.strTEN_DON_VI.Trim())
                    {
                        v_list.id_don_vi_thuoc_nhap = ip_us_gd_dv_tinh_thuoc.dcID;
                    }
                    //v_list.ID_don_vi_thuoc = ip_us_gd_dv_tinh_thuoc.dcID;
                    decimal id_dv_cha_2 = ip_us_gd_dv_tinh_thuoc.dcID;
                    if (v_list.don_vi_cap_3 != v_list.don_vi_cap_2)
                    {
                        ip_us_gd_dv_tinh_thuoc.strTEN_DON_VI = v_list.don_vi_cap_3;
                        ip_us_gd_dv_tinh_thuoc.dcID_NHOM_DON_VI_TINH = v_list.ID_nhom_dv_tinh;
                        ip_us_gd_dv_tinh_thuoc.dcID_DON_VI_CHA = id_dv_cha_2;
                        ip_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_list.quy_doi_2);
                        ip_us_gd_dv_tinh_thuoc.Insert();
                        v_list.ID_don_vi_thuoc = ip_us_gd_dv_tinh_thuoc.dcID;

                        if (v_list.ten_don_vi_tinh_thuoc == ip_us_gd_dv_tinh_thuoc.strTEN_DON_VI.Trim())
                        {
                            v_list.id_don_vi_thuoc_nhap = ip_us_gd_dv_tinh_thuoc.dcID;
                        }
                        //v_list.ID_don_vi_thuoc = CIPConvert.ToDecimal(m_cbo_dv_cap_2.SelectedValue);
                    }
                    v_list.ID_dv_cap_3 = ip_us_gd_dv_tinh_thuoc.dcID;
                    decimal id_dv_cha_3 = ip_us_gd_dv_tinh_thuoc.dcID;
                    if (v_list.don_vi_cap_4 != v_list.don_vi_cap_3)
                    {
                        ip_us_gd_dv_tinh_thuoc.strTEN_DON_VI = v_list.don_vi_cap_4;
                        ip_us_gd_dv_tinh_thuoc.dcID_NHOM_DON_VI_TINH = v_list.ID_nhom_dv_tinh;
                        ip_us_gd_dv_tinh_thuoc.dcID_DON_VI_CHA = id_dv_cha_3;
                        ip_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_list.quy_doi_3);
                        ip_us_gd_dv_tinh_thuoc.Insert();
                        v_list.ID_don_vi_thuoc = ip_us_gd_dv_tinh_thuoc.dcID;
                        if (m_cbo_don_vi_tinh.Text == ip_us_gd_dv_tinh_thuoc.strTEN_DON_VI.Trim())
                        {
                            v_list.id_don_vi_thuoc_nhap = ip_us_gd_dv_tinh_thuoc.dcID;
                        }

                    }
                    v_list.ID_dv_cap_4 = ip_us_gd_dv_tinh_thuoc.dcID;
                    v_list.ID_don_vi_thuoc = ip_us_gd_dv_tinh_thuoc.dcID;

                    //load_cbo_don_vi_tinh(v_list.ID_nhom_dv_tinh);
                    //load_cbo_dv_cap_2(v_list.ID_nhom_dv_tinh);
                    //load_cbo_dv_cap_3(v_list.ID_nhom_dv_tinh);
                    //load_cbo_dv_cap_4(v_list.ID_nhom_dv_tinh);
                    //m_cbo_don_vi_tinh.SelectedValue = v_list.id_don_vi_thuoc_nhap;
                    //m_cbo_dv_cap_2.SelectedValue = v_list.ID_dv_cap_2;
                    //m_cbo_dv_cap_3.SelectedValue = v_list.ID_dv_cap_3;
                    //m_cbo_dv_cap_4.SelectedValue = v_list.ID_dv_cap_4;
                }
                else
                {

                    v_ds_gd_dv_tinh_thuoc.Clear();
                    ip_us_gd_dv_tinh_thuoc.FillDataset(v_ds_gd_dv_tinh_thuoc, "where  id_nhom_don_vi_tinh='" + v_list.ID_nhom_dv_tinh + "' and ten_don_vi like N'%Thùng%'");
                    DataRow v_dr = v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0];
                    v_list.ID_dv_cap_1 = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID]);
                    ip_us_gd_dv_tinh_thuoc.dcID = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID]);
                    v_list.id_don_vi_thuoc_nhap = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID]);
                    ip_us_gd_dv_tinh_thuoc.strTEN_DON_VI = v_dr[GD_DON_VI_TINH_THUOC.TEN_DON_VI].ToString();
                    ip_us_gd_dv_tinh_thuoc.dcID_NHOM_DON_VI_TINH = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID_NHOM_DON_VI_TINH]);
                    ip_us_gd_dv_tinh_thuoc.dcID_DON_VI_CHA = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID]);
                    ip_us_gd_dv_tinh_thuoc.dcQUY_DOI = 1;
                    ip_us_gd_dv_tinh_thuoc.Update();
                    v_ds_gd_dv_tinh_thuoc.Clear();
                    v_list.id_don_vi_thuoc_nhap = ip_us_gd_dv_tinh_thuoc.dcID;
                    v_list.ID_don_vi_thuoc = ip_us_gd_dv_tinh_thuoc.dcID;
                    if (v_list.don_vi_cap_2 == "Thùng")
                    {
                        return;
                    }
                    else
                    {

                        ip_us_gd_dv_tinh_thuoc.FillDataset(v_ds_gd_dv_tinh_thuoc, "where  id_nhom_don_vi_tinh='" + v_list.ID_nhom_dv_tinh + "' and ten_don_vi like N'%" + v_list.don_vi_cap_2 + "%'");
                        v_dr = v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0];
                        ip_us_gd_dv_tinh_thuoc.dcID = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID]);
                        v_list.ID_dv_cap_2 = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID]);
                        ip_us_gd_dv_tinh_thuoc.strTEN_DON_VI = v_dr[GD_DON_VI_TINH_THUOC.TEN_DON_VI].ToString();
                        ip_us_gd_dv_tinh_thuoc.dcID_DON_VI_CHA = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID_DON_VI_CHA].ToString());
                        ip_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.QUY_DOI].ToString().Trim());
                        ip_us_gd_dv_tinh_thuoc.dcID_NHOM_DON_VI_TINH = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID_NHOM_DON_VI_TINH].ToString());
                        if (ip_us_gd_dv_tinh_thuoc.dcQUY_DOI != CIPConvert.ToDecimal(v_list.quy_doi_1)) ip_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_list.quy_doi_1);
                        ip_us_gd_dv_tinh_thuoc.Update();
                        v_list.ID_don_vi_thuoc = v_list.ID_dv_cap_2;
                        if (v_list.ten_don_vi_tinh_thuoc == ip_us_gd_dv_tinh_thuoc.strTEN_DON_VI.Trim())
                        {
                            v_list.id_don_vi_thuoc_nhap = ip_us_gd_dv_tinh_thuoc.dcID;
                        }
                        v_ds_gd_dv_tinh_thuoc.Clear();
                        ip_us_gd_dv_tinh_thuoc.FillDataset(v_ds_gd_dv_tinh_thuoc, "where id_nhom_don_vi_tinh='" + v_list.ID_nhom_dv_tinh + "' and ten_don_vi like N'%" + v_list.don_vi_cap_3 + "%'");
                        if (v_ds_gd_dv_tinh_thuoc.GD_DON_VI_TINH_THUOC.Count != 0)
                        {
                            v_dr = v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0];
                            ip_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.QUY_DOI].ToString().Trim());
                            ip_us_gd_dv_tinh_thuoc.dcID = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID]);
                            v_list.ID_dv_cap_3 = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID]);
                            ip_us_gd_dv_tinh_thuoc.dcID_DON_VI_CHA = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID_DON_VI_CHA].ToString());
                            ip_us_gd_dv_tinh_thuoc.dcID_NHOM_DON_VI_TINH = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID_NHOM_DON_VI_TINH].ToString());
                            ip_us_gd_dv_tinh_thuoc.strTEN_DON_VI = v_dr[GD_DON_VI_TINH_THUOC.TEN_DON_VI].ToString();
                            if (ip_us_gd_dv_tinh_thuoc.dcQUY_DOI != CIPConvert.ToDecimal(v_list.quy_doi_2)) ip_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_list.quy_doi_2);
                            ip_us_gd_dv_tinh_thuoc.Update();
                            v_list.ID_don_vi_thuoc = v_list.ID_dv_cap_3;
                            if (v_list.ten_don_vi_tinh_thuoc == ip_us_gd_dv_tinh_thuoc.strTEN_DON_VI.Trim())
                            {
                                v_list.id_don_vi_thuoc_nhap = ip_us_gd_dv_tinh_thuoc.dcID;
                            }
                        }
                        v_ds_gd_dv_tinh_thuoc.Clear();
                        ip_us_gd_dv_tinh_thuoc.FillDataset(v_ds_gd_dv_tinh_thuoc, "where id_nhom_don_vi_tinh='" + v_list.ID_nhom_dv_tinh + "' and ten_don_vi like N'%" + v_list.don_vi_cap_4 + "%'");
                        if (v_ds_gd_dv_tinh_thuoc.GD_DON_VI_TINH_THUOC.Count != 0)
                        {
                            v_dr = v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0];
                            ip_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.QUY_DOI].ToString().Trim());
                            ip_us_gd_dv_tinh_thuoc.dcID = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID]);
                            v_list.ID_dv_cap_4 = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID]);
                            ip_us_gd_dv_tinh_thuoc.dcID_DON_VI_CHA = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID_DON_VI_CHA].ToString());
                            ip_us_gd_dv_tinh_thuoc.dcID_NHOM_DON_VI_TINH = CIPConvert.ToDecimal(v_dr[GD_DON_VI_TINH_THUOC.ID_NHOM_DON_VI_TINH].ToString());
                            ip_us_gd_dv_tinh_thuoc.strTEN_DON_VI = v_dr[GD_DON_VI_TINH_THUOC.TEN_DON_VI].ToString();
                            if (ip_us_gd_dv_tinh_thuoc.dcQUY_DOI != CIPConvert.ToDecimal(v_list.quy_doi_3)) ip_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_list.quy_doi_3);
                            ip_us_gd_dv_tinh_thuoc.Update();
                            v_list.ID_don_vi_thuoc = v_list.ID_dv_cap_4;
                            if (v_list.ten_don_vi_tinh_thuoc == ip_us_gd_dv_tinh_thuoc.strTEN_DON_VI.Trim())
                            {
                                v_list.id_don_vi_thuoc_nhap = ip_us_gd_dv_tinh_thuoc.dcID;
                            }
                        }
                    }

                }

            }
        }
        private void load_data_2_gd_detial(US_GD_GIAO_DICH_DETAIL ip_us_gd_detail)
        {

            DS_GD_GIAO_DICH_DETAIL v_ds_gd_detail = new DS_GD_GIAO_DICH_DETAIL();
            foreach (data v_list in list)
            {
                decimal ID_GIAO_DICH = m_id_giao_dich;
                decimal ID_THUOC = CIPConvert.ToDecimal(v_list.ID_thuoc);
                decimal ID_DON_VI_THUOC = CIPConvert.ToDecimal(v_list.ID_don_vi_thuoc);
                decimal SO_LUONG_NHAP = CIPConvert.ToDecimal(v_list.so_luong) * CIPConvert.ToDecimal(v_list.quy_doi_1) * CIPConvert.ToDecimal(v_list.quy_doi_2) * CIPConvert.ToDecimal(v_list.quy_doi_3);
                decimal ID_NUOC_SX = CIPConvert.ToDecimal(v_list.id_nuoc_sx);
                decimal ID_NHA_CUNG_CAP = CIPConvert.ToDecimal(v_list.id_nha_cc);
                decimal ID_HANG_SX = CIPConvert.ToDecimal(v_list.id_hang_sx);
                decimal SO_LUONG_BAN = 0;
                decimal GIA_BAN = CIPConvert.ToDecimal(v_list.gia_ban);
                DateTime HAN_SU_DUNG = v_list.han_sd;
                decimal GIA_NHAP = CIPConvert.ToDecimal(v_list.gia) / (CIPConvert.ToDecimal(v_list.quy_doi_1) * CIPConvert.ToDecimal(v_list.quy_doi_2) * CIPConvert.ToDecimal(v_list.quy_doi_3));
                decimal ID_GD_DETAIL = 0;
                ip_us_gd_detail.Insert_data_into_gd_giao_dich_detail(ID_GIAO_DICH, ID_THUOC, ID_DON_VI_THUOC, SO_LUONG_NHAP, SO_LUONG_BAN, ID_GD_DETAIL, ID_NHA_CUNG_CAP, ID_NUOC_SX, ID_HANG_SX, HAN_SU_DUNG, GIA_BAN, GIA_NHAP);
            }
        }
        private void load_data_2_gd_giao_dich(US_GD_GIAO_DICH ip_us_gd)
        {

            DS_GD_GIAO_DICH v_ds_gd = new DS_GD_GIAO_DICH();
            foreach (data v_list in list)
            {
                ip_us_gd.dcID_LOAI_GIAO_DICH = ID_LOAI_GIAO_DICH.NHAP_THUOC;
                ip_us_gd.dcID_BAC_SY = 10;
                ip_us_gd.dcID_KHACH_HANG = 1;
                ip_us_gd.strMA_GIAO_DICH = v_list.ma_giao_dich;
                ip_us_gd.datNGAY_GIAO_DICH = v_list.ngay_nhap;
                ip_us_gd.dcID_NGUOI_THUC_HIEN = CAppContext_201.getCurrentUserID();


            }
            ip_us_gd.Insert();
            m_id_giao_dich = ip_us_gd.dcID;
        }
        //private void load_cbo_dv() {
        //    load_cbo_don_vi_tinh();
        //    load_cbo_dv_cap_2();
        //    load_cbo_dv_cap_3();
        //    load_cbo_dv_cap_4();
        //}
        private void load_data_2_gd_gia_ban(US_GD_GIA_BAN ip_us_gd_gia_ban)
        {

            DS_GD_GIA_BAN v_ds = new DS_GD_GIA_BAN();
            foreach (data v_list in list)
            {
                decimal v_id_thuoc = v_list.ID_thuoc;
                decimal gia_ban_dv_1=0;
                v_ds.Clear();
                ip_us_gd_gia_ban.FillDataset(v_ds, "where id_thuoc=" + v_id_thuoc);
                if (v_ds.GD_GIA_BAN.Count == 0)
                {

                    ip_us_gd_gia_ban.dcID_THUOC = v_list.ID_thuoc;
                    ip_us_gd_gia_ban.dcID_DON_VI_TINH = CIPConvert.ToDecimal(v_list.id_don_vi_thuoc_nhap);
                    ip_us_gd_gia_ban.dcGIA_BAN = CIPConvert.ToDecimal(v_list.gia_ban.ToString());
                    ip_us_gd_gia_ban.Insert();
                    decimal v_id_dv_tinh_gia = ip_us_gd_gia_ban.dcID;
                    if (v_list.ten_don_vi_tinh_thuoc == "Thùng")
                    {
                        ip_us_gd_gia_ban.dcID_THUOC = v_list.ID_thuoc;
                        ip_us_gd_gia_ban.dcID_DON_VI_TINH = v_list.ID_dv_cap_2;
                        ip_us_gd_gia_ban.dcGIA_BAN = CIPConvert.ToDecimal(v_list.gia_ban) / CIPConvert.ToDecimal(v_list.quy_doi_1);
                        ip_us_gd_gia_ban.Insert();

                    }
                    else
                    {
                        if (v_list.id_don_vi_thuoc_nhap == v_list.ID_dv_cap_2)
                        {
                            ip_us_gd_gia_ban.dcID_THUOC = v_list.ID_thuoc;
                            ip_us_gd_gia_ban.dcID_DON_VI_TINH = CIPConvert.ToDecimal(v_list.ID_dv_cap_1);
                            ip_us_gd_gia_ban.dcGIA_BAN = CIPConvert.ToDecimal(v_list.gia_ban) * CIPConvert.ToDecimal(v_list.quy_doi_1);
                            ip_us_gd_gia_ban.Insert();
                        }
                    }

                    if (v_list.ID_dv_cap_2 != v_list.ID_dv_cap_3)
                    {
                        ip_us_gd_gia_ban.dcID_THUOC = v_list.ID_thuoc;
                        ip_us_gd_gia_ban.dcID_DON_VI_TINH = v_list.ID_dv_cap_3;
                        ip_us_gd_gia_ban.dcGIA_BAN = (CIPConvert.ToDecimal(v_list.gia_ban) / CIPConvert.ToDecimal(v_list.quy_doi_1)) / CIPConvert.ToDecimal(v_list.quy_doi_2);
                        ip_us_gd_gia_ban.Insert();
                    }
                    decimal gia_ban_dv = ip_us_gd_gia_ban.dcGIA_BAN;
                    if (v_list.ID_dv_cap_3 != v_list.ID_dv_cap_4)
                    {
                        ip_us_gd_gia_ban.dcID_THUOC = v_list.ID_thuoc;
                        ip_us_gd_gia_ban.dcID_DON_VI_TINH = v_list.ID_dv_cap_4;
                        ip_us_gd_gia_ban.dcGIA_BAN = gia_ban_dv / CIPConvert.ToDecimal(v_list.quy_doi_3);
                        ip_us_gd_gia_ban.Insert();
                    }
                }


                else
                {
                    if (v_list.ID_dv_cap_1 == v_list.id_don_vi_thuoc_nhap) gia_ban_dv_1 = v_list.gia_ban;
                    if (v_list.ID_dv_cap_2 == v_list.id_don_vi_thuoc_nhap) gia_ban_dv_1 = v_list.gia_ban * CIPConvert.ToDecimal(v_list.quy_doi_1);
                    if (v_list.ID_dv_cap_3 == v_list.id_don_vi_thuoc_nhap) gia_ban_dv_1 = v_list.gia_ban * CIPConvert.ToDecimal(v_list.quy_doi_1) * CIPConvert.ToDecimal(v_list.quy_doi_2);
                    if (v_list.ID_dv_cap_4 == v_list.id_don_vi_thuoc_nhap) gia_ban_dv_1 = v_list.gia_ban * CIPConvert.ToDecimal(v_list.quy_doi_1) * CIPConvert.ToDecimal(v_list.quy_doi_2) * CIPConvert.ToDecimal(v_list.quy_doi_3);
                    v_ds.Clear();
                    ip_us_gd_gia_ban.FillDataset(v_ds, "where id_thuoc='" + v_list.ID_thuoc + "' and id_don_vi_tinh=" + v_list.ID_dv_cap_1);
                    DataRow v_dr = v_ds.Tables[0].Rows[0];
                    if (CIPConvert.ToDecimal(v_dr[GD_GIA_BAN.GIA_BAN].ToString()) != gia_ban_dv_1)
                    {
                        ip_us_gd_gia_ban.dcID = CIPConvert.ToDecimal(v_dr[GD_GIA_BAN.ID].ToString());
                        ip_us_gd_gia_ban.dcID_THUOC = CIPConvert.ToDecimal(v_dr[GD_GIA_BAN.ID_THUOC].ToString());
                        ip_us_gd_gia_ban.dcID_DON_VI_TINH = CIPConvert.ToDecimal(v_dr[GD_GIA_BAN.ID_DON_VI_TINH].ToString());
                        ip_us_gd_gia_ban.dcGIA_BAN = gia_ban_dv_1;
                        ip_us_gd_gia_ban.Update();
                        v_ds.Clear();
                        ip_us_gd_gia_ban.FillDataset(v_ds, "where id_thuoc='" + v_list.ID_thuoc + "' and id_don_vi_tinh=" + v_list.ID_dv_cap_2);
                        v_dr = v_ds.Tables[0].Rows[0];
                        ip_us_gd_gia_ban.dcID = CIPConvert.ToDecimal(v_dr[GD_GIA_BAN.ID].ToString());
                        ip_us_gd_gia_ban.dcID_THUOC = CIPConvert.ToDecimal(v_dr[GD_GIA_BAN.ID_THUOC].ToString());
                        ip_us_gd_gia_ban.dcID_DON_VI_TINH = CIPConvert.ToDecimal(v_dr[GD_GIA_BAN.ID_DON_VI_TINH].ToString());
                        ip_us_gd_gia_ban.dcGIA_BAN = gia_ban_dv_1 / CIPConvert.ToDecimal(v_list.quy_doi_1);
                        ip_us_gd_gia_ban.Update();
                        v_ds.Clear();
                        ip_us_gd_gia_ban.FillDataset(v_ds, "where id_thuoc='" + v_list.ID_thuoc + "' and id_don_vi_tinh=" + v_list.ID_dv_cap_3);
                        v_dr = v_ds.Tables[0].Rows[0];
                        ip_us_gd_gia_ban.dcID = CIPConvert.ToDecimal(v_dr[GD_GIA_BAN.ID].ToString());
                        ip_us_gd_gia_ban.dcID_THUOC = CIPConvert.ToDecimal(v_dr[GD_GIA_BAN.ID_THUOC].ToString());
                        ip_us_gd_gia_ban.dcID_DON_VI_TINH = CIPConvert.ToDecimal(v_dr[GD_GIA_BAN.ID_DON_VI_TINH].ToString());
                        ip_us_gd_gia_ban.dcGIA_BAN = gia_ban_dv_1 / (CIPConvert.ToDecimal(v_list.quy_doi_1) * CIPConvert.ToDecimal(v_list.quy_doi_2));
                        ip_us_gd_gia_ban.Update();
                        v_ds.Clear();
                        if (v_list.ID_dv_cap_3 != v_list.ID_dv_cap_4)
                        {
                            ip_us_gd_gia_ban.FillDataset(v_ds, "where id_thuoc='" + v_list.ID_thuoc + "' and id_don_vi_tinh=" + v_list.ID_dv_cap_4);
                            v_dr = v_ds.Tables[0].Rows[0];
                            ip_us_gd_gia_ban.dcID = CIPConvert.ToDecimal(v_dr[GD_GIA_BAN.ID].ToString());
                            ip_us_gd_gia_ban.dcID_THUOC = CIPConvert.ToDecimal(v_dr[GD_GIA_BAN.ID_THUOC].ToString());
                            ip_us_gd_gia_ban.dcID_DON_VI_TINH = CIPConvert.ToDecimal(v_dr[GD_GIA_BAN.ID_DON_VI_TINH].ToString());
                            ip_us_gd_gia_ban.dcGIA_BAN = gia_ban_dv_1 / (CIPConvert.ToDecimal(v_list.quy_doi_1) * CIPConvert.ToDecimal(v_list.quy_doi_2) * CIPConvert.ToDecimal(v_list.quy_doi_3));
                            ip_us_gd_gia_ban.Update();
                        }
                    }
                }

            }
        }
        private void load_data_2_gd_so_du(US_GD_SO_DU ip_us_gd_so_du)
        {

            DS_GD_SO_DU v_ds_sd = new DS_GD_SO_DU();


            foreach (data v_list in list)
            {
                v_ds_sd.Clear();
                ip_us_gd_so_du.FillDataset(v_ds_sd, "where id_thuoc='" + v_list.ID_thuoc + "' and moi_nhat_yn='Y'");
                if (v_ds_sd.GD_SO_DU.Count == 0)
                {
                    ip_us_gd_so_du.dcID_THUOC = CIPConvert.ToDecimal(v_list.ID_thuoc);
                    ip_us_gd_so_du.dcID_DON_VI_THUOC = CIPConvert.ToDecimal(v_list.ID_don_vi_thuoc);
                    ip_us_gd_so_du.dcSO_DU = CIPConvert.ToDecimal(v_list.sd_so_luong);
                    ip_us_gd_so_du.datNGAY_PHAT_SINH = v_list.ngay_nhap;
                    ip_us_gd_so_du.strMOI_NHAT_YN = "Y";
                    ip_us_gd_so_du.Insert();
                }
                else
                {
                    DateTime v_dat_nps = (DateTime)(v_ds_sd.Tables[0].Rows[0]["NGAY_PHAT_SINH"]);
                    if (v_dat_nps.Date != DateTime.Now.Date)
                    {
                        ip_us_gd_so_du.dcID = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID"]);
                        ip_us_gd_so_du.dcID_THUOC = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID_THUOC"]);
                        ip_us_gd_so_du.dcSO_DU = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["SO_DU"]);
                        ip_us_gd_so_du.dcID_DON_VI_THUOC = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID_DON_VI_THUOC"]);
                        ip_us_gd_so_du.datNGAY_PHAT_SINH = v_dat_nps;
                        ip_us_gd_so_du.strMOI_NHAT_YN = v_ds_sd.Tables[0].Rows[0]["MOI_NHAT_YN"].ToString();
                        ip_us_gd_so_du.strMOI_NHAT_YN = "N";
                        ip_us_gd_so_du.Update();
                        ip_us_gd_so_du.datNGAY_PHAT_SINH = DateTime.Now;
                        ip_us_gd_so_du.dcID_THUOC = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID_THUOC"]);
                        ip_us_gd_so_du.dcID_DON_VI_THUOC = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID_DON_VI_THUOC"]);
                        ip_us_gd_so_du.strMOI_NHAT_YN = "Y";
                        ip_us_gd_so_du.dcSO_DU = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["SO_DU"]) + v_list.sd_so_luong;
                        ip_us_gd_so_du.Insert();
                    }
                    else
                    {
                        ip_us_gd_so_du.dcID = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID"]);
                        ip_us_gd_so_du.dcID_THUOC = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID_THUOC"]);
                        ip_us_gd_so_du.dcSO_DU = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["SO_DU"]) + v_list.sd_so_luong;
                        if (v_list.ID_don_vi_thuoc != CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID_DON_VI_THUOC"]))
                        {
                            ip_us_gd_so_du.dcID_DON_VI_THUOC = v_list.ID_don_vi_thuoc;
                        }
                        else
                            ip_us_gd_so_du.dcID_DON_VI_THUOC = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID_DON_VI_THUOC"]);
                        //ip_us_gd_so_du.datNGAY_PHAT_SINH = CIPConvert.ToDatetime( v_ds_sd.Tables[0].Rows[0]["NGAY_PHAT_SINH"].ToString(),"dd/MM/yyyy");
                        ip_us_gd_so_du.datNGAY_PHAT_SINH = DateTime.Now;
                        ip_us_gd_so_du.strMOI_NHAT_YN = "Y";
                        ip_us_gd_so_du.Update();
                    }
                }
            }
        }
        private void restart_form()
        {
            m_txt_gia_nhap.Clear();
            m_txt_gia_ban.Clear();
            m_txt_so_luong.Clear();
            m_txt_search_thuoc1.Visible = true;
            m_txt_search_thuoc1.xoa_trang();
            //m_txt_search_thuoc1.Text1 = "";
            restart_quy_doi();
            load_data_2_label();
        }
        private void restart_quy_doi()
        {
            load_cbo_don_vi_tinh_start();
            load_cbo_dv_cap_2_start();
            load_cbo_dv_cap_3_start();
            load_cbo_dv_cap_4_start();
            m_txt_quy_doi_2.Enabled = true;
            m_txt_quy_doi_3.Enabled = true;
            m_txt_quy_doi_1.Text = "1";
            m_txt_quy_doi_2.Text = "1";
            m_txt_quy_doi_3.Text = "1";

        }
        private bool check_validate()
        {
            if (m_txt_search_thuoc1.Text1 == null)
            {
                BaseMessages.MsgBox_Infor("Bạn cần nhập tên thuốc");
                m_txt_search_thuoc1.Focus();
                return false;
            }
            if (m_txt_gia_nhap.Text == "")
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập giá nhập");
                m_txt_gia_nhap.Focus();
                return false;
            }
            if (m_txt_gia_ban.Text == "")
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập giá bán");
                m_txt_gia_ban.Focus();
                return false;
            }
            if (m_txt_so_luong.Text == "")
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập số lượng");
                m_txt_so_luong.Focus();
                return false;
            }
            if (m_txt_quy_doi_1.Text == "")
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập quy đổi đơn vị");
                m_txt_quy_doi_1.Focus();
                return false;
            }
            if (m_txt_quy_doi_2.Text == "")
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập quy đổi đơn vị");
                m_txt_quy_doi_2.Focus();
                return false;
            }
            if (m_txt_quy_doi_3.Text == "")
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập quy đổi đơn vị");
                m_txt_quy_doi_3.Focus();
                return false;
            }
            if (int.Parse(m_txt_gia_nhap.Text.Trim().Replace(",", "").Replace(".","")) > int.Parse(m_txt_gia_ban.Text.Trim().Replace(",", "").Replace(".","")))
            {
                BaseMessages.MsgBox_Infor("Giá bán phải lớn hơn giá nhập");
                m_txt_gia_nhap.Focus();
                return false;

            }
            if (m_cbo_dv_cap_4.Text == "Thùng" && m_cbo_dv_cap_3.Text != "Thùng")
            {
                BaseMessages.MsgBox_Infor("Bạn nhập sai các đơn vị quy đổi!!");
                m_cbo_dv_cap_4.Focus();
                return false;
            }
            if (m_cbo_dv_cap_3.Text == "Thùng" && m_cbo_dv_cap_2.Text != "Thùng")
            {
                BaseMessages.MsgBox_Infor("Bạn nhập sai các đơn vị quy đổi!!");
                m_cbo_dv_cap_3.Focus();
                return false;
            }
            if (m_cbo_dv_cap_4.Text == m_cbo_dv_cap_2.Text && m_cbo_dv_cap_3.Text != m_cbo_dv_cap_2.Text)
            {
                BaseMessages.MsgBox_Infor("Bạn nhập sai các đơn vị quy đổi!!");
                m_cbo_dv_cap_4.Focus();
                return false;
            }
            if (m_cbo_dv_cap_4.Text == m_cbo_dv_cap_3.Text && m_txt_quy_doi_3.Text != "1")
            {
                BaseMessages.MsgBox_Infor("Bạn nhập sai quy đổi đơn vị!!");
                m_txt_quy_doi_3.Focus();
                return false;
            }
            if (m_cbo_dv_cap_3.Text == m_cbo_dv_cap_2.Text && m_txt_quy_doi_2.Text != "1")
            {
                BaseMessages.MsgBox_Infor("Bạn nhập sai quy đổi đơn vị!!");
                m_txt_quy_doi_2.Focus();
                return false;
            }
            if (m_cbo_dv_cap_4.Text == m_cbo_dv_cap_3.Text && m_cbo_dv_cap_3.Text == m_cbo_dv_cap_2.Text && m_cbo_don_vi_tinh.Text == m_cbo_dv_cap_2.Text) {
                DialogResult dgr = MessageBox.Show("Bộ đơn vị bạn nhập chỉ có 1 đơn vị.Bạn có muốn nhập bộ đơn vị này không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dgr == DialogResult.No) {
                    m_cbo_dv_cap_2.Focus();
                    return false;
                }
            }
            if (m_dtp_ngay_san_xuat.Value>m_dtp_han_su_dung.Value )
            {
                BaseMessages.MsgBox_Infor("Bạn nhập sai hạn sử dụng");
                m_dtp_han_su_dung.Focus();
                return false;
            }

            return true;
        }
        private void set_define_event()
        {
            this.Load += new System.EventHandler(this.f511_gd_nhap_thuoc_Load);
            this.m_cbo_don_vi_tinh.SelectedIndexChanged += new System.EventHandler(this.m_cbo_don_vi_tinh_SelectedIndexChanged);
            this.m_cbo_dv_cap_2.SelectedIndexChanged += new System.EventHandler(this.m_cbo_dv_cap_2_SelectedIndexChanged);
            this.m_cbo_dv_cap_3.SelectedIndexChanged += new System.EventHandler(this.m_cbo_dv_cap_3_SelectedIndexChanged);
            this.m_txt_gia_nhap.TextChanged += new System.EventHandler(this.m_txt_gia_nhap_TextChanged);
            this.m_cmd_add.Click += new System.EventHandler(this.m_cmd_add_Click);
            this.m_cmd_save.Click += new System.EventHandler(this.m_cmd_save_Click);
            this.m_txt_gia_nhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_gia_nhap_KeyPress);
            this.m_txt_gia_ban.TextChanged += new System.EventHandler(this.m_txt_gia_ban_TextChanged);
            this.m_dtp_ngay_san_xuat.ValueChanged += new System.EventHandler(this.m_dtp_ngay_san_xuat_ValueChanged);
            this.m_txt_so_luong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.m_txt_so_luong_KeyPress);
            this.m_grv_nhap_thuoc.DoubleClick += new System.EventHandler(this.m_grv_nhap_thuoc_DoubleClick);
            this.m_cmd_delete.Click += new System.EventHandler(this.m_cmd_delete_Click);
            this.m_cmd_exit.Click += new System.EventHandler(this.m_cmd_exit_Click);
            this.m_txt_add_thuoc.Click += new System.EventHandler(this.m_txt_add_thuoc_Click);
            this.m_txt_search_thuoc1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_txt_search_thuoc1_KeyDown);
            this.m_cmd_upadate.Click += new System.EventHandler(this.m_cmd_upadate_Click);

        }
        #endregion

        #region Event
        private void f511_gd_nhap_thuoc_Load(object sender, EventArgs e)
        {
            set_inital_form_load();
        }
        private void m_cbo_dv_cap_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_lbl_don_vi_cap_2.Text = "1" + " " + m_cbo_dv_cap_2.Text;
            //m_cbo_dv_cap_3.Text = m_cbo_dv_cap_2.Text;
            //m_cbo_dv_cap_4.Text = m_cbo_dv_cap_2.Text;


        }
        private void m_cbo_dv_cap_3_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_lbl_don_vi_cap_3.Text = "1" + " " + m_cbo_dv_cap_3.Text;
            //m_cbo_dv_cap_4.Text = m_cbo_dv_cap_3.Text;

        }
        private void m_cbo_don_vi_tinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_lbl_dv_tinh_ban.Text = "1" + " " + m_cbo_don_vi_tinh.Text;
            m_lbl_dv_tinh_nhap.Text = "1" + " " + m_cbo_don_vi_tinh.Text;
            if (m_txt_search_thuoc1.Text1 != null)
            {
                load_don_gia_ban();
            }

        }
        private void m_cmd_add_Click(object sender, EventArgs e)
        {

            if (!check_validate()) return;
            add_list();
            int n = m_grv_nhap_thuoc.Rows.Add();
            //string v_gia_nhap = m_txt_gia_nhap.Text.Remove(m_txt_gia_nhap.Text.IndexOf(','));
            m_grv_nhap_thuoc.Rows[n].Cells[0].Value = n + 1;
            m_grv_nhap_thuoc.Rows[n].Cells[1].Value = m_txt_search_thuoc1.Text1;
            m_grv_nhap_thuoc.Rows[n].Cells[2].Value = m_txt_so_luong.Text;
            m_grv_nhap_thuoc.Rows[n].Cells[3].Value = m_cbo_don_vi_tinh.Text;
            m_grv_nhap_thuoc.Rows[n].Cells[4].Value = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_gia_nhap.Text.Trim().Replace(",", "").Replace(".", "")));
            m_grv_nhap_thuoc.Rows[n].Cells[5].Value = string.Format("{0:#,###}", CIPConvert.ToDecimal(int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_gia_nhap.Text.Trim().Replace(",", "").Replace(".", ""))));
            tong_tien += int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_gia_nhap.Text.Trim().Replace(",", "").Replace(".", ""));
            m_lbl_tong_tien.Text = string.Format("{0:#,###}", CIPConvert.ToDecimal(tong_tien));
            restart_form();
            m_trang_thai = true;
            m_cbo_dv_cap_2.Enabled = true;
            m_cbo_dv_cap_3.Enabled = true;
            m_cbo_dv_cap_4.Enabled = true;

        }
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_trang_thai == true)
                {
                    DialogResult dgr = MessageBox.Show("Bạn có muốn lưu dữ liệu không ?", "Thông báo  ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dgr == DialogResult.OK)
                    {
                        m_us_don_vi_tinh.BeginTransaction();
                        load_data_2_don_vi_tinh(m_us_don_vi_tinh);
                        US_GD_DON_VI_TINH_THUOC v_us_gd_dv_tinh_thuoc = new US_GD_DON_VI_TINH_THUOC();
                        v_us_gd_dv_tinh_thuoc.UseTransOfUSObject(m_us_don_vi_tinh);
                        load_data_2_gd_dv_tinh_thuoc(v_us_gd_dv_tinh_thuoc);
                        US_GD_GIAO_DICH v_us_gd_giao_dich = new US_GD_GIAO_DICH();
                        v_us_gd_giao_dich.UseTransOfUSObject(m_us_don_vi_tinh);
                        load_data_2_gd_giao_dich(v_us_gd_giao_dich);
                        //load_cbo_dv();
                        US_GD_GIAO_DICH_DETAIL v_us_gd_detail = new US_GD_GIAO_DICH_DETAIL();
                        v_us_gd_detail.UseTransOfUSObject(m_us_don_vi_tinh);
                        load_data_2_gd_detial(v_us_gd_detail);
                        US_GD_GIA_BAN v_us_gd_gia_ban = new US_GD_GIA_BAN();
                        v_us_gd_gia_ban.UseTransOfUSObject(m_us_don_vi_tinh);
                        load_data_2_gd_gia_ban(v_us_gd_gia_ban);
                        US_GD_SO_DU v_us_gd_so_du = new US_GD_SO_DU();
                        v_us_gd_so_du.UseTransOfUSObject(m_us_don_vi_tinh);
                        load_data_2_gd_so_du(v_us_gd_so_du);
                        m_us_don_vi_tinh.CommitTransaction();
                        restart_form();
                        list.Clear();
                        m_lbl_tong_tien.Text = "";
                        tong_tien = 0;
                        m_grv_nhap_thuoc.Rows.Clear();
                        m_lbl_ma_giao_dich.Text = gen_Ma_GD();
                        BaseMessages.MsgBox_Infor("Bạn đã cập nhật thành công");
                    }
                    //DialogResult dgl = MessageBox.Show("Ban muon in hoa don khong", "In hoa don", MessageBoxButtons.YesNo);
                    //if (dgl == DialogResult.Yes) {
                    //    f513_report_nhap_thuoc frm = new f513_report_nhap_thuoc();
                    //    frm.display_form_print_nhap_thuoc(m_id_giao_dich);
                    //}
                }
                else
                {
                    BaseMessages.MsgBox_Infor("Bạn cần nhấn nút thêm trước khi lưu");
                    m_cmd_add.Focus();
                }
            }
            catch (Exception v_e)
            {

                if (m_us_don_vi_tinh.is_having_transaction())
                {
                    m_us_don_vi_tinh.Rollback();
                }
                throw v_e;

            }

        }
        private void m_txt_gia_nhap_TextChanged(object sender, EventArgs e)
        {
            if (m_txt_gia_nhap.Text == "")
            {
                m_txt_gia_nhap.SelectionStart = m_txt_gia_nhap.Text.Length + 1;
            }
            else
            {
                m_txt_gia_nhap.Text = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_gia_nhap.Text.Trim()));
                m_txt_gia_nhap.SelectionStart = m_txt_gia_nhap.Text.Length + 1;
            }

        }
        private void m_txt_gia_ban_TextChanged(object sender, EventArgs e)
        {
            if (m_txt_gia_ban.Text == "")
            {
                m_txt_gia_ban.SelectionStart = m_txt_gia_ban.Text.Length + 1;
            }
            else
            {
                m_txt_gia_ban.Text = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_gia_ban.Text.Trim()));
                m_txt_gia_ban.SelectionStart = m_txt_gia_ban.Text.Length + 1;
            }
        }
        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (BaseMessages.askUser_DataCouldBeDeleted(8) != BaseMessages.IsDataCouldBeDeleted.CouldBeDeleted) return;
                list.RemoveAt(m_grv_nhap_thuoc.SelectedRows[0].Index);
                m_lbl_tong_tien.Text = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_lbl_tong_tien.Text.Replace(",", "").Replace(".", "")) - CIPConvert.ToDecimal(m_grv_nhap_thuoc.SelectedRows[0].Cells[5].Value.ToString().Replace(",", "").Replace(".", "")));
                tong_tien -= int.Parse(m_grv_nhap_thuoc.SelectedRows[0].Cells[5].Value.ToString().Replace(",", "").Replace(".", ""));
                m_grv_nhap_thuoc.Rows.RemoveAt(m_grv_nhap_thuoc.SelectedRows[0].Index);
                restart_form();
                for (int i = 0; i < m_grv_nhap_thuoc.Rows.Count; i++) m_grv_nhap_thuoc.Rows[i].Cells[0].Value = i + 1;
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
                list.Clear();
                this.Visible = false;
                this.Controls.Clear();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_txt_search_thuoc1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    load_data_2_cbo_don_vi();
                    load_quy_doi();
                    load_don_gia_ban();
                    m_dtp_han_su_dung.Value = new DateTime(m_dtp_ngay_san_xuat.Value.Year + 2, m_dtp_ngay_san_xuat.Value.Month, m_dtp_ngay_san_xuat.Value.Day);
                }

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }
        private void m_txt_add_thuoc_Click(object sender, EventArgs e)
        {
            f503_v_dm_thuoc_de frm = new f503_v_dm_thuoc_de();
            frm.ShowDialog();
            load_ten_thuoc();
        }
        private void m_dtp_ngay_san_xuat_ValueChanged(object sender, EventArgs e)
        {
            m_dtp_han_su_dung.Value = new DateTime(m_dtp_ngay_san_xuat.Value.Year + 2, m_dtp_ngay_san_xuat.Value.Month, m_dtp_ngay_san_xuat.Value.Day);
        }
        private void m_txt_so_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (char)8)
                {
                    BaseMessages.MsgBox_Infor("Bạn đã nhập chữ '" + e.KeyChar + "'..Xin vui lòng chỉ nhập số");
                    e.KeyChar = (char)0;
                }
            }
        }
        private void m_txt_gia_nhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar != (char)8)
                {
                    BaseMessages.MsgBox_Infor("Bạn đã nhập chữ '" + e.KeyChar + "'...Xin vui lòng chỉ nhập số");
                    e.KeyChar = (char)0;
                }
            }
        }
        private void m_grv_nhap_thuoc_DoubleClick(object sender, EventArgs e)
        {
            m_cmd_add.Visible = false;
            m_cmd_upadate.Visible = true;
            m_grv_s_i = m_grv_nhap_thuoc.SelectedRows[0].Index;
            m_txt_search_thuoc1.dcID = list[m_grv_s_i].ID_thuoc;
            m_txt_search_thuoc1.Text1 = list[m_grv_s_i].ten_thuoc;
            m_txt_search_thuoc1.get_text(list[m_grv_s_i].ten_thuoc);
            m_txt_search_thuoc1.Enabled = false;
            //m_txt_search_thuoc1.Visible = false;
            load_data_2_cbo_don_vi();
            load_quy_doi();
            load_don_gia_ban();
            m_cbo_dv_cap_2.Enabled = false;
            m_cbo_dv_cap_3.Enabled = false;
            m_cbo_dv_cap_4.Enabled = false;
            m_cbo_don_vi_tinh.Text = list[m_grv_s_i].ten_don_vi_tinh_thuoc;
            m_cbo_dv_cap_2.Text = list[m_grv_s_i].don_vi_cap_2;
            m_cbo_dv_cap_3.Text = list[m_grv_s_i].don_vi_cap_3;
            m_cbo_dv_cap_4.Text = list[m_grv_s_i].don_vi_cap_4;
            m_txt_quy_doi_1.Text = list[m_grv_s_i].quy_doi_1;
            m_txt_quy_doi_2.Text = list[m_grv_s_i].quy_doi_2;
            m_txt_quy_doi_3.Text = list[m_grv_s_i].quy_doi_3;
            m_txt_so_luong.Text = list[m_grv_s_i].so_luong.ToString();
            m_dtp_ngay_san_xuat.Value = list[m_grv_s_i].ngay_sx;
            m_dtp_han_su_dung.Value = list[m_grv_s_i].han_sd;
            tong_tien -= (int.Parse(list[m_grv_s_i].so_luong.ToString()) * int.Parse(list[m_grv_s_i].gia.ToString()));
            //m_cbo_don_vi_tinh.ValueMember = list[m_grv_s_i].id_don_vi_thuoc_nhap.ToString();
            //m_cbo_dv_cap_2.Text = list[m_grv_s_i].don_vi_cap_2;
            //m_cbo_dv_cap_3.Text = list[m_grv_s_i].don_vi_cap_3;
            //m_cbo_dv_cap_3.Text = list[m_grv_s_i].don_vi_cap_3;
            //m_txt_quy_doi_1.Text = list[m_grv_s_i].quy_doi_1;
            //m_txt_quy_doi_2.Text = list[m_grv_s_i].quy_doi_2;
            //m_txt_quy_doi_3.Text = list[m_grv_s_i].quy_doi_3;
            m_txt_gia_nhap.Text = list[m_grv_s_i].gia.ToString();
            m_txt_gia_ban.Text = list[m_grv_s_i].gia_ban.ToString();
            m_cbo_nha_cung_cap.SelectedValue = list[m_grv_s_i].id_nha_cc;
            m_cbo_nuoc_san_xuat.SelectedValue = list[m_grv_s_i].id_nuoc_sx;
            m_cbo_hang_san_xuat.SelectedValue = list[m_grv_s_i].id_hang_sx;
            m_txt_gia_nhap.Text = m_grv_nhap_thuoc.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void m_cmd_upadate_Click(object sender, EventArgs e)
        {
            tong_tien += int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_gia_nhap.Text.Trim().Replace(",", "").Replace(".", ""));
            m_grv_nhap_thuoc.Rows[m_grv_s_i].Cells[2].Value = m_txt_so_luong.Text;
            m_grv_nhap_thuoc.Rows[m_grv_s_i].Cells[5].Value = string.Format("{0:#,###}", CIPConvert.ToDecimal(int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_gia_nhap.Text.Trim().Replace(",", "").Replace(".", ""))));
            m_lbl_tong_tien.Text = string.Format("{0:#,###}", CIPConvert.ToDecimal(tong_tien));
            list[m_grv_s_i].so_luong = int.Parse(m_txt_so_luong.Text);
            list[m_grv_s_i].gia = int.Parse(m_txt_gia_nhap.Text.Replace(",", "").Replace(".", ""));
            list[m_grv_s_i].gia_ban = int.Parse(m_txt_gia_ban.Text.Replace(",", "").Replace(".", ""));
            list[m_grv_s_i].sd_so_luong = int.Parse(m_txt_so_luong.Text) * int.Parse(m_txt_quy_doi_1.Text) * int.Parse(m_txt_quy_doi_2.Text) * int.Parse(m_txt_quy_doi_3.Text);
            m_grv_nhap_thuoc.Rows[m_grv_s_i].Cells[4].Value = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_gia_nhap.Text.Trim().Replace(",", "").Replace(".", "")));
            m_cmd_add.Visible = true;
            m_cmd_upadate.Visible = false;
            //m_txt_search_thuoc1.Visible = true;
            m_txt_search_thuoc1.Enabled = true;
            BaseMessages.MsgBox_Infor("Bạn đã cập nhật thành công");
            restart_form();
        }
        #endregion
    }
}
