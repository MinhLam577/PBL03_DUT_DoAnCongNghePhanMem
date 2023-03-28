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
using DAL;
using QLPhongGym.BLL;
using QLPhongGym.DTO;
namespace QLPhongGym.GUI
{
    public partial class DangKiForm : Form
    {
        public event EventHandler Back;
        public DangKiForm()
        {
            InitializeComponent();
        }
        
        public void OpenForm(string tentk, string mk, string email, string sdt, int maquyen)
        {
            TK tK = new TK
            {
                TenTK = tentk,
                MatkhauTK = mk,
                EmailTK = email,
                IDQuyen = maquyen,
                Sdt = sdt
            };
            switch (maquyen)
            {
                case 1:
                case 3:
                    
                    DangKiAdminOrKHForm usf = new DangKiAdminOrKHForm(tK, maquyen);
                    usf.DangKiThanhCong += Usf_DangKiThanhCong;
                    usf.Back += Usf_Back;
                    this.Hide();
                    usf.Show();
                    break;
                case 2:
                    DangKiHLVForm hlvf = new DangKiHLVForm(tK);
                    hlvf.DangKiThanhCong += Hlvf_DangKiThanhCong;
                    hlvf.Back += Hlvf_Back;
                    this.Hide();
                    hlvf.Show();
                    break;
            }
        }

        private void Hlvf_Back(object sender, EventArgs e)
        {
            (sender as DangKiHLVForm).Close();
            this.Show();
        }

        private void Usf_Back(object sender, EventArgs e)
        {
            (sender as DangKiAdminOrKHForm).Close();
            this.Show();
        }
        private void Hlvf_DangKiThanhCong(object sender, EventArgs e)
        {
            (sender as DangKiHLVForm).Close();
            Back(this, new EventArgs());
        }

        private void Usf_DangKiThanhCong(object sender, EventArgs e)
        {
            (sender as DangKiAdminOrKHForm).Close();
            Back(this, new EventArgs());
        }

        private void btn_ctn_Click(object sender, EventArgs e)
        {
            string tentk = txb_tentk.Text.Trim();
            string mk = txb_mk.Text.Trim();
            string xnmk = txb_xnmk.Text.Trim();
            string email = txb_gm.Text.Trim();
            string sdt = txb_sdt.Text.Trim();
            string ltk = cb_ltk.Text.Trim();
            int maquyen = -1;
            if (ltk == "Admin") maquyen = 1;
            else if (ltk == "Huấn Luyện Viên") maquyen = 2;
            else maquyen = 3;
            if (ltk == "" || tentk == "" || mk == "" || xnmk == "" || email == "" || sdt == "") { MessageBox.Show("Mời nhập vào thông tin còn trông"); return; }
            if (TKDAL.Instance.checkTkMk(tentk) == false || TKDAL.Instance.checkTkMk(tentk) == false) { MessageBox.Show("Tài khoản và mật khẩu chỉ chứa kí tự số hoặc chữ hoa thường và bao gồm 6 đến 20 kí tự"); return; }
            if (TKDAL.Instance.checkxnmk(mk, xnmk) == false) { MessageBox.Show("Xác nhận mật khẩu không đồng dạng"); return; }
            if (TKDAL.Instance.checkEmail(email) == false) { MessageBox.Show("Email không đúng"); return; }
            if (TKDAL.Instance.checksdt(sdt) == false) { MessageBox.Show("Số điện thoại không đúng"); return; }
            else
            {
                if (TKBLL.Instance.CheckSdtExist(sdt)) { MessageBox.Show("Số điện thoại đã tồn tại"); return; }
            }
            if (TKBLL.Instance.CheckTenTKExist(tentk)) { MessageBox.Show("Tên tài khoản đã tồn tại"); return; }
            else { if (TKBLL.Instance.CheckEmailExist(email)) { MessageBox.Show("Email đã tồn tại"); return; } }
            OpenForm(tentk, mk, email, sdt, maquyen);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Back(this, new EventArgs());
        }

       
    }
}
