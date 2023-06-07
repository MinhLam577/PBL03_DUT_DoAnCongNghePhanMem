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
    public partial class Admin_FormThemTKHLV : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        public string ID { get; set; }
        public string Ten { get; set; }
        public Admin_FormThemTKHLV(string id, string txtText)
        {
            ID = id;
            Ten = txtText;
            InitializeComponent();
            if(txtText != "")
            {
                GUI2();
            }
            else 
            {
                GUI();
            };
            
        }
        public void GUI()
        {
            if (ID != "")
            {
                txt_MaHLV.Text = ID;
                HLV a = new HLV();
                a = TKHLV_BLL.Instance.GetHLVByID_BLL(Convert.ToInt32(ID));
                Txt_TenHLV.Text = a.Name;
                txt_MaHLV.Enabled = false;
                Txt_TenHLV.Enabled = false;
            }
        }
        public void GUI2()
        {
            if (ID != "")
            {
                txt_MaHLV.Text = ID;
                HLV a = new HLV();
                a = TKHLV_BLL.Instance.GetHLVByID_BLL(Convert.ToInt32(ID));
                Txt_TenHLV.Text = a.Name;
                Txt_TK.Text = Ten;
                txt_MaHLV.Enabled = false;
                Txt_TenHLV.Enabled = false;
                Txt_TK.Enabled = false;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            TK tk = null;
            if (Ten != "")
                tk = TKBLL.Instance.GetTKByTenTK(Ten);
            TK a = new TK();
            if (Txt_TK.Text == "")
            {
                MessageBox.Show("Cần nhập tên tài khoản");
                return;
            }
            a.TenTK = Txt_TK.Text;
            if (!TKBLL.Instance.checkTkMk(Txt_Mk.Text))
            {
                MessageBox.Show("Mật khẩu chỉ chứa kí tự số hoặc chữ hoa thường và bao gồm 6 đến 20 kí tự");
                return;
            }
            if (Txt_Mk.Text != Txt_NhapLai.Text || Txt_Mk.Text == "")
            {
                MessageBox.Show("Xác nhận mật khẩu không đồng dạng");
                return ;
            }
            a.MatkhauTK = Eramake.eCryptography.Encrypt(Txt_NhapLai.Text);
            a.IDQuyen = 2;
            a.TrangThai = true;
            a.IDUser = Convert.ToInt32(ID);
            if (Ten == "")
            {   if(TKHLV_BLL.Instance.TenTK_BLL(Txt_TK.Text) == true)
                {
                    MessageBox.Show("Tên tài khoản đã được sử dụng");
                    return;
                }
                TKHLV_BLL.Instance.ADD_BLL(a);
                d();
            }
            else
            {
                a.TrangThai = tk.TrangThai;
                TKHLV_BLL.Instance.UpdateTK_BLl(a);
                d();
            }
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
