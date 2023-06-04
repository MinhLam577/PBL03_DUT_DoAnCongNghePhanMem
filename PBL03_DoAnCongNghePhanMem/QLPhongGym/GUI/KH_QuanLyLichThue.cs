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
            if (datagrid_LichThue.Rows.Count > 0)
            {
                DataGridViewRow row = datagrid_LichThue.SelectedRows[0];
                int ma = Convert.ToInt32(row.Cells[0].Value.ToString());
                if (LichThueBLL.Instance.xoa(ma) == true)
                {
                    MessageBox.Show("Xoa thanh cong");
                }
                datagrid_LichThue.DataSource = LichThueBLL.Instance.showlich();
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
            // chua fixx loi chon nhieu hang thua

            try
            {
                if (datagrid_LichThue.Rows.Count !=-1 )
                {
                    KH_SuaLich a = new KH_SuaLich();
                    DataGridViewRow row = datagrid_LichThue.SelectedRows[0];
                    int ma = Convert.ToInt32(row.Cells[0].Value.ToString());
                    string tenkhachhang = row.Cells[1].Value.ToString();
                    int idhlv = Convert.ToInt32(row.Cells[2].Value.ToString());
                    string name = row.Cells[3].Value.ToString();
                    DateTime ngaylam = Convert.ToDateTime(row.Cells[4].Value.ToString());
                    int ca = Convert.ToInt32(row.Cells[5].Value.ToString());
                    a.setForm1(ma,tenkhachhang, idhlv, name, ngaylam, ca);
                    a.Show();
                    a.buon += new KH_SuaLich.mydelegate(edit);
                }
                else
                {
                    MessageBox.Show("Chon 1 hang ");
                }
            }
            catch(Exception ex) {
                 
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
