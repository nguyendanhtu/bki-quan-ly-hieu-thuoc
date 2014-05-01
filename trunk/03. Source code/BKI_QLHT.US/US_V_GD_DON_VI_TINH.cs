///************************************************
/// Generated by: ThaiPH
/// Date: 01/05/2014 12:32:51
/// Goal: Create User Service Class for V_GD_DON_VI_TINH
///************************************************
/// <summary>
/// Create User Service Class for V_GD_DON_VI_TINH
/// </summary>

using System;
using BKI_QLHT;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BKI_QLHT.DS;


namespace BKI_QLHT.US{

public class US_V_GD_DON_VI_TINH : US_Object
{
	private const string c_TableName = "V_GD_DON_VI_TINH";
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

	public decimal dcID_DON_VI_CHA 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_CHA", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DON_VI_CHA"] = value;
		}
	}

	public bool IsID_DON_VI_CHANull()	{
		return pm_objDR.IsNull("ID_DON_VI_CHA");
	}

	public void SetID_DON_VI_CHANull() {
		pm_objDR["ID_DON_VI_CHA"] = System.Convert.DBNull;
	}

	public decimal dcQUY_DOI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "QUY_DOI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["QUY_DOI"] = value;
		}
	}

	public bool IsQUY_DOINull()	{
		return pm_objDR.IsNull("QUY_DOI");
	}

	public void SetQUY_DOINull() {
		pm_objDR["QUY_DOI"] = System.Convert.DBNull;
	}

	public decimal dcID_NHOM_DON_VI_TINH 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NHOM_DON_VI_TINH", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NHOM_DON_VI_TINH"] = value;
		}
	}

	public bool IsID_NHOM_DON_VI_TINHNull()	{
		return pm_objDR.IsNull("ID_NHOM_DON_VI_TINH");
	}

	public void SetID_NHOM_DON_VI_TINHNull() {
		pm_objDR["ID_NHOM_DON_VI_TINH"] = System.Convert.DBNull;
	}

	public decimal dcExpr1 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "Expr1", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["Expr1"] = value;
		}
	}

	public bool IsExpr1Null()	{
		return pm_objDR.IsNull("Expr1");
	}

	public void SetExpr1Null() {
		pm_objDR["Expr1"] = System.Convert.DBNull;
	}

	public string strMA_NHOM 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_NHOM", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_NHOM"] = value;
		}
	}

	public bool IsMA_NHOMNull() 
	{
		return pm_objDR.IsNull("MA_NHOM");
	}

	public void SetMA_NHOMNull() {
		pm_objDR["MA_NHOM"] = System.Convert.DBNull;
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

	public DateTime datNGAY_LAP
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_LAP", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_LAP"] = value;
		}
	}

	public bool IsNGAY_LAPNull()
	{
		return pm_objDR.IsNull("NGAY_LAP");
	}

	public void SetNGAY_LAPNull()
	{
		pm_objDR["NGAY_LAP"] = System.Convert.DBNull;
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

#endregion
#region "Init Functions"
	public US_V_GD_DON_VI_TINH() 
	{
		pm_objDS = new DS_V_GD_DON_VI_TINH();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_GD_DON_VI_TINH(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_GD_DON_VI_TINH(decimal i_dbID) 
	{
		pm_objDS = new DS_V_GD_DON_VI_TINH();
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
