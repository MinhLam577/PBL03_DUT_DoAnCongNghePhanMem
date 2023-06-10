using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QLPhongGym.DAL
{
    class DangKiGoiTapDAL
    {
        private static DangKiGoiTapDAL instance;
        public static DangKiGoiTapDAL Instance
        {
            get
            {
                if(instance == null)
                    instance = new DangKiGoiTapDAL();
                return instance;
            }
            private set { }
        }
        DataTable dt = null;
        public DataTable CreateTable()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "IDThe", DataType = typeof(int)},
                new DataColumn{ColumnName = "Name", DataType = typeof(string)},
                new DataColumn{ColumnName = "GoiTap", DataType = typeof(string)},
                new DataColumn{ColumnName = "NgayDangKi", DataType = typeof(DateTime)},
                new DataColumn{ColumnName = "NgayKetThuc", DataType = typeof(DateTime)},
                new DataColumn{ColumnName = "DaysLeft", DataType = typeof(double)},
                new DataColumn{ColumnName = "BaoLuu", DataType = typeof(bool)}
            });
            return dt;
        }
        public DataTable GetDKGT_Newest_DataTableByIDKH(int IDKH)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                dt = CreateTable();
                var data = (from dkgt in db.DangKiGoiTaps
                            join kh in db.Users.OfType<KH>() on dkgt.IDKH equals kh.IDUsers
                            join gt in db.GoiTaps on dkgt.IDGT equals gt.IDGT
                            where kh.IDUsers == IDKH && dkgt.NgayKetThucGT.Value >= DateTime.Today
                            orderby dkgt.NgayDangKiGT descending
                            select new
                            {
                                dkgt.IDDK,
                                kh.IDUsers,
                                kh.Name,
                                gt.NameGT,
                                dkgt.NgayDangKiGT,
                                dkgt.NgayKetThucGT,
                                dkgt.BaoLuu
                            }).ToList();
                if (data != default)
                    foreach (var d in data)
                        dt.Rows.Add(d.IDUsers, d.Name, d.NameGT, d.NgayDangKiGT, d.NgayKetThucGT, (d.NgayKetThucGT - DateTime.Today).Value.Days, d.BaoLuu);
                return dt;
            }
                
        }
        public DangKiGoiTap GetDKGT_Newest_ByIDKH(int IDKH)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                DangKiGoiTap d = null;
                dt = CreateTable();
                var data = (from dkgt in db.DangKiGoiTaps
                            join kh in db.Users.OfType<KH>() on dkgt.IDKH equals kh.IDUsers
                            join gt in db.GoiTaps on dkgt.IDGT equals gt.IDGT
                            where kh.IDUsers == IDKH && dkgt.NgayKetThucGT.Value >= DateTime.Today
                            orderby dkgt.NgayDangKiGT descending
                            select new
                            {
                                dkgt.IDDK,
                                dkgt.IDKH,
                                dkgt.IDGT,
                                kh.Name,
                                gt.NameGT,
                                dkgt.Description,
                                dkgt.NgayDangKiGT,
                                dkgt.NgayKetThucGT,
                                dkgt.BaoLuu,
                            }).ToList().FirstOrDefault();
                if (data != null)
                    d = new DangKiGoiTap
                    {
                        IDDK = data.IDDK,
                        IDKH = data.IDKH,
                        IDGT = data.IDGT,
                        NgayDangKiGT = data.NgayDangKiGT,
                        NgayKetThucGT = data.NgayKetThucGT,
                        Description = data.Description,
                        BaoLuu = data.BaoLuu,
                    };
                return d;
            }
                
        }
        public DataTable FitlerListDKGT(int IDKH, string require, string GoiTap)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                dt = CreateTable();
                switch (require)
                {
                    case "Tất cả":
                        switch (GoiTap)
                        {
                            case "None":
                                break;
                            case "Tất cả":
                                var data1 = (from dkgt in db.DangKiGoiTaps
                                             join kh in db.Users.OfType<KH>() on dkgt.IDKH equals kh.IDUsers
                                             join gt in db.GoiTaps on dkgt.IDGT equals gt.IDGT
                                             where kh.IDUsers == IDKH
                                             select new
                                             {
                                                 dkgt.IDDK,
                                                 kh.IDUsers,
                                                 kh.Name,
                                                 gt.NameGT,
                                                 dkgt.NgayDangKiGT,
                                                 dkgt.NgayKetThucGT,
                                                 dkgt.BaoLuu
                                             }).ToList();
                                if (data1 != null)
                                    foreach (var d in data1)
                                    {
                                        int Day = (d.NgayKetThucGT - DateTime.Today).Value.Days;
                                        if (Day < 0) Day = 0;
                                        dt.Rows.Add(d.IDUsers, d.Name, d.NameGT, d.NgayDangKiGT, d.NgayKetThucGT, Day, d.BaoLuu);
                                    }
                                return dt;
                            default:
                                var data2 = (from dkgt in db.DangKiGoiTaps
                                             join kh in db.Users.OfType<KH>() on dkgt.IDKH equals kh.IDUsers
                                             join gt in db.GoiTaps on dkgt.IDGT equals gt.IDGT
                                             where kh.IDUsers == IDKH && gt.NameGT == GoiTap
                                             select new
                                             {
                                                 dkgt.IDDK,
                                                 kh.IDUsers,
                                                 kh.Name,
                                                 gt.NameGT,
                                                 dkgt.NgayDangKiGT,
                                                 dkgt.NgayKetThucGT,
                                                 dkgt.BaoLuu
                                             }).ToList();
                                if (data2 != null)
                                    foreach (var d in data2)
                                    {
                                        int Day = (d.NgayKetThucGT - DateTime.Today).Value.Days;
                                        if (Day < 0) Day = 0;
                                        dt.Rows.Add(d.IDUsers, d.Name, d.NameGT, d.NgayDangKiGT, d.NgayKetThucGT, Day, d.BaoLuu);
                                    }
                                return dt;
                        }
                        break;
                    case "Đang tập":
                        switch (GoiTap)
                        {
                            case "None":
                                break;
                            case "Tất cả":
                                var data1 = (from dkgt in db.DangKiGoiTaps
                                             join kh in db.Users.OfType<KH>() on dkgt.IDKH equals kh.IDUsers
                                             join gt in db.GoiTaps on dkgt.IDGT equals gt.IDGT
                                             where kh.IDUsers == IDKH && dkgt.NgayKetThucGT.Value >= DateTime.Today && dkgt.BaoLuu == false
                                             select new
                                             {
                                                 dkgt.IDDK,
                                                 kh.IDUsers,
                                                 kh.Name,
                                                 gt.NameGT,
                                                 dkgt.NgayDangKiGT,
                                                 dkgt.NgayKetThucGT,
                                                 dkgt.BaoLuu
                                             }).ToList();
                                if (data1 != null)
                                    foreach (var d in data1)
                                    {
                                        int Day = (d.NgayKetThucGT - DateTime.Today).Value.Days;
                                        if (Day < 0) Day = 0;
                                        dt.Rows.Add(d.IDUsers, d.Name, d.NameGT, d.NgayDangKiGT, d.NgayKetThucGT, Day, d.BaoLuu);
                                    }
                                return dt;
                            default:
                                var data2 = (from dkgt in db.DangKiGoiTaps
                                             join kh in db.Users.OfType<KH>() on dkgt.IDKH equals kh.IDUsers
                                             join gt in db.GoiTaps on dkgt.IDGT equals gt.IDGT
                                             where kh.IDUsers == IDKH && gt.NameGT == GoiTap && dkgt.NgayKetThucGT.Value >= DateTime.Today && dkgt.BaoLuu == false
                                             select new
                                             {
                                                 dkgt.IDDK,
                                                 kh.IDUsers,
                                                 kh.Name,
                                                 gt.NameGT,
                                                 dkgt.NgayDangKiGT,
                                                 dkgt.NgayKetThucGT,
                                                 dkgt.BaoLuu
                                             }).ToList();
                                if (data2 != null)
                                    foreach (var d in data2)
                                    {
                                        int Day = (d.NgayKetThucGT - DateTime.Today).Value.Days;
                                        if (Day < 0) Day = 0;
                                        dt.Rows.Add(d.IDUsers, d.Name, d.NameGT, d.NgayDangKiGT, d.NgayKetThucGT, Day, d.BaoLuu);
                                    }
                                return dt;
                        }
                        break;
                    case "Đang bảo lưu":
                        switch (GoiTap)
                        {
                            case "None":
                                break;
                            case "Tất cả":
                                var data1 = (from dkgt in db.DangKiGoiTaps
                                             join kh in db.Users.OfType<KH>() on dkgt.IDKH equals kh.IDUsers
                                             join gt in db.GoiTaps on dkgt.IDGT equals gt.IDGT
                                             where kh.IDUsers == IDKH && dkgt.NgayKetThucGT.Value >= DateTime.Today && dkgt.BaoLuu == true
                                             select new
                                             {
                                                 dkgt.IDDK,
                                                 kh.IDUsers,
                                                 kh.Name,
                                                 gt.NameGT,
                                                 dkgt.NgayDangKiGT,
                                                 dkgt.NgayKetThucGT,
                                                 dkgt.BaoLuu
                                             }).ToList();
                                if (data1 != null)
                                    foreach (var d in data1)
                                    {
                                        int Day = (d.NgayKetThucGT - DateTime.Today).Value.Days;
                                        if (Day < 0) Day = 0;
                                        dt.Rows.Add(d.IDUsers, d.Name, d.NameGT, d.NgayDangKiGT, d.NgayKetThucGT, Day, d.BaoLuu);
                                    }
                                return dt;
                            default:
                                var data2 = (from dkgt in db.DangKiGoiTaps
                                             join kh in db.Users.OfType<KH>() on dkgt.IDKH equals kh.IDUsers
                                             join gt in db.GoiTaps on dkgt.IDGT equals gt.IDGT
                                             where kh.IDUsers == IDKH && gt.NameGT == GoiTap && dkgt.NgayKetThucGT.Value >= DateTime.Today && dkgt.BaoLuu == true
                                             select new
                                             {
                                                 dkgt.IDDK,
                                                 kh.IDUsers,
                                                 kh.Name,
                                                 gt.NameGT,
                                                 dkgt.NgayDangKiGT,
                                                 dkgt.NgayKetThucGT,
                                                 dkgt.BaoLuu
                                             }).ToList();
                                if (data2 != null)
                                    foreach (var d in data2)
                                    {
                                        int Day = (d.NgayKetThucGT - DateTime.Today).Value.Days;
                                        if (Day < 0) Day = 0;
                                        dt.Rows.Add(d.IDUsers, d.Name, d.NameGT, d.NgayDangKiGT, d.NgayKetThucGT, Day, d.BaoLuu);
                                    }
                                return dt;
                        }
                        break;
                    case "Đã hết hạn":
                        switch (GoiTap)
                        {
                            case "None":
                                break;
                            case "Tất cả":
                                var data1 = (from dkgt in db.DangKiGoiTaps
                                             join kh in db.Users.OfType<KH>() on dkgt.IDKH equals kh.IDUsers
                                             join gt in db.GoiTaps on dkgt.IDGT equals gt.IDGT
                                             where kh.IDUsers == IDKH && dkgt.NgayKetThucGT.Value < DateTime.Today
                                             select new
                                             {
                                                 dkgt.IDDK,
                                                 kh.IDUsers,
                                                 kh.Name,
                                                 gt.NameGT,
                                                 dkgt.NgayDangKiGT,
                                                 dkgt.NgayKetThucGT,
                                                 dkgt.BaoLuu
                                             }).ToList();
                                if (data1 != null)
                                    foreach (var d in data1)
                                    {
                                        int Day = (d.NgayKetThucGT - DateTime.Today).Value.Days;
                                        if (Day < 0) Day = 0;
                                        dt.Rows.Add(d.IDUsers, d.Name, d.NameGT, d.NgayDangKiGT, d.NgayKetThucGT, Day, d.BaoLuu);
                                    }
                                return dt;
                            default:
                                var data2 = (from dkgt in db.DangKiGoiTaps
                                             join kh in db.Users.OfType<KH>() on dkgt.IDKH equals kh.IDUsers
                                             join gt in db.GoiTaps on dkgt.IDGT equals gt.IDGT
                                             where kh.IDUsers == IDKH && gt.NameGT == GoiTap && dkgt.NgayKetThucGT.Value < DateTime.Today
                                             select new
                                             {
                                                 dkgt.IDDK,
                                                 kh.IDUsers,
                                                 kh.Name,
                                                 gt.NameGT,
                                                 dkgt.NgayDangKiGT,
                                                 dkgt.NgayKetThucGT,
                                                 dkgt.BaoLuu
                                             }).ToList();
                                if (data2 != null)
                                    foreach (var d in data2)
                                    {
                                        int Day = (d.NgayKetThucGT - DateTime.Today).Value.Days;
                                        if (Day < 0) Day = 0;
                                        dt.Rows.Add(d.IDUsers, d.Name, d.NameGT, d.NgayDangKiGT, d.NgayKetThucGT, Day, d.BaoLuu);
                                    }
                                return dt;
                        }
                        break;
                    default:
                        break;
                }
                return dt;
            }
               
        }
        public int AddDKGT(DangKiGoiTap dkgt)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                try
                {
                    db.DangKiGoiTaps.Add(dkgt);
                    return db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Thêm đăng kí gói tập thất bại");
                    return 0;
                }
                
            }
                
        }
        public void DeleteDKGT(DangKiGoiTap dkgt)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                try
                {
                    db.Entry(dkgt).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Xóa đăng kí gói tập thất bại");
                }
                
            }
                
        }
        public int UpdateDKGT(DangKiGoiTap dkgt)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                try
                {
                    db.Entry(dkgt).State = System.Data.Entity.EntityState.Modified;
                    return db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Cật nhật đăng kí gói tập thất bại");
                    return 0;
                }
                
            }
               
        }
        public List<DangKiGoiTap> GetAllDKGTByIDKH(int IDKH)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
                return db.DangKiGoiTaps.Where(s => (int)s.IDKH == IDKH).ToList();
        }
        public void DeleteAllDKGT(List<DangKiGoiTap> list)
        {
            foreach(DangKiGoiTap i in list)
                DeleteDKGT(i);
        }
        public DangKiGoiTap GetDKGT_Newest_ByIDKH_IDGT(int IDKH, int IDGT)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
                return db.DangKiGoiTaps.Where(s => (int)s.IDKH == IDKH && (int)s.IDGT == IDGT && s.NgayKetThucGT >= DateTime.Today).OrderByDescending(s => s.NgayDangKiGT).FirstOrDefault();
        }
        public DangKiGoiTap GetDKGTByIDKH_NgayDangKi_IDGT(int IDKH, DateTime ngaydangki, int IDGT)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
                return db.DangKiGoiTaps.Where(s => (int)s.IDKH == IDKH && s.NgayDangKiGT == ngaydangki && (int)s.IDGT == IDGT).FirstOrDefault();
        }
        public DangKiGoiTap GetDLGTByIDKH_NgayDangKi_NgayKetThuc_IDGT(int IDKH, DateTime ngaydangki, DateTime ngayketthuc, int IDGT)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
                return db.DangKiGoiTaps.Where(s => (int)s.IDKH == IDKH && s.NgayDangKiGT.Value == ngaydangki && s.NgayKetThucGT.Value == ngayketthuc && (int)s.IDGT == IDGT).FirstOrDefault();
        }
        public List<DangKiGoiTap> GetListDKGTDangTap(int IDKH)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
                return db.DangKiGoiTaps.Where(s => s.IDKH.Value == IDKH && s.NgayKetThucGT.Value >= DateTime.Today && s.BaoLuu == false).ToList();
        }
        public int GetSoLuongDKGTTheoNamVaThang(int year, int month)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                var data = db.DangKiGoiTaps.ToList();
                int cnt = 0;
                foreach (DangKiGoiTap dkgt in data)
                    if (dkgt.NgayDangKiGT.Value.Year == year && dkgt.NgayDangKiGT.Value.Month == month)
                        cnt++;
                return cnt;
            }
                
        }
        public int GetSoLuongNhuCauDKGTTheoNam_Thang_IDGT(int year, int month, int IDGT)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                var data = db.DangKiGoiTaps.ToList();
                int cnt = 0;
                foreach (DangKiGoiTap dkgt in data)
                    if (dkgt.NgayDangKiGT.Value.Year == year && dkgt.NgayDangKiGT.Value.Month == month && dkgt.IDGT.Value == IDGT)
                        cnt++;
                return cnt;
            }
                
        }
        public List<DangKiGoiTap> GetListDKGTByYear(int year)
        {
            using(QLPhongGymDB db = new QLPhongGymDB())
            {
                return db.DangKiGoiTaps.Where(s => s.NgayDangKiGT.Value.Year == year).ToList();
            }
        }
        public List<DangKiGoiTap> GetListDKGTByIDGT(int IDGT)
        {
            using(QLPhongGymDB db = new QLPhongGymDB())
            {
                return db.DangKiGoiTaps.Where(s => s.IDGT.Value == IDGT).ToList();
            }
        }
    }
}
