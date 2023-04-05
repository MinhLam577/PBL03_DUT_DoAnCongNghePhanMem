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
using QLPhongGym.BLL;
using QLPhongGym.DTO;
namespace QLPhongGym.GUI
{
    public partial class DangKiTKForm : Form
    {
        public event EventHandler Back;
        public DangKiTKForm()
        {
            InitializeComponent();
        }
        public void OpenForm(string tentk, string mk, int maquyen)
        {
            bool trangthai = true;
            TK tK = new TK
            {
                TenTK = tentk,
                MatkhauTK = mk,
                IDQuyen = maquyen,
                TrangThai = trangthai
            };
            switch (maquyen)
            {
                case 1:                   
                    DangKiAdminOrKHForm usf = new DangKiAdminOrKHForm(tK, maquyen);
                    usf.Back += Usf_Back;
                    this.Hide();
                    usf.Show();
                    break;
            }
        }

        private void Usf_Back(object sender, EventArgs e)
        {
            (sender as DangKiAdminOrKHForm).Close();
            this.Show();
        }

        private void btn_ctn_Click_1(object sender, EventArgs e)
        {
            string tentk = txb_tentk.Text.Trim();
            string mk = txb_mk.Text.Trim();
            string xnmk = txb_xnmk.Text.Trim();
            string ltk = cb_ltk.Text.Trim();
            int maquyen = -1;
            if (ltk == "Admin") maquyen = 1;
            if (ltk == "" || tentk == "" || mk == "" || xnmk == "") { MessageBox.Show("Mời nhập vào thông tin còn trông"); return; }
            if (TKBLL.Instance.checkTkMk(tentk) == false || TKBLL.Instance.checkTkMk(tentk) == false) { MessageBox.Show("Tài khoản và mật khẩu chỉ chứa kí tự số hoặc chữ hoa thường và bao gồm 6 đến 20 kí tự"); return; }
            if (TKBLL.Instance.checkxnmk(mk, xnmk) == false) { MessageBox.Show("Xác nhận mật khẩu không đồng dạng"); return; }
            OpenForm(tentk, Eramake.eCryptography.Encrypt(mk), maquyen);
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            Back(this, new EventArgs());
        }

        
    }
}
