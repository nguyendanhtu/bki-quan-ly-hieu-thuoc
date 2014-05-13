///************************************************
/// Generated by: TuNA
/// Date: 13-05-2014 02:54:38
/// Goal: Create User Service Class for V_BC_DOANH_THU_THEO_CAC_BAC_SY
///************************************************
/// <summary>
/// Create User Service Class for V_BC_DOANH_THU_THEO_CAC_BAC_SY
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

public class US_V_BC_DOANH_THU_THEO_CAC_BAC_SY : US_Object
{
	private const string c_TableName = "V_BC_DOANH_THU_THEO_CAC_BAC_SY";
#region "Public Properties"
	public string strTEN_BAC_SY 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TEN_BAC_SY", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TEN_BAC_SY"] = value;
		}
	}

	public bool IsTEN_BAC_SYNull() 
	{
		return pm_objDR.IsNull("TEN_BAC_SY");
	}

	public void SetTEN_BAC_SYNull() {
		pm_objDR["TEN_BAC_SY"] = System.Convert.DBNull;
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
	public US_V_BC_DOANH_THU_THEO_CAC_BAC_SY() 
	{
		pm_objDS = new DS_V_BC_DOANH_THU_THEO_CAC_BAC_SY();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_BC_DOANH_THU_THEO_CAC_BAC_SY(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_BC_DOANH_THU_THEO_CAC_BAC_SY(decimal i_dbID) 
	{
		pm_objDS = new DS_V_BC_DOANH_THU_THEO_CAC_BAC_SY();
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
