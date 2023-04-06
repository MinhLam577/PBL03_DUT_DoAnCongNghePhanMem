using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.DAL
{
    class ThietBiDAL
    {
        private static ThietBiDAL instance;
        public static ThietBiDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new ThietBiDAL();
                return instance;
            }
            private set { }
        }
        QLPhongGymDB db = new QLPhongGymDB();
        public DataTable createDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Tên thiết bị", typeof(string));
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Số lượng hỏng", typeof(int));
            dt.Columns.Add("Nhà cung cấp", typeof(string));
            dt.Columns.Add("Mô tả", typeof(string));
            dt.Columns.Add("Giá tiền", typeof(double));
            return dt;
        }


        public DataTable GetAllDanhSachThietBi_DAL()
        {
            DataTable dt = new DataTable();
            dt = createDataTable();
            var str = from p in db.ThietBis select new { p.IDTB, p.Name, p.SoLuong, p.SoLuongHong, p.NhaCungCap, p.MoTa, p.Price };
            foreach (var item in str)
            {
                dt.Rows.Add(item.IDTB, item.Name, item.SoLuong, item.SoLuongHong, item.NhaCungCap, item.MoTa, item.Price);
            }
            return dt;

        }
        public void UpdateThietBi_DAL(ThietBi tb)
        {
            QLPhongGymDB ds = new QLPhongGymDB();
            var s = db.ThietBis.FirstOrDefault(p => p.IDTB == tb.IDTB);
            if (s != null)
            {
                try
                {
                    s.IDTB = tb.IDTB;
                    s.Name = tb.Name;
                    s.Price = tb.Price;
                    s.MoTa = tb.MoTa;
                    s.NhaCungCap = tb.NhaCungCap;
                    s.SoLuong = tb.SoLuong;
                    s.SoLuongHong = tb.SoLuongHong;
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Lỗi" + e.Message);
                    throw;
                }
            }
        }
        public void AddThietBi_DAL(ThietBi tb)
        {
            try
            {
                db.ThietBis.Add(tb);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message);
                throw;
            }
        }
        public DataTable GetThietBiByID_DAL(int id)
        {
            DataTable dt = new DataTable();
            dt = createDataTable();
            var str = db.ThietBis.Where(p => p.IDTB == id).Select(p => new { p.IDTB, p.Name, p.SoLuong, p.SoLuongHong, p.NhaCungCap, p.MoTa, p.Price }).FirstOrDefault();
            dt.Rows.Add(str);
            return dt;
        }
        public void DeleteTB_DAL(int matb)
        {
            ThietBi query = db.ThietBis.Where(p => p.IDTB == matb).FirstOrDefault();
            db.ThietBis.Remove(query);
            db.SaveChanges();
        }
        public DataTable SearchTB_DAL(string str)
        {
            DataTable dt = new DataTable();
            int id;
            if (Int32.TryParse(str, out id))
            {
                var s = db.ThietBis.Where(p => p.IDTB == id).ToList();
                dt = createDataTable();
                foreach (var item in s)
                {
                    dt.Rows.Add(item.IDTB, item.Name, item.SoLuong, item.SoLuongHong, item.NhaCungCap, item.MoTa, item.Price);
                }
                return dt;
            }
            else
            {
                var query = db.ThietBis.Where(p => p.Name.Contains(str) || p.NhaCungCap.Contains(str) || p.MoTa.Contains(str)).ToList();
                dt = createDataTable();
                foreach (var item in query)
                {
                    dt.Rows.Add(item.IDTB, item.Name, item.SoLuong, item.SoLuongHong, item.NhaCungCap, item.MoTa, item.Price);
                }
                return dt;
            }

        }
        public DataTable Sort_DLL(string sort, string search)
        {
            DataTable dt = new DataTable();
            if (search == "")
            {
                switch (sort)
                {
                    case "Giá":
                        var query = db.ThietBis.OrderBy(s => s.Price).ToList();
                        dt = createDataTable();
                        foreach (var item in query)
                        {
                            dt.Rows.Add(item.IDTB, item.Name, item.SoLuong, item.SoLuongHong, item.NhaCungCap, item.MoTa, item.Price);
                        }
                        break;
                    case "Nhà cung cấp":
                        var str = db.ThietBis.OrderBy(s => s.NhaCungCap).ToList();
                        dt = createDataTable();
                        foreach (var item in str)
                        {
                            dt.Rows.Add(item.IDTB, item.Name, item.SoLuong, item.SoLuongHong, item.NhaCungCap, item.MoTa, item.Price);
                        }
                        break;
                    case "Số lượng hỏng":
                        var st = db.ThietBis.OrderBy(s => s.SoLuongHong).ToList();
                        dt = createDataTable();
                        foreach (var item in st)
                        {
                            dt.Rows.Add(item.IDTB, item.Name, item.SoLuong, item.SoLuongHong, item.NhaCungCap, item.MoTa, item.Price);
                        }
                        break;
                    case "Tên thiết bị":
                        var t = db.ThietBis.OrderBy(s => s.Name).ToList();
                        dt = createDataTable();
                        foreach (var item in t)
                        {
                            dt.Rows.Add(item.IDTB, item.Name, item.SoLuong, item.SoLuongHong, item.NhaCungCap, item.MoTa, item.Price);
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (sort)
                {
                    case "Giá":
                        var query = db.ThietBis.Where(p => p.Name.Contains(search) || p.NhaCungCap.Contains(search) || p.MoTa.Contains(search)).OrderBy(s => s.Price).ToList();
                        dt = createDataTable();
                        foreach (var item in query)
                        {
                            dt.Rows.Add(item.IDTB, item.Name, item.SoLuong, item.SoLuongHong, item.NhaCungCap, item.MoTa, item.Price);
                        }
                        break;
                    case "Nhà cung cấp":
                        var str = db.ThietBis.Where(p => p.Name.Contains(search) || p.NhaCungCap.Contains(search) || p.MoTa.Contains(search)).OrderBy(s => s.NhaCungCap).ToList();
                        dt = createDataTable();
                        foreach (var item in str)
                        {
                            dt.Rows.Add(item.IDTB, item.Name, item.SoLuong, item.SoLuongHong, item.NhaCungCap, item.MoTa, item.Price);
                        }
                        break;
                    case "Số lượng hỏng":
                        var st = db.ThietBis.Where(p => p.Name.Contains(search) || p.NhaCungCap.Contains(search) || p.MoTa.Contains(search)).OrderBy(s => s.SoLuongHong).ToList();
                        dt = createDataTable();
                        foreach (var item in st)
                        {
                            dt.Rows.Add(item.IDTB, item.Name, item.SoLuong, item.SoLuongHong, item.NhaCungCap, item.MoTa, item.Price);
                        }
                        break;
                    case "Tên thiết bị":
                        var t = db.ThietBis.Where(p => p.Name.Contains(search) || p.NhaCungCap.Contains(search) || p.MoTa.Contains(search)).OrderBy(s => s.Name).ToList();
                        dt = createDataTable();
                        foreach (var item in t)
                        {
                            dt.Rows.Add(item.IDTB, item.Name, item.SoLuong, item.SoLuongHong, item.NhaCungCap, item.MoTa, item.Price);
                        }
                        break;
                    default:
                        break;
                }
            }
            return dt;
        }
    }
}
