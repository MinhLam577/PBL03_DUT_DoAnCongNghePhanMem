using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        public void OpenUserForm(string user)
        {
            switch (user)
            {
                case "Customer":
                case "Hlv":
                case "Admin":
                    QuanLyForm qlf = new QuanLyForm();
                    qlf.ShowDialog();
                    break;
            }
        }
        public void CheckAccountLogin(string tk, string mk)
        {
            if(tk.Length == 0 || mk.Length == 0){
                MessageBox.Show("Vui lòng nhập tài khoản hoặc mật khẩu");
                return;
            }
            string user = AccountBUS.Instance.CheckAccountLogin(tk, mk);
            if (user == ""){
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txb_TenTk.SelectAll();
                txb_TenTk.Focus();
                return;
            }
            else
            {
                DialogResult dlres = MessageBox.Show("Đăng nhập thành công", "Login Success", MessageBoxButtons.OK);
                if (dlres.Equals(DialogResult.OK))
                    OpenUserForm(user);
            }
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string taikoan = txb_TenTk.Text.Trim();
            string mk = txb_mk.Text.Trim();
            CheckAccountLogin(taikoan, mk);
        }
        private void lb_Dangki_Click(object sender, EventArgs e)
        {
            
            DangKiForm dkf = new DangKiForm();
            this.Hide();
            dkf.ShowDialog();
            
        }
       
        private void lb_QuenMk_Click(object sender, EventArgs e)
        {
            QuenMatKhauForm qmkf = new QuenMatKhauForm();
            qmkf.ShowDialog();
        }
    }
}
