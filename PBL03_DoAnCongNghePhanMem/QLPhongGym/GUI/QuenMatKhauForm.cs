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
        public event EventHandler Exit;
        private void btn_laylaimk_Click(object sender, EventArgs e)
        {
            if(txb_Email.Text == "") { MessageBox.Show("Mời nhập vào thông tin còn trống"); return; }
            else
            {
                if (TKBLL.Instance.CheckEmailExist(txb_Email.Text))
                {
                    txb_res.Text = TKBLL.Instance.GetPassword(txb_Email.Text);
                }
                else MessageBox.Show("Gmail không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Exit(this, new EventArgs());
        }
    }
}
