using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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
        public bool checkAge(string age)
        {
            int t;
            try { t = Convert.ToInt32(Regex.Match(age, "^[0-9]{1,3}$").ToString()); }
            catch { return false; }
            return t >= 10 && t <= 120;
        }
        public bool checkcmnd(string cmnd)
        {
            return Regex.IsMatch(cmnd, "^[0-9]{12}$");
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
    }
}
