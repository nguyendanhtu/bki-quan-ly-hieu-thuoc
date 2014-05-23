///************************************************
/// Generated by: TuNA
/// Date: 23-05-2014 11:35:04
/// Goal: Create User Service Class for V_BC_NHAP_THUOC_NCC_DE
///************************************************
/// <summary>
/// Create User Service Class for V_BC_NHAP_THUOC_NCC_DE
/// </summary>

using System;
using BKI_QLHT;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BKI_QLHT.DS;
using BKI_QLHT.DS.CDBNames;


namespace BKI_QLHT.US
{

public class US_V_BC_NHAP_THUOC_NCC_DE : US_Object
{
	private const string c_TableName = "V_BC_NHAP_THUOC_NCC_DE";
#region "Public Properties"
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

	public string strMA_GIAO_DICH 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "MA_GIAO_DICH", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["MA_GIAO_DICH"] = value;
		}
	}

	public bool IsMA_GIAO_DICHNull() 
	{
		return pm_objDR.IsNull("MA_GIAO_DICH");
	}

	public void SetMA_GIAO_DICHNull() {
		pm_objDR["MA_GIAO_DICH"] = System.Convert.DBNull;
	}

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
    public void FillDatasetSearch(BKI_QLHT.DS.V_BC_NHAP_THUOC_NCC_DE op_ds_bc_da, string i_str_tu_khoa, DateTime i_dat_ngay_bd, DateTime i_dat_ngay_kt)
    {
        CStoredProc v_sp = new CStoredProc("pr_V_BC_NHAP_THUOC_NCC_DE_search");
        v_sp.addNVarcharInputParam("@STR_SEARCH", i_str_tu_khoa);
        v_sp.addDatetimeInputParam("@DAT_BD", i_dat_ngay_bd);
        v_sp.addDatetimeInputParam("@DAT_KT", i_dat_ngay_kt);
        v_sp.fillDataSetByCommand(this, op_ds_bc_da);
    }
	public US_V_BC_NHAP_THUOC_NCC_DE() 
	{
		pm_objDS = new BKI_QLHT.DS.V_BC_NHAP_THUOC_NCC_DE();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_BC_NHAP_THUOC_NCC_DE(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_BC_NHAP_THUOC_NCC_DE(decimal i_dbID) 
	{
        pm_objDS = new BKI_QLHT.DS.V_BC_NHAP_THUOC_NCC_DE();
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
