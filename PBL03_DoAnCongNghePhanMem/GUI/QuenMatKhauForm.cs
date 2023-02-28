using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class QuenMatKhauForm : Form
    {
        AccountBUS accbus = new AccountBUS();
        public QuenMatKhauForm()
        {
            InitializeComponent();
        }
        private void btn_laylaimk_Click(object sender, EventArgs e)
        {
            if(txb_Email.Text == "") { MessageBox.Show("Mời nhập vào thông tin còn trống"); return; }
            txb_res.Text = accbus.GetPassword(txb_Email.Text);
        }
        bool btnexit = false;
        private void btn_exit_Click(object sender, EventArgs e)
        {
            btnexit = true;
            switch (MessageBox.Show("Bạn có muốn quay về đăng nhập luôn không!", "Thông báo", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes: this.Close();
                    break;
                case DialogResult.No: Application.Exit();
                    break;
            }
        }

        private void txb_Email_TextChanged(object sender, EventArgs e)
        {
            txb_res.Text = "";
        }
        private void QuenMatKhauForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if(!btnexit)
                switch (MessageBox.Show("Bạn có chắc chắn thoát không!", "Chờ một lát", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes: 
                        break;
                    case DialogResult.No: e.Cancel = true;
                        break;
                }
        }
    }
}
