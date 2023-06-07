using QLPhongGym.BLL;
using QLPhongGym.DAL;
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
    public partial class KH_QuanLyLichThue : Form
    {

        public KH_QuanLyLichThue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagrid_LichThue.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = datagrid_LichThue.SelectedCells[0].RowIndex;
                    DataGridViewRow row = datagrid_LichThue.Rows[selectedRowIndex];
                    if (row.Cells[0].Value != null)  // Kiểm tra giá trị của ô không phải là null trước khi chuyển đổi sang kiểu số nguyên
                    {
                        int ma = Convert.ToInt32(row.Cells[0].Value.ToString());
                        if (LichThueBLL.Instance.xoa(ma) == true)
                        {
                            MessageBox.Show("Xoa thanh cong");
                        }
                        datagrid_LichThue.DataSource = LichThueBLL.Instance.showlich();
                    }
                    else
                    {
                        MessageBox.Show("Không Xóa Được");
                    }
                }
                else
                {
                    MessageBox.Show("Không Xóa Được");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa Thất Bại: " + ex.Message);
            }

        }
        private void KH_QuanLyLichThue_Load(object sender, EventArgs e)
        {

            datagrid_LichThue.DataSource = LichThueBLL.Instance.showlich();
            datagrid_LichThue.Columns["IDKH"].Visible = false;
            datagrid_LichThue.Columns["IDHLV"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagrid_LichThue.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = datagrid_LichThue.SelectedCells[0].RowIndex;
                    DataGridViewRow row = datagrid_LichThue.Rows[selectedRowIndex];
                    int ma = 0;
                    string tenkhachhang = "";
                    int idhlv = 0;
                    string name = "";
                    DateTime ngaylam = DateTime.Now;
                    int ca = 0;

                    if (row.Cells[0].Value != null)
                    {
                        ma = Convert.ToInt32(row.Cells[0].Value.ToString());
                    }

                    if (row.Cells[1].Value != null)
                    {
                        tenkhachhang = row.Cells[1].Value.ToString();
                    }

                    if (row.Cells[2].Value != null)
                    {
                        idhlv = Convert.ToInt32(row.Cells[2].Value.ToString());
                    }

                    if (row.Cells[3].Value != null)
                    {
                        name = row.Cells[3].Value.ToString();
                    }

                    if (row.Cells[4].Value != null)
                    {
                        ngaylam = Convert.ToDateTime(row.Cells[4].Value.ToString());
                    }

                    if (row.Cells[5].Value != null)
                    {
                        ca = Convert.ToInt32(row.Cells[5].Value.ToString());
                    }

                    KH_SuaLich a = new KH_SuaLich();
                    a.setForm1(ma, tenkhachhang, idhlv, name, ngaylam, ca);
                    a.Show();
                    a.buon += new KH_SuaLich.mydelegate(edit);
                }
                else
                {
                    MessageBox.Show("Chọn 1 hàng");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
           
        public void edit(int idca, int idhlv, DateTime ngaylam, int idkh)
        {
            try
            {
                DataGridViewRow row = datagrid_LichThue.SelectedRows[0];
                int IDCA = Convert.ToInt32(row.Cells[5].Value.ToString().Trim());
                int IDHLV = Convert.ToInt32(row.Cells[2].Value.ToString().Trim());

                DateTime NgayLam = Convert.ToDateTime(row.Cells[3].Value.ToString().Trim());
                if (IDCA != idca || IDHLV != idhlv || ngaylam != NgayLam)
                {
                    if (LichThueBLL.Instance.Capnhat1(IDCA, IDHLV, NgayLam, idca, idhlv, ngaylam) == true)
                    {
                        MessageBox.Show("Thanh cong ");
                        datagrid_LichThue.DataSource = LichThueBLL.Instance.showlich();

                    }
                    else
                    {
                        MessageBox.Show("That bai ");
                    }
                }
                else if (IDCA == idca && IDHLV == idhlv && ngaylam == NgayLam)
                {
                    MessageBox.Show("Lịch Làm Việc đã tồn tại  ");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Đẫ tồn tại");
            }
           

        }
    }
}
