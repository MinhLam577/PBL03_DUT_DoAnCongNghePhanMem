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
namespace TestProcedure
{
    public partial class Form1 : Form
    {
        private DataTable dt;
        string con = "Data Source=SKY;Initial Catalog=QLSV;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlconnect = null;
        SqlDataAdapter sqladap = null;
        SqlCommand sqlcommand = null;
        SqlDataReader sqldata = null;
        public Form1()
        {
            InitializeComponent();
        }
        public SqlConnection Connect()
        {
            if(sqlconnect == null)
            {
                sqlconnect = new SqlConnection(con);
            }
            return sqlconnect;
        }
        public SqlDataAdapter GetDataAdap(string query)
        {
            sqlconnect = Connect();
            sqladap = new SqlDataAdapter(query, sqlconnect);
            return sqladap;
        }
       
        public void LoadDGV()
        {
            dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "ClassName", DataType = typeof(string)},
                new DataColumn{ColumnName = "Id", DataType = typeof(string)},
                new DataColumn{ColumnName = "Name", DataType = typeof(string)},
                new DataColumn{ColumnName = "Dtb", DataType = typeof(double)},
                new DataColumn{ColumnName = "NS", DataType = typeof(DateTime)},
                new DataColumn{ColumnName = "Gender", DataType = typeof(bool)},
                new DataColumn{ColumnName = "Picture", DataType = typeof(bool)},
                new DataColumn{ColumnName = "Hb", DataType = typeof(bool)},
                new DataColumn{ColumnName = "Cccd", DataType = typeof(bool)},
            });
            SqlDataAdapter db = GetDataAdap("ShowSV");
            db.Fill(dt);
            DGV_show.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDGV();
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SV sv = new SV
                {
                    ClassName = "21TCLC_DT6",
                    Id = "102210282",
                    Name = "Lam",
                    Dtb = 10,
                    NS = new DateTime(2003, 12, 30),
                    Gender = true,
                    Picture = true,
                    Hb = true,
                    Cccd = true
                };
                sqlconnect = Connect();
                if (sqlconnect.State == ConnectionState.Closed)
                    sqlconnect.Open();
                sqlcommand = new SqlCommand("AddSV", sqlconnect);
                sqlcommand.CommandType = CommandType.StoredProcedure;
                sqlcommand.Parameters.AddWithValue("@ClassName", sv.ClassName);
                sqlcommand.Parameters.AddWithValue("@Id", sv.Id);
                sqlcommand.Parameters.AddWithValue("@Name", sv.Name);
                sqlcommand.Parameters.AddWithValue("@Dtb", sv.Dtb);
                sqlcommand.Parameters.AddWithValue("@NS", sv.NS);
                sqlcommand.Parameters.AddWithValue("@Gender", sv.Gender);
                sqlcommand.Parameters.AddWithValue("@Picture", sv.Picture);
                sqlcommand.Parameters.AddWithValue("@Hb", sv.Hb);
                sqlcommand.Parameters.AddWithValue("@Cccd", sv.Cccd);
                int kq = sqlcommand.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("thêm thành công");
                    LoadDGV();
                }
                sqlconnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public class SV
        {
            public string ClassName { get; set; }
            public string Id { get; set; }
            public string Name { get; set; }
            public double Dtb { get; set; }
            public DateTime NS { get; set; }
            public bool Gender { get; set; }
            public bool Picture { get; set; }
            public bool Hb { get; set; }
            public bool Cccd { get; set; }
        }
    }
}
