using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office.CustomUI;
using DocumentFormat.OpenXml.Office2010.Excel;
using duan1.DAO;
using duan1.DTO;
using System.Globalization;
using Button = System.Windows.Forms.Button;
using Color = System.Drawing.Color;
using ComboBox = System.Windows.Forms.ComboBox;
using Table = duan1.DTO.Table;





namespace duan1
{
    public partial class Form2 : Form
    {
   

       

        public Form2(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
            LoadComboboxTable(comboBox3);
           
        }
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            comboBox1.DataSource = listCategory;
            comboBox1.DisplayMember = "Name";
        }

        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinCáNhânToolStripMenuItem.Text += "(" + LoginAccount.Email + ")";



        }




        void LoadRoomListByCategoryID(int id)
        {
            List<Phong> listPhong = PhongDAO.Instance.GetRoomByCategoryID(id);
            comboBox2.DataSource = listPhong;
            comboBox2.DisplayMember = "Name";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedIndex == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadRoomListByCategoryID(id);
        }



        void LoadTable()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Table> tablelist = TableDAO.Instance.LoadTableList();

            foreach (Table item in tablelist)
            {

                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;






                switch (item.Status.Trim().ToLower())
                {
                    case "trong":
                        btn.BackColor = Color.Green;
                        break;

                    default:
                        btn.BackColor = Color.Red; // Màu mặc định cho các trạng thái khác
                        break;

                }


                flowLayoutPanel1.Controls.Add(btn);

            }

        }
        void ShowBill(int id)
        {
            listView1.Items.Clear();
            List<duan1.DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;

            foreach (duan1.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.PhongName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalTien.ToString());


                totalPrice += item.TotalTien;

                listView1.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("en-US");
            //Thread.CurrentThread.CurrentCulture = culture;
            textBox1.Text = totalPrice.ToString("c", culture);


        }
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
           cb.DisplayMember = "Name";
        }

        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            listView1.Tag = (sender as Button).Tag;
            ShowBill(tableID);

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(LoginAccount);
            f.UpdateAcount += f_UpdateAccount;
            f.ShowDialog();
        }

        private void f_UpdateAccount(object? sender, AccountEvent e)
        {
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.Email + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            try
            {
                Form4 f = new Form4();
                f.InsertPhong += f_InsertPhong;
                f.DeletePhong += f_DeletePhong;
                f.UpdatePhong += f_UpdatePhong;
                f.UpdateDMPhong += f_UpdateDMphong;
                f.InsertDMPhongEvent += f_InsertDMPhongEvent;
                f.DeleteDMPhong += f_DeleteDMPhong;
                f.UpdateDMPhongN += f_UpdateDMphongN;
                f.InsertDMPhongNEvent += f_InsertDMPhongNEvent;
                f.DeleteDMPhongN += f_DeleteDMPhongN;
                f.loginAccount = LoginAccount;


                f.ShowDialog();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

            Form5 f = new Form5();
            this.Hide();
            f.ShowDialog();
            
        }

        private void f_DeleteDMPhongN(object? sender, EventArgs e)
        {
            LoadRoomListByCategoryID((comboBox1.SelectedItem as Category).ID);
            if (listView1.Tag != null)
                ShowBill((listView1.Tag as Table).ID);
            LoadTable();
        }

        private void f_InsertDMPhongNEvent(object? sender, EventArgs e)
        {
            LoadRoomListByCategoryID((comboBox1.SelectedItem as Category).ID);
            if (listView1.Tag != null)
                ShowBill((listView1.Tag as Table).ID);
            LoadTable();
        }

        private void f_UpdateDMphongN(object? sender, EventArgs e)
        {
            LoadRoomListByCategoryID((comboBox1.SelectedItem as Category).ID);
            if (listView1.Tag != null)
                ShowBill((listView1.Tag as Table).ID);
            LoadTable();
        }

        private void f_DeleteDMPhong(object? sender, EventArgs e)
        {
            LoadRoomListByCategoryID((comboBox1.SelectedItem as Category).ID);
            if (listView1.Tag != null)
                ShowBill((listView1.Tag as Table).ID);
            LoadCategory();
        }

        private void f_InsertDMPhongEvent(object? sender, EventArgs e)
        {
            LoadRoomListByCategoryID((comboBox1.SelectedItem as Category).ID);
            if (listView1.Tag != null)
                ShowBill((listView1.Tag as Table).ID);
            LoadCategory();
        }

            private void f_UpdateDMphong(object? sender, EventArgs e)
        {
            LoadRoomListByCategoryID((comboBox1.SelectedItem as Category).ID);
            if (listView1.Tag != null)
                ShowBill((listView1.Tag as Table).ID);
            LoadCategory();
        }

        private void f_UpdatePhong(object? sender, EventArgs e)
        {
            LoadRoomListByCategoryID((comboBox1.SelectedItem as Category).ID);
            if (listView1.Tag != null)
                ShowBill((listView1.Tag as Table).ID);
        }

        private void f_DeletePhong(object? sender, EventArgs e)
        {
            LoadRoomListByCategoryID((comboBox1.SelectedItem as Category).ID);
            if (listView1.Tag != null)
                ShowBill((listView1.Tag as Table).ID);
            LoadTable();
        }

        private void f_InsertPhong(object? sender, EventArgs e)
        {
            LoadRoomListByCategoryID((comboBox1.SelectedItem as Category).ID);
            if(listView1.Tag != null)
            ShowBill((listView1.Tag as Table).ID);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Table table = listView1.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Hay cho phong");
                return;
            }
            int idBill = BillDAO.Instance.getUncheckBillIDByTableID(table.ID);
            int phongID = (comboBox2.SelectedItem as Phong).ID;
            int count = (int)numericUpDown1.Value;
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDao.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), phongID, count);
            }
            else
            {
                BillInfoDao.Instance.InsertBillInfo(idBill, phongID, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Table table = listView1.Tag as Table;
            int idBill = BillDAO.Instance.getUncheckBillIDByTableID(table.ID);
            int discount = (int)numericUpDown2.Value;
            double totalPrice = Convert.ToDouble(textBox1.Text.Replace("$", "").Replace(",", "").Trim());

            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            if (idBill != -1)

            {
                if (MessageBox.Show(string.Format("Bạn có chắc muốn thanh toáncho Room {0}\n  Tổng tiền -  (Tổng tiền / 100) x Giảm giá\n => {1} - ({1}/100) x {2} = {3} ", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount,(float)finalTotalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            int id1=(listView1.Tag as Table).ID;
            int id2=(comboBox3.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển khu {0} qua khu {1}", (listView1.Tag as Table).Name, (comboBox3.SelectedItem as Table).Name), "Thông Báo", MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);
                LoadTable();
            }   
        }
    }
}
