///************************************************
/// Generated by: DungNT
/// Date: 02/04/2014 09:23:02
/// Goal: Create User Service Class for V_DM_THUOC
///************************************************
/// <summary>
/// Create User Service Class for V_DM_THUOC
/// </summary>

using System;
using BKI_QLHT.DS;
using IP.Core.IPCommon;
using IP.Core.IPUserService;
using System.Data.SqlClient;
using System.Data;



namespace BKI_QLHT.US{

public class US_V_DM_THUOC : US_Object
{
	private const string c_TableName = "V_DM_THUOC";
    #region "Public Properties"
    public string strTEN_DANH_MUC
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TEN_DANH_MUC", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TEN_DANH_MUC"] = value;
        }
    }

    public bool IsTEN_DANH_MUCNull()
    {
        return pm_objDR.IsNull("TEN_DANH_MUC");
    }

    public void SetTEN_DANH_MUCNull()
    {
        pm_objDR["TEN_DANH_MUC"] = System.Convert.DBNull;
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

    public void SetTEN_NHOMNull()
    {
        pm_objDR["TEN_NHOM"] = System.Convert.DBNull;
    }

    public string strTHUOC_THAY_THE
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "THUOC_THAY_THE", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["THUOC_THAY_THE"] = value;
        }
    }

    public bool IsTHUOC_THAY_THENull()
    {
        return pm_objDR.IsNull("THUOC_THAY_THE");
    }

    public void SetTHUOC_THAY_THENull()
    {
        pm_objDR["THUOC_THAY_THE"] = System.Convert.DBNull;
    }

    public decimal dcID_DANH_MUC_THUOC
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_DANH_MUC_THUOC", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_DANH_MUC_THUOC"] = value;
        }
    }

    public bool IsID_DANH_MUC_THUOCNull()
    {
        return pm_objDR.IsNull("ID_DANH_MUC_THUOC");
    }

    public void SetID_DANH_MUC_THUOCNull()
    {
        pm_objDR["ID_DANH_MUC_THUOC"] = System.Convert.DBNull;
    }

    public decimal dcID_NHOM_THUOC
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "ID_NHOM_THUOC", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["ID_NHOM_THUOC"] = value;
        }
    }

    public bool IsID_NHOM_THUOCNull()
    {
        return pm_objDR.IsNull("ID_NHOM_THUOC");
    }

    public void SetID_NHOM_THUOCNull()
    {
        pm_objDR["ID_NHOM_THUOC"] = System.Convert.DBNull;
    }

    public decimal dcTT_HOAT_CHAT
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "TT_HOAT_CHAT", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["TT_HOAT_CHAT"] = value;
        }
    }

    public bool IsTT_HOAT_CHATNull()
    {
        return pm_objDR.IsNull("TT_HOAT_CHAT");
    }

    public void SetTT_HOAT_CHATNull()
    {
        pm_objDR["TT_HOAT_CHAT"] = System.Convert.DBNull;
    }

    public decimal dcTT_THUOC
    {
        get
        {
            return CNull.RowNVLDecimal(pm_objDR, "TT_THUOC", IPConstants.c_DefaultDecimal);
        }
        set
        {
            pm_objDR["TT_THUOC"] = value;
        }
    }

    public bool IsTT_THUOCNull()
    {
        return pm_objDR.IsNull("TT_THUOC");
    }

    public void SetTT_THUOCNull()
    {
        pm_objDR["TT_THUOC"] = System.Convert.DBNull;
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

    public void SetTEN_THUOCNull()
    {
        pm_objDR["TEN_THUOC"] = System.Convert.DBNull;
    }

    public string strDUONG_DUNG_DANG_DUNG
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "DUONG_DUNG_DANG_DUNG", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["DUONG_DUNG_DANG_DUNG"] = value;
        }
    }

    public bool IsDUONG_DUNG_DANG_DUNGNull()
    {
        return pm_objDR.IsNull("DUONG_DUNG_DANG_DUNG");
    }

    public void SetDUONG_DUNG_DANG_DUNGNull()
    {
        pm_objDR["DUONG_DUNG_DANG_DUNG"] = System.Convert.DBNull;
    }

    public string strTUYEN_SU_DUNG_5
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TUYEN_SU_DUNG_5", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TUYEN_SU_DUNG_5"] = value;
        }
    }

    public bool IsTUYEN_SU_DUNG_5Null()
    {
        return pm_objDR.IsNull("TUYEN_SU_DUNG_5");
    }

    public void SetTUYEN_SU_DUNG_5Null()
    {
        pm_objDR["TUYEN_SU_DUNG_5"] = System.Convert.DBNull;
    }

    public string strTUYEN_SU_DUNG_6
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TUYEN_SU_DUNG_6", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TUYEN_SU_DUNG_6"] = value;
        }
    }

    public bool IsTUYEN_SU_DUNG_6Null()
    {
        return pm_objDR.IsNull("TUYEN_SU_DUNG_6");
    }

    public void SetTUYEN_SU_DUNG_6Null()
    {
        pm_objDR["TUYEN_SU_DUNG_6"] = System.Convert.DBNull;
    }

    public string strTUYEN_SU_DUNG_7
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TUYEN_SU_DUNG_7", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TUYEN_SU_DUNG_7"] = value;
        }
    }

    public bool IsTUYEN_SU_DUNG_7Null()
    {
        return pm_objDR.IsNull("TUYEN_SU_DUNG_7");
    }

    public void SetTUYEN_SU_DUNG_7Null()
    {
        pm_objDR["TUYEN_SU_DUNG_7"] = System.Convert.DBNull;
    }

    public string strTUYEN_SU_DUNG_8
    {
        get
        {
            return CNull.RowNVLString(pm_objDR, "TUYEN_SU_DUNG_8", IPConstants.c_DefaultString);
        }
        set
        {
            pm_objDR["TUYEN_SU_DUNG_8"] = value;
        }
    }

    public bool IsTUYEN_SU_DUNG_8Null()
    {
        return pm_objDR.IsNull("TUYEN_SU_DUNG_8");
    }

    public void SetTUYEN_SU_DUNG_8Null()
    {
        pm_objDR["TUYEN_SU_DUNG_8"] = System.Convert.DBNull;
    }

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

    public bool IsIDNull()
    {
        return pm_objDR.IsNull("ID");
    }

    public void SetIDNull()
    {
        pm_objDR["ID"] = System.Convert.DBNull;
    }

    #endregion
    #region "Init Functions"
    public US_V_DM_THUOC()
    {
        pm_objDS = new DS_V_DM_THUOC();
        pm_strTableName = c_TableName;
        pm_objDR = pm_objDS.Tables[pm_strTableName].NewRow();
    }

    public US_V_DM_THUOC(DataRow i_objDR)
        : this()
    {
        this.DataRow2Me(i_objDR);
    }

    public US_V_DM_THUOC(decimal i_dbID)
    {
        pm_objDS = new DS_V_DM_THUOC();
        pm_strTableName = c_TableName;
        IMakeSelectCmd v_objMkCmd = new CMakeAndSelectCmd(pm_objDS, c_TableName);
        v_objMkCmd.AddCondition("ID", i_dbID, eKieuDuLieu.KieuNumber, eKieuSoSanh.Bang);
        SqlCommand v_cmdSQL;
        v_cmdSQL = v_objMkCmd.getSelectCmd();
        this.FillDatasetByCommand(pm_objDS, v_cmdSQL);
        pm_objDR = getRowClone(pm_objDS.Tables[pm_strTableName].Rows[0]);
    }
    #endregion
    public void FillDatasetSearchByDanhMuc(DS_V_DM_THUOC ip_ds, decimal ip_dc_id_danh_muc, string ip_str_tu_khoa)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_V_DM_THUOC_By_danh_muc");
        v_store_proc.addDecimalInputParam("@IP_ID_DANH_MUC", ip_dc_id_danh_muc);
        //v_store_proc.addDecimalInputParam("@IP_ID_NHOM_THUOC", ip_dc_id_nhom_thuoc);
        v_store_proc.addNVarcharInputParam("@TU_KHOA", ip_str_tu_khoa);
        v_store_proc.fillDataSetByCommand(this, ip_ds);
    }
   
    public void FillDatasetSearchByNhomThuoc(DS_V_DM_THUOC ip_ds, decimal ip_dc_id_nhom_thuoc, string ip_str_tu_khoa)
    {
        CStoredProc v_store_proc = new CStoredProc("pr_V_DM_THUOC_By_Nhom_Thuoc");
        v_store_proc.addDecimalInputParam("@IP_ID_NHOM_THUOC", ip_dc_id_nhom_thuoc);
        v_store_proc.addNVarcharInputParam("@TU_KHOA", ip_str_tu_khoa);
        v_store_proc.fillDataSetByCommand(this, ip_ds);
    }
}
}
