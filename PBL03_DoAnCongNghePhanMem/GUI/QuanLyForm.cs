using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class QuanLyForm : Form
    {
        AccountBUS accbus = new AccountBUS();
        AdminBUS adbus = new AdminBUS();
        DataTable dt;
        string strcon = "Data Source=SKY;Initial Catalog=QLPhongGym;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlcon = null;
        SqlDataAdapter sqladt = null;
        SqlCommand sqlcmd = null;
        public QuanLyForm()
        {
            InitializeComponent();
            LoadDGV();
        }
        public SqlConnection GetConnect()
        {
            if (sqlcon == null)
                sqlcon = new SqlConnection(strcon);
            return sqlcon;
        }

        public SqlDataAdapter Getadt(string query)
        {
            try
            {
                sqlcon = GetConnect();
                sqladt = new SqlDataAdapter(query, sqlcon);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return sqladt;
        }
        public void LoadDGV()
        {
            dgv_showKh.DataSource = adbus.GetAdmin();
        }
        public void OpenConnect()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
        }
        public void CloseConnect()
        {
            if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
        }
        private void AddKh_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string ma = Idkh_txb.Text;
                if (ma == "") throw new Exception("Mời nhập vào mã");
                string ten = NameKh_txb.Text;
                if (ten == "") throw new Exception("Mời nhập vào tên");
                string email = EmailKh_txb.Text;
                if (email == "") throw new Exception("Mời nhập vào email");
                int sdt = Convert.ToInt32(SdtKh_txb.Text);
                if (sdt.ToString() == "") throw new Exception("Mời nhập vào số điện thoại");
                sqlcon = GetConnect();
                OpenConnect();
                sqlcmd = new SqlCommand("AddKh", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@MaKH", ma);
                sqlcmd.Parameters.AddWithValue("@TenKH", ten);
                sqlcmd.Parameters.AddWithValue("@EmailKH", email);
                sqlcmd.Parameters.AddWithValue("@SdtKH", sdt);
                int kq = sqlcmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    LoadDGV();
                }
                CloseConnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DelKh_btn_Click(object sender, EventArgs e)
        {
            if (dgv_showKh.SelectedRows.Count > 0)
            {
                List<string> IdList = new List<string>();
                foreach (DataGridViewRow item in dgv_showKh.SelectedRows)
                    IdList.Add(item.Cells["MaKH"].Value.ToString());
                try
                {
                    sqlcon = GetConnect(); int res = -1;
                    OpenConnect();
                    foreach (string str in IdList)
                    {
                        sqlcmd = new SqlCommand("DeleteKh", sqlcon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("@MaKH", str);
                        res = sqlcmd.ExecuteNonQuery();
                    }
                    if (res > 0)
                    {
                        MessageBox.Show("Xóa khách hàng thành công");
                        LoadDGV();
                    }
                    CloseConnect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        private void EditKh_btn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    sqlcon = GetConnect();
            //    OpenConnect();
            //    sqlcmd = new SqlCommand("EditKh", sqlcon);
            //    sqlcmd.CommandType = CommandType.StoredProcedure;
            //    sqlcmd.Parameters.AddWithValue("@MaKH", ma);
            //    sqlcmd.Parameters.AddWithValue("@TenKH", ten);
            //    sqlcmd.Parameters.AddWithValue("@EmailKH", email);
            //    sqlcmd.Parameters.AddWithValue("@SdtKH", sdt);
            //    int res = sqlcmd.ExecuteNonQuery();
            //    if(res > 0)
            //    {
            //        MessageBox.Show("Cật nhật khách hàng thành công");
            //        LoadDGV();
            //    }    
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}  
        }

        private void QuanLyForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            ptb_imdynamic.Image = new Bitmap("E:\\PBL_03_DUT_DoAnCongNghePhanMem\\GUI\\Resources\\5.jpg");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            switch(r.Next(1, 5))
            {
                case 5:
                    ptb_imdynamic.Image = new Bitmap(@"E:\PBL_03_DUT_DoAnCongNghePhanMem\GUI\Resources\5.jpg");
                    break;
                case 1:
                    ptb_imdynamic.Image = new Bitmap(@"E:\PBL_03_DUT_DoAnCongNghePhanMem\GUI\Resources\1.png");
                    break;
                case 2:
                    ptb_imdynamic.Image = new Bitmap(@"E:\PBL_03_DUT_DoAnCongNghePhanMem\GUI\Resources\2.jpg");
                    break;
                case 3:
                    ptb_imdynamic.Image = new Bitmap(@"E:\PBL_03_DUT_DoAnCongNghePhanMem\GUI\Resources\3.png");
                    break;
                case 4:
                    ptb_imdynamic.Image = new Bitmap(@"E:\PBL_03_DUT_DoAnCongNghePhanMem\GUI\Resources\4.jpg");
                    break;
            }
            
        }
    }
}
