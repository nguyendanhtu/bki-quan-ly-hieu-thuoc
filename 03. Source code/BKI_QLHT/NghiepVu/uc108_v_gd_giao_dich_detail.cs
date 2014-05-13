using System;
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
using IP.Core.IPSystemAdmin;

using BKI_QLHT.US;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;
using BKI_QLHT.DanhMuc;


using C1.Win.C1FlexGrid;
using System.Collections;

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
        public class data
        {
            public decimal id_giao_dich_detail;
            public decimal id_thuoc;
            public string ten_thuoc;
            public decimal id_giao_dich;
            public decimal id_don_vi_tinh_thuoc;
            public string ten_don_vi_tinh;
            public decimal id_don_vi_tinh_thuoc_min;
            public decimal so_luong_ban;
            public decimal so_luong_ban_min;
            public decimal so_luong_nhap;
            public decimal id_nha_cung_cap;
            public decimal id_nha_san_xuat;
            public decimal id_hang_san_xuat;
            public DateTime han_su_dung;
            public decimal gia_ban;
            public decimal gia_ban_min;
            public decimal gia_nhap;
            public decimal id_lo_thuoc;
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

        #region Data Structure
        private enum e_col_Number
        {
            STT = 1
                ,
            TEN_THUOC = 2
,
            DON_VI_TINH = 3
                ,
            SO_LUONG = 4
                ,
            DON_GIA = 5
                ,
            THANH_TIEN = 6
        }
        #endregion

        #region Members
        decimal tong_tien = 0;
        decimal tong_tien_thanh_toan = 0;
        decimal m_ti_le_chiet_khau = 0;
        decimal m_id_giao_dich;
        int m_i_fg;
        US_GD_GIAO_DICH_DETAIL m_us_giao_dich_detail = new US_GD_GIAO_DICH_DETAIL();
        DS_GD_GIAO_DICH_DETAIL m_ds_giao_dich_detail = new DS_GD_GIAO_DICH_DETAIL();
        bool trang_thai = false;
        bool flag_sua = false;
        List<data> list = new List<data>();
        
        #endregion


        #region Private Method

        private void add_list()
        {
            data v_data = new data();
            QuyDoiDVT q = new QuyDoiDVT();
            v_data.id_giao_dich_detail = 0;
            v_data.id_thuoc = txt_search_thuoc1.dcID;
            v_data.ten_thuoc = txt_search_thuoc1.Text1;
            v_data.so_luong_ban = Convert.ToDecimal(m_txt_so_luong.Text);
            v_data.so_luong_nhap = 0;
            v_data.so_luong_ban_min = q.QuyDoi(Convert.ToDecimal(m_txt_so_luong.Text), CIPConvert.ToDecimal(m_cbo_don_vi_tinh.SelectedValue), txt_search_thuoc1.dcID);
            v_data.id_don_vi_tinh_thuoc = CIPConvert.ToDecimal(m_cbo_don_vi_tinh.SelectedValue);
            v_data.ten_don_vi_tinh = m_cbo_don_vi_tinh.DisplayMember;
            v_data.id_don_vi_tinh_thuoc_min = quy_doi_doi_don_vi_tinh(v_data.id_thuoc);
            if (v_data.id_don_vi_tinh_thuoc_min == 0) return; // chưa có dữ liệu, id_don_vi_tinh_thuoc_min = 0; thoát hàm!
            v_data.gia_ban = CIPConvert.ToDecimal(m_txt_don_gia.Text);
            v_data.gia_ban_min = quy_doi_gia_ban(v_data.id_don_vi_tinh_thuoc_min);
            v_data.gia_nhap = 0;
            v_data.id_hang_san_xuat = 2;
            v_data.id_nha_cung_cap = 2;
            v_data.id_nha_san_xuat = 2;
            v_data.han_su_dung = DateTime.Now;
            v_data.id_lo_thuoc = 0;
            list.Add(v_data);
        }
        private void format_control()
        {
            m_lbl_Ma_GD_text.Text = gen_Ma_GD();
            m_lbl_ngay_GD.Text = CIPConvert.ToStr(CAppContext_201.getCurentDate());
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
        private void set_define_events()
        {
            //m_cmd_them.Click += new EventHandler(m_cmd_them_Click);
            //    m_cmd_insert.Click += new EventHandler(m_cmd_insert_Click);
            //    m_cmd_update.Click += new EventHandler(m_cmd_update_Click);
            //    m_cmd_delete.Click += new EventHandler(m_cmd_delete_Click);
        }

        private decimal quy_doi_doi_don_vi_tinh(decimal ip_id_thuoc)
        {
            US_GD_SO_DU v_us = new US_GD_SO_DU();
            DS_GD_SO_DU v_ds = new DS_GD_SO_DU();
            v_us.FillDataset(v_ds,"where id_thuoc ="+ip_id_thuoc);
            if (v_ds.Tables[0].Rows.Count != 0)
            {
                DataRow v_dr = v_ds.Tables[0].Rows[0];
                return CIPConvert.ToDecimal(v_dr["ID_DON_VI_THUOC"]);
            }
            else
            { 
                txt_search_thuoc1.Focus();
                return 0;
            }
        }
        private decimal quy_doi_gia_ban(decimal ip_don_vi_tinh)
        {
            decimal gia_ban;
            US_GD_GIA_BAN v_us = new US_GD_GIA_BAN();
            DS_GD_GIA_BAN v_ds = new DS_GD_GIA_BAN();
            v_us.FillDataset(v_ds,"where ID_DON_VI_TINH ="+ip_don_vi_tinh);
            DataRow v_dr = v_ds.Tables[0].Rows[0];
            return gia_ban = CIPConvert.ToDecimal(v_dr["GIA_BAN"]);
        }

        private void insert_so_du()
        {
            US_GD_SO_DU v_us_sd = new US_GD_SO_DU();
            DS_GD_SO_DU v_ds_sd = new DS_GD_SO_DU();
            foreach (data v_list in list)
            {
                v_ds_sd.Clear();
                v_us_sd.FillDataset(v_ds_sd, "where ID_THUOC =" + v_list.id_thuoc + "and MOI_NHAT_YN = 'Y' ");
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
                    v_us_sd.dcSO_DU = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["SO_DU"]) - v_list.so_luong_ban_min;
                    v_us_sd.Insert();
                }
                else
                {
                    v_us_sd.dcID = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID"]);
                    v_us_sd.dcID_THUOC = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID_THUOC"]);
                    v_us_sd.dcSO_DU = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["SO_DU"]) - v_list.so_luong_ban_min;
                    v_us_sd.dcID_DON_VI_THUOC = CIPConvert.ToDecimal(v_ds_sd.Tables[0].Rows[0]["ID_DON_VI_THUOC"]);
                    //v_us_sd.datNGAY_PHAT_SINH = CIPConvert.ToDatetime( v_ds_sd.Tables[0].Rows[0]["NGAY_PHAT_SINH"].ToString(),"dd/MM/yyyy");
                    v_us_sd.datNGAY_PHAT_SINH = DateTime.Now;
                    v_us_sd.strMOI_NHAT_YN = v_ds_sd.Tables[0].Rows[0]["MOI_NHAT_YN"].ToString();
                    v_us_sd.Update();
                }
            }
        }
        private void insert_giao_dich_detail()
        {
            US_GD_GIAO_DICH_DETAIL v_us_gd_de = new US_GD_GIAO_DICH_DETAIL();
            DS_GD_GIAO_DICH_DETAIL v_ds_gd_de = new DS_GD_GIAO_DICH_DETAIL();
            foreach (data v_list in list)
            {
                v_us_gd_de.Insert_data_into_gd_giao_dich_detail(m_id_giao_dich, v_list.id_thuoc, v_list.id_don_vi_tinh_thuoc_min, v_list.so_luong_nhap, v_list.so_luong_ban_min, v_list.id_giao_dich_detail, v_list.id_nha_cung_cap, v_list.id_nha_san_xuat, v_list.id_hang_san_xuat, v_list.han_su_dung, v_list.gia_ban_min, v_list.gia_nhap);
            }

        }
        private void insert_gd_giao_dich()
        {
            US_GD_GIAO_DICH v_us = new US_GD_GIAO_DICH();
            DS_GD_GIAO_DICH v_ds = new DS_GD_GIAO_DICH();
            v_us.strMA_GIAO_DICH = m_lbl_Ma_GD_text.Text;
            v_us.datNGAY_GIAO_DICH = CIPConvert.ToDatetime(m_lbl_ngay_GD.Text);
            v_us.dcID_NGUOI_THUC_HIEN = CAppContext_201.getCurrentUserID();
            v_us.dcID_KHACH_HANG = CIPConvert.ToDecimal(m_cbo_ten_khach_hang.SelectedValue);
            v_us.dcID_LOAI_GIAO_DICH = 2;
            if (CIPConvert.ToDecimal(m_cbo_ten_bac_sy.SelectedValue) == -1)
            {
                v_us.dcID_BAC_SY = 14;
            }
            else
            {
                v_us.dcID_BAC_SY = CIPConvert.ToDecimal(m_cbo_ten_bac_sy.SelectedValue);
            }
            v_us.dcTI_LE_CHIET_KHAU = m_ti_le_chiet_khau;
            v_us.Insert();
            m_id_giao_dich = v_us.dcID;
        }

        private void load_ten_thuoc()
        {
            US_V_DM_THUOC v_us = new US_V_DM_THUOC();
            DS_V_DM_THUOC v_ds = new DS_V_DM_THUOC();
            v_us.FillDataset(v_ds);
            txt_search_thuoc1.load_data_to_list(v_ds, V_DM_THUOC.DISPLAY, V_DM_THUOC.ID);
        }
        private void load_cbo_don_vi_tinh()
        {
            
            US_V_GD_DON_VI_TINH_THUOC v_us_v_gd_don_vi_tinh_thuoc = new US_V_GD_DON_VI_TINH_THUOC();
            DS_V_GD_DON_VI_TINH_THUOC v_ds_v_gd_don_vi_tinh_thuoc = new DS_V_GD_DON_VI_TINH_THUOC();
            decimal v_id_thuoc = txt_search_thuoc1.dcID;
            v_us_v_gd_don_vi_tinh_thuoc.FillDataset(v_ds_v_gd_don_vi_tinh_thuoc, "where ID_THUOC = " + v_id_thuoc);
            if (v_ds_v_gd_don_vi_tinh_thuoc.Tables[0].Rows.Count != 0)
            {
                
                m_cbo_don_vi_tinh.DataSource = v_ds_v_gd_don_vi_tinh_thuoc.V_GD_DON_VI_TINH_THUOC;
                m_cbo_don_vi_tinh.ValueMember = V_GD_DON_VI_TINH_THUOC.ID;
                m_cbo_don_vi_tinh.DisplayMember = V_GD_DON_VI_TINH_THUOC.TEN_DON_VI;
            }
            else
            {
                BaseMessages.MsgBox_Infor("Chưa có dữ liệu của loại thuốc này");
                DataRow v_dr = v_ds_v_gd_don_vi_tinh_thuoc.Tables[0].NewRow();
                v_dr[V_GD_DON_VI_TINH_THUOC.ID] = -1;
                v_dr[V_GD_DON_VI_TINH_THUOC.TEN_DON_VI] = "Chưa nhập";
                v_dr[V_GD_DON_VI_TINH_THUOC.ID_THUOC] = -1;
                v_dr[V_GD_DON_VI_TINH_THUOC.ID_DON_VI_TINH] = -1;
                v_dr[V_GD_DON_VI_TINH_THUOC.ID_NHOM_DON_VI_TINH] = -1;
                v_dr[V_GD_DON_VI_TINH_THUOC.GIA_BAN] = -1;
                v_ds_v_gd_don_vi_tinh_thuoc.V_GD_DON_VI_TINH_THUOC.Rows.InsertAt(v_dr, 0);
                m_cbo_don_vi_tinh.DataSource = v_ds_v_gd_don_vi_tinh_thuoc.V_GD_DON_VI_TINH_THUOC;
                m_cbo_don_vi_tinh.ValueMember = V_GD_DON_VI_TINH_THUOC.ID;
                m_cbo_don_vi_tinh.DisplayMember = V_GD_DON_VI_TINH_THUOC.TEN_DON_VI;
                m_txt_don_gia.Text = "Chưa nhập";

            }
            trang_thai = true;
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
        private void load_data_2_grid()
        {
            m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[1].Value = txt_search_thuoc1.Text1;
            m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[2].Value = m_txt_so_luong.Text;
            m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[3].Value = m_cbo_don_vi_tinh.Text;
            m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[4].Value = m_txt_don_gia.Text;
        }
        private void load_data_grid_2_form()
        {
            int i_row = 0;
            txt_search_thuoc1.Text1 = m_grv_quan_ly_ban_thuoc.SelectedRows[i_row].Cells[1].ToString();
            load_cbo_don_vi_tinh();
            load_don_gia();
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
        private void load_don_gia()
        {
            US_V_GD_DON_VI_TINH_THUOC v_us_v_gd_don_vi_tinh_thuoc = new US_V_GD_DON_VI_TINH_THUOC();
            DS_V_GD_DON_VI_TINH_THUOC v_ds_v_gd_don_vi_tinh_thuoc = new DS_V_GD_DON_VI_TINH_THUOC();
            decimal don_gia;
            decimal v_id_don_vi_tinh_thuoc = CIPConvert.ToDecimal(m_cbo_don_vi_tinh.SelectedValue);
            v_us_v_gd_don_vi_tinh_thuoc.FillDataset(v_ds_v_gd_don_vi_tinh_thuoc, "where ID = " + v_id_don_vi_tinh_thuoc);
            if (v_ds_v_gd_don_vi_tinh_thuoc.Tables[0].Rows.Count != 0)
            {
                DataRow v_dr = v_ds_v_gd_don_vi_tinh_thuoc.Tables[0].Rows[0];
                don_gia = CIPConvert.ToDecimal(v_dr[V_GD_DON_VI_TINH_THUOC.GIA_BAN]);
                m_txt_don_gia.Text = don_gia.ToString();
                m_txt_don_gia.Text = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_don_gia.Text.Trim()));
            }
            else
            { 
                m_txt_don_gia.Text = "Chưa nhập";
            }
        }

        private bool check_so_luong()
        {
            decimal num;
            bool isNumberic = decimal.TryParse(m_txt_so_luong.Text, out num);

            if (!isNumberic)
            {
                return false;
            }
            else return true;
        }
        private bool check_don_gia()
        {
            decimal num;
            bool isNumberic = decimal.TryParse(m_txt_don_gia.Text, out num);

            if (!isNumberic)
            {
                return false;
            }
            else return true;
        }
        private bool check_chiet_khau()
        {
            decimal num;
            bool isNumberic = decimal.TryParse(m_txt_ti_le_chiet_khau.Text, out num);

            if (!isNumberic)
            {
                return false;
            }
            else return true;
        }
        private bool check_so_luong_va_so_du()
        {
            if (!check_validate()) return false;
            US_GD_SO_DU v_us = new US_GD_SO_DU();
            DS_GD_SO_DU v_ds = new DS_GD_SO_DU();
            v_us.FillDataset(v_ds, "where id_thuoc = " + txt_search_thuoc1.dcID + "and moi_nhat_yn = 'y'");
            if (v_ds.Tables[0].Rows.Count > 0)
            {
                DataRow v_dr = v_ds.Tables[0].Rows[0];
                if (CIPConvert.ToDecimal(m_txt_so_luong.Text) > CIPConvert.ToDecimal(v_dr["SO_DU"]))
                {
                    DialogResult result = MessageBox.Show("Số lượng vừa nhập vượt số dư trong kho. Bạn có muốn bán hết số dư không?",
                   "Thông báo",
                   MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        m_txt_so_luong.Text = v_dr["SO_DU"].ToString();
                        return true;
                    }
                    if (result == DialogResult.No)
                    {
                        m_txt_so_luong.Text = "";
                        m_txt_so_luong.Focus();
                        return false;
                    }
                }
                if (CIPConvert.ToDecimal(m_txt_so_luong.Text) <= CIPConvert.ToDecimal(v_dr["SO_DU"]))
                {
                    return true;
                }
                return false;
            }
            else
            {
                BaseMessages.MsgBox_Error("Chưa nhập đủ dữ liệu cho loại thuốc này!");
                return false;
            }
        }
        private bool check_validate()
        {
            if (txt_search_thuoc1.Text1 == null)
            {
                BaseMessages.MsgBox_Infor("Bạn chưa nhập tên thuốc");
                txt_search_thuoc1.Focus();
                return false;
            }
            if (!CValidateTextBox.IsValid(m_txt_don_gia, DataType.StringType, allowNull.NO, true)) return false;
            if (!CValidateTextBox.IsValid(m_txt_so_luong, DataType.StringType, allowNull.NO, true)) return false;
            return true;
        }

        private void restart_data()
        {
            list.Clear();
            m_grv_quan_ly_ban_thuoc.Rows.Clear();
            txt_search_thuoc1.Text1 = "";
            m_txt_don_gia.Text = "";
            m_cbo_don_vi_tinh.Text = "";
            tong_tien = 0;
            tong_tien_thanh_toan = 0;
            m_txt_tong_tien.Text = "0 VNĐ";
            m_txt_tong_tien_thanh_toan.Text = "0 VNĐ";
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

        private void m_cbo_don_vi_tinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(trang_thai == true)
            {
            US_V_GD_DON_VI_TINH_THUOC v_us_v_gd_don_vi_tinh_thuoc = new US_V_GD_DON_VI_TINH_THUOC();
            DS_V_GD_DON_VI_TINH_THUOC v_ds_v_gd_don_vi_tinh_thuoc = new DS_V_GD_DON_VI_TINH_THUOC();
            decimal don_gia;
            decimal v_id_don_vi_tinh_thuoc = CIPConvert.ToDecimal(m_cbo_don_vi_tinh.SelectedValue);
            v_us_v_gd_don_vi_tinh_thuoc.FillDataset(v_ds_v_gd_don_vi_tinh_thuoc, "where ID = " + v_id_don_vi_tinh_thuoc);
            if (v_ds_v_gd_don_vi_tinh_thuoc.Tables[0].Rows.Count != 0)
            {
                DataRow v_dr = v_ds_v_gd_don_vi_tinh_thuoc.Tables[0].Rows[0];
                don_gia = CIPConvert.ToDecimal(v_dr[V_GD_DON_VI_TINH_THUOC.GIA_BAN]);
                m_txt_don_gia.Text = don_gia.ToString();
                m_txt_don_gia.Text = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_don_gia.Text.Trim()));
            }
            else
            {
                DataRow v_dr = v_ds_v_gd_don_vi_tinh_thuoc.Tables[0].NewRow();
                v_dr[V_GD_DON_VI_TINH_THUOC.ID] = -1;
                v_dr[V_GD_DON_VI_TINH_THUOC.TEN_DON_VI] = "Chưa nhập";
                v_dr[V_GD_DON_VI_TINH_THUOC.ID_THUOC] = -1;
                v_dr[V_GD_DON_VI_TINH_THUOC.ID_DON_VI_TINH] = -1;
                v_dr[V_GD_DON_VI_TINH_THUOC.ID_NHOM_DON_VI_TINH] = -1;
                v_dr[V_GD_DON_VI_TINH_THUOC.GIA_BAN] = -1;
                v_ds_v_gd_don_vi_tinh_thuoc.V_GD_DON_VI_TINH_THUOC.Rows.InsertAt(v_dr, 0);
                m_cbo_don_vi_tinh.DataSource = v_ds_v_gd_don_vi_tinh_thuoc.V_GD_DON_VI_TINH_THUOC;
                m_cbo_don_vi_tinh.ValueMember = V_GD_DON_VI_TINH_THUOC.ID;
                m_cbo_don_vi_tinh.DisplayMember = V_GD_DON_VI_TINH_THUOC.TEN_DON_VI;
                m_txt_don_gia.Text = "Chưa nhập";
            }
        }
        }

        private void m_cmd_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check_validate()) return;
                if (!check_so_luong()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_so_luong.Focus(); return; }
                if (!check_don_gia()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_don_gia.Focus(); return; }
                if (!check_chiet_khau()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_ti_le_chiet_khau.Focus(); return; }
                if (!check_so_luong_va_so_du()) return;
                add_list();
                if (list.Count == 0) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); return; };
                int n = m_grv_quan_ly_ban_thuoc.Rows.Add();
                m_grv_quan_ly_ban_thuoc.Rows[n].Cells[0].Value = n + 1;
                m_grv_quan_ly_ban_thuoc.Rows[n].Cells[1].Value = txt_search_thuoc1.Text1;
                m_grv_quan_ly_ban_thuoc.Rows[n].Cells[2].Value = m_txt_so_luong.Text;
                m_grv_quan_ly_ban_thuoc.Rows[n].Cells[3].Value = m_cbo_don_vi_tinh.Text;
                m_grv_quan_ly_ban_thuoc.Rows[n].Cells[4].Value = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_don_gia.Text.ToString().Replace(",", ""))) + " " + "VNĐ";
                m_grv_quan_ly_ban_thuoc.Rows[n].Cells[5].Value = string.Format("{0:#,###}", CIPConvert.ToDecimal(int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_don_gia.Text.ToString().Replace(",", "")))) + " " + "VNĐ";
                tong_tien += int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_don_gia.Text.Trim().Replace(",", ""));
                m_txt_tong_tien.Text = string.Format("{0:0,#}", CIPConvert.ToDecimal(tong_tien)) + " " + "VNĐ";
                m_txt_tong_tien_thanh_toan.Text = string.Format("{0:0,#}", (CIPConvert.ToDecimal(tong_tien)-(CIPConvert.ToDecimal(tong_tien)*m_ti_le_chiet_khau)/100)) + " " + "VNĐ";
                txt_search_thuoc1.Focus();
                m_cbo_don_vi_tinh.Refresh();
                m_txt_don_gia.Clear();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e); ;
            }
        }

        private void m_cmd_in_Click(object sender, EventArgs e)
        {
            try
            {
                //f115_REPORT_GD_GIAO_DICH_DETIAL frm = new f115_REPORT_GD_GIAO_DICH_DETIAL();
                //frm.Show();

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_cap_nhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!check_validate()) return;
                if (!check_so_luong()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_so_luong.Focus(); return; }
                if (!check_don_gia()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_don_gia.Focus(); return; }
                if (!check_chiet_khau()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_ti_le_chiet_khau.Focus(); return; }
                if (!check_so_luong_va_so_du()) return;
                //tính tổng cũ
                decimal tong_cu;
                tong_cu = list[m_i_fg].so_luong_ban * list[m_i_fg].gia_ban;
                // sửa dữ liệu trong list
                list[m_i_fg].so_luong_ban = CIPConvert.ToDecimal(m_txt_so_luong.Text);
                list[m_i_fg].ten_don_vi_tinh = m_cbo_don_vi_tinh.Text;
                list[m_i_fg].gia_ban = CIPConvert.ToDecimal(m_txt_don_gia.Text);
                //load dữ liệu xuống grid
                m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[2].Value = m_txt_so_luong.Text;
                m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[3].Value = m_cbo_don_vi_tinh.Text;
                m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[4].Value = m_txt_don_gia.Text;
                m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[5].Value = CIPConvert.ToDecimal(m_txt_don_gia.Text) * CIPConvert.ToDecimal(m_txt_so_luong.Text);
                tong_tien = (tong_tien - tong_cu) + (int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_don_gia.Text.Trim().Replace(",", "")));
                m_txt_tong_tien.Text = string.Format("{0:0,#}", CIPConvert.ToDecimal(tong_tien)) + " " + "VNĐ";
                m_txt_tong_tien_thanh_toan.Text = string.Format("{0:0,#}", CIPConvert.ToDecimal(tong_tien)) + " " + "VNĐ";
                //thông báo và thoát khỏi chế độ sửa
                BaseMessages.MsgBox_Infor("Bạn đã cập nhật thành công");
                m_cmd_them.Visible = true;
                m_cmd_luu.Visible = true;
                m_lbl_luu.Visible = true;
                m_cmd_sua.Visible = true;
                m_lbl_sua.Visible = true;
                m_cmd_in.Visible = true;
                m_lbl_in.Visible = true;
                txt_search_thuoc1.Visible = true;
                m_cmd_tro_ve.Visible = false;
                m_lbl_tro_lai.Visible = false;
                m_cmd_cap_nhat.Visible = false;
                m_lbl_cap_nhat.Visible = false;
                m_txt_cap_nhat_ten_thuoc.Visible = false;
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_tro_ve_Click(object sender, EventArgs e)
        {
            try
            {
                flag_sua = false;
                m_cmd_them.Visible = true;
                m_cmd_luu.Visible = true;
                m_lbl_luu.Visible = true;
                m_cmd_sua.Visible = true;
                m_lbl_sua.Visible = true;
                m_cmd_in.Visible = true;
                m_lbl_in.Visible = true;
                txt_search_thuoc1.Visible = true;
                m_cmd_tro_ve.Visible = false;
                m_lbl_tro_lai.Visible = false;
                m_cmd_cap_nhat.Visible = false;
                m_lbl_cap_nhat.Visible = false;
                m_txt_cap_nhat_ten_thuoc.Visible = false;
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_cmd_luu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có muốn lưu lại không?",
                "Quản lý bán thuốc", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) 
                {
                    insert_gd_giao_dich();
                    insert_giao_dich_detail();
                    insert_so_du();
                    BaseMessages.MsgBox_Infor("Đã lưu xong");
                    restart_data();
                }
                if (result == DialogResult.No)
                {
                    restart_data();
                }

            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }


        }

        private void m_cmd_sua_Click(object sender, EventArgs e)
        {
            try
            {
                flag_sua = true;
                m_cmd_them.Visible = false;
                m_cmd_luu.Visible = false;
                m_lbl_luu.Visible = false;
                m_cmd_sua.Visible = false;
                m_lbl_sua.Visible = false;
                m_cmd_in.Visible = false;
                m_lbl_in.Visible = false;
                txt_search_thuoc1.Visible = false;
                m_cmd_tro_ve.Visible = true;
                m_lbl_tro_lai.Visible = true;
                m_cmd_cap_nhat.Visible = true;
                m_lbl_cap_nhat.Visible = true;
                m_txt_cap_nhat_ten_thuoc.Visible = true;
                m_i_fg = m_grv_quan_ly_ban_thuoc.SelectedRows[0].Index;
                m_txt_cap_nhat_ten_thuoc.Text = list[m_i_fg].ten_thuoc;
                txt_search_thuoc1.dcID = list[m_i_fg].id_thuoc;
                load_cbo_don_vi_tinh();
                load_don_gia();
                m_txt_so_luong.Text = list[m_i_fg].so_luong_ban.ToString();
                m_cbo_don_vi_tinh.Text = list[m_i_fg].ten_don_vi_tinh;
                m_txt_don_gia.Text = list[m_i_fg].gia_ban.ToString();
                //m_grv_quan_ly_ban_thuoc.MultiSelect = false;
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
                DialogResult result = MessageBox.Show("Bạn có muốn xóa không?",
                "Thông báo", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    //xóa dữ liệu trong list
                    list.RemoveAt(m_grv_quan_ly_ban_thuoc.SelectedRows[0].Index);
                    m_grv_quan_ly_ban_thuoc.Rows.RemoveAt(m_grv_quan_ly_ban_thuoc.SelectedRows[0].Index);
                    txt_search_thuoc1.Focus();
                    BaseMessages.MsgBox_Infor("Đã xóa");
                }
                if (result == DialogResult.No)
                {
                    return;
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_cmd_thoat_Click(object sender, EventArgs e)
        {
            try
            {
                this.Controls.Clear();
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_don_gia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                BaseMessages.MsgBox_Error("Bạn chỉ được nhập số!");
                m_txt_don_gia.Focus();

            }

        }

        private void m_txt_so_luong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                BaseMessages.MsgBox_Error("Bạn chỉ được nhập số!");
                m_txt_so_luong.Focus();
            }
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

        private void m_txt_ti_le_chiet_khau_Leave(object sender, EventArgs e)
        {
            if (!check_chiet_khau()) { BaseMessages.MsgBox_Error("Bạn phải nhập kiểu số"); m_txt_ti_le_chiet_khau.Text = "0"; m_txt_ti_le_chiet_khau.Focus(); return; }
            if (m_txt_ti_le_chiet_khau.Text == "" || m_txt_ti_le_chiet_khau.Text == "0")
            {
                m_ti_le_chiet_khau = 0;
            }
            m_ti_le_chiet_khau = CIPConvert.ToDecimal(m_txt_ti_le_chiet_khau.Text);
            tong_tien_thanh_toan = tong_tien - (tong_tien * m_ti_le_chiet_khau) / 100;
            m_txt_tong_tien_thanh_toan.Text = string.Format("{0:0,#}", CIPConvert.ToDecimal(tong_tien_thanh_toan)) + " " + "VNĐ";

        }

        private void m_txt_so_luong_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (flag_sua == false)
                    {
                        if (!check_validate()) return;
                        if (!check_so_luong()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_so_luong.Focus(); return; }
                        if (!check_don_gia()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_don_gia.Focus(); return; }
                        if (!check_chiet_khau()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_ti_le_chiet_khau.Focus(); return; }
                        if (!check_so_luong_va_so_du()) return;
                        add_list();
                        if (list.Count == 0) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); return; };
                        int n = m_grv_quan_ly_ban_thuoc.Rows.Add();
                        m_grv_quan_ly_ban_thuoc.Rows[n].Cells[0].Value = n + 1;
                        m_grv_quan_ly_ban_thuoc.Rows[n].Cells[1].Value = txt_search_thuoc1.Text1;
                        m_grv_quan_ly_ban_thuoc.Rows[n].Cells[2].Value = m_txt_so_luong.Text;
                        m_grv_quan_ly_ban_thuoc.Rows[n].Cells[3].Value = m_cbo_don_vi_tinh.Text;
                        m_grv_quan_ly_ban_thuoc.Rows[n].Cells[4].Value = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_don_gia.Text.ToString().Replace(",", ""))) + " " + "VNĐ";
                        m_grv_quan_ly_ban_thuoc.Rows[n].Cells[5].Value = string.Format("{0:#,###}", CIPConvert.ToDecimal(int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_don_gia.Text.ToString().Replace(",", "")))) + " " + "VNĐ";
                        tong_tien += int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_don_gia.Text.Trim().Replace(",", ""));
                        m_txt_tong_tien.Text = string.Format("{0:0,#}", CIPConvert.ToDecimal(tong_tien)) + " " + "VNĐ";
                        m_txt_tong_tien_thanh_toan.Text = string.Format("{0:0,#}", CIPConvert.ToDecimal(tong_tien)) + " " + "VNĐ";
                        txt_search_thuoc1.Focus();
                        m_cbo_don_vi_tinh.Refresh();
                        m_txt_don_gia.Clear();
                    }
                    else
                    {
                        if (!check_validate()) return;
                        if (!check_so_luong()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_so_luong.Focus(); return; }
                        if (!check_don_gia()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_don_gia.Focus(); return; }
                        if (!check_chiet_khau()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_ti_le_chiet_khau.Focus(); return; }
                        if (!check_so_luong_va_so_du()) return;
                        //tính tổng cũ
                        decimal tong_cu;
                        tong_cu = list[m_i_fg].so_luong_ban * list[m_i_fg].gia_ban;
                        // sửa dữ liệu trong list
                        list[m_i_fg].so_luong_ban = CIPConvert.ToDecimal(m_txt_so_luong.Text);
                        list[m_i_fg].ten_don_vi_tinh = m_cbo_don_vi_tinh.Text;
                        list[m_i_fg].gia_ban = CIPConvert.ToDecimal(m_txt_don_gia.Text);
                        //load dữ liệu xuống grid
                        m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[2].Value = m_txt_so_luong.Text;
                        m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[3].Value = m_cbo_don_vi_tinh.Text;
                        m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[4].Value = m_txt_don_gia.Text;
                        m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[5].Value = CIPConvert.ToDecimal(m_txt_don_gia.Text) * CIPConvert.ToDecimal(m_txt_so_luong.Text);
                        tong_tien = (tong_tien - tong_cu) + (int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_don_gia.Text.Trim().Replace(",", "")));
                        m_txt_tong_tien.Text = string.Format("{0:0,#}", CIPConvert.ToDecimal(tong_tien)) + " " + "VNĐ";
                        m_txt_tong_tien_thanh_toan.Text = string.Format("{0:0,#}", CIPConvert.ToDecimal(tong_tien)) + " " + "VNĐ";
                        //thông báo và thoát khỏi chế độ sửa
                        BaseMessages.MsgBox_Infor("Bạn đã cập nhật thành công");
                        m_cmd_them.Visible = true;
                        m_cmd_luu.Visible = true;
                        m_lbl_luu.Visible = true;
                        m_cmd_sua.Visible = true;
                        m_lbl_sua.Visible = true;
                        m_cmd_in.Visible = true;
                        m_lbl_in.Visible = true;
                        txt_search_thuoc1.Visible = true;
                        m_cmd_tro_ve.Visible = false;
                        m_lbl_tro_lai.Visible = false;
                        m_cmd_cap_nhat.Visible = false;
                        m_lbl_cap_nhat.Visible = false;
                        m_txt_cap_nhat_ten_thuoc.Visible = false;
                    }
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }

        }

        private void m_txt_don_gia_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter)
                {
                    if (flag_sua == false)
                    {
                        if (!check_validate()) return;
                        if (!check_so_luong()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_so_luong.Focus(); return; }
                        if (!check_don_gia()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_don_gia.Focus(); return; }
                        if (!check_chiet_khau()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_ti_le_chiet_khau.Focus(); return; }
                        if (!check_so_luong_va_so_du()) return;
                        add_list();
                        if (list.Count == 0) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); return; };
                        int n = m_grv_quan_ly_ban_thuoc.Rows.Add();
                        m_grv_quan_ly_ban_thuoc.Rows[n].Cells[0].Value = n + 1;
                        m_grv_quan_ly_ban_thuoc.Rows[n].Cells[1].Value = txt_search_thuoc1.Text1;
                        m_grv_quan_ly_ban_thuoc.Rows[n].Cells[2].Value = m_txt_so_luong.Text;
                        m_grv_quan_ly_ban_thuoc.Rows[n].Cells[3].Value = m_cbo_don_vi_tinh.Text;
                        m_grv_quan_ly_ban_thuoc.Rows[n].Cells[4].Value = string.Format("{0:#,###}", CIPConvert.ToDecimal(m_txt_don_gia.Text.ToString().Replace(",", ""))) + " " + "VNĐ";
                        m_grv_quan_ly_ban_thuoc.Rows[n].Cells[5].Value = string.Format("{0:#,###}", CIPConvert.ToDecimal(int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_don_gia.Text.ToString().Replace(",", "")))) + " " + "VNĐ";
                        tong_tien += int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_don_gia.Text.Trim().Replace(",", ""));
                        m_txt_tong_tien.Text = string.Format("{0:0,#}", CIPConvert.ToDecimal(tong_tien)) + " " + "VNĐ";
                        m_txt_tong_tien_thanh_toan.Text = string.Format("{0:0,#}", CIPConvert.ToDecimal(tong_tien)) + " " + "VNĐ";
                        txt_search_thuoc1.Focus();
                        m_cbo_don_vi_tinh.Refresh();
                        m_txt_don_gia.Clear();
                    }
                    else
                    {
                        if (!check_validate()) return;
                        if (!check_so_luong()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_so_luong.Focus(); return; }
                        if (!check_don_gia()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_don_gia.Focus(); return; }
                        if (!check_chiet_khau()) { BaseMessages.MsgBox_Error("Bạn nhập dữ liệu chưa đúng!"); m_txt_ti_le_chiet_khau.Focus(); return; }
                        if (!check_so_luong_va_so_du()) return;
                        //tính tổng cũ
                        decimal tong_cu;
                        tong_cu = list[m_i_fg].so_luong_ban * list[m_i_fg].gia_ban;
                        // sửa dữ liệu trong list
                        list[m_i_fg].so_luong_ban = CIPConvert.ToDecimal(m_txt_so_luong.Text);
                        list[m_i_fg].ten_don_vi_tinh = m_cbo_don_vi_tinh.Text;
                        list[m_i_fg].gia_ban = CIPConvert.ToDecimal(m_txt_don_gia.Text);
                        //load dữ liệu xuống grid
                        m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[2].Value = m_txt_so_luong.Text;
                        m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[3].Value = m_cbo_don_vi_tinh.Text;
                        m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[4].Value = m_txt_don_gia.Text;
                        m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[5].Value = CIPConvert.ToDecimal(m_txt_don_gia.Text) * CIPConvert.ToDecimal(m_txt_so_luong.Text);
                        tong_tien = (tong_tien - tong_cu) + (int.Parse(m_txt_so_luong.Text.ToString()) * int.Parse(m_txt_don_gia.Text.Trim().Replace(",", "")));
                        m_txt_tong_tien.Text = string.Format("{0:0,#}", CIPConvert.ToDecimal(tong_tien)) + " " + "VNĐ";
                        m_txt_tong_tien_thanh_toan.Text = string.Format("{0:0,#}", CIPConvert.ToDecimal(tong_tien)) + " " + "VNĐ";
                        //thông báo và thoát khỏi chế độ sửa
                        BaseMessages.MsgBox_Infor("Bạn đã cập nhật thành công");
                        m_cmd_them.Visible = true;
                        m_cmd_luu.Visible = true;
                        m_lbl_luu.Visible = true;
                        m_cmd_sua.Visible = true;
                        m_lbl_sua.Visible = true;
                        m_cmd_in.Visible = true;
                        m_lbl_in.Visible = true;
                        txt_search_thuoc1.Visible = true;
                        m_cmd_tro_ve.Visible = false;
                        m_lbl_tro_lai.Visible = false;
                        m_cmd_cap_nhat.Visible = false;
                        m_lbl_cap_nhat.Visible = false;
                        m_txt_cap_nhat_ten_thuoc.Visible = false;
                    }
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

     
        #endregion

        private void m_grv_quan_ly_ban_thuoc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                flag_sua = true;
                m_cmd_them.Visible = false;
                m_cmd_luu.Visible = false;
                m_lbl_luu.Visible = false;
                m_cmd_sua.Visible = false;
                m_lbl_sua.Visible = false;
                m_cmd_in.Visible = false;
                m_lbl_in.Visible = false;
                txt_search_thuoc1.Visible = false;
                m_cmd_tro_ve.Visible = true;
                m_lbl_tro_lai.Visible = true;
                m_cmd_cap_nhat.Visible = true;
                m_lbl_cap_nhat.Visible = true;
                m_txt_cap_nhat_ten_thuoc.Visible = true;
                m_i_fg = m_grv_quan_ly_ban_thuoc.SelectedRows[0].Index;
                m_txt_cap_nhat_ten_thuoc.Text = list[m_i_fg].ten_thuoc;
                txt_search_thuoc1.dcID = list[m_i_fg].id_thuoc;
                load_cbo_don_vi_tinh();
                load_don_gia();
                m_txt_so_luong.Text = list[m_i_fg].so_luong_ban.ToString();
                m_cbo_don_vi_tinh.Text = list[m_i_fg].ten_don_vi_tinh;
                m_txt_don_gia.Text = list[m_i_fg].gia_ban.ToString();
                //m_grv_quan_ly_ban_thuoc.MultiSelect = false;
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
        }

        private void m_txt_ti_le_chiet_khau_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyData == Keys.Enter || e.KeyData == Keys.Tab)
                {
                    if (!check_chiet_khau()) { BaseMessages.MsgBox_Error("Bạn phải nhập kiểu số"); m_txt_ti_le_chiet_khau.Text = "0"; m_txt_ti_le_chiet_khau.Focus(); return; }
                    if (m_txt_ti_le_chiet_khau.Text == "" || m_txt_ti_le_chiet_khau.Text == "0")
                    {
                        m_ti_le_chiet_khau = 0;
                    }
                    m_ti_le_chiet_khau = CIPConvert.ToDecimal(m_txt_ti_le_chiet_khau.Text);
                    tong_tien_thanh_toan = tong_tien - (tong_tien * m_ti_le_chiet_khau) / 100;
                    m_txt_tong_tien_thanh_toan.Text = string.Format("{0:0,#}", CIPConvert.ToDecimal(tong_tien_thanh_toan)) + " " + "VNĐ";
                    m_cmd_luu.Focus();
                }
            }
            catch (Exception v_e)
            {

                CSystemLog_301.ExceptionHandle(v_e);
            }
           
        }


        //private void m_grv_quan_ly_ban_thuoc_MouseClick(object sender, MouseEventArgs e)
        //{
        //    txt_search_thuoc1.Text1 = m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[1].Value.ToString();
        //    m_txt_so_luong.Text = m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[2].Value.ToString();
        //    m_cbo_don_vi_tinh.Text = m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[3].Value.ToString();
        //    m_txt_don_gia.Text = m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[4].Value.ToString();   
        //}

        //private void m_grv_quan_ly_ban_thuoc_SelectionChanged(object sender, EventArgs e)
        //{
        //  m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[1].Value = txt_search_thuoc1.Text1;
        //  m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[2].Value = m_txt_so_luong.Text;
        //  m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[3].Value = m_cbo_don_vi_tinh.Text;
        //  m_grv_quan_ly_ban_thuoc.SelectedRows[0].Cells[4].Value = m_txt_don_gia.Text;
        //}
       

        

     

        //private void m_cbo_don_vi_tinh_KeyDown(object sender, KeyEventArgs e)
        //{
        //    try
        //    {
        //        if (e.KeyData == Keys.Enter)
        //            load_cbo_don_vi_tinh();
        //            load_don_gia();
        //    }
        //    catch (Exception v_e)
        //    {

        //        CSystemLog_301.ExceptionHandle(v_e);
        //    }
        //}

     }

 }
