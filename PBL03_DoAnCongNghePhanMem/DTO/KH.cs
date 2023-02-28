using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KH:Person
    {
        
        public KH():base() { }
        public KH(string kHTenTK, string kHTen, string kHSdt, int kHAge, bool kHSex, string kHCmnd, string kHAddress):
            base(kHTenTK, kHTen, kHSdt, kHAge, kHSex, kHCmnd, kHAddress){}
    }
}
