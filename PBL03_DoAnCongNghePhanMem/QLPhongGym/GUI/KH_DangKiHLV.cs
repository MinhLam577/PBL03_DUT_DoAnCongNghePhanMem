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

        private void cbbCa_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void dateNgayLam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KH_DangKiHLV_Load(object sender, EventArgs e)
        {
            
        }

        private void cbbCa_DropDown(object sender, EventArgs e)
        {
            DateTime a = dateNgayLam.Value;
            //oki
            cbbCa.Items.Clear();
            cbbCa.Items.AddRange(LichThueBLL.Instance.danhsachcatheongay(a).ToArray());
        }
        int id = -1;
        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            DateTime a = dateNgayLam.Value;
            cbbHlv.Items.Clear();
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
            DateTime ngaylam = dateNgayLam.Value;
            int makh = Convert.ToInt32(textMa.Text.ToString().Trim());
            int idca = -1;
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
            idca = id;
            int idhlv = Convert.ToInt32(cbbma.SelectedItem.ToString().Trim());

            b.NgayThue = ngaylam;
            b.IDHLV = idhlv;
            b.IDKH = makh;
            b.IDCa = idca;
            if (LichThueBLL.Instance.DangKiThueHLV(b) == true)
            {
                MessageBox.Show("Đăng Kí Thành Công");
            }
            else
            {
                MessageBox.Show("Đã Có Người Thuê");
            }

            this.Dispose();

        }
        public void setForm1(int makh, int idhlv,string name,DateTime ngaylam,int ca)
        {
            textMa.Text = makh.ToString();
            dateNgayLam.Value = ngaylam;

           
           
            //oki
           /* cbbCa.Items.Clear();
            cbbCa.Items.AddRange(LichThueBLL.Instance.danhsachcatheongay(ngaylam).ToArray());
*/
            string tenca = "";
            if(id == 1)
            {
                tenca = "Ca 1";
            }
            else if(id ==2)
            {
                tenca = "Ca 2";
            }
            else if(id == 3)
            {
                tenca = "Ca 3";
            }
            else
            {
                tenca = "Ca 4";
            }
            cbbCa.SelectedItem= tenca;
            cbbHlv.SelectedItem = name;
            lb_dongia.Text = "200.000";


        }
        

        private void cbbma_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_dongia.Text = "200.000";

        }

    }
}
