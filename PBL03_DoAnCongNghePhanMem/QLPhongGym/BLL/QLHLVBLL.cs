
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhongGym.DAL;
using QLPhongGym.DTO;
using System.Drawing;
using System.Net;

namespace QLPhongGym.BLL
{
    public class QLHLVBLL : UsersBLL
    {
        private static QLHLVBLL instance;
        public QLHLVBLL()
        {

        }
        public static QLHLVBLL getInstance
        {
            get
            {
                if (instance == null)
                    instance = new QLHLVBLL();
                return instance;
            }
            private set
            {

            }
        }
        QLPhongGymDB db = new QLPhongGymDB();
        DataTable dt = new DataTable();
        public DataTable CapNhatListHLV()
        {
            return QLHLVDAL.getInstance.CapNhatListHLV();
        }
        public bool Delete(int idHLv)
        {
            return QLHLVDAL.getInstance.Delete(idHLv);
        }
        // them 
        public bool Them(HLV a )
        {
            return QLHLVDAL.getInstance.Them(a);
        }
        // sửa 
        public bool Update(HLV a)
        {
            return QLHLVDAL.getInstance.Update(a);
        }
        public DataTable SearchHLVByNameID(string NameorId)
        {
            return QLHLVDAL.getInstance.SearchHLVByNameID(NameorId);
        }
        public DataTable SortHLV(string required, string NameorId)
        {
            return QLHLVDAL.getInstance.SortHLV(required, NameorId);
        }
        public HLV GetInfoHLV(int ma)
        {
            return QLHLVDAL.getInstance.GetInfoHLV(ma);
        }
        public bool CheckCmndExitEDit(HLV a)
        {
            return QLHLVDAL.getInstance.CheckCmndExitEDit(a);
        }
        public bool CheckSDTExitEdit(HLV a)
        {
            return QLHLVDAL.getInstance.CheckSDTExitEdit(a);
        }
        public bool CheckGmailExitEdit(HLV a)
        {
            return QLHLVDAL.getInstance.CheckGmailExitEdit(a);
        }
        public List<HLV> GetHLVs()
        {
            return QLHLVDAL.getInstance.getHLVs();
        }
        public DataTable getinfoLichHLV()
        {
            dt = new DataTable();
            return QLHLVDAL.getInstance.getinfoLichHLV();
        }
        public List<int> GetAllHLVID()
        {
            return db.Users.OfType<HLV>().Select(s => s.IDUsers).ToList();
        }
        public DataTable GetListHLV_ByYear(int Year)
        {
            return QLHLVDAL.getInstance.GetListHLV_ByYear(Year);
        }
    }
}
