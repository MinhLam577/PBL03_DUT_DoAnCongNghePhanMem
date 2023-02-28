using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Person
    {
        public string TenTK { get; set; }
        public string Ten { get; set; }
        public string Sdt { get; set; }
        public int Age { get; set; }
        public bool Sex { get; set; }
        public string Cmnd { get; set; }
        public string Address { get; set; }
        public Person() { }
        public Person(string tenTK, string ten, string sdt, int age, bool sex, string cmnd, string address)
        {
            TenTK = tenTK;
            Ten = ten;
            Sdt = sdt;
            Age = age;
            Sex = sex;
            Cmnd = cmnd;
            Address = address;
        }
    }
}
