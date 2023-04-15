using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using QLPhongGym.DTO;
using static System.Net.Mime.MediaTypeNames;

namespace QLPhongGym.DAL
{
    public class QLHLVDAL
    {

        private static QLHLVDAL instance;
        public QLHLVDAL()
        {

        }
        public static QLHLVDAL getInstance
        {
            get
            {
                if (instance == null)
                    instance = new QLHLVDAL();
                return instance;
            }
            private set
            {

            }
        }
        QLPhongGymDB db = new QLPhongGymDB();
        DataTable dt = new DataTable();
        // tao cot bang
        public DataTable CreatDataTable()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
                {
                new DataColumn{ColumnName = "STT", DataType = typeof(int)},
                new DataColumn{ColumnName = "ID", DataType = typeof(int)},
                new DataColumn{ColumnName = "Name", DataType = typeof(string)},
                new DataColumn{ColumnName = "Date", DataType = typeof(DateTime)},
                new DataColumn{ColumnName = "Sex", DataType = typeof(bool)},
                new DataColumn{ColumnName = "CCCD", DataType = typeof(string)},
                new DataColumn{ColumnName = "Gmail", DataType = typeof(string)},
                new DataColumn{ColumnName = "Sdt", DataType = typeof(string)},
                new DataColumn{ColumnName = "Adress", DataType = typeof(string)},
                new DataColumn{ColumnName = "BangCap", DataType = typeof(string)},
               // new DataColumn{ColumnName = "Image", DataType = typeof(string)}
        });
            return dt;
        }
        public DataTable CapNhatListHLV()
        {
            dt = CreatDataTable(); int cnt = 1;
            var result = (from u in db.Users.OfType<HLV>()
                          select new
                          {
                              u.IDUsers,
                              u.Name,
                              u.DateBorn,
                              u.Sex,
                              u.CCCD,
                              u.Gmail,
                              u.Sdt,
                              u.Address,
                              u.BangCap,
                              u.NamKinhNghiem
                          }).ToList();
            foreach (var list in result)
                dt.Rows.Add(
                              cnt++,
                              list.IDUsers,
                              list.Name,
                              list.DateBorn,
                              list.Sex,
                              list.CCCD,
                              list.Gmail,
                              list.Sdt,
                              list.Address,
                              list.BangCap
                      );
            return dt;
        }
        public bool Them(string name, DateTime ngaysinh, bool sex, string cccd, string gmail, string sdt, string diachi, string degree, string
            image)
        {
            var them = new HLV
            {
                Name = name,
                DateBorn = ngaysinh,
                Sex = sex,
                Gmail = gmail,
                Address = diachi,
                Sdt = sdt,
                CCCD = cccd,
                BangCap = degree,
                Image = image
            };
            // Thêm đối tượng HLV mới vào bảng Users
            db.Users.Add(them);
            db.SaveChanges();
            return true;
        }
        public bool Delete(int idHLV)
        {
            User s = db.Users.Find(idHLV);
            db.Users.Remove(s);
            db.SaveChanges();
            return true;
        }
        public bool Update(int ma, string name, DateTime ngaysinh, bool sex, string cccd, string gmail, string sdt, string diachi, string degree, string anh)
        {
            // lấy ra danh sách huấn luyện viên trong bảng users 
            var coarches = db.Users.OfType<HLV>();
            // tìm huyến luyện viên chỉnh bằng use method 
            // tìm huyến luyện viên cần chỉnh bằng sử dụng SingleorDefalut();
            var coarch = coarches.SingleOrDefault(c => c.IDUsers == ma);
            if (coarch != null)
                coarch.IDUsers = ma;
            coarch.Name = name;
            coarch.DateBorn = ngaysinh;
            coarch.Sex = sex;
            coarch.CCCD = cccd;
            coarch.Gmail = gmail;
            coarch.Sdt = sdt;
            coarch.Address = diachi;
            coarch.BangCap = degree;
            coarch.Image = anh;
            db.SaveChanges();
            return true;
        }
        public DataTable SearchHLVByNameID(string NameorId)
        {
            dt = CreatDataTable(); int cnt = 1;
            var result = (from u in db.Users.OfType<HLV>()
                          where u.Name.Contains(NameorId) || u.IDUsers.ToString().Contains(NameorId)
                          select new
                          {
                              u.IDUsers,
                              u.Name,
                              u.DateBorn,
                              u.Sex,
                              u.CCCD,
                              u.Image,
                              u.Gmail,
                              u.Sdt,
                              u.Address,
                              u.BangCap,
                              u.NamKinhNghiem,
                          }).ToList();
            foreach (var list in result)
            {
                dt.Rows.Add(

                              cnt++,
                              list.IDUsers,
                              list.Name,
                              list.DateBorn,
                              list.Sex,
                              list.CCCD,
                              list.Gmail,
                              list.Sdt,
                              list.Address,
                              list.BangCap
                    );
            }
            return dt;
        }
        public DataTable SortHLV(string required, string NameorId)
        {

            dt = CreatDataTable(); int cnt = 1;
            if (required.Equals("ID"))
            {
                var result = (from u in db.Users.OfType<HLV>()
                              where u.Name.Contains(NameorId) || u.IDUsers.ToString().Contains(NameorId)
                              orderby u.IDUsers descending
                              select new
                              {
                                  u.IDUsers,
                                  u.Name,
                                  u.DateBorn,
                                  u.Sex,
                                  u.CCCD,
                                  u.Image,
                                  u.Gmail,
                                  u.Sdt,
                                  u.Address,
                                  u.BangCap,
                                  u.NamKinhNghiem
                              }).ToList();
                foreach (var list in result)
                {
                    dt.Rows.Add(cnt++,
                                  list.IDUsers,
                                  list.Name,
                                  list.DateBorn,
                                  list.Sex,
                                  list.CCCD,
                                  list.Gmail,
                                  list.Sdt,
                                  list.Address,
                                  list.BangCap
                        );
                }
            }
            else if (required.Equals("Date"))
            {
                dt = SortDateBorn(NameorId);
            }
            else // Name
            {
                dt = SortName(NameorId);
            }
            return dt;
        }
        public DataTable GetDataTableByList(List<HLV> list1)
        {
            dt = CreatDataTable(); int cnt = 1;
            foreach (var list in list1)
            {
                dt.Rows.Add(cnt++,
                                  list.IDUsers,
                                  list.Name,
                                  list.DateBorn,
                                  list.Sex,
                                  list.CCCD,
                                  list.Gmail,
                                  list.Sdt,
                                  list.Address,
                                  list.BangCap

                    );
            }
            return dt;
        }
        // code cách 2 sort 
        public DataTable SortDateBorn(string text)
        {

            List<HLV> list = new List<HLV>();
            list = db.Users.OfType<HLV>().ToList();
            list = list.Where(p => p.Name.Contains(text) || p.IDUsers.ToString().Contains(text)).OrderByDescending(p => p.DateBorn).ToList();
            dt = GetDataTableByList(list);
            return dt;
        }
        public DataTable SortName(string text)
        {
            try
            {
                List<HLV> list = new List<HLV>();
                list = db.Users.OfType<HLV>().ToList();
                list = list.Where(p => p.Name.Contains(text) || p.IDUsers.ToString().Contains(text)).OrderByDescending(p => p.Name).ToList();
                dt = GetDataTableByList(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            };
            return dt;
        }
        // tim kiếm HLV theo id 
        public HLV GetInfoHLV(int ma)
        {
            var coarches = db.Users.OfType<HLV>();
            // tìm huyến luyện viên chỉnh bằng use method 
            // tìm huyến luyện viên cần chỉnh bằng sử dụng SingleorDefalut();
            var coarch = coarches.SingleOrDefault(c => c.IDUsers == ma);
            return coarch;

        }
    }
}
