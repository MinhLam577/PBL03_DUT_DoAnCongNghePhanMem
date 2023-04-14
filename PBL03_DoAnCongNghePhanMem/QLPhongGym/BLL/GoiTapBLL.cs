using QLPhongGym.DAL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongGym.BLL
{
    class GoiTapBLL
    {
        private static GoiTapBLL instance;
        public static GoiTapBLL Instance
        {
            get
            {
                if(instance == null)
                    instance = new GoiTapBLL();
                return instance;
            }
            private set { }
        }
        public List<GoiTap> GetAllGT()
        {
            return GoiTapDAL.Instance.GetAllGT();
        }
        public GoiTap GetGTByID(int ID)
        {
            return GoiTapDAL.Instance.GetGTByID(ID);
        }
        public GoiTap GetGTByName(string name)
        {
            return GoiTapDAL.Instance.GetGTByName(name);
        }
        public bool AddGT(GoiTap GT)
        {
            return GoiTapDAL.Instance.AddGT(GT) > 0;
        }
        public void DeleteGT(GoiTap GT)
        {
            GoiTapDAL.Instance.DeleteGT(GT);
        }
        public bool UpdateGT(GoiTap GT)
        {
            return GoiTapDAL.Instance.UpdateGT(GT) > 0;
        }
    }
}
