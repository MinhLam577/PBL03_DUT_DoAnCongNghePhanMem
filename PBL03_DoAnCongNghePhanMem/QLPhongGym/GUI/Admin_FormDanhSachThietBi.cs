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
        static string ImagePath = Application.StartupPath + @"\Resources\No_Image_Available.jpg";
        public Admin_FormDanhSachThietBi()
        {
            InitializeComponent();
            ShowData();
        }
        public void ShowData()
        {
            dataGridView1.DataSource = ThietBi_BLL.Instance.GetAllThietBi_BLL();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ThietBi_BLL.Instance.Search_BLL(txt_Search.Text);
        }
        private void btn_xoa_Click(object sender, EventArgs e)
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
                        if (row.Cells["ID"] != null && row.Cells["ID"].Value != null)
                        {
                            int id = Convert.ToInt32(row.Cells["ID"].Value);
                            ThietBi_BLL.Instance.DeleteTB_BLL(id);
                        }

                    }
                }
                ShowData();

            }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null) // chọn một giá trị trong combobox
            {
                dataGridView1.DataSource = ThietBi_BLL.Instance.Sort_BLL(comboBox1.SelectedItem.ToString(), txt_Search.Text);
            }
            else
            {
                MessageBox.Show("Chọn thứ bạn muốn sắp xếp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        /*private void btn_Xoa_Click(object sender, EventArgs e)
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
                    //Reset();
                }
                ShowData();
            }
        }*/
    }
    }
/*        private void Btn_Sửa_Click(object sender, EventArgs e)
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
                string Anh = null;
                if (pictureBox1.Tag != null)
                {
                    if (!string.IsNullOrEmpty(pictureBox1.Tag.ToString()))
                        Anh = pictureBox1.Tag.ToString();
                }
                tb.Image = Anh;
                ThietBi_BLL.Instance.UpdateThietBi_BLL(tb);
                MessageBox.Show("Đã sửa thành công!!!");
                Reset();
            }
            ShowData();
        }

        private void Btn_thêm_Click(object sender, EventArgs e)
        {
            if (txt_MTB.Text == "")
            {
                ThietBi tb = new ThietBi();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Tên thiết bị"].Value != null)
                    {
                        if (txt_TenThietbi.Text == row.Cells["Tên thiết bị"].Value.ToString())
                        {
                            MessageBox.Show("Tên thiết bị đã tồn tại trong danh sách, vui lòng nhập tên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
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
                string Anh = null;
                if (pictureBox1.Tag != null)
                {
                    if (!string.IsNullOrEmpty(pictureBox1.Tag.ToString()))
                        Anh = pictureBox1.Tag.ToString();
                }
                tb.Image = Anh;
                tb.Name = txt_TenThietbi.Text;
                tb.MoTa = txt_Mota.Text;
                tb.SoLuong = Convert.ToInt32(txt_SoLuong.Text);
                tb.Price = Convert.ToDouble(txt_Price.Text);
                tb.NhaCungCap = txt_NhaCungCap.Text;
                ThietBi_BLL.Instance.AddThietBi_BLL(tb);
                MessageBox.Show("Đã thêm thành công!!!");
                Reset();
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
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txt_MTB.Text = row.Cells["ID"].Value.ToString();
                    txt_Mota.Text = row.Cells["Mô tả"].Value.ToString();
                    txt_TenThietbi.Text = row.Cells["Tên thiết bị"].Value.ToString();
                    txt_SoLuong.Text = row.Cells["Số lượng"].Value.ToString();
                    txt_NhaCungCap.Text = row.Cells["Nhà cung cấp"].Value.ToString();
                    txt_Price.Text = row.Cells["Giá tiền(vnd)"].Value.ToString();
                    txt_SLHong.Text = row.Cells["Số lượng hỏng"].Value.ToString();
                    ThietBi tb = new ThietBi();
                    tb = ThietBi_BLL.Instance.GetThietBiByID_BLL(Convert.ToInt32(txt_MTB.Text));
                    pictureBox1.Tag = tb.Image;
                    if (pictureBox1.Image != null)
                    {
                        if (tb.Image == null)
                        {
                            pictureBox1.Image = Image.FromFile(ImagePath);
                        }
                        else
                        {
                            pictureBox1.Image = Image.FromFile(Application.StartupPath + @"\ThietBi_Image\" + tb.Image);
                        }
                    }
                }
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        public void Reset()
        {
            txt_MTB.Text = "";
            txt_Mota.Text = "";
            txt_TenThietbi.Text = "";
            txt_SoLuong.Text = "";
            txt_NhaCungCap.Text = "";
            txt_Price.Text = "";
            txt_SLHong.Text = "";
            pictureBox1.Image = Image.FromFile(ImagePath);
            pictureBox1.Tag = null;
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ThietBi_BLL.Instance.Search_BLL(txt_search.Text);
        }

        private void btn_DoiAnh_Click(object sender, EventArgs e)
        {
            string PathAnh = Application.StartupPath + @"\ThietBi_Image\";
            var codecs = ImageCodecInfo.GetImageEncoders();
            var codecFilter = "Image Files|";
            foreach (var codec in codecs)
            {
                codecFilter += codec.FilenameExtension + ";";
            }

            using (OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = codecFilter,
                Multiselect = false,
                InitialDirectory = Application.StartupPath + @"\ThietBi_Image\"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filename = ofd.FileName;
                    pictureBox1.Image = Image.FromFile(filename);
                    pictureBox1.Tag = filename.Replace(PathAnh, "");
                }
            }
        }

    }
}
*/