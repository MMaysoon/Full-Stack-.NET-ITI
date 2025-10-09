namespace Lab_02_CRUD_Disconnected_Windows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            std_Id = new TextBox();
            std_Name = new TextBox();
            std_courseId = new TextBox();
            std_Age = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(183, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 34);
            textBox1.TabIndex = 0;
            textBox1.Text = "Student Form";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // std_Id
            // 
            std_Id.Location = new Point(161, 74);
            std_Id.Name = "std_Id";
            std_Id.Size = new Size(180, 29);
            std_Id.TabIndex = 1;
            std_Id.TextChanged += textBox2_TextChanged;
            // 
            // std_Name
            // 
            std_Name.Location = new Point(161, 119);
            std_Name.Name = "std_Name";
            std_Name.Size = new Size(180, 29);
            std_Name.TabIndex = 2;
            // 
            // std_courseId
            // 
            std_courseId.Location = new Point(161, 172);
            std_courseId.Name = "std_courseId";
            std_courseId.Size = new Size(180, 29);
            std_courseId.TabIndex = 3;
            // 
            // std_Age
            // 
            std_Age.Location = new Point(161, 218);
            std_Age.Name = "std_Age";
            std_Age.Size = new Size(180, 29);
            std_Age.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(479, 66);
            button1.Name = "button1";
            button1.Size = new Size(182, 43);
            button1.TabIndex = 5;
            button1.Text = "Get All Data";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(479, 119);
            button2.Name = "button2";
            button2.Size = new Size(182, 43);
            button2.TabIndex = 6;
            button2.Text = "Insert";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.CausesValidation = false;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(479, 168);
            button3.Name = "button3";
            button3.Size = new Size(182, 43);
            button3.TabIndex = 7;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(479, 231);
            button4.Name = "button4";
            button4.Size = new Size(182, 43);
            button4.TabIndex = 8;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(132, 316);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(563, 159);
            dataGridView1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 84);
            label1.Name = "label1";
            label1.Size = new Size(26, 23);
            label1.TabIndex = 10;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 127);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 11;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(53, 171);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 12;
            label3.Text = "CourseId";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(53, 221);
            label4.Name = "label4";
            label4.Size = new Size(42, 23);
            label4.TabIndex = 13;
            label4.Text = "Age";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 516);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(std_Age);
            Controls.Add(std_courseId);
            Controls.Add(std_Name);
            Controls.Add(std_Id);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox std_Id;
        private TextBox std_Name;
        private TextBox std_courseId;
        private TextBox std_Age;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
