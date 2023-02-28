using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DTO
{
    public class Admin:Person
    {
        public Admin():base(){}
        public Admin(string adTenTK, string adName, int adAge, bool adSex, string adSdt, string adAddress, string adCMND) : 
            base(adTenTK, adName, adSdt, adAge, adSex, adCMND, adAddress){}
    }
}
