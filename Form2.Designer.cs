namespace duan1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinToolStripMenuItem = new ToolStripMenuItem();
            thôngTinCáNhânToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            panel3 = new Panel();
            textBox1 = new TextBox();
            comboBox3 = new ComboBox();
            button5 = new Button();
            numericUpDown2 = new NumericUpDown();
            button4 = new Button();
            button3 = new Button();
            panel4 = new Panel();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 348);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(59, 28);
            button1.TabIndex = 1;
            button1.Text = "<--";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(830, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // thôngTinToolStripMenuItem
            // 
            thôngTinToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinCáNhânToolStripMenuItem, đăngXuấtToolStripMenuItem });
            thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            thôngTinToolStripMenuItem.Size = new Size(70, 20);
            thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            thôngTinCáNhânToolStripMenuItem.Size = new Size(170, 22);
            thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            thôngTinCáNhânToolStripMenuItem.Click += thôngTinCáNhânToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(170, 22);
            đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(12, 39);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 304);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(319, 301);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(listView1);
            panel2.Location = new Point(343, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(447, 164);
            panel2.TabIndex = 4;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.GridLines = true;
            listView1.Location = new Point(1, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(444, 161);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên Phòng";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Sô Lượng";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn giá";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành Tiền";
            columnHeader4.Width = 70;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(comboBox3);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(numericUpDown2);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Location = new Point(344, 283);
            panel3.Name = "panel3";
            panel3.Size = new Size(447, 60);
            panel3.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.DarkSlateGray;
            textBox1.Location = new Point(226, 18);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(126, 39);
            textBox1.TabIndex = 8;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(5, 36);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(103, 23);
            comboBox3.TabIndex = 7;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Location = new Point(5, 3);
            button5.Name = "button5";
            button5.Size = new Size(103, 33);
            button5.TabIndex = 6;
            button5.Text = "Chuyển Khu";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(116, 34);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(104, 23);
            numericUpDown2.TabIndex = 5;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // button4
            // 
            button4.Location = new Point(114, 1);
            button4.Name = "button4";
            button4.Size = new Size(106, 36);
            button4.TabIndex = 4;
            button4.Text = "Giảm Giá";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(358, 3);
            button3.Name = "button3";
            button3.Size = new Size(86, 54);
            button3.TabIndex = 3;
            button3.Text = "Thanh Toán";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(numericUpDown1);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(comboBox1);
            panel4.Location = new Point(346, 39);
            panel4.Name = "panel4";
            panel4.Size = new Size(444, 77);
            panel4.TabIndex = 6;
            panel4.Paint += panel4_Paint;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(340, 34);
            numericUpDown1.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(84, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(250, 19);
            button2.Name = "button2";
            button2.Size = new Size(75, 49);
            button2.TabIndex = 2;
            button2.Text = "Thêm Phòng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(3, 45);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 23);
            comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 387);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel1;
        private Panel panel2;
        private ListView listView1;
        private Panel panel3;
        private Panel panel4;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Button button2;
        private NumericUpDown numericUpDown2;
        private Button button4;
        private Button button3;
        private ComboBox comboBox3;
        private Button button5;
        private FlowLayoutPanel flowLayoutPanel1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private TextBox textBox1;
    }
}