using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QLPhongGym.DAL
{
    class GoiTapDAL
    {
        
        private static GoiTapDAL instance;
        public static GoiTapDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new GoiTapDAL();
                return instance;
            }
            private set { }
        }
        public List<GoiTap> GetAllGT()
        {
            using(QLPhongGymDB db = new QLPhongGymDB())
            {
                List<GoiTap> list = new List<GoiTap>();
                var item = db.GoiTaps.Select(s => new
                {
                    s.IDGT,
                    s.NameGT,
                    s.Price,
                    s.ThoiHanTapTheoThang
                }).ToList();
                foreach (var i in item)
                {
                    list.Add(new GoiTap { IDGT = i.IDGT, NameGT = i.NameGT, Price = i.Price, ThoiHanTapTheoThang = i.ThoiHanTapTheoThang });
                }
                return list;
            }
            
        }
        public GoiTap GetGTByName(string name)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
                return db.GoiTaps.SingleOrDefault(s => s.NameGT.Equals(name));
        }
        public GoiTap GetGTByID(int ID)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
                return db.GoiTaps.Where(s => s.IDGT == ID).FirstOrDefault();
        }
        public int AddGT(GoiTap GT)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                db.GoiTaps.Add(GT);
                return db.SaveChanges();
            }
                
        }
        public void DeleteGT(GoiTap GT)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                    try
                    {
                        GoiTap query = db.GoiTaps.Where(p => p.IDGT == GT.IDGT).FirstOrDefault();
                        db.GoiTaps.Remove(query);
                        db.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi" + ex.Message);
                    }
            }
                
        }
        public void UpdateGT(GoiTap GT)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                var s = db.GoiTaps.FirstOrDefault(p => p.IDGT == GT.IDGT);
                if (s != null)
                {
                    try
                    {
                        s.IDGT = GT.IDGT;
                        s.NameGT = GT.NameGT;
                        s.ThoiHanTapTheoThang = GT.ThoiHanTapTheoThang;
                        s.Price = GT.Price;
                        db.SaveChanges();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Lỗi" + e.Message);
                        throw;
                    }
                }
            }
                
        }
        public DataTable TaoBang()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Mã gói tập", typeof(int));
            dt.Columns.Add("Gói tập", typeof(string));
            dt.Columns.Add("Giá(vnđ)", typeof(double));
            dt.Columns.Add("Thời hạn(Tháng)", typeof(int));
            return dt;
        }
        public DataTable GetData_DAL()
        {
            DataTable data = new DataTable();
            int cnt = 1;
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                data = TaoBang();
                var str = from p in db.GoiTaps select new { p.IDGT, p.NameGT, p.Price, p.ThoiHanTapTheoThang };
                foreach (var item in db.GoiTaps)
                {
                    data.Rows.Add(cnt++, item.IDGT, item.NameGT, item.Price, item.ThoiHanTapTheoThang);
                }
                return data;
            }
        }
        public bool TenGT(string str)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                return db.GoiTaps.Any(s => s.NameGT == str);
            }
        }

    }
}
