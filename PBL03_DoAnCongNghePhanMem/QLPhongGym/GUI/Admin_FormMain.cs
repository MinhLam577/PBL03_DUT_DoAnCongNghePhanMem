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

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
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
            Menu_Panel.Visible = false;
            panel_hlv.Visible = false;
            panel_tk.Visible = false;
        }
        private void hideMenu()
        {
            if (Menu_Panel.Visible == true)
            {
                Menu_Panel.Visible = false;
            }
            if (panel_hlv.Visible == true)
            {
                panel_hlv.Visible = false;
            }
            if (panel_tk.Visible == true)
            {
                panel_tk.Visible = false;
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
            showMenu(Menu_Panel);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            showMenu(panel_hlv);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            showMenu(panel_tk);
        }

        private void button_ThietBi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormDanhSachThietBi());
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
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormDanhSachHLV());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormDanhSachKH());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormDKiGoiTapKH());
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
