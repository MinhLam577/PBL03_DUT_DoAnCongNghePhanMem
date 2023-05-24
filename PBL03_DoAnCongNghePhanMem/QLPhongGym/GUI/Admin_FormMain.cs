using QLPhongGym.BLL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.GUI
{
    public partial class Admin_FormMain : Form
    {
        public TK tk { get; set; }
        static string ImageDefaultPath = Application.StartupPath + @"\Resources\account_icon.png";
        public Admin_FormMain()
        {
            InitializeComponent();
            customizedesing();
        }
        public Admin_FormMain(TK tk)
        {
            InitializeComponent();
            this.tk = tk;
            LoadDuLieuTK();
            customizedesing();
        }
        public void LoadDuLieuTK()
        {
            int IDUser = (int)tk.IDUser;
            Admin ad = (Admin)UsersBLL.Instance.GetUserByID(IDUser);
            lb_gmailad.Text = ad.Gmail;
            lb_tenad.Text = ad.Name;
            if (ad.Image != null)
            {
                pb_acc.Image = Image.FromFile(Application.StartupPath + @"\PersonImage\" + ad.Image);
                pb_ad.Image = Image.FromFile(Application.StartupPath + @"\PersonImage\" + ad.Image);
            }
            else
            {
                pb_acc.Image = Image.FromFile(ImageDefaultPath);
                pb_ad.Image = Image.FromFile(ImageDefaultPath);
            }
        }
        private Form currentFormChild = null;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
                currentFormChild.Close();        
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void customizedesing()
        {
            panel_hlv.Visible = false;
            pn_tkadmin.Visible = false;
        }
        private void hideMenu()
        {
            if (panel_hlv.Visible == true)
            {
                panel_hlv.Visible = false;
            }
            if(pn_tkadmin.Visible == true)
            {
                pn_tkadmin.Visible = false;
            }
        }
        private void showMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormDanhSachKH());
            hideMenu();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            showMenu(panel_hlv);
        }

        private void button_ThietBi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormDanhSachThietBi());
            hideMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormDanhSachGoiTap());
            hideMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormDanhSachHLV());
            hideMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormDanhSachKH());
            hideMenu();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
                currentFormChild.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                hideMenu();
            }
                
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormThongKe());
            hideMenu();
        }


        private void BtnTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_DangKiTaiKhoanHLV());
            hideMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                hideMenu();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            showMenu(pn_tkadmin);
        }

        private void pb_updateimage_Click(object sender, EventArgs e)
        {
            UpdateImageAccountForm updateImageAccountForm = new UpdateImageAccountForm((Admin)UsersBLL.Instance.GetUserByID((int)tk.IDUser));
            updateImageAccountForm.catnhatthanhcong += new UpdateImageAccountForm.Mydel(LoadDuLieuTK);
            updateImageAccountForm.ShowDialog();
            hideMenu();
        }

        private void btn_updatethongtin_Click(object sender, EventArgs e)
        {
            AddOrEditFormKH addOrEditFormKH = new AddOrEditFormKH(tk.IDUser.ToString(), "Admin");
            addOrEditFormKH.ThayDoiThanhCong += (s, ev) => { 
                (s as AddOrEditFormKH).Close();
                LoadDuLieuTK();
            };
            addOrEditFormKH.ShowDialog();
            hideMenu();
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            DoiMatKhauForm dmk = new DoiMatKhauForm(tk);
            dmk.DoiMatKhauChanged += (s, ev) =>
            {
                (s as DoiMatKhauForm).Close();
            };
            dmk.ShowDialog();
        }

    }
}
