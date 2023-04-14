using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                new DataColumn{ColumnName = "STT", DataType = typeof(int)},
                new DataColumn{ColumnName = "ID", DataType = typeof(int)},
                new DataColumn{ColumnName = "Name", DataType = typeof(string)},
                new DataColumn{ColumnName = "DateBorn", DataType = typeof(DateTime)},
                new DataColumn{ColumnName = "Sex", DataType = typeof(bool)},
                new DataColumn{ColumnName = "CCCD", DataType = typeof(string)},
                new DataColumn{ColumnName = "Address", DataType = typeof(string)},
                new DataColumn{ColumnName = "Gmail", DataType = typeof(string)},
                new DataColumn{ColumnName = "Sdt", DataType = typeof (string)},
                new DataColumn{ColumnName = "NgayDangKi", DataType = typeof(DateTime)},
                new DataColumn{ColumnName = "NgayKetThuc", DataType = typeof(DateTime)},
                new DataColumn{ColumnName = "GoiTap", DataType = typeof(string)}
            });
            return dt;
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
        public DangKiGoiTap GetDKGTByIDKH_NgayDangKi_NgayKetThuc(int IDKH, DateTime ngaydangki, DateTime ngayketthuc)
        {
            return db.DangKiGoiTaps.FirstOrDefault(s => (int)s.IDKH == IDKH && s.NgayDangKiGT == ngaydangki && s.NgayKetThucGT == ngayketthuc);
        }
    }
}
