using duan1.DAO;
using duan1.DTO;
using Google.Apis.Admin.Directory.directory_v1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace duan1
{
    public partial class Form3 : Form
    {
        
        public Form3(Account acc)
        {
            InitializeComponent();
          LoginAccount = acc;
        }
        private Account loginAccount;
      

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        void ChangeAccount(Account acc)
        {
            textBox1.Text = LoginAccount.Username;
            textBox2.Text = LoginAccount.Email ;

        }
        void UpdateAccountInfo()
        {
            string usename = textBox1.Text;
            string Email = textBox2.Text;
            string password = textBox3.Text;
            string newpass = textBox4.Text;
            string reenterPass = textBox5.Text;

            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show(" Vui lòng nhập khẩu đúng với mật khẩu trên !");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount( usename,Email,password,newpass))
                {
                    MessageBox.Show(" Cập nhật thành công rồi nhá :");
                    if(updateAccount!=null)
                        updateAccount(this,new AccountEvent( AccountDAO.Instance.GetAccountByUserName(usename)));
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu : ");
                }

            }

        }
        private event  EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAcount
        {
            add { updateAccount += value;}
            remove { updateAccount -= value;}
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
    }
    public class AccountEvent:EventArgs
    {
        private Account acc;

        public Account Acc { 
            get { return acc; }
            set { acc = value; }
        }
        public AccountEvent(Account acc)
        {
            this.acc = acc;
        }
    }
}
