using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.ComTypes;
using System.Data;
using QLPhongGym.DTO;
using QLPhongGym.DAL;
using System.Text.RegularExpressions;
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
        public bool CheckTenTKExist(string tentk)
        {
            return TKDAL.Instance.CheckTenTKExist(tentk);
        }
        public bool CheckMKTKExist(string tk, string mk)
        {
            return TKDAL.Instance.CheckMKTKExist(tk, mk);
        }
        public bool AddTK(TK tk)
        {
            return TKDAL.Instance.AddTK(tk) > 0;
        }
        public void DeleteTK(TK tk)
        {
            TKDAL.Instance.DeleteTK(tk);
        }
        public bool UpdateTK(TK tk)
        {
            return TKDAL.Instance.UpdateTK(tk) > 0;
        }
        public int GetIDQuyen(string username)
        {
            return TKDAL.Instance.GetIDQuyen(username);
        }
        public string GetUserName(int IDQuyen) {
            return TKDAL.Instance.GetUserByMaQuyen(IDQuyen);
        }
        public bool checkTkMk(string ac)
        {
            return TKDAL.Instance.checkTkMk(ac);
        }
        public bool checkxnmk(string mk, string xnmk)
        {
            return TKDAL.Instance.checkxnmk(mk, xnmk);
        }
        public TK GetTKByID(int ID)
        {
            return TKDAL.Instance.GetTKByUserID(ID);
        }
        public TK GetTKByTenTK(string TenTK)
        {
            return TKDAL.Instance.GetTKByTenTK(TenTK);
        }

    }
}
