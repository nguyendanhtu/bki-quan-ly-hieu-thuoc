///************************************************
/// Generated by: TuNA
/// Date: 17-05-2014 09:55:51
/// Goal: Create User Service Class for V_BC_BAN_THUOC
///************************************************
/// <summary>
/// Create User Service Class for V_BC_BAN_THUOC
/// </summary>

using System;
using BKI_QLHT;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BKI_QLHT.DS;


namespace BKI_QLHT.US{

public class US_V_BC_BAN_THUOC : US_Object
{
	private const string c_TableName = "V_BC_BAN_THUOC";
#region "Public Properties"
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

	public string strNGAY_GIAO_DICH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "NGAY_GIAO_DICH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["NGAY_GIAO_DICH"] = value;
		}
	}

	public bool IsNGAY_GIAO_DICHNull() 
	{
		return pm_objDR.IsNull("NGAY_GIAO_DICH");
	}

	public void SetNGAY_GIAO_DICHNull() {
		pm_objDR["NGAY_GIAO_DICH"] = System.Convert.DBNull;
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

	public string strDON_VI_TINH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "DON_VI_TINH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["DON_VI_TINH"] = value;
		}
	}

	public bool IsDON_VI_TINHNull() 
	{
		return pm_objDR.IsNull("DON_VI_TINH");
	}

	public void SetDON_VI_TINHNull() {
		pm_objDR["DON_VI_TINH"] = System.Convert.DBNull;
	}

	public decimal dcGIA_BAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "GIA_BAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["GIA_BAN"] = value;
		}
	}

	public bool IsGIA_BANNull()	{
		return pm_objDR.IsNull("GIA_BAN");
	}

	public void SetGIA_BANNull() {
		pm_objDR["GIA_BAN"] = System.Convert.DBNull;
	}

	public decimal dcTHANH_TIEN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "THANH_TIEN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["THANH_TIEN"] = value;
		}
	}

	public bool IsTHANH_TIENNull()	{
		return pm_objDR.IsNull("THANH_TIEN");
	}

	public void SetTHANH_TIENNull() {
		pm_objDR["THANH_TIEN"] = System.Convert.DBNull;
	}

#endregion
#region "Init Functions"
    public void FillDatasetSearch(DS_V_BC_BAN_THUOC op_ds_bc_da, string i_str_tu_khoa, DateTime i_dat_ngay_bd, DateTime i_dat_ngay_kt)
    {
        CStoredProc v_sp = new CStoredProc("pr_V_BC_BAN_THUOC_search");
        v_sp.addNVarcharInputParam("@STR_SEARCH", i_str_tu_khoa);
        v_sp.addDatetimeInputParam("@DAT_BD", i_dat_ngay_bd);
        v_sp.addDatetimeInputParam("@DAT_KT", i_dat_ngay_kt);
        v_sp.fillDataSetByCommand(this, op_ds_bc_da);
    }
	public US_V_BC_BAN_THUOC() 
	{
		pm_objDS = new DS_V_BC_BAN_THUOC();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_BC_BAN_THUOC(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_BC_BAN_THUOC(decimal i_dbID) 
	{
		pm_objDS = new DS_V_BC_BAN_THUOC();
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
