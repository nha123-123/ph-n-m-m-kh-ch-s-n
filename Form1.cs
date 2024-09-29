using duan1.DAO;
using duan1.DTO;


namespace duan1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();

           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đăng ký sự kiện KeyDown cho form
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra nếu phím Enter được nhấn
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi trực tiếp sự kiện button1_Click
                button1_Click(this, new EventArgs());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        //dang nhap
        {
            string username = textBox1.Text;
            string Pass = textBox2.Text;
            if (Login(username, Pass))

            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(username);

                Form2 f = new Form2(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai ten TK hoac MK");
            }
        }
        bool Login(string username, string Pass)
        {

            return AccountDAO.Instance.Login(username, Pass);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            this.Hide();
            f.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
