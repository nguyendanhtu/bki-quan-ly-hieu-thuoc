///************************************************
/// Generated by: TuNA
/// Date: 12-05-2014 11:52:41
/// Goal: Create User Service Class for V_BAO_CAO_DOANH_THU_THEO_NCC_0
///************************************************
/// <summary>
/// Create User Service Class for V_BAO_CAO_DOANH_THU_THEO_NCC_0
/// </summary>

using System;
using BKI_QLHT;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BKI_QLHT.DS;


namespace BKI_QLHT.US{

public class US_V_BAO_CAO_DOANH_THU_THEO_NCC_0 : US_Object
{
	private const string c_TableName = "V_BAO_CAO_DOANH_THU_THEO_NCC_0";
#region "Public Properties"
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

	public string strTEN_NCC 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_NCC", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_NCC"] = value;
		}
	}

	public bool IsTEN_NCCNull() 
	{
		return pm_objDR.IsNull("TEN_NCC");
	}

	public void SetTEN_NCCNull() {
		pm_objDR["TEN_NCC"] = System.Convert.DBNull;
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
	public US_V_BAO_CAO_DOANH_THU_THEO_NCC_0() 
	{
		pm_objDS = new DS_V_BAO_CAO_DOANH_THU_THEO_NCC_0();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_BAO_CAO_DOANH_THU_THEO_NCC_0(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_BAO_CAO_DOANH_THU_THEO_NCC_0(decimal i_dbID) 
	{
		pm_objDS = new DS_V_BAO_CAO_DOANH_THU_THEO_NCC_0();
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
