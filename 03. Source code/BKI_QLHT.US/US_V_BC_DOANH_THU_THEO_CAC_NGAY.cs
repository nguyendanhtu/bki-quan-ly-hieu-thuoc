///************************************************
/// Generated by: TuNA
/// Date: 14-05-2014 11:39:44
/// Goal: Create User Service Class for V_BC_DOANH_THU_THEO_CAC_NGAY
///************************************************
/// <summary>
/// Create User Service Class for V_BC_DOANH_THU_THEO_CAC_NGAY
/// </summary>

using System;
using BKI_QLHT;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BKI_QLHT.DS;


namespace BKI_QLHT.US
{

public class US_V_BC_DOANH_THU_THEO_CAC_NGAY : US_Object
{
	private const string c_TableName = "V_BC_DOANH_THU_THEO_CAC_NGAY";
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
    public void FillDatasetSearch(DS_V_BC_DOANH_THU_THEO_CAC_NGAY op_ds_bc_da, string i_str_tu_khoa, DateTime i_dat_ngay_bd, DateTime i_dat_ngay_kt)
    {
        CStoredProc v_sp = new CStoredProc("pr_V_BC_DOANH_THU_THEO_CAC_NGAY_search");
        v_sp.addNVarcharInputParam("@STR_SEARCH", i_str_tu_khoa);
        v_sp.addDatetimeInputParam("@DAT_BD", i_dat_ngay_bd);
        v_sp.addDatetimeInputParam("@DAT_KT", i_dat_ngay_kt);
        v_sp.fillDataSetByCommand(this, op_ds_bc_da);
    }
	public US_V_BC_DOANH_THU_THEO_CAC_NGAY() 
	{
		pm_objDS = new DS_V_BC_DOANH_THU_THEO_CAC_NGAY();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_BC_DOANH_THU_THEO_CAC_NGAY(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_BC_DOANH_THU_THEO_CAC_NGAY(decimal i_dbID) 
	{
		pm_objDS = new DS_V_BC_DOANH_THU_THEO_CAC_NGAY();
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