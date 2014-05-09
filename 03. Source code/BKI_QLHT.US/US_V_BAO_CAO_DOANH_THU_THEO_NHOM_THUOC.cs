///************************************************
/// Generated by: TuNA
/// Date: 09-05-2014 03:50:43
/// Goal: Create User Service Class for V_BAO_CAO_DOANH_THU_THEO_NHOM_THUOC
///************************************************
/// <summary>
/// Create User Service Class for V_BAO_CAO_DOANH_THU_THEO_NHOM_THUOC
/// </summary>

using System;
using BKI_QLHT;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BKI_QLHT.DS;


namespace BKI_QLHT.US{

public class US_V_BAO_CAO_DOANH_THU_THEO_NHOM_THUOC : US_Object
{
	private const string c_TableName = "V_BAO_CAO_DOANH_THU_THEO_NHOM_THUOC";
#region "Public Properties"
	public string strTEN_NHOM 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_NHOM", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_NHOM"] = value;
		}
	}

	public bool IsTEN_NHOMNull() 
	{
		return pm_objDR.IsNull("TEN_NHOM");
	}

	public void SetTEN_NHOMNull() {
		pm_objDR["TEN_NHOM"] = System.Convert.DBNull;
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

	public decimal dcSO_LUONG_BAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "SO_LUONG_BAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["SO_LUONG_BAN"] = value;
		}
	}

	public bool IsSO_LUONG_BANNull()	{
		return pm_objDR.IsNull("SO_LUONG_BAN");
	}

	public void SetSO_LUONG_BANNull() {
		pm_objDR["SO_LUONG_BAN"] = System.Convert.DBNull;
	}

	public decimal dcDOANH_THU 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "DOANH_THU", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["DOANH_THU"] = value;
		}
	}

	public bool IsDOANH_THUNull()	{
		return pm_objDR.IsNull("DOANH_THU");
	}

	public void SetDOANH_THUNull() {
		pm_objDR["DOANH_THU"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_BAO_CAO_DOANH_THU_THEO_NHOM_THUOC() 
	{
		pm_objDS = new DS_V_BAO_CAO_DOANH_THU_THEO_NHOM_THUOC();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_BAO_CAO_DOANH_THU_THEO_NHOM_THUOC(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_BAO_CAO_DOANH_THU_THEO_NHOM_THUOC(decimal i_dbID) 
	{
		pm_objDS = new DS_V_BAO_CAO_DOANH_THU_THEO_NHOM_THUOC();
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