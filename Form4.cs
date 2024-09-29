using DocumentFormat.OpenXml.Drawing.Diagrams;
using duan1.DAO;
using duan1.DTO;
using Google.Apis.Admin.Directory.directory_v1.Data;
using Microsoft.Azure.Amqp.Framing;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Category = duan1.DTO.Category;

namespace duan1
{
    public partial class Form4 : Form
    {
        BindingSource phongList = new BindingSource();
        BindingSource phongList1 = new BindingSource();
        BindingSource phongListN = new BindingSource();
        BindingSource accountList = new BindingSource();

        private EventHandler insertDMPhong;
        public Account loginAccount;
        public Form4()
        {
            InitializeComponent();
            dataGridView1.DataSource = phongList;
            dataGridView3.DataSource = phongList1;
            dataGridView4.DataSource = phongListN;
            dataGridView5.DataSource = accountList;
            LoadListBillByDate(dateTimePicker1.Value, dateTimePicker2.Value);
            LoadListPhong();

            //LoadAccountList();
            LoadDateTimePickerBill();
            AddPhongBinDing();
            LoadCategoryIntoCombobox(comboBox3);
            LoadListCategory();
            AddDanhMucBinDing();
            LoadListPhongN();
            AddPhongNBinDing();
            AddAccountBinding();
            LoadAccount();





        }

        void AddAccountBinding()
        {
            textBox9.DataBindings.Add(new Binding("Text", dataGridView5.DataSource, "Username", true, DataSourceUpdateMode.Never));
            textBox10.DataBindings.Add(new Binding("Text", dataGridView5.DataSource, "Email", true, DataSourceUpdateMode.Never));

            numericUpDown2.DataBindings.Add(new Binding("Value", dataGridView5.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
            //dataGridView5.Columns["pass"].Visible = false;
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dateTimePicker1.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);

        }

        void LoadListPhong()
        {
            phongList.DataSource = PhongDAO.Instance.GetListPhong();
            //dataGridView2.DataSource = PhongDAO.Instance.GetListPhong();


        }
        void LoadListCategory()
        {
            phongList1.DataSource = CategoryDAO.Instance.GetListCategory();
        }


        void LoadListPhongN()
        {
            phongListN.DataSource = TableDAO.Instance.GetListPhongN();
        }
        //void LoadClassList()
        //{
        //    string query = " select * from TPHONG ";  // Câu truy vấn

        //    dataGridView1.DataSource = DataProvider.Instance.ExeCuteQuery(query, new object[] { "K11" });
        //}
        //// Hàm tải danh sách tài khoản từ cơ sở dữ liệu
        //void LoadAccountList()
        //{
        //    string query = "  select * from TAIKHOAN ";  // Câu truy vấn

        //    dataGridView5.DataSource = DataProvider.Instance.ExeCuteQuery(query, new object[] { "K11" });

        //}


        private void label1_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e) { }

