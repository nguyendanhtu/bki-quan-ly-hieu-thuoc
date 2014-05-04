using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BKI_QLHT.DS;
using BKI_QLHT.US;
using BKI_QLHT.DS.CDBNames;
using System.Data;
using IP.Core.IPCommon;
namespace BKI_QLHT
{
    public class QuyDoiDVT
    {
        decimal id_dvt { get; set; }
        int so_luong { get; set; }
        decimal id_thuoc { get; set; }

        public decimal QuyDoi(decimal ip_dc_soluong, decimal ip_dc_id_dvt, decimal ip_dc_id_thuoc) {
            US_V_GD_DON_VI_TINH v_us = new US_V_GD_DON_VI_TINH();
            DS_V_GD_DON_VI_TINH v_ds = new DS_V_GD_DON_VI_TINH();
            v_us.FillDatasetByIDThuoc(v_ds, ip_dc_id_thuoc);
            List<decimal> list_id_dv_tinh = new List<decimal>();
            int count = 0;
            while (true)
            {
                foreach (var item in v_ds.V_GD_DON_VI_TINH.Rows)
                {
                    DataRow v_dr = (DataRow)item;
                    if (v_dr[v_gd_don_vi_tinh.ID_DON_VI_CHA].ToString() == "")
                    {
                        continue;
                    }

                    if (CIPConvert.ToDecimal(v_dr[v_gd_don_vi_tinh.ID_DON_VI_CHA].ToString()) == ip_dc_id_dvt)
                    {
                        count++;
                        list_id_dv_tinh.Add(CIPConvert.ToDecimal(v_dr[v_gd_don_vi_tinh.ID].ToString()));
                        ip_dc_id_dvt = CIPConvert.ToDecimal(v_dr[v_gd_don_vi_tinh.ID].ToString());
                    }                    
                }
                if (count == 0)
                {
                    break;
                }
                else
                {
                    count = 0;
                }
            }
            foreach (var item in list_id_dv_tinh)
            {
                foreach (var item2 in v_ds.V_GD_DON_VI_TINH.Rows)
                {
                    DataRow v_dr = (DataRow)item2;
                    if (item == CIPConvert.ToDecimal(v_dr[v_gd_don_vi_tinh.ID].ToString()))
                    {
                        ip_dc_soluong = ip_dc_soluong * CIPConvert.ToDecimal(v_dr[v_gd_don_vi_tinh.QUY_DOI].ToString());
                    }
                }
            }
            
            return ip_dc_soluong;
        }
    }
}
