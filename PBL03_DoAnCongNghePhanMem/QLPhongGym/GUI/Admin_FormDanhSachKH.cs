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
    public partial class Admin_FormDanhSachKH : Form
    {
        bool Ispbchange = true;
        static string ImagePath = Application.StartupPath + @"\Resources\User.png";
        public Admin_FormDanhSachKH()
        {
            InitializeComponent();
            LoadListAllKH();
        }
        public void LoadListAllKH()
        {
            dgv_kh.DataSource = KHBLL.Instance.FindListKHByIDOrName("");
        }
        public void LoadListDKGT(int IDKH)
        {
            dgv_gt.DataSource = DangKiGoiTapBLL.Instance.GetDKKHDataTableByIDKH(IDKH);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(Ispbchange)
            {
                lb_mathe_cccd.Text = "CCCD:";
                lb_ten_sdt.Text = "Số điện thoại:";
                Ispbchange = false;
            }
            else
            {
                lb_mathe_cccd.Text = "Mã thẻ:";
                lb_ten_sdt.Text = "Tên:";
                Ispbchange = true;
            }
            
        }
        private void dgv_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_kh.SelectedRows.Count > 0)
            {
                try
                {
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                    KH kh = (KH)UsersBLL.Instance.GetUserByID(IDKH);
                    lb_tenkh.Text = kh.Name;
                    LoadListDKGT(kh.IDUsers);
                    if (kh.Image != null)
                        pb_kh.Image = Image.FromFile(Application.StartupPath + @"\PersonImage\" + kh.Image);
                    else pb_kh.Image = Image.FromFile(ImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOrEditFormKH addOrEditFormKH = new AddOrEditFormKH("");
            addOrEditFormKH.ShowDialog();
        }
        private void sửaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgv_kh.SelectedRows.Count == 1)
            {
                try
                {
                    int IDKH = KHBLL.Instance.GetUserID(dgv_kh.SelectedRows[0].Cells["CCCD"].Value.ToString());
                    AddOrEditFormKH f = new AddOrEditFormKH(IDKH.ToString());
                    f.ThayDoiThanhCong += F_ThayDoiThanhCong;
                    f.ShowDialog();
                }
                catch (Exception ex)
                {
                     MessageBox.Show(ex.Message, "Cật nhật khách hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void F_ThayDoiThanhCong(object sender, EventArgs e)
        {
            (sender as AddOrEditFormKH).Close();
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgv_kh.SelectedRows.Count > 0)
            {
                try
                {
                    switch (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xin chờ một lát", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        case DialogResult.Yes:
                            foreach (DataGridViewRow i in dgv_kh.SelectedRows)
                            {
                                int IDKH = Convert.ToInt32(i.Cells["IDThe"].Value.ToString());
                                DangKiGoiTapBLL.Instance.DeleteAllDKGT(DangKiGoiTapBLL.Instance.GetAllDKGTByIDKH(IDKH));
                                UsersBLL.Instance.DeleteUser(UsersBLL.Instance.GetUserByID(Convert.ToInt32(i.Cells["IDThe"].Value.ToString())));
                            }
                            LoadListAllKH();
                            break;
                        case DialogResult.No:
                            return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Xóa khách hàng thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txb_mathe_gmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lb_mathe_cccd.Text == "Mã thẻ:" && lb_ten_sdt.Text == "Tên:")
                {
                    if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text == "")
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHByIDOrName(txb_mathe_cccd.Text);
                    else if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text != "")
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHByNameAndID(txb_ten_sdt.Text, txb_mathe_cccd.Text);
                }
                else if (lb_mathe_cccd.Text == "CCCD:" && lb_ten_sdt.Text == "Số điện thoại:")
                {
                    if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text == "")
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHBySdtOrCCCD(txb_mathe_cccd.Text);
                    else if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text != "")
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHBySDTAndCCCD(txb_ten_sdt.Text, txb_mathe_cccd.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Tìm kiếm thất bại");
            }
            

        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadListAllKH() ;
        }

        private void txb_ten_sdt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lb_mathe_cccd.Text == "Mã thẻ:" && lb_ten_sdt.Text == "Tên:")
                {
                    if (txb_mathe_cccd.Text == "" && txb_ten_sdt.Text != "")
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHByIDOrName(txb_ten_sdt.Text);
                    else if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text != "")
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHByNameAndID(txb_ten_sdt.Text, txb_mathe_cccd.Text);
                }
                else if (lb_mathe_cccd.Text == "CCCD:" && lb_ten_sdt.Text == "Số điện thoại:")
                {
                    if (txb_mathe_cccd.Text == "" && txb_ten_sdt.Text != "")
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHBySdtOrCCCD(txb_ten_sdt.Text);
                    else if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text != "")
                        dgv_kh.DataSource = KHBLL.Instance.FindListKHBySDTAndCCCD(txb_ten_sdt.Text, txb_mathe_cccd.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Tìm kiếm thất bại");
            }
            
        }

        private void mãThẻToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text == "")
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Mã thẻ", KHBLL.Instance.FindListKHByIDOrName(txb_mathe_cccd.Text));
                else if (txb_ten_sdt.Text != "" && txb_mathe_cccd.Text == "")
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Mã thẻ", KHBLL.Instance.FindListKHByIDOrName(txb_ten_sdt.Text));
                else if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text != "")
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Mã thẻ", KHBLL.Instance.FindListKHByNameAndID(txb_ten_sdt.Text, txb_mathe_cccd.Text));
                else
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Mã thẻ", KHBLL.Instance.FindListKHByIDOrName(""));
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Sắp xếp thất bại");
            }
            
        }

        private void giớiTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text == "")
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Giới tính", KHBLL.Instance.FindListKHByIDOrName(txb_mathe_cccd.Text));
                else if (txb_ten_sdt.Text != "" && txb_mathe_cccd.Text == "")
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Giới tính", KHBLL.Instance.FindListKHByIDOrName(txb_ten_sdt.Text));
                else if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text != "")
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Giới tính", KHBLL.Instance.FindListKHByNameAndID(txb_ten_sdt.Text, txb_mathe_cccd.Text));
                else
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Giới tính", KHBLL.Instance.FindListKHByIDOrName(""));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sắp xếp thất bại");
            }
           
        }

        private void tênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text == "")
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Tên", KHBLL.Instance.FindListKHByIDOrName(txb_mathe_cccd.Text));
                else if (txb_ten_sdt.Text != "" && txb_mathe_cccd.Text == "")
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Tên", KHBLL.Instance.FindListKHByIDOrName(txb_ten_sdt.Text));
                else if (txb_mathe_cccd.Text != "" && txb_ten_sdt.Text != "")
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Tên", KHBLL.Instance.FindListKHByNameAndID(txb_ten_sdt.Text, txb_mathe_cccd.Text));
                else
                    dgv_kh.DataSource = KHBLL.Instance.SortListKHBy("Tên", KHBLL.Instance.FindListKHByIDOrName(""));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sắp xếp thất bại");
            }
            
        }

        private void giaHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgv_gt.SelectedRows.Count > 0)
                {
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                    string GoiTap = dgv_gt.SelectedRows[0].Cells["GoiTap"].Value.ToString();
                    KH kh = (KH)UsersBLL.Instance.GetUserByID(IDKH);
                    DangKiGoiTapKHForm dkf = new DangKiGoiTapKHForm(kh, GoiTap);
                    dkf.DangKiThanhCong += (o, a) =>
                    {
                        (o as DangKiGoiTapKHForm).Close();
                    };
                    dkf.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Gia hạn thất bại");
            }
        }

        private void đăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_kh.SelectedRows.Count > 0)
                {
                    int IDKH = Convert.ToInt32(dgv_kh.SelectedRows[0].Cells["IDThe"].Value.ToString());
                    KH kh = (KH)UsersBLL.Instance.GetUserByID(IDKH);
                    DangKiGoiTapKHForm dkf = new DangKiGoiTapKHForm(kh, "");
                    dkf.DangKiThanhCong += (o, a) =>
                    {
                        (o as DangKiGoiTapKHForm).Close();
                    };
                    dkf.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gia hạn thất bại");
            }
        }
    }
}
