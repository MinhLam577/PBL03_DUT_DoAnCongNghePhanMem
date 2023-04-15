using QLPhongGym.DAL;
using QLPhongGym.DTO;
using QLPhongGym.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongGym.BLL
{
    class DangKiGoiTapBLL
    {
        private static DangKiGoiTapBLL instance;
        public static DangKiGoiTapBLL Instance
        {
            get
            {
                if(instance == null)
                    instance = new DangKiGoiTapBLL();
                return instance;
            }
            private set { }
        }
        public DataTable FindListDKKHByIDOrName(string txt)
        {
            return DangKiGoiTapDAL.Instance.FindListDKKHByIDOrName(txt);
        }
        public DataTable SortListDKKHBy(string require, DataTable dt)
        {
            return DangKiGoiTapDAL.Instance.SortDKKHBy(require, dt);
        }
        public bool AddDKGT(DangKiGoiTap dkgt)
        {
            return DangKiGoiTapDAL.Instance.AddDKGT(dkgt) > 0;
        }
        public bool UpdateDKGT(DangKiGoiTap dangKiGoiTap)
        {
            return DangKiGoiTapDAL.Instance.UpdateDKGT(dangKiGoiTap) > 0;
        }
        public void DeleteDKGT(DangKiGoiTap dkgt)
        {
            DangKiGoiTapDAL.Instance.DeleteDKGT(dkgt);
        }
        public DangKiGoiTap GetDKGTByIDKH_NgayDangKi_NgayKetThuc(int IDKH, DateTime ngaydangki, DateTime ngayketthuc)
        {
            return DangKiGoiTapDAL.Instance.GetDKGTByIDKH_NgayDangKi_NgayKetThuc(IDKH, ngaydangki, ngayketthuc);
        }
        public DataTable GetDKKHDataTableByIDKH(int IDKH)
        {
            return DangKiGoiTapDAL.Instance.GetDKKHDataTableByIDKH(IDKH);
        }
        public List<DangKiGoiTap> GetAllDKGTByIDKH(int IDKH)
        {
            return DangKiGoiTapDAL.Instance.GetAllDKGTByIDKH(IDKH);
        }
        public void DeleteAllDKGT(List<DangKiGoiTap> list)
        {
            DangKiGoiTapDAL.Instance.DeleteAllDKGTByIDKH(list);
        }
        public DangKiGoiTap GetDKGTByIDKH(int IDKH)
        {
            return DangKiGoiTapDAL.Instance.GetDKKHByIDKH(IDKH);
        }
    }
}
