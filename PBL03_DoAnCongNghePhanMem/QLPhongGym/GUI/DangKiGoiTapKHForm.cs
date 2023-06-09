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
using System.Linq.Expressions;
using System.Data.Entity.Core;
using System.Data.SqlClient;

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
            if(ngayketthuc.Date <= ngaydangki.Date)
                return false;
            return true;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string gt = cb_gt.Text;
                int IDGT;
                string description = "";
                DateTime NgayDangKi = dtp_ngaydangki.Value;
                DateTime NgayKetThuc = dtp_ngayketthuc.Value;
                if (string.IsNullOrEmpty(gt))
                {
                    MessageBox.Show("Mời nhập vào thông tin còn trống");
                    return;
                }
                if (!CheckNgay(NgayDangKi, NgayKetThuc))
                {
                    MessageBox.Show("Ngày đăng kí hoặc ngày kết thúc không đúng");
                    return;
                }
                IDGT = GoiTapBLL.Instance.GetGTByName(gt).IDGT;
                if(!KHBLL.Instance.CheckUserExist(kh.CCCD, kh.Name))
                {
                    if (KHBLL.Instance.AddUser(kh))
                    {
                        if (!string.IsNullOrEmpty(txb_ghichu.Text))
                            description = txb_ghichu.Text;
                        DangKiGoiTap dkgt = new DangKiGoiTap
                        {
                            IDGT = IDGT,
                            IDKH = kh.IDUsers,
                            NgayDangKiGT = NgayDangKi,
                            NgayKetThucGT = NgayKetThuc,
                            Description = description,
                            BaoLuu = false
                        };
                        try
                        {
                            switch (MessageBox.Show("Xác nhận đăng kí?", "Xin chờ một lát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                            {
                                case DialogResult.OK:
                                    
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
                                                HoaDonForm f = new HoaDonForm(kh.Name, gt, giamgia, dkgt);
                                                DangKiThanhCong(this, new EventArgs());
                                                f.Show();
                                            }
                                            else
                                                DangKiThanhCong(this, new EventArgs());
                                        }
                                    }
                                    break;
                                case DialogResult.Cancel:
                                    break;
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
                    DangKiGoiTap dangKiGoiTap = null;
                    if (!string.IsNullOrEmpty(txb_ghichu.Text))
                        description = txb_ghichu.Text;
                    if (this.GoiTap == "")
                    {
                        switch (MessageBox.Show("Xác nhận đăng kí?", "Xin chờ một lát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                        {
                            case DialogResult.OK:
                                if (DangKiGoiTapBLL.Instance.GetDKGT_Newest_ByIDKH_IDGT(kh.IDUsers, IDGT) != null)
                                    if (MessageBox.Show("Bạn dường như đã đăng kí và đang tập gói tập này, bạn chỉ có thể gia hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                                    {
                                        DangKiThanhCong(this, new EventArgs());
                                        return;
                                    }
                                          
                                dangKiGoiTap = new DangKiGoiTap
                                {
                                    IDGT = IDGT,
                                    IDKH = kh.IDUsers,
                                    NgayDangKiGT = NgayDangKi,
                                    NgayKetThucGT = NgayKetThuc,
                                    Description = description,
                                    BaoLuu = false
                                };
                                if (DangKiGoiTapBLL.Instance.AddDKGT(dangKiGoiTap))
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
                                            HoaDonForm f = new HoaDonForm(kh.Name, gt, giamgia, dangKiGoiTap);
                                            DangKiThanhCong(this, new EventArgs());
                                            f.Show();
                                        }
                                        else
                                            DangKiThanhCong(this, new EventArgs());
                                    }
                                }
                                break;
                            case DialogResult.Cancel:
                                break;
                        }
                    }
                    else {
                        dangKiGoiTap = DangKiGoiTapBLL.Instance.GetDKGT_Newest_ByIDKH_IDGT(kh.IDUsers, IDGT);
                        dangKiGoiTap.NgayKetThucGT = dtp_ngayketthuc.Value.Date;
                        switch (MessageBox.Show("Xác nhận gia hạn?", "Xin chờ một lát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                        {
                            case DialogResult.OK:
                                if (DangKiGoiTapBLL.Instance.UpdateDKGT(dangKiGoiTap))
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

                                    if (MessageBox.Show("Gia hạn gói tập thành công") == DialogResult.OK)
                                    {
                                        if (cb_inhoadon.Checked)
                                        {
                                            HoaDonForm f = new HoaDonForm(kh.Name, gt, giamgia, dangKiGoiTap);
                                            DangKiThanhCong(this, new EventArgs());
                                            f.Show();
                                        }
                                        else
                                            DangKiThanhCong(this, new EventArgs());
                                    }
                                }
                                break;
                            case DialogResult.Cancel:
                                break;
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                if(ex.InnerException != null)
                    MessageBox.Show("Có vẻ như bạn đã đăng kí gói tập trong khoảng thời gian đã chọn này rồi. Xin kiểm tra lại");
                else
                    MessageBox.Show(ex.Message, "Đăng kí gói tập không thành công");
            }

        }
        private void DangKiGoiTapFormKH_Load(object sender, EventArgs e)
        {
            rb_tienmat.Checked = true;
            cb_gt.DisplayMember = "NameGT";
            cb_gt.ValueMember = "IDGT";
            cb_gt.DataSource = GoiTapBLL.Instance.GetAllGT();
            dtp_ngaydangki.Enabled = false;
            if (GoiTap != "")
            {
                lb_main.Text = "Gia hạn gói tập khách hàng";
                cb_gt.Text = GoiTap;
                cb_gt.Enabled = false;
            }
            else
            {
                cb_gt.Enabled = true;
                lb_main.Text = "Đăng kí gói tập khách hàng";
            }

                  
        }
        private void cb_gt_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Today;
                if(GoiTap == "")
                {
                    if ((cb_gt.SelectedItem as GoiTap) != null)
                    {
                        int TimeGT = (int)(cb_gt.SelectedItem as GoiTap).ThoiHanTapTheoThang;
                        dtp_ngaydangki.Value = now;
                        dtp_ngayketthuc.Value = dtp_ngaydangki.Value.AddMonths(TimeGT);
                        numeric_giamgia.Value = 0;
                        lb_dongia.Text = (cb_gt.SelectedItem as GoiTap).Price.ToString();
                        lb_thanhtien.Text = lb_dongia.Text;
                        lb_thanhtoan.Text = lb_thanhtien.Text;
                    }
                }
                else
                {
                    if ((cb_gt.SelectedItem as GoiTap) != null)
                    {
                        DangKiGoiTap dkgt = DangKiGoiTapBLL.Instance.GetDKGT_Newest_ByIDKH_IDGT(kh.IDUsers, GoiTapBLL.Instance.GetGTByName(GoiTap).IDGT);
                        DateTime ngayketthuc = dkgt.NgayKetThucGT.Value;
                        TimeSpan timeleft = default;
                        int Timegt = (cb_gt.SelectedItem as GoiTap).ThoiHanTapTheoThang.Value;
                        if (ngayketthuc > now)
                            timeleft = ngayketthuc.Subtract(now);
                        else if(ngayketthuc == now) timeleft = TimeSpan.Zero;
                        dtp_ngaydangki.Value = dkgt.NgayDangKiGT.Value;
                        if (timeleft != TimeSpan.Zero)
                            dtp_ngayketthuc.Value = dtp_ngaydangki.Value.AddMonths(Timegt).Add(timeleft);
                        else dtp_ngayketthuc.Value = dtp_ngaydangki.Value.AddMonths(Timegt);
                        numeric_giamgia.Value = 0;
                        lb_dongia.Text = (cb_gt.SelectedItem as GoiTap).Price.ToString();
                        lb_thanhtien.Text = lb_dongia.Text;
                        lb_thanhtoan.Text = lb_thanhtien.Text;
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
