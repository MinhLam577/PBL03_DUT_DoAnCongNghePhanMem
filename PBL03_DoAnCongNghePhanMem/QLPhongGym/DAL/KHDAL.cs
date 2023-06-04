using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
        readonly QLPhongGymDB db = new QLPhongGymDB();
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
        public DataTable FindListKHByCCCD(string CCCD){
            dt = CreateTable(); int cnt = 1;
            var data = (db.Users.OfType<KH>().Where(k => k.CCCD.Contains(CCCD)).
                        Select(kh => new
                        {
                            kh.IDUsers,
                            kh.Name,
                            kh.DateBorn,
                            kh.Sex,
                            kh.Sdt,
                            kh.Gmail,
                            kh.Address,
                            kh.CCCD,
                        })).ToList().Distinct();
            foreach (var i in data)
                dt.Rows.Add(cnt++, i.IDUsers, i.Name, i.DateBorn, i.Sex, i.CCCD, i.Address, i.Gmail, i.Sdt);
            return dt;
        }
        public DataTable FindListKHByID(string ID)
        {
            dt = CreateTable(); int cnt = 1;
            var data = (db.Users.OfType<KH>().Where(k => k.IDUsers.ToString().Contains(ID)).
                        Select(kh => new
                        {
                            kh.IDUsers,
                            kh.Name,
                            kh.DateBorn,
                            kh.Sex,
                            kh.Sdt,
                            kh.Gmail,
                            kh.Address,
                            kh.CCCD,
                        })).ToList().Distinct();
            foreach (var i in data)
                dt.Rows.Add(cnt++, i.IDUsers, i.Name, i.DateBorn, i.Sex, i.CCCD, i.Address, i.Gmail, i.Sdt);
            return dt;
        }
        public DataTable FindListKHByName(string Name)
        {
            dt = CreateTable(); int cnt = 1;
            var data = (db.Users.OfType<KH>().Where(k => k.Name.Contains(Name)).
                        Select(kh => new
                        {
                            kh.IDUsers,
                            kh.Name,
                            kh.DateBorn,
                            kh.Sex,
                            kh.Sdt,
                            kh.Gmail,
                            kh.Address,
                            kh.CCCD,
                        })).ToList().Distinct();
            foreach (var i in data)
                dt.Rows.Add(cnt++, i.IDUsers, i.Name, i.DateBorn, i.Sex, i.CCCD, i.Address, i.Gmail, i.Sdt);
            return dt;
        }
        public DataTable FindListKHBySDT(string Sdt)
        {
            dt = CreateTable(); int cnt = 1;
            var data = (db.Users.OfType<KH>().Where(k => k.Sdt.Contains(Sdt)).
                        Select(kh => new
                        {
                            kh.IDUsers,
                            kh.Name,
                            kh.DateBorn,
                            kh.Sex,
                            kh.Sdt,
                            kh.Gmail,
                            kh.Address,
                            kh.CCCD,
                        })).ToList().Distinct();
            foreach (var i in data)
                dt.Rows.Add(cnt++, i.IDUsers, i.Name, i.DateBorn, i.Sex, i.CCCD, i.Address, i.Gmail, i.Sdt);
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
        public DataTable FindListKHByIDHLV_NgayThue_IDCa_IDOrName(string txt, int IDHLV, DateTime NgayThue, int? IDCa)
        {
            dt = CreateTable(); int cnt = 1;
            if(IDCa != null)
            {
                var data = (from kh in db.Users.OfType<KH>()
                            join lt in db.LichThueHLVs on kh.IDUsers equals lt.IDKH
                            where (kh.Name.Contains(txt) && lt.IDHLV == IDHLV && lt.NgayThue.Value == NgayThue && lt.IDCa.Value == IDCa.Value)
                            || (kh.IDUsers.ToString().Contains(txt) && lt.IDHLV == IDHLV && lt.NgayThue.Value == NgayThue && lt.IDCa.Value == IDCa.Value)
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
            }
            else
            {
                var data = (from kh in db.Users.OfType<KH>()
                            join lt in db.LichThueHLVs on kh.IDUsers equals lt.IDKH
                            where (kh.Name.Contains(txt) && lt.IDHLV == IDHLV && lt.NgayThue.Value == NgayThue)
                            || (kh.IDUsers.ToString().Contains(txt) && lt.IDHLV == IDHLV && lt.NgayThue.Value == NgayThue)
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
            }
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