        private void tabPage3_Click(object sender, EventArgs e) { }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e) { }



        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadAccount();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dataGridView2.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);


        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dateTimePicker1.Value, dateTimePicker2.Value);

        }
        void AddPhongBinDing()
        {
            textBox2.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "ID", true, DataSourceUpdateMode.Never));
            textBox3.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Name", true, DataSourceUpdateMode.Never));
            numericUpDown1.DataBindings.Add(new Binding("Value", dataGridView1.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void AddPhongNBinDing()
        {
            textBox6.DataBindings.Add(new Binding("Text", dataGridView4.DataSource, "ID", true, DataSourceUpdateMode.Never));
            textBox5.DataBindings.Add(new Binding("Text", dataGridView4.DataSource, "Name", true, DataSourceUpdateMode.Never));
            comboBox1.DataBindings.Add(new Binding("Text", dataGridView4.DataSource, "Status", true, DataSourceUpdateMode.Never));
        }
        void AddDanhMucBinDing()
        {
            textBox8.DataBindings.Add(new Binding("Text", dataGridView3.DataSource, "ID", true, DataSourceUpdateMode.Never));
            textBox7.DataBindings.Add(new Binding("Text", dataGridView3.DataSource, "Name", true, DataSourceUpdateMode.Never));

        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadListPhong();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int id = (int)dataGridView1.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category cateogory = CategoryDAO.Instance.GetCategoryByID(id);
                    comboBox3.SelectedItem = cateogory;
                    int index = -1;
                    int i = 0;
                    foreach (Category item in comboBox3.Items)
                    {
                        if (item.ID == cateogory.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;

                    }
                    comboBox3.SelectedIndex = index;
                }
            }
            catch { }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            int iddm = (comboBox3.SelectedItem as Category).ID;
            float price = (float)numericUpDown1.Value;

            if (PhongDAO.Instance.InsertPhong(name, iddm, price))
            {
                MessageBox.Show("Thêm Phòng Thành công :");
                LoadListPhong();
                if (insertPhong != null)
                    insertPhong(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Thêm Phòng : ");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox3.Text;
            int iddm = (comboBox3.SelectedItem as Category).ID;
            float price = (float)numericUpDown1.Value;
            int id = Convert.ToInt32(textBox2.Text);

            if (PhongDAO.Instance.UpdatePhong(id, name, iddm, price))
            {
                MessageBox.Show("Update Phòng Thành công :");
                LoadListPhong();
                if (updatePhong != null)
                    updatePhong(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Update Phòng : ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox2.Text);

            if (PhongDAO.Instance.DeletePhong(id))
            {
                MessageBox.Show("Xoa Phòng Thành công :");
                LoadListPhong();
                if (deletePhong != null)
                    deletePhong(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Xoa Phòng : ");
            }
        }
        List<Phong> SearchPhongByName(string name)
        {
            List<Phong> listPhong = PhongDAO.Instance.SearchPhongByName(name);
            return listPhong;
        }
        private void button6_Click(object sender, EventArgs e)
        {

            phongList.DataSource = SearchPhongByName(textBox1.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string name = textBox7.Text;



            if (CategoryDAO.Instance.InsertDMPhong(name))
            {
                MessageBox.Show("Thêm Danh muc Phòng Thành công :");
                LoadListCategory();
                if (insertDMPhongEvent != null)
                    insertDMPhongEvent(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Thêm Danh muc Phòng : ");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox8.Text);

            if (CategoryDAO.Instance.DeleteDMPhong(id))
            {
                MessageBox.Show("Xoa Danh Muc Phòng Thành công :");
                LoadListCategory();
                if (deleteDMPhong != null)
                    deleteDMPhong(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Xoa Danh Muc Phòng : ");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string name = textBox7.Text;

            int id = Convert.ToInt32(textBox8.Text);

            if (CategoryDAO.Instance.UpdateDMPhong(name, id))
            {
                MessageBox.Show("Update Phòng Thành công :");
                LoadListCategory();
                if (updateDMPhong != null)
                    updateDMPhong(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Update Phòng : ");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadListCategory();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadListPhongN();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string name = textBox5.Text;

            string status = comboBox1.Text;


            if (TableDAO.Instance.InsertPhongN(name, status))
            {
                MessageBox.Show("Thêm Khu Thành công :");
                LoadListPhongN();
                if (insertDMPhongNEvent != null)
                    insertDMPhongNEvent(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Thêm Khu : ");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(textBox6.Text);



            if (TableDAO.Instance.DeletePhongN(id))
            {
                MessageBox.Show("Xoá Khu Thành công :");
                LoadListPhongN();
                if (deleteDMPhongN != null)
                    deleteDMPhongN(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Xoá Khu : ");
            }
        }
        private void button12_Click(object sender, EventArgs e)
        {

            string name = textBox5.Text;
            string status = comboBox1.Text;
            int id = Convert.ToInt32(textBox6.Text);

            if (TableDAO.Instance.UpdatePhongN(id, name, status))
            {
                MessageBox.Show("Update Phòng Thành công :");
                LoadListPhongN();
                if (updateDMPhongN != null)
                    updateDMPhongN(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Update Phòng : ");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        void AddAccount(string userName, string Email, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, Email, type))
            {
                MessageBox.Show("Thêm Tài Khoản Thành Công");
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Thêm Tài Khoản Thất Bại ");
            }



        }
        void EditAccount(string userName, string Email, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, Email, type))
            {
                MessageBox.Show("Upadte Tài Khoản Thành Công");
                LoadAccount();
            }
            else
            {
                MessageBox.Show("Update Tài Khoản Thất Bại ");
            }

        }
        void DeleteAccount(string userName)
        {
            if (loginAccount.Username.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xoá chính mình xem lại bản thân đi ");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xoa Tài Khoản Thành Công");

            }
            else
            {
                MessageBox.Show("Xoa Tài Khoản Thất Bại ");
            }
            LoadAccount();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            string username = textBox9.Text;
            string email = textBox10.Text;
            int type = (int)numericUpDown2.Value;
            AddAccount(username, email, type);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string username = textBox9.Text;

            DeleteAccount(username);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string username = textBox9.Text;
            string email = textBox10.Text;
            int type = (int)numericUpDown2.Value;
            EditAccount(username, email, type);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void ResetPass(string username)
        {
            if (AccountDAO.Instance.ResetPassword(username))
            {
                MessageBox.Show("Đặt Lại Mật Khẩu Thành Công");

            }
            else
            {
                MessageBox.Show("Đặt Lại Mật Khẩu Thất Bại ");
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            string username = textBox9.Text;

            ResetPass(username);
        }

        private event EventHandler insertPhong;
        public event EventHandler InsertPhong
        {
            add { insertPhong += value; }
            remove { insertPhong -= value; }
        }
        private event EventHandler deletePhong;
        public event EventHandler DeletePhong
        {
            add { deletePhong += value; }
            remove { deletePhong -= value; }
        }
        private event EventHandler updatePhong;
        public event EventHandler UpdatePhong
        {
            add { updatePhong += value; }
            remove { updatePhong -= value; }
        }

        private event EventHandler insertDMPhongEvent;

        public event EventHandler InsertDMPhongEvent
        {
            add { insertDMPhongEvent += value; }
            remove { insertDMPhongEvent -= value; }
        }
        private event EventHandler deleteDMPhong;
        public event EventHandler DeleteDMPhong
        {
            add { deleteDMPhong += value; }
            remove { deleteDMPhong -= value; }
        }
        private event EventHandler updateDMPhong;
        public event EventHandler UpdateDMPhong
        {
            add { updateDMPhong += value; }
            remove { updateDMPhong -= value; }
        }
        private event EventHandler insertDMPhongNEvent;

        public event EventHandler InsertDMPhongNEvent
        {
            add { insertDMPhongNEvent += value; }
            remove { insertDMPhongNEvent -= value; }
        }
        private event EventHandler deleteDMPhongN;
        public event EventHandler DeleteDMPhongN
        {
            add { deleteDMPhongN += value; }
            remove { deleteDMPhongN -= value; }
        }
        private event EventHandler updateDMPhongN;
        public event EventHandler UpdateDMPhongN
        {
            add { updateDMPhongN += value; }
            remove { updateDMPhongN -= value; }
        }












        // Biến lưu chỉ số của tab hiện tại
        private int currentTabIndex = 0;
        private List<TabPage> hiddenTabs = new List<TabPage>();

        // Hàm để ẩn một tab
        private void HideTab(TabPage tabPage)
        {
            if (tabControl1.TabPages.Contains(tabPage))
            {
                hiddenTabs.Add(tabPage);
                tabControl1.TabPages.Remove(tabPage);
            }
        }

        // Hàm để hiện lại một tab
        private void ShowTab(TabPage tabPage)
        {
            if (!tabControl1.TabPages.Contains(tabPage) && hiddenTabs.Contains(tabPage))
            {
                tabControl1.TabPages.Add(tabPage);
                hiddenTabs.Remove(tabPage);
            }
        }

        // Hàm để chuyển đến tab tiếp theo
        private void ShowNextTab()
        {
            if (currentTabIndex < tabControl1.TabPages.Count - 1)
            {
                currentTabIndex++;
                tabControl1.SelectedIndex = currentTabIndex;
            }
        }

        // Hàm để trở về tab trước
        private void ShowPreviousTab()
        {
            if (currentTabIndex > 0)
            {
                currentTabIndex--;
                tabControl1.SelectedIndex = currentTabIndex;
            }
        }

        // Sự kiện khi nhấn nút trở về tab trước
        private void button21_Click(object sender, EventArgs e)
        {
            ShowPreviousTab(); // Trở về tab trước
        }

        // Sự kiện khi nhấn nút chuyển đến tab tiếp theo
        private void button22_Click(object sender, EventArgs e)
        {
            ShowNextTab(); // Chuyển đến tab tiếp theo
        }

        // Sự kiện khi tab được chọn (để cập nhật chỉ số hiện tại)
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTabIndex = tabControl1.SelectedIndex;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            

        }
    }

}

