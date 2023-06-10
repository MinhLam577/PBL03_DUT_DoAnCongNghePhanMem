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
        public event EventHandler XoaThanhCong;
        public XoaDangKiCaHLV()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[1].Value != null)
                {
                    int IDCa = -1;
                    DateTime NgayLam = DateTime.Now;
                    bool check = true;
                    switch (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                    {
                        case DialogResult.OK:
                            foreach (DataGridViewRow selectedRow in dataGridView1.SelectedRows)
                            {
                                if (selectedRow.Cells["IDMaHLV"] != null && selectedRow.Cells["IDMaHLV"].Value != null)
                                {
                                    int idhlv = Convert.ToInt32(selectedRow.Cells["IDMaHLV"].Value.ToString());
                                    NgayLam = Convert.ToDateTime(selectedRow.Cells["NgayLam"].Value.ToString());
                                    string ca = cbbCaLam.SelectedItem.ToString();
                                    IDCa = DangKiLichLamViecBAL.getInStance.GetIdCa_ByTenCa(ca);
                                    LichLamViecTrongTuan llv = DangKiLichLamViecBAL.getInStance.GetLLVByIDHLV_IDCa_NgayLam(idhlv, IDCa, NgayLam);
                                    if (!DangKiLichLamViecBAL.getInStance.Xoa(llv))
                                    {
                                        check = false;
                                        break;
                                    }
                                }
                            }
                            if (check && IDCa != -1)
                            {

                                dataGridView1.DataSource = DangKiLichLamViecBAL.getInStance.ListHLVByCaForm2(NgayLam, IDCa);
                                MessageBox.Show("Xóa thành công");
                                XoaThanhCong(this, new EventArgs());
                            }

                            break;
                        case DialogResult.Cancel:
                            break;
                    }
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
