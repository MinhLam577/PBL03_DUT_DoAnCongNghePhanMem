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
        public DataTable CreateTable()
        {
            return DangKiGoiTapDAL.Instance.CreateTable();
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
        public DataTable GetDKGT_Newest_DataTableByIDKH(int IDKH)
        {
            return DangKiGoiTapDAL.Instance.GetDKGT_Newest_DataTableByIDKH(IDKH);
        }
        public List<DangKiGoiTap> GetAllDKGTByIDKH(int IDKH)
        {
            return DangKiGoiTapDAL.Instance.GetAllDKGTByIDKH(IDKH);
        }
        public void DeleteAllDKGT(List<DangKiGoiTap> list)
        {
            DangKiGoiTapDAL.Instance.DeleteAllDKGT(list);
        }
        public DangKiGoiTap GetDKGT_Newest_ByIDKH(int IDKH)
        {
            return DangKiGoiTapDAL.Instance.GetDKGT_Newest_ByIDKH(IDKH);
        }
        public DangKiGoiTap GetDKGTByIDKH_NgayDangKi_IDGT(int IDKH, DateTime ngaydangki, int IDGT)
        {
            return DangKiGoiTapDAL.Instance.GetDKGTByIDKH_NgayDangKi_IDGT(IDKH, ngaydangki, IDGT);
        }
        public DangKiGoiTap GetDLGTByIDKH_NgayDangKi_NgayKetThuc_IDGT(int IDKH, DateTime ngaydangki, DateTime ngayketthuc, int IDGT)
        {
            return DangKiGoiTapDAL.Instance.GetDLGTByIDKH_NgayDangKi_NgayKetThuc_IDGT(IDKH, ngaydangki, ngayketthuc, IDGT);
        }
        public DangKiGoiTap GetDKGT_Newest_ByIDKH_IDGT(int IDKH, int IDGT)
        {
            return DangKiGoiTapDAL.Instance.GetDKGT_Newest_ByIDKH_IDGT(IDKH, IDGT);
        }
        public int GetSoLuongDKGTTheoNamVaThang(int year, int month)
        {
            return DangKiGoiTapDAL.Instance.GetSoLuongDKGTTheoNamVaThang(year, month);
        }
        public DataTable FitlerListDKGT(int IDKH, string require, string GoiTap)
        {
            return DangKiGoiTapDAL.Instance.FitlerListDKGT(IDKH, require, GoiTap);
        }
        public List<DangKiGoiTap> GetListDKGTDangTap(int IDKH)
        {
            return DangKiGoiTapDAL.Instance.GetListDKGTDangTap(IDKH);
        }
        public int GetSoLuongNhuCauDKGTTheoNam_Thang_IDGT(int year, int month, int IDGT)
        {
            return DangKiGoiTapDAL.Instance.GetSoLuongNhuCauDKGTTheoNam_Thang_IDGT(year, month, IDGT);
        }
        public List<DangKiGoiTap> GetListDKGTByYear(int year)
        {
            return DangKiGoiTapDAL.Instance.GetListDKGTByYear(year);
        }
        public List<DangKiGoiTap> GetListDKGTByIDGT(int IDGT)
        {
            return DangKiGoiTapDAL.Instance.GetListDKGTByIDGT(IDGT);
        }
    }
}
