using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLPhongGym.DAL
{
    class LichThueDAL
    {
        QLPhongGymDB db = new QLPhongGymDB();
        private static LichThueDAL instance;
        public static LichThueDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new LichThueDAL();
                return instance;
            }
            private set { }
        }
        public List<string> danhsachcatheongay(DateTime ngay)
        {
            List<string> danhsachca = new List<string>();
            var result = (from u in db.LichLamViecTrongTuans
                          from i in db.CaLamViecs
                          where u.IDCa == i.IDCa && u.NgayLam == ngay

                          select new
                          {
                              i.Name
                          }).ToList();
            foreach (var every in result)
            {

                danhsachca.Add(every.Name.ToString());

            }

            return danhsachca;
        }
        // truy vấn đ/kí thuê hlv  , và xem xét trùng lịch 
        public bool DangKiThueHLV(LichThueHLV a)
        {
            // kiem tra su ton tai doi tuong 
            bool exist = db.LichThueHLVs.Any(LichThueHLV =>
                LichThueHLV.IDCa == a.IDCa &&
                LichThueHLV.IDHLV == a.IDHLV &&
                LichThueHLV.NgayThue == a.NgayThue);
            //  LichThueHLV.IDKH == a.IDKH);
            if (!exist)
            {
                LichThueHLV newLichThueHLV = new LichThueHLV
                {
                    IDCa = a.IDCa,
                    IDHLV = a.IDHLV,
                    NgayThue = a.NgayThue,
                    IDKH = a.IDKH,
                };
                db.LichThueHLVs.Add(newLichThueHLV);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        // 
        DataTable dt = new DataTable();
        public DataTable CreatDataTable()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn { ColumnName = "IDKH", DataType = typeof(int) },
                     new DataColumn { ColumnName = "NameKH", DataType = typeof(string) },
                    new DataColumn { ColumnName = "IDHLV", DataType = typeof(int) },
                    new DataColumn { ColumnName = "NameHLV", DataType = typeof(string) },
                    new DataColumn {ColumnName = "NgayLam",DataType = typeof(DateTime)},
                    new DataColumn { ColumnName = "Ca", DataType = typeof(int) },
                });
            return dt;
        }
        public DataTable showlich()
        {
            CreatDataTable();

            var result = (from i in db.LichThueHLVs
                          join u in db.Users.OfType<HLV>() on i.IDHLV equals u.IDUsers
                          join z in db.Users.OfType<KH>() on i.IDKH equals z.IDUsers
                          where i.IDHLV == u.IDUsers
                          select new
                          {
                              i.IDKH,
                              u.IDUsers, // id khach hang                                  
                              HLVName = u.Name,
                              i.NgayThue,
                              i.IDCa,
                              KHName = z.Name // Lấy tên từ bảng Users loại KH
                          }).ToList();
            foreach (var u in result)


                dt.Rows.Add(
                              u.IDKH,
                              u.KHName,
                              u.IDUsers,
                              u.HLVName,                             
                              u.NgayThue,
                              u.IDCa
                      );
            return dt;

        }
        public bool xoa(int ma)
        {
            LichThueHLV a = db.LichThueHLVs.FirstOrDefault(x => x.IDKH == ma);
            db.LichThueHLVs.Remove(a);
            db.SaveChanges();
            return true;
        }
        public bool Capnhat1(int idca, int idhlv,DateTime ngaylam, int IDCA, int IDHLV,DateTime NGAYLAM)
        {

            // Lấy đối tượng Order cần sửa đổi từ cơ sở dữ liệu
            var lich = db.LichThueHLVs.FirstOrDefault(x => x.IDHLV == idhlv &&
            x.IDCa == idca &&
            x.NgayThue == ngaylam);
            lich.IDCa = IDCA;
            lich.IDHLV = IDHLV;
            lich.NgayThue = NGAYLAM;
            db.SaveChanges();
            return true;
        }
        
        public List<LichThueHLV> GetLichThueByIDKH_IDHLV(int IDKH, int IDHLV)
        {
            var data = db.LichThueHLVs.Where(l => l.IDKH == IDKH && l.IDHLV == IDHLV).ToList();
            return data;
        }
        public List<LichThueHLV> GetLichThueByIDHLV(int IDHLV)
        {
            var data = db.LichThueHLVs.Where(l => l.IDHLV == IDHLV).ToList();
            return data;
        }
    }
}
