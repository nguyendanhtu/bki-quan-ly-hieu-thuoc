///************************************************
/// Generated by: TuNA
/// Date: 30-04-2014 11:53:20
/// Goal: Create User Service Class for V_DM_NHASX
///************************************************
/// <summary>
/// Create User Service Class for V_DM_NHASX
/// </summary>

using System;
using BKI_QLHT.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BKI_QLHT.DS;


namespace BKI_QLHT.US{

public class US_V_DM_NHASX : US_Object
{
	private const string c_TableName = "V_DM_NHASX";
#region "Public Properties"
	public decimal dcID_LOAI_DM 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_DM", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_DM"] = value;
		}
	}

	public bool IsID_LOAI_DMNull()	{
		return pm_objDR.IsNull("ID_LOAI_DM");
	}

	public void SetID_LOAI_DMNull() {
		pm_objDR["ID_LOAI_DM"] = System.Convert.DBNull;
	}

	public string strTEN_NHASX 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_NHASX", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_NHASX"] = value;
		}
	}

	public bool IsTEN_NHASXNull() 
	{
		return pm_objDR.IsNull("TEN_NHASX");
	}

	public void SetTEN_NHASXNull() {
		pm_objDR["TEN_NHASX"] = System.Convert.DBNull;
	}

	public string strMA_NHASX 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_NHASX", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_NHASX"] = value;
		}
	}

	public bool IsMA_NHASXNull() 
	{
		return pm_objDR.IsNull("MA_NHASX");
	}

	public void SetMA_NHASXNull() {
		pm_objDR["MA_NHASX"] = System.Convert.DBNull;
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
	public US_V_DM_NHASX() 
	{
		pm_objDS = new DS_V_DM_NHASX();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_NHASX(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_NHASX(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_NHASX();
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