using QLPhongGym.DAL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.BLL
{
    class ThietBi_BLL
    {
        private static ThietBi_BLL instance;
        public static ThietBi_BLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThietBi_BLL();
                return instance;
            }
            private set { }
        }
        public DataTable GetAllThietBi_BLL()
        {
            DataTable dt = ThietBiDAL.Instance.GetAllDanhSachThietBi_DAL();
            return dt;
        }
        public void DeleteTB_BLL(int mtb)
        {
            ThietBiDAL.Instance.DeleteTB_DAL(mtb);
        }
        public void UpdateThietBi_BLL(ThietBi tb)
        {
            ThietBiDAL.Instance.UpdateThietBi_DAL(tb);
        }
        public void AddThietBi_BLL(ThietBi tb)
        {
            ThietBiDAL.Instance.AddThietBi_DAL(tb);
        }
        public DataTable Search_BLL(string str)
        {
            return ThietBiDAL.Instance.SearchTB_DAL(str);
        }
        public DataTable Sort_BLL(string sort, string search)
        {
            return ThietBiDAL.Instance.Sort_DLL(sort, search);
        }
        public ThietBi GetThietBiByID_BLL(int id)
        {
            return ThietBiDAL.Instance.GetThietBiByID(id);
        }
        public bool KiemTraTen_BLL(string name)
        {
            return ThietBiDAL.Instance.KiemTraTen_DAL(name);
        }
        public List<ThietBi> GetAllTB()
        {
            return ThietBiDAL.Instance.GetAllTB();
        }
        public int GetTongSoLuongThietBiCoSan()
        {
            return ThietBiDAL.Instance.GetTongSoLuongThietBiCoSan();
        }
    }
}
