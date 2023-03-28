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
    public class AccountDB : AccessDB
    {
        SqlConnection sqlcon = null;
        SqlDataAdapter sqladt = null;
        SqlCommand sqlcmd = null;
        private static AccountDB instance;
        public static AccountDB Instance
        {
            get
            {
                if( instance == null )
                    instance = new AccountDB();
                return instance;
            }
            private set { }
        }
        public List<Account> LoadAllAccount()
        {
            List<Account> acclist = new List<Account>();
            DataTable dt = GetAllValue("GetAllAccount");
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
            string sdt = d["Sdt"].ToString();
            return new Account(email, sdt, tenTK, mk, maquyen);
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
        public bool CheckSdtExist(string sdt)
        {
            List<Account> acclist = LoadAllAccount();
            return acclist.Any(a => a.Sdt == sdt);
        }
        public bool CheckAccountExist(string tentk)
        {
            List<Account> acclist = LoadAllAccount();
            return acclist.Any(a => a.TenTK == tentk);
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
                sqlcmd.Parameters.AddWithValue("@Sdt", acc.Sdt);
                OpenConnect();
                kq = sqlcmd.ExecuteNonQuery();
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
