using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhongGym.DTO;
namespace QLPhongGym.DAL
{
    class HoaDonDAL
    {
        private static HoaDonDAL instance;
        QLPhongGymDB db = new QLPhongGymDB();
        public static HoaDonDAL Instance
        {
            get
            {
                if(instance == null)
                    instance = new HoaDonDAL();
                return instance;
            }
            private set { }
            
        }
        public int AddHoaDon(HoaDon hd)
        {
            db.HoaDons.Add(hd);
            return db.SaveChanges();
        }
        public int UpdateHoaDon(HoaDon hd)
        {
            db.Entry(hd).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges() ;
        }
        public void DeleteHoaDon(HoaDon hd)
        {
            db.HoaDons.Remove(hd);
            db.SaveChanges();
        }
        public double TongDoanhThuTheoNamVaThang(int year, int month)
        {
            var data = db.HoaDons.ToList();
            double res = 0;
            foreach( HoaDon hd in data )
            {
                if(hd.NgayThanhToan.Value.Year == year && hd.NgayThanhToan.Value.Month == month)
                {
                    res += (double)hd.Price;
                }
            }
            return res;
        }
    }
}
