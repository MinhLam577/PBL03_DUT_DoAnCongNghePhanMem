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
        public Admin_FormMain()
        {
            InitializeComponent();
            customizedesing();
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
        }
        private void hideMenu()
        {
            if (panel_hlv.Visible == true)
            {
                panel_hlv.Visible = false;
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
    }
}
