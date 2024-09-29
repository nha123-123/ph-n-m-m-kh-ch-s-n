using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duan1.DTO
{
    public class Account
    {
        private string username;
        private string password;
        private int type;
        private string email;

        public string Username { 
            get { return username; }
            set { username = value; } }
        public string Password { 
            get { return password; }
            set { password = value; } }
        public int Type {
            get { return type; }
            set { type = value; } 
        }
        public string Email {
            get { return email; }
            set { email = value; } }
        public Account(string username , string email, int type, string password = null)
        {
            this.Username = username;
            this.Password = password;
            this.Email = email;
            this.Type = type;
           
        }
        public Account(DataRow row) {
            this.Username = row["username"].ToString();
            this.Email = row["email"].ToString();
            this.Password = row["pass"].ToString();
            this.Type = (int)row["type"];
           
        }
    }
}
