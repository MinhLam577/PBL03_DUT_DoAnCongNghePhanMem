using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhongGym.DAL;
using QLPhongGym.DTO;
namespace QLPhongGym.BLL
{
    public class KHBLL:UsersBLL
    {
        private static KHBLL instance;
        public static KHBLL Instance
        {
            get
            {
                if(instance == null)
                    instance = new KHBLL();
                return instance;
            }
            private set { }
        }

        public DataTable CreateTable()
        {
            return KHDAL.Instance.CreateTable();    
        }
        public KH GetKHByID(int ID)
        {
            return (KH)UsersBLL.Instance.GetUserByID(ID);
        }
        public DataTable FindListKHByIDOrName(string txt)
        {
            return KHDAL.Instance.FindListKHByIDOrName(txt);
        }
        public DataTable FindListKHByNameAndID(string Name, string ID)
        {
            return KHDAL.Instance.FindListKHByNameAndID(Name, ID);
        }
        public DataTable FindListKHBySdtOrCCCD(string txt)
        {
            return KHDAL.Instance.FindListKHBySDTOrCCCD(txt);
        }
        public DataTable FindListKHBySDTAndCCCD(string sdt, string cccd)
        {
            return KHDAL.Instance.FindListKHBySDTAndCCCD(sdt, cccd);
        }
        public DataTable SortListKHBy(string require, DataTable dt)
        {
            return KHDAL.Instance.SortDKKHBy(require, dt);
        }
        public DataTable FindListKHBySDT(string Sdt)
        {
            return KHDAL.Instance.FindListKHBySDT(Sdt);
        }
        public DataTable FindListKHByID(string ID)
        {
            return KHDAL.Instance.FindListKHByID(ID);
        }
        public DataTable FindListKHByCCCD(string CCCD)
        {
            return KHDAL.Instance.FindListKHByCCCD(CCCD);
        }
        public DataTable FindListKHByName(string Name)
        {
            return KHDAL.Instance.FindListKHByName(Name);
        }
        public List<int> GetAllKHID()
        {
            return KHDAL.Instance.GetAllKHID();
        }
        public DataTable FindListKHByIDHLV_NgayThue_IDCa_IDOrName(string txt, int IDHLV, DateTime NgayThue, int? IDCa)
        {
            return KHDAL.Instance.FindListKHByIDHLV_NgayThue_IDCa_IDOrName(txt, IDHLV, NgayThue, IDCa);
        }
        public DataTable GetListKH_ByYear(int Year)
        {
            return KHDAL.Instance.GetListKH_ByYear(Year);
        }
    }
}
