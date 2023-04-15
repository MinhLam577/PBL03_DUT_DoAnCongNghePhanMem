using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Data;
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
        QLPhongGymDB db = new QLPhongGymDB();
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
                new DataColumn{ColumnName = "DaysLeft", DataType = typeof(double)}
            });
            return dt;
        }

        public DataTable GetDKKHDataTableByIDKH(int IDKH)
        {
            dt = CreateTable();
            var data = (from dkgt in db.DangKiGoiTaps
                        join kh in db.Users.OfType<KH>() on dkgt.IDKH equals kh.IDUsers
                        join gt in db.GoiTaps on dkgt.IDGT equals gt.IDGT
                        where kh.IDUsers == IDKH && (DateTime)dkgt.NgayKetThucGT > DateTime.Now
                        orderby dkgt.NgayDangKiGT descending
                        select new
                        {
                            dkgt.IDDK,
                            kh.IDUsers,
                            kh.Name,
                            gt.NameGT,
                            dkgt.NgayDangKiGT,
                            dkgt.NgayKetThucGT
                        }).ToList().FirstOrDefault();
            if(data != default)
                dt.Rows.Add(data.IDUsers, data.Name, data.NameGT, data.NgayDangKiGT, data.NgayKetThucGT, (data.NgayKetThucGT - data.NgayDangKiGT).Value.TotalDays);
            return dt;
        }
        public DangKiGoiTap GetDKKHByIDKH(int IDKH)
        {
            DangKiGoiTap d = null;
            dt = CreateTable();
            var data = (from dkgt in db.DangKiGoiTaps
                        join kh in db.Users.OfType<KH>() on dkgt.IDKH equals kh.IDUsers
                        join gt in db.GoiTaps on dkgt.IDGT equals gt.IDGT
                        where kh.IDUsers == IDKH
                        orderby dkgt.NgayDangKiGT descending
                        select new
                        {
                            dkgt.IDDK,
                            dkgt.IDKH,
                            dkgt.IDGT,
                            kh.Name,
                            gt.NameGT,
                            dkgt.NgayDangKiGT,
                            dkgt.NgayKetThucGT
                        }).ToList().FirstOrDefault();
            if (data != null)
                d = new DangKiGoiTap
                {
                   IDDK = data.IDDK, IDKH = data.IDKH, IDGT = data.IDGT, NgayDangKiGT = data.NgayDangKiGT, NgayKetThucGT = data.NgayKetThucGT 
                };
            return d;
        }
        public DataTable SortDKKHBy(string Require, DataTable data)
        {
            DataView dv = data.DefaultView;
            switch (Require)
            {
                case "Tên":
                    dv.Sort = "Name";
                    dt = dv.ToTable();
                    break;
                case "Mã":
                    dv.Sort = "ID";
                    dt = dv.ToTable();
                    break;
                case "Giới tính":
                    dv.Sort = "Sex";
                    dt = dv.ToTable();
                    break;
                case "Gói tập":
                    dv.Sort = "GoiTap";
                    dt = dv.ToTable();
                    break;
            }
            return dt;
        }
        public DataTable FindListDKKHByIDOrName(string txt)
        {
            dt = CreateTable(); int cnt = 1;
            var data = (from kh in db.Users.OfType<KH>()
                        join dkgt in db.DangKiGoiTaps on kh.IDUsers equals dkgt.IDKH
                        join gt in db.GoiTaps on dkgt.IDGT equals gt.IDGT
                        where kh.IDUsers.ToString().Contains(txt) || kh.Name.Contains(txt)
                        select new
                        {
                            kh.IDUsers,
                            kh.Name,
                            kh.DateBorn,
                            kh.Sex,
                            kh.Sdt,
                            kh.Gmail,
                            kh.Address,
                            kh.CCCD,
                            dkgt.NgayDangKiGT,
                            dkgt.NgayKetThucGT,
                            gt.NameGT
                        }).ToList();
            foreach (var i in data)
                dt.Rows.Add(cnt++, i.IDUsers, i.Name, i.DateBorn, i.Sex, i.CCCD, i.Address, i.Gmail, i.Sdt, i.NgayDangKiGT, i.NgayKetThucGT , i.NameGT);
            return dt;
        }
        public int AddDKGT(DangKiGoiTap dkgt)
        {
            db.DangKiGoiTaps.Add(dkgt);
            return db.SaveChanges();
        }
        public void DeleteDKGT(DangKiGoiTap dkgt)
        {
            db.DangKiGoiTaps.Remove(dkgt);
            db.SaveChanges();
        }
        public int UpdateDKGT(DangKiGoiTap dkgt)
        {
            db.Entry(dkgt).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
        public List<DangKiGoiTap> GetAllDKGTByIDKH(int IDKH)
        {
            return db.DangKiGoiTaps.Where(s => (int)s.IDKH == IDKH).ToList();
        }
        public DangKiGoiTap GetDKGTByIDKH_NgayDangKi_NgayKetThuc(int IDKH, DateTime ngaydangki, DateTime ngayketthuc)
        {
            return db.DangKiGoiTaps.FirstOrDefault(s => (int)s.IDKH == IDKH && (DateTime)s.NgayDangKiGT == ngaydangki && (DateTime)s.NgayKetThucGT == ngayketthuc);
        }
        
        public void DeleteAllDKGTByIDKH(List<DangKiGoiTap> list)
        {
            foreach(DangKiGoiTap i in list)
                DeleteDKGT(i);
        }
        
    }
}
