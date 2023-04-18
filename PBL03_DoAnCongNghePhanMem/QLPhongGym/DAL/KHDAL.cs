using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongGym.DTO;

namespace QLPhongGym.DAL
{
    class KHDAL
    {
        private static KHDAL instance;
        public static KHDAL Instance
        {
            get
            {
                if(instance == null)
                    instance = new KHDAL();
                return instance;
            }
            private set { }
        }
        QLPhongGymDB db = new QLPhongGymDB();
        DataTable dt = null;
        public DataTable CreateTable()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "STT", DataType = typeof(int)},
                new DataColumn{ColumnName = "IDThe", DataType = typeof(int)},
                new DataColumn{ColumnName = "Name", DataType = typeof(string)},
                new DataColumn{ColumnName = "DateBorn", DataType = typeof(DateTime)},
                new DataColumn{ColumnName = "Sex", DataType = typeof(bool)},
                new DataColumn{ColumnName = "CCCD", DataType = typeof(string)},
                new DataColumn{ColumnName = "Address", DataType = typeof(string)},
                new DataColumn{ColumnName = "Gmail", DataType = typeof(string)},
                new DataColumn{ColumnName = "Sdt", DataType = typeof (string)},
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
                case "Mã thẻ":
                    dv.Sort = "IDThe";
                    dt = dv.ToTable();
                    break;
                case "Giới tính":
                    dv.Sort = "Sex";
                    dt = dv.ToTable();
                    break;
            }
            return dt;
        }
        
        public DataTable FindListKHByIDOrName(string txt)
        {
            dt = CreateTable(); int cnt = 1;
            var data = (from kh in db.Users.OfType<KH>()
                        where kh.Name.Contains(txt) || kh.IDUsers.ToString().Contains(txt)
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
                        }).ToList().Distinct();
            foreach (var i in data)
                dt.Rows.Add(cnt++, i.IDUsers, i.Name, i.DateBorn, i.Sex, i.CCCD, i.Address, i.Gmail, i.Sdt);
            return dt;
        }
        public DataTable FindListKHByNameAndID(string Name, string ID)
        {
            dt = CreateTable(); int cnt = 1;
            var data = (from kh in db.Users.OfType<KH>()
                        where kh.Name.Contains(Name) && kh.IDUsers.ToString().Contains(ID)
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
                        }).ToList().Distinct();
            foreach (var i in data)
                dt.Rows.Add(cnt++, i.IDUsers, i.Name, i.DateBorn, i.Sex, i.CCCD, i.Address, i.Gmail, i.Sdt);
            return dt;
        }
        public DataTable FindListKHBySDTOrCCCD(string txt)
        {
            dt = CreateTable(); int cnt = 1;
            var data = (from kh in db.Users.OfType<KH>()
                        where kh.Sdt.Contains(txt) || kh.CCCD.Contains(txt)
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
                        }).ToList().Distinct();
            foreach (var i in data)
                dt.Rows.Add(cnt++, i.IDUsers, i.Name, i.DateBorn, i.Sex, i.CCCD, i.Address, i.Gmail, i.Sdt);
            return dt;
        }
        public DataTable FindListKHBySDTAndCCCD(string sdt, string cccd)
        {
            dt = CreateTable(); int cnt = 1;
            var data = (from kh in db.Users.OfType<KH>()
                        where kh.Sdt.Contains(sdt) && kh.CCCD.Contains(cccd)
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
                        }).ToList().Distinct();
            foreach (var i in data)
                dt.Rows.Add(cnt++, i.IDUsers, i.Name, i.DateBorn, i.Sex, i.CCCD, i.Address, i.Gmail, i.Sdt);
            return dt;
        }
        public List<int> GetAllKHID()
        {
            return db.Users.OfType<KH>().Select(s => s.IDUsers).ToList();
        }
    }
}
