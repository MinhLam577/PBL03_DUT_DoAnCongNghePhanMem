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
                if (instance == null)
                    instance = new GoiTapBLL();
                return instance;
            }
            private set { }
        }
        public DataTable GetData_BLL()
        {
            return GoiTapDAL.Instance.GetData_DAL();
        }
        public void DeleteGT_BLL(int mgt)
        {
            GoiTapDAL.Instance.DeleteGT_DAL(mgt);
        }
        public void AddGoiTap_BLL(GoiTap gt)
        {
            GoiTapDAL.Instance.AddGoiTap_DAL(gt);
        }
        public void UpdateGoiTap_BLL(GoiTap gt)
        {
            GoiTapDAL.Instance.UpdateGoiTap_DAL(gt);
        }
    }
}
