using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.DAL
{
    public class TKHLV_DAL
    {
        private static TKHLV_DAL instance;
        public static TKHLV_DAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TKHLV_DAL();
                return instance;
            }
            private set { }
        }
        public DataTable CreateDataTable()
        {
            DataTable dt = new DataTable();
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
                {
                new DataColumn{ColumnName = "STT", DataType = typeof(int)},
                new DataColumn{ColumnName = "ID", DataType = typeof(int)},
                new DataColumn{ColumnName = "Tên huấn luyện viên", DataType = typeof(string)},
                new DataColumn{ColumnName = "Date", DataType = typeof(DateTime)},
                new DataColumn{ColumnName = "Sex", DataType = typeof(bool)},
        });
            return dt;
        }
        public DataTable GetDataTableByList()
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                DataTable dt = new DataTable();
                dt = CreateDataTable(); int cnt = 1;
                var result = (from u in db.Users.OfType<HLV>()
                              select new
                              {
                                  u.IDUsers,
                                  u.Name,
                                  u.DateBorn,
                                  u.Sex,
                              }).ToList();
                foreach (var list in result)
                    dt.Rows.Add(
                                  cnt++,
                                  list.IDUsers,
                                  list.Name,
                                  list.DateBorn,
                                  list.Sex
                          );
                return dt;
            }
        }
        public DataTable CreateDataTable2()
        {
            DataTable dt = new DataTable();
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
                {
                new DataColumn{ColumnName = "STT", DataType = typeof(int)},
                new DataColumn{ColumnName = "ID", DataType = typeof(int)},
                new DataColumn{ColumnName = "Tên huấn luyện viên", DataType = typeof(string)},
                new DataColumn{ColumnName = "Tên TK", DataType = typeof(string)},
                new DataColumn{ColumnName = "Mật khẩu", DataType = typeof(string)},
        });
            return dt;
        }
        public DataTable GetDataTableByList2()
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                DataTable dt = new DataTable();
                dt = CreateDataTable2(); int cnt = 1;
                var result = from p in db.TKs
                             join t in db.Users on p.IDUser equals t.IDUsers
                             where p.IDQuyen == 2
                             select new { p.TenTK, p.IDUser, t.Name, p.MatkhauTK };
                foreach (var list in result)
                    dt.Rows.Add(
                                  cnt++,
                                  list.IDUser,
                                  list.Name,
                                  list.TenTK,
                                  list.MatkhauTK
                          );
                return dt;
            }
        }
        public bool CheckHLVHasAccount(int hlvID)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                var query = from u in db.Users.OfType<HLV>()
                            join tk in db.TKs on u.IDUsers equals tk.IDUser into g
                            from tk in g.DefaultIfEmpty()
                            where u.IDUsers == hlvID
                            select tk != null;

                return query.FirstOrDefault();
            }
        }
        public void Delete_DAL(int str)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                try
                {
                    var product = db.TKs.SingleOrDefault(p => p.IDUser == str);
                    if (product != null)
                    {
                        db.TKs.Remove(product);
                        db.SaveChanges();
                    }
                }
                catch
                {
                    MessageBox.Show("Xóa tài khoản huấn luyện viên thất bại");
                }
                
            }
        }
        public HLV GetHLVByID(int id)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                return db.Users.OfType<HLV>().SingleOrDefault(s => s.IDUsers == id);
            }
        }
        public void ADD_DAL(TK sp)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                try
                {
                    db.TKs.Add(sp);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Thêm tài khoản huấn luyện viên thất bai");
                }
            }

        }
        public void UpdateTK_DAl(TK sp)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                try
                {
                    db.Entry(sp).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Cật nhật tài khoản huấn luyện viên thất bại");
                }
                
            }
        }
        public DataTable SearchSP_DAL(string str)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                DataTable dt = new DataTable();
                dt = CreateDataTable(); int cnt = 1;
                var result = (from u in db.Users.OfType<HLV>()
                              where (u.Name.Contains(str) || u.IDUsers.ToString().Contains(str))
                              select new
                              {
                                  u.IDUsers,
                                  u.Name,
                                  u.DateBorn,
                                  u.Sex,
                              }).ToList();
                foreach (var list in result)
                    dt.Rows.Add(
                                  cnt++,
                                  list.IDUsers,
                                  list.Name,
                                  list.DateBorn,
                                  list.Sex
                          );
                return dt;
            }
        }
        public DataTable SearchSP_DAL2(string str)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                DataTable dt = new DataTable();
                dt = CreateDataTable2(); int cnt = 1;
                var result = from p in db.TKs
                             join t in db.Users on p.IDUser equals t.IDUsers
                             where (p.IDQuyen == 2 && p.TenTK.Contains(str)) || (t.Name.Contains(str) && p.IDQuyen == 2) || (t.IDUsers.ToString().Contains(str) && p.IDQuyen == 2)
                             select new { p.TenTK, p.IDUser, t.Name, p.MatkhauTK };
                foreach (var list in result)
                    dt.Rows.Add(
                                  cnt++,
                                  list.IDUser,
                                  list.Name,
                                  list.TenTK,
                                  list.MatkhauTK
                          );
                return dt;
            }
        }
        public bool TenTK(string str)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                return db.TKs.Any(s => s.TenTK == str);
            }
        }

        public DataTable FitlerTaiKhoanBy(string require, string IDHLV)
        {
            DataTable dt = CreateDataTable2();
            using(QLPhongGymDB db = new QLPhongGymDB())
            {
                int cnt = 1;
                switch (require)
                {
                    case "Tất cả":
                        dt = GetDataTableByList2();
                        return dt;
                    case "Tài khoản bị ban":
                        var data1 = from p in db.TKs
                                    join t in db.Users on p.IDUser equals t.IDUsers
                                    where p.IDQuyen == 2 && p.TrangThai.Value == false
                                    select new { p.TenTK, p.IDUser, t.Name, p.MatkhauTK };
                        foreach (var i in data1)
                        {
                            dt.Rows.Add(
                                      cnt++,
                                      i.IDUser,
                                      i.Name,
                                      i.TenTK,
                                      i.MatkhauTK
                              );
                        }
                        return dt;
                    case "Tài khoản đang hoạt động":
                        var data2 = from p in db.TKs
                                    join t in db.Users on p.IDUser equals t.IDUsers
                                    where p.IDQuyen == 2 && p.TrangThai.Value == true
                                    select new { p.TenTK, p.IDUser, t.Name, p.MatkhauTK };
                        foreach (var i in data2)
                        {
                            dt.Rows.Add(
                                      cnt++,
                                      i.IDUser,
                                      i.Name,
                                      i.TenTK,
                                      i.MatkhauTK
                              );
                        }
                        return dt;
                    default:
                        int idhlv = Convert.ToInt32(IDHLV);
                        var data3 = from p in db.TKs
                                    join t in db.Users on p.IDUser equals t.IDUsers
                                    where p.IDQuyen == 2 && t.IDUsers == idhlv
                                    select new { p.TenTK, p.IDUser, t.Name, p.MatkhauTK };
                        foreach (var i in data3)
                        {
                            dt.Rows.Add(
                                      cnt++,
                                      i.IDUser,
                                      i.Name,
                                      i.TenTK,
                                      i.MatkhauTK
                              );
                        }
                        return dt;
                }
            
            }
        }
        public List<string> FindListTKHLVByIDHLV(int IDHLV)
        {
            using(QLPhongGymDB db = new QLPhongGymDB())
            {
                return (from tk in db.TKs
                       join hlv in db.Users.OfType<HLV>()
                       on tk.IDUser equals hlv.IDUsers
                       where hlv.IDUsers == IDHLV
                       select tk.TenTK).ToList();
            }
        }

    }
}