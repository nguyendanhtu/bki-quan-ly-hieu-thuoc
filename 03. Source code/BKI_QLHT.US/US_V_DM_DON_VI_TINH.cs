///************************************************
/// Generated by: Huytd
/// Date: 22/04/2014 11:01:08
/// Goal: Create User Service Class for V_DM_DON_VI_TINH
///************************************************
/// <summary>
/// Create User Service Class for V_DM_DON_VI_TINH
/// </summary>

using System;
using BKI_QLHT;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;
using BKI_QLHT.DS;


namespace BKI_QLHT.US{

public class US_V_DM_DON_VI_TINH : US_Object
{
	private const string c_TableName = "V_DM_DON_VI_TINH";
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

	public decimal dcID_NGUOI_LAP 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_LAP", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NGUOI_LAP"] = value;
		}
	}

	public bool IsID_NGUOI_LAPNull()	{
		return pm_objDR.IsNull("ID_NGUOI_LAP");
	}

	public void SetID_NGUOI_LAPNull() {
		pm_objDR["ID_NGUOI_LAP"] = System.Convert.DBNull;
	}

	public decimal dcID_TRANG_THAI 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_TRANG_THAI", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_TRANG_THAI"] = value;
		}
	}

	public bool IsID_TRANG_THAINull()	{
		return pm_objDR.IsNull("ID_TRANG_THAI");
	}

	public void SetID_TRANG_THAINull() {
		pm_objDR["ID_TRANG_THAI"] = System.Convert.DBNull;
	}

	public DateTime datNGAY_LAP
	{
		get   
		{
			return CNull.RowNVLDate(pm_objDR, "NGAY_LAP", IPConstants.c_DefaultDate);
		}
		set   
		{
			pm_objDR["NGAY_LAP"] = value;
		}
	}

	public bool IsNGAY_LAPNull()
	{
		return pm_objDR.IsNull("NGAY_LAP");
	}

	public void SetNGAY_LAPNull()
	{
		pm_objDR["NGAY_LAP"] = System.Convert.DBNull;
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

	public string strTRANG_THAI 
	{
		get 
		{
			return CNull.RowNVLString(pm_objDR, "TRANG_THAI", IPConstants.c_DefaultString);
		}
		set 
		{
			pm_objDR["TRANG_THAI"] = value;
		}
	}

	public bool IsTRANG_THAINull() 
	{
		return pm_objDR.IsNull("TRANG_THAI");
	}

	public void SetTRANG_THAINull() {
		pm_objDR["TRANG_THAI"] = System.Convert.DBNull;
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

	public decimal dcID_NGUOI_SU_DUNG 
	{
		get
		{
			return CNull.RowNVLDecimal(pm_objDR, "ID_NGUOI_SU_DUNG", IPConstants.c_DefaultDecimal);
		}
		set	
		{
			pm_objDR["ID_NGUOI_SU_DUNG"] = value;
		}
	}

	public bool IsID_NGUOI_SU_DUNGNull()	{
		return pm_objDR.IsNull("ID_NGUOI_SU_DUNG");
	}

	public void SetID_NGUOI_SU_DUNGNull() {
		pm_objDR["ID_NGUOI_SU_DUNG"] = System.Convert.DBNull;
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

#endregion
#region "Init Functions"
	public US_V_DM_DON_VI_TINH() 
	{
		pm_objDS = new DS_V_DM_DON_VI_TINH();
		pm_strTableName = c_TableName;
		pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
	}

	public US_V_DM_DON_VI_TINH(DataRow i_objDR): this()
	{
		this.DataRow2Me(i_objDR);
	}

	public US_V_DM_DON_VI_TINH(decimal i_dbID) 
	{
		pm_objDS = new DS_V_DM_DON_VI_TINH();
		pm_strTableName = c_TableName;
		IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
		v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
		SqlCommand v_cmdSQL;
		v_cmdSQL = v_objMkCmd.getSelectCmd();
		this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
		pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
	}
#endregion

    public void FillDatasetSearch(DS_V_DM_DON_VI_TINH ip_ds_v_dm_don_vi_tinh, string ip_v_str_tu_khoa, decimal ip_v_dc_id_trang_thai, decimal ip_v_dc_id_nguoi_su_dung)
    {
        CStoredProc v_stored_proc = new CStoredProc("pr_V_DM_DON_VI_TINH_Search");
        v_stored_proc.addNVarcharInputParam("@TU_KHOA", ip_v_str_tu_khoa);
        v_stored_proc.addDecimalInputParam("@IP_DC_ID_TRANG_THAI", ip_v_dc_id_trang_thai);
        v_stored_proc.addDecimalInputParam("@IP_DC_ID_NGUOI_SU_DUNG", ip_v_dc_id_nguoi_su_dung);
        v_stored_proc.fillDataSetByCommand(this, ip_ds_v_dm_don_vi_tinh);
    }
}
}