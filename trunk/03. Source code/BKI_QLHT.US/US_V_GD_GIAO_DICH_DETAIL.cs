///************************************************
/// Generated by: HuyTD
/// Date: 01/05/2014 02:17:47
/// Goal: Create User Service Class for V_GD_GIAO_DICH_DETAIL
///************************************************
/// <summary>
/// Create User Service Class for V_GD_GIAO_DICH_DETAIL
/// </summary>

using System;
using BKI_QLHT;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BKI_QLHT.DS;


namespace BKI_QLHT.US{

public class US_V_GD_GIAO_DICH_DETAIL : US_Object
{
	private const string c_TableName = "V_GD_GIAO_DICH_DETAIL";
#region "Public Properties"
	public decimal dcID 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID"] = value;
		}
	}

	public bool IsIDNull()	{
		return pm_objDR.IsNull("ID");
	}

	public void SetIDNull() {
		pm_objDR["ID"] = System.Convert.DBNull;
	}

	public decimal dcID_GIAO_DICH 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_GIAO_DICH", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_GIAO_DICH"] = value;
		}
	}

	public bool IsID_GIAO_DICHNull()	{
		return pm_objDR.IsNull("ID_GIAO_DICH");
	}

	public void SetID_GIAO_DICHNull() {
		pm_objDR["ID_GIAO_DICH"] = System.Convert.DBNull;
	}

	public decimal dcID_THUOC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_THUOC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_THUOC"] = value;
		}
	}

	public bool IsID_THUOCNull()	{
		return pm_objDR.IsNull("ID_THUOC");
	}

	public void SetID_THUOCNull() {
		pm_objDR["ID_THUOC"] = System.Convert.DBNull;
	}

	public decimal dcID_DON_VI_THUOC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_THUOC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DON_VI_THUOC"] = value;
		}
	}

	public bool IsID_DON_VI_THUOCNull()	{
		return pm_objDR.IsNull("ID_DON_VI_THUOC");
	}

	public void SetID_DON_VI_THUOCNull() {
		pm_objDR["ID_DON_VI_THUOC"] = System.Convert.DBNull;
	}

	public decimal dcSO_LUONG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_LUONG"] = value;
		}
	}

	public bool IsSO_LUONGNull()	{
		return pm_objDR.IsNull("SO_LUONG");
	}

	public void SetSO_LUONGNull() {
		pm_objDR["SO_LUONG"] = System.Convert.DBNull;
	}

	public decimal dcID_NHA_CUNG_CAP 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NHA_CUNG_CAP", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NHA_CUNG_CAP"] = value;
		}
	}

	public bool IsID_NHA_CUNG_CAPNull()	{
		return pm_objDR.IsNull("ID_NHA_CUNG_CAP");
	}

	public void SetID_NHA_CUNG_CAPNull() {
		pm_objDR["ID_NHA_CUNG_CAP"] = System.Convert.DBNull;
	}

	public decimal dcID_NUOC_SX 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NUOC_SX", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NUOC_SX"] = value;
		}
	}

	public bool IsID_NUOC_SXNull()	{
		return pm_objDR.IsNull("ID_NUOC_SX");
	}

	public void SetID_NUOC_SXNull() {
		pm_objDR["ID_NUOC_SX"] = System.Convert.DBNull;
	}

	public decimal dcID_HANG_SX 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_HANG_SX", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_HANG_SX"] = value;
		}
	}

	public bool IsID_HANG_SXNull()	{
		return pm_objDR.IsNull("ID_HANG_SX");
	}

	public void SetID_HANG_SXNull() {
		pm_objDR["ID_HANG_SX"] = System.Convert.DBNull;
	}

	public DateTime datHAN_SU_DUNG
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "HAN_SU_DUNG", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["HAN_SU_DUNG"] = value;
		}
	}

	public bool IsHAN_SU_DUNGNull()
	{
		return pm_objDR.IsNull("HAN_SU_DUNG");
	}

	public void SetHAN_SU_DUNGNull()
	{
		pm_objDR["HAN_SU_DUNG"] = System.Convert.DBNull;
	}

	public decimal dcGIA 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "GIA", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["GIA"] = value;
		}
	}

	public bool IsGIANull()	{
		return pm_objDR.IsNull("GIA");
	}

	public void SetGIANull() {
		pm_objDR["GIA"] = System.Convert.DBNull;
	}

	public decimal dcID_DM_THUOC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DM_THUOC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DM_THUOC"] = value;
		}
	}

	public bool IsID_DM_THUOCNull()	{
		return pm_objDR.IsNull("ID_DM_THUOC");
	}

	public void SetID_DM_THUOCNull() {
		pm_objDR["ID_DM_THUOC"] = System.Convert.DBNull;
	}

	public string strTEN_THUOC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_THUOC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_THUOC"] = value;
		}
	}

	public bool IsTEN_THUOCNull() 
	{
		return pm_objDR.IsNull("TEN_THUOC");
	}

	public void SetTEN_THUOCNull() {
		pm_objDR["TEN_THUOC"] = System.Convert.DBNull;
	}

	public decimal dcID_DON_VI_TINH_THUOC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_TINH_THUOC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DON_VI_TINH_THUOC"] = value;
		}
	}

	public bool IsID_DON_VI_TINH_THUOCNull()	{
		return pm_objDR.IsNull("ID_DON_VI_TINH_THUOC");
	}

	public void SetID_DON_VI_TINH_THUOCNull() {
		pm_objDR["ID_DON_VI_TINH_THUOC"] = System.Convert.DBNull;
	}

	public string strTEN_DON_VI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_DON_VI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_DON_VI"] = value;
		}
	}

	public bool IsTEN_DON_VINull() 
	{
		return pm_objDR.IsNull("TEN_DON_VI");
	}

	public void SetTEN_DON_VINull() {
		pm_objDR["TEN_DON_VI"] = System.Convert.DBNull;
	}

	public decimal dcID_GD_GIA_BAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_GD_GIA_BAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_GD_GIA_BAN"] = value;
		}
	}

	public bool IsID_GD_GIA_BANNull()	{
		return pm_objDR.IsNull("ID_GD_GIA_BAN");
	}

	public void SetID_GD_GIA_BANNull() {
		pm_objDR["ID_GD_GIA_BAN"] = System.Convert.DBNull;
	}

	public decimal dcGIA_BAN_ID_DM_THUOC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "GIA_BAN_ID_DM_THUOC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["GIA_BAN_ID_DM_THUOC"] = value;
		}
	}

	public bool IsGIA_BAN_ID_DM_THUOCNull()	{
		return pm_objDR.IsNull("GIA_BAN_ID_DM_THUOC");
	}

	public void SetGIA_BAN_ID_DM_THUOCNull() {
		pm_objDR["GIA_BAN_ID_DM_THUOC"] = System.Convert.DBNull;
	}

	public decimal dcGIA_BAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "GIA_BAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["GIA_BAN"] = value;
		}
	}

	public bool IsGIA_BANNull()	{
		return pm_objDR.IsNull("GIA_BAN");
	}

	public void SetGIA_BANNull() {
		pm_objDR["GIA_BAN"] = System.Convert.DBNull;
	}

	public decimal dcID_GD_GIAO_DICH 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_GD_GIAO_DICH", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_GD_GIAO_DICH"] = value;
		}
	}

	public bool IsID_GD_GIAO_DICHNull()	{
		return pm_objDR.IsNull("ID_GD_GIAO_DICH");
	}

	public void SetID_GD_GIAO_DICHNull() {
		pm_objDR["ID_GD_GIAO_DICH"] = System.Convert.DBNull;
	}

	public string strMA_GIAO_DICH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_GIAO_DICH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_GIAO_DICH"] = value;
		}
	}

	public bool IsMA_GIAO_DICHNull() 
	{
		return pm_objDR.IsNull("MA_GIAO_DICH");
	}

	public void SetMA_GIAO_DICHNull() {
		pm_objDR["MA_GIAO_DICH"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_GIAO_DICH
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_GIAO_DICH", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_GIAO_DICH"] = value;
		}
	}

	public bool IsNGAY_GIAO_DICHNull()
	{
		return pm_objDR.IsNull("NGAY_GIAO_DICH");
	}

	public void SetNGAY_GIAO_DICHNull()
	{
		pm_objDR["NGAY_GIAO_DICH"] = System.Convert.DBNull;
	}

	public decimal dcID_KHACH_HANG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_KHACH_HANG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_KHACH_HANG"] = value;
		}
	}

	public bool IsID_KHACH_HANGNull()	{
		return pm_objDR.IsNull("ID_KHACH_HANG");
	}

	public void SetID_KHACH_HANGNull() {
		pm_objDR["ID_KHACH_HANG"] = System.Convert.DBNull;
	}

	public decimal dcID_LOAI_GIAO_DICH 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_GIAO_DICH", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_GIAO_DICH"] = value;
		}
	}

	public bool IsID_LOAI_GIAO_DICHNull()	{
		return pm_objDR.IsNull("ID_LOAI_GIAO_DICH");
	}

	public void SetID_LOAI_GIAO_DICHNull() {
		pm_objDR["ID_LOAI_GIAO_DICH"] = System.Convert.DBNull;
	}

	public decimal dcID_BAC_SY 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_BAC_SY", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_BAC_SY"] = value;
		}
	}

	public bool IsID_BAC_SYNull()	{
		return pm_objDR.IsNull("ID_BAC_SY");
	}

	public void SetID_BAC_SYNull() {
		pm_objDR["ID_BAC_SY"] = System.Convert.DBNull;
	}

	public decimal dcTI_LE_CHIET_KHAU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TI_LE_CHIET_KHAU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TI_LE_CHIET_KHAU"] = value;
		}
	}

	public bool IsTI_LE_CHIET_KHAUNull()	{
		return pm_objDR.IsNull("TI_LE_CHIET_KHAU");
	}

	public void SetTI_LE_CHIET_KHAUNull() {
		pm_objDR["TI_LE_CHIET_KHAU"] = System.Convert.DBNull;
	}

	public decimal dcID_DM_BAC_SY 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DM_BAC_SY", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DM_BAC_SY"] = value;
		}
	}

	public bool IsID_DM_BAC_SYNull()	{
		return pm_objDR.IsNull("ID_DM_BAC_SY");
	}

	public void SetID_DM_BAC_SYNull() {
		pm_objDR["ID_DM_BAC_SY"] = System.Convert.DBNull;
	}

	public string strHO_TEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_TEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_TEN"] = value;
		}
	}

	public bool IsHO_TENNull() 
	{
		return pm_objDR.IsNull("HO_TEN");
	}

	public void SetHO_TENNull() {
		pm_objDR["HO_TEN"] = System.Convert.DBNull;
	}

	public decimal dcID_DM_KHACH_HANG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DM_KHACH_HANG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DM_KHACH_HANG"] = value;
		}
	}

	public bool IsID_DM_KHACH_HANGNull()	{
		return pm_objDR.IsNull("ID_DM_KHACH_HANG");
	}

	public void SetID_DM_KHACH_HANGNull() {
		pm_objDR["ID_DM_KHACH_HANG"] = System.Convert.DBNull;
	}

	public string strTEN_KHACH_HANG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_KHACH_HANG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_KHACH_HANG"] = value;
		}
	}

	public bool IsTEN_KHACH_HANGNull() 
	{
		return pm_objDR.IsNull("TEN_KHACH_HANG");
	}

	public void SetTEN_KHACH_HANGNull() {
		pm_objDR["TEN_KHACH_HANG"] = System.Convert.DBNull;
	}

	public string strDIA_CHI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DIA_CHI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DIA_CHI"] = value;
		}
	}

	public bool IsDIA_CHINull() 
	{
		return pm_objDR.IsNull("DIA_CHI");
	}

	public void SetDIA_CHINull() {
		pm_objDR["DIA_CHI"] = System.Convert.DBNull;
	}

	public string strSDT 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "SDT", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["SDT"] = value;
		}
	}

	public bool IsSDTNull() 
	{
		return pm_objDR.IsNull("SDT");
	}

	public void SetSDTNull() {
		pm_objDR["SDT"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_GD_GIAO_DICH_DETAIL() 
	{
		pm_objDS = new DS_V_GD_GIAO_DICH_DETAIL();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_GIAO_DICH_DETAIL(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_GIAO_DICH_DETAIL(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_GIAO_DICH_DETAIL();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion
	}
}
