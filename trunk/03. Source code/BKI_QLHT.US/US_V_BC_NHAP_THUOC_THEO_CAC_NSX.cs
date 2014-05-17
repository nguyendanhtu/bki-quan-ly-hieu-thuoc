///************************************************
/// Generated by: TuNA
/// Date: 17-05-2014 11:13:53
/// Goal: Create User Service Class for V_BC_NHAP_THUOC_THEO_CAC_NSX
///************************************************
/// <summary>
/// Create User Service Class for V_BC_NHAP_THUOC_THEO_CAC_NSX
/// </summary>

using System;
using BKI_QLHT;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BKI_QLHT.DS;


namespace BKI_QLHT.US{

public class US_V_BC_NHAP_THUOC_THEO_CAC_NSX : US_Object
{
	private const string c_TableName = "V_BC_NHAP_THUOC_THEO_CAC_NSX";
#region "Public Properties"
	public string strTEN_NSX 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_NSX", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_NSX"] = value;
		}
	}

	public bool IsTEN_NSXNull() 
	{
		return pm_objDR.IsNull("TEN_NSX");
	}

	public void SetTEN_NSXNull() {
		pm_objDR["TEN_NSX"] = System.Convert.DBNull;
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

	public decimal dcTONG_SO_LUONG_NHAP 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "TONG_SO_LUONG_NHAP", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["TONG_SO_LUONG_NHAP"] = value;
		}
	}

	public bool IsTONG_SO_LUONG_NHAPNull()	{
		return pm_objDR.IsNull("TONG_SO_LUONG_NHAP");
	}

	public void SetTONG_SO_LUONG_NHAPNull() {
		pm_objDR["TONG_SO_LUONG_NHAP"] = System.Convert.DBNull;
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
    public void FillDatasetSearch(DS_V_BC_NHAP_THUOC_THEO_CAC_NSX op_ds_bc_da, string i_str_tu_khoa, DateTime i_dat_ngay_bd, DateTime i_dat_ngay_kt)
    {
        CStoredProc v_sp = new CStoredProc("pr_V_BC_NHAP_THUOC_CAC_NSX_search");
        v_sp.addNVarcharInputParam("@STR_SEARCH", i_str_tu_khoa);
        v_sp.addDatetimeInputParam("@DAT_BD", i_dat_ngay_bd);
        v_sp.addDatetimeInputParam("@DAT_KT", i_dat_ngay_kt);
        v_sp.fillDataSetByCommand(this, op_ds_bc_da);
    }
	public US_V_BC_NHAP_THUOC_THEO_CAC_NSX() 
	{
		pm_objDS = new DS_V_BC_NHAP_THUOC_THEO_CAC_NSX();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_BC_NHAP_THUOC_THEO_CAC_NSX(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_BC_NHAP_THUOC_THEO_CAC_NSX(decimal i_dbID) 
	{
		pm_objDS = new DS_V_BC_NHAP_THUOC_THEO_CAC_NSX();
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
