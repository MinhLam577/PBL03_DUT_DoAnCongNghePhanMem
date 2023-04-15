using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongGym.DTO;

namespace QLPhongGym.DAL
{
    class KHDAL
    {
        private static KHDAL instance;
        public static KHDAL Instance
        {
            get
            {
                if(instance == null)
                    instance = new KHDAL();
                return instance;
            }
            private set { }
        }
        QLPhongGymDB db = new QLPhongGymDB();
        public KH GetKHByID(int ID)
        {
            return db.Users.OfType<KH>().Where(k => (int)k.IDUsers == ID).FirstOrDefault();
        }
    }
}
