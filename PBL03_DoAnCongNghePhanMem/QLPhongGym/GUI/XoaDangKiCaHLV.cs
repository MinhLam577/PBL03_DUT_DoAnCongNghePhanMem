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
                if (selectedRow.Cells[1].Value != null && selectedRow.Cells[3].Value != null)
                {
                    int idhlv = Convert.ToInt32(selectedRow.Cells[1].Value.ToString());
                    DateTime ngaylam = Convert.ToDateTime(selectedRow.Cells[3].Value.ToString());
                    LichLamViecTrongTuan a = new LichLamViecTrongTuan();
                    string ca = cbbCaLam.SelectedItem.ToString();
                    int idca = DangKiLichLamViecBAL.getInStance.GetIdCa_ByTenCa(ca);
                    a.IDCa = idca;
                    a.IDHLV = idhlv;
                    a.NgayLam = ngaylam;
                    if (DangKiLichLamViecBAL.getInStance.Xoa(a) == true)
                    {
                        MessageBox.Show("Xoa thanh cong");
                        dataGridView1.DataSource = DangKiLichLamViecBAL.getInStance.ListHLVByCaForm2(ngaylam, idca);
                        xoahlv(ngaybatdaulamviec);
                    }
                }
                else
                {
                    MessageBox.Show("Giá trị ô không hợp lệ.");
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
            cbbCaLam.Items.AddRange(DangKiLichLamViecBAL.getInStance.LayDanhSachCaLamViec().ToArray());
            ngaybatdaulamviec = ngaybatdau1;
            ngaylamviec.Value = ngaylamviec1;        
            cbbCaLam.SelectedItem = ca;
            string tenca = cbbCaLam.SelectedItem.ToString().Trim();
            int id = DangKiLichLamViecBAL.getInStance.GetIdCa_ByTenCa(tenca);
            dataGridView1.DataSource = DangKiLichLamViecBAL.getInStance.ListHLVByCaForm2(ngaylamviec.Value, id);         
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
