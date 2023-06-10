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
using QLPhongGym.BLL;
using QLPhongGym.DAL;
using QLPhongGym.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLPhongGym.GUI
{
    public partial class KH_SuaLich : Form
    {
        public delegate void mydelegate(int idca, int idhlv, DateTime ngaylam, int idkh);
        public mydelegate buon;
        public KH_SuaLich()
        {
           
            InitializeComponent();

        }
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            LichThueHLV b = new LichThueHLV();
            DateTime ngaylam = dateNgayLam.Value;
            int makh = Convert.ToInt32(textMa.Text.ToString().Trim());
            try
            {
                if (!string.IsNullOrEmpty(textMa.Text) && cbbCa.SelectedItem != null && cbbma.SelectedItem != null && cbbHlv.SelectedItem != null)
                {
                    int idca = -1;
                    string cbbtenca = cbbCa.SelectedItem.ToString().Trim();
                    idca = DangKiLichLamViecBAL.getInStance.GetIdCa_ByTenCa(cbbtenca);
                    int idhlv = Convert.ToInt32(cbbma.SelectedItem.ToString().Trim());
                    b.NgayThue = ngaylam;
                    b.IDHLV = idhlv;
                    b.IDKH = makh;
                    b.IDCa = idca;
                    buon(idca, idhlv, ngaylam, makh);
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Đã tồn tại Lịch Thuê Huấn Luyện Viên");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Dispose();
        }
        public void setForm1(int makh,string tenkhachhang, int idhlv, string name, DateTime ngaylam, int ca)
        {
            textMa.Text = makh.ToString();
            dateNgayLam.Value = ngaylam;
            textTen.Text = tenkhachhang;
            cbbCa.Items.Clear();
            cbbCa.Items.AddRange(LichThueBLL.Instance.danhsachcatheongay(ngaylam).ToArray());
            string tenca = "";
            tenca = DangKiLichLamViecDAL.getInStance.GetTenCa_ByIdCa(ca);
            cbbCa.SelectedItem = tenca;
            cbbHlv.Items.AddRange(DangKiLichLamViecBAL.getInStance.danhsachsinhvientheongayca(ngaylam, ca).ToArray());
            cbbma.Items.AddRange(DangKiLichLamViecBAL.getInStance.danhsachmasinhvientheongayca(ngaylam, ca, name).ToArray());
            cbbma.SelectedItem = idhlv.ToString();

            cbbHlv.SelectedItem = name;
            lb_dongia.Text = "200.000";
        }
       private void cbbCa_DropDown(object sender, EventArgs e)
        {
            DateTime a = dateNgayLam.Value;
            cbbCa.Items.Clear();
            cbbHlv.SelectedItem = null;
            cbbma.SelectedItem = null;
            cbbCa.Items.AddRange(LichThueBLL.Instance.danhsachcatheongay(a).ToArray());
        }
        private void cbbHlv_DropDown(object sender, EventArgs e)
        {
            DateTime a = dateNgayLam.Value;
            cbbHlv.Items.Clear();
            cbbma.SelectedItem = null;
            int idca = -1;
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
            DateTime ngay = dateNgayLam.Value;       
            cbbma.Items.Clear();
            if (cbbHlv.SelectedItem != null)
            {
                int idca = -1;
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

        private void KH_SuaLich_Load(object sender, EventArgs e)
        {
    
        }

        private void cbbHlv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbCa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dateNgayLam_ValueChanged(object sender, EventArgs e)
        {
            cbbCa.Items.Clear();
            cbbHlv.SelectedItem = null;
            cbbma.SelectedItem = null;
        }
    }
}
