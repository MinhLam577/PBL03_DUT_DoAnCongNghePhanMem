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
        public void UpdateGT(GoiTap GT)
        {
            GoiTapDAL.Instance.UpdateGT(GT);
        }
        public DataTable GetData_BLL()
        {
            return GoiTapDAL.Instance.GetData_DAL();
        }
        public bool TenGT_BLL(string str)
        {
            return GoiTapDAL.Instance.TenGT(str);
        }

    }
}
