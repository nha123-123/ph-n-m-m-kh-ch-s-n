namespace duan1
{
    partial class Form3
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
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            textBox3 = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            textBox4 = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            textBox5 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(46, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 66);
            panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 22);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(311, 35);
            textBox1.TabIndex = 51;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 23);
            label1.Name = "label1";
            label1.Size = new Size(71, 17);
            label1.TabIndex = 50;
            label1.Text = "Họ Và Tên";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(46, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(443, 69);
            panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 17);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(311, 37);
            textBox2.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 18);
            label2.Name = "label2";
            label2.Size = new Size(87, 17);
            label2.TabIndex = 50;
            label2.Text = "Tên Hiển Thị";
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(46, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(443, 70);
            panel3.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 22);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(311, 36);
            textBox3.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 23);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 50;
            label3.Text = "Mật Khẩu";
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(46, 264);
            panel4.Name = "panel4";
            panel4.Size = new Size(443, 66);
            panel4.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(124, 24);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(311, 33);
            textBox4.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 24);
            label4.Name = "label4";
            label4.Size = new Size(95, 17);
            label4.TabIndex = 50;
            label4.Text = "Mật Khẩu Mới";
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox5);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(46, 347);
            panel5.Name = "panel5";
            panel5.Size = new Size(443, 66);
            panel5.TabIndex = 52;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(124, 17);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(311, 36);
            textBox5.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 17);
            label5.Name = "label5";
            label5.Size = new Size(63, 17);
            label5.TabIndex = 50;
            label5.Text = "Nhập Lại";
            // 
            // button1
            // 
            button1.Location = new Point(563, 364);
            button1.Name = "button1";
            button1.Size = new Size(75, 49);
            button1.TabIndex = 53;
            button1.Text = "Cập Nhật";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(701, 369);
            button2.Name = "button2";
            button2.Size = new Size(75, 44);
            button2.TabIndex = 54;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Panel panel2;
        private TextBox textBox2;
        private Label label2;
        private Panel panel3;
        private TextBox textBox3;
        private Label label3;
        private Panel panel4;
        private TextBox textBox4;
        private Label label4;
        private Panel panel5;
        private TextBox textBox5;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}