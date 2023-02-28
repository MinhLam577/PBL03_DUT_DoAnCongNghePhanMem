using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccessDB
    {
        DataTable dt = null;
        string strcon = "Data Source=SKY;Initial Catalog=QLPhongGym;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlcon;
        SqlDataAdapter sqladt;
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
        public DataTable GetAllValue(string query)
        {
            dt = new DataTable();
            sqlcon = GetConnect();
            sqladt = new SqlDataAdapter(query, sqlcon);
            sqladt.Fill(dt);
            return dt;
        }
        
    }
}
