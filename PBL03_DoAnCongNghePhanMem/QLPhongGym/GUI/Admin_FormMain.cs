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
        static string TitleMenuColorPath = Application.StartupPath + @"\Resources\Background_Color_TrangChu_Admin.png";
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
            if(ad != null)
            {
                lb_gmailad.Text = ad.Gmail;
                lb_tenad.Text = ad.Name;
            }
            
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
            pn_TitleMenu.BackColor = childForm.BackColor;
            pn_TitleMenu.BackgroundImage = null;
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button13_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_ThongKeForm());
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
            updateImageAccountForm.LuuThanhCong += (s, ev) =>
            {
                (s as UpdateImageAccountForm).Close();
            };
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
                hideMenu();
            };
            dmk.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                hideMenu();
            }
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            showMenu(pn_tkadmin);
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                pn_TitleMenu.BackgroundImage = Image.FromFile(TitleMenuColorPath);
                currentFormChild.Close();
                hideMenu();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                pn_TitleMenu.BackgroundImage = Image.FromFile(TitleMenuColorPath);
                currentFormChild.Close();
                hideMenu();
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDangKiLichHLV1());
            hideMenu();
        }
        private void pb_ad_Click(object sender, EventArgs e)
        {
            showMenu(pn_tkadmin);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            showMenu(pn_tkadmin);
        }

        const int WM_PARENTNOTIFY = 0x210;
        const int WM_LBUTTONDOWN = 0x201;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN || (m.Msg == WM_PARENTNOTIFY &&
                (int)m.WParam == WM_LBUTTONDOWN))
            {
                if (!panel_hlv.ClientRectangle.Contains(
                                 panel_hlv.PointToClient(Cursor.Position)))
                    panel_hlv.Hide();
                if (!pn_tkadmin.ClientRectangle.Contains(
                                 pn_tkadmin.PointToClient(Cursor.Position)))
                    pn_tkadmin.Hide();
            }
                
                
            base.WndProc(ref m);
        }
    }
}
