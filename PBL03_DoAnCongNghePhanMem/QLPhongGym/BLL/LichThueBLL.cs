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
    public class LichThueBLL
    {
        private static LichThueBLL instance;
        public LichThueBLL()
        {

        }
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

        }
    }
}
