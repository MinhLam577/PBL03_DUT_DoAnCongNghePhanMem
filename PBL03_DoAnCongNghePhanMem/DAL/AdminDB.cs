using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class AdminDB
    {
        DataTable dt;
        string strcon = "Data Source=SKY;Initial Catalog=QLPhongGym;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlcon = null;
        SqlDataAdapter sqladt = null;
        SqlCommand sqlcmd = null;
        public SqlConnection GetConnect()
        {
            if (sqlcon == null)
                sqlcon = new SqlConnection(strcon);
            return sqlcon;
        }
        public void OpenConnect()
        {
            if (sqlcon.State == ConnectionState.Closed)
                sqlcon.Open();
        }
        public void CloseConnect()
        {
            if (sqlcon.State == ConnectionState.Open)
                sqlcon.Close();
        }
        public SqlDataAdapter Getadt(string query)
        {
            sqlcon = GetConnect();
            sqladt = new SqlDataAdapter(query, sqlcon);
            return sqladt;
        }

        public List<Admin> LoadAllAdmin()
        {
            List<Admin> adlist = new List<Admin>();
            dt = new DataTable();
            sqladt = Getadt("GetAllAdmin");
            sqladt.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                Admin ad = GetAdminByDatarow(dr);
                adlist.Add(ad);
            }
            return adlist;
        }
        public Admin GetAdminByDatarow(DataRow dr)
        {
            string tentk = dr["adTenTK"].ToString();
            string adNam = dr["adName"].ToString();
            int adage = Convert.ToInt32(dr["adAge"].ToString());
            bool sex = Convert.ToBoolean(dr["adSex"].ToString());
            string sdt = dr["adSdt"].ToString();
            string address = dr["adAddress"].ToString();
            string cmnd = dr["adCMND"].ToString();
            return new Admin(tentk, adNam, adage, sex, sdt, address, cmnd);
        }
        public int AddAdmin(Admin ad)
        {
            int kq = -1;
            using(sqlcon = GetConnect())
            {
                sqlcmd = new SqlCommand("AddAdmin", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@tentk", ad.TenTK);
                sqlcmd.Parameters.AddWithValue("@Name", ad.Ten);
                sqlcmd.Parameters.AddWithValue("@Age", ad.Age);
                sqlcmd.Parameters.AddWithValue("@Sex", ad.Sex);
                sqlcmd.Parameters.AddWithValue("@Sdt", ad.Sdt);
                sqlcmd.Parameters.AddWithValue("@Address", ad.Address);
                sqlcmd.Parameters.AddWithValue("@cmnd", ad.Cmnd);
                OpenConnect();
                kq = sqlcmd.ExecuteNonQuery();
                if (kq > 0)
                CloseConnect();
            }
            return kq;
        }
    }
}
