using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL;
using QLPhongGym.DTO;
using QLPhongGym.GUI;

namespace QLPhongGym.DAL
{
    public class UsersDAL
    {
        QLPhongGymDB db = new QLPhongGymDB();
        private static UsersDAL instance;
        public static UsersDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new UsersDAL();
                return instance;
            }
            private set { }
        }
        public int AddUsers(User user)
        {
            db.Users.Add(user);
            return db.SaveChanges();
        }
        public int UpdateUsers(User user)
        {
            db.Entry(user).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
        public void DeleteUsers(User user)
        {
            db.Users.Remove(user);
            db.SaveChanges();
        }
        public int GetUsersID(string CCCD)
        {
            int UserID = db.Users.Where(s => s.CCCD.Equals(CCCD)).FirstOrDefault().IDUsers;
            return UserID;
        }
        public User GetUserByID(int IDUsers)
        {
            return db.Users.Where(s => s.IDUsers.Equals(IDUsers)).FirstOrDefault();
        }
        public bool checkEmail(string email)
        {
            if (email == "") return true;
            return Regex.IsMatch(email, "^[a-zA-Z][a-zA-Z0-9_.]{5,20}(@gmail.com)$");
        }
        public bool checksdt(string sdt)
        {
            return Regex.IsMatch(sdt, "^[0-9]{10,11}$");
        }
        public bool checkcccd(string cccd)
        {
            return Regex.IsMatch(cccd, "^[0-9]{12}$");
        }
        public List<User> GetAllUser()
        {
            return db.Users.ToList();
        }
        public bool CheckEmailExist(string gmail)
        {
            if (GetAllUser().Select(t => t.Gmail).FirstOrDefault() != null)
                return GetAllUser().Any(t => t.Gmail.Equals(gmail));
            return false;
        }
        public bool CheckSdtExist(string sdt)
        {
            if (GetAllUser().Select(t => t.Sdt).FirstOrDefault() != null)
                return GetAllUser().Any(t => t.Sdt.Equals(sdt));
            return false;
        }
        public bool checkCCCDexist(string cmnd)
        {
            return db.Users.Any(s => s.CCCD.Equals(cmnd));
        }
        public bool checkHoten(string hoten)
        {
            string t = hoten.RemoveUnicode();
            while (t.IndexOf("  ") != -1) t = t.Replace("  ", " ");
            return Regex.IsMatch(t, "^[a-zA-Z ]+$");
        }
        public bool checkdiachi(string diachi)
        {
            string t = diachi.RemoveUnicode();
            while (t.IndexOf("  ") != -1) t = t.Replace("  ", " ");
            return Regex.IsMatch(t, "^[a-zA-Z0-9 ]+$");
        }
        public bool CheckNamKinhNghiem(string NamKinhNghiem)
        {
            bool check = Regex.IsMatch(NamKinhNghiem, "^[0-9]{1,3}$");
            int nkn = -1;
            if (check == true)
            {
                try
                {
                    nkn = int.Parse(NamKinhNghiem);
                }
                catch
                {
                    check = false;
                }
            }
            if (nkn > 0 && nkn <= 120) check = true;
            return check;
        }
        public string GetPassword(string Gmail)
        {
            int IDUsers = GetAllUser().Where(p => p.Gmail.Equals(Gmail)).FirstOrDefault().IDUsers;
            return db.TKs.Where(a => (int)a.IDUser == IDUsers).FirstOrDefault().MatkhauTK;
        }
    }
}
