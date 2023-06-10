using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhongGym.DTO;
using QLPhongGym.DAL;
using System.Data;

namespace QLPhongGym.BLL
{
    class HoaDonBLL
    {
        private static HoaDonBLL instance;
        public static HoaDonBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonBLL();
                return instance;
            }
            private set { }

        }
        public bool AddHoaDon(HoaDon hd)
        {
            return HoaDonDAL.Instance.AddHoaDon(hd) > 0;
        }
        public bool UpdateHoaDon(HoaDon hd)
        {
            return HoaDonDAL.Instance.UpdateHoaDon(hd) > 0;
        }
        public void DeleteHoaDon(HoaDon hd)
        {
            HoaDonDAL.Instance.DeleteHoaDon(hd);
        }
        public double GetTongDoanhThuTheoNamVaThang(int year, int month)
        {
            return HoaDonDAL.Instance.TongDoanhThuTheoNamVaThang(year, month);
        }
        public DataTable SearchHoaDon_BLL(string str, string require, int year)
        {
            return HoaDonDAL.Instance.SearchHoaDon_DAL(str, require, year);
        }
        public DataTable GetHoaDonByID_BLL(string str)
        {
            return HoaDonDAL.Instance.GetHoaDonByID_DAL(str);
        }
        public User GetTenUser_BLL(int id)
        {
            return HoaDonDAL.Instance.GetTenUser_DAL(id);
        }
        public DataTable GetHoaDonByYear(int Year)
        {
            return HoaDonDAL.Instance.GetHoaDonByYear(Year);
        }
        public List<HoaDon> getListHoaDonByIDLT(int IDLT)
        {
            return HoaDonDAL.Instance.getListHoaDonByIDLT(IDLT);
        }
        public List<HoaDon> GetListHoaDonByIDKH(int IDKH)
        {
            return HoaDonDAL.Instance.GetListHoaDonByIDKH(IDKH);
        }
        public List<HoaDon> GetListHoaDonByIDGT(int IDGT)
        {
            return HoaDonDAL.Instance.GetListHoaDonByIDGT(IDGT);
        }
    }
}
