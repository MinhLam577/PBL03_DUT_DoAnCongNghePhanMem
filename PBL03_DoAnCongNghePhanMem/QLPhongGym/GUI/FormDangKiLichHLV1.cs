using QLPhongGym.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongGym.GUI
{
    public partial class FormDangKiLichHLV1 : Form
    {
        public FormDangKiLichHLV1()
        {
            InitializeComponent();
            lb_thang.Text = "Tháng " + DateTime.Now.Month.ToString();
            tuanlam();
            labelTheoTuan();

        }
        // ham tru tuan 
        private void button5_Click(object sender, EventArgs e)
        {
            string Sotuan = lbTuanLam.Text.Trim();
            string[] parts = Sotuan.Split(' '); // Tách chuỗi thành mảng các chuỗi con dựa trên ký tự khoảng trắng
            int weekNumber = Int32.Parse(parts[1]);
            if (weekNumber > 1)
            {
                lbTuanLam.Text = parts[0] + " " + (--weekNumber);
            }
            tuanlam();
            labelTheoTuan();
            ClearListBox();
            hienthilenlistboxHang(dateTimeNgayStart.Value);
        }
        // ham cong tuan 
        private void btnthangtruoc_Click(object sender, EventArgs e)
        {
            if (dateTimeNgayStart.Value.Month > 1 && dateTimeNgayStart.Value.Month <= 12)
            {
                int nam = dateTimeNgayStart.Value.Year;
                int thang = dateTimeNgayStart.Value.Month;
                int ngaybatdau = dateTimeNgayStart.Value.Day;
                int ngayketthuc = dateTimeNgayEnd.Value.Day;
                thang = --thang;
                lb_thang.Text = "Tháng " + thang.ToString();
                int daysInMonth = DateTime.DaysInMonth(nam, thang);
                if (lbTuanLam.Text == "Tuần 5" && daysInMonth >= 29)
                {
                    dateTimeNgayStart.Value = new DateTime(nam, thang, 29);
                    dateTimeNgayEnd.Value = new DateTime(nam, thang, daysInMonth);
                }
                else if (lbTuanLam.Text == "Tuần 5" && daysInMonth == 28)
                {
                    dateTimeNgayStart.Value = new DateTime(nam, thang, 28);
                    dateTimeNgayEnd.Value = new DateTime(nam, thang, daysInMonth);
                    ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
                }
                else
                {
                    dateTimeNgayStart.Value = new DateTime(nam, thang, ngaybatdau);
                    dateTimeNgayEnd.Value = new DateTime(nam, thang, ngayketthuc);
                }
            }
            else if (dateTimeNgayStart.Value.Month == 1)
            {
                int nam = dateTimeNgayStart.Value.Year;
                nam--;
                int ngaybatdau = dateTimeNgayStart.Value.Day;
                int ngayketthuc = dateTimeNgayEnd.Value.Day;
                lb_thang.Text = "Tháng " + 12;
                dateTimeNgayStart.Value = new DateTime(nam, 12, ngaybatdau);
                dateTimeNgayEnd.Value = new DateTime(nam, 12, ngayketthuc);
            }

            labelTheoTuan();
            hienthilenlistboxHang(dateTimeNgayStart.Value);
        }
        private void btnthangsau_Click(object sender, EventArgs e)
        {
            if (dateTimeNgayStart.Value.Month >= 1 && dateTimeNgayStart.Value.Month < 12)
            {
                int nam = dateTimeNgayStart.Value.Year;
                int thang = dateTimeNgayStart.Value.Month;
                int ngaybatdau = dateTimeNgayStart.Value.Day;
                int ngayketthuc = dateTimeNgayEnd.Value.Day;
                thang = ++thang;
                lb_thang.Text = "Tháng " + thang.ToString();
                int daysInMonth = DateTime.DaysInMonth(nam, thang);
                if (lbTuanLam.Text == "Tuần 5" && daysInMonth >=29)
                {
                    dateTimeNgayStart.Value = new DateTime(nam, thang, 29);
                    dateTimeNgayEnd.Value = new DateTime(nam, thang, daysInMonth);
                }
                else if(lbTuanLam.Text == "Tuần 5" && daysInMonth ==28 )
                {
                    dateTimeNgayStart.Value = new DateTime(nam, thang, 28);
                    dateTimeNgayEnd.Value = new DateTime(nam, thang, daysInMonth);
                }
                else
                {
                    dateTimeNgayStart.Value = new DateTime(nam, thang, ngaybatdau);
                    dateTimeNgayEnd.Value = new DateTime(nam, thang, ngayketthuc);
                }
            }
            else if(dateTimeNgayStart.Value.Month ==12)
            {
                int nam = dateTimeNgayStart.Value.Year;
                nam++;
                int ngaybatdau = dateTimeNgayStart.Value.Day;
                int ngayketthuc = dateTimeNgayEnd.Value.Day;
                lb_thang.Text = "Tháng " + 1;
                dateTimeNgayStart.Value = new DateTime(nam, 1, ngaybatdau);
                dateTimeNgayEnd.Value = new DateTime(nam, 1, ngayketthuc);
            }
            labelTheoTuan();
            hienthilenlistboxHang(dateTimeNgayStart.Value);
        }
        // ham kiem tra nam nhuan 
        private bool namnhuan( )
        {
            DateTime namnhuan = dateTimeNgayStart.Value;
            int year = namnhuan.Year;
            if(year % 4 ==0 && year % 100 != 0 || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // cong tru ngay lam
        private void btntru_Click(object sender, EventArgs e)
        {
            if (ngaylamviec.Value > dateTimeNgayStart.Value && ngaylamviec.Value <= dateTimeNgayEnd.Value)
            {
                int day = ngaylamviec.Value.Day;
                day = --day;
                ngaylamviec.Value = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, day);
            }
        }
        private void btnCong_Click_1(object sender, EventArgs e)
        {

            if (ngaylamviec.Value >= dateTimeNgayStart.Value && ngaylamviec.Value < dateTimeNgayEnd.Value)
            {
                int day = ngaylamviec.Value.Day;
                day = ++day;
                ngaylamviec.Value = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, day);
            }
        }
        private void tuanlam()
        {
            if (lbTuanLam.Text == "Tuần 1")
            {
                // Tạo một đối tượng DateTime mới với ngày là 1 và giờ phút giây là 0
                DateTime date = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 1);
                // Thiết lập giá trị của DateTimePicker là ngày vừa tạo
                dateTimeNgayStart.Value = date;
                dateTimeNgayEnd.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 7);
            }
            else if (lbTuanLam.Text == "Tuần 2")
            {
                DateTime date = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 8);
                // Thiết lập giá trị của DateTimePicker là ngày vừa tạo
                dateTimeNgayStart.Value = date;
                dateTimeNgayEnd.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 14);
            }
            else if (lbTuanLam.Text == "Tuần 3")
            {
                DateTime date = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 15);
                // Thiết lập giá trị của DateTimePicker là ngày vừa tạo
                dateTimeNgayStart.Value = date;
                dateTimeNgayEnd.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 21);
            }
            else if (lbTuanLam.Text == "Tuần 4")
            {
                DateTime date = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 22);
                // Thiết lập giá trị của DateTimePicker là ngày vừa tạo
                dateTimeNgayStart.Value = date;
                dateTimeNgayEnd.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 28);
            }
            else if (lbTuanLam.Text == "Tuần 5")
            {
                // tinh so ngay trong thang  
                int daysInMonth = DateTime.DaysInMonth(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month);
                if (daysInMonth == 28)
                {
                    DateTime date = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, daysInMonth);
                    dateTimeNgayStart.Value = date;
                    dateTimeNgayEnd.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, daysInMonth);
                }
                else
                {
                    DateTime date = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 29);
                    dateTimeNgayStart.Value = date;
                    dateTimeNgayEnd.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, daysInMonth);
                }
                
            }
        }
        private void FormDangKiLichHLV1_Load(object sender, EventArgs e)
        {
            lbca1.Text = DangKiLichLamViecBAL.getInStance.GetTenCa_ByIdCa(1);
            lbca2.Text = DangKiLichLamViecBAL.getInStance.GetTenCa_ByIdCa(2);
            labelca3.Text = DangKiLichLamViecBAL.getInStance.GetTenCa_ByIdCa(3);
            lbca4.Text = DangKiLichLamViecBAL.getInStance.GetTenCa_ByIdCa(4);
            ngaylamviec.Value = DateTime.Now;
            hienthingayStart_End();
            labelTheoTuan();
            hienthilenlistboxHang(dateTimeNgayStart.Value);
        }
        // xu li them 7 ngay vao 7 label 
        private void labelTheoTuan()
        {

            DateTime startDate = dateTimeNgayStart.Value; // Lấy ngày hôm nay làm ngày bắt đầu
            DateTime endDate = dateTimeNgayEnd.Value;
            int dayend = endDate.Day;
            int daystart = startDate.Day;
            if(daystart != dayend) {
                for (int i = 1; i <= 7; i++)
                {
                    string labelName = "label" + i.ToString();
                    Label label = Controls.Find(labelName, true)[0] as Label; // Tìm Label theo tên
                    DateTime date = startDate.AddDays(i - 1); // Tính toán ngày tương ứng
                    if (date <= dateTimeNgayEnd.Value)
                    {
                        label.Text = date.ToString("dd/MM/yyyy"); // Gán text cho Label
                    }
                    else
                    {
                        label.Text = "";
                    }
                }
            }
        }
        private void btnTest_Click_1(object sender, EventArgs e)
        {
            labelTheoTuan();
            hienthilenlistboxHang(dateTimeNgayStart.Value);
        }
        private void buttontuantiep_Click(object sender, EventArgs e)
        {
            string Sotuan = lbTuanLam.Text.Trim();
            string[] parts = Sotuan.Split(' ');
            int weekNumber = Int32.Parse(parts[1]);
            if (weekNumber < 5)
            {
                lbTuanLam.Text = parts[0] + " " + (++weekNumber);
            }
            tuanlam();
            labelTheoTuan();
            ClearListBox();
            hienthilenlistboxHang(dateTimeNgayStart.Value);
        }
        // ds hlv dang ki ca 
        public void hienthilenlistboxHang(DateTime dateTimeStart)
        {
            int u = 7;
            int v = 14;
            int z = 21;
            int h = 28;
            for (int i = 0; i < 7; i++)
            {
                if (lbTuanLam.Text != "Tuần 5")
                {
                    DateTime nextDate = dateTimeStart.AddDays(i);
                    ListBox listBox = (ListBox)Controls.Find("listBox" + (i + 1).ToString(), true)[0];
                    ListBox listBox1 = (ListBox)Controls.Find("listBox" + (++u).ToString(), true)[0];
                    ListBox listBox2 = (ListBox)Controls.Find("listBox" + (++v).ToString(), true)[0];
                    ListBox listBox3 = (ListBox)Controls.Find("listBox" + (++z).ToString(), true)[0];
                    listBox.Items.Clear();
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    listBox3.Items.Clear();
                    listBox.Items.AddRange(DangKiLichLamViecBAL.getInStance.danhsachsinhvientheongayca(nextDate, 1).ToArray());
                    listBox1.Items.AddRange(DangKiLichLamViecBAL.getInStance.danhsachsinhvientheongayca(nextDate, 2).ToArray());
                    listBox2.Items.AddRange(DangKiLichLamViecBAL.getInStance.danhsachsinhvientheongayca(nextDate, 3).ToArray());
                    listBox3.Items.AddRange(DangKiLichLamViecBAL.getInStance.danhsachsinhvientheongayca(nextDate,4).ToArray());
                }
                else
                // xu li nam nhuan THANG 2
                {
                    // lấy ra ngay bat dau va ket thuc cua thang
                    DateTime DayofTuanStart = dateTimeNgayStart.Value;
                    DateTime DayofTuanEnd = dateTimeNgayEnd.Value;
                    int daystart = DayofTuanStart.Day;
                    int dayend = DayofTuanEnd.Day;
                    int day = dayend - daystart;
                    int j;
                    int j1 = 7, j2 = 14;
                    int j3 = 21;
                    for( j = 0; j <= day; j++)
                    {
                        // hang 1 
                        DateTime nextDate = dateTimeStart.AddDays(j);
                        ListBox listBox5 = (ListBox)Controls.Find("listBox" + (j+1).ToString(), true)[0];
                        // hang 2 
                        ListBox listBox6 = (ListBox)Controls.Find("listBox" + (++j1).ToString(), true)[0];
                        // hang 3
                        ListBox listBox7 = (ListBox)Controls.Find("listBox" + (++j2).ToString(), true)[0];
                        // hang 4
                        ListBox listBox8 = (ListBox)Controls.Find("listBox" + (++j3).ToString(), true)[0];
                        listBox5.Items.Clear();
                        listBox6.Items.Clear();
                        listBox7.Items.Clear();
                        listBox8.Items.Clear();
                        listBox5.Items.AddRange(DangKiLichLamViecBAL.getInStance.danhsachsinhvientheongayca(nextDate, 1).ToArray());
                        listBox6.Items.AddRange(DangKiLichLamViecBAL.getInStance.danhsachsinhvientheongayca(nextDate, 2).ToArray());
                        listBox7.Items.AddRange(DangKiLichLamViecBAL.getInStance.danhsachsinhvientheongayca(nextDate, 3).ToArray());
                        listBox8.Items.AddRange(DangKiLichLamViecBAL.getInStance.danhsachsinhvientheongayca(nextDate, 4).ToArray());

                    }                  
                }
            }
        }
        private void ClearListBox()
        {
            for (int i = 1; i <= 21; i++)
            {
                ListBox listBox = (ListBox)Controls.Find("listBox" + (i).ToString(), true)[0];
                listBox.Items.Clear();
            }
        }
        private void butncong1_Click(object sender, EventArgs e)
        {
            try
            {
                btnCong(label1.Text, 1);
            }
            catch
            {

            }
           
        }

        private void btntru1_Click(object sender, EventArgs e)
        {

            btntru(label1.Text, 1);
        }
        private void btncong2_Click(object sender, EventArgs e)
        {
            try
            {
                btnCong(label2.Text, 1);
            }
            catch
            {

            }
        }
        private void btntru2_Click(object sender, EventArgs e)
        {
            btntru(label2.Text, 1);
        }

        private void btncong3_Click(object sender, EventArgs e)
        {
            try{
                btnCong(label3.Text, 1);
            }
            catch
            {

            }
        }
        private void btntru3_Click(object sender, EventArgs e)
        {
            btntru(label3.Text, 1);

        }

        private void btncong4_Click(object sender, EventArgs e)
        {
            btnCong(label4.Text, 1);

        }

        private void btntru4_Click(object sender, EventArgs e)
        {
            btntru(label4.Text, 1);
        }

        private void btncong5_Click(object sender, EventArgs e)
        {
            btnCong(label5.Text, 1);
        }

        private void btntru5_Click(object sender, EventArgs e)
        {
            btntru(label5.Text, 1);
        }

        private void btncong6_Click(object sender, EventArgs e)
        {
            btnCong(label6.Text, 1);
        }

        private void btntru6_Click(object sender, EventArgs e)
        {
            btntru(label6.Text, 1);
        }
        private void btncong7_Click(object sender, EventArgs e)
        {
            btnCong(label7.Text, 1);
        }
        private void btntru7_Click(object sender, EventArgs e)
        {
            btntru(label7.Text, 1);
        }
        // ham tru
        private void btntru(string a, int idca )
        {
            XoaDangKiCaHLV A = new XoaDangKiCaHLV();
            string dateString1 = a;
            // Định dạng ngày tháng ban đầu
            string format = "dd/MM/yyyy";
            // Chuyển đổi chuỗi thành kiểu DateTime
            DateTime date1 = DateTime.ParseExact(dateString1, format, CultureInfo.InvariantCulture);
            // Định dạng kiểu DateTime thành chuỗi mới với định dạng "yyyy-MM-dd"
            string newDateString = date1.ToString("yyyy-MM-dd");        
            A.ngaylamviec1 = Convert.ToDateTime(newDateString);
            A.ngaybatdau1 = dateTimeNgayStart.Value;
            string ca = DangKiLichLamViecBAL.getInStance.GetTenCa_ByIdCa(idca);
            A.ca = ca;
            A.Show();
            A.XoaThanhCong += (o, ev) =>
            {
                hienthilenlistboxHang((o as XoaDangKiCaHLV).ngaybatdau1);
            };
        }
        // btncong
        private void btnCong(string a, int idca)
        {
            XepLichHLV A = new XepLichHLV();
            // Chuỗi ngày tháng ban đầu
            string dateString1 = a;
            // Định dạng ngày tháng ban đầu
            string format = "dd/MM/yyyy";
            // Chuyển đổi chuỗi thành kiểu DateTime
            DateTime date1 = DateTime.ParseExact(dateString1, format, CultureInfo.InvariantCulture);
            // Định dạng kiểu DateTime thành chuỗi mới với định dạng "yyyy-MM-dd"
            string newDateString = date1.ToString("yyyy-MM-dd");
            A.ngaylamviec1 = Convert.ToDateTime(newDateString);
            string ca = DangKiLichLamViecBAL.getInStance.GetTenCa_ByIdCa(idca);
            A.ca = ca;
            A.ngaybatdau1 = dateTimeNgayStart.Value;
            A.ngayketthuc1 = dateTimeNgayEnd.Value;
            A.Show();
            A.HLVDelegate = new XepLichHLV.AddHLVToListBox(hienthilenlistboxHang);
        }
        private void btncong8_Click(object sender, EventArgs e)
        {
            btnCong(label1.Text, 2);
        }
        private void btntru8_Click(object sender, EventArgs e)
        {
            btntru(label1.Text, 2);
        }
        private void btncong9_Click(object sender, EventArgs e)
        {
            btnCong(label2.Text, 2);
        }
        private void btntru9_Click(object sender, EventArgs e)
        {
            btntru(label2.Text, 2);
        }
        private void btncong10_Click(object sender, EventArgs e)
        {
            btnCong(label3.Text,  2);
        }
        private void btntru10_Click(object sender, EventArgs e)
        {
            btntru(label3.Text, 2);
        }
        private void btncong11_Click(object sender, EventArgs e)
        {
            btnCong(label4.Text, 2);
        }
        private void btntru11_Click(object sender, EventArgs e)
        {
            btntru(label4.Text, 2);
        }
        private void btncong12_Click(object sender, EventArgs e)
        {
            btnCong(label5.Text,  2);
        }
        private void btntru12_Click(object sender, EventArgs e)
        {
            btntru(label5.Text, 2);
        }
        private void btncong13_Click(object sender, EventArgs e)
        {
            btnCong(label6.Text, 2);
        }
        private void btntru13_Click(object sender, EventArgs e)
        {
            btntru(label6.Text,  2);
        }
        private void btn14_Click(object sender, EventArgs e)
        {
            btnCong(label7.Text, 2);
        }

        private void btntru14_Click(object sender, EventArgs e)
        {
            btntru(label7.Text, 2);
        }
        private void btncong15_Click(object sender, EventArgs e)
        {
            btnCong(label1.Text, 3);
        }
        private void btntru15_Click(object sender, EventArgs e)
        {
            btntru(label1.Text,  3);
        }
        private void btncong16_Click(object sender, EventArgs e)
        {
            btnCong(label2.Text,  3);
        }

        private void btntru16_Click(object sender, EventArgs e)
        {
            btntru(label2.Text,3);
        }
        private void btncong17_Click(object sender, EventArgs e)
        {
            btnCong(label3.Text,  3);
        }
        private void btntru17_Click(object sender, EventArgs e)
        {
            btntru(label3.Text, 3);
        }

        private void btncong18_Click(object sender, EventArgs e)
        {
            btnCong(label4.Text, 3);
        }
        private void btntru18_Click(object sender, EventArgs e)
        {
            btntru(label4.Text,  3);
        }

        private void btncong19_Click(object sender, EventArgs e)
        {
            btnCong(label5.Text, 3);
        }
        private void btntru19_Click(object sender, EventArgs e)
        {
            btntru(label5.Text, 3);
        }

        private void btncong20_Click(object sender, EventArgs e)
        {
            btnCong(label6.Text,  3);
        }
        private void btntru20_Click(object sender, EventArgs e)
        {
            btntru(label6.Text,3);
        }
        private void btncong21_Click(object sender, EventArgs e)
        {
            btnCong(label7.Text, 3);
        }
        private void btntru21_Click(object sender, EventArgs e)
        {
            btntru(label7.Text,  3);
        }
        // hien thi ngaybat dau , ngay ket thuc ben form kia
        private void hienthingayStart_End()
        {
            if (checkdisplaytuan1(ngaylamviec.Value) == true)
            {
                lbTuanLam.Text = "Tuần 1";
            }
            else if (checkdisplaytuan2(ngaylamviec.Value) == true)
            {
                lbTuanLam.Text = "Tuần 2";
            }
            else if (checkdisplaytuan3(ngaylamviec.Value) == true)
            {
                lbTuanLam.Text = "Tuần 3";
            }
            else if (checkdisplaytuan4(ngaylamviec.Value) == true)
            {
                lbTuanLam.Text = "Tuần 4";
            }
            else if (checkdisplaytuan5(ngaylamviec.Value) == true)
            {
                lbTuanLam.Text = "Tuần 5";
            }
        }
        private bool checkdisplaytuan1(DateTime ngayhomnay)
        {
            
            DateTime date = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, 1);
            dateTimeNgayStart.Value = date;
            dateTimeNgayEnd.Value = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, 7);
            if (ngayhomnay >= dateTimeNgayStart.Value && ngayhomnay <= (dateTimeNgayEnd.Value)) {
                return true;
            }
            return false;
        }
        private bool checkdisplaytuan2(DateTime ngayhomnay)
        {

            DateTime date = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, 8);
            dateTimeNgayStart.Value = date;
            dateTimeNgayEnd.Value = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, 14);
            if (ngayhomnay >= dateTimeNgayStart.Value && ngayhomnay <= (dateTimeNgayEnd.Value))
            {
                return true;
            }
            return false;
        }
        private bool checkdisplaytuan(DateTime ngayhomnay)
        {

            DateTime date = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, 1);
            dateTimeNgayStart.Value = date;
            dateTimeNgayEnd.Value = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, 7);
            if (ngayhomnay >= dateTimeNgayStart.Value && ngayhomnay <= (dateTimeNgayEnd.Value))
            {
                return true;
            }
            return false;
        }
        private bool checkdisplaytuan3(DateTime ngayhomnay)
        {

            DateTime date = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, 15);
            dateTimeNgayStart.Value = date;
            dateTimeNgayEnd.Value = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, 21);
            if (ngayhomnay >= dateTimeNgayStart.Value && ngayhomnay <= (dateTimeNgayEnd.Value))
            {
                return true;
            }
            return false;
        }
        private bool checkdisplaytuan4(DateTime ngayhomnay)
        {

            DateTime date = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 22);
            dateTimeNgayStart.Value = date;
            dateTimeNgayEnd.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 28);
            if (ngayhomnay >= dateTimeNgayStart.Value && ngayhomnay <= (dateTimeNgayEnd.Value))
            {
                return true;
            }
            return false;
        }

        private bool checkdisplaytuan5(DateTime ngayhomnay)
        {

           //tinh so ngay trong thang
                int daysInMonth = DateTime.DaysInMonth(ngaylamviec.Value.Year, ngaylamviec.Value.Month);
            if (daysInMonth == 28)
            {
                DateTime date = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, daysInMonth);
                dateTimeNgayStart.Value = date;
                dateTimeNgayEnd.Value = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, daysInMonth);
                if(ngayhomnay >= dateTimeNgayStart.Value && ngayhomnay <= dateTimeNgayEnd.Value)
                {
                    return true;
                }
            }
            else
            {
                DateTime date = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, 29);
                dateTimeNgayStart.Value = date;
                dateTimeNgayEnd.Value = new DateTime(ngaylamviec.Value.Year, ngaylamviec.Value.Month, daysInMonth);
                return true;
            }
            return false;
        }
        private void btncong22_Click(object sender, EventArgs e)
        {
            btnCong(label1.Text,4);
        }
        private void btntru22_Click(object sender, EventArgs e)
        {
            btntru(label1.Text, 4);
        }

        private void btncong23_Click(object sender, EventArgs e)
        {
            btnCong(label2.Text, 4);
        }
        private void btntru23_Click(object sender, EventArgs e)
        {
            btntru(label2.Text, 4);
        }
        private void btncong24_Click(object sender, EventArgs e)
        {
            btnCong(label3.Text,  4);
        }

        private void btntru24_Click(object sender, EventArgs e)
        {
            btntru(label3.Text,4);
        }
        private void btncong25_Click(object sender, EventArgs e)
        {
            btnCong(label4.Text,  4);
        }

        private void btntru25_Click(object sender, EventArgs e)
        {
            btntru(label4.Text, 4);
        }
        private void btncong26_Click(object sender, EventArgs e)
        {
            btnCong(label5.Text, 4);
        }
        private void btntru26_Click(object sender, EventArgs e)
        {
            btntru(label5.Text, 4);
        }

        private void btncong27_Click(object sender, EventArgs e)
        {
            btnCong(label6.Text, 4);
        }
        private void btntru27_Click(object sender, EventArgs e)
        {
            btntru(label6.Text, 4);
        }
        private void btncong28_Click(object sender, EventArgs e)
        {
            btnCong(label7.Text, 4);
        }
        private void bntru28_Click(object sender, EventArgs e)
        {
            btntru(label7.Text,  4);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btntru(label1.Text, 4);
        }
        private void lbTuanLam_Click_1(object sender, EventArgs e)
        { 
        }
        private void button3_Click(object sender, EventArgs e)
        {
            btntru(label5.Text, 4);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            btntru(label1.Text, 4);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            btnCong(label1.Text, 4);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            btnCong(label5.Text, 4);
        }
    }
}       
