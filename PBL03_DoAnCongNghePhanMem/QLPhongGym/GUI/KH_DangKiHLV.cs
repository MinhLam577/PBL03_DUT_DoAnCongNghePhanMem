using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using QLPhongGym.BLL;
using QLPhongGym.DAL;
using QLPhongGym.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLPhongGym.GUI
{
    public partial class KH_DangKiHLV : Form
    {
        public KH_DangKiHLV()
        {
            
            InitializeComponent();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dateNgayLam_ValueChanged(object sender, EventArgs e)
        {
            cbbCa.Items.Clear();
            cbbHlv.SelectedItem = null;
            cbbma.SelectedItem = null;

        }

        private void KH_DangKiHLV_Load(object sender, EventArgs e)
        {
     
        }
        private void cbbCa_DropDown(object sender, EventArgs e)
        {
            DateTime a = dateNgayLam.Value;
            cbbCa.Items.Clear();
            cbbHlv.SelectedItem = null;
            cbbma.SelectedItem = null;
            cbbCa.Items.AddRange(LichThueBLL.Instance.danhsachcatheongay(a).ToArray());
        }
        int idca = -1;
        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            DateTime a = dateNgayLam.Value;
            cbbHlv.Items.Clear();
            cbbma.SelectedItem = null;

            if (cbbCa.SelectedItem != null)
            {

                
                string cbbtenca = cbbCa.SelectedItem.ToString().Trim();
                idca = DangKiLichLamViecBAL.getInStance.GetIdCa_ByTenCa(cbbtenca);
                cbbHlv.Items.AddRange(DangKiLichLamViecBAL.getInStance.danhsachsinhvientheongayca(a, idca).ToArray());
            }
            else
            {
                MessageBox.Show("Bạn Chưa Điền Ca ");
            }
        }


        private void cbbma_DropDown(object sender, EventArgs e)
        {

            cbbma.Items.Clear();
          
            DateTime ngay = dateNgayLam.Value;
            if (cbbHlv.SelectedItem != null)
            {
              
                string cbbtenca = cbbCa.SelectedItem.ToString().Trim();
                idca = DangKiLichLamViecBAL.getInStance.GetIdCa_ByTenCa(cbbtenca);
                string name = cbbHlv.SelectedItem.ToString().Trim();

                cbbma.Items.AddRange(DangKiLichLamViecBAL.getInStance.danhsachmasinhvientheongayca(ngay, idca, name).ToArray());
            }
            else
            {
                MessageBox.Show("Bạn Chưa Điền Tên Huấn Luyện Viên ");
            }
        }
        public void setForm(string name, int ma)
        {
            textTen.Text = name;
            textMa.Text = ma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            LichThueHLV b = new LichThueHLV();
            if (string.IsNullOrEmpty(textMa.Text))
            {
                MessageBox.Show("Vui lòng nhập giá trị vào textMa.");
                return;
            }

            if (cbbCa.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giá trị từ comboboxCa.");
                return;
            }

            if (cbbma.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn giá trị từ comboboxma.");
                return;
            }
            DateTime ngaylam = dateNgayLam.Value;
            int makh = Convert.ToInt32(textMa.Text.ToString().Trim());
            int idca = -1;
            string cbbtenca = cbbCa.SelectedItem.ToString().Trim();
            idca = DangKiLichLamViecBAL.getInStance.GetIdCa_ByTenCa(cbbtenca);
            int idhlv = Convert.ToInt32(cbbma.SelectedItem.ToString().Trim());

            b.NgayThue = ngaylam;
            b.IDHLV = idhlv;
            b.IDKH = makh;
            b.IDCa = idca;
            if (LichThueBLL.Instance.DangKiThueHLV(b) == true)
            {
                LichThueHLV lthlv = LichThueBLL.Instance.GetLichThueByIDKH_IDHLV_NgayLam_IDCa(makh, idhlv, ngaylam, idca);
                HoaDon hd = new HoaDon
                {
                    IDKH = makh,
                    NgayThanhToan = DateTime.Today,
                    Price = 200000,
                    IDLT = lthlv.IDLT
                };
                HoaDonBLL.Instance.AddHoaDon(hd);
                MessageBox.Show("Đăng Kí Thành Công");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Đã Có Người Thuê");
            }

           
        }
        private void cbbma_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_dongia.Text = "200.000";

        }

        private void cbbCa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
