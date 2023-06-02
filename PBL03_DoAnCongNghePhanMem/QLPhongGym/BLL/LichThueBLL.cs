using QLPhongGym.DAL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
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
