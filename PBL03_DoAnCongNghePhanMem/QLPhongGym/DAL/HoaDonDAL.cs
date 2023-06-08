using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhongGym.DTO;
namespace QLPhongGym.DAL
{
    class HoaDonDAL
    {
        private static HoaDonDAL instance;
        public static HoaDonDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDAL();
                return instance;
            }
            private set { }

        }
        public DataTable createDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Mã hóa đơn", typeof(int));
            dt.Columns.Add("Mã khách hàng", typeof(int));
            dt.Columns.Add("Tên gói tập", typeof(string));
            dt.Columns.Add("Ngày đăng kí", typeof(DateTime));
            dt.Columns.Add("Giá tiền(vnd)", typeof(double));
            return dt;
        }
        public int AddHoaDon(HoaDon hd)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                db.HoaDons.Add(hd);
                return db.SaveChanges();
            }

        }
        public int UpdateHoaDon(HoaDon hd)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                db.Entry(hd).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }

        }
        public void DeleteHoaDon(HoaDon hd)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                db.Entry(hd).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }

        }
        public double TongDoanhThuTheoNamVaThang(int year, int month)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                var data = db.HoaDons.ToList();
                double res = 0;
                foreach (HoaDon hd in data)
                {
                    if (hd.NgayThanhToan.Value.Year == year && hd.NgayThanhToan.Value.Month == month)
                    {
                        res += (double)hd.Price;
                    }
                }
                return res;
            }

        }
        public DataTable GetDuLieuHoaDon_DAL()
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                DataTable dt = new DataTable();
                int cnt = 1;
                dt = createDataTable();
                var str = db.HoaDons.Select(p => new { p.IDHD, p.IDKH, p.GoiTap.NameGT, p.NgayThanhToan, p.Price });
                foreach (var item in str)
                {
                    dt.Rows.Add(cnt++, item.IDHD, item.IDKH, item.NameGT, item.NgayThanhToan, item.Price);
                }
                return dt;
            }
        }
        public DataTable SearchHoaDon_DAL(string str)
        {
            DataTable dt = new DataTable();
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                int cnt = 1;
                var s = db.HoaDons.Where(p => p.IDHD.ToString().Contains(str) || p.IDKH.ToString().Contains(str) || p.GoiTap.NameGT.Contains(str)).Select(p => new { p.IDHD, p.IDKH, p.GoiTap.NameGT, p.NgayThanhToan, p.Price }).ToList();
                dt = createDataTable();
                foreach (var item in s)
                {
                    dt.Rows.Add(cnt++, item.IDHD, item.IDKH, item.NameGT, item.NgayThanhToan, item.Price);
                }
                return dt;
            }
        }
        public DataTable GetHoaDonByID_DAL(string str)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                DataTable dt = new DataTable();
                dt = createDataTable();
                var hoadons = db.HoaDons.Where(p => p.IDHD.ToString().Contains(str)).Select(p => new { p.IDHD,p.IDKH, p.GoiTap.NameGT, p.NgayThanhToan,p.Price });
                foreach (var item in hoadons)
                {
                    dt.Rows.Add(1, item.IDHD, item.IDKH, item.NameGT, item.NgayThanhToan, item.Price);
                }
                return dt;
            }
        }
        public User GetTenUser_DAL(int id)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                User s = db.Users.FirstOrDefault(p => p.IDUsers == id);
                return s;
            }
        }
    }
}
