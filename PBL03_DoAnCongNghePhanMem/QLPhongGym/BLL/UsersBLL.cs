using QLPhongGym.DAL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongGym.BLL
{
    public class UsersBLL
    {
        private static UsersBLL instance;
        public static UsersBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new UsersBLL();
                return instance;
            }
            private set { }
        }
        public User GetUserByID(int id)
        {
            return UsersDAL.Instance.GetUserByID(id);
        }
        public bool AddUser(User user)
        {
            return UsersDAL.Instance.AddUsers(user) > 0;
        }
        public void DeleteUser(User user)
        {
            UsersDAL.Instance.DeleteUsers(user);
        }
        public bool UpdateUser(User user)
        {
            return UsersDAL.Instance.UpdateUsers(user) > 0;
        }
        public bool CheckGmailExist(string gmail)
        {
            return UsersDAL.Instance.CheckEmailExist(gmail);
        }
        public bool CheckSDTExist(string sdt)
        {
            return UsersDAL.Instance.CheckSdtExist(sdt);
        }
        public bool CheckGmail(string gmail)
        {
            return UsersDAL.Instance.checkEmail(gmail);
        }
        public bool CheckSDT(string sdt)
        {
            return UsersDAL.Instance.checksdt(sdt);
        }
        public bool CheckCccd(string Cmnd)
        {
            return UsersDAL.Instance.checkcccd(Cmnd);
        }
        public bool checkCCCDexist(string Cmnd)
        {
            return UsersDAL.Instance.checkCCCDexist(Cmnd);
        }
        public bool CheckHoTen(string Hoten)
        {
            return UsersDAL.Instance.checkHoten(Hoten);
        }
        public bool CheckNS(DateTime NS)
        {
            return UsersDAL.Instance.CheckNS(NS);
        }
        public bool CheckDiaChi(string DiaChi)
        {
            return UsersDAL.Instance.checkdiachi(DiaChi);
        }
        public bool CheckNamKinhNghiem(string NamKinhNghiem)
        {
            return UsersDAL.Instance.CheckNamKinhNghiem(NamKinhNghiem);
        }
        public bool CheckUserExist(string CCCD, string Name)
        {
            return UsersDAL.Instance.CheckUserExist(CCCD, Name);
        }
        public int GetUserIDByCCCD(string CCCD)
        {
            return UsersDAL.Instance.GetUsersIDByCCCD(CCCD);
        }

        public User GetUserByGmail(string gmail)
        {
            return UsersDAL.Instance.GetUserByGmail(gmail);
        }
        public string GetPassword(string Gmail)
        {
            return UsersDAL.Instance.GetPassword(Gmail);
        }
        public User GetUserByName(string Name)
        {
            return UsersDAL.Instance.GetUserByName(Name);
        }


    }
}
