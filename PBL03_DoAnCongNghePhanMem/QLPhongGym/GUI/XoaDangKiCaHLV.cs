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
        public event EventHandler XoaThanhCong;
        public XoaDangKiCaHLV()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Hàng đầu tiên trên DataGridView đã được chọn
                    int IDCa = -1;
                    DateTime NgayLam = DateTime.Now;
                    bool check = true;
                    foreach (DataGridViewRow r in dataGridView1.SelectedRows)
                    {
                        if (r.Cells[1].Value != null)
                        {
                            int idhlv = Convert.ToInt32(r.Cells[1].Value.ToString());
                            NgayLam = Convert.ToDateTime(r.Cells[3].Value.ToString());
                            string ca = cbbCaLam.SelectedItem.ToString();
                            IDCa = DangKiLichLamViecBAL.getInStance.GetIdCa_ByTenCa(ca);
                            LichLamViecTrongTuan llv = DangKiLichLamViecBAL.getInStance.GetLLVByIDHLV_IDCa_NgayLam(idhlv, IDCa, NgayLam);
                            if (!DangKiLichLamViecBAL.getInStance.Xoa(llv) == true)
                            {
                                check = false;
                                break;
                            }
                        }
                    }
                    if (check == true && IDCa != -1)
                    {
                        MessageBox.Show("Xoa thanh cong");
                        XoaThanhCong(this, new EventArgs());
                        dataGridView1.DataSource = DangKiLichLamViecBAL.getInStance.ListHLVByCaForm2(NgayLam, IDCa);
                    }
                }
                catch { MessageBox.Show("Xóa lịch làm việc thất bại"); }
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
