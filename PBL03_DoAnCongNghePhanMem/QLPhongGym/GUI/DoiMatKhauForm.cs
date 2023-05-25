using QLPhongGym.BLL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.GUI
{
    public partial class DoiMatKhauForm : Form
    {
        public TK tk { get; set; }
        public event EventHandler DoiMatKhauChanged;
        public DoiMatKhauForm()
        {
            InitializeComponent();
        }

        public DoiMatKhauForm(TK tk)
        {
            this.tk = tk;
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Mkcu = txb_mkcu.Text, mkmoi = txb_mkmoi.Text, xnmk = txb_xnmkmoi.Text;
            string tentk = tk.TenTK;
            try
            {
                if (Mkcu == "" || mkmoi == "" || xnmk == "")
                {
                    MessageBox.Show("Mời nhập vào dữ liệu còn trống");
                    return;
                }
                if (!TKBLL.Instance.CheckMKTKExist(tentk, Mkcu))
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác");
                    return;
                }
                else
                {
                    if (!TKBLL.Instance.checkTkMk(mkmoi))
                    {
                        MessageBox.Show("Tài khoản và mật khẩu chỉ chứa kí tự số hoặc chữ hoa thường và bao gồm 6 đến 20 kí tự");
                        return;
                    }
                    if (mkmoi.Equals(Mkcu))
                    {
                        MessageBox.Show("Mật khẩu phải khác với mật khẩu cũ");
                        return;
                    }
                    else
                    {
                        if (!xnmk.Equals(mkmoi))
                        {
                            MessageBox.Show("Xác nhận mật khẩu không đồng dạng");
                            return;
                        }
                        else
                        {
                            this.tk.MatkhauTK = Eramake.eCryptography.Encrypt(mkmoi);
                            if (TKBLL.Instance.UpdateTK(tk))
                            {
                                if(MessageBox.Show("Đổi mật khẩu thành công") == DialogResult.OK)
                                {
                                    DoiMatKhauChanged(this, new EventArgs());
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đổi mật khẩu thất bại");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DoiMatKhauChanged(this, new EventArgs());
        }
    }
}
