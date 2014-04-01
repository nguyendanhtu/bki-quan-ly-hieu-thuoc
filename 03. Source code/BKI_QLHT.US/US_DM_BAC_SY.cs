///************************************************
/// Generated by: DungNT
/// Date: 31/03/2014 02:23:31
/// Goal: Create User Service Class for DM_BAC_SY
///************************************************
/// <summary>
/// Create User Service Class for DM_BAC_SY
/// </summary>

using System;
using BKI_QLHT.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLHT.US{

public class US_DM_BAC_SY : US_Object
{
	private const string c_TableName = "DM_BAC_SY";
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

	public string strHO_TEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "HO_TEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["HO_TEN"] = value;
		}
	}

	public bool IsHO_TENNull() 
	{
		return pm_objDR.IsNull("HO_TEN");
	}

	public void SetHO_TENNull() {
		pm_objDR["HO_TEN"] = System.Convert.DBNull;
	}

	public decimal dcBENH_VIEN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "BENH_VIEN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["BENH_VIEN"] = value;
		}
	}

	public bool IsBENH_VIENNull()	{
		return pm_objDR.IsNull("BENH_VIEN");
	}

	public void SetBENH_VIENNull() {
		pm_objDR["BENH_VIEN"] = System.Convert.DBNull;
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

	public string strDIEN_THOAI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DIEN_THOAI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DIEN_THOAI"] = value;
		}
	}

	public bool IsDIEN_THOAINull() 
	{
		return pm_objDR.IsNull("DIEN_THOAI");
	}

	public void SetDIEN_THOAINull() {
		pm_objDR["DIEN_THOAI"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DM_BAC_SY() 
	{
		pm_objDS = new DS_DM_BAC_SY();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_BAC_SY(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_BAC_SY(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_BAC_SY();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    //public void FillDatasetSearch(DS_DM_BAC_SY ip_ds_dm_bac_sy, string ip_str_tu_khoa)
    //{
    //    CStoredProc v_stored_proc = new CStoredProc("pr_DM_BAC_SY_Search");
    //    v_stored_proc.addNVarcharInputParam("@TU_KHOA", ip_str_tu_khoa);
    //    v_stored_proc.fillDataSetByCommand(this, ip_ds_dm_bac_sy);
    //}
}
}
