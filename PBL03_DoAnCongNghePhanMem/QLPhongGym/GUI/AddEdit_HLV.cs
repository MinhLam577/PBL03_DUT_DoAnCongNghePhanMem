using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPhongGym.BLL;
using QLPhongGym.DTO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace QLPhongGym.GUI
{
    public partial class AddEdit_HLV : Form
    {
        public delegate void mydelegate(object a);
        public mydelegate buon { get; set; }


        public AddEdit_HLV()
        {
            InitializeComponent();
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(textSDT, "Số điện thoại phải đúng 10 kí tự số "); // you can change the first parameter (textbox3) on any control you wanna focus*/

        }
        private ToolTip toolTip = new ToolTip();
        private bool isShown = false;
        static string ImageLink = Application.StartupPath + @"\Resources\Admin.png";

        public int lc = -1;
        public int luachon(int luachon)
        {
            return lc = luachon;
        }
        private void btnOKI_Click(object sender, EventArgs e)
        {
            HLV a = new HLV();
            if (luachon(lc) == 2)
            {
                a.IDUsers = Convert.ToInt32(textMaHLv.Text.ToString().Trim());
            }
            bool sex = false, check = false;
            if(radioBtnMale.Checked == true)
            {
                sex = true;
            }
            if (radioBtnMale.Checked || radioBtnFemale.Checked)
                check = true;
            if (!check)
            {
                MessageBox.Show("Mời chọn giới tính");
                return;
            }
            a.Name = textNameHLV.Text.ToString().Trim();
            a.Sex = sex;
            a.DateBorn = Convert.ToDateTime(dateTimeHLV.Value);
            a.BangCap = textBangcap.Text.Trim();
            a.Sdt = textSDT.Text.Trim();
            a.CCCD = textCCCD.Text.Trim();
            a.Gmail = textGmai.Text.Trim();
            a.Address = textDiachi.Text.Trim();
            string Anh = null;
            if (pictureHLV.Tag != null)
            {
                if (!string.IsNullOrEmpty(pictureHLV.Tag.ToString()))
                    Anh = pictureHLV.Tag.ToString();
            }
            a.Image = Anh;
            try
            {
                if(textBangcap.Text == "")
                {
                    MessageBox.Show("Mời nhập vào dữ liệu còn trống");
                    return;
                }
                if (!UsersBLL.Instance.CheckHoTen(a.Name)) { MessageBox.Show("Họ tên không đúng định dạng"); return; }
                if (!UsersBLL.Instance.CheckNS((DateTime)a.DateBorn))
                {
                    MessageBox.Show("Đô tuổi không đúng quy định(10 < Tuổi <= 120)");
                    return;
                }
                if (!UsersBLL.Instance.CheckCccd(a.CCCD))
                {
                    MessageBox.Show("Căn cước công dân không đúng định dạng"); return;
                }
                else
                {
                    if (luachon(lc) == 1)
                    {
                        if (UsersBLL.Instance.checkCCCDexist(a.CCCD))
                        {
                            MessageBox.Show("Căn cước công dân đã tồn tại"); return;
                        }
                    }
                    else
                    {
                        if (QLHLVBLL.getInstance.CheckCmndExitEDit(a))
                        {
                            MessageBox.Show("Căn cước công dân đã tồn tại"); return;
                        }
                    }
                }
                if (!UsersBLL.Instance.CheckGmail(a.Gmail))
                {
                    MessageBox.Show("Gmail không đúng định dạng");
                    return;
                }
                else
                {
                    if (luachon(lc) == 1)
                    {
                        if (UsersBLL.Instance.CheckGmailExist(a.Gmail))
                        {
                            MessageBox.Show("Gmail đã tồn tại");
                            return;
                        }
                    }
                    else if (luachon(lc) == 2)
                    {
                        if (QLHLVBLL.getInstance.CheckGmailExitEdit(a))
                        {
                            MessageBox.Show("Gmail cật nhật đã tồn tại");
                            return;
                        }
                    }
                }

                if (!UsersBLL.Instance.CheckSDT(a.Sdt))
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng");
                    return;
                }
                else
                {
                    if (luachon(lc) == 1)
                    {
                        if (UsersBLL.Instance.CheckSDTExist(a.Sdt))
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại");
                            return;
                        }
                    }
                    else if (luachon(lc) == 2)
                    {
                        if (QLHLVBLL.getInstance.CheckSDTExitEdit(a))
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại");
                            return;
                        }
                    }
                }
                if (!UsersBLL.Instance.CheckDiaChi(a.Address))
                {
                    MessageBox.Show("Địa chỉ không đúng định dạng");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi ");
            }
            buon(a);
            Dispose();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            try
            {
                string PathAnh = Application.StartupPath + @"\PersonImage\"; // duong dan 
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
                        string filename = ofd.FileName;// ten ảnh 
                        pictureHLV.Image = Image.FromFile(filename);
                        pictureHLV.Tag = filename.Replace(PathAnh, "");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upload ảnh thất bại");
            }
        }

        private void btnResetPic_Click(object sender, EventArgs e)
        {
            pictureHLV.Image = Image.FromFile(ImageLink);
            pictureHLV.Tag = null;
        }
        public void getinfofromAB(HLV a)
        {
            textMaHLv.Text = a.IDUsers.ToString().Trim();
            textCCCD.Text = a.CCCD.ToString().Trim();
            textNameHLV.Text = a.Name.ToString().Trim();
            if (a.Sex == true)
            {
                radioBtnMale.Checked = (bool)a.Sex;
            }
            else
            {
                radioBtnFemale.Checked = true;
            }
            textDiachi.Text = a.Address.ToString().Trim();
            textSDT.Text = a.Sdt.ToString().Trim();
            textGmai.Text = a.Gmail.ToString().Trim();
            textBangcap.Text = a.BangCap.ToString().Trim();
            dateTimeHLV.Value = (DateTime)a.DateBorn;
            if (a.Image != null)
            {
                pictureHLV.Image = Image.FromFile(Application.StartupPath + @"\PersonImage\" + a.Image);
                pictureHLV.Tag = a.Image;
            }
            else
            {
                pictureHLV.Image = Image.FromFile(ImageLink);
                pictureHLV.Tag = a.Image;
            }
        }

        private void textSDT_Click(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(textSDT, "Số điện thoại phải đúng 10 kí tự số "); // you can change the first parameter (textbox3) on any control you wanna focus*/
        }

        private void textCCCD_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textCCCD, "Căn cước công dân phải đúng 12 kí tự số "); // you can change the first parameter (textbox3) on any control you wanna focus*/
        }

        private void textGmai_Click(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textGmai, "Gmail phải có cả chữ và số  "); // you can change the first parameter (textbox3) on any control you wanna focus*/
        }

        private void AddEdit_HLV_Load(object sender, EventArgs e)
        {

        }
    }  
}

