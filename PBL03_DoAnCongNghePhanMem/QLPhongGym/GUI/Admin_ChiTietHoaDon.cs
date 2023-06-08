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
    public partial class Admin_ChiTietHoaDon : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        public string ID { get; set; }
        public Admin_ChiTietHoaDon(string id)
        {
            ID = id;
            InitializeComponent();
            GUI();
        }
        
        public void GUI()
        {
            if(ID != "")
            {
                DataTable hd = HoaDonBLL.Instance.GetHoaDonByID_BLL(ID);
                lb_hd.Text = ID;
                int id = Convert.ToInt32(hd.Rows[0]["Mã khách hàng"]);
                label_MKH.Text = hd.Rows[0]["Mã khách hàng"].ToString();
                User s = HoaDonBLL.Instance.GetTenUser_BLL(id);
                lb_hovaten.Text = s.Name.ToString();
                lb_gt.Text = hd.Rows[0]["Tên gói tập"].ToString();
                lb_ngaydki.Text = hd.Rows[0]["Ngày đăng kí"].ToString();
                lb_thanhtien.Text = hd.Rows[0]["Giá tiền(vnd)"].ToString();
                lb_hlv.Text = hd.Rows[0]["Tên huấn luyện viên"].ToString();
            }
        }
        [System.Runtime.InteropServices.DllImportAttribute("gdi32.dll")]
        private static extern bool BitBlt
        (
            IntPtr hdcDest, // handle to destination DC  
            int nXDest, // x-coord of destination upper-left corner  
            int nYDest, // y-coord of destination upper-left corner  
            int nWidth, // width of destination rectangle  
            int nHeight, // height of destination rectangle  
            IntPtr hdcSrc, // handle to source DC  
            int nXSrc, // x-coordinate of source upper-left corner  
            int nYSrc, // y-coordinate of source upper-left corner  
            System.Int32 dwRop // raster operation code  
        );
        private void btn_inhoadon_Click(object sender, EventArgs e)
        {
            btn_inhoadon.Visible = false;
            btn_thoat.Visible = false;
            Graphics g1 = this.CreateGraphics();
            System.Drawing.Image MyImage = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height, g1);
            Graphics g2 = Graphics.FromImage(MyImage);
            IntPtr dc1 = g1.GetHdc();
            IntPtr dc2 = g2.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            g1.ReleaseHdc(dc1);
            g2.ReleaseHdc(dc2);
            
            var codecFilter = "(*.png)|*.png|(*.jpg)|*.jpg";
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = codecFilter,
                InitialDirectory = @"G:\"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    MyImage.Save(sfd.FileName);
                    btn_inhoadon.Visible = true;
                    btn_thoat.Visible = true;
                    if (MessageBox.Show("In hóa đơn thành công") == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                else
                {
                    btn_inhoadon.Visible = true;
                    btn_thoat.Visible = true;
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
