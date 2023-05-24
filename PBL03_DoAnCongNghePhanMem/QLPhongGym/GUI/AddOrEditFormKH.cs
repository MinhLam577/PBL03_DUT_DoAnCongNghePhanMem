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
    public partial class AddOrEditFormKH : Form
    {
        static string DefaultImagePath = Application.StartupPath + @"\Resources\User.png";
        public string ID { get; set; }
        public string TenQuyen { get; set; }
        public event EventHandler ThayDoiThanhCong;
        public AddOrEditFormKH()
        {
            InitializeComponent();
        }
        public AddOrEditFormKH(string ID, string tenQuyen)
        {
            InitializeComponent();
            this.ID = ID;
            TenQuyen = tenQuyen;
            if(ID == "")
            {
                lb_main.Text = "Đăng kí khách hàng";
                lb_main.Font = new Font("Arial", 28, FontStyle.Bold);
                lb_main.ForeColor = Color.Black;
            }
            else { 
                if(tenQuyen == "Admin")
                {
                    lb_main.Text = "Cật nhật thông tin Admin";
                    lb_main.Font = new Font("Arial", 28, FontStyle.Bold);
                    lb_main.ForeColor = Color.Black;
                }
                else {
                    lb_main.Text = "Cật nhật thông tin khách hàng";
                    lb_main.Font = new Font("Arial", 28, FontStyle.Bold);
                    lb_main.ForeColor = Color.Black;
                }
            }
        }
        private void LoadData()
        {
            if(!string.IsNullOrEmpty(ID) && TenQuyen != "Admin") {
                try
                {
                    KH kh = (KH)UsersBLL.Instance.GetUserByID(Convert.ToInt32(ID));
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
                        pb_kh.Image = Image.FromFile(Application.StartupPath + @"\PersonImage\" + kh.Image);
                    else pb_kh.Image = Image.FromFile(DefaultImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load dữ liệu khách hàng thất bại");
                }
            }
            else if(!string.IsNullOrEmpty(ID) && TenQuyen == "Admin")
            {
                try
                {
                    Admin ad = (Admin)UsersBLL.Instance.GetUserByID(Convert.ToInt32(ID));
                    txb_makh.Text = ad.IDUsers.ToString();
                    txb_tenkh.Text = ad.Name.ToString();
                    dtp_ns.Value = Convert.ToDateTime(ad.DateBorn);
                    if ((bool)ad.Sex)
                        rb_nam.Checked = true;
                    else rb_nu.Checked = true;
                    txb_CCCD.Text = ad.CCCD;
                    txb_gmail.Text = ad.Gmail;
                    txb_sdt.Text = ad.Sdt;
                    txb_diachi.Text = ad.Address;
                    pb_kh.Tag = ad.Image;
                    if (ad.Image != null)
                        pb_kh.Image = Image.FromFile(Application.StartupPath + @"\PersonImage\" + ad.Image);
                    else pb_kh.Image = Image.FromFile(DefaultImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load dữ liệu admin thất bại");
                }
            }
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.ID))
            {
                bool gen = false, check = true;
                string Anh = null;
                KH kh = null;
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
                kh = new KH
                {
                    Name = txb_tenkh.Text.Trim(),
                    DateBorn = dtp_ns.Value,
                    Sdt = txb_sdt.Text.Trim(),
                    Gmail = txb_gmail.Text.Trim(),
                    Address = txb_diachi.Text.Trim(),
                    CCCD = txb_CCCD.Text.Trim(),
                    Sex = gen,
                    Image = Anh
                };

                try
                {
                    DangKiGoiTapKHForm f = new DangKiGoiTapKHForm(kh, "");
                    f.DangKiThanhCong += (o, a) =>
                    {
                        (o as DangKiGoiTapKHForm).Close();
                        this.Close();
                    };
                    f.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thêm khách hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    switch (MessageBox.Show("Bạn đã chắc chắn muốn sửa chưa không", "Xin chờ một lát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                    {
                        case DialogResult.OK:
                            bool gen = false, check = true;
                            string Anh = null;
                            KH kh = null;
                            Admin ad = null;
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
                            if(TenQuyen != "Admin")
                            {
                                kh = (KH)UsersBLL.Instance.GetUserByID(Convert.ToInt32(this.ID));
                                kh.Name = txb_tenkh.Text.Trim(); kh.DateBorn = dtp_ns.Value; kh.Sdt = txb_sdt.Text.Trim();
                                kh.Gmail = txb_gmail.Text.Trim(); kh.Address = txb_diachi.Text.Trim(); kh.CCCD = txb_CCCD.Text.Trim();
                                kh.Sex = gen; kh.Image = Anh;
                                if (KHBLL.Instance.UpdateUser(kh))
                                {
                                    MessageBox.Show("Cật nhật khách hàng thành công");
                                    ThayDoiThanhCong(this, new EventArgs());
                                }
                            }
                            else
                            {
                                ad = (Admin)UsersBLL.Instance.GetUserByID(Convert.ToInt32(this.ID));
                                ad.Name = txb_tenkh.Text.Trim(); ad.DateBorn = dtp_ns.Value; ad.Sdt = txb_sdt.Text.Trim();
                                ad.Gmail = txb_gmail.Text.Trim(); ad.Address = txb_diachi.Text.Trim(); ad.CCCD = txb_CCCD.Text.Trim();
                                ad.Sex = gen; ad.Image = Anh;
                                if (UsersBLL.Instance.UpdateUser(ad))
                                {
                                    MessageBox.Show("Cật nhật admin thành công");
                                    ThayDoiThanhCong(this, new EventArgs());
                                }
                            }
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message,  "Cật nhật thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_upload_Click(object sender, EventArgs e)
        {
            try
            {
                string PathAnh = Application.StartupPath + @"\PersonImage\";
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
                    InitialDirectory = Application.StartupPath + @"\PersonImage\"
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upload ảnh thất bại");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            pb_kh.Image = Image.FromFile(DefaultImagePath);
            pb_kh.Tag = null;
        }

        private void AddOrEditFormKH_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
