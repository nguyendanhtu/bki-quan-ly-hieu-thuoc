///************************************************
/// Generated by: HuyTD
/// Date: 16/05/2014 02:55:45
/// Goal: Create User Service Class for DM_NHOM_KHACH_HANG
///************************************************
/// <summary>
/// Create User Service Class for DM_NHOM_KHACH_HANG
/// </summary>

using System;
using BKI_QLHT;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BKI_QLHT.DS;


namespace BKI_QLHT.US{

public class US_DM_NHOM_KHACH_HANG : US_Object
{
	private const string c_TableName = "DM_NHOM_KHACH_HANG";
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

	public decimal dcTI_LE_CHIET_KHAU_NHOM_KH 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TI_LE_CHIET_KHAU_NHOM_KH", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TI_LE_CHIET_KHAU_NHOM_KH"] = value;
		}
	}

	public bool IsTI_LE_CHIET_KHAU_NHOM_KHNull()	{
		return pm_objDR.IsNull("TI_LE_CHIET_KHAU_NHOM_KH");
	}

	public void SetTI_LE_CHIET_KHAU_NHOM_KHNull() {
		pm_objDR["TI_LE_CHIET_KHAU_NHOM_KH"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_DM_NHOM_KHACH_HANG() 
	{
		pm_objDS = new DS_DM_NHOM_KHACH_HANG();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_DM_NHOM_KHACH_HANG(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_DM_NHOM_KHACH_HANG(decimal i_dbID) 
	{
		pm_objDS = new DS_DM_NHOM_KHACH_HANG();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillDatasetSearch(DS_DM_NHOM_KHACH_HANG ip_ds_dm_nhom_khach_hang, string ip_str_tu_khoa)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_DM_NHOM_KHACH_HANG_Search");
        v_stored_proc.addNVarcharInputParam("@TU_KHOA", ip_str_tu_khoa);
        v_stored_proc.fillDataSetByCommand(this, ip_ds_dm_nhom_khach_hang);
    }

    public void FillDatasetCheckMaNhom(DS_DM_NHOM_KHACH_HANG ip_v_ds, string ip_ma_nhom)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_DM_NHOM_KHACH_HANG_Check_ma_nhom");
        v_stored_proc.addNVarcharInputParam("@IP_MA_NHOM", ip_ma_nhom);
        v_stored_proc.fillDataSetByCommand(this, ip_v_ds);
    }
}
}
