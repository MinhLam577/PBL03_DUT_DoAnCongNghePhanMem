using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongGym.DTO;
using QLPhongGym.BLL;
using System.Data.Entity.Infrastructure;

namespace QLPhongGym.GUI
{

    public partial class DangKiAdminOrKHForm : Form
    {
        public TK tk {get; set;}
        public int IDQuyen { get; set; }
        public event EventHandler DangKiThanhCong;
        public event EventHandler Back;
        public DangKiAdminOrKHForm()
        {
            InitializeComponent();
        }
        public DangKiAdminOrKHForm(TK tk, int IDQuyen)
        {
            this.tk = tk;
            this.IDQuyen = IDQuyen;
            InitializeComponent();
        }
        private void btn_dangki_Click(object sender, EventArgs e)
        {
            string hoten = txb_hvt.Text.Trim();
            string gioitinh = cb_sex.Text.ToString(); 
            bool gen = false, check = true; 
            string tuoi = txb_age.Text.Trim();
            string cmnd = txb_cmnd.Text.Trim();
            string diachi = txb_address.Text.Trim();
            if (gioitinh == "" || hoten == "" || tuoi == "" || cmnd == "" || diachi == "") { MessageBox.Show("Xin nhập vào thông tin còn trống"); return; }
            if (UsersBLL.Instance.CheckAge(tuoi) == false) { MessageBox.Show("Tuổi không đúng"); return; }
            if (UsersBLL.Instance.CheckCmnd(cmnd) == false) { MessageBox.Show("Chứng minh nhân dân không đúng"); return; }
            if (UsersBLL.Instance.CheckHoTen(hoten) == false) { MessageBox.Show("Họ tên không đúng"); return; }
            if (UsersBLL.Instance.CheckDiaChi(diachi) == false) { MessageBox.Show("Địa chỉ không đúng"); return; }
            if (gioitinh == "Nam") gen = true;
            Admin ad = new Admin
            {
                Name = hoten,
                Sex = gen,
                Address = diachi,
                Age = Convert.ToInt32(tuoi),
                CCCD = cmnd
            };
            KH kh = new KH
            {
                Name = hoten,
                Sex = gen,
                Address = diachi,
                Age = Convert.ToInt32(tuoi),
                CCCD = cmnd
            };
            if (this.IDQuyen == 1)
            {
                if (UsersBLL.Instance.AddUser(ad))
                {
                    tk.IDUser = UsersBLL.Instance.GetUserID(cmnd);
                    if (TKBLL.Instance.AddTK(this.tk))
                    {
                        switch (MessageBox.Show("Đăng kí thành công. Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.OKCancel))
                        {
                            case DialogResult.OK:
                                DangKiThanhCong(this, new EventArgs());
                                break;
                            case DialogResult.Cancel:
                                break;
                        }
                    }
                    else
                    {
                        UsersBLL.Instance.DeleteUser(kh);
                        check = false;
                    }
                }
                else check = false;
            }
            else
            {
                if (UsersBLL.Instance.AddUser(kh))
                {
                    tk.IDUser = UsersBLL.Instance.GetUserID(cmnd);
                    if (TKBLL.Instance.AddTK(this.tk))
                    {
                        switch(MessageBox.Show("Đăng kí thành công. Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.OKCancel))
                        {
                            case DialogResult.OK:
                                DangKiThanhCong(this, new EventArgs());
                                break;
                            case DialogResult.Cancel:
                                break;
                        }
                    }
                    else
                    {
                        UsersBLL.Instance.DeleteUser(kh);
                        check = false;
                    }
                }
                else check = false;
            }
            if (check == false) MessageBox.Show("Đăng kí không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_back_Click(object sender, EventArgs e){
            Back(this, new EventArgs() );
        }
        
    }
}
