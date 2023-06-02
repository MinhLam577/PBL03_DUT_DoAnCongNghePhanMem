using QLPhongGym.BLL;
using QLPhongGym.DAL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.GUI
{
    public partial class HLV_FormDanhSachKH : Form
    {
        public HLV hlv { get; set; }
        static string ImagePath = Application.StartupPath + @"\Resources\User.png";
        public HLV_FormDanhSachKH()
        {
            InitializeComponent();
        }
        public HLV_FormDanhSachKH(HLV hlv)
        {
            this.hlv = hlv;
            InitializeComponent();
            LoadCBBCa();
            DateTime NgayThue = dtp_nt.Value.Date;
            string TenCa = cb_tenca.Text;
            List<KH> kh = new List<KH>();
            if(!string.IsNullOrEmpty(TenCa))
                kh = DangKiLichLamViecBAL.getInStance.FitlerListKHByNgayThue_IDCa_IDHLV(NgayThue, TenCa, hlv.IDUsers);
            LoadDGVByListKH(kh);
        }
        public void LoadDGVByListKH(List<KH> listkh)
        {
            int cnt = 0;
            DataTable dt = KHBLL.Instance.CreateTable();
            foreach (KH kh in listkh)
            {
                dt.Rows.Add(cnt++, kh.IDUsers, kh.Name, kh.DateBorn, kh.Sex, kh.CCCD, kh.Address, kh.Gmail, kh.Sdt);
            }
            dgv_kh.DataSource = dt;
            dgv_kh.Columns["IDThe"].Visible = false;
        }
        private void LoadThongTinChiTiet(int IDKH, int IDHLV, DateTime NgayThue)
        {
            List<int> IDCa = DangKiLichLamViecBAL.getInStance.GetListCaLamViecByNgayLam_IDHLV_IDKH(IDHLV, NgayThue, IDKH);
            List<string> List_ca = new List<string>();
            List<DangKiGoiTap> List_DKGT = DangKiGoiTapBLL.Instance.GetListDKGTDangTap(IDKH);
            List<string> List_gt = new List<string>();
            foreach(int i in IDCa)
            {
                string TenCa = DangKiLichLamViecBAL.getInStance.GetCaLamViecByIDCa(i).Name;
                List_ca.Add(TenCa);
            }
            foreach(DangKiGoiTap dkgt in List_DKGT)
            {
                List_gt.Add(GoiTapBLL.Instance.GetGTByID(dkgt.IDGT.Value).NameGT);
            }
            cb_detailca.DataSource = List_ca;
            cb_gt.DataSource = List_gt;
        }

        private void dgv_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_kh.SelectedRows.Count > 0)
            {
                try
                {
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                    KH kh = (KH)UsersBLL.Instance.GetUserByID(IDKH);

                    //Show tên khách hàng lên giao diện
                    lb_tenkh.Text = kh.Name;

                    //kiểm tra để show giới tính lên giao diện
                    if ((bool)kh.Sex)
                        lb_gioitinh.Text = "Giới tính: Nam";
                    else lb_gioitinh.Text = "Giới tính: Nữ";
                    LoadThongTinChiTiet(IDKH, hlv.IDUsers, dtp_nt.Value.Date);
                    //Kiểm tra show ảnh lên giao diện
                    if (kh.Image != null)
                        pb_kh.Image = Image.FromFile(Application.StartupPath + @"\PersonImage\" + kh.Image);
                    else pb_kh.Image = Image.FromFile(ImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void LoadCBBCa()
        {
            int IDHLV = hlv.IDUsers;
            DateTime NgayLam = dtp_nt.Value.Date;
            List<int> List_IDCa = DangKiLichLamViecBAL.getInStance.GetCaLamViecByNgayLam_IDHLV(IDHLV, NgayLam);
            List<string> List_Ca = new List<string> { "All" };
            foreach (int i in List_IDCa)
            {
                string TenCa = DangKiLichLamViecBAL.getInStance.GetCaLamViecByIDCa(i).Name;
                List_Ca.Add(TenCa);
            }
            cb_tenca.DataSource = List_Ca;
        }
        private void dtp_ns_ValueChanged(object sender, EventArgs e)
        {
            LoadCBBCa();
        }

        private void cb_tenca_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime NgayThue = dtp_nt.Value.Date;
            string TenCa = cb_tenca.Text;
            var data = DangKiLichLamViecBAL.getInStance.FitlerListKHByNgayThue_IDCa_IDHLV(NgayThue, TenCa, hlv.IDUsers);
            LoadDGVByListKH(data);
        }

        private void cb_detailca_SelectedIndexChanged(object sender, EventArgs e)
        {
            CaLamViec ca = DangKiLichLamViecBAL.getInStance.GetCaLamViecByTenCa((cb_detailca.SelectedItem as string));
            lb_batdau.Text = ca.GioBatDau.Value.ToString();
            lb_ketthuc.Text = ca.GioKetThuc.Value.ToString();
        }

        private void txb_ten_sdt_TextChanged(object sender, EventArgs e)
        {
            dgv_kh.DataSource = KHBLL.Instance.FindListKHByIDOrName(txb_ten_sdt.Text);
        }
    }
}
