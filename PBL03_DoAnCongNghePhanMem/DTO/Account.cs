using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        public string EmailTK { get; set; }
        public string TenTK { get; set; }
        public string MatKhauTK { get; set; }
        public int MaQuyen { get; set; }
        private static Account instance;
        public static Account Instance
        {
            get
            {
                if(instance == null)
                    instance = new Account();
                return instance;
            }
            private set { }
        }

        public Account() { }
        public Account(string EmailTk, string tenTK, string matKhauTK, int MaQuyen)
        {
            EmailTK = EmailTk;
            TenTK = tenTK;
            MatKhauTK = matKhauTK;
            this.MaQuyen = MaQuyen;
        }
    }
}
