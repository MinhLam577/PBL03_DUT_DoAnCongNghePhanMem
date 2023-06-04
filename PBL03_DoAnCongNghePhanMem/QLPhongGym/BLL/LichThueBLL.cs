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
        public DataTable showlich()
        {
            return LichThueDAL.Instance.showlich();
        }
        public bool xoa(int ma)
        {
            return LichThueDAL.Instance.xoa(ma);
        }
    
        public bool Capnhat1(int idca, int idhlv, DateTime ngaylam, int IDCA, int IDHLV, DateTime NGAYLAM)
        {
            return LichThueDAL.Instance.Capnhat1(idca, idhlv, ngaylam, IDCA, IDHLV,  NGAYLAM);

        public List<LichThueHLV> GetLichThueByIDKH_IDHLV(int IDKH, int IDHLV)
        {
            return LichThueDAL.Instance.GetLichThueByIDKH_IDHLV(IDKH, IDHLV);
        }
        public List<LichThueHLV> GetLichThueByIDHLV(int IDHLV)
        {
            return LichThueDAL.Instance.GetLichThueByIDHLV(IDHLV);
        }
    }
}
