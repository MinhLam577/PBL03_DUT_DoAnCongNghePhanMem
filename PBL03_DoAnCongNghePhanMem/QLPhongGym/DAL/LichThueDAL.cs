using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongGym.DAL
{
    class LichThueDAL
    {
        QLPhongGymDB db = new QLPhongGymDB();
        private static LichThueDAL instance;
        public static LichThueDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LichThueDAL();
                return instance;
            }
            private set { }
        }
        
        public List<LichThueHLV> GetLichThueByIDKH_IDHLV(int IDKH, int IDHLV)
        {
            var data = db.LichThueHLVs.Where(l => l.IDKH == IDKH && l.IDHLV == IDHLV).ToList();
            return data;
        }
        public List<LichThueHLV> GetLichThueByIDHLV(int IDHLV)
        {
            var data = db.LichThueHLVs.Where(l => l.IDHLV == IDHLV).ToList();
            return data;
        }
    }
}
