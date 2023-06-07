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
    public partial class XoaDangKiCaHLV : Form
    {
        public delegate void subtractHLV(DateTime ngaybatdaulam);
        public subtractHLV xoahlv;

        public XoaDangKiCaHLV()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Hàng đầu tiên trên DataGridView đã được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                // can than loi thieu value
                int idhlv = Convert.ToInt32(selectedRow.Cells[1].Value.ToString());
                DateTime ngaylam = Convert.ToDateTime(selectedRow.Cells[3].Value.ToString());
                LichLamViecTrongTuan a = new LichLamViecTrongTuan();
                string ca = cbbCaLam.SelectedItem.ToString();
                int id = Convert.ToInt32(ca.Substring(3, 1));
                a.IDCa = id;
                a.IDHLV = idhlv;
                a.NgayLam = ngaylam;
                if (DangKiLichLamViecBAL.getInStance.Xoa(a) == true)
                {
                    MessageBox.Show("Xoa thanh cong");
                    dataGridView1.DataSource = DangKiLichLamViecBAL.getInStance.ListHLVByCaForm2(ngaylam, id);
                    // cap nhat len data

                    xoahlv(ngaybatdaulamviec);
                }
            }
            else
            {
                MessageBox.Show("Vui long chon hang ");
            }
        }
        public DateTime ngaylamviec1 { get; set; }
        public string ca { get; set; }
        public DateTime ngaybatdau1 { get; set; }
        public DateTime ngayketthuc1 { get; set; }
        DateTime ngaybatdaulamviec;
        private void XoaDangKiCaHLV_Load(object sender, EventArgs e)
        {
            ngaybatdaulamviec = ngaybatdau1;
            ngaylamviec.Value = ngaylamviec1;        
            cbbCaLam.SelectedItem = ca;
            string s = cbbCaLam.SelectedItem.ToString().Trim();
            int id = Convert.ToInt32(s.Substring(3,1));
            dataGridView1.DataSource = DangKiLichLamViecBAL.getInStance.ListHLVByCaForm2(ngaylamviec.Value, id);         
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
