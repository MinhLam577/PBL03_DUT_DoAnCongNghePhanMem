using QLPhongGym.DAL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongGym.BLL
{
    class LichThueBLL
    {
        private static LichThueBLL instance;
        public static LichThueBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LichThueBLL();
                return instance;
            }
            private set { }
        }
        public List<string> danhsachcatheongay(DateTime ngay)
        {
            return LichThueDAL.Instance.danhsachcatheongay(ngay);
        }
        public bool DangKiThueHLV(LichThueHLV a)
        {
            return LichThueDAL.Instance.DangKiThueHLV(a);
        }
      
        public bool xoa(int ma)
        {
            return LichThueDAL.Instance.xoa(ma);
        }

        public bool Capnhat1(int idca, int idhlv, DateTime ngaylam, int IDCA, int IDHLV, DateTime NGAYLAM)
        {
            return LichThueDAL.Instance.Capnhat1(idca, idhlv, ngaylam, IDCA, IDHLV, NGAYLAM);
        }
        public List<LichThueHLV> GetLichThueByIDKH_IDHLV(int IDKH, int IDHLV)
        {
            return LichThueDAL.Instance.GetLichThueByIDKH_IDHLV(IDKH, IDHLV);
        }
        public List<LichThueHLV> GetLichThueByIDHLV(int IDHLV)
        {
            return LichThueDAL.Instance.GetLichThueByIDHLV(IDHLV);
        }
        public void DeleteLichThue(int IDLT)
        {
            LichThueDAL.Instance.DeleteLichThue(IDLT);
        }
        public LichThueHLV GetLichThueByIDLT(int IDLT)
        {
            return LichThueDAL.Instance.GetLichThueByIDLT((int)IDLT);
        }
        public List<LichThueHLV> GetLichThueByIDKH(int IDKH)
        {
            return LichThueDAL.Instance.GetLichThueByIDKH(IDKH);
        }
        public DataTable ShowListKH_DkiHLV(int idkh)
        {
            return LichThueDAL.Instance.ShowListKH_DkiHLV(idkh);
        }
      /*  public bool SuaLichThueHLv(int idhlv, DateTime ngaylam, int idca,int idkh, int Idhlv, DateTime NgayLam, int Idca,int Idkh)
        {
            return LichThueDAL.Instance.SuaLichThueHLv(idhlv, ngaylam, idca, Idhlv, NgayLam, Idca);
        }*/
        public LichThueHLV GetLichThueByIDKH_IDHLV_NgayLam_IDCa(int IDKH, int IDHLV, DateTime NgayLam, int Idca)
        {
            return LichThueDAL.Instance.GetLichThueByIDKH_IDHLV_NgayLam_IDCa(IDKH, IDHLV, NgayLam, Idca);
        }
    }

}
