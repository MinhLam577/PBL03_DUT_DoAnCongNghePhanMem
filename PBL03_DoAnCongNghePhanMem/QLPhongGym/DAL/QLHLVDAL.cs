using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
            {}
        }
        
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
        });
            return dt;
        }
        public DataTable CapNhatListHLV()
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
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

        }
        public bool Them(HLV a)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                try
                {
                    var them = new HLV
                    {
                        Name = a.Name,
                        DateBorn = a.DateBorn,
                        Sex = a.Sex,
                        Gmail = a.Gmail,
                        Address = a.Address,
                        Sdt = a.Sdt,
                        CCCD = a.CCCD,
                        BangCap = a.BangCap,
                        Image = a.Image
                    };
                    // Thêm đối tượng HLV mới vào bảng Users
                    db.Users.Add(them);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Thêm huấn luyện viên thất bại");
                    return false;
                }
                
                return true;

            }
        }
        public bool Delete(int idHLV)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                try
                {
                    User s = db.Users.Find(idHLV);
                    db.Users.Remove(s);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Xóa huấn luyện viên thất bại");
                    return false;
                }
                
                return true;
            }

        }
        public bool Update(HLV a)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {

                // lấy ra danh sách huấn luyện viên trong bảng users 
                var coarches = db.Users.OfType<HLV>();
                // tìm huyến luyện viên chỉnh bằng use method 
                // tìm huyến luyện viên cần chỉnh bằng sử dụng SingleorDefalut();
                try
                {
                    var coarch = coarches.SingleOrDefault(c => c.IDUsers == a.IDUsers);
                    if (coarch != null)
                    {
                        coarch.IDUsers = a.IDUsers;
                        coarch.Name = a.Name;
                        coarch.DateBorn = a.DateBorn;
                        coarch.Sex = a.Sex;
                        coarch.CCCD = a.CCCD;
                        coarch.Gmail = a.Gmail;
                        coarch.Sdt = a.Sdt;
                        coarch.Address = a.Address;
                        coarch.BangCap = a.BangCap;
                        coarch.Image = a.Image;

                    }
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Cật nhật huấn luyện viên thất bại");
                    return false;
                }
                return true;

            }

        }
        public DataTable SearchHLVByNameID(string NameorId)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
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
                
        }
        public DataTable SortHLV(string required, string NameorId)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
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
                
        }
        public DataTable GetDataTableByList(List<HLV> list1)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
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
                
        }
        // code cách 2 sort 
        public DataTable SortDateBorn(string text)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                List<HLV> list = new List<HLV>();
                list = db.Users.OfType<HLV>().ToList();
                list = list.Where(p => p.Name.Contains(text) || p.IDUsers.ToString().Contains(text)).OrderByDescending(p => p.DateBorn).ToList();
                dt = GetDataTableByList(list);
                return dt;
            }
                
        }
        public DataTable SortName(string text)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
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
                    MessageBox.Show("Lỗi");
                };
                return dt;
            }
                
        }
        // tim kiếm HLV theo id 
        public HLV GetInfoHLV(int ma)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                var coarches = db.Users.OfType<HLV>();
                // tìm huyến luyện viên chỉnh bằng use method 
                // tìm huyến luyện viên cần chỉnh bằng sử dụng SingleorDefalut();
                var coarch = coarches.SingleOrDefault(c => c.IDUsers == ma);
                return coarch;
            }
                
        }
        public bool CheckCmndExitEDit(HLV a)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
                return db.Users.OfType<HLV>().Any(s => s.CCCD == a.CCCD && s.IDUsers != a.IDUsers);
        }
        public bool CheckSDTExitEdit(HLV a)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
                return db.Users.OfType<HLV>().Any(s => s.Sdt == a.Sdt && s.IDUsers != a.IDUsers);
        }
        public bool CheckGmailExitEdit(HLV a)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
                return db.Users.OfType<HLV>().Any(s => s.Gmail == a.Gmail && s.IDUsers != a.IDUsers);
        }
        public List<HLV> getHLVs()
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
                return db.Users.OfType<HLV>().ToList();
        }
        public DataTable getinfoLichHLV()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[] {
                new DataColumn{ColumnName="STT",DataType= typeof(int)},
                new DataColumn{ColumnName = "ID", DataType = typeof(int)},
            });
            return dt;
        }
        public List<int> GetAllHLVID()
        {
            return QLHLVDAL.getInstance.GetAllHLVID();
        }
        public DataTable GetListHLV_ByYear(int Year)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                dt = CreatDataTable();
                int cnt = 1;
                var data = db.LichLamViecTrongTuans.Where(s => s.NgayBatDau.Value.Year == Year).Select(s => s.IDHLV.Value).Distinct().ToList();
                List<HLV> list_hlv = new List<HLV>();
                foreach (int i in data)
                    list_hlv.Add((HLV)UsersDAL.Instance.GetUserByID(i));
                foreach (var list in list_hlv)
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
        }
    }
}
