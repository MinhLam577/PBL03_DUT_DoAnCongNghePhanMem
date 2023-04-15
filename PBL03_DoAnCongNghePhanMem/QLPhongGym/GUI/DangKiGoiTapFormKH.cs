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
    public partial class DangKiGoiTapFormKH : Form
    {
        public KH kh { get; set; }
        public event EventHandler DangKiThanhCong;
        public DangKiGoiTapFormKH()
        {
            InitializeComponent();
        }
        public DangKiGoiTapFormKH(KH kh)
        {
            InitializeComponent();
            this.kh = kh;
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
                            if(MessageBox.Show("Đăng kí gói tập thành công") == DialogResult.OK)
                            {
                                if(cb_inhoadon.Checked)
                                {
                                    string giamgia = (Convert.ToInt32(lb_dongia.Text) * numeric_giamgia.Value / 100).ToString();
                                    HoaDonForm f = new HoaDonForm(kh.Name, gt, giamgia, dkgt, null);
                                    DangKiThanhCong(this, new EventArgs());
                                    f.Show();
                                }
                                else
                                    DangKiThanhCong(this, new EventArgs());
                            }        
                        }
                    }
                    catch {
                        MessageBox.Show("Đăng kí gói tập không thành công");
                        KHBLL.Instance.DeleteUser(kh);                  
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
        }
        private void cb_gt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now;
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
