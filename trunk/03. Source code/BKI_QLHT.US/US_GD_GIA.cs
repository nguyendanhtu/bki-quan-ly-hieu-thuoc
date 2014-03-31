///************************************************
/// Generated by: DungNT
/// Date: 31/03/2014 02:44:55
/// Goal: Create User Service Class for GD_GIA
///************************************************
/// <summary>
/// Create User Service Class for GD_GIA
/// </summary>

using System;
using BKI_QLHT.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLHT.US{

public class US_GD_GIA : US_Object
{
	private const string c_TableName = "GD_GIA";
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

	public string strTEST 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEST", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEST"] = value;
		}
	}

	public bool IsTESTNull() 
	{
		return pm_objDR.IsNull("TEST");
	}

	public void SetTESTNull() {
		pm_objDR["TEST"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_GD_GIA() 
	{
		pm_objDS = new DS_GD_GIA();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_GIA(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_GIA(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_GIA();
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
