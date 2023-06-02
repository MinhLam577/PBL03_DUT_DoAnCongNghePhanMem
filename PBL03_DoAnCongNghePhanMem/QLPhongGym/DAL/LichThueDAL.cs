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
    }
}
