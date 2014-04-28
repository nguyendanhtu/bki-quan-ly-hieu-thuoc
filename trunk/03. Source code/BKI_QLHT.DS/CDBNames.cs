﻿namespace BKI_QLHT.DS.CDBNames
{
    public class V_HT_CONTROL_IN_FORM
    {
        public const string ID = "ID";
        public const string FORM_NAME = "FORM_NAME";
        public const string DISPLAY_NAME = "DISPLAY_NAME";
        public const string CONTROL_NAME = "CONTROL_NAME";
        public const string CONTROL_TYPE = "CONTROL_TYPE";
        public const string MA_TU_DIEN = "MA_TU_DIEN";
        public const string ID_TU_DIEN = "ID_TU_DIEN";
    }


    public class HT_FORM
    {
        public const string ID = "ID";
        public const string FORM_NAME = "FORM_NAME";
        public const string DISPLAY_NAME = "DISPLAY_NAME";
    }


    public class LOAI_TU_DIEN
    {
        public const string PHAN_QUYEN = "PHAN_QUYEN";
        public const string DIA_DIEM_QUAN_LY = "DIA_DIEM_QUAN_LY";
        public const string DON_VI_QUAN_LY_CHINH = "DON_VI_QUAN_LY_CHINH";
        public const string LEVEL_GIANG_VIEN = "LEVEL_GIANG_VIEN";
        public const string LOAI_HOP_DONG = "LOAI_HOP_DONG";
        public const string TRANG_THAI_HOP_DONG_KHUNG = "TRANG_THAI_HOP_DONG_KHUNG";
        public const string TRANG_THAI_GIANG_VIEN = "TRANG_THAI_GIANG_VIEN";
        public const string HINH_THUC_CONG_TAC = "HINH_THUC_CONG_TAC";
        public const string TRANG_THAI_DOT_THANH_TOAN = "TRANG_THAI_DOT_THANH_TOAN";
        public const string TRANG_THAI_THANH_TOAN = "TRANG_THAI_THANH_TOAN";
        public const string TRANG_THAI_SU_KIEN = "TRANG_THAI_SU_KIEN";
        public const string TRANG_THAI_CONG_VIEC_GV = "TRANG_THAI_CONG_VIEC_GV";
        public const string TRANG_THAI_SU_KIEN_GV = "TRANG_THAI_SU_KIEN_GV";

    }

    public enum e_user_group
    {
        TESTER = 1
        ,
        PM_TD = 2
            ,
        TRUONG_NHOM_PO = 3
            ,
        PO = 4
            ,
        ADMIN = 5
            , GIANG_VIEN = 6
    }



    public class HT_PHAN_QUYEN_HE_THONG
    {
        public const string ID = "ID";
        public const string MA_PHAN_QUYEN = "MA_PHAN_QUYEN";
        public const string GHI_CHU = "GHI_CHU";
        public const string LOAI_PHAN_QUYEN = "LOAI_PHAN_QUYEN";
    }
    public class HT_PHAN_QUYEN_CHO_NHOM
    {
        public const string ID = "ID";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_PHAN_QUYEN_HE_THONG = "ID_PHAN_QUYEN_HE_THONG";
    }

    public class HT_NHOM_NGUOI_SU_DUNG
    {
        public const string ID = "ID";
        public const string MA_NHOM = "MA_NHOM";
        public const string GHI_CHU = "GHI_CHU";
        public const string TRANG_THAI_NHOM = "TRANG_THAI_NHOM";
        public const string ID_INPUTED_BY = "ID_INPUTED_BY";
        public const string INPUTED_DATE = "INPUTED_DATE";
        public const string ID_LAST_UPDATED_BY = "ID_LAST_UPDATED_BY";
        public const string LAS_UPDATED_DATE = "LAS_UPDATED_DATE";
    }

    public class SU_KIEN
    {
        public const string ID = "ID";
        public const string ID_LOAI_SU_KIEN = "ID_LOAI_SU_KIEN";
        public const string TEN_SU_KIEN = "TEN_SU_KIEN";
        public const string NGAY_DIEN_RA = "NGAY_DIEN_RA";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string MO_TA = "MO_TA";
    }

    public class CM_DM_TU_DIEN
    {
        public const string ID = "ID";
        public const string MA_TU_DIEN = "MA_TU_DIEN";
        public const string TEN_NGAN = "TEN_NGAN";
        public const string TEN = "TEN";
        public const string ID_LOAI_TU_DIEN = "ID_LOAI_TU_DIEN";
        public const string GHI_CHU = "GHI_CHU";
    }
    public class CM_DM_LOAI_TD
    {
        public const string ID = "ID";
        public const string MA_LOAI = "MA_LOAI";
        public const string TEN_LOAI = "TEN_LOAI";
    }

    public class HT_NGUOI_SU_DUNG
    {
        public const string ID = "ID";
        public const string TEN_TRUY_CAP = "TEN_TRUY_CAP";
        public const string TEN = "TEN";
        public const string MAT_KHAU = "MAT_KHAU";
        public const string NGAY_TAO = "NGAY_TAO";
        public const string NGUOI_TAO = "NGUOI_TAO";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string BUILT_IN_YN = "BUILT_IN_YN";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
    }

    public class HT_CHUC_NANG
    {
        public const string ID = "ID";
        public const string TEN_CHUC_NANG = "TEN_CHUC_NANG";
        public const string URL_FORM = "URL_FORM";
        public const string TRANG_THAI_YN = "TRANG_THAI_YN";
        public const string VI_TRI = "VI_TRI";
        public const string CHUC_NANG_PARENT_ID = "CHUC_NANG_PARENT_ID";
        public const string HIEN_THI_YN = "HIEN_THI_YN";
    }
    public class HT_QUYEN_GROUP
    {
        public const string ID = "ID";
        public const string ID_USER_GROUP = "ID_USER_GROUP";
        public const string ID_QUYEN = "ID_QUYEN";
    }
    public class HT_USER_GROUP
    {
        public const string ID = "ID";
        public const string USER_GROUP_NAME = "USER_GROUP_NAME";
        public const string DESCRIPTION = "DESCRIPTION";
    }


    /// <summary>
    /// 
    /// </summary>
    public class CM_COMPANY_INFO
    {
        public const string ID = "ID";
        public const string COMPANY_NAME = "COMPANY_NAME";
        public const string COMPANY_ADDRESS = "COMPANY_ADDRESS";
    }
    public class DM_DON_VI
    {
        public const string ID = "ID";
        public const string MA_VIET_TAT = "MA_VIET_TAT";
        public const string TEN_DAY_DU = "TEN_DAY_DU";
        public const string MA_SO_THUE = "MA_SO_THUE";
        public const string DIA_CHI = "DIA_CHI";
        public const string GHI_CHU_1 = "GHI_CHU_1";
        public const string GHI_CHU_2 = "GHI_CHU_2";
        public const string GHI_CHU_3 = "GHI_CHU_3";
        public const string ID_DON_VI_CAP_TREN = "ID_DON_VI_CAP_TREN";
        public const string ID_LOAI_DON_VI = "ID_LOAI_DON_VI";
    }

      public class DM_PHAP_NHAN
    {
        public const string ID = "ID";
        public const string MA_PHAP_NHAN = "MA_PHAP_NHAN";
        public const string TEN_PHAP_NHAN = "TEN_PHAP_NHAN";
        public const string MA_SO_THUE = "MA_SO_THUE";
        public const string MA_DK_KINH_DOANH = "MA_DK_KINH_DOANH";
        public const string NGAY_DK_KINH_DOANH = "NGAY_DK_KINH_DOANH";
        public const string DIA_CHI = "DIA_CHI";
        public const string NGUOI_DAI_DIEN = "NGUOI_DAI_DIEN";
    }



    public class DM_BAC_SY
    {
        public const string ID = "ID";
        public const string HO_TEN = "HO_TEN";
        public const string BENH_VIEN = "BENH_VIEN";
        public const string DIA_CHI = "DIA_CHI";
        public const string DIEN_THOAI = "DIEN_THOAI";
    }
    /// <summary>
    /// 
    /// </summary>
    public class DM_DANH_MUC_THUOC
    {
        public const string ID = "ID";
        public const string TEN_DANH_MUC = "TEN_DANH_MUC";
        public const string GHI_CHU = "GHI_CHU";
    }
    public class DM_NHA_CUNG_CAP
    {
        public const string ID = "ID";
        public const string TEN_NCC = "TEN_NCC";
        public const string MA_NCC = "MA_NCC";
        public const string DIA_CHI = "DIA_CHI";
        public const string SDT = "SDT";
    }
    public class V_DM_BAC_SY
    {
        public const string ID = "ID";
        public const string HO_TEN = "HO_TEN";
        public const string BENH_VIEN = "BENH_VIEN";
        public const string DIA_CHI = "DIA_CHI";
        public const string DIEN_THOAI = "DIEN_THOAI";
        public const string TEN_NGAN = "TEN_NGAN";
        public const string ID_LOAI_TU_DIEN = "ID_LOAI_TU_DIEN";
    }
    public class V_DM_KHACH_HANG
    {
        public const string ID = "ID";
        public const string TEN_KHACH_HANG = "TEN_KHACH_HANG";
        public const string MA_KHACH_HANG = "MA_KHACH_HANG";
        public const string SDT = "SDT";
        public const string DIA_CHI = "DIA_CHI";
        public const string ID_NHOM_KHACH_HANG = "ID_NHOM_KHACH_HANG";
        public const string MA_SO_THUE = "MA_SO_THUE";
        public const string TEN_NHOM = "TEN_NHOM";
    }
    public class DM_NHOM_KHACH_HANG
    {
        public const string ID = "ID";
        public const string MA_NHOM = "MA_NHOM";
        public const string TEN_NHOM = "TEN_NHOM";
    }
    public class DM_THUOC
    {
        public const string ID = "ID";
        public const string THUOC_THAY_THE = "THUOC_THAY_THE";
        public const string ID_DANH_MUC_THUOC = "ID_DANH_MUC_THUOC";
        public const string ID_NHOM_THUOC = "ID_NHOM_THUOC";
        public const string TT_HOAT_CHAT = "TT_HOAT_CHAT";
        public const string TT_THUOC = "TT_THUOC";
        public const string TEN_THUOC = "TEN_THUOC";
        public const string DUONG_DUNG_DANG_DUNG = "DUONG_DUNG_DANG_DUNG";
        public const string TUYEN_SU_DUNG_5 = "TUYEN_SU_DUNG_5";
        public const string TUYEN_SU_DUNG_6 = "TUYEN_SU_DUNG_6";
        public const string TUYEN_SU_DUNG_7 = "TUYEN_SU_DUNG_7";
        public const string TUYEN_SU_DUNG_8 = "TUYEN_SU_DUNG_8";
    }

    public class DM_NHOM_THUOC
    {
        public const string ID = "ID";
        public const string TEN_NHOM = "TEN_NHOM";
        public const string ID_DANH_MUC_THUOC = "ID_DANH_MUC_THUOC";
        public const string GHI_CHU = "GHI_CHU";
    }
    public class V_DM_NHOM_THUOC
    {
        public const string TEN_DANH_MUC = "TEN_DANH_MUC";
        public const string ID = "ID";
        public const string TEN_NHOM = "TEN_NHOM";
        public const string ID_DANH_MUC_THUOC = "ID_DANH_MUC_THUOC";
        public const string GHI_CHU = "GHI_CHU";
    }
    /// <summary>
    /// 
    /// </summary>
    public class V_DM_THUOC
    {
        public const string ID = "ID";
        public const string THUOC_THAY_THE = "THUOC_THAY_THE";
        public const string ID_DANH_MUC_THUOC = "ID_DANH_MUC_THUOC";
        public const string ID_NHOM_THUOC = "ID_NHOM_THUOC";
        public const string TT_HOAT_CHAT = "TT_HOAT_CHAT";
        public const string TT_THUOC = "TT_THUOC";
        public const string TEN_THUOC = "TEN_THUOC";
        public const string DUONG_DUNG_DANG_DUNG = "DUONG_DUNG_DANG_DUNG";
        public const string TUYEN_SU_DUNG_5 = "TUYEN_SU_DUNG_5";
        public const string TUYEN_SU_DUNG_6 = "TUYEN_SU_DUNG_6";
        public const string TUYEN_SU_DUNG_7 = "TUYEN_SU_DUNG_7";
        public const string TUYEN_SU_DUNG_8 = "TUYEN_SU_DUNG_8";
        public const string TEN_NHOM = "TEN_NHOM";
        public const string TEN_DANH_MUC = "TEN_DANH_MUC";
    }
    public class V_GD_GIA
    {
        public const string ID = "ID";
        public const string NGAY_AP_DUNG = "NGAY_AP_DUNG";
        public const string ID_DON_VI_GIA = "ID_DON_VI_GIA";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string ID_THUOC = "ID_THUOC";
        public const string GIA = "GIA";
        public const string TEN_THUOC = "TEN_THUOC";
        public const string TRANG_THAI_SU_DUNG = "TRANG_THAI_SU_DUNG";
        public const string DON_VI_TINH = "DON_VI_TINH";
    }

    public class GD_DON_VI_TINH_THUOC
    {
        public const string ID = "ID";
        public const string MA_DON_VI = "MA_DON_VI";
        public const string TEN_DON_VI = "TEN_DON_VI";
        public const string NGAY_AP_DUNG = "NGAY_AP_DUNG";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string ID_NGUOI_THEM = "ID_NGUOI_THEM";
        public const string ID_DON_VI_CHA = "ID_DON_VI_CHA";
        public const string QUY_DOI = "QUY_DOI";
        public const string ID_NHOM_DON_VI_TINH = "ID_NHOM_DON_VI_TINH";
    }
    public class V_DM_DON_VI_TINH
    {
        public const string ID = "ID";
        public const string TEN_NHOM = "TEN_NHOM";
        public const string MA_NHOM = "MA_NHOM";
        public const string ID_NGUOI_LAP = "ID_NGUOI_LAP";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string NGAY_LAP = "NGAY_LAP";
        public const string TEN = "TEN";
        public const string TRANG_THAI = "TRANG_THAI";
        public const string ID_LOAI_TU_DIEN = "ID_LOAI_TU_DIEN";
        public const string ID_NGUOI_SU_DUNG = "ID_NGUOI_SU_DUNG";
        public const string ID_TU_DIEN = "ID_TU_DIEN";
    }
    public class V_DM_DON_VI
    {
        public const string ID = "ID";
        public const string MA_VIET_TAT = "MA_VIET_TAT";
        public const string TEN_DAY_DU = "TEN_DAY_DU";
        public const string MA_SO_THUE = "MA_SO_THUE";
        public const string DIA_CHI = "DIA_CHI";
        public const string GHI_CHU_1 = "GHI_CHU_1";
        public const string GHI_CHU_2 = "GHI_CHU_2";
        public const string GHI_CHU_3 = "GHI_CHU_3";
        public const string ID_DON_VI_CAP_TREN = "ID_DON_VI_CAP_TREN";
        public const string ID_LOAI_DON_VI = "ID_LOAI_DON_VI";
        public const string ID_TU_DIEN = "ID_TU_DIEN";
        public const string ID_LOAI_TU_DIEN = "ID_LOAI_TU_DIEN";
        public const string TEN = "TEN";
        public const string ID_DV_CAP_TREN = "ID_DV_CAP_TREN";
        public const string MA_VIET_TAT_DV_CAP_TREN = "MA_VIET_TAT_DV_CAP_TREN";
    }

    public class V_GD_GIA_2
    {
        public const string ID = "ID";
        public const string NGAY_AP_DUNG = "NGAY_AP_DUNG";
        public const string ID_DON_VI_GIA = "ID_DON_VI_GIA";
        public const string ID_TRANG_THAI = "ID_TRANG_THAI";
        public const string ID_THUOC = "ID_THUOC";
        public const string GIA = "GIA";
        public const string ID_DON_VI_TINH = "ID_DON_VI_TINH";
        public const string TEN_THUOC = "TEN_THUOC";
        public const string TEN = "TEN";
        public const string TEN_DON_VI_GIA = "TEN_DON_VI_GIA";
        public const string TEN_DON_VI_TINH = "TEN_DON_VI_TINH";
    }
}
