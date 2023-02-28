using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class AccountDB
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
        public List<Account> LoadAllAccount()
        {
            List<Account> acclist = new List<Account>();
            dt = new DataTable();
            sqladt = Getadt("GetAllAccount");
            sqladt.Fill(dt);
            foreach (DataRow item in dt.Rows)
                acclist.Add(GetAccountByDataRow(item));
            return acclist;
        }

        public Account GetAccountByDataRow(DataRow d)
        {
            string email = d["EmailTK"].ToString();
            string tenTK = d["TenTK"].ToString();
            string mk = d["MatKhauTK"].ToString();
            int maquyen = Convert.ToInt32(d["MaQuyen"].ToString());
            return new Account(email, tenTK, mk, maquyen);
        }
        public string GetUserByMaQuyen(int ma)
        {
            string tenquyen = "";
            sqlcon = GetConnect();
            sqlcmd = new SqlCommand("GetUser", sqlcon);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.Parameters.AddWithValue("@MaQuyen", ma);
            OpenConnect();
            SqlDataReader dr = sqlcmd.ExecuteReader();
            if (dr.Read())
                tenquyen = dr["TenQuyen"].ToString();
            CloseConnect();
            return tenquyen;
        }
        public bool CheckAccountExist(string tentk)
        {
            List<Account> acclist = LoadAllAccount();
            return acclist.Any(a=>a.TenTK == tentk);
        }
        public bool CheckEmailExist(string email)
        {
            List<Account> acclist = LoadAllAccount();
            return acclist.Any(a => a.EmailTK == email);
        }
        public int AddAcount(Account acc)
        {
            int kq = -1;
            using (sqlcon = GetConnect())
            {
                sqlcmd = new SqlCommand("AddAccount", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@TenTK", acc.TenTK);
                sqlcmd.Parameters.AddWithValue("@EmailTK", acc.EmailTK);
                sqlcmd.Parameters.AddWithValue("@MaQuyen", acc.MaQuyen);
                sqlcmd.Parameters.AddWithValue("@MatKhauTK", acc.MatKhauTK);
                OpenConnect();
                kq = sqlcmd.ExecuteNonQuery();
                if(kq > 0)
                    dt.Rows.Add(acc.TenTK, acc.MatKhauTK, acc.EmailTK, acc.MaQuyen);  
                CloseConnect();
            }
            return kq;
        }

        public string GetPassword(string email)
        {
            List<Account> acclist = LoadAllAccount();
            string e = acclist.Where(a => a.EmailTK == email).Select(a => a.MatKhauTK).FirstOrDefault();
            if(e != null) return e;
            return "";
        }
    }
}
