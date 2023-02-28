using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KH:Person
    {
        private static KH instance;
        public static KH Instance
        {
            get
            {
                if (instance == null)
                    instance = new KH();
                return instance;
            }
            private set { }
        }
        public KH():base() { }
        public KH(string kHTenTK, string kHTen, string kHSdt, int kHAge, bool kHSex, string kHCmnd, string kHAddress):
            base(kHTenTK, kHTen, kHSdt, kHAge, kHSex, kHCmnd, kHAddress){}
    }
}
