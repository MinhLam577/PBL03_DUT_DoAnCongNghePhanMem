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
using System.Windows.Forms.DataVisualization.Charting;

namespace QLPhongGym.GUI
{
    public partial class Admin_ThongKeForm : Form
    {
        public Admin_ThongKeForm()
        {
            InitializeComponent();
            LoadDuLieuForm();
            LoadDuLieuBieuDo();
            LoadDuLieuBieuDoSoLuongDangKiGoi();
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
                new Font("Arial", 20, FontStyle.Bold), Color.Black));
            chart_doanhthu.Series["Doanh thu"].Color = Color.Red;
            double tongdoanhthu = 0;

            for (int i = 1, j = 0; i <= 12; i++, j++)
            {

                chart_doanhthu.Series["Doanh thu"].Points.AddXY(i, HoaDonBLL.Instance.GetTongDoanhThuTheoNamVaThang(x, i));
                tongdoanhthu += HoaDonBLL.Instance.GetTongDoanhThuTheoNamVaThang(x, i);
                chart_doanhthu.Series["Doanh thu"].Points[j].Label = HoaDonBLL.Instance.GetTongDoanhThuTheoNamVaThang(x, i).ToString();
            }
            chart_doanhthu.ChartAreas[0].AxisX.Title = "Tháng";
            chart_doanhthu.ChartAreas[0].AxisX.TitleFont = new Font("Times new roman", 14, FontStyle.Bold);
            chart_doanhthu.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Near;
            chart_doanhthu.ChartAreas[0].AxisY.Title = "Tổng doanh thu(VNĐ)";
            chart_doanhthu.ChartAreas[0].AxisY.TitleFont = new Font("Times new roman", 14, FontStyle.Bold);
            chart_doanhthu.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Near;
            lb_tongthunhap.Text = tongdoanhthu.ToString();
        }
        public void LoadDuLieuBieuDoSoLuongDangKiGoi()
        {
            int x = DateTime.Now.Year;
            chart_soluongdkgt.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(
                "số lượng đăng kí gói tập trong năm " + x, System.Windows.Forms.DataVisualization.Charting.Docking.Top,
                new Font("Arial", 20, FontStyle.Bold), Color.Black));
            for (int i = 1, j = 0; i <= 12; i++, j++)
            {
                chart_soluongdkgt.Series["Số lượng đăng kí gói"].Points.AddXY(i, DangKiGoiTapBLL.Instance.GetSoLuongDKGTTheoNamVaThang(x, i));
                chart_soluongdkgt.Series["Số lượng đăng kí gói"].Points[j].Label = DangKiGoiTapBLL.Instance.GetSoLuongDKGTTheoNamVaThang(x, i).ToString();
            }
            chart_soluongdkgt.ChartAreas[0].AxisX.Title = "Tháng";
            chart_soluongdkgt.ChartAreas[0].AxisX.TitleFont = new Font("Times new roman", 14, FontStyle.Bold);
            chart_soluongdkgt.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Near;
            chart_soluongdkgt.ChartAreas[0].AxisY.Title = "Tổng số lượng gói tập khách hàng đăng kí";
            chart_soluongdkgt.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Near;
            chart_soluongdkgt.ChartAreas[0].AxisY.TitleFont = new Font("Times new roman", 14, FontStyle.Bold);
        }
        public void LoadDuLieuBieuDoNhuCauDangKiGoi()
        {
            int x = DateTime.Now.Year;
            chart_nhucaudkgt.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(
                "Nhu cầu đăng kí gói tập trong năm " + x, System.Windows.Forms.DataVisualization.Charting.Docking.Top,
                new Font("Arial", 20, FontStyle.Bold), Color.Black));
            List<GoiTap> list_gt = GoiTapBLL.Instance.GetAllGT();
            int cnt_gt = list_gt.Count;
            chart_nhucaudkgt.ChartAreas[0].AxisX.Title = "Tháng";
            chart_nhucaudkgt.ChartAreas[0].AxisX.TitleFont = new Font("Times new roman", 14, FontStyle.Bold);
            chart_nhucaudkgt.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Near;
            chart_nhucaudkgt.ChartAreas[0].AxisY.Title = "Số lượng khách hàng đăng kí theo gói tập";
            chart_nhucaudkgt.ChartAreas[0].AxisY.TitleFont = new Font("Times new roman", 14, FontStyle.Bold);
            chart_nhucaudkgt.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Near;
            foreach (var i in list_gt)
            {
                chart_nhucaudkgt.Series.Add(i.NameGT);
                chart_nhucaudkgt.Series[i.NameGT].Font = new Font("Times new roman", 15, FontStyle.Bold);
                chart_nhucaudkgt.Legends[0].Font = new Font("Times new roman", 15, FontStyle.Bold);
            }

            for (int i = 1, j = 0; i <= 12; i++, j++)
            {
                foreach (var k in list_gt)
                {
                    chart_nhucaudkgt.Series[k.NameGT].Points.AddXY(i, DangKiGoiTapBLL.Instance.GetSoLuongNhuCauDKGTTheoNam_Thang_IDGT(x, i, k.IDGT));
                    chart_nhucaudkgt.Series[k.NameGT].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
                    chart_nhucaudkgt.Series[k.NameGT].IsValueShownAsLabel = true;
                }
            }
            foreach(Series sr in chart_nhucaudkgt.Series)
                foreach(DataPoint p in sr.Points)
                    if (p.YValues[0] == 0)
                        p.IsValueShownAsLabel = false;
        }
    }
}
