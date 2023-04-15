﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            try
            {
                db.Users.Add(user);
                return db.SaveChanges();
            }
            catch
            {
                return 0;
            }
        }
        public int UpdateUsers(User user)
        {
            try
            {
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                return db.SaveChanges();
            }
            catch
            { return 0; }
        }
        public void DeleteUsers(User user)
        {
            try
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        public int GetUsersID(string CCCD)
        {
            try
            {
                int UserID = db.Users.Where(s => s.CCCD.Equals(CCCD)).FirstOrDefault().IDUsers;
                return UserID;
            }
            catch
            {
                return 0;
            }
            
        }
        public User GetUserByID(int IDUsers)
        {
            try
            {
                return db.Users.Where(s => s.IDUsers.Equals(IDUsers)).FirstOrDefault();
            }
            catch
            {
                return null;
            }
            
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
            if(string.IsNullOrEmpty(cccd)) return true;
            return Regex.IsMatch(cccd, "^[0-9]{12}$");
        }
        public List<User> GetAllUser()
        {
            return db.Users.ToList();
        }
        public bool CheckEmailExist(string gmail)
        {
            try
            {
                return GetAllUser().Any(t => !string.IsNullOrEmpty(t.Gmail) && t.Gmail.Equals(gmail));
            }
            catch
            {
                return false;
            }
        }
        public bool CheckSdtExist(string sdt)
        {
            try
            {
                if (GetAllUser().Select(t => t.Sdt).FirstOrDefault() != null)
                    return GetAllUser().Any(t => t.Sdt.Equals(sdt));
                return false;
            }
            catch
            {
                return false;
            }
            
        }
        public bool checkCCCDexist(string cmnd)
        {
            try
            {
                return db.Users.Any(s => !string.IsNullOrEmpty(s.CCCD) && s.CCCD.Equals(cmnd));
            }
            catch
            {
                return false;
            }
            
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
        public bool CheckNS(DateTime NS)
        {
            return DateTime.Now.Year - NS.Year >= 10 && DateTime.Now.Year - NS.Year <= 120;
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
            try
            {
                int IDUsers = GetAllUser().Where(p => p.Gmail.Equals(Gmail)).FirstOrDefault().IDUsers;
                return db.TKs.Where(a => (int)a.IDUser == IDUsers).FirstOrDefault().MatkhauTK;
            }
            catch
            {
                return null;
            }
            
        }
    }
}
