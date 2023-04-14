using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongGym.DAL
{
    class GoiTapDAL
    {
        QLPhongGymDB db = new QLPhongGymDB();
        private static GoiTapDAL instance;
        public static GoiTapDAL Instance
        {
            get
            {
                if(instance == null)
                    instance = new GoiTapDAL();
                return instance;
            }
            private set { }
        }
        public List<GoiTap> GetAllGT()
        {
            List<GoiTap> list = new List<GoiTap>();
            var item = db.GoiTaps.Select(s => new
            {
                s.IDGT, s.NameGT, s.Price
            }).ToList();
            foreach(var i in item)
            {
                list.Add(new GoiTap { IDGT = i.IDGT, NameGT = i.NameGT, Price = i.Price });
            }
            return list;
        }
        public GoiTap GetGTByName(string name)
        {
            return db.GoiTaps.SingleOrDefault(s => s.NameGT.Equals(name));
        }
        public GoiTap GetGTByID(int ID)
        {
            return db.GoiTaps.Where(s => (int)s.IDGT == ID).FirstOrDefault();
        }
        public int AddGT(GoiTap GT)
        {
            db.GoiTaps.Add(GT);
            return db.SaveChanges(); 
        }
        public void DeleteGT(GoiTap GT)
        {
            db.GoiTaps.Remove(GT);
        }
        public int UpdateGT(GoiTap GT)
        {
            db.Entry(GT).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
