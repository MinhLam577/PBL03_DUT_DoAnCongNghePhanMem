using QLPhongGym.BLL;
using QLPhongGym.DAL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        }
        public void LoadDGVByListKH(List<KH> listkh)
        {
            int cnt = 1;
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
                    if (!string.IsNullOrEmpty(kh.Gmail))
                        lb_gmail.Text = kh.Gmail;
                    else lb_gmail.Text = "NA";
                    if (!string.IsNullOrEmpty(kh.Sdt))
                        lb_sdt.Text = kh.Sdt;
                    else lb_sdt.Text = "NA";
                    lb_diachi.Text = kh.Address;
                    LoadThongTinChiTiet(IDKH, hlv.IDUsers, DateTime.ParseExact(cb_nt.Text,
                            "dd/MM/yyyy",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None).Date);
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
            DateTime NgayLam = DateTime.ParseExact(cb_nt.Text,
                            "dd/MM/yyyy",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None).Date;
            List<int> List_IDCa = DangKiLichLamViecBAL.getInStance.GetCaLamViecByNgayLam_IDHLV(IDHLV, NgayLam);
            List<string> List_Ca = new List<string> { "All" };
            foreach (int i in List_IDCa)
            {
                string TenCa = DangKiLichLamViecBAL.getInStance.GetCaLamViecByIDCa(i).Name;
                List_Ca.Add(TenCa);
            }
            cb_tenca.DataSource = List_Ca;
        }

        private void cb_tenca_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime NgayThue = DateTime.ParseExact(cb_nt.Text,
                            "dd/MM/yyyy",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None).Date;
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
            try
            {
                DateTime NgayThue = DateTime.ParseExact(cb_nt.Text,
                            "dd/MM/yyyy",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None).Date;
                string TenCa = cb_tenca.Text;
                if (cb_tenca.Text != "All")
                {
                    dgv_kh.DataSource = KHBLL.Instance.FindListKHByIDHLV_NgayThue_IDCa_IDOrName(txb_ten_sdt.Text,
                        hlv.IDUsers, NgayThue, DangKiLichLamViecBAL.getInStance.GetCaLamViecByTenCa(TenCa).IDCa);
                }
                else
                {
                    dgv_kh.DataSource = KHBLL.Instance.FindListKHByIDHLV_NgayThue_IDCa_IDOrName(txb_ten_sdt.Text,
                        hlv.IDUsers, NgayThue, null);
                }
            }
            catch
            {
                MessageBox.Show("Tìm kiếm thất bại");
            }
            
        }
        private bool checkNamNhuan(int year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) ||
                    (year % 400 == 0));
        }
        private void nmup_tuan_ValueChanged(object sender, EventArgs e)
        {
            int Month = dtp_thangnam.Value.Month;
            int Year = dtp_thangnam.Value.Year;
            List<string> CBB_data = new List<string>();
            switch ((int)nmup_tuan.Value)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    dtp_from.Value = new DateTime(Year, Month, 7 * ((int)nmup_tuan.Value - 1) + 1);
                    dtp_to.Value = dtp_from.Value.AddDays(6);
                    for (int i = 0; i <= 6; i++)
                    {
                        DateTime dt = dtp_from.Value.AddDays(i);
                        CBB_data.Add(dt.ToString("dd/MM/yyyy"));
                    }
                    cb_nt.DataSource = CBB_data;
                    break;
                case 5:
                    int day = -1;
                    int ngayle = -1;
                    if(Month == 2)
                    {
                        if (checkNamNhuan(Year))
                        {
                            dtp_from.Value = new DateTime(Year, Month, 29);
                            dtp_to.Value = dtp_from.Value;
                            DateTime dt = dtp_from.Value;
                            CBB_data.Add(dt.ToString("dd/MM/yyyy"));
                            cb_nt.DataSource = CBB_data;
                        }
                        else
                        {
                            dtp_from.Value = new DateTime(Year, Month, 28);
                            dtp_to.Value = dtp_from.Value;
                            DateTime dt = dtp_from.Value;
                            CBB_data.Add(dt.ToString("dd/MM/yyyy"));
                            cb_nt.DataSource = CBB_data;
                        }
                            
                    }    
                    else
                    {
                        dtp_from.Value = new DateTime(Year, Month, 7 * ((int)nmup_tuan.Value - 1) + 1);
                        day = DateTime.DaysInMonth(Year, Month);
                        ngayle = day - 28;
                        dtp_to.Value = dtp_from.Value.AddDays(ngayle - 1);
                        for (int i = 0; i < ngayle; i++)
                        {
                            DateTime dt = dtp_from.Value.AddDays(i);
                            CBB_data.Add(dt.ToString("dd/MM/yyyy"));
                        }
                        cb_nt.DataSource = CBB_data;
                    }
                    break;
            }
        }

        private void dtp_thangnam_ValueChanged(object sender, EventArgs e)
        {
            int Month = dtp_thangnam.Value.Month;
            int Year = dtp_thangnam.Value.Year;
            nmup_tuan.Value = nmup_tuan.Minimum;
            nmup_tuan_ValueChanged(sender, e);
        }

        private void HLV_FormDanhSachKH_Load(object sender, EventArgs e)
        {
            dtp_thangnam_ValueChanged(sender, e);
        }

        private void cb_nt_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCBBCa();
        }

    }
}
