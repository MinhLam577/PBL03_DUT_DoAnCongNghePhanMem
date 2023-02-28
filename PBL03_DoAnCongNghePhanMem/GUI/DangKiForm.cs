using BUS;
using DTO;
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


namespace GUI
{
    
    public partial class DangKiForm : Form
    {
        AccountBUS accbus = new AccountBUS();
        AdminBUS adbus = new AdminBUS();
        public DangKiForm()
        {
            InitializeComponent();
        }
        public bool checkTkMk(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,20}$");
        }

        public bool checkEmail(string email)
        {
            if (email == "") return true;
            return Regex.IsMatch(email, "^[a-zA-Z][a-zA-Z0-9_.]{5,20}(@gmail.com)$");
        }
        public bool checkxnmk(string mk, string xnmk)
        {
            return mk.Equals(xnmk);
        }
        public bool checkAge(string age)
        {
            int t;try{ t = Convert.ToInt32(Regex.Match(age, "^[0-9]{1,3}$").ToString());}catch{ return false;} return t > 0;
        }
        public bool checksdt(string sdt)
        {
            return Regex.IsMatch(sdt, "^[0-9]{10,11}$");
        }
        public bool checkcmnd(string cmnd)
        {
            return Regex.IsMatch(cmnd, "^[0-9]{12}$");
        }
        public bool checkHoten(string hoten)
        {
            string t = hoten.RemoveUnicode();
            while (t.IndexOf("  ") != -1) t = t.Replace("  ", " ");
            return Regex.IsMatch(t, "^[a-zA-Z ]+$");
        }
        public bool checkdiachi(string diachi)
        {
            string t = diachi.RemoveUnicode();
            while (t.IndexOf("  ") != -1) t = t.Replace("  ", " ");
            return Regex.IsMatch(t, "^[a-zA-Z0-9 ]+$");
        }
        private void btn_dangki_Click(object sender, EventArgs e)
        {
            string tentk = txb_tentk.Text.Trim();
            string mk = txb_mk.Text.Trim();
            string xnmk = txb_xnmk.Text.Trim();
            string hoten = txb_hvt.Text.Trim();
            string gioitinh = cb_sex.Text.ToString(); bool gen; if (gioitinh == "Nam") gen = true; else gen = false;
            string tuoi = txb_age.Text.Trim();
            string email = txb_email.Text.Trim();
            string sdt = txb_sdt.Text.Trim();
            string cmnd = txb_cmnd.Text.Trim();
            string diachi = txb_address.Text.Trim();
            string loaitk = cb_loaitk.Text.ToString(); int ltk = 1;
            if (gioitinh == "" || loaitk == "" || tentk == "" || mk == "" || xnmk == "" || hoten == "" || tuoi == "" || sdt == "" || cmnd == "") { MessageBox.Show("Xin nhập vào thông tin còn trống"); return; }
            if (checkTkMk(tentk) == false || checkTkMk(mk) == false) { MessageBox.Show("Tài khoản và mật khẩu chỉ chứa kí tự số hoặc chữ hoa thường và bao gồm 6 đến 20 kí tự"); return; }
            if (checkxnmk(mk, xnmk) == false) { MessageBox.Show("Xác nhận mật khẩu không đồng dạng"); return; }
            if (checkAge(tuoi) == false) { MessageBox.Show("Tuổi không đúng"); return; }
            if (checkEmail(email) == false) { MessageBox.Show("Email không đúng"); return; }
            if (checksdt(sdt) == false) { MessageBox.Show("Số điện thoại không đúng"); return; }
            if (checkcmnd(cmnd) == false) { MessageBox.Show("Chứng minh nhân dân không đúng"); return; }
            if (checkHoten(hoten) == false) { MessageBox.Show("Họ tên không đúng"); return; }
            if (checkdiachi(diachi) == false) { MessageBox.Show("Địa chỉ không đúng"); return; }
            if (accbus.CheckAccountExist(tentk)) { MessageBox.Show("Tên tài khoản đã tồn tại"); return; }
            else { if (accbus.CheckEmailExist(email)) { MessageBox.Show("Email đã tồn tại"); return; } }
            if (accbus.AddAccount(new Account(email, tentk, mk, ltk))){
                if (adbus.AddAdmin(new Admin(tentk, hoten, Convert.ToInt32(tuoi), gen, sdt, diachi, cmnd))){
                    if (MessageBox.Show("Đăng kí thành công! Bạn có muốn đăng nhập luôn không?", "Xin chúc mừng", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();
                    else Application.Exit();
                }
                else MessageBox.Show("Thêm admin không thành công");
            }
            else MessageBox.Show("Thêm tài khoản không thành công");
        }

        private void btn_back_Click(object sender, EventArgs e){
            this.Close();
        }

        private void DangKiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                LoginForm f = new LoginForm();
                f.Show();
            }
                
            

        }
    }
}
