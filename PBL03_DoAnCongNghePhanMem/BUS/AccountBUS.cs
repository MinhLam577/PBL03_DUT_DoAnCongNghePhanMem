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
        private static AccountBUS instance;
        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBUS();
                return instance;
            }
            private set { }
        }
        public List<Account> Getaccount()
        {
            return AccountDB.Instance.LoadAllAccount();
        }
        public bool AddAccount(Account account)
        {
            return AccountDB.Instance.AddAcount(account) > 0;
        }
        public string GetUser(int MaQuyen)
        {
            return AccountDB.Instance.GetUserByMaQuyen(MaQuyen);
        }
        public bool CheckEmailExist(string email)
        {
            return AccountDB.Instance.CheckEmailExist(email);
        }
        public bool CheckAccountExist(string tentk)
        {
            return AccountDB.Instance.CheckAccountExist(tentk);
        }
        public string GetPassword(string email)
        {
            string res = AccountDB.Instance.GetPassword(email);
            if (res == "") return "Email không đúng hoặc không tồn tại";
            return res;
        }
        public string CheckAccountLogin(string tk, string mk)
        {
            List<Account> acclist = AccountDB.Instance.LoadAllAccount();
            Account Acc = acclist.Where(a => a.TenTK.Equals(tk) && a.MatKhauTK.Equals(mk)).FirstOrDefault();
            if (Acc != default) return GetUser(Acc.MaQuyen);
            return "";
        }
        public bool CheckSdtExist(string sdt)
        {
            return AccountDB.Instance.CheckSdtExist(sdt);
        }
    }
}
