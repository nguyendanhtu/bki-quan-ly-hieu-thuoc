///************************************************
/// Generated by: VinhNQ
/// Date: 01/04/2014 08:02:15
/// Goal: Create User Service Class for V_DM_KHACH_HANG
///************************************************
/// <summary>
/// Create User Service Class for V_DM_KHACH_HANG
/// </summary>

using System;
using BKI_QLHT.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLHT{

public class US_V_DM_KHACH_HANG : US_Object
{
	private const string c_TableName = "V_DM_KHACH_HANG";
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

	public string strMA_KHACH_HANG 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_KHACH_HANG", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_KHACH_HANG"] = value;
		}
	}

	public bool IsMA_KHACH_HANGNull() 
	{
		return pm_objDR.IsNull("MA_KHACH_HANG");
	}

	public void SetMA_KHACH_HANGNull() {
		pm_objDR["MA_KHACH_HANG"] = System.Convert.DBNull;
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

	public decimal dcID_NHOM_KHACH_HANG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NHOM_KHACH_HANG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NHOM_KHACH_HANG"] = value;
		}
	}

	public bool IsID_NHOM_KHACH_HANGNull()	{
		return pm_objDR.IsNull("ID_NHOM_KHACH_HANG");
	}

	public void SetID_NHOM_KHACH_HANGNull() {
		pm_objDR["ID_NHOM_KHACH_HANG"] = System.Convert.DBNull;
	}

	public string strMA_SO_THUE 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_SO_THUE", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_SO_THUE"] = value;
		}
	}

	public bool IsMA_SO_THUENull() 
	{
		return pm_objDR.IsNull("MA_SO_THUE");
	}

	public void SetMA_SO_THUENull() {
		pm_objDR["MA_SO_THUE"] = System.Convert.DBNull;
	}

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

#endregion
#region "Init Functions"
	public US_V_DM_KHACH_HANG() 
	{
		pm_objDS = new DS_V_DM_KHACH_HANG();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_KHACH_HANG(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_KHACH_HANG(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_KHACH_HANG();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion


    public void FillDatasetSearch(DS_V_DM_KHACH_HANG ip_ds_v_dm_khach_hang, string ip_str_tu_khoa)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_DM_KHACH_HANG_Search");
        v_stored_proc.addNVarcharInputParam("@TU_KHOA", ip_str_tu_khoa);
        v_stored_proc.fillDataSetByCommand(this, ip_ds_v_dm_khach_hang);
    }
}
}
