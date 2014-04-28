///************************************************
/// Generated by: VinhNQ
/// Date: 28/04/2014 02:32:43
/// Goal: Create User Service Class for V_GD_GIA_2
///************************************************
/// <summary>
/// Create User Service Class for V_GD_GIA_2
/// </summary>

using System;
using BKI_QLHT.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLHT{

public class US_V_GD_GIA_2 : US_Object
{
	private const string c_TableName = "V_GD_GIA_2";
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

	public DateTime datNGAY_AP_DUNG
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_AP_DUNG", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_AP_DUNG"] = value;
		}
	}

	public bool IsNGAY_AP_DUNGNull()
	{
		return pm_objDR.IsNull("NGAY_AP_DUNG");
	}

	public void SetNGAY_AP_DUNGNull()
	{
		pm_objDR["NGAY_AP_DUNG"] = System.Convert.DBNull;
	}

	public decimal dcID_DON_VI_GIA 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_GIA", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DON_VI_GIA"] = value;
		}
	}

	public bool IsID_DON_VI_GIANull()	{
		return pm_objDR.IsNull("ID_DON_VI_GIA");
	}

	public void SetID_DON_VI_GIANull() {
		pm_objDR["ID_DON_VI_GIA"] = System.Convert.DBNull;
	}

	public decimal dcID_TRANG_THAI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_TRANG_THAI"] = value;
		}
	}

	public bool IsID_TRANG_THAINull()	{
		return pm_objDR.IsNull("ID_TRANG_THAI");
	}

	public void SetID_TRANG_THAINull() {
		pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
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

	public decimal dcID_DON_VI_TINH 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_TINH", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DON_VI_TINH"] = value;
		}
	}

	public bool IsID_DON_VI_TINHNull()	{
		return pm_objDR.IsNull("ID_DON_VI_TINH");
	}

	public void SetID_DON_VI_TINHNull() {
		pm_objDR["ID_DON_VI_TINH"] = System.Convert.DBNull;
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

	public string strTEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN"] = value;
		}
	}

	public bool IsTENNull() 
	{
		return pm_objDR.IsNull("TEN");
	}

	public void SetTENNull() {
		pm_objDR["TEN"] = System.Convert.DBNull;
	}

	public string strTEN_DON_VI_GIA 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_DON_VI_GIA", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_DON_VI_GIA"] = value;
		}
	}

	public bool IsTEN_DON_VI_GIANull() 
	{
		return pm_objDR.IsNull("TEN_DON_VI_GIA");
	}

	public void SetTEN_DON_VI_GIANull() {
		pm_objDR["TEN_DON_VI_GIA"] = System.Convert.DBNull;
	}

	public string strTEN_DON_VI_TINH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_DON_VI_TINH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_DON_VI_TINH"] = value;
		}
	}

	public bool IsTEN_DON_VI_TINHNull() 
	{
		return pm_objDR.IsNull("TEN_DON_VI_TINH");
	}

	public void SetTEN_DON_VI_TINHNull() {
		pm_objDR["TEN_DON_VI_TINH"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_GD_GIA_2() 
	{
		pm_objDS = new DS_V_GD_GIA_2();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_GIA_2(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_GIA_2(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_GIA_2();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillDatasetSearch(DS_V_GD_GIA_2 ip_ds_v_gd_gia, string ip_str_tu_khoa)
    {
        CStoredProc v_sp = new CStoredProc("pr_V_GD_GIA_2_Search");
        v_sp.addNVarcharInputParam("@TU_KHOA", ip_ds_v_gd_gia);
        v_sp.fillDataSetByCommand(this,ip_ds_v_gd_gia);
    }
}
}
