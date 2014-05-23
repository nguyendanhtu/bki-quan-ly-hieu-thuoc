///************************************************
/// Generated by: TuNA
/// Date: 15-05-2014 12:03:20
/// Goal: Create User Service Class for V_BC_DOANH_THU_THEO_CAC_NGAY_N_KHACH_HANG
///************************************************
/// <summary>
/// Create User Service Class for V_BC_DOANH_THU_THEO_CAC_NGAY_N_KHACH_HANG
/// </summary>

using System;
using BKI_QLHT;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BKI_QLHT.DS;


namespace BKI_QLHT.US{

public class US_V_BC_DOANH_THU_THEO_CAC_NGAY_N_KHACH_HANG : US_Object
{
	private const string c_TableName = "V_BC_DOANH_THU_THEO_CAC_NGAY_N_KHACH_HANG";
#region "Public Properties"
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

	public decimal dcTONG_SO_LUONG_BAN 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TONG_SO_LUONG_BAN", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TONG_SO_LUONG_BAN"] = value;
		}
	}

	public bool IsTONG_SO_LUONG_BANNull()	{
		return pm_objDR.IsNull("TONG_SO_LUONG_BAN");
	}

	public void SetTONG_SO_LUONG_BANNull() {
		pm_objDR["TONG_SO_LUONG_BAN"] = System.Convert.DBNull;
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
    public void FillDatasetSearch(DS_V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG op_ds_bc_da, string i_str_tu_khoa, DateTime i_dat_ngay_bd, DateTime i_dat_ngay_kt)
    {
        CStoredProc v_sp = new CStoredProc("pr_V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG_search");
        v_sp.addNVarcharInputParam("@STR_SEARCH", i_str_tu_khoa);
        v_sp.addDatetimeInputParam("@DAT_BD", i_dat_ngay_bd);
        v_sp.addDatetimeInputParam("@DAT_KT", i_dat_ngay_kt);
        v_sp.fillDataSetByCommand(this, op_ds_bc_da);
    }
	public US_V_BC_DOANH_THU_THEO_CAC_NGAY_N_KHACH_HANG() 
	{
		pm_objDS = new DS_V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_BC_DOANH_THU_THEO_CAC_NGAY_N_KHACH_HANG(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_BC_DOANH_THU_THEO_CAC_NGAY_N_KHACH_HANG(decimal i_dbID) 
	{
		pm_objDS = new DS_V_BC_DOANH_THU_THEO_CAC_NGAY_n_KHACH_HANG();
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