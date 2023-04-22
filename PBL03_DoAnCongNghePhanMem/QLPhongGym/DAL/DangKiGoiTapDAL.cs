﻿using QLPhongGym.DTO;
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
                new DataColumn{ColumnName = "DaysLeft", DataType = typeof(double)},
                new DataColumn{ColumnName = "BaoLuu", DataType = typeof(bool)}
            });
            return dt;
        }
        public DataTable GetDKKH_Newest_DataTableByIDKH(int IDKH)
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
        public DangKiGoiTap GetDKKH_Newest_ByIDKH(int IDKH)
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
        public void DeleteAllDKGTByIDKH(List<DangKiGoiTap> list)
        {
            foreach(DangKiGoiTap i in list)
                DeleteDKGT(i);
        }
        public DangKiGoiTap GetDKGTByIDKH_NgayDangKi_IDGT(int IDKH, DateTime ngaydangki, int IDGT)
        {
            return db.DangKiGoiTaps.Where(s => (int)s.IDKH == IDKH && s.NgayDangKiGT == ngaydangki && (int)s.IDGT == IDGT).FirstOrDefault();
        }
        public DangKiGoiTap GetDLGTByIDKH_NgayDangKi_NgayKetThuc_IDGT(int IDKH, DateTime ngaydangki, DateTime ngayketthuc, int IDGT)
        {
            return db.DangKiGoiTaps.Where(s => (int)s.IDKH == IDKH && s.NgayDangKiGT.Value == ngaydangki && s.NgayKetThucGT.Value == ngayketthuc && (int)s.IDGT == IDGT).FirstOrDefault();
        }
        
    }
}