using QLPhongGym.BLL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.GUI
{
    public partial class Admin_FormDanhSachHLV : Form
    {
        public Admin_FormDanhSachHLV()
        {
            InitializeComponent();
        }
        static string ImageLink = Application.StartupPath + @"\HLV_Image\Admin.png";
        private void CapNhatListHLV()
        {
            dataGridView1.DataSource = QLHLVBLL.getInstance.CapNhatListHLV();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn chắc chắn muốn xóa ? ", "Xóa ", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int idHLV = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[1].Value.ToString().Trim());
                if (QLHLVBLL.getInstance.Delete(idHLV) == true)
                {
                    MessageBox.Show("Xóa Thành Công");
                    CapNhatListHLV();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int Ma = Convert.ToInt32(textMaHLv.Text.Trim());
            string Name = textNameHLV.Text.Trim();
            DateTime DateBorn = Convert.ToDateTime(dateTimeHLV.Value);
            bool Sex;
            if (radioBtnMale.Checked == true)
            {
                Sex = true;
            }
            else
            {
                Sex = false;
            }
            string CCCD = textCCCD.Text.Trim();
            string Gmail = textGmai.Text.Trim();
            string Sdt = textSDT.Text.Trim();
            string DiaChi = textDiachi.Text.Trim();
            string BangCap = textBangcap.Text.Trim();
            string Anh = null;
            // a.Cccd = Convert.ToBoolean(dataGridView1.Rows[row].Cells[7].Value.ToString());
            // string TenLop = dataGridView1.Rows[rowSelected].Cells[8].Value.ToString();
            try
            {
                if (pictureHLV.Tag != null)
                {
                    if (!string.IsNullOrEmpty(pictureHLV.Tag.ToString()))
                        Anh = pictureHLV.Tag.ToString();
                }
                if (!UsersBLL.Instance.CheckHoTen(Name)) { MessageBox.Show("Họ tên không đúng định dạng"); return; }
                if (!UsersBLL.Instance.CheckNS(DateBorn))
                {
                    MessageBox.Show("Đô tuổi không đúng quy định(10 < Tuổi <= 120)");
                    return;
                }
                if (!UsersBLL.Instance.CheckCccd(CCCD))
                {
                    MessageBox.Show("Căn cước công dân không đúng định dạng"); return;
                }
                if (!UsersBLL.Instance.CheckGmail(Gmail))
                {
                    MessageBox.Show("Gmail không đúng định dạng");
                    return;
                }
                if (!UsersBLL.Instance.CheckSDT(Sdt))
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng");
                    return;
                }
                if (!UsersBLL.Instance.CheckDiaChi(DiaChi))
                {
                    MessageBox.Show("Địa chỉ không đúng định dạng");
                    return;
                }
                /*  if (QLHLVBLL.getInstance.Them(Name,DateBorn,Sex,CCCD,Gmail,Sdt,DiaChi, BangCap,Anh) == true)
                  {
                      MessageBox.Show("UpDate Thanh cong");
                      CapNhatListHLV();
                  };*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UpDate khách hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (QLHLVBLL.getInstance.Update(Ma, Name, DateBorn, Sex, CCCD, Gmail, Sdt, DiaChi, BangCap, Anh) == true)
            {
                MessageBox.Show("UpDate Thành Công ");
                CapNhatListHLV();
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string name = textNameHLV.Text.ToString().Trim();
            bool gioitinh = radioBtnFemale.Checked;
            DateTime ngaysinh = Convert.ToDateTime(dateTimeHLV.Value);
            string bangcap = textBangcap.Text.Trim();
            string sdt = textSDT.Text.Trim();
            string cccd = textCCCD.Text.Trim();
            string gmail = textGmai.Text.Trim();
            string diachi = textDiachi.Text.Trim();
            string Anh = null;
            if (pictureHLV.Tag != null)
            {
                if (!string.IsNullOrEmpty(pictureHLV.Tag.ToString()))
                    Anh = pictureHLV.Tag.ToString();
            }
            try
            {

                if (!UsersBLL.Instance.CheckHoTen(name)) { MessageBox.Show("Họ tên không đúng định dạng"); return; }
                if (!UsersBLL.Instance.CheckNS(ngaysinh))
                {
                    MessageBox.Show("Đô tuổi không đúng quy định(10 < Tuổi <= 120)");
                    return;
                }
                if (!UsersBLL.Instance.CheckCccd(cccd))
                {
                    MessageBox.Show("Căn cước công dân không đúng định dạng"); return;
                }
                else
                {
                    if (UsersBLL.Instance.checkCCCDexist(cccd))
                    {
                        MessageBox.Show("Căn cước công dân đã tồn tại"); return;
                    }
                }
                if (!UsersBLL.Instance.CheckGmail(gmail))
                {
                    MessageBox.Show("Gmail không đúng định dạng");
                    return;
                }
                else
                    if (UsersBLL.Instance.CheckGmailExist(gmail))
                {
                    MessageBox.Show("Gmail đã tồn tại");
                    return;
                }
                if (!UsersBLL.Instance.CheckSDT(sdt))
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng");
                    return;
                }
                if (UsersBLL.Instance.CheckSDTExist(sdt))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại");
                    return;
                }
                if (!UsersBLL.Instance.CheckDiaChi(diachi))
                {
                    MessageBox.Show("Địa chỉ không đúng định dạng");
                    return;
                }

                if (QLHLVBLL.getInstance.Them(name, ngaysinh, gioitinh, cccd, gmail, sdt, diachi, bangcap, Anh) == true)
                {
                    MessageBox.Show("Them Thanh cong");
                    CapNhatListHLV();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm khách hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textMaHLv.Text = "";
            textNameHLV.Text = "";
            textGmai.Text = "";
            textDiachi.Text = "";
            textSDT.Text = "";
            textBangcap.Text = "";
            textCCCD.Text = "";
            pictureHLV.Tag = null;
            radioBtnFemale.Checked = false;
            radioBtnMale.Checked = false;
            dateTimeHLV.Value = DateTime.Now;
            pictureHLV.Image = Image.FromFile(ImageLink);
            cbbSort.SelectedItem = null;
            textSearch.Text = "";
            CapNhatListHLV();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //
            string PathAnh = Application.StartupPath + @"\HLV_Image\"; // duong dan 
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
                InitialDirectory = Application.StartupPath + @"\HLV_Image\"
            })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filename = ofd.FileName;// ten ảnh 
                    pictureHLV.Image = Image.FromFile(filename);
                    pictureHLV.Tag = filename.Replace(PathAnh, "");
                    MessageBox.Show(pictureHLV.Tag.ToString());
                }
            }

        }
        private void btnResetPic_Click(object sender, EventArgs e)
        {
            pictureHLV.Image = Image.FromFile(ImageLink);
            pictureHLV.Tag = null;
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (cbbSort.SelectedItem == null)
            {
                MessageBox.Show("Bạn chưa nhập giá trị cần tìm kiếm  ", "Thong Báo", MessageBoxButtons.OK);
                cbbSort.Focus();
            }
            else
            {
                string textsort = cbbSort.SelectedItem.ToString().Trim();
                dataGridView1.DataSource = QLHLVBLL.getInstance.SortHLV(textsort, textSearch.Text.Trim());
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = textSearch.Text.Trim();
            dataGridView1.DataSource = QLHLVBLL.getInstance.SearchHLVByNameID(name);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            textMaHLv.Text = (dataGridView1.Rows[row].Cells[1].Value.ToString());
            textNameHLV.Text = dataGridView1.Rows[row].Cells[2].Value.ToString();
            dateTimeHLV.Value = Convert.ToDateTime(dataGridView1.Rows[row].Cells[3].Value.ToString());
            if (dataGridView1.Rows[row].Cells[4].Value.ToString().Equals("True"))
            {
                radioBtnMale.Checked = Convert.ToBoolean(dataGridView1.Rows[row].Cells[4].Value.ToString());
            }
            else
            {
                radioBtnFemale.Checked = true;
            }
            textCCCD.Text = (dataGridView1.Rows[row].Cells[5].Value.ToString());
            textGmai.Text = (dataGridView1.Rows[row].Cells[6].Value.ToString());
            textSDT.Text = (dataGridView1.Rows[row].Cells[7].Value.ToString());
            textDiachi.Text = (dataGridView1.Rows[row].Cells[8].Value.ToString());
            textBangcap.Text = (dataGridView1.Rows[row].Cells[9].Value.ToString());
            HLV a = new HLV();
            a = QLHLVBLL.getInstance.GetInfoHLV(Convert.ToInt32(textMaHLv.Text));
            pictureHLV.Tag = a.Image;
            if (pictureHLV.Tag != null)
            {
                if (!string.IsNullOrEmpty(pictureHLV.Tag.ToString()))
                {
                    pictureHLV.Image = Image.FromFile(Application.StartupPath + @"\HLV_Image\" + pictureHLV.Tag);
                }
            }
            else
            {
                pictureHLV.Image = Image.FromFile(Application.StartupPath + @"\HLV_Image\Admin.png");
            }
        }

        private void Admin_FormDanhSachHLV_Load_1(object sender, EventArgs e)
        {
            CapNhatListHLV();
        }
    }
}
