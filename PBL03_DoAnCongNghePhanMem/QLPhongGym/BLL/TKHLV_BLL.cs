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
    public class TKHLV_BLL
    {
        private static TKHLV_BLL instance;
        public static TKHLV_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TKHLV_BLL();
                return instance;
            }
            private set { }
        }
        public DataTable GetDataTableByList_BLL()
        {
            return TKHLV_DAL.Instance.GetDataTableByList();
        }
        public DataTable GetDataTableByList2_BLL()
        {
            return TKHLV_DAL.Instance.GetDataTableByList2();
        }
        public bool CheckHLVHasAccount_BLL(int hlvID)
        {
            return TKHLV_DAL.Instance.CheckHLVHasAccount(hlvID);
        }
        public void Delete_BLL(int str)
        {
            TKHLV_DAL.Instance.Delete_DAL(str);
        }
        public HLV GetHLVByID_BLL(int id)
        {
            return TKHLV_DAL.Instance.GetHLVByID(id);
        }
        public void ADD_BLL(TK sp)
        {
            TKHLV_DAL.Instance.ADD_DAL(sp);
        }
        public void UpdateTK_BLl(TK sp)
        {
            TKHLV_DAL.Instance.UpdateTK_DAl(sp);
        }
        public DataTable SearchSP_BLL2(string str)
        {
            return TKHLV_DAL.Instance.SearchSP_DAL2(str);
        }
        public DataTable SearchSP_BLL(string str)
        {
            return TKHLV_DAL.Instance.SearchSP_DAL(str);
        }
        public bool TenTK_BLL(string str)
        {
            return TKHLV_DAL.Instance.TenTK(str);
        }
        public DataTable FitlerTaiKhoanBy(string require, string IDHLV)
        {
            return TKHLV_DAL.Instance.FitlerTaiKhoanBy(require, IDHLV);
        }
        public List<string> FindListTKHLVByIDHLV(int IDHLV)
        {
            return TKHLV_DAL.Instance.FindListTKHLVByIDHLV(IDHLV);
        }
    }
}
