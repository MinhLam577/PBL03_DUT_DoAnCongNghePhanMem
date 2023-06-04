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

        private void KH_SuaLich_Load(object sender, EventArgs e)
        {
       /*     cbbCa.Items.Clear();
            List<string> itemList = new List<string>
              {
              "Ca 1",
              "Ca 2",
              "Ca 3",
              "Ca 4"
              };

            cbbCa.Items.AddRange(itemList.ToArray());*/
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            LichThueHLV b = new LichThueHLV();
            DateTime ngaylam = dateNgayLam.Value;
            int makh = Convert.ToInt32(textMa.Text.ToString().Trim());
            int id = -1;

            if (cbbCa.SelectedItem != null)
            {
                if (cbbCa.SelectedItem.ToString().Trim() == "Ca 1")
                {
                    id = 1;
                }
                else if (cbbCa.SelectedItem.ToString().Trim() == "Ca 2")
                {
                    id = 2;
                }
                else if (cbbCa.SelectedItem.ToString().Trim() == "Ca 3")
                {
                    id = 3;
                }
                else if (cbbCa.SelectedItem.ToString().Trim() == "Ca 4")
                {
                    id = 4;
                }
                int idhlv = Convert.ToInt32(cbbma.SelectedItem.ToString().Trim());

                b.NgayThue = ngaylam;
                b.IDHLV = idhlv;
                b.IDKH = makh;
                b.IDCa = id;
                buon(id, idhlv, ngaylam, makh);

                this.Dispose();
            }
            else
            {
                // Xử lý khi SelectedItem là null
                MessageBox.Show("Giá trị từ combobox không tồn tại.");
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


            List<string> itemList = new List<string>
              {
              "Ca 1",
              "Ca 2",
              "Ca 3"
              };

            cbbCa.Items.AddRange(itemList.ToArray());

            //oki
             cbbCa.Items.Clear();
             cbbCa.Items.AddRange(LichThueBLL.Instance.danhsachcatheongay(ngaylam).ToArray());
            string tenca = "";
            if (ca == 1)
            {
                tenca = "Ca 1";
            }
            else if (ca == 2)
            {
                tenca = "Ca 2";
            }
            else if (ca == 3)
            {
                tenca = "Ca 3";
            }
            else
            {
                tenca = "Ca 4";
            }

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
            //oki
            cbbCa.Items.Clear();
            cbbCa.Items.AddRange(LichThueBLL.Instance.danhsachcatheongay(a).ToArray());
        }

        private void cbbHlv_DropDown(object sender, EventArgs e)
        {
            DateTime a = dateNgayLam.Value;
            cbbHlv.Items.Clear();
            int id = -1;
            if (cbbCa.SelectedItem != null)
            {

                if (cbbCa.SelectedItem.ToString() == "Ca 1")
                {
                    id = 1;
                }
                else if (cbbCa.SelectedItem.ToString() == "Ca 2")
                {
                    id = 2;
                }
                else if (cbbCa.SelectedItem.ToString() == "Ca 3")
                {
                    id = 3;
                }
                else
                {
                    id = 4;
                }
                cbbHlv.Items.AddRange(DangKiLichLamViecBAL.getInStance.danhsachsinhvientheongayca(a, id).ToArray());
            }
            else
            {
                MessageBox.Show("Bạn Chưa Điền Ca ");
            }
        }

        private void cbbma_DropDown(object sender, EventArgs e)
        {
            DateTime ngay = dateNgayLam.Value;
            int id = -1;
            cbbma.Items.Clear();
            if (cbbHlv.SelectedItem != null)
            {

                if (cbbCa.SelectedItem.ToString() == "Ca 1")
                {
                    id = 1;
                }
                else if (cbbCa.SelectedItem.ToString() == "Ca 2")
                {
                    id = 2;
                }
                else if (cbbCa.SelectedItem.ToString() == "Ca 3")
                {
                    id = 3;
                }
                else
                {
                    id = 4;
                }
                string name = cbbHlv.SelectedItem.ToString().Trim();

                cbbma.Items.AddRange(DangKiLichLamViecBAL.getInStance.danhsachmasinhvientheongayca(ngay, id, name).ToArray());
            }
            else
            {
                MessageBox.Show("Bạn Chưa Điền Tên Huấn Luyện Viên ");
            }
        }
    }
}
