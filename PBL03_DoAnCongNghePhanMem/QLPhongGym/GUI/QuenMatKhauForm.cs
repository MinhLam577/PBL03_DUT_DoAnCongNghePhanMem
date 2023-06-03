using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongGym.BLL;
using QLPhongGym.DTO;
namespace QLPhongGym.GUI
{
    public partial class QuenMatKhauForm : Form
    {
        public event EventHandler LayLaiMatKhauThanhCong;
        SmtpClient smtpClient = null;
        MailAddress from = new MailAddress("minh32405@gmail.com", "Nhóm PBL03_DUT phần mềm quản lý phòng gym");
        MailAddress to = null;
        MailMessage mail = null;
        public QuenMatKhauForm()
        {
            InitializeComponent();
        }
        public void GuiMail(MailMessage mail)
        {
            smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("minh32405@gmail.com", "hxehdwxujpyzpsfw");
            smtpClient.Send(mail);
        }
        private void btn_laylaimk_Click(object sender, EventArgs e)
        {
            string gmail = txb_Email.Text;
            if(txb_Email.Text == "") { MessageBox.Show("Mời nhập vào thông tin còn trống"); return; }
            else
            {
                if (UsersBLL.Instance.CheckGmailExist(txb_Email.Text))
                {
                    try
                    {
                        KH kh = (KH)UsersBLL.Instance.GetUserByGmail(gmail);
                        MessageBox.Show("Bạn là khách hàng và không có tài khoản trong hệ thống");
                        return;
                    }
                    catch
                    {

                    }
                    to = new MailAddress(txb_Email.Text);
                    mail = new MailMessage(from, to);
                    mail.Subject = "Lấy lại mật khẩu tài khoản phần mềm quản lý phòng gym";
                    string password = UsersBLL.Instance.GetPassword(txb_Email.Text);
                    if (string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Bạn chưa có tài khoản trong hệ thống");
                        return;
                    }
                    mail.Body = "Mật khẩu tài khoản của bạn: " + UsersBLL.Instance.GetPassword(txb_Email.Text);
                    mail.IsBodyHtml = true;
                    try
                    {
                        GuiMail(mail);
                        if(MessageBox.Show("Lấy lại mật khẩu thành công", "Vui lòng kiểm tra lại gmail để lấy mật khẩu", MessageBoxButtons.OK) == DialogResult.OK)
                        {
                            LayLaiMatKhauThanhCong(this, new EventArgs());
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lấy lại mật khẩu thất bại. Vui lòng kiểm tra lại thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else MessageBox.Show("Gmail không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
