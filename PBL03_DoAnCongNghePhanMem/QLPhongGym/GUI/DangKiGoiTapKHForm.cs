using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongGym.DTO;
using QLPhongGym.BLL;
using System.Data.Entity.Migrations.Model;

namespace QLPhongGym.GUI
{
    public partial class DangKiGoiTapKHForm : Form
    {
        public KH kh { get; set; }
        public event EventHandler DangKiThanhCong;
        public string GoiTap { get; set; }
        public DangKiGoiTapKHForm()
        {
            InitializeComponent();
        }
        public DangKiGoiTapKHForm(KH kh, string GoiTap)
        {
            InitializeComponent();
            this.kh = kh;
            this.GoiTap = GoiTap;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool CheckNgay(DateTime ngaydangki, DateTime ngayketthuc)
        {
            if (ngaydangki < DateTime.Now)
                return false;
            if(ngayketthuc <= ngaydangki)
                return false;
            return true;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string gt = cb_gt.Text;
                int IDGT;
                DateTime NgayDangKi = dtp_ngaydangki.Value;
                DateTime NgayKetThuc = dtp_ngayketthuc.Value;
                
                if (string.IsNullOrEmpty(gt))
                {
                    MessageBox.Show("Mời nhập vào thông tin còn trống");
                    return;
                }
                if (CheckNgay(NgayDangKi, NgayKetThuc))
                {
                    MessageBox.Show("Ngày đăng kí hoặc ngày kết thúc không đúng");
                    return;
                }
                
                IDGT = GoiTapBLL.Instance.GetGTByName(gt).IDGT;
                if(!KHBLL.Instance.CheckUserExist(kh.CCCD, kh.Name))
                {
                    if (KHBLL.Instance.AddUser(kh))
                    {
                        DangKiGoiTap dkgt = new DangKiGoiTap
                        {
                            IDGT = IDGT,
                            IDKH = kh.IDUsers,
                            NgayDangKiGT = NgayDangKi,
                            NgayKetThucGT = NgayKetThuc
                        };
                        try
                        {

                            if (DangKiGoiTapBLL.Instance.AddDKGT(dkgt))
                            {
                                string giamgia = (Convert.ToInt32(lb_dongia.Text) * numeric_giamgia.Value / 100).ToString();
                                HoaDon hd = new HoaDon {
                                    IDGT = IDGT, IDKH = kh.IDUsers, NgayThanhToan = DateTime.Now, Price = Convert.ToDouble(lb_dongia.Text) - Convert.ToDouble(giamgia)
                                };
                                try
                                {
                                    HoaDonBLL.Instance.AddHoaDon(hd);
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Thêm hóa đơn không thành công");
                                }
                                
                                if (MessageBox.Show("Đăng kí gói tập thành công") == DialogResult.OK)
                                {
                                    if (cb_inhoadon.Checked)
                                    {
                                        
                                        HoaDonForm f = new HoaDonForm(kh.Name, gt, giamgia, dkgt, null);
                                        DangKiThanhCong(this, new EventArgs());
                                        f.Show();
                                    }
                                    else
                                        DangKiThanhCong(this, new EventArgs());
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Đăng kí gói tập không thành công");
                            KHBLL.Instance.DeleteUser(kh);
                        }
                    }
                }
                else
                {
                    DangKiGoiTap dkgt = new DangKiGoiTap
                    {
                        IDGT = IDGT,
                        IDKH = kh.IDUsers,
                        NgayDangKiGT = NgayDangKi,
                        NgayKetThucGT = NgayKetThuc
                    };
                    if (DangKiGoiTapBLL.Instance.AddDKGT(dkgt))
                    {
                        string giamgia = (Convert.ToInt32(lb_dongia.Text) * numeric_giamgia.Value / 100).ToString();
                        HoaDon hd = new HoaDon
                        {
                            IDGT = IDGT,
                            IDKH = kh.IDUsers,
                            NgayThanhToan = DateTime.Now,
                            Price = Convert.ToDouble(lb_dongia.Text) - Convert.ToDouble(giamgia)
                        };
                        try
                        {
                            HoaDonBLL.Instance.AddHoaDon(hd);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Thêm hóa đơn không thành công");
                        }
                        if (MessageBox.Show("Đăng kí gói tập thành công") == DialogResult.OK)
                        {
                            if (cb_inhoadon.Checked)
                            {
                                HoaDonForm f = new HoaDonForm(kh.Name, gt, giamgia, dkgt, null);
                                DangKiThanhCong(this, new EventArgs());
                                f.Show();
                            }
                            else
                                DangKiThanhCong(this, new EventArgs());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Đăng kí gói tập không thành công");
            }
            
        }
        private void DangKiGoiTapFormKH_Load(object sender, EventArgs e)
        {
            rb_tienmat.Checked = true;
            cb_gt.DisplayMember = "NameGT";
            cb_gt.DataSource = GoiTapBLL.Instance.GetAllGT();
            if(GoiTap != "")
                cb_gt.Text = GoiTap;
        }
        private void cb_gt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
                if(GoiTap == "")
                {
                    if ((cb_gt.SelectedItem as GoiTap) != null)
                    {
                        switch ((cb_gt.SelectedItem as GoiTap).NameGT)
                        {
                            case "1 Tháng":
                                dtp_ngaydangki.Value = now;
                                dtp_ngayketthuc.Value = dtp_ngaydangki.Value.AddMonths(1);
                                numeric_giamgia.Value = 0;
                                lb_dongia.Text = (cb_gt.SelectedItem as GoiTap).Price.ToString();
                                lb_thanhtien.Text = lb_dongia.Text;
                                lb_thanhtoan.Text = lb_thanhtien.Text;
                                break;
                            case "6 Tháng":
                                dtp_ngaydangki.Value = now;
                                dtp_ngayketthuc.Value = dtp_ngaydangki.Value.AddMonths(6);
                                numeric_giamgia.Value = 0;
                                lb_dongia.Text = (cb_gt.SelectedItem as GoiTap).Price.ToString();
                                lb_thanhtien.Text = lb_dongia.Text;
                                lb_thanhtoan.Text = lb_thanhtien.Text;
                                break;
                            case "1 Năm":
                                dtp_ngaydangki.Value = now;
                                dtp_ngayketthuc.Value = dtp_ngaydangki.Value.AddYears(1);
                                numeric_giamgia.Value = 0;
                                lb_dongia.Text = (cb_gt.SelectedItem as GoiTap).Price.ToString();
                                lb_thanhtien.Text = lb_dongia.Text;
                                lb_thanhtoan.Text = lb_thanhtien.Text;
                                break;
                            case "2 Năm":
                                dtp_ngaydangki.Value = now;
                                dtp_ngayketthuc.Value = dtp_ngaydangki.Value.AddYears(2);
                                numeric_giamgia.Value = 0;
                                lb_dongia.Text = (cb_gt.SelectedItem as GoiTap).Price.ToString();
                                lb_thanhtien.Text = lb_dongia.Text;
                                lb_thanhtoan.Text = lb_thanhtien.Text;
                                break;
                        }
                    }
                }
                else
                {
                    if ((cb_gt.SelectedItem as GoiTap) != null)
                    {
                        DangKiGoiTap dkgt = DangKiGoiTapBLL.Instance.GetDKGTByIDKH(kh.IDUsers);
                        DateTime ngayketthuc = dkgt.NgayKetThucGT.Value;
                        TimeSpan timeleft = default;
                        if (ngayketthuc > now)
                            timeleft = ngayketthuc.Subtract(now);
                        switch ((cb_gt.SelectedItem as GoiTap).NameGT)
                        {
                            case "1 Tháng":
                                dtp_ngaydangki.Value = now;
                                if (timeleft != default)
                                    dtp_ngayketthuc.Value = dtp_ngaydangki.Value.AddMonths(1).Add(timeleft);
                                else dtp_ngayketthuc.Value = dtp_ngaydangki.Value.AddMonths(1);
                                numeric_giamgia.Value = 0;
                                lb_dongia.Text = (cb_gt.SelectedItem as GoiTap).Price.ToString();
                                lb_thanhtien.Text = lb_dongia.Text;
                                lb_thanhtoan.Text = lb_thanhtien.Text;
                                break;
                            case "6 Tháng":
                                dtp_ngaydangki.Value = now;
                                if (timeleft != default)
                                    dtp_ngayketthuc.Value = dtp_ngaydangki.Value.AddMonths(6).Add(timeleft);
                                else dtp_ngayketthuc.Value = dtp_ngaydangki.Value.AddMonths(6);
                                numeric_giamgia.Value = 0;
                                lb_dongia.Text = (cb_gt.SelectedItem as GoiTap).Price.ToString();
                                lb_thanhtien.Text = lb_dongia.Text;
                                lb_thanhtoan.Text = lb_thanhtien.Text;
                                break;
                            case "1 Năm":
                                dtp_ngaydangki.Value = now;
                                if (timeleft != default)
                                    dtp_ngayketthuc.Value = dtp_ngaydangki.Value.AddYears(1).Add(timeleft);
                                else dtp_ngayketthuc.Value = dtp_ngaydangki.Value.AddYears(1);
                                numeric_giamgia.Value = 0;
                                lb_dongia.Text = (cb_gt.SelectedItem as GoiTap).Price.ToString();
                                lb_thanhtien.Text = lb_dongia.Text;
                                lb_thanhtoan.Text = lb_thanhtien.Text;
                                break;
                            case "2 Năm":
                                dtp_ngaydangki.Value = now;
                                if (timeleft != default)
                                    dtp_ngayketthuc.Value = dtp_ngaydangki.Value.AddYears(2).Add(timeleft);
                                else dtp_ngayketthuc.Value = dtp_ngaydangki.Value.AddYears(2);
                                numeric_giamgia.Value = 0;
                                lb_dongia.Text = (cb_gt.SelectedItem as GoiTap).Price.ToString();
                                lb_thanhtien.Text = lb_dongia.Text;
                                lb_thanhtoan.Text = lb_thanhtien.Text;
                                break;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }
        private void cb_giamgia_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_giamgia.Checked)
                numeric_giamgia.Enabled = true;
            else
            {
                numeric_giamgia.Value = 0;
                numeric_giamgia.Enabled = false;
                lb_thanhtien.Text = lb_dongia.Text;
                lb_thanhtoan.Text = lb_thanhtien.Text;
            }
                
        }

        private void numeric_giamgia_ValueChanged(object sender, EventArgs e)
        {
            int giamgia = Convert.ToInt32(numeric_giamgia.Value);
            double dongia = Convert.ToDouble(lb_dongia.Text);
            double thanhtien = dongia - dongia * giamgia / 100;
            lb_thanhtien.Text = thanhtien.ToString();
            lb_thanhtoan.Text = lb_thanhtien.Text;
        }

       
    }
}
