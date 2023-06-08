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
        public Admin_FormHoaDon()
        {
            InitializeComponent();
            loadDuLieuDTG();
        }
        public void loadDuLieuDTG()
        {
            dataGridView1.DataSource = HoaDonBLL.Instance.GetDuLieuHoaDon_BLL();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = HoaDonBLL.Instance.SearchHoaDon_BLL(textBox1.Text);
        }

        private void buttonDetailHoaDon_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (dataGridView1.SelectedRows[0].Cells["Mã hóa đơn"] != null && dataGridView1.SelectedRows[0].Cells["Mã hóa đơn"].Value != null)
                {
                    string id = dataGridView1.SelectedRows[0].Cells["Mã hóa đơn"].Value.ToString();
                    Admin_ChiTietHoaDon f = new Admin_ChiTietHoaDon(id);
                    f.d += new Admin_ChiTietHoaDon.Mydel(loadDuLieuDTG);
                    f.ShowDialog();
                }
            }
        }

        private void buttonXoaHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
