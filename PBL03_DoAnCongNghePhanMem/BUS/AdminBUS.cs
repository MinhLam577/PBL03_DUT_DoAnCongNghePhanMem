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
        AdminDB addb = new AdminDB();
        public bool AddAdmin(Admin ad)
        {
            return addb.AddAdmin(ad) > 0;
        }
        public List<Admin> GetAdmin()
        {
            return addb.LoadAllAdmin();
        }
    }
}
