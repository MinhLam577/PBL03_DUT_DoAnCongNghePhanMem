using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using QLPhongGym.BLL;
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
            dt.Columns.Add("Tên khách hàng", typeof(string));
            dt.Columns.Add("Tên gói tập", typeof(string));
            dt.Columns.Add("Tên huấn luyện viên", typeof(string));
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
        public DataTable SearchHoaDon_DAL(string str, string require, int year)
        {
            DataTable dt = null;
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                int cnt = 1;
                switch (require)
                {
                    case "Tất cả":
                        dt = createDataTable();
                        var s = db.HoaDons.Where(p => (p.IDHD.ToString().Contains(str) && p.NgayThanhToan.Value.Year == year)
                        || (p.IDKH.ToString().Contains(str) && p.NgayThanhToan.Value.Year == year))
                    .Select(p => new { p.IDHD, p.IDKH, p.IDGT, p.NgayThanhToan, p.Price, p.IDLT }).ToList();
                        foreach (var item in s)
                        {
                            string tenhlv = "NA", tengoitap = "NA";
                            if (item.IDLT != null)
                                tenhlv = UsersBLL.Instance.GetUserByID(LichThueBLL.Instance.GetLichThueByIDLT(item.IDLT.Value).IDHLV).Name;
                            if (item.IDGT != null)
                                tengoitap = GoiTapBLL.Instance.GetGTByID(item.IDGT.Value).NameGT;
                            dt.Rows.Add(cnt++, item.IDHD, item.IDKH, (UsersDAL.Instance.GetUserByID(item.IDKH)).Name, tengoitap, tenhlv, item.NgayThanhToan, item.Price);
                        }
                        return dt;
                    case "Gói tập":
                        dt = new DataTable();
                        dt.Columns.Add("STT", typeof(int));
                        dt.Columns.Add("Mã hóa đơn", typeof(int));
                        dt.Columns.Add("Mã khách hàng", typeof(int));
                        dt.Columns.Add("Tên khách hàng", typeof(string));
                        dt.Columns.Add("Tên gói tập", typeof(string));
                        dt.Columns.Add("Ngày đăng kí", typeof(DateTime));
                        dt.Columns.Add("Giá tiền(vnd)", typeof(double));
                        var s1 = from gt in db.GoiTaps
                                 join hd in db.HoaDons
                                 on gt.IDGT equals hd.IDGT
                                 where (hd.IDHD.ToString().Contains(str) && hd.NgayThanhToan.Value.Year == year) || (hd.IDKH.ToString().Contains(str) && hd.NgayThanhToan.Value.Year == year)
                                 select new { hd.IDHD, hd.IDKH, gt.NameGT, hd.NgayThanhToan, hd.Price };
                        foreach (var item in s1)
                        {
                            dt.Rows.Add(cnt++, item.IDHD, item.IDKH, (UsersDAL.Instance.GetUserByID(item.IDKH)).Name, item.NameGT, item.NgayThanhToan, item.Price);
                        }
                        return dt;
                    case "Lịch thuê huấn luyện viên":
                        dt = new DataTable();
                        dt.Columns.Add("STT", typeof(int));
                        dt.Columns.Add("Mã hóa đơn", typeof(int));
                        dt.Columns.Add("Mã khách hàng", typeof(int));
                        dt.Columns.Add("Tên khách hàng", typeof(string));
                        dt.Columns.Add("Tên huấn luyện viên", typeof(string));
                        dt.Columns.Add("Ngày đăng kí", typeof(DateTime));
                        dt.Columns.Add("Giá tiền(vnd)", typeof(double));
                        var s2 = from lt in db.LichThueHLVs
                                 join hd in db.HoaDons
                                 on lt.IDLT equals hd.IDLT
                                 where (hd.IDHD.ToString().Contains(str) && hd.NgayThanhToan.Value.Year == year) || (hd.IDKH.ToString().Contains(str) && hd.NgayThanhToan.Value.Year == year)
                                 select new { hd.IDHD, hd.IDKH, lt.IDHLV, hd.NgayThanhToan, hd.Price };
                        foreach (var item in s2)
                        {
                            string tenhlv = UsersBLL.Instance.GetUserByID(item.IDHLV).Name;
                            dt.Rows.Add(cnt++, item.IDHD, item.IDKH, (UsersDAL.Instance.GetUserByID(item.IDKH)).Name, tenhlv, item.NgayThanhToan, item.Price);
                        }
                        return dt;
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
                var hoadons = db.HoaDons.Where(p => p.IDHD.ToString().Equals(str)).Select(p => new { p.IDHD,p.IDKH, p.IDLT, p.IDGT, p.NgayThanhToan,p.Price });
                int cnt = 0;
                foreach (var item in hoadons)
                {
                    string tenhlv = "NA", tengoitap = "NA";
                    if (item.IDLT != null)
                        tenhlv = UsersBLL.Instance.GetUserByID(LichThueBLL.Instance.GetLichThueByIDLT(item.IDLT.Value).IDHLV).Name;
                    if (item.IDGT != null)
                        tengoitap = GoiTapBLL.Instance.GetGTByID(item.IDGT.Value).NameGT;
                    dt.Rows.Add(++cnt, item.IDHD, item.IDKH, (UsersDAL.Instance.GetUserByID(item.IDKH)).Name, tengoitap, tenhlv, item.NgayThanhToan, item.Price);
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
        public DataTable GetHoaDonByYear(int Year)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                DataTable dt = createDataTable();
                int cnt = 1;
                var list_hd = db.HoaDons.Where(p => p.NgayThanhToan.Value.Year == Year).Select(p => new { p.IDHD, p.IDKH, p.IDGT, p.NgayThanhToan, p.Price, p.IDLT });
                foreach (var item in list_hd)
                {
                    string tenhlv = "NA", tengoitap = "NA";
                    if (item.IDLT != null)
                        tenhlv = UsersBLL.Instance.GetUserByID(LichThueBLL.Instance.GetLichThueByIDLT(item.IDLT.Value).IDHLV).Name;
                    if (item.IDGT != null)
                        tengoitap = GoiTapBLL.Instance.GetGTByID(item.IDGT.Value).NameGT;
                    dt.Rows.Add(cnt++, item.IDHD, item.IDKH, (UsersDAL.Instance.GetUserByID(item.IDKH)).Name, tengoitap, tenhlv, item.NgayThanhToan, item.Price);
                }
                return dt;
            }
        }
        public List<HoaDon> getListHoaDonByIDLT(int IDLT)
        {
            using(QLPhongGymDB db = new QLPhongGymDB())
            {
                return db.HoaDons.Where(s => s.IDLT.Value == IDLT).ToList();
            }
        }
        public List<HoaDon> GetListHoaDonByIDKH(int IDKH)
        {
            using(QLPhongGymDB db = new QLPhongGymDB())
            {
                return db.HoaDons.Where(s => s.IDKH == IDKH).ToList();
            }
        }
        public List<HoaDon> GetListHoaDonByIDGT(int IDGT)
        {
            using(QLPhongGymDB db = new QLPhongGymDB())
            {
                return db.HoaDons.Where(s => s.IDGT.Value == IDGT).ToList();
            }
        }
    }
}
