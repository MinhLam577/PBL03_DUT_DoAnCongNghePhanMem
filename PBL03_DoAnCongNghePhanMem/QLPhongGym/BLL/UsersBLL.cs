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
        public bool AddUser(User user)
        {
            return UsersDAL.Instance.AddUsers(user) > 0;
        }
        public void DeleteUser(User user)
        {
            UsersDAL.Instance.DeleteUsers(user);
        }
        public bool CheckCmnd(string Cmnd)
        {
            return UsersDAL.Instance.checkcmnd(Cmnd);
        }
        public bool CheckHoTen(string Hoten)
        {
            return UsersDAL.Instance.checkHoten(Hoten);
        }
        public bool CheckDiaChi(string DiaChi)
        {
            return UsersDAL.Instance.checkdiachi(DiaChi);
        }
        public bool CheckNamKinhNghiem(string NamKinhNghiem)
        {
            return UsersDAL.Instance.CheckNamKinhNghiem(NamKinhNghiem);
        }
        public int GetUserID(string CCCD)
        {
            return UsersDAL.Instance.GetUsersID(CCCD);
        }
    }
}
