using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HLV : Person
    {
        public string BangCap { get; set; }
        public int NamKinhNghiem { get; set; }
        public HLV():base() { }
        public HLV(string tenTK, string ten, string sdt, int age, bool sex, string cmnd, string address, string bangCap, int namKinhNghiem):
            base(tenTK, ten, sdt, age, sex, cmnd, address){
            BangCap = bangCap;
            NamKinhNghiem = namKinhNghiem;
        }
    }
}
