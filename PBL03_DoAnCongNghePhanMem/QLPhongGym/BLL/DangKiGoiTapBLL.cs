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
        public DataTable GetDKKH_Newest_DataTableByIDKH(int IDKH)
        {
            return DangKiGoiTapDAL.Instance.GetDKKH_Newest_DataTableByIDKH(IDKH);
        }
        public List<DangKiGoiTap> GetAllDKGTByIDKH(int IDKH)
        {
            return DangKiGoiTapDAL.Instance.GetAllDKGTByIDKH(IDKH);
        }
        public void DeleteAllDKGT(List<DangKiGoiTap> list)
        {
            DangKiGoiTapDAL.Instance.DeleteAllDKGTByIDKH(list);
        }
        public DangKiGoiTap GetDKKH_Newest_ByIDKH(int IDKH)
        {
            return DangKiGoiTapDAL.Instance.GetDKKH_Newest_ByIDKH(IDKH);
        }
        public DangKiGoiTap GetDKGTByIDKH_NgayDangKi_IDGT(int IDKH, DateTime ngaydangki, int IDGT)
        {
            return DangKiGoiTapDAL.Instance.GetDKGTByIDKH_NgayDangKi_IDGT(IDKH, ngaydangki, IDGT);
        }
        public DangKiGoiTap GetDLGTByIDKH_NgayDangKi_NgayKetThuc_IDGT(int IDKH, DateTime ngaydangki, DateTime ngayketthuc, int IDGT)
        {
            return DangKiGoiTapDAL.Instance.GetDLGTByIDKH_NgayDangKi_NgayKetThuc_IDGT(IDKH, ngaydangki, ngayketthuc, IDGT);
        }
    }
}
