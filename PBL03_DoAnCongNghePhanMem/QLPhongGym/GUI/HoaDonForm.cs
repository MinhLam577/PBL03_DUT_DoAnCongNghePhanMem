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
    public partial class HoaDonForm : Form
    {
        public string UserName { get; set; }
        public string GTName { get; set; }
        public string GiamGia { get; set; }
        public DangKiGoiTap dkgt { get; set; }
        public LichThueHLV lt { get; set; }
        public HoaDonForm()
        {
            InitializeComponent();
        }
        public HoaDonForm(string UserName, string GTName, string GiamGia, DangKiGoiTap dkgt, LichThueHLV lt)
        {
            InitializeComponent();
            this.UserName = UserName;
            this.GTName = GTName;
            this.dkgt = dkgt;
            this.lt = lt;
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
                if (lt != null)
                    lb_thanhtien.Text = (Convert.ToDouble(lb_giathue.Text) + Convert.ToDouble(lb_phidki.Text) - Convert.ToDouble(lb_giamgia.Text)).ToString();
                else
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
    }
}
