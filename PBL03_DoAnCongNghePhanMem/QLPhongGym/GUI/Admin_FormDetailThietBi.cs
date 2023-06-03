using QLPhongGym.BLL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.GUI
{
    public partial class Admin_FormDetailThietBi : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        public string ID { get; set; }
        static string ImagePath = Application.StartupPath + @"\Resources\No_Image_Available.jpg";
        public Admin_FormDetailThietBi(string id)
        {
            ID = id;
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            if (ID != "")
            {
                ThietBi tb = new ThietBi();
                tb = ThietBi_BLL.Instance.GetThietBiByID_BLL(Convert.ToInt32(ID));
                txt_MTB.Text = ID;
                txt_NhaCungCap.Text = tb.NhaCungCap;
                txt_Price.Text = Convert.ToString(tb.Price);
                txt_SL.Text = Convert.ToString(tb.SoLuong);
                txt_SLHong.Text = Convert.ToString(tb.SoLuongHong);
                txt_TenTB.Text = Convert.ToString(tb.Name);
                dateTimePicker1.Text = Convert.ToString(tb.NamSX);
                txt_Mota.Text = tb.MoTa;
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

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
            else return;
        }

        private void Btn_Change_Click(object sender, EventArgs e)
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

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            ThietBi tb = new ThietBi();
            if (txt_TenTB.Text == "")
            {
                MessageBox.Show("Cần nhập tên thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txt_SL.Text, out int sl) || sl <= 0)
            {
                MessageBox.Show("Số lượng thiết bị không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_Mota.Text == "")
            {
                MessageBox.Show("Bạn phải nhập mô tả thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txt_Price.Text, out int price) || price <= 1000)
            {
                MessageBox.Show("Giá thiết bị không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_NhaCungCap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập nhà cung cấp thiết bị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tb.Name = txt_TenTB.Text;
            tb.MoTa = txt_Mota.Text;
            tb.SoLuong = Convert.ToInt32(txt_SL.Text);
            if (!int.TryParse(txt_SLHong.Text, out int slhong) || slhong < 0 || slhong > Convert.ToInt32(txt_SL.Text))
            {
                MessageBox.Show("Số lượng hỏng không hợp lệ, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tb.SoLuongHong = Convert.ToInt32(txt_SLHong.Text);
            tb.Price = Convert.ToDouble(txt_Price.Text);
            tb.NhaCungCap = txt_NhaCungCap.Text;
            tb.NamSX = Convert.ToDateTime(dateTimePicker1.Text);
            string Anh = null;
            if (pictureBox1.Tag != null)
            {
                if (!string.IsNullOrEmpty(pictureBox1.Tag.ToString()))
                    Anh = pictureBox1.Tag.ToString();
            }
            if (Anh == null)
            {
                MessageBox.Show("Bạn phải chọn ảnh cho thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tb.Image = Anh;
            if (txt_MTB.Text != "")
            {
                tb.IDTB = Convert.ToInt32(txt_MTB.Text);
                ThietBi_BLL.Instance.UpdateThietBi_BLL(tb);
                d();
                MessageBox.Show("Đã sửa thành công!!!");
                this.Close();
            }
            else
            {
                if (ThietBi_BLL.Instance.KiemTraTen_BLL(txt_TenTB.Text))
                {
                    MessageBox.Show("Tên thiết bị đã tồn tại, vui lòng thử lại với tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ThietBi_BLL.Instance.AddThietBi_BLL(tb);
                d();
                MessageBox.Show("Đã thêm thành công!!!");
                this.Close();
            }
        }
    }
}
