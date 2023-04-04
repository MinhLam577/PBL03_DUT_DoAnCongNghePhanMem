using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public DataTable GetAllKHDataTable()
        {
            dt = new DataTable(); int cnt = 1;
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "STT", DataType = typeof(int)},
                new DataColumn{ColumnName = "ID", DataType = typeof(int)},
                new DataColumn{ColumnName = "Name", DataType = typeof(string)},
                new DataColumn{ColumnName = "DateBorn", DataType = typeof(DateTime)},
                new DataColumn{ColumnName = "Sex", DataType = typeof(bool)},
                new DataColumn{ColumnName = "CCCD", DataType = typeof(string)},
                new DataColumn{ColumnName = "Address", DataType = typeof(string)}
            }); 
            foreach(var i in db.Users.OfType<KH>())
            {
                dt.Rows.Add(cnt++, i.IDUsers, i.Name, i.DateBorn, i.Sex, i.CCCD, i.Address);
            }
            return dt;
        }
    }
}
