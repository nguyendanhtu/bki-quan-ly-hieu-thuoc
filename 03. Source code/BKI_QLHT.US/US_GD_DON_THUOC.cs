///************************************************
/// Generated by: DungNT
/// Date: 31/03/2014 02:44:00
/// Goal: Create User Service Class for GD_DON_THUOC
///************************************************
/// <summary>
/// Create User Service Class for GD_DON_THUOC
/// </summary>

using System;
using BKI_QLHT.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLHT.US{

public class US_GD_DON_THUOC : US_Object
{
	private const string c_TableName = "GD_DON_THUOC";
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

	public string strTEN_DON_THUOC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_DON_THUOC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_DON_THUOC"] = value;
		}
	}

	public bool IsTEN_DON_THUOCNull() 
	{
		return pm_objDR.IsNull("TEN_DON_THUOC");
	}

	public void SetTEN_DON_THUOCNull() {
		pm_objDR["TEN_DON_THUOC"] = System.Convert.DBNull;
	}

	public string strMA_DON_THUOC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_DON_THUOC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_DON_THUOC"] = value;
		}
	}

	public bool IsMA_DON_THUOCNull() 
	{
		return pm_objDR.IsNull("MA_DON_THUOC");
	}

	public void SetMA_DON_THUOCNull() {
		pm_objDR["MA_DON_THUOC"] = System.Convert.DBNull;
	}

	public string strMO_TA 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MO_TA", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MO_TA"] = value;
		}
	}

	public bool IsMO_TANull() 
	{
		return pm_objDR.IsNull("MO_TA");
	}

	public void SetMO_TANull() {
		pm_objDR["MO_TA"] = System.Convert.DBNull;
	}

	public string strGHI_CHU_DON_THUOC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU_DON_THUOC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU_DON_THUOC"] = value;
		}
	}

	public bool IsGHI_CHU_DON_THUOCNull() 
	{
		return pm_objDR.IsNull("GHI_CHU_DON_THUOC");
	}

	public void SetGHI_CHU_DON_THUOCNull() {
		pm_objDR["GHI_CHU_DON_THUOC"] = System.Convert.DBNull;
	}

	public string strDI_UNG_THUOC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DI_UNG_THUOC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DI_UNG_THUOC"] = value;
		}
	}

	public bool IsDI_UNG_THUOCNull() 
	{
		return pm_objDR.IsNull("DI_UNG_THUOC");
	}

	public void SetDI_UNG_THUOCNull() {
		pm_objDR["DI_UNG_THUOC"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_SU_DUNG
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_SU_DUNG", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_SU_DUNG"] = value;
		}
	}

	public bool IsNGAY_SU_DUNGNull()
	{
		return pm_objDR.IsNull("NGAY_SU_DUNG");
	}

	public void SetNGAY_SU_DUNGNull()
	{
		pm_objDR["NGAY_SU_DUNG"] = System.Convert.DBNull;
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

#endregion
#region "Init Functions"
	public US_GD_DON_THUOC() 
	{
		pm_objDS = new DS_GD_DON_THUOC();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_GD_DON_THUOC(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_GD_DON_THUOC(decimal i_dbID) 
	{
		pm_objDS = new DS_GD_DON_THUOC();
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