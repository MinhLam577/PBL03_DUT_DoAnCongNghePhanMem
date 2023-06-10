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
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
        }
        int lc = -1;
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn chắc chắn muốn xóa ? ", "Xóa ", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    int CatNhat = 0;
                    if (dataGridView1.SelectedCells.Count > 0)
                    {
                        bool check = true;
                        foreach(DataGridViewCell i in dataGridView1.SelectedCells)
                        {
                            if (i.OwningRow.Cells[1].Value != null)
                            {
                                int idHLV = Convert.ToInt32(i.OwningRow.Cells[1].Value.ToString().Trim());
                                CatNhat++;
                                //Xóa tài khoản hlv
                                if (TKHLV_BLL.Instance.FindListTKHLVByIDHLV(idHLV) != null)
                                    foreach (string TenTK in TKHLV_BLL.Instance.FindListTKHLVByIDHLV(idHLV))
                                        TKBLL.Instance.DeleteTK(TKBLL.Instance.GetTKByTenTK(TenTK));

                                //Xóa lịch làm việc hlv
                                if (DangKiLichLamViecBAL.getInStance.GetListLichLamViecByIDHLV(idHLV) != null)
                                    foreach (LichLamViecTrongTuan llv in DangKiLichLamViecBAL.getInStance.GetListLichLamViecByIDHLV(idHLV))
                                        DangKiLichLamViecBAL.getInStance.DeleteLichLamViec(llv);                               

                                //Xóa lịch thuê hlv
                                if (LichThueBLL.Instance.GetLichThueByIDHLV(idHLV) != null)
                                    foreach (LichThueHLV lt in LichThueBLL.Instance.GetLichThueByIDHLV(idHLV))
                                    {
                                        //Xóa hóa đơn lịch thuê
                                        foreach (HoaDon hd in HoaDonBLL.Instance.getListHoaDonByIDLT(lt.IDLT))
                                            HoaDonBLL.Instance.DeleteHoaDon(hd);

                                        //Xóa lịch thuê
                                        LichThueBLL.Instance.DeleteLichThue(lt.IDLT);
                                    }

                                //Xóa huấn luyện viên
                                if (!QLHLVBLL.getInstance.Delete(idHLV))
                                {
                                    check = false;
                                    break;
                                }
                            }
                        }
                        if (check && CatNhat != 0)
                        {
                            MessageBox.Show("Xóa Thành Công");
                            CapNhatListHLV();
                        }
                        else MessageBox.Show("Xóa thất bại");
                    }
                }
                catch (Exception ex)
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
            if (dataGridView1.SelectedCells.Count == 1)
            {
                if (dataGridView1.SelectedCells[0].OwningRow.Cells[1].Value != null)
                {
                    AddEdit_HLV a = new AddEdit_HLV();
                    HLV aa = new HLV();
                    a.luachon(2);
                    inforfromData(aa);
                    a.getinfofromAB(aa);
                    a.Show();
                    a.buon += new AddEdit_HLV.mydelegate(Edit);
                }
                    
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

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells["STT"].Value = ++cnt;
            }
        }
    }
}
