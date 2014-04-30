///************************************************
/// Generated by: VinhNQ
/// Date: 30/04/2014 11:13:18
/// Goal: Create User Service Class for V_GD_GIA_BAN
///************************************************
/// <summary>
/// Create User Service Class for V_GD_GIA_BAN
/// </summary>

using System;
using BKI_QLHT.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLHT{

public class US_V_GD_GIA_BAN : US_Object
{
	private const string c_TableName = "V_GD_GIA_BAN";
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

#endregion
#region "Init Functions"
	public US_V_GD_GIA_BAN() 
	{
		pm_objDS = new DS_V_GD_GIA_BAN();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_GIA_BAN(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_GIA_BAN(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_GIA_BAN();
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
