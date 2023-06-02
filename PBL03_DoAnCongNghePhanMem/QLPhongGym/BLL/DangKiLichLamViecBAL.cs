﻿using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QLPhongGym.DAL;

namespace QLPhongGym.BLL
{
    public class DangKiLichLamViecBAL
    {
        private static DangKiLichLamViecBAL instance;
        public DangKiLichLamViecBAL()
        {

        }
        public static DangKiLichLamViecBAL getInStance
        {
            get
            {
                if (instance == null)
                    instance = new DangKiLichLamViecBAL();
                return instance;
            }
            private set
            {
            }
        }
        public DataTable CapNhatListDangKiCa(DateTime ngaystart, DateTime ngayend)
        {

            return DangKiLichLamViecDAL.getInStance.CapNhatListHLV(ngaystart, ngayend);
        }
        public bool Them(LichLamViecTrongTuan a)
        {
            return DangKiLichLamViecDAL.getInStance.ThemCaLamViec(a);
        }
        public bool IsDifferentFromAllCaOther(LichLamViecTrongTuan b)
        {
            return DangKiLichLamViecDAL.getInStance.IsDifferentFromAllCaOther(b);
        }
        public void Exitt(List<LichLamViecTrongTuan> a)
        {
            DangKiLichLamViecDAL.getInStance.Exit(a);
        }
        public bool AddPersonIfNotExists(int idhlv, int idca, DateTime ngaybatdau, DateTime ngayketthuc, DateTime ngaylam)
        {
            return DangKiLichLamViecDAL.getInStance.AddPersonIfNotExists(idhlv, idca, ngaybatdau, ngayketthuc, ngaylam);
        }
        public DataTable TimKiemLichLamViec(int idca, DateTime ngaybatdau, DateTime ngayketthuc)
        {

            return DangKiLichLamViecDAL.getInStance.TimKiemLichLamViec(idca, ngaybatdau, ngayketthuc);
        }
        public DataTable TimKiemLichLamViecTheoNgay(int idca, DateTime ngaylam)
        {

            return DangKiLichLamViecDAL.getInStance.TimKiemLichLamViecTheoNgay(idca, ngaylam);
        }
        public bool Xoa(LichLamViecTrongTuan a)
        {
            return DangKiLichLamViecDAL.getInStance.Xoa(a);
        }
        public bool UpdateOrder(int IDHLV, int IDCa, DateTime ngaybatdau, DateTime ngayketthuc, DateTime NgayLam)
        {
            return DangKiLichLamViecDAL.getInStance.UpdateOrder(IDHLV, IDCa, ngaybatdau, ngayketthuc, NgayLam);

        }
        public DataTable CapNhatListHLVAll()
        {

            return DangKiLichLamViecDAL.getInStance.CapNhatListHLVAll();
        }

        public bool capnhat(int idca, int idhlv, DateTime ngaybatdau, DateTime ngayketthuc, DateTime ngaylam, int IDCA, int IDHLV, DateTime NGAYBATDAU, DateTime NGAYKETTHUC, DateTime NGAYLAM)
        {
            return DangKiLichLamViecDAL.getInStance.capnhat(idca, idhlv, ngaybatdau, ngayketthuc, ngaylam, IDCA, IDHLV, NGAYBATDAU, NGAYKETTHUC, NGAYLAM);

        }

        public bool Capnhat1(int idca, int idhlv, /*DateTime ngaybatdau, DateTime ngayketthuc,*/ DateTime ngaylam, int IDCA, int IDHLV,/* DateTime NGAYBATDAU, DateTime NGAYKETTHUC, */DateTime NGAYLAM)
        {
            return DangKiLichLamViecDAL.getInStance.Capnhat1(idca, idhlv, /*ngaybatdau, ngayketthuc,*/ ngaylam, IDCA, IDHLV, /*NGAYBATDAU, NGAYKETTHUC,*/ NGAYLAM);
        }
        public DataTable XemTheoNgay(DateTime ngay)
        {

            return DangKiLichLamViecDAL.getInStance.XemTheoNgay(ngay);
        }
        public DataTable XemTheoTuan(DateTime ngaybatdau, DateTime ngayketthuc)
        {

            return DangKiLichLamViecDAL.getInStance.XemTheoTuan(ngaybatdau, ngayketthuc);
        }
        public DataTable XemTheoNgay1(DateTime ngay)
        {

            return DangKiLichLamViecDAL.getInStance.XemTheoNgay(ngay);
        }
        public string DisplayHLVTheoCa(string listhlv, int idca, DateTime ngaylam)
        {
            listhlv = "";

            return DangKiLichLamViecDAL.getInStance.DisplayHLVTheoCa(listhlv, idca, ngaylam);

        }
        public List<String> danhsachsinhvientheongayca(DateTime ngay, int idca)
        {
            return DangKiLichLamViecDAL.getInStance.danhsachsinhvientheongayca(ngay, idca);
        }
        public DataTable ListHLVByCaForm2(DateTime ngaylam, int idca)
        {
            return DangKiLichLamViecDAL.getInStance.ListHLVByCaForm2(ngaylam, idca);
        }
        public List<int> GetCaLamViecByNgayLam_IDHLV(int IDHLV, DateTime NgayLam)
        {
            return DangKiLichLamViecDAL.getInStance.GetCaLamViecByNgayLam_IDHLV(IDHLV, NgayLam);
        }
        public CaLamViec GetCaLamViecByIDCa(int IDCa)
        {
            return DangKiLichLamViecDAL.getInStance.GetCaLamViecByIDCa(IDCa);
        }
        public CaLamViec GetCaLamViecByTenCa(string TenCa)
        {
            return DangKiLichLamViecDAL.getInStance.GetCaLamViecByTenCa(TenCa);
        }
        public List<KH> FitlerListKHByNgayThue_IDCa_IDHLV(DateTime NgayThue, string TenCa, int IDHLV)
        {
            return DangKiLichLamViecDAL.getInStance.FitlerListKHByNgayThue_IDCa_IDHLV(NgayThue, TenCa, IDHLV); 
        }
        public List<int> GetListCaLamViecByNgayLam_IDHLV_IDKH(int IDHLV, DateTime NgayLam, int IDKH)
        {
            return DangKiLichLamViecDAL.getInStance.GetListCaLamViecByNgayLam_IDHLV_IDKH(IDHLV, NgayLam, IDKH); 
        }
    }
}
