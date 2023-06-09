using Microsoft.VisualBasic;
using QLPhongGym.BLL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.GUI
{
    public partial class HoaDonForm : Form
    {
        public string UserName { get; set; }
        public string GTName { get; set; }
        public string GiamGia { get; set; }
        public DangKiGoiTap dkgt { get; set; }
        public HoaDonForm()
        {
            InitializeComponent();
        }
        public HoaDonForm(string UserName, string GTName, string GiamGia, DangKiGoiTap dkgt)
        {
            InitializeComponent();
            this.UserName = UserName;
            this.GTName = GTName;
            this.dkgt = dkgt;
            this.GiamGia = GiamGia;
            LoadDuLieu();
        }
        public void LoadDuLieu()
        {
            try
            {
                string PriceGT = GoiTapBLL.Instance.GetGTByName(GTName).Price.ToString();
                lb_hovaten.Text = UserName;
                lb_gt.Text = GTName;
                lb_ngaydki.Text = dkgt.NgayDangKiGT.Value.Date.ToString();
                lb_ngayketthuc.Text = dkgt.NgayKetThucGT.Value.Date.ToString();
                lb_phidki.Text = PriceGT;
                lb_giamgia.Text = GiamGia;
                lb_thanhtien.Text = (Convert.ToDouble(lb_phidki.Text) - Convert.ToDouble(lb_giamgia.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Không load được dữ liệu hóa đơn");
            }
           
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                else {
                    btn_inhoadon.Visible = true;
                    btn_thoat.Visible = true;
                }
            }
        }
    }
}
