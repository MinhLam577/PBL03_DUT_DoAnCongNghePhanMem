using QLPhongGym.DAL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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
        public bool Them(string name, DateTime ngaysinh, bool sex, string cccd, string gmail, string sdt, string diachi, string degree, string anh)
        {
            return QLHLVDAL.getInstance.Them(name, ngaysinh, sex, cccd, gmail, sdt, diachi, degree, anh);
        }
        // sửa 
        public bool Update(int ma, string name, DateTime ngaysinh, bool sex, string cccd, string gmail, string sdt, string diachi, string degree, string anh)
        {
            return QLHLVDAL.getInstance.Update(ma, name, ngaysinh, sex, cccd, gmail, sdt, diachi, degree, anh);
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
        public List<int> GetAllHLVID()
        {
            return QLHLVDAL.getInstance.GetAllHLVID();
        }
    }
}
