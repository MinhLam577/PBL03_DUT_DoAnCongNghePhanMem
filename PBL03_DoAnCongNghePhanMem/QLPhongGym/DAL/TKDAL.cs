using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhongGym.DTO;
using QLPhongGym.GUI;
using System.Text.RegularExpressions;
using System.Data.Entity;

namespace DAL
{
    public class TKDAL
    {
        private static TKDAL instance;
        public static TKDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TKDAL();
                return instance;
            }
            private set { }
        }
        public List<TK> LoadAllTK()
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                return db.TKs.ToList();
            }
                
        }
        public bool checkTkMk(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,20}$");
        }
        
        public bool checkxnmk(string mk, string xnmk)
        {
            return mk.Equals(xnmk);
        }
        public bool checkcmnd(string cmnd)
        {
            return Regex.IsMatch(cmnd, "^[0-9]{12}$");
        }
        public bool CheckMKTKExist(string tk, string mk)
        {
            return LoadAllTK().Any(t => (t.TenTK.Equals(tk) && t.MatkhauTK.Equals(Eramake.eCryptography.Encrypt(mk))) || (t.TenTK.Equals(tk) && t.MatkhauTK.Equals(mk)));
        }
        public bool CheckTenTKExist(string tentk)
        {
            return LoadAllTK().Any(t => t.TenTK.Equals(tentk));
        }
        public string GetUserByMaQuyen(int IDQuyen)
        {
            using(QLPhongGymDB db = new QLPhongGymDB())
            {
                var data = (from tk in db.TKs 
                           join pq in db.PhanQuyens
                           on tk.IDQuyen equals pq.IDQuyen
                           where pq.IDQuyen == IDQuyen
                           select pq.TenQuyen).FirstOrDefault();
                return data;
            }
        }
        public int GetIDQuyen(string tentk) {
            return LoadAllTK().Where(t => t.TenTK.Equals(tentk)).Select(t => t.IDQuyen).FirstOrDefault();
        }
        public int AddTK(TK acc)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                db.TKs.Add(acc);
                return db.SaveChanges();
            }
               
        }
        public void DeleteTK(TK acc)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                TK tk = db.TKs.FirstOrDefault(s => s.TenTK == acc.TenTK);
                db.TKs.Remove(tk);
                db.SaveChanges();
            }
        }
        public int UpdateTK(TK acc)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                db.Entry(acc).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }
               
        }
        public TK GetTKByUserID(int ID)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
                return db.TKs.FirstOrDefault(tk => (int)tk.IDUser == ID);
        }
        public TK GetTKByTenTK(string TenTK)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
            {
                return db.TKs.FirstOrDefault(tk => tk.TenTK.Equals(TenTK));
            }    
                
        }
        public TK GetTKByMK(string MKTK)
        {
            using (QLPhongGymDB db = new QLPhongGymDB())
                return db.TKs.FirstOrDefault(tk => tk.MatkhauTK.Equals(Eramake.eCryptography.Encrypt(MKTK)));
        }
    }
}
