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
using QLPhongGym.BLL;
using QLPhongGym.DTO;
namespace QLPhongGym.GUI
{
    public partial class QuenMatKhauForm : Form
    {
        public QuenMatKhauForm()
        {
            InitializeComponent();
        }
        private void btn_laylaimk_Click(object sender, EventArgs e)
        {
            if(txb_Email.Text == "") { MessageBox.Show("Mời nhập vào thông tin còn trống"); return; }
        }
        bool btnexit = false;
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void txb_Email_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void QuenMatKhauForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
