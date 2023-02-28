using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Runtime.InteropServices.ComTypes;
using System.Data;

namespace BUS
{
    public class AccountBUS
    {
        Account accdto = new Account();
        AccountDB db = new AccountDB();
        public List<Account> Getaccount()
        {
            return db.LoadAllAccount();
        }
        public bool AddAccount(Account account)
        {
            return db.AddAcount(account) > 0;
        }
        public string GetUser(int MaQuyen)
        {
            return db.GetUserByMaQuyen(MaQuyen);
        }
        public bool CheckEmailExist(string email)
        {
            return db.CheckEmailExist(email);
        }
        public bool CheckAccountExist(string tentk)
        {
            return db.CheckAccountExist(tentk);
        }
        public string GetPassword(string email)
        {
            string res = db.GetPassword(email);
            if (res == "") return "Email không đúng hoặc không tồn tại";
            return res;
        }
        public string CheckAccountLogin(string tk, string mk)
        {
            List<Account> acclist = db.LoadAllAccount();
            Account Acc = acclist.Where(a => a.TenTK.Equals(tk) && a.MatKhauTK.Equals(mk)).FirstOrDefault();
            if (Acc != default) return GetUser(Acc.MaQuyen);
            return "";
        }
    }
}
