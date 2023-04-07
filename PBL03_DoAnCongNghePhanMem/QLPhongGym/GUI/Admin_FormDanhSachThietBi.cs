using QLPhongGym.BLL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Drawing.Imaging;
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
            int selectedCount = dataGridView1.SelectedRows.Count;
            if (selectedCount > 0)
            {
                DialogResult result = MessageBox.Show(string.Format("Bạn có chắc chắn muốn xóa {0} hàng đã chọn?", selectedCount),
                                                       "Xóa dữ liệu",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Xóa các hàng được chọn
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                        ThietBi_BLL.Instance.DeleteTB_BLL(id);
                    }
                }
                ShowData();
            }
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
                if (!int.TryParse(txt_SoLuong.Text, out int sl) || sl <= 0)
                {
                    MessageBox.Show("Số lượng thiết bị không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_Mota.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mô tả thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txt_Price.Text, out int price) || price <= 0)
                {
                    MessageBox.Show("Giá thiết bị không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_NhaCungCap.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập nhà cung cấp thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                tb.IDTB = Convert.ToInt32(txt_MTB.Text);
                tb.Name = txt_TenThietbi.Text;
                tb.MoTa = txt_Mota.Text;
                tb.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
                if (txt_SLHong.Text != "")
                {
                    if (!int.TryParse(txt_SLHong.Text, out int slhong) || slhong <= 0 || slhong > Convert.ToInt32(txt_SoLuong.Text))
                    {
                        MessageBox.Show("Số lượng hỏng không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    tb.SoLuongHong = Convert.ToInt32(txt_SLHong.Text);
                }
                tb.Price = Convert.ToDouble(txt_Price.Text);
                tb.NhaCungCap = txt_NhaCungCap.Text;
                ThietBi_BLL.Instance.UpdateThietBi_BLL(tb);
                MessageBox.Show("Đã sửa thành công!!!");
            }
            ShowData();
        }

        private void Btn_thêm_Click(object sender, EventArgs e)
        {
            if (txt_MTB.Text == "")
            {
                ThietBi tb = new ThietBi();
                if (txt_TenThietbi.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập tên thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txt_SoLuong.Text, out int sl) || sl <= 0)
                {
                    MessageBox.Show("Số lượng thiết bị không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_Mota.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập mô tả thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txt_Price.Text, out int price) || price <= 0)
                {
                    MessageBox.Show("Giá thiết bị không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_NhaCungCap.Text == "")
                {
                    MessageBox.Show("Bạn phải nhập nhà cung cấp thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txt_SLHong.Text != "")
                {
                    if (!int.TryParse(txt_SLHong.Text, out int slhong) || slhong <= 0 || slhong > Convert.ToInt32(txt_SoLuong.Text))
                    {
                        MessageBox.Show("Số lượng hỏng không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    tb.SoLuongHong = Convert.ToInt32(txt_SLHong.Text);
                }
                tb.Name = txt_TenThietbi.Text;
                tb.MoTa = txt_Mota.Text;
                tb.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
                tb.Price = Convert.ToDouble(txt_Price.Text);
                tb.NhaCungCap = txt_NhaCungCap.Text;
                ThietBi_BLL.Instance.AddThietBi_BLL(tb);
                MessageBox.Show("Đã thêm thành công!!!");
            }
            ShowData();
        }
        private void Btn_sort_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) // chọn một giá trị trong combobox
            {
                dataGridView1.DataSource = ThietBi_BLL.Instance.Sort_BLL(comboBox1.SelectedItem.ToString(), txt_search.Text);
            }
            else
            {
                MessageBox.Show("Chọn thứ bạn muốn sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_MTB.Text = "";
            txt_Mota.Text = "";
            txt_TenThietbi.Text = "";
            txt_SoLuong.Text = "";
            txt_NhaCungCap.Text = "";
            txt_Price.Text = "";
            txt_SLHong.Text = "";
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ThietBi_BLL.Instance.Search_BLL(txt_search.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
     
        }
    }
}
