using QLPhongGym.BLL;
using QLPhongGym.DAL;
using QLPhongGym.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Label = System.Windows.Forms.Label;

namespace QLPhongGym.GUI
{
    public partial class FormLichHLV : Form
    {
        public TK tk { get; set; }
        public int iduser ;
        public FormLichHLV(TK tk)
        {
            this.tk = tk;
            
            InitializeComponent();
            lb_thang.Text = "Tháng " + DateTime.Now.Month.ToString();
            tuanlam();
            labelTheoTuan();
        }
        // ham tru tuan 
        // ham kiem tra nam nhuan 
        private bool namnhuan()
            {
                DateTime namnhuan = dateTimeNgayStart.Value;
                int year = namnhuan.Year;
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
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
            private void dateTimeNgayStart_ValueChanged(object sender, EventArgs e)
            {
               
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
                    // ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
                }
                else if (lbTuanLam.Text == "Tuần 3")
                {
                    DateTime date = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 15);
                    // Thiết lập giá trị của DateTimePicker là ngày vừa tạo
                    dateTimeNgayStart.Value = date;
                    dateTimeNgayEnd.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, 21);
                    //ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
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
                    // Thiết lập giá trị của DateTimePicker là ngày vừa tạo

                }
            }
         
            // xu li them 7 ngay vao 7 label 
            private void labelTheoTuan()
            {

                DateTime startDate = dateTimeNgayStart.Value; // Lấy ngày hôm nay làm ngày bắt đầu
                DateTime endDate = dateTimeNgayEnd.Value;
                int dayend = endDate.Day;
                int daystart = startDate.Day;
                if (daystart != dayend)
                {
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
            // ahihi
            private void btnTest_Click_1(object sender, EventArgs e)
            {
                labelTheoTuan();
                
                //hienlistLabel();
                hienthilenlistboxHang(dateTimeNgayStart.Value);

            }
            public void hienthilenlistboxHang(DateTime dateTimeStart/*, int idca*/)
            {
            int ID = (int)tk.IDUser;
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
                        listBox.Items.AddRange(DangKiLichLamViecBAL.getInStance.getTenHLV_theoNgayCaId(nextDate, 1,ID).ToArray());
                        listBox1.Items.AddRange(DangKiLichLamViecBAL.getInStance.getTenHLV_theoNgayCaId(nextDate, 2, ID).ToArray());
                        listBox2.Items.AddRange(DangKiLichLamViecBAL.getInStance.getTenHLV_theoNgayCaId(nextDate, 3, ID).ToArray());
                        listBox3.Items.AddRange(DangKiLichLamViecBAL.getInStance.getTenHLV_theoNgayCaId(nextDate, 4, ID).ToArray());
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
                        for (j = 0; j <= day; j++)
                        {
                            // hang 1 
                            DateTime nextDate = dateTimeStart.AddDays(j);
                            ListBox listBox5 = (ListBox)Controls.Find("listBox" + (j + 1).ToString(), true)[0];
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
                            listBox5.Items.AddRange(DangKiLichLamViecBAL.getInStance.getTenHLV_theoNgayCaId(nextDate, 1, ID).ToArray());
                            listBox6.Items.AddRange(DangKiLichLamViecBAL.getInStance.getTenHLV_theoNgayCaId(nextDate, 2, ID).ToArray());
                            listBox7.Items.AddRange(DangKiLichLamViecBAL.getInStance.getTenHLV_theoNgayCaId(nextDate, 3, ID).ToArray());
                            listBox8.Items.AddRange(DangKiLichLamViecBAL.getInStance.getTenHLV_theoNgayCaId(nextDate, 4, ID).ToArray());

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
                if (ngayhomnay >= dateTimeNgayStart.Value && ngayhomnay <= (dateTimeNgayEnd.Value))
                {
                    //lbTuanLam.Text = "Tuần 1";
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
                    // lbTuanLam.Text = "Tuần 3";
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
                    //lbTuanLam.Text = "Tuần 4";
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
                    if (ngayhomnay >= dateTimeNgayStart.Value && ngayhomnay <= dateTimeNgayEnd.Value)
                    {
                        // lbTuanLam.Text = "Tuần 5";
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
        private void FormLichHLV_Load(object sender, EventArgs e)
        {
            lbca1.Text = DangKiLichLamViecBAL.getInStance.GetTenCa_ByIdCa(1);
            lbca2.Text = DangKiLichLamViecBAL.getInStance.GetTenCa_ByIdCa(2);
            labelca3.Text = DangKiLichLamViecBAL.getInStance.GetTenCa_ByIdCa(3);
            ca4.Text = DangKiLichLamViecBAL.getInStance.GetTenCa_ByIdCa(4);
            tuanlam();
            labelTheoTuan();
            ngaylamviec.Value = DateTime.Now;
            hienthingayStart_End();
            labelTheoTuan();
            hienthilenlistboxHang(dateTimeNgayStart.Value);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string Sotuan = lbTuanLam.Text.Trim();
            string[] parts = Sotuan.Split(' ');
            int weekNumber = Int32.Parse(parts[1]);
            if (weekNumber < 5)
            {
                lbTuanLam.Text = parts[0] + " " + (++weekNumber);
            }
            //ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
            tuanlam();
            labelTheoTuan();
            ClearListBox();
            hienthilenlistboxHang(dateTimeNgayStart.Value);
        }

        private void btnGiamTuan_Click(object sender, EventArgs e)
        {
            string Sotuan = lbTuanLam.Text.Trim();
            string[] parts = Sotuan.Split(' '); // Tách chuỗi thành mảng các chuỗi con dựa trên ký tự khoảng trắng
            int weekNumber = Int32.Parse(parts[1]);
            if (weekNumber > 1)
            {
                lbTuanLam.Text = parts[0] + " " + (--weekNumber);
            }
            //ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
            tuanlam();
            labelTheoTuan();
            ClearListBox();
            hienthilenlistboxHang(dateTimeNgayStart.Value);
        }
        private void btnGiamThang_Click(object sender, EventArgs e)
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
                    // ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
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
                    // ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
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

        private void btnthangsau_Click_1(object sender, EventArgs e)
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
                if (lbTuanLam.Text == "Tuần 5" && daysInMonth >= 29)
                {
                    dateTimeNgayStart.Value = new DateTime(nam, thang, 29);
                    dateTimeNgayEnd.Value = new DateTime(nam, thang, daysInMonth);
                    // ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
                }
                else if (lbTuanLam.Text == "Tuần 5" && daysInMonth == 28)
                {
                    dateTimeNgayStart.Value = new DateTime(nam, thang, 28);
                    dateTimeNgayEnd.Value = new DateTime(nam, thang, daysInMonth);
                    //ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
                }
                else
                {
                    dateTimeNgayStart.Value = new DateTime(nam, thang, ngaybatdau);
                    dateTimeNgayEnd.Value = new DateTime(nam, thang, ngayketthuc);
                    // ngaylamviec.Value = new DateTime(dateTimeNgayStart.Value.Year, dateTimeNgayStart.Value.Month, dateTimeNgayStart.Value.Day);
                }
            }
            else if (dateTimeNgayStart.Value.Month == 12)
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
    }
}
