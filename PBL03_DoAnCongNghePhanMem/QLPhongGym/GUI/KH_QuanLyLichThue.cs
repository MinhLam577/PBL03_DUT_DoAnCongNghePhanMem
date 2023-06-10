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
                    if (datagrid_LichThue.SelectedRows[0].Cells[1].Value != null)
                    {
                        bool check = true;
                        switch (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                        {
                            case DialogResult.OK:
                                foreach (DataGridViewRow row in datagrid_LichThue.SelectedRows)
                                {
                                    int IDKH = Convert.ToInt32(row.Cells["IDKH"].Value.ToString());
                                    int IDHLV = Convert.ToInt32(row.Cells["IDHLV"].Value.ToString());
                                    DateTime NgayLam = Convert.ToDateTime(row.Cells["NgayLam"].Value.ToString()).Date;
                                    int IDCa = Convert.ToInt32(DangKiLichLamViecBAL.getInStance.GetCaLamViecByTenCa(row.Cells["Tên Ca"].Value.ToString()).IDCa);
                                    LichThueHLV lt = LichThueBLL.Instance.GetLichThueByIDKH_IDHLV_NgayLam_IDCa(IDKH, IDHLV, NgayLam, IDCa);

                                    //Xóa hóa đơn
                                    foreach (HoaDon hd in HoaDonBLL.Instance.getListHoaDonByIDLT(lt.IDLT))
                                        HoaDonBLL.Instance.DeleteHoaDon(hd);

                                    //Xóa lịch thuê
                                    if (lt != null)
                                        LichThueBLL.Instance.DeleteLichThue(lt.IDLT);
                                    else
                                    {
                                        check = false;
                                        break;
                                    }
                                }
                                if (check)
                                    datagrid_LichThue.DataSource = LichThueBLL.Instance.ShowListKH_DkiHLV(idkh);
                                else { MessageBox.Show("Xóa thất bại"); }
                                break;
                            case DialogResult.Cancel:
                                break;
                        }
                    }
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
            if (datagrid_LichThue.SelectedRows.Count == 1)
            {
                if (datagrid_LichThue.SelectedRows[0].Cells[0].Value != null)
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
                        if (selectedRowIndex != -1)
                        {
                            KH_SuaLich a = new KH_SuaLich();
                            a.setForm1(ma, tenkhachhang, idhlv, name, ngaylam, ca);
                            a.Show();
                            a.buon += new KH_SuaLich.mydelegate(Edit);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }

            }
        }
        // idca : đã thay đổi , idhlv 
        // IDCa : lấy trên hàng 
        public void Edit(int idca, int idhlv, DateTime ngaylam, int idkh)
        {

            DataGridViewRow row = datagrid_LichThue.SelectedRows[0];

            int IDKH = Convert.ToInt32(row.Cells["IDKH"].Value.ToString());
            int IDHLV = Convert.ToInt32(row.Cells[2].Value.ToString().Trim());
            DateTime NgayLam = Convert.ToDateTime(row.Cells[4].Value.ToString().Trim());
            string TENCA = (row.Cells[5].Value.ToString().Trim());
            int IDCA = DangKiLichLamViecBAL.getInStance.GetIdCa_ByTenCa(TENCA);
            try
            {
                // 
                if (IDCA != idca || IDHLV != idhlv || ngaylam != NgayLam)
                {

                    if (DangKiLichLamViecBAL.getInStance.Capnhat2(IDCA, IDHLV, NgayLam, idca, idhlv, ngaylam) == true)
                    {
                        MessageBox.Show("Cap Nhat thanh cong ");
                        datagrid_LichThue.DataSource = LichThueBLL.Instance.ShowListKH_DkiHLV(idkh);
                    }
                    else
                    {
                        MessageBox.Show("Da ton tai");
                    }
                }
                else if (IDCA == idca && IDHLV == idhlv && ngaylam == NgayLam)
                {
                    MessageBox.Show("Lịch Thuê Làm Việc Đã Tồn Tại  ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có người thuê rồi ");
            }
        }
    }
}


