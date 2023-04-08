using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPhongGym.DTO;
using QLPhongGym.BLL;
using System.Data.SqlTypes;
using System.Linq.Expressions;
using System.Drawing.Imaging;

namespace QLPhongGym.GUI
{
    public partial class Admin_FormDanhSachKH : Form
    {
        QLPhongGymDB db = new QLPhongGymDB();
        static string ImagePath = Application.StartupPath + @"\Resources\User.png";
        public Admin_FormDanhSachKH()
        {
            InitializeComponent();
            LoadKHDGV();
        }
        public void LoadKHDGV()
        {
            dataGridView1.DataSource = KHBLL.Instance.FindListKHByIDOrName("");
        }
        public void ResetDuLieu()
        {
            txb_tenkh.Text = "";
            dtp_ns.Value = DateTime.Now;
            txb_makh.Text = "";
            txb_sdt.Text = "";
            txb_CCCD.Text = "";
            txb_diachi.Text = "";
            txb_gmail.Text = "";
            pb_kh.Image = Image.FromFile(ImagePath);
            groupBox1.Controls.OfType<RadioButton>().ToList().ForEach(p => p.Checked = false);
            LoadKHDGV();
        }
        public void LoadDuLieuKH(int IDKH)
        {
            try
            {
                KH kh = (KH)UsersBLL.Instance.GetUserByID(IDKH);
                txb_makh.Text = kh.IDUsers.ToString();
                txb_tenkh.Text = kh.Name.ToString();
                dtp_ns.Value = Convert.ToDateTime(kh.DateBorn);
                if ((bool)kh.Sex)
                    rb_nam.Checked = true;
                else rb_nu.Checked = true;
                txb_CCCD.Text = kh.CCCD;
                txb_gmail.Text = kh.Gmail;
                txb_sdt.Text = kh.Sdt;
                txb_diachi.Text = kh.Address;
                pb_kh.Tag = kh.Image;
                if (kh.Image != null)
                    pb_kh.Image = Image.FromFile(Application.StartupPath + @"\CustomerImage\" + kh.Image);
                else pb_kh.Image = Image.FromFile(ImagePath);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Load dữ liệu khách hàng 1thất bại");
            }
            
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            bool gen = false, check = true;
            string Anh = null;
            if (pb_kh.Tag != null)
            {
                if(!string.IsNullOrEmpty(pb_kh.Tag.ToString()))
                    Anh = pb_kh.Tag.ToString();
            }
            if (rb_nam.Checked) gen = true;
            else if(!rb_nu.Checked && !rb_nam.Checked) check = false;
            if(txb_tenkh.Text.Trim() == "" || txb_sdt.Text.Trim() == "" || txb_diachi.Text.Trim() == "" || !check) {
                MessageBox.Show("Mời nhập vào thông tin còn trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!UsersBLL.Instance.CheckHoTen(txb_tenkh.Text.Trim())) { MessageBox.Show("Họ tên không đúng định dạng"); return; }
            if (!UsersBLL.Instance.CheckNS(dtp_ns.Value))
            {
                MessageBox.Show("Đô tuổi không đúng quy định(10 < Tuổi <= 120)");
                return;
            }
            if (!UsersBLL.Instance.CheckCccd(txb_CCCD.Text.Trim()))
            {
                MessageBox.Show("Căn cước công dân không đúng định dạng"); return;
            }
            else
            {
                if (UsersBLL.Instance.checkCCCDexist(txb_CCCD.Text.Trim()))
                {
                    MessageBox.Show("Căn cước công dân đã tồn tại"); return;
                }
            }
            if (!UsersBLL.Instance.CheckGmail(txb_gmail.Text.Trim()))
            {
                MessageBox.Show("Gmail không đúng định dạng");
                return;
            }
            else
                if (UsersBLL.Instance.CheckGmailExist(txb_gmail.Text.Trim()))
            {
                MessageBox.Show("Gmail đã tồn tại");
                return;
            }
            if (!UsersBLL.Instance.CheckSDT(txb_sdt.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại không đúng định dạng");
                return;
            }
            if (UsersBLL.Instance.CheckSDTExist(txb_sdt.Text.Trim()))
            {
                MessageBox.Show("Số điện thoại đã tồn tại");
                return;
            }
            if (!UsersBLL.Instance.CheckDiaChi(txb_diachi.Text))
            {
                MessageBox.Show("Địa chỉ không đúng định dạng");
                return;
            }
            KH kh = new KH
            {
                Name = txb_tenkh.Text.Trim(), DateBorn = dtp_ns.Value, Sdt = txb_sdt.Text.Trim(),
                Gmail = txb_gmail.Text.Trim(), Address = txb_diachi.Text.Trim(),
                CCCD = txb_CCCD.Text.Trim(), Sex = gen, Image = Anh
            };
            try
            {

                if (KHBLL.Instance.AddUser(kh))
                {
                    MessageBox.Show("Thêm khách hàng thành công");
                    ResetDuLieu();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thêm khách hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            
            if(dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    int IDKH = KHBLL.Instance.GetUserID(dataGridView1.SelectedRows[0].Cells["CCCD"].Value.ToString());
                    switch (MessageBox.Show("Bạn đã chắc chắn muốn sửa chưa không", "Xin chờ một lát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                    {
                        case DialogResult.OK:
                            bool gen = false, check = true;
                            string Anh = null;
                            if (pb_kh.Tag != null)
                            {
                                if (!string.IsNullOrEmpty(pb_kh.Tag.ToString()))
                                    Anh = pb_kh.Tag.ToString();
                            }
                            if (rb_nam.Checked) gen = true;
                            else if (!rb_nu.Checked && !rb_nam.Checked) check = false;
                            if (txb_tenkh.Text.Trim() == "" || txb_sdt.Text.Trim() == "" || txb_diachi.Text.Trim() == "" || !check)
                            {
                                MessageBox.Show("Mời nhập vào thông tin còn trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            if (!UsersBLL.Instance.CheckHoTen(txb_tenkh.Text.Trim())) { MessageBox.Show("Họ tên không đúng định dạng"); return; }
                            if (!UsersBLL.Instance.CheckNS(dtp_ns.Value))
                            {
                                MessageBox.Show("Đô tuổi không đúng quy định(10 < Tuổi <= 120)");
                                return;
                            }
                            if (!UsersBLL.Instance.CheckCccd(txb_CCCD.Text.Trim()))
                            {
                                MessageBox.Show("Căn cước công dân không đúng định dạng"); return;
                            }
                            if (!UsersBLL.Instance.CheckGmail(txb_gmail.Text.Trim()))
                            {
                                MessageBox.Show("Gmail không đúng định dạng");
                                return;
                            }
                            if (!UsersBLL.Instance.CheckSDT(txb_sdt.Text.Trim()))
                            {
                                MessageBox.Show("Số điện thoại không đúng định dạng");
                                return;
                            }
                            if (!UsersBLL.Instance.CheckDiaChi(txb_diachi.Text))
                            {
                                MessageBox.Show("Địa chỉ không đúng định dạng");
                                return;
                            }
                            KH kh = (KH)UsersBLL.Instance.GetUserByID(IDKH);
                            kh.Name = txb_tenkh.Text.Trim(); kh.DateBorn = dtp_ns.Value; kh.Sdt = txb_sdt.Text.Trim();
                            kh.Gmail = txb_gmail.Text.Trim(); kh.Address = txb_diachi.Text.Trim(); kh.CCCD = txb_CCCD.Text.Trim();
                            kh.Sex = gen; kh.Image = Anh;
                            if (KHBLL.Instance.UpdateUser(kh))
                            {
                                MessageBox.Show("Cật nhật khách hàng thành công");
                                ResetDuLieu();
                            }
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Cật nhật khách hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }             
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    switch(MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xin chờ một lát", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                                UsersBLL.Instance.DeleteUser(UsersBLL.Instance.GetUserByID(Convert.ToInt32(i.Cells["ID"].Value.ToString())));
                            ResetDuLieu();
                            break;
                        case DialogResult.No:
                            return;
                    }                 
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Xóa khách hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                string PathAnh = Application.StartupPath + @"\CustomerImage\";
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
                    InitialDirectory = Application.StartupPath + @"\CustomerImage\"
                })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        string filename = ofd.FileName;
                        pb_kh.Image = Image.FromFile(filename);
                        pb_kh.Tag = filename.Replace(PathAnh, "");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Upload ảnh thất bại");
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    int IDKH = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                    LoadDuLieuKH(IDKH);
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            pb_kh.Image = Image.FromFile(ImagePath);
            pb_kh.Tag = null;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = KHBLL.Instance.FindListKHByIDOrName(txb_search.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tìm kiếm khách hàng thất bại");
            }
           
        }

        private void btn_resetdata_Click(object sender, EventArgs e)
        {
            ResetDuLieu();
        }

        private void btn_sapxep_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = KHBLL.Instance.SortListKHBy(cb_sapxep.Text, KHBLL.Instance.FindListKHByIDOrName(txb_search.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Sắp xếp khách hàng thất bại");
            }
            
        } 
    }
}
