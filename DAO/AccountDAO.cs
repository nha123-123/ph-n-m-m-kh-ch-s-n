using duan1.DTO;
using MathNet.Numerics;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace duan1.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string username, string pass)
        {

            //byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            //byte[] hasData = MD5.HashData(temp);
            ////var list = hasData.ToString();
            ////list.Reverse();
            //string hasPass = "";
            //foreach (byte item in hasData)
            //{
            //    hasPass += item;
            //}//ma hoa thiếu thư viện
            
            string query = "USP_Login @Username , @Pass";
            DataTable result = DataProvider.Instance.ExeCuteQuery(query, new object[] { username, pass });
            return result.Rows.Count > 0;
        }

        public Account GetAccountByUserName(string username) {
            DataTable data = DataProvider.Instance.ExeCuteQuery("SELECT * FROM TAIKHOAN WHERE username = '" + username + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);

            }
            return null;
        }
        public bool UpdateAccount(string username, string Email, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExeCuteNonQuery(
                "exec USP_UpdateAccount @userName , @Email , @password , @newPassword",
                new object[] { username, Email, pass, newPass });

            return result > 0;
        }
        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExeCuteQuery("SELECT username, email, type FROM dbo.TAIKHOAN");
        }

        public bool InsertAccount(string name, string email, int type)
        {

            string query = string.Format("INSERT dbo.TAIKHOAN (username,email,type) VALUES (N'{0}','{1}','{2}')", name, email, type);
            int result = DataProvider.Instance.ExeCuteNonQuery(query);
            return result > 0;
        }
        public bool DKIAccount(string name, string email, string pass)
        {

            string query = string.Format("INSERT dbo.TAIKHOAN (username,email,pass) VALUES (N'{0}','{1}','{2}')", name, email, pass);
            int result = DataProvider.Instance.ExeCuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteAccount(string name)
        {

            string query = string.Format("DELETE FROM dbo.TAIKHOAN WHERE username = N'{0}'", name);
            int result = DataProvider.Instance.ExeCuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(string name, string email, int type)
        {

            string query = string.Format("UPDATE dbo.TAIKHOAN SET email = N'{1}',type = {2} WHERE username =N'{0}'", name, email, type);
            int result = DataProvider.Instance.ExeCuteNonQuery(query);
            return result > 0;
        }
        public bool ResetPassword(string name)
        {
            string query = string.Format("UPDATE dbo.TAIKHOAN SET pass = N'{0}' WHERE username =N'{0}'", name);
            int result = DataProvider.Instance.ExeCuteNonQuery(query);
            return result > 0;
        }

       
    }


}