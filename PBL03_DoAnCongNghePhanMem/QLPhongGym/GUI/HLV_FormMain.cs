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
using QLPhongGym.BLL;
namespace QLPhongGym.GUI
{
    public partial class HLV_FormMain : Form
    {
        public TK tk { get; set; }
        static string ImageDefaultPath = Application.StartupPath + @"\Resources\account_icon.png";
        static bool IsGanHLV = false;
        static HLV Hlv = null;
        public HLV_FormMain()
        {
            InitializeComponent();
            customizedesing();
        }
        public HLV_FormMain(TK tk)
        {
            InitializeComponent();
            this.tk = tk;
            LoadDuLieuTK();
            customizedesing();
        }
        public void LoadDuLieuTK()
        {
            int IDUser = (int)tk.IDUser;
            HLV hlv = null;
            if (!IsGanHLV)
            {
                hlv = (HLV)UsersBLL.Instance.GetUserByID(IDUser);
                Hlv = hlv;
                IsGanHLV = true;
            }
            if (Hlv != null)
            {
                lb_gmailhlv.Text = Hlv.Gmail;
                lb_tenhlv.Text = Hlv.Name;
            }
            if (Hlv.Image != null)
            {
                pb_acc.Image = Image.FromFile(Application.StartupPath + @"\PersonImage\" + Hlv.Image);
                pb_hlv.Image = Image.FromFile(Application.StartupPath + @"\PersonImage\" + Hlv.Image);
            }
            else
            {
                pb_acc.Image = Image.FromFile(ImageDefaultPath);
                pb_hlv.Image = Image.FromFile(ImageDefaultPath);
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
            pn_cha.Controls.Add(childForm);
            pn_cha.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void customizedesing()
        {
            pn_tkhlv.Visible = false;
        }
        private void hideMenu()
        {
            if (pn_tkhlv.Visible)
            {
                pn_tkhlv.Visible = false;
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void pb_home_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                hideMenu();
            }
        }

        private void lb_home_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                hideMenu();
            }
        }

        private void pb_acc_Click(object sender, EventArgs e)
        {
            showMenu(pn_tkhlv);
        }

        private void lb_acc_Click(object sender, EventArgs e)
        {
            showMenu(pn_tkhlv);
        }
        private void Edit(object hlv)
        {
            HLV a = (HLV)hlv;
            if (QLHLVBLL.getInstance.Update(a) == true)
            {
                Hlv = a;
                LoadDuLieuTK();
                MessageBox.Show("Sua Thanh cong");
            }
            else
            {
                MessageBox.Show("Sua huấn luyện viên thất bại");
            }
        }
        private void btn_updatethongtin_Click(object sender, EventArgs e)
        {
            AddEdit_HLV a = new AddEdit_HLV();
            int ID = (int)tk.IDUser;
            //Hlv = (HLV)UsersBLL.Instance.GetUserByID(ID);
            a.buon += new AddEdit_HLV.mydelegate(Edit);
            a.luachon(2);
            a.getinfofromAB(Hlv);
            a.Show();
        }
        private void pb_updateimage_Click(object sender, EventArgs e)
        {
            UpdateImageAccountForm updateImageAccountForm = new UpdateImageAccountForm((HLV)UsersBLL.Instance.GetUserByID((int)tk.IDUser));
            updateImageAccountForm.catnhatthanhcong += new UpdateImageAccountForm.Mydel(LoadDuLieuTK);
            updateImageAccountForm.LuuThanhCong += (s, ev) =>
            {
                (s as UpdateImageAccountForm).Close();
            };
            updateImageAccountForm.ShowDialog();
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

        private void HLV_FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btn_lichlamviec_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormLichHLV());
            hideMenu();
        }
        private void btn_thoat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xin chờ một lát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }

        private void btn_kh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HLV_FormDanhSachKH((HLV)UsersBLL.Instance.GetUserByID(tk.IDUser.Value)));
            hideMenu();
        }
    }
}
