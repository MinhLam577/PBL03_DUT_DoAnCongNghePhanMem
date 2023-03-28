using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;
using System.Data;
using QLPhongGym.DTO;
using QLPhongGym.DAL;
using DAL;

namespace QLPhongGym.BLL
{
    public class TKBLL
    {
        private static TKBLL instance;
        public static TKBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TKBLL();
                return instance;
            }
            private set { }
        }
        public List<TK> GetAllTK()
        {
            return TKDAL.Instance.LoadAllTK();
        }
        public bool CheckEmailExist(string email)
        {
            return TKDAL.Instance.CheckEmailExist(email);
        }
        public bool CheckTenTKExist(string tentk)
        {
            return TKDAL.Instance.CheckTenTKExist(tentk);
        }
        public bool CheckMKTKExist(string mk)
        {
            return TKDAL.Instance.CheckMKTKExist(mk);
        }
        public bool CheckSdtExist(string sdt)
        {
            return TKDAL.Instance.CheckSdtExist(sdt);
        }
        public bool AddTK(TK tk)
        {
            return TKDAL.Instance.AddTK(tk) > 0;
        }
        public void DeleteTK(TK tk)
        {
            TKDAL.Instance.DeleteTK(tk);
        }
        public int GetIDQuyen(string username)
        {
            return TKDAL.Instance.GetIDQuyen(username);
        }
        public string GetUserName(int IDQuyen) {
            return TKDAL.Instance.GetUserByMaQuyen(IDQuyen);
        }
        public string GetPassword(string Email)
        {
            return TKDAL.Instance.GetPassword(Email);
        }
    }
}
