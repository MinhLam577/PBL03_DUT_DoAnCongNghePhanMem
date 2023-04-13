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
        public DataTable TaoBang()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Mã gói tập", typeof(int));
            dt.Columns.Add("Gói tập", typeof(string));
            dt.Columns.Add("Giá(vnđ)", typeof(double));
            return dt;
        }
        public DataTable GetData_DAL()
        {
            DataTable data = new DataTable();
            int cnt = 1;
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                data = TaoBang();
                var str = from p in db.GoiTaps select new { p.IDGT, p.Name, p.Price };
                foreach (var item in db.GoiTaps)
                {
                    data.Rows.Add(cnt++, item.IDGT, item.Name, item.Price);
                }
                return data;
            }
        }
        public void DeleteGT_DAL(int mgt)
        {
            try
            {
                using (QLPhongGymDB db = new QLPhongGymDB())
                {
                    GoiTap query = db.GoiTaps.Where(p => p.IDGT == mgt).FirstOrDefault();
                    db.GoiTaps.Remove(query);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }
        public void AddGoiTap_DAL(GoiTap gt)
        {
            try
            {
                using (QLPhongGymDB db = new QLPhongGymDB())
                {
                    db.GoiTaps.Add(gt);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
                throw;
            }
        }
        public void UpdateGoiTap_DAL(GoiTap tb)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                var s = db.GoiTaps.FirstOrDefault(p => p.IDGT == tb.IDGT);
                try
                {
                    s.IDGT = tb.IDGT;
                    s.Name = tb.Name;
                    s.Price = tb.Price;
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
}
