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
using System.Collections.Generic;

namespace BKI_QLHT
{
    public partial class f511_gd_nhap_thuoc : Form
    {
        public f511_gd_nhap_thuoc()
        {
            InitializeComponent();
            format_control();

        }


        #region Public Interface
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
        }
        #endregion

        #region Member
        long tong_tien = 0;
        List<data> list = new List<data>();
        #endregion

        #region Private Method
        private void format_control()
        {
            CControlFormat.setFormStyle(this, new CAppContext_201());
            set_define_event();
            m_grv_nhap_thuoc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            m_grv_nhap_thuoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            m_grv_nhap_thuoc.RowsDefaultCellStyle.BackColor = Color.Bisque;
            m_grv_nhap_thuoc.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            m_grv_nhap_thuoc.CellBorderStyle = DataGridViewCellBorderStyle.None;
            m_grv_nhap_thuoc.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            m_grv_nhap_thuoc.DefaultCellStyle.SelectionForeColor = Color.White;
            m_grv_nhap_thuoc.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            m_grv_nhap_thuoc.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            m_grv_nhap_thuoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //m_grv_nhap_thuoc.AllowUserToResizeColumns = false;
            m_lbl_ma_giao_dich.Text = gen_Ma_GD();
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
        }
        public void set_inital_form_load()
        {
            load_ten_thuoc();
            load_data_2_cbo_don_vi_tinh();
            load_data_2_dv_cap_2();
            load_data_2_dv_cap_3();
            load_data_2_dv_cap_4();
            //load_data_to_text_box_search();
            load_data_2_cbo_nha_cung_cap();
            load_data_2_cbo_nuoc_sx();
            load_data_2_cbo_hang_sx();
            load_data_2_label();
        }

