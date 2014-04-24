///************************************************
/// Generated by: Huytd
/// Date: 24/04/2014 04:36:40
/// Goal: Create User Service Class for V_DM_DON_VI
///************************************************
/// <summary>
/// Create User Service Class for V_DM_DON_VI
/// </summary>

using System;
using BKI_QLHT;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BKI_QLHT.DS;


namespace BKI_QLHT.US{

public class US_V_DM_DON_VI : US_Object
{
	private const string c_TableName = "V_DM_DON_VI";
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

	public string strMA_VIET_TAT 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_VIET_TAT", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_VIET_TAT"] = value;
		}
	}

	public bool IsMA_VIET_TATNull() 
	{
		return pm_objDR.IsNull("MA_VIET_TAT");
	}

	public void SetMA_VIET_TATNull() {
		pm_objDR["MA_VIET_TAT"] = System.Convert.DBNull;
	}

	public string strTEN_DAY_DU 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_DAY_DU", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_DAY_DU"] = value;
		}
	}

	public bool IsTEN_DAY_DUNull() 
	{
		return pm_objDR.IsNull("TEN_DAY_DU");
	}

	public void SetTEN_DAY_DUNull() {
		pm_objDR["TEN_DAY_DU"] = System.Convert.DBNull;
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

	public string strGHI_CHU_1 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU_1", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU_1"] = value;
		}
	}

	public bool IsGHI_CHU_1Null() 
	{
		return pm_objDR.IsNull("GHI_CHU_1");
	}

	public void SetGHI_CHU_1Null() {
		pm_objDR["GHI_CHU_1"] = System.Convert.DBNull;
	}

	public string strGHI_CHU_2 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU_2", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU_2"] = value;
		}
	}

	public bool IsGHI_CHU_2Null() 
	{
		return pm_objDR.IsNull("GHI_CHU_2");
	}

	public void SetGHI_CHU_2Null() {
		pm_objDR["GHI_CHU_2"] = System.Convert.DBNull;
	}

	public string strGHI_CHU_3 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "GHI_CHU_3", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["GHI_CHU_3"] = value;
		}
	}

	public bool IsGHI_CHU_3Null() 
	{
		return pm_objDR.IsNull("GHI_CHU_3");
	}

	public void SetGHI_CHU_3Null() {
		pm_objDR["GHI_CHU_3"] = System.Convert.DBNull;
	}

	public decimal dcID_DON_VI_CAP_TREN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_DON_VI_CAP_TREN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_DON_VI_CAP_TREN"] = value;
		}
	}

	public bool IsID_DON_VI_CAP_TRENNull()	{
		return pm_objDR.IsNull("ID_DON_VI_CAP_TREN");
	}

	public void SetID_DON_VI_CAP_TRENNull() {
		pm_objDR["ID_DON_VI_CAP_TREN"] = System.Convert.DBNull;
	}

	public decimal dcID_LOAI_DON_VI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_DON_VI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_DON_VI"] = value;
		}
	}

	public bool IsID_LOAI_DON_VINull()	{
		return pm_objDR.IsNull("ID_LOAI_DON_VI");
	}

	public void SetID_LOAI_DON_VINull() {
		pm_objDR["ID_LOAI_DON_VI"] = System.Convert.DBNull;
	}

	public decimal dcID_TU_DIEN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_TU_DIEN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_TU_DIEN"] = value;
		}
	}

	public bool IsID_TU_DIENNull()	{
		return pm_objDR.IsNull("ID_TU_DIEN");
	}

	public void SetID_TU_DIENNull() {
		pm_objDR["ID_TU_DIEN"] = System.Convert.DBNull;
	}

	public decimal dcID_LOAI_TU_DIEN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_LOAI_TU_DIEN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_LOAI_TU_DIEN"] = value;
		}
	}

	public bool IsID_LOAI_TU_DIENNull()	{
		return pm_objDR.IsNull("ID_LOAI_TU_DIEN");
	}

	public void SetID_LOAI_TU_DIENNull() {
		pm_objDR["ID_LOAI_TU_DIEN"] = System.Convert.DBNull;
	}

	public string strTEN 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN"] = value;
		}
	}

	public bool IsTENNull() 
	{
		return pm_objDR.IsNull("TEN");
	}

	public void SetTENNull() {
		pm_objDR["TEN"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
	public US_V_DM_DON_VI() 
	{
		pm_objDS = new DS_V_DM_DON_VI();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_DON_VI(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_DON_VI(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_DON_VI();
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
