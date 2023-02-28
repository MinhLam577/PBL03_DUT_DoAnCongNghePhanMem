using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AdminBUS
    {
        private static AdminBUS instance;
        public static AdminBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AdminBUS();
                return instance;
            }
            private set { }
        }
        public bool AddAdmin(Admin ad)
        {
            return AdminDB.Instance.AddAdmin(ad) > 0;
        }
        public List<Admin> GetAdmin()
        {
            return AdminDB.Instance.LoadAllAdmin();
        }
    }
}
