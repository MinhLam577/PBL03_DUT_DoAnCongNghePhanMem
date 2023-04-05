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
    public partial class Admin_FormDanhSachThietBi : Form
    {
        public Admin_FormDanhSachThietBi()
        {
            InitializeComponent();
            ShowData();
        }
        public void ShowData()
        {
            dataGridView1.DataSource = ThietBi_BLL.Instance.GetAllThietBi_BLL();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                ThietBi_BLL.Instance.DeleteTB_BLL(id);
            }
            ShowData();
        }
        public void GUI()
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                txt_MTB.Text = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                txt_Mota.Text = dataGridView1.SelectedRows[0].Cells["Mô tả"].Value.ToString();
                txt_TenThietbi.Text = dataGridView1.SelectedRows[0].Cells["Tên thiết bị"].Value.ToString();
                txt_SoLuong.Text = dataGridView1.SelectedRows[0].Cells["Số lượng"].Value.ToString();
                txt_NhaCungCap.Text = dataGridView1.SelectedRows[0].Cells["Nhà cung cấp"].Value.ToString();
                txt_Price.Text = dataGridView1.SelectedRows[0].Cells["Giá tiền"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_MTB.Text = row.Cells["ID"].Value.ToString();
                txt_Mota.Text = row.Cells["Mô tả"].Value.ToString();
                txt_TenThietbi.Text = row.Cells["Tên thiết bị"].Value.ToString();
                txt_SoLuong.Text = row.Cells["Số lượng"].Value.ToString();
                txt_NhaCungCap.Text = row.Cells["Nhà cung cấp"].Value.ToString();
                txt_Price.Text = row.Cells["Giá tiền"].Value.ToString();
                txt_SLHong.Text = row.Cells["Số lượng hỏng"].Value.ToString();
            }
        }
        private void Btn_Sửa_Click(object sender, EventArgs e)
        {
            if (txt_MTB.Text != "")
            {
                ThietBi tb = new ThietBi();
                if (txt_TenThietbi.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập tên thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_SoLuong.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập số lượng thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_Mota.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mô tả thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_Price.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập giá thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_NhaCungCap.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập nhà cung cấp thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tb.Name = txt_TenThietbi.Text;
                tb.MoTa = txt_Mota.Text;
                tb.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
                if (txt_SLHong.Text != "")
                {
                    tb.SoLuongHong = Convert.ToInt32(txt_SLHong.Text);
                }
                tb.Price = Convert.ToDouble(txt_Price.Text);
                tb.NhaCungCap = txt_NhaCungCap.Text;
                ThietBi_BLL.Instance.UpdateThietBi_BLL(tb);
            }
        }

        private void Btn_thêm_Click(object sender, EventArgs e)
        {
            if (txt_MTB.Text == "")
            {
                ThietBi tb = new ThietBi();
                if (txt_TenThietbi.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập tên thiết bị","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                if (txt_SoLuong.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập số lượng thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_Mota.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mô tả thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_Price.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập giá thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_NhaCungCap.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập nhà cung cấp thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_SLHong.Text != "")
                {
                    tb.SoLuongHong = Convert.ToInt32(txt_SLHong.Text);
                }
                tb.Name = txt_TenThietbi.Text;
                tb.MoTa = txt_Mota.Text;
                tb.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
                tb.Price = Convert.ToDouble(txt_Price.Text);
                tb.NhaCungCap = txt_NhaCungCap.Text;
                ThietBi_BLL.Instance.AddThietBi_BLL(tb);
            }
            ShowData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = ThietBi_BLL.Instance.Search_BLL(txt_search.Text);
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ThietBi_BLL.Instance.Search_BLL(txt_search.Text);
        }

        private void Btn_sort_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ThietBi_BLL.Instance.Sort_BLL(comboBox1.SelectedItem.ToString(), txt_search.Text);
        }
    }
}
