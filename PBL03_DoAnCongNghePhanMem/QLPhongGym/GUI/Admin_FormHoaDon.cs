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
    public partial class Admin_FormHoaDon : Form
    {
        public int year { get; set; }
        public Admin_FormHoaDon(int year)
        {
            InitializeComponent();
            this.year = year;
            loadDuLieuDTG();
        }
        public void loadDuLieuDTG()
        {
            dgv_object.DataSource = HoaDonBLL.Instance.GetHoaDonByYear(year);
            dgv_object.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgv_object.DataSource = HoaDonBLL.Instance.SearchHoaDon_BLL(textBox1.Text, cb_fitler.Text, year);
        }

        private void buttonDetailHoaDon_Click(object sender, EventArgs e)
        {
            if (dgv_object.SelectedRows.Count == 1)
            {
                if (dgv_object.SelectedRows[0].Cells["Mã hóa đơn"] != null && dgv_object.SelectedRows[0].Cells["Mã hóa đơn"].Value != null)
                {
                    string id = dgv_object.SelectedRows[0].Cells["Mã hóa đơn"].Value.ToString();
                    Admin_ChiTietHoaDon f = new Admin_ChiTietHoaDon(id);
                    f.d += new Admin_ChiTietHoaDon.Mydel(loadDuLieuDTG);
                    f.ShowDialog();
                }
            }
        }

        private void cb_fitler_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_object.DataSource = HoaDonBLL.Instance.SearchHoaDon_BLL(textBox1.Text, cb_fitler.Text, year);
        }
    }
}
