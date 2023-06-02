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
    }
}
