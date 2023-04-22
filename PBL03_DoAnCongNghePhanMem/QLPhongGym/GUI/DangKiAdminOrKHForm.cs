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
            bool gen = false;
            string gmail = txb_gm.Text.Trim();
            string cccd = txb_cmnd.Text.Trim();
            string sdt = txb_sdt.Text.Trim();
            string diachi = txb_address.Text.Trim();
            if (gioitinh == "" || hoten == "" || cccd == "" || diachi == "" || sdt == "") { MessageBox.Show("Xin nhập vào thông tin còn trống"); return; }
            if(!UsersBLL.Instance.CheckGmail(gmail)) { MessageBox.Show("Gmail không đúng định dạng"); return; }
            else
            {
                if (UsersBLL.Instance.CheckGmailExist(gmail))
                {
                    MessageBox.Show("Gmail đã tồn tại");
                    return;
                }
            }
            if (!UsersBLL.Instance.CheckCccd(cccd)) { MessageBox.Show("Căn cước công dân không đúng định dạng"); return; }
            else
            {
                if (UsersBLL.Instance.checkCCCDexist(cccd)){
                    MessageBox.Show("Căn cước công dân đã tồn tại");
                    return;
                }
            }
            
            if (!UsersBLL.Instance.CheckSDT(sdt))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng");
                return;
            }
            else
            {
                if (UsersBLL.Instance.CheckSDTExist(sdt))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại");
                    return;
                }
            }
            if (UsersBLL.Instance.CheckHoTen(hoten) == false) { MessageBox.Show("Họ tên không đúng định dạng"); return; }
            if (UsersBLL.Instance.CheckDiaChi(diachi) == false) { MessageBox.Show("Địa chỉ không đúng định dạng"); return; }
            if (gioitinh == "Nam") gen = true;
            Admin ad = new Admin
            {
                Name = hoten, Sex = gen, Address = diachi, DateBorn = dtp_ns.Value,
                CCCD = cccd, Gmail = gmail, Sdt = sdt
            };
            KH kh = new KH
            {
                Name = hoten,
                Sex = gen,
                Address = diachi,
                DateBorn = dtp_ns.Value,
                CCCD = cccd,
                Gmail = gmail,
                Sdt = sdt
            };
            try
            {
                if (this.IDQuyen == 1)
                {
                    if (UsersBLL.Instance.AddUser(ad))
                    {
                        try
                        {
                            tk.IDUser = UsersBLL.Instance.GetUserIDByCCCD(cccd);
                            if (TKBLL.Instance.AddTK(this.tk))
                            {
                                switch (MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK))
                                {
                                    case DialogResult.OK:
                                        this.Close();
                                        break;
                                }
                            }
                        }
                        catch(Exception ex)
                        {
                            UsersBLL.Instance.DeleteUser(ad);
                            MessageBox.Show(ex.Message);
                        }
                        
                    }
                }
                else
                {
                    if (UsersBLL.Instance.AddUser(kh))
                    {
                        try
                        {
                            tk.IDUser = UsersBLL.Instance.GetUserIDByCCCD(cccd);
                            if (TKBLL.Instance.AddTK(this.tk))
                            {
                                switch (MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK))
                                {
                                    case DialogResult.OK:
                                        this.Close();
                                        break;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            UsersBLL.Instance.DeleteUser(kh);
                            MessageBox.Show(ex.Message);
                        }
                        
                    }
                }
            }
            catch
            {
                MessageBox.Show("Đăng kí không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_back_Click(object sender, EventArgs e){
            Back(this, new EventArgs() );
        }

        
    }
}
