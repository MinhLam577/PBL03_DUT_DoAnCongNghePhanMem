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
using QLPhongGym.DAL;

namespace QLPhongGym.GUI
{
    public partial class Admin_FormDanhSachKH : Form
    {
        static string ImagePath = Application.StartupPath + @"\Resources\User.png";
        public Admin_FormDanhSachKH()
        {
            InitializeComponent();
            LoadKHDGV();
        }
        public void LoadKHDGV()
        {
            dataGridView1.DataSource = DangKiGoiTapBLL.Instance.FindListDKKHByIDOrName("");
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            AddOrEditFormKH addOrEditFormKH = new AddOrEditFormKH("");
            addOrEditFormKH.ShowDialog();
            LoadKHDGV();
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    int IDKH = KHBLL.Instance.GetUserID(dataGridView1.SelectedRows[0].Cells["CCCD"].Value.ToString());
                    AddOrEditFormKH f = new AddOrEditFormKH(IDKH.ToString());
                    if(f.ShowDialog() == DialogResult.Cancel)
                        LoadKHDGV();
                }
                catch (Exception ex)
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
                            {
                                int IDKH = Convert.ToInt32(i.Cells["ID"].Value.ToString());
                                DateTime ngaydangki = Convert.ToDateTime(i.Cells["NgayDangKi"].Value.ToString());
                                DateTime ngayketthuc = Convert.ToDateTime(i.Cells["NgayKetThuc"].Value.ToString());
                                DangKiGoiTapBLL.Instance.DeleteDKGT(DangKiGoiTapBLL.Instance.GetDKGTByIDKH_NgayDangKi_NgayKetThuc(IDKH, ngaydangki, ngayketthuc));
                                UsersBLL.Instance.DeleteUser(UsersBLL.Instance.GetUserByID(Convert.ToInt32(i.Cells["ID"].Value.ToString())));
                            }
                               
                            LoadKHDGV();
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    int IDKH = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());
                    KH kh = KHDAL.Instance.GetKHByID(IDKH);
                    if (!string.IsNullOrEmpty(kh.Image))
                        pb_kh.Image = Image.FromFile(Application.StartupPath + @"\PersonImage\" + kh.Image);
                    else pb_kh.Image = Image.FromFile(ImagePath);
                }
                catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = DangKiGoiTapBLL.Instance.FindListDKKHByIDOrName(txb_search.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tìm kiếm khách hàng thất bại");
            }
           
        }

        private void btn_sapxep_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = DangKiGoiTapBLL.Instance.SortListDKKHBy(cb_sapxep.Text, DangKiGoiTapBLL.Instance.FindListDKKHByIDOrName(txb_search.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Sắp xếp khách hàng thất bại");
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
