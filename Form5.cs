using duan1.DAO;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string username = textBox2.Text;
            string email = textBox1.Text;
            string pass = textBox3.Text;
            AddAccount(username, email, pass);
        }
        void AddAccount(string userName, string Email, string Pass)
        {
            if (AccountDAO.Instance.DKIAccount(userName, Email, Pass))
            {
                MessageBox.Show("Đăng kí Tài Khoản Thành Công");

            }
            else
            {
                MessageBox.Show("Đăng kí Tài Khoản Thất Bại ");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.ShowDialog();
            
        }
    }
}
