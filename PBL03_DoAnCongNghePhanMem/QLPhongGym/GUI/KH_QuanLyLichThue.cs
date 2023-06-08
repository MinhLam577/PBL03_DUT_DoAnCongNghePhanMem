using QLPhongGym.BLL;
using QLPhongGym.DAL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
        public int idkh;
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
                        datagrid_LichThue.DataSource = LichThueBLL.Instance.ShowListKH_DkiHLV(idkh);
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

            datagrid_LichThue.DataSource = LichThueBLL.Instance.ShowListKH_DkiHLV(idkh);
            datagrid_LichThue.Columns["IDKH"].Visible = false;
            datagrid_LichThue.Columns["IDHLV"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (datagrid_LichThue.SelectedCells.Count > 0)
            {
                try
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
                    string tenca = "";
                    if (row.Cells[5].Value != null)
                    {
                        tenca = (row.Cells[5].Value.ToString().Trim());
                        ca = DangKiLichLamViecBAL.getInStance.GetIdCa_ByTenCa(tenca);
                    }

                    KH_SuaLich a = new KH_SuaLich();
                    a.setForm1(ma, tenkhachhang, idhlv, name, ngaylam, ca);
                    a.Show();
                    a.buon += new KH_SuaLich.mydelegate(Edit);
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chọn 1 hàng");
            }
        }

        public void Edit(int idca, int idhlv, DateTime ngaylam, int idkh)
        {

            DataGridViewRow row = datagrid_LichThue.SelectedRows[0];
            int IDHLV = Convert.ToInt32(row.Cells[2].Value.ToString().Trim());
            DateTime NgayLam = Convert.ToDateTime(row.Cells[4].Value.ToString().Trim());
            string TENCA = (row.Cells[5].Value.ToString().Trim());
            int IDCA = DangKiLichLamViecBAL.getInStance.GetIdCa_ByTenCa(TENCA);
            if (LichThueBLL.Instance.SuaLichThueHLv(IDHLV, NgayLam, IDCA, idhlv, ngaylam, idca) == true)
            {
                MessageBox.Show("Thay Đổi Thành Công");
                datagrid_LichThue.DataSource = LichThueBLL.Instance.ShowListKH_DkiHLV(idkh);
            }
            else
            {
                MessageBox.Show("Đã tồn tại");
            }
        }  
    }
}
