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
            OpenChildForm(new FormTrangChu());
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
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTrangChu());
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormDanhSachKH());
        }

        private void danhSáchHuấnLuyệnViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormDanhSachHLV());
        }

        private void tàiKhoảnHuấnLuyệnViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void góiTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormDanhSachGoiTap());
        }

        private void danhSáchThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormDanhSachThietBi());
        }

        private void góiTậpKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormDKiGoiTapKH());
        }

        private void tậpCùngHuấnLuyệnViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_FormDKiTapCungHLV());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
