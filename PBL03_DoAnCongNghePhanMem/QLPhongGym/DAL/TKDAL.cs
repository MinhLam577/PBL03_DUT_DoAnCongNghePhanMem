using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhongGym.DTO;
using QLPhongGym.DAL;
using QLPhongGym.GUI;
using System.Text.RegularExpressions;

namespace DAL
{
    public class TKDAL
    {
        QLPhongGymDB db = new QLPhongGymDB();
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
            return db.TKs.ToList();
        }
        public bool checkTkMk(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,20}$");
        }
        public bool checkEmail(string email)
        {
            if (email == "") return true;
            return Regex.IsMatch(email, "^[a-zA-Z][a-zA-Z0-9_.]{5,20}(@gmail.com)$");
        }
        public bool checkxnmk(string mk, string xnmk)
        {
            return mk.Equals(xnmk);
        }
        public bool checksdt(string sdt)
        {
            return Regex.IsMatch(sdt, "^[0-9]{10,11}$");
        }
        public bool checkcmnd(string cmnd)
        {
            return Regex.IsMatch(cmnd, "^[0-9]{12}$");
        }
        public bool CheckMKTKExist(string mk)
        {
            return LoadAllTK().Any(t => t.MatkhauTK.Equals(mk));
        }
        public bool CheckTenTKExist(string tentk)
        {
            return LoadAllTK().Any(t => t.TenTK.Equals(tentk));
        }
        public bool CheckEmailExist(string email)
        {
            return LoadAllTK().Any(t => t.EmailTK.Equals(email));
        }
        public bool CheckSdtExist(string sdt)
        {
            return LoadAllTK().Any(t => t.Sdt.Equals(sdt));
        }

        public string GetUserByMaQuyen(int IDUsers)
        {
            string user = (from a in db.TKs
                           join b in db.PhanQuyens
                           on a.IDQuyen equals b.IDQuyen
                           select b.TenQuyen).ToList().FirstOrDefault();
            return user;
        }

        public int GetIDQuyen(string tentk) {
            return LoadAllTK().Where(t => t.TenTK.Equals(tentk)).Select(t => t.IDQuyen).FirstOrDefault();
        }
        public string GetPassword(string email)
        {
            string e = LoadAllTK().Where(a => a.EmailTK.Equals(email)).FirstOrDefault().MatkhauTK;
            if (e != null) return e;
            return "";
        }
        public int AddTK(TK acc)
        {
            db.TKs.Add(acc);
            return db.SaveChanges();
        }
        public void DeleteTK(TK acc)
        {
            db.TKs.Remove(acc);
            db.SaveChanges();
        }
    }
}
