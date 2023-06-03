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
using System.Xml.Linq;

namespace QLPhongGym.GUI
{
    public partial class Admin_FormDanhSachHLV : Form
    {
        public Admin_FormDanhSachHLV()
        {
            InitializeComponent();
        }        
        /*static string ImageLink = Application.StartupPath + @"\Resources\Admin.png";*/
        private void CapNhatListHLV()
        {
            dataGridView1.DataSource = QLHLVBLL.getInstance.CapNhatListHLV();
        }
        int lc = -1;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn chắc chắn muốn xóa ? ", "Xóa ", MessageBoxButtons.OKCancel);          
            if (result == DialogResult.OK)
            {
                try
                {
                    int idHLV = Convert.ToInt32(dataGridView1.SelectedCells[0].OwningRow.Cells[1].Value.ToString().Trim());
                    if (QLHLVBLL.getInstance.Delete(idHLV) == true)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        CapNhatListHLV();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Xóa huấn luyện viên thất bại");
                }
                
            }
        }
        private void Edit(object hlv)
        {
            HLV a = (HLV)hlv;
            if (QLHLVBLL.getInstance.Update(a) == true)
            {
                MessageBox.Show("Sửa thành công");
                CapNhatListHLV();
            }
            else
            {
                MessageBox.Show("Sửa huấn luyện viên thất bại");
            }
        }
        public void inforfromData(HLV a)
        {
                int rowSelected = -1;
                rowSelected = dataGridView1.CurrentRow.Index;
                if(rowSelected != -1) { 
                a.IDUsers = Convert.ToInt32(dataGridView1.Rows[rowSelected].Cells[1].Value);
                a.Name = dataGridView1.Rows[rowSelected].Cells[2].Value.ToString();
                a.DateBorn = Convert.ToDateTime(dataGridView1.Rows[rowSelected].Cells[3].Value.ToString());
                a.Sex = Convert.ToBoolean(dataGridView1.Rows[rowSelected].Cells[4].Value.ToString());
                a.CCCD =(dataGridView1.Rows[rowSelected].Cells[5].Value.ToString());
                a.Gmail = (dataGridView1.Rows[rowSelected].Cells[6].Value.ToString());
                a.Sdt = (dataGridView1.Rows[rowSelected].Cells[7].Value.ToString());
                a.Address = (dataGridView1.Rows[rowSelected].Cells[8].Value.ToString());
                a.BangCap = (dataGridView1.Rows[rowSelected].Cells[9].Value.ToString());
                HLV b = new HLV();
                b = QLHLVBLL.getInstance.GetInfoHLV(a.IDUsers);
                a.Image = b.Image;
            }
            else
            {

            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if ( dataGridView1.CurrentRow.Index !=-1)
            {                
                AddEdit_HLV a = new AddEdit_HLV();
                HLV aa = new HLV();
                a.luachon(2);
                inforfromData(aa);
                a.getinfofromAB(aa);
                a.Show();
                a.buon += new AddEdit_HLV.mydelegate(Edit);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng lại để tiếp tục");
                return;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            AddEdit_HLV a = new AddEdit_HLV();
            a.Show();
            a.buon += new AddEdit_HLV.mydelegate(Add);
            CapNhatListHLV();
         }
         private void Add(object hlv)
         {
            HLV a = (HLV)hlv;
            if (QLHLVBLL.getInstance.Them(a) == true)
            {
                MessageBox.Show("Thêm thành công");
                CapNhatListHLV();
            }
            else
            {
                MessageBox.Show("Thêm huấn luyện viên thất bại");
            }
         }
        private void btnSapXep_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbSort.SelectedItem == null)
                {
                    MessageBox.Show("Bạn chưa nhập giá trị cần tìm kiếm  ", "Thông Báo", MessageBoxButtons.OK);
                    cbbSort.Focus();
                }
                else
                {
                    string textsort = cbbSort.SelectedItem.ToString().Trim();
                    dataGridView1.DataSource = QLHLVBLL.getInstance.SortHLV(textsort, textSearch.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi sắp xếp");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textSearch.Text.Trim();
                dataGridView1.DataSource = QLHLVBLL.getInstance.SearchHLVByNameID(name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi tìm kiếm");
            }

        }
        private void Admin_FormDanhSachHLV_Load_1(object sender, EventArgs e)
        {
            CapNhatListHLV();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
