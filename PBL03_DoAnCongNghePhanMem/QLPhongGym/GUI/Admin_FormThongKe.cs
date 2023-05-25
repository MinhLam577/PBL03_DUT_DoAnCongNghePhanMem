using QLPhongGym.BLL;
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
    public partial class Admin_FormThongKe : Form
    {
        public Admin_FormThongKe()
        {
            InitializeComponent();
            LoadDuLieuForm();
            LoadDuLieuBieuDo();
            LoadDuLieuBieuDoNhuCauDangKiGoi();
        }
        public void LoadDuLieuForm()
        {
            int tongkhachhang = 0, tonghlv = 0, tongtb = 0, tonggt = 0;
            foreach (var i in KHBLL.Instance.GetAllKHID())
                tongkhachhang++;
            foreach (var i in QLHLVBLL.getInstance.GetAllHLVID())
                tonghlv++;
            foreach (var i in ThietBi_BLL.Instance.GetAllTB())
                tongtb++;
            foreach (var i in GoiTapBLL.Instance.GetAllGT())
                tonggt++;
            lb_totalcoach.Text = tonghlv.ToString();
            lb_totalcustomer.Text = tongkhachhang.ToString();
            lb_equipment.Text = tongtb.ToString();
            lb_package.Text = tonggt.ToString();
        }
        public void LoadDuLieuBieuDo()
        {
            int x = DateTime.Now.Year;
            chart_doanhthu.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(
                "Doanh thu trong năm " + x, System.Windows.Forms.DataVisualization.Charting.Docking.Top,
                new Font("Arial", 18, FontStyle.Bold), Color.Black));
            chart_doanhthu.Series["Doanh thu"].Color = Color.Red;
            double tongdoanhthu = 0;
            for (int i = 1, j = 0; i <= 12; i++, j++)
            {
                chart_doanhthu.Series["Doanh thu"].Points.AddXY(i, HoaDonBLL.Instance.GetTongDoanhThuTheoNamVaThang(x, i));
                tongdoanhthu += HoaDonBLL.Instance.GetTongDoanhThuTheoNamVaThang(x, i);
                chart_doanhthu.Series["Doanh thu"].Points[j].Label = HoaDonBLL.Instance.GetTongDoanhThuTheoNamVaThang(x, i).ToString();
            }
            lb_tongthunhap.Text = tongdoanhthu.ToString();
        }
        public void LoadDuLieuBieuDoNhuCauDangKiGoi()
        {
            int x = DateTime.Now.Year;
            chart_nhucaudkgt.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(
                "số lượng đăng kí gói tập trong năm " + x, System.Windows.Forms.DataVisualization.Charting.Docking.Top,
                new Font("Arial", 18, FontStyle.Bold), Color.Black));
            for (int i = 1, j = 0; i <= 12; i++, j++)
            {
                chart_nhucaudkgt.Series["Số lượng đăng kí gói"].Points.AddXY(i, DangKiGoiTapBLL.Instance.GetSoLuongDKGTTheoNamVaThang(x, i));
                chart_nhucaudkgt.Series["Số lượng đăng kí gói"].Points[j].Label = DangKiGoiTapBLL.Instance.GetSoLuongDKGTTheoNamVaThang(x, i).ToString();
            }
        }

        private void Admin_FormThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
