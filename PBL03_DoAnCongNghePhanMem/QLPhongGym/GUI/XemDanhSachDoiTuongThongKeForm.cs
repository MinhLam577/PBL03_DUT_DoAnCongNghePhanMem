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
    public partial class XemDanhSachDoiTuongThongKeForm : Form
    {
        public DataTable dt { get; set; }
        public string TenDoiTuong { get; set; }
        public int Year { get; set; }
        public XemDanhSachDoiTuongThongKeForm(DataTable dt, string TenDiTuong, int Year)
        {
            InitializeComponent();
            this.dt = dt;
            this.TenDoiTuong = TenDiTuong;
            this.Year = Year;
            LoadDGV();
        }
        public void LoadDGV()
        {
            if (TenDoiTuong == "Khách hàng")
            {
                label1.Text = "Danh sách khách hàng trong năm " + Year.ToString();
                dgv_object.DataSource = dt;
                dgv_object.Columns["IDThe"].Visible = false;
            }
            else if(TenDoiTuong == "Huấn luyện viên")
            {
                label1.Text = "Danh sách huấn luyện viên trong năm " + Year.ToString();
                dgv_object.DataSource = dt;
                dgv_object.Columns["ID"].Visible = false;
            }
            else if (TenDoiTuong == "Thiết bị")
            {
                label1.Text = "Danh sách thiết bị trong năm " + Year.ToString();
                dgv_object.DataSource = dt;
                dgv_object.Columns["ID"].Visible = false;
            }
            else if (TenDoiTuong == "Gói tập")
            {
                label1.Text = "Danh sách gói tập trong năm " + Year.ToString();
                dgv_object.DataSource = dt;
                dgv_object.Columns["Mã gói tập"].Visible = false;
            }
            dgv_object.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }
    }
}
