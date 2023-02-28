using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyen
    {
        public string MaQuyen { get; set; }
        public string TenQuyen { get; set; }
        public PhanQuyen() { }
        public PhanQuyen(string MaQuyen, string TenQuyen)
        {
            this.MaQuyen = MaQuyen;
            this.TenQuyen = TenQuyen;
        }
    }
}