        private void load_data_2_cbo_don_vi_tinh()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.FillDataset(v_ds_tu_dien, "where id_loai_tu_dien=8");
            m_cbo_don_vi_tinh.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_don_vi_tinh.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_don_vi_tinh.DisplayMember = CM_DM_TU_DIEN.TEN;
        }
        private void load_data_2_dv_cap_2()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.FillDataset(v_ds_tu_dien, "where id_loai_tu_dien=8");
            m_cbo_dv_cap_2.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_dv_cap_2.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_dv_cap_2.DisplayMember = CM_DM_TU_DIEN.TEN;

        }
        private void load_data_2_dv_cap_4()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.FillDataset(v_ds_tu_dien, "where id_loai_tu_dien=8");
            m_cbo_dv_cap_4.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_dv_cap_4.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_dv_cap_4.DisplayMember = CM_DM_TU_DIEN.TEN;

        }
        private void load_data_2_dv_cap_3()
        {
            US_CM_DM_TU_DIEN v_us_tu_dien = new US_CM_DM_TU_DIEN();
            DS_CM_DM_TU_DIEN v_ds_tu_dien = new DS_CM_DM_TU_DIEN();
            v_us_tu_dien.FillDataset(v_ds_tu_dien, "where id_loai_tu_dien=8");
            m_cbo_dv_cap_3.DataSource = v_ds_tu_dien.CM_DM_TU_DIEN;
            m_cbo_dv_cap_3.ValueMember = CM_DM_TU_DIEN.ID;
            m_cbo_dv_cap_3.DisplayMember = CM_DM_TU_DIEN.TEN;

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
            v_us.FillDataset(v_ds, "where id_loai_dm=2");
            m_cbo_nuoc_san_xuat.DataSource = v_ds.DM_NCC_NSX_NHASX;
            m_cbo_nuoc_san_xuat.ValueMember = DM_NCC_NSX_NHASX.ID;
            m_cbo_nuoc_san_xuat.DisplayMember = DM_NCC_NSX_NHASX.TEN_NCC;
        }
        private void load_data_2_label()
        {
            m_lbl_dv_tinh_nhap.Text = "1" + " " + m_cbo_don_vi_tinh.Text;
            m_lbl_dv_tinh_ban.Text = "1" + " " + m_cbo_don_vi_tinh.Text;
            m_lbl_don_vi_cap_2.Text = "1" + " " + m_cbo_dv_cap_2.Text;
            m_lbl_don_vi_cap_3.Text = "1" + " " + m_cbo_dv_cap_4.Text;

        }
        private void restart_form()
        {
            m_txt_gia_nhap.Clear();
            m_txt_gia_ban.Clear();
            m_txt_so_luong.Clear();
            m_txt_quy_doi_1.Clear();
            m_txt_quy_doi_2.Clear();
            m_txt_quy_doi_3.Clear();
            load_data_2_label();
        }
        private void restart_quy_doi() {
            load_data_2_dv_cap_2();
            load_data_2_dv_cap_3();
            load_data_2_dv_cap_4();
            m_txt_quy_doi_1.Text = "1";
            m_txt_quy_doi_2.Text = "1";
            m_txt_quy_doi_3.Text = "1";
            
        }
        private void add_list()
        {
            data v_data = new data();
            //string gia_nha_convert = m_txt_gia_nhap.Text.Remove(m_txt_gia_nhap.Text.IndexOf(','));
            v_data.ten_thuoc = m_txt_search_thuoc1.Text1;
            v_data.ngay_nhap = m_dtp_ngay_nhap.Value;
            v_data.ngay_sx = m_dtp_ngay_san_xuat.Value;
            v_data.han_sd = m_dtp_han_su_dung.Value;
            v_data.nha_cung_cap = m_cbo_nha_cung_cap.Text;
            v_data.hang_sx = m_cbo_hang_san_xuat.Text;
            v_data.nuoc_sx = m_cbo_nuoc_san_xuat.Text;
            v_data.ID_thuoc = m_txt_search_thuoc1.dcID;
            v_data.so_luong = int.Parse(m_txt_so_luong.Text) * int.Parse(m_txt_quy_doi_1.Text) * int.Parse(m_txt_quy_doi_2.Text) * int.Parse(m_txt_quy_doi_3.Text);
            v_data.gia = int.Parse(m_txt_gia_nhap.Text.Trim().Replace(",", "").Replace(".", ""));
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
            list.Add(v_data);
        }
        private void load_data_2_gd_so_du()
        {
            US_GD_SO_DU v_us_sd = new US_GD_SO_DU();
            DS_GD_SO_DU v_ds_sd = new DS_GD_SO_DU();


            foreach (data v_list in list)
            {
                v_ds_sd.Clear();
                v_us_sd.FillDataset(v_ds_sd, "where id_thuoc='" + v_list.ID_thuoc + "' and moi_nhat_yn='Y'");
                if (v_ds_sd.GD_SO_DU.Count == 0)
                {
                    v_us_sd.dcID_THUOC = CIPConvert.ToDecimal(v_list.ID_thuoc);
                    v_us_sd.dcID_DON_VI_THUOC = CIPConvert.ToDecimal(v_list.ID_don_vi_thuoc);
                    v_us_sd.dcSO_DU = CIPConvert.ToDecimal(v_list.so_luong);
                    v_us_sd.datNGAY_PHAT_SINH = v_list.ngay_nhap;
                    v_us_sd.strMOI_NHAT_YN = "Y";
                    v_us_sd.Insert();
                }
                else
                {
                    DateTime v_dat_nps = (DateTime)(v_ds_sd.Tables[0].Rows[0]["NGAY_PHAT_SINH"]);
                    if (v_dat_nps.Date != DateTime.Now.Date)
                    {
                        v_us_sd.dcID = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID"]);
                        v_us_sd.dcID_THUOC = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID_THUOC"]);
                        v_us_sd.dcSO_DU = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["SO_DU"]);
                        v_us_sd.dcID_DON_VI_THUOC = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID_DON_VI_THUOC"]);
                        //v_us_sd.datNGAY_PHAT_SINH = CIPConvert.ToDatetime( v_ds_sd.Tables[0].Rows[0]["NGAY_PHAT_SINH"].ToString(),"dd/MM/yyyy");
                        v_us_sd.datNGAY_PHAT_SINH = DateTime.Now;
                        v_us_sd.strMOI_NHAT_YN = v_ds_sd.Tables[0].Rows[0]["MOI_NHAT_YN"].ToString();
                        v_us_sd.strMOI_NHAT_YN = "N";
                        v_us_sd.Update();
                        v_us_sd.dcID_THUOC = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID_THUOC"]);
                        v_us_sd.dcID_DON_VI_THUOC = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID_DON_VI_THUOC"]);
                        v_us_sd.strMOI_NHAT_YN = "Y";
                        v_us_sd.dcSO_DU = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["SO_DU"]) + v_list.so_luong;
                        v_us_sd.Insert();
                    }
                    else
                    {
                        v_us_sd.dcID = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID"]);
                        v_us_sd.dcID_THUOC = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID_THUOC"]);
                        v_us_sd.dcSO_DU = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["SO_DU"]) + v_list.so_luong;
                        v_us_sd.dcID_DON_VI_THUOC = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID_DON_VI_THUOC"]);
                        //v_us_sd.datNGAY_PHAT_SINH = CIPConvert.ToDatetime( v_ds_sd.Tables[0].Rows[0]["NGAY_PHAT_SINH"].ToString(),"dd/MM/yyyy");
                        v_us_sd.datNGAY_PHAT_SINH = DateTime.Now;
                        v_us_sd.strMOI_NHAT_YN = v_ds_sd.Tables[0].Rows[0]["MOI_NHAT_YN"].ToString();
                        v_us_sd.Update();
                    }
                }
            }
        }
        private void load_data_2_don_vi_tinh()
        {
            US_DM_DON_VI_TINH m_us_dm_dv_tinh = new US_DM_DON_VI_TINH();
            DS_DM_DON_VI_TINH m_ds_dm_dv_tinh = new DS_DM_DON_VI_TINH();
            foreach (data v_list in list)
            {
                m_us_dm_dv_tinh.FillDataset(m_ds_dm_dv_tinh, "where id_thuoc=" + v_list.ID_thuoc);
                if (m_ds_dm_dv_tinh.DM_DON_VI_TINH.Count == 0)
                {
                    m_us_dm_dv_tinh.dcID_THUOC = v_list.ID_thuoc;
                    m_us_dm_dv_tinh.strMA_NHOM = v_list.ID_thuoc.ToString() + v_list.ten_thuoc;
                    m_us_dm_dv_tinh.datNGAY_LAP = v_list.ngay_nhap;
                    m_us_dm_dv_tinh.dcID_TRANG_THAI = 12;
                    m_us_dm_dv_tinh.Insert();
                    v_list.ID_nhom_dv_tinh = m_us_dm_dv_tinh.dcID;
                }
                else
                {
                    v_list.ID_nhom_dv_tinh = CIPConvert.ToDecimal(m_ds_dm_dv_tinh.Tables[0].Rows[0]["ID"]);
                }

            }
        }
        private void load_data_2_gd_dv_tinh_thuoc()
        {
            US_GD_DON_VI_TINH_THUOC v_us_gd_dv_tinh_thuoc = new US_GD_DON_VI_TINH_THUOC();
            DS_GD_DON_VI_TINH_THUOC v_ds_gd_dv_tinh_thuoc = new DS_GD_DON_VI_TINH_THUOC();
            foreach (data v_list in list)
            {

                v_us_gd_dv_tinh_thuoc.FillDataset(v_ds_gd_dv_tinh_thuoc, "where id_nhom_don_vi_tinh=" + v_list.ID_nhom_dv_tinh);
                if (v_ds_gd_dv_tinh_thuoc.GD_DON_VI_TINH_THUOC.Count == 0)
                {
                    v_us_gd_dv_tinh_thuoc.strTEN_DON_VI = "Thùng";
                    v_us_gd_dv_tinh_thuoc.dcID_NHOM_DON_VI_TINH = v_list.ID_nhom_dv_tinh;
                    v_us_gd_dv_tinh_thuoc.Insert();
                    decimal id_dv_cha = v_us_gd_dv_tinh_thuoc.dcID;
                    v_us_gd_dv_tinh_thuoc.strTEN_DON_VI = v_list.don_vi_cap_2;
                    v_us_gd_dv_tinh_thuoc.dcID_NHOM_DON_VI_TINH = v_list.ID_nhom_dv_tinh;
                    v_us_gd_dv_tinh_thuoc.dcID_DON_VI_CHA = id_dv_cha;
                    v_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_list.quy_doi_1);
                    v_us_gd_dv_tinh_thuoc.Insert();
                    v_list.ID_don_vi_thuoc = v_us_gd_dv_tinh_thuoc.dcID;
                    decimal id_dv_cha_2 = v_us_gd_dv_tinh_thuoc.dcID;
                    if (v_list.don_vi_cap_3 != v_list.don_vi_cap_2)
                    {
                        v_us_gd_dv_tinh_thuoc.strTEN_DON_VI = v_list.don_vi_cap_3;
                        v_us_gd_dv_tinh_thuoc.dcID_NHOM_DON_VI_TINH = v_list.ID_nhom_dv_tinh;
                        v_us_gd_dv_tinh_thuoc.dcID_DON_VI_CHA = id_dv_cha_2;
                        v_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_list.quy_doi_2);
                        v_us_gd_dv_tinh_thuoc.Insert();
                        v_list.ID_don_vi_thuoc = v_us_gd_dv_tinh_thuoc.dcID;

                    }
                    decimal id_dv_cha_3 = v_us_gd_dv_tinh_thuoc.dcID;
                    if (v_list.don_vi_cap_4 != v_list.don_vi_cap_3)
                    {
                        v_us_gd_dv_tinh_thuoc.strTEN_DON_VI = v_list.don_vi_cap_4;
                        v_us_gd_dv_tinh_thuoc.dcID_NHOM_DON_VI_TINH = v_list.ID_nhom_dv_tinh;
                        v_us_gd_dv_tinh_thuoc.dcID_DON_VI_CHA = id_dv_cha_3;
                        v_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_list.quy_doi_3);
                        v_us_gd_dv_tinh_thuoc.Insert();
                        v_list.ID_don_vi_thuoc = v_us_gd_dv_tinh_thuoc.dcID;

                    }
                }
                else
                {
                    v_ds_gd_dv_tinh_thuoc.Clear();
                    v_us_gd_dv_tinh_thuoc.FillDataset(v_ds_gd_dv_tinh_thuoc, "where  id_nhom_don_vi_tinh='" + v_list.ID_nhom_dv_tinh + "' and ten_don_vi like N'%" + v_list.don_vi_cap_2 + "%'");
                    v_us_gd_dv_tinh_thuoc.dcID = CIPConvert.ToDecimal(v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0]["ID"]);
                    v_us_gd_dv_tinh_thuoc.strTEN_DON_VI = v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0]["TEN_DON_VI"].ToString();
                    v_us_gd_dv_tinh_thuoc.dcID_DON_VI_CHA = CIPConvert.ToDecimal(v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0]["ID_DON_VI_CHA"]);
                    v_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0]["QUY_DOI"]);
                    v_us_gd_dv_tinh_thuoc.dcID_NHOM_DON_VI_TINH = CIPConvert.ToDecimal(v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0]["ID_NHOM_DON_VI_TINH"]);
                    if (v_us_gd_dv_tinh_thuoc.dcQUY_DOI != CIPConvert.ToDecimal(v_list.quy_doi_1)) v_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_list.quy_doi_1);
                    v_us_gd_dv_tinh_thuoc.Update();
                    v_list.ID_don_vi_thuoc = v_us_gd_dv_tinh_thuoc.dcID;

                    v_ds_gd_dv_tinh_thuoc.Clear();
                    v_us_gd_dv_tinh_thuoc.FillDataset(v_ds_gd_dv_tinh_thuoc, "where id_nhom_don_vi_tinh='" + v_list.ID_nhom_dv_tinh + "' and ten_don_vi like N'%" + v_list.don_vi_cap_3 + "%'");
                    if (v_ds_gd_dv_tinh_thuoc.GD_DON_VI_TINH_THUOC.Count != 0)
                    {

                        v_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0]["QUY_DOI"]);
                        v_us_gd_dv_tinh_thuoc.dcID = CIPConvert.ToDecimal(v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0]["ID"]);
                        v_us_gd_dv_tinh_thuoc.dcID_DON_VI_CHA = CIPConvert.ToDecimal(v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0]["ID_DON_VI_CHA"]);
                        v_us_gd_dv_tinh_thuoc.dcID_NHOM_DON_VI_TINH = CIPConvert.ToDecimal(v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0]["ID_NHOM_DON_VI_TINH"]);
                        v_us_gd_dv_tinh_thuoc.strTEN_DON_VI = v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0]["TEN_DON_VI"].ToString();
                        if (v_us_gd_dv_tinh_thuoc.dcQUY_DOI != CIPConvert.ToDecimal(v_list.quy_doi_2)) v_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_list.quy_doi_2);
                        v_us_gd_dv_tinh_thuoc.Update();
                        v_list.ID_don_vi_thuoc = v_us_gd_dv_tinh_thuoc.dcID;
                    }
                    v_ds_gd_dv_tinh_thuoc.Clear();
                    v_us_gd_dv_tinh_thuoc.FillDataset(v_ds_gd_dv_tinh_thuoc, "where id_nhom_don_vi_tinh='" + v_list.ID_nhom_dv_tinh + "' and ten_don_vi like N'%" + v_list.don_vi_cap_4 + "%'");
                    if (v_ds_gd_dv_tinh_thuoc.GD_DON_VI_TINH_THUOC.Count != 0)
                    {
                        v_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0]["QUY_DOI"]);
                        v_us_gd_dv_tinh_thuoc.dcID = CIPConvert.ToDecimal(v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0]["ID"]);
                        v_us_gd_dv_tinh_thuoc.dcID_DON_VI_CHA = CIPConvert.ToDecimal(v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0]["ID_DON_VI_CHA"]);
                        v_us_gd_dv_tinh_thuoc.dcID_NHOM_DON_VI_TINH = CIPConvert.ToDecimal(v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0]["ID_NHOM_DON_VI_TINH"]);
                        v_us_gd_dv_tinh_thuoc.strTEN_DON_VI = v_ds_gd_dv_tinh_thuoc.Tables[0].Rows[0]["TEN_DON_VI"].ToString();
                        if (v_us_gd_dv_tinh_thuoc.dcQUY_DOI != CIPConvert.ToDecimal(v_list.quy_doi_3)) v_us_gd_dv_tinh_thuoc.dcQUY_DOI = CIPConvert.ToDecimal(v_list.quy_doi_3);
                        v_us_gd_dv_tinh_thuoc.Update();
                        v_list.ID_don_vi_thuoc = v_us_gd_dv_tinh_thuoc.dcID;
                    }

                }

            }
        }
        private void load_data_2_gd_detial()
        {
            US_GD_GIAO_DICH_DETAIL v_us_gd_detail = new US_GD_GIAO_DICH_DETAIL();
            DS_GD_GIAO_DICH_DETAIL v_ds_gd_detail = new DS_GD_GIAO_DICH_DETAIL();
            foreach (data v_list in list)
            {
                v_us_gd_detail.dcID_GIAO_DICH = v_list.id_giao_dich;
                v_us_gd_detail.dcID_THUOC = CIPConvert.ToDecimal(v_list.ID_thuoc);
                v_us_gd_detail.dcID_DON_VI_THUOC = CIPConvert.ToDecimal(v_list.ID_don_vi_thuoc);
                v_us_gd_detail.dcSO_LUONG = CIPConvert.ToDecimal(v_list.so_luong);
                v_us_gd_detail.dcID_NUOC_SX = CIPConvert.ToDecimal(v_list.id_nuoc_sx);
                v_us_gd_detail.dcID_NHA_CUNG_CAP = CIPConvert.ToDecimal(v_list.id_nha_cc);
                v_us_gd_detail.dcID_HANG_SX = CIPConvert.ToDecimal(v_list.id_hang_sx);
                v_us_gd_detail.datHAN_SU_DUNG = v_list.han_sd;
                v_us_gd_detail.dcGIA = CIPConvert.ToDecimal(v_list.gia);
                v_us_gd_detail.Insert();
            }
        }
        private void load_data_2_gd_giao_dich()
        {
            US_GD_GIAO_DICH v_us_gd = new US_GD_GIAO_DICH();
            DS_GD_GIAO_DICH v_ds_gd = new DS_GD_GIAO_DICH();
            foreach (data v_list in list)
            {
                v_us_gd.dcID_LOAI_GIAO_DICH = 1;
                v_us_gd.dcID_BAC_SY = 10;
                v_us_gd.dcID_KHACH_HANG = 1;
                v_us_gd.strMA_GIAO_DICH = v_list.ma_giao_dich;
                v_us_gd.datNGAY_GIAO_DICH = v_list.ngay_nhap;
                v_us_gd.dcID_NGUOI_THUC_HIEN = 2;
                v_us_gd.Insert();
                v_list.id_giao_dich = v_us_gd.dcID;
            }

        }
        private void load_cbo_don_vi_tinh()
        {
            US_V_GD_DON_VI_TINH_THUOC v_us_v_gd_don_vi_tinh_thuoc = new US_V_GD_DON_VI_TINH_THUOC();
            DS_V_GD_DON_VI_TINH_THUOC v_ds_v_gd_don_vi_tinh_thuoc = new DS_V_GD_DON_VI_TINH_THUOC();
            decimal v_id_thuoc = m_txt_search_thuoc1.dcID;
            v_us_v_gd_don_vi_tinh_thuoc.FillDataset(v_ds_v_gd_don_vi_tinh_thuoc, "where ID_THUOC = " + v_id_thuoc);
            if (v_ds_v_gd_don_vi_tinh_thuoc.V_GD_DON_VI_TINH_THUOC.Count != 0)
            {
                m_cbo_don_vi_tinh.DataSource = v_ds_v_gd_don_vi_tinh_thuoc.V_GD_DON_VI_TINH_THUOC;
                m_cbo_don_vi_tinh.ValueMember = V_GD_DON_VI_TINH_THUOC.ID_DON_VI_TINH;
                m_cbo_don_vi_tinh.DisplayMember = V_GD_GIAO_DICH_DETAIL.TEN_DON_VI;
                

            }
            else
            {
                load_data_2_cbo_don_vi_tinh();
            }
        }
        private void load_cbo_dv_cap_2()
        {
            US_V_GD_DON_VI_TINH_THUOC v_us_v_gd_don_vi_tinh_thuoc = new US_V_GD_DON_VI_TINH_THUOC();
            DS_V_GD_DON_VI_TINH_THUOC v_ds_v_gd_don_vi_tinh_thuoc = new DS_V_GD_DON_VI_TINH_THUOC();
            decimal v_id_thuoc = m_txt_search_thuoc1.dcID;
            v_us_v_gd_don_vi_tinh_thuoc.FillDataset(v_ds_v_gd_don_vi_tinh_thuoc, "where ID_THUOC = " + v_id_thuoc);
            if (v_ds_v_gd_don_vi_tinh_thuoc.V_GD_DON_VI_TINH_THUOC.Count != 0)
            {

                m_cbo_dv_cap_2.DataSource = v_ds_v_gd_don_vi_tinh_thuoc.V_GD_DON_VI_TINH_THUOC;
                m_cbo_dv_cap_2.ValueMember = V_GD_DON_VI_TINH_THUOC.ID_DON_VI_TINH;
                m_cbo_dv_cap_2.DisplayMember = V_GD_GIAO_DICH_DETAIL.TEN_DON_VI;

            }
            else
            {
                load_data_2_dv_cap_2();
            }
        }
        private void load_cbo_dv_cap_3()
        {
            US_V_GD_DON_VI_TINH_THUOC v_us_v_gd_don_vi_tinh_thuoc = new US_V_GD_DON_VI_TINH_THUOC();
            DS_V_GD_DON_VI_TINH_THUOC v_ds_v_gd_don_vi_tinh_thuoc = new DS_V_GD_DON_VI_TINH_THUOC();
            decimal v_id_thuoc = m_txt_search_thuoc1.dcID;
            v_us_v_gd_don_vi_tinh_thuoc.FillDataset(v_ds_v_gd_don_vi_tinh_thuoc, "where ID_THUOC = " + v_id_thuoc);
            if (v_ds_v_gd_don_vi_tinh_thuoc.V_GD_DON_VI_TINH_THUOC.Count != 0)
            {

                m_cbo_dv_cap_2.DataSource = v_ds_v_gd_don_vi_tinh_thuoc.V_GD_DON_VI_TINH_THUOC;
                m_cbo_dv_cap_2.ValueMember = V_GD_DON_VI_TINH_THUOC.ID_DON_VI_TINH;
                m_cbo_dv_cap_2.DisplayMember = V_GD_GIAO_DICH_DETAIL.TEN_DON_VI;

            }
            else
            {
                load_data_2_dv_cap_3();
            }
        }
        private void load_cbo_dv_cap_4()
        {
            US_V_GD_DON_VI_TINH_THUOC v_us_v_gd_don_vi_tinh_thuoc = new US_V_GD_DON_VI_TINH_THUOC();
            DS_V_GD_DON_VI_TINH_THUOC v_ds_v_gd_don_vi_tinh_thuoc = new DS_V_GD_DON_VI_TINH_THUOC();
            decimal v_id_thuoc = m_txt_search_thuoc1.dcID;
            v_us_v_gd_don_vi_tinh_thuoc.FillDataset(v_ds_v_gd_don_vi_tinh_thuoc, "where ID_THUOC = " + v_id_thuoc);
            if (v_ds_v_gd_don_vi_tinh_thuoc.V_GD_DON_VI_TINH_THUOC.Count != 0)
            {

                m_cbo_dv_cap_2.DataSource = v_ds_v_gd_don_vi_tinh_thuoc.V_GD_DON_VI_TINH_THUOC;
                m_cbo_dv_cap_2.ValueMember = V_GD_DON_VI_TINH_THUOC.ID_DON_VI_TINH;
                m_cbo_dv_cap_2.DisplayMember = V_GD_GIAO_DICH_DETAIL.TEN_DON_VI;

            }
            else
            {
                load_data_2_dv_cap_4();
            }
        }

        private void load_don_gia_ban()
        {
            US_V_GD_DON_VI_TINH_THUOC v_us_v_gd_don_vi_tinh_thuoc = new US_V_GD_DON_VI_TINH_THUOC();
            DS_V_GD_DON_VI_TINH_THUOC v_ds_v_gd_don_vi_tinh_thuoc = new DS_V_GD_DON_VI_TINH_THUOC();
            decimal don_gia;
            decimal v_id_don_vi_tinh_thuoc = CIPConvert.ToDecimal(m_cbo_don_vi_tinh.SelectedValue);
            v_us_v_gd_don_vi_tinh_thuoc.FillDataset(v_ds_v_gd_don_vi_tinh_thuoc, "where ID = " + v_id_don_vi_tinh_thuoc);
            if (v_ds_v_gd_don_vi_tinh_thuoc.V_GD_DON_VI_TINH_THUOC.Count != 0)
            {
                DataRow v_dr = v_ds_v_gd_don_vi_tinh_thuoc.Tables[0].Rows[0];
                don_gia = CIPConvert.ToDecimal(v_dr[V_GD_DON_VI_TINH_THUOC.GIA_BAN]);
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
                    m_cbo_dv_cap_2.Text = v_ds_gd_don_vi_tinh_thuoc.Tables[0].Rows[1]["TEN_DON_VI"].ToString();
                    m_txt_quy_doi_1.Text = v_ds_gd_don_vi_tinh_thuoc.Tables[0].Rows[1]["QUY_DOI"].ToString();
                }
                if (count > 2)
                {
                    m_cbo_dv_cap_3.Text = v_ds_gd_don_vi_tinh_thuoc.Tables[0].Rows[2]["TEN_DON_VI"].ToString();
                    m_txt_quy_doi_2.Text = v_ds_gd_don_vi_tinh_thuoc.Tables[0].Rows[2]["QUY_DOI"].ToString();
                }
                else
                {
                    m_cbo_dv_cap_3.Text = m_cbo_dv_cap_2.Text;
                    m_txt_quy_doi_2.Text = "1";
                }
                if (count == 4)
                {
                    m_cbo_dv_cap_4.Text = v_ds_gd_don_vi_tinh_thuoc.Tables[0].Rows[3]["TEN_DON_VI"].ToString();
                    m_txt_quy_doi_3.Text = v_ds_gd_don_vi_tinh_thuoc.Tables[0].Rows[3]["QUY_DOI"].ToString();
                }
                else
                {
                    m_cbo_dv_cap_4.Text = m_cbo_dv_cap_3.Text;
                    m_txt_quy_doi_3.Text = "1";
                }


            }
            else
            {
                restart_quy_doi();
            }
        }

        //private void load_data_to_text_box_search()
        //{
        //    US_DM_THUOC v_us = new US_DM_THUOC();
        //    DS_DM_THUOC v_ds = new DS_DM_THUOC();
        //    v_us.FillDataset(v_ds);
        //    m_txts_ten_thuoc.load_data_to_list(v_ds, DM_THUOC.TEN_THUOC, DM_THUOC.ID);

        //}

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

            add_list();
            int n = m_grv_nhap_thuoc.Rows.Add();
            //string v_gia_nhap = m_txt_gia_nhap.Text.Remove(m_txt_gia_nhap.Text.IndexOf(','));
            m_grv_nhap_thuoc.Rows[n].Cells[0].Value = n + 1;
            m_grv_nhap_thuoc.Rows[n].Cells[1].Value = m_txt_search_thuoc1.Text1;
            m_grv_nhap_thuoc.Rows[n].Cells[2].Value = m_txt_so_luong.Text;
            m_grv_nhap_thuoc.Rows[n].Cells[3].Value = m_cbo_don_vi_tinh.Text;
            m_grv_nhap_thuoc.Rows[n].Cells[4].Value = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_gia_nhap.Text.Trim().Replace(",", ""))) + " " + "VNĐ";
            m_grv_nhap_thuoc.Rows[n].Cells[5].Value = string.Format("{0:#,###}", CIPConvert.ToDecimal(int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_gia_nhap.Text.Trim().Replace(",", "")))) + " " + "VNĐ";
            tong_tien += int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_gia_nhap.Text.Trim().Replace(",", ""));
            m_lbl_tong_tien.Text = string.Format("{0:#,###}", CIPConvert.ToDecimal(tong_tien)) + " " + "VNĐ";
            restart_form();

        }
        private void m_cmd_save_Click(object sender, EventArgs e)
        {
            try
            {
                load_data_2_don_vi_tinh();
                load_data_2_gd_dv_tinh_thuoc();
                load_data_2_gd_giao_dich();
                load_data_2_gd_detial();
                load_data_2_gd_so_du();
                list.Clear();
                m_grv_nhap_thuoc.Rows.Clear();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
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
        private void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                restart_form();
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
                this.Close();
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
                    load_cbo_don_vi_tinh();
                    load_don_gia_ban();
                    load_quy_doi();

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        #endregion




    }
}
