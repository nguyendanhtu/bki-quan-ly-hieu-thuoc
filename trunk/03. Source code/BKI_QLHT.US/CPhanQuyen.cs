using System;
using System.Collections.Generic;
using System.Text;
using BKI_QLHT.DS;
using IP.Core.IPCommon;
using IP.Core.IPSystemAdmin;

namespace BKI_QLHT.US
{
    public class CPhanQuyen : IControlerControl
    {
        #region "Variables"
        private static US_HT_NGUOI_SU_DUNG m_us_user;
        private static string m_strRunMode;
        #endregion

        public bool CanUseControl(string ip_strFormName, string ip_strControlName, string ip_strControlType)
        {
            return CPhanQuyen.CanUseThisControl(ip_strFormName, ip_strControlName, ip_strControlType);
        }

       

        
        private static bool CanUseThisControl(string ip_strFormName, string ip_strControlName, string ip_strControlType)
        {
            US_HT_NGUOI_SU_DUNG v_us_ht_nguoi_su_dung = new US_HT_NGUOI_SU_DUNG(CAppContext_201.getCurrentUserID());
            US_HT_USER_GROUP v_us_ht_user_group = new US_HT_USER_GROUP(v_us_ht_nguoi_su_dung.dcID_USER_GROUP);
            US_V_HT_PHAN_QUYEN v_us_v_ht_phan_quyen = new US_V_HT_PHAN_QUYEN();
            DS_V_HT_PHAN_QUYEN v_ds_v_ht_phan_quyen = new DS_V_HT_PHAN_QUYEN();
            v_us_v_ht_phan_quyen.FillDataset(v_ds_v_ht_phan_quyen, "where form_name = '" + ip_strFormName + "' and control_name='" + ip_strControlName + "' and control_type='" + ip_strControlType + "' and id_user_group=" + +v_us_ht_user_group.dcID);
            if (v_ds_v_ht_phan_quyen.V_HT_PHAN_QUYEN.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
