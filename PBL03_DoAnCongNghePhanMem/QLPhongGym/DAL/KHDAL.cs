using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongGym.DTO;
using static System.Net.Mime.MediaTypeNames;

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
                new DataColumn{ColumnName = "ID", DataType = typeof(int)},
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
        public KH GetKHByDataRow(DataRow dtr)
        {
            return new KH
            {
                IDUsers = Convert.ToInt32(dtr["ID"].ToString()),
                Name = dtr["Name"].ToString(),
                DateBorn = Convert.ToDateTime(dtr["DateBorn"].ToString()),
                Sex = Convert.ToBoolean(dtr["Sex"].ToString()),
                CCCD = dtr["CCCD"].ToString(),
                Address = dtr["Address"].ToString(),
                Gmail = dtr["Gmail"].ToString(),
                Sdt = dtr["Sdt"].ToString()
            };
        }
        public DataTable GetDataTableByList(List<KH> list)
        {
            dt = CreateTable(); int cnt = 1;
            foreach (var i in list)
            {
                dt.Rows.Add(cnt++, i.IDUsers, i.Name, i.DateBorn, i.Sex, i.CCCD, i.Address, i.Gmail, i.Sdt);
            }
            return dt;
        }
        public List<KH> GetListKHByDataTable(DataTable data)
        {
            List<KH> list = new List<KH>();
            foreach (DataRow dr in data.Rows)
            {
                list.Add(GetKHByDataRow(dr));
            }
            return list;
        }
        public DataTable SortKHBy(string Require, DataTable data)
        {
            List<KH> list = GetListKHByDataTable(data);
            dt = new DataTable();
            switch(Require){
                case "Tên":
                    list = list.OrderBy(s => s.Name).ToList();
                    dt = GetDataTableByList(list);
                    break;
                case "Mã":
                    list = list.OrderBy(s => s.IDUsers).ToList();
                    dt = GetDataTableByList(list);
                    break;
                case "Giới tính":
                    list = list.OrderBy(s => s.Sex).ToList();
                    dt = GetDataTableByList(list);
                    break;
            }
            return dt;
        }
        public DataTable FindListKHByIDOrName(string txt)
        {
            dt = CreateTable(); int cnt = 1;
            foreach(var i in db.Users.OfType<KH>().Where(k => k.IDUsers.ToString().Contains(txt) || k.Name.Contains(txt)).Select(p => new
            {
                p.IDUsers,p.Name,p.DateBorn,p.Sex,p.Sdt,p.Gmail,p.Address,p.CCCD
            }).ToList())
            {
                dt.Rows.Add(cnt++, i.IDUsers, i.Name, i.DateBorn, i.Sex, i.CCCD, i.Address, i.Gmail, i.Sdt);
            }
            return dt;
        }
        
    }
}
