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
        static int Nam = 2023;
        public Admin_ThongKeForm()
        {
            InitializeComponent();
            LoadDuLieuLabel();
            LoadDuLieuBieuDo();
            LoadDuLieuBieuDoSoLuongDangKiGoi();
            LoadDuLieuBieuDoNhuCauDangKiGoi();
        }
        public void LoadDuLieuLabel()
        {
            int tongkhachhang = 0, tonghlv = 0, tonggt = 0;
            List<string> list_kh = new List<string>(), list_hlv = new List<string>();
            foreach (var i in DangKiGoiTapBLL.Instance.GetListDKGTByYear(Nam))
                list_kh.Add(UsersBLL.Instance.GetUserByID(i.IDKH.Value).Name);
            foreach (var i in list_kh.Distinct())
                tongkhachhang++;
            foreach (var i in DangKiLichLamViecBAL.getInStance.GetListLLVByYear(Nam))
                list_hlv.Add(UsersBLL.Instance.GetUserByID(i.IDHLV.Value).Name);
            foreach (var i in list_hlv.Distinct())
                tonghlv++;
            foreach (var i in GoiTapBLL.Instance.GetAllGT())
                tonggt++;
            lb_totalcoach.Text = tonghlv.ToString();
            lb_totalcustomer.Text = tongkhachhang.ToString();
            lb_equipment.Text = ThietBi_BLL.Instance.GetTongSoLuongThietBiCoSan().ToString();
            lb_package.Text = tonggt.ToString();
        }
        public void LoadDuLieuBieuDo()
        {
            chart_doanhthu.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(
                "Doanh thu trong năm " + Nam, System.Windows.Forms.DataVisualization.Charting.Docking.Top,
                new Font("Arial", 20, FontStyle.Bold), Color.White));
            chart_doanhthu.Series["Doanh thu"].Color = Color.Red;
            double tongdoanhthu = 0;

            for (int i = 1, j = 0; i <= 12; i++, j++)
            {

                chart_doanhthu.Series["Doanh thu"].Points.AddXY(i, HoaDonBLL.Instance.GetTongDoanhThuTheoNamVaThang(Nam, i));
                tongdoanhthu += HoaDonBLL.Instance.GetTongDoanhThuTheoNamVaThang(Nam, i);
                chart_doanhthu.Series["Doanh thu"].Points[j].Label = HoaDonBLL.Instance.GetTongDoanhThuTheoNamVaThang(Nam, i).ToString();
            }
            chart_doanhthu.ChartAreas[0].AxisX.Title = "Tháng";
            chart_doanhthu.ChartAreas[0].AxisX.TitleFont = new Font("Times new roman", 14, FontStyle.Bold);
            chart_doanhthu.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Near;
            chart_doanhthu.ChartAreas[0].AxisY.Title = "Tổng doanh thu(VNĐ)";
            chart_doanhthu.ChartAreas[0].AxisY.TitleFont = new Font("Times new roman", 14, FontStyle.Bold);
            chart_doanhthu.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Near;
            chart_doanhthu.Legends[0].Font = new Font("Times new roman", 15, FontStyle.Bold);
            chart_doanhthu.Legends[0].Docking = Docking.Top;
            lb_tongthunhap.Text = tongdoanhthu.ToString();
        }
        public void LoadDuLieuBieuDoSoLuongDangKiGoi()
        {
            chart_soluongdkgt.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(
                "số lượng đăng kí gói tập trong năm " + Nam, System.Windows.Forms.DataVisualization.Charting.Docking.Top,
                new Font("Arial", 20, FontStyle.Bold), Color.White));
            chart_soluongdkgt.Series["Số lượng đăng kí gói"].Color = Color.FromArgb(34, 139, 34);
            for (int i = 1, j = 0; i <= 12; i++, j++)
            {
                chart_soluongdkgt.Series["Số lượng đăng kí gói"].Points.AddXY(i, DangKiGoiTapBLL.Instance.GetSoLuongDKGTTheoNamVaThang(Nam, i));
                chart_soluongdkgt.Series["Số lượng đăng kí gói"].Points[j].Label = DangKiGoiTapBLL.Instance.GetSoLuongDKGTTheoNamVaThang(Nam, i).ToString();
                chart_soluongdkgt.Series["Số lượng đăng kí gói"].Points[j].Font = new Font("Times new roman", 15, FontStyle.Bold);
            }
            chart_soluongdkgt.ChartAreas[0].AxisX.Title = "Tháng";
            chart_soluongdkgt.ChartAreas[0].AxisX.TitleFont = new Font("Times new roman", 14, FontStyle.Bold);
            chart_soluongdkgt.ChartAreas[0].AxisX.TitleAlignment = StringAlignment.Near;
            chart_soluongdkgt.ChartAreas[0].AxisY.Title = "Tổng số lượng gói tập khách hàng đăng kí";
            chart_soluongdkgt.ChartAreas[0].AxisY.TitleAlignment = StringAlignment.Near;
            chart_soluongdkgt.ChartAreas[0].AxisY.TitleFont = new Font("Times new roman", 12, FontStyle.Bold);
            chart_soluongdkgt.Legends[0].Font = new Font("Times new roman", 15, FontStyle.Bold);
            chart_soluongdkgt.Legends[0].Docking = Docking.Top;
        }
        public void LoadDuLieuBieuDoNhuCauDangKiGoi()
        {
            chart_nhucaudkgt.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(
                "Nhu cầu đăng kí gói tập trong năm " + Nam, System.Windows.Forms.DataVisualization.Charting.Docking.Top,
                new Font("Arial", 20, FontStyle.Bold), Color.White));
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
                chart_nhucaudkgt.Legends[0].Font = new Font("Times new roman", 12, FontStyle.Bold);
            }

            for (int i = 1, j = 0; i <= 12; i++, j++)
            {
                foreach (var k in list_gt)
                {
                    chart_nhucaudkgt.Series[k.NameGT].Points.AddXY(i, DangKiGoiTapBLL.Instance.GetSoLuongNhuCauDKGTTheoNam_Thang_IDGT(Nam, i, k.IDGT));
                    chart_nhucaudkgt.Series[k.NameGT].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
                    chart_nhucaudkgt.Series[k.NameGT].IsValueShownAsLabel = true;
                }
            }
            foreach (Series sr in chart_nhucaudkgt.Series)
                foreach (DataPoint p in sr.Points)
                    if (p.YValues[0] == 0)
                        p.IsValueShownAsLabel = false;
        }
        public void ReloadBieuDoDoanhThu()
        {
            chart_doanhthu.Titles.Clear();
            chart_doanhthu.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(
                "Doanh thu trong năm " + Nam, System.Windows.Forms.DataVisualization.Charting.Docking.Top,
                new Font("Arial", 20, FontStyle.Bold), Color.White));
            double tongdoanhthu = 0;
            foreach (var series in chart_doanhthu.Series)
            {
                series.Points.Clear();
            }
            for (int i = 1, j = 0; i <= 12; i++, j++)
            {
                chart_doanhthu.Series["Doanh thu"].Points.AddXY(i, HoaDonBLL.Instance.GetTongDoanhThuTheoNamVaThang(Nam, i));
                tongdoanhthu += HoaDonBLL.Instance.GetTongDoanhThuTheoNamVaThang(Nam, i);
                chart_doanhthu.Series["Doanh thu"].Points[j].Label = HoaDonBLL.Instance.GetTongDoanhThuTheoNamVaThang(Nam, i).ToString();
            }
            lb_tongthunhap.Text = tongdoanhthu.ToString();

        }
        public void ReloadBieuDoSoLuongDangKi()
        {
            chart_soluongdkgt.Titles.Clear();
            chart_soluongdkgt.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(
                "số lượng đăng kí gói tập trong năm " + Nam, System.Windows.Forms.DataVisualization.Charting.Docking.Top,
                new Font("Arial", 20, FontStyle.Bold), Color.White));
            foreach (var series in chart_soluongdkgt.Series)
            {
                series.Points.Clear();
            }
            for (int i = 1, j = 0; i <= 12; i++, j++)
            {
                chart_soluongdkgt.Series["Số lượng đăng kí gói"].Points.AddXY(i, DangKiGoiTapBLL.Instance.GetSoLuongDKGTTheoNamVaThang(Nam, i));
                chart_soluongdkgt.Series["Số lượng đăng kí gói"].Points[j].Label = DangKiGoiTapBLL.Instance.GetSoLuongDKGTTheoNamVaThang(Nam, i).ToString();
                chart_soluongdkgt.Series["Số lượng đăng kí gói"].Points[j].Font = new Font("Times new roman", 15, FontStyle.Bold);
            }
        }

        public void ReloadBieuDoNhuCauDangKi()
        {
            chart_nhucaudkgt.Titles.Clear();
            chart_nhucaudkgt.Titles.Add(new System.Windows.Forms.DataVisualization.Charting.Title(
                "Nhu cầu đăng kí gói tập trong năm " + Nam, System.Windows.Forms.DataVisualization.Charting.Docking.Top,
                new Font("Arial", 20, FontStyle.Bold), Color.White));
            List<GoiTap> list_gt = GoiTapBLL.Instance.GetAllGT();
            foreach (var series in chart_nhucaudkgt.Series)
            {
                series.Points.Clear();
            }
            for (int i = 1, j = 0; i <= 12; i++, j++)
            {
                foreach (var k in list_gt)
                {
                    chart_nhucaudkgt.Series[k.NameGT].Points.AddXY(i, DangKiGoiTapBLL.Instance.GetSoLuongNhuCauDKGTTheoNam_Thang_IDGT(Nam, i, k.IDGT));
                    chart_nhucaudkgt.Series[k.NameGT].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
                    chart_nhucaudkgt.Series[k.NameGT].IsValueShownAsLabel = true;
                }
            }
            foreach (Series sr in chart_nhucaudkgt.Series)
                foreach (DataPoint p in sr.Points)
                    if (p.YValues[0] == 0)
                        p.IsValueShownAsLabel = false;

        }

        private void lb_tru_Click(object sender, EventArgs e)
        {
            if (Nam >= 1976)
            {
                Nam--;
                ReloadBieuDoDoanhThu();
                ReloadBieuDoSoLuongDangKi();
                ReloadBieuDoNhuCauDangKi();
                LoadDuLieuLabel();
                lb_nam.Text = "Năm: " + Nam.ToString();
            }
        }

        private void lb_cong_Click(object sender, EventArgs e)
        {
            if (Nam <= 9999)
            {
                Nam++;
                ReloadBieuDoDoanhThu();
                ReloadBieuDoSoLuongDangKi();
                ReloadBieuDoNhuCauDangKi();
                LoadDuLieuLabel();
                lb_nam.Text = "Năm: " + Nam.ToString();
            }
        }

        private void pb_kh_Click(object sender, EventArgs e)
        {
            DataTable dt = KHBLL.Instance.GetListKH_ByYear(Nam);
            XemDanhSachDoiTuongThongKeForm f = new XemDanhSachDoiTuongThongKeForm(dt, "Khách hàng", Nam);
            f.ShowDialog();
        }

        private void pb_hlv_Click(object sender, EventArgs e)
        {
            DataTable dt = QLHLVBLL.getInstance.GetListHLV_ByYear(Nam);
            XemDanhSachDoiTuongThongKeForm f = new XemDanhSachDoiTuongThongKeForm(dt, "Huấn luyện viên", Nam);
            f.ShowDialog();
        }

        private void pb_tb_Click(object sender, EventArgs e)
        {
            DataTable dt = ThietBi_BLL.Instance.GetAllThietBi_BLL();
            XemDanhSachDoiTuongThongKeForm f = new XemDanhSachDoiTuongThongKeForm(dt, "Thiết bị", Nam);
            f.ShowDialog();
        }

        private void pb_gt_Click(object sender, EventArgs e)
        {
            DataTable dt = GoiTapBLL.Instance.GetData_BLL();
            XemDanhSachDoiTuongThongKeForm f = new XemDanhSachDoiTuongThongKeForm(dt, "Gói tập", Nam);
            f.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Admin_FormHoaDon f = new Admin_FormHoaDon(Nam);
            f.ShowDialog();
        }
    }
}
