///************************************************
/// Generated by: TuNA
/// Date: 02-05-2014 03:14:30
/// Goal: Create User Service Class for V_BAO_CAO_DANH_MUC_THUOC_THEO_NSX
///************************************************
/// <summary>
/// Create User Service Class for V_BAO_CAO_DANH_MUC_THUOC_THEO_NSX
/// </summary>

using System;
using BKI_QLHT;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BKI_QLHT.DS;


namespace BKI_QLHT.US
{

public class US_V_BAO_CAO_DANH_MUC_THUOC_THEO_NSX : US_Object
{
	private const string c_TableName = "V_BAO_CAO_DANH_MUC_THUOC_THEO_NSX";
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

	public decimal dcTT_HOAT_CHAT 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TT_HOAT_CHAT", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TT_HOAT_CHAT"] = value;
		}
	}

	public bool IsTT_HOAT_CHATNull()	{
		return pm_objDR.IsNull("TT_HOAT_CHAT");
	}

	public void SetTT_HOAT_CHATNull() {
		pm_objDR["TT_HOAT_CHAT"] = System.Convert.DBNull;
	}

	public decimal dcTT_THUOC 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TT_THUOC", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TT_THUOC"] = value;
		}
	}

	public bool IsTT_THUOCNull()	{
		return pm_objDR.IsNull("TT_THUOC");
	}

	public void SetTT_THUOCNull() {
		pm_objDR["TT_THUOC"] = System.Convert.DBNull;
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

	public string strDUONG_DUNG_DANG_DUNG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DUONG_DUNG_DANG_DUNG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DUONG_DUNG_DANG_DUNG"] = value;
		}
	}

	public bool IsDUONG_DUNG_DANG_DUNGNull() 
	{
		return pm_objDR.IsNull("DUONG_DUNG_DANG_DUNG");
	}

	public void SetDUONG_DUNG_DANG_DUNGNull() {
		pm_objDR["DUONG_DUNG_DANG_DUNG"] = System.Convert.DBNull;
	}

	public string strTUYEN_SU_DUNG_5 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TUYEN_SU_DUNG_5", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TUYEN_SU_DUNG_5"] = value;
		}
	}

	public bool IsTUYEN_SU_DUNG_5Null() 
	{
		return pm_objDR.IsNull("TUYEN_SU_DUNG_5");
	}

	public void SetTUYEN_SU_DUNG_5Null() {
		pm_objDR["TUYEN_SU_DUNG_5"] = System.Convert.DBNull;
	}

	public string strTUYEN_SU_DUNG_6 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TUYEN_SU_DUNG_6", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TUYEN_SU_DUNG_6"] = value;
		}
	}

	public bool IsTUYEN_SU_DUNG_6Null() 
	{
		return pm_objDR.IsNull("TUYEN_SU_DUNG_6");
	}

	public void SetTUYEN_SU_DUNG_6Null() {
		pm_objDR["TUYEN_SU_DUNG_6"] = System.Convert.DBNull;
	}

	public string strTUYEN_SU_DUNG_7 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TUYEN_SU_DUNG_7", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TUYEN_SU_DUNG_7"] = value;
		}
	}

	public bool IsTUYEN_SU_DUNG_7Null() 
	{
		return pm_objDR.IsNull("TUYEN_SU_DUNG_7");
	}

	public void SetTUYEN_SU_DUNG_7Null() {
		pm_objDR["TUYEN_SU_DUNG_7"] = System.Convert.DBNull;
	}

	public string strTUYEN_SU_DUNG_8 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TUYEN_SU_DUNG_8", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TUYEN_SU_DUNG_8"] = value;
		}
	}

	public bool IsTUYEN_SU_DUNG_8Null() 
	{
		return pm_objDR.IsNull("TUYEN_SU_DUNG_8");
	}

	public void SetTUYEN_SU_DUNG_8Null() {
		pm_objDR["TUYEN_SU_DUNG_8"] = System.Convert.DBNull;
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

	public string strMA_NUOC_SAN_XUAT 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_NUOC_SAN_XUAT", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_NUOC_SAN_XUAT"] = value;
		}
	}

	public bool IsMA_NUOC_SAN_XUATNull() 
	{
		return pm_objDR.IsNull("MA_NUOC_SAN_XUAT");
	}

	public void SetMA_NUOC_SAN_XUATNull() {
		pm_objDR["MA_NUOC_SAN_XUAT"] = System.Convert.DBNull;
	}

	public string strTEN_NUOC_SAN_XUAT 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_NUOC_SAN_XUAT", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_NUOC_SAN_XUAT"] = value;
		}
	}

	public bool IsTEN_NUOC_SAN_XUATNull() 
	{
		return pm_objDR.IsNull("TEN_NUOC_SAN_XUAT");
	}

	public void SetTEN_NUOC_SAN_XUATNull() {
		pm_objDR["TEN_NUOC_SAN_XUAT"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
    public void FillDatasetSearch(DS_V_BAO_CAO_DANH_MUC_THUOC_THEO_NSX ip_ds, string ip_str_search)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_V_BAO_CAO_DANH_MUC_THUOC_THEO_NSX_search");
        v_store_proc.addNVarcharInputParam("@STR_SEARCH", ip_str_search);
        v_store_proc.fillDataSetByCommand(this, ip_ds);
    }
	public US_V_BAO_CAO_DANH_MUC_THUOC_THEO_NSX() 
	{
		pm_objDS = new DS_V_BAO_CAO_DANH_MUC_THUOC_THEO_NSX();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_BAO_CAO_DANH_MUC_THUOC_THEO_NSX(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_BAO_CAO_DANH_MUC_THUOC_THEO_NSX(decimal i_dbID) 
	{
		pm_objDS = new DS_V_BAO_CAO_DANH_MUC_THUOC_THEO_NSX();
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
