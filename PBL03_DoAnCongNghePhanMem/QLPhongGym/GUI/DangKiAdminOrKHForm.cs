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

namespace QLPhongGym.GUI
{

    public partial class DangKiAdminOrKHForm : Form
    {
        public TK tk {get; set;}
        
        public DangKiAdminOrKHForm()
        {
            InitializeComponent();
        }
        public DangKiAdminOrKHForm(TK tk)
        {
            this.tk = tk;
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
            if (UsersBLL.Instance.AddUser(ad)){
                tk.IDUser = UsersBLL.Instance.GetUserID(cmnd);
                if (TKBLL.Instance.AddTK(this.tk))
                    MessageBox.Show("Đăng kí thành công");
                else
                {
                    UsersBLL.Instance.DeleteUser(ad);
                    check = false;
                }
            }
            else check = false;
            if (check == false) MessageBox.Show("Đăng kí không thành công");
        }
        private void btn_back_Click(object sender, EventArgs e){
            this.Close();
        }
        private void DangKiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
