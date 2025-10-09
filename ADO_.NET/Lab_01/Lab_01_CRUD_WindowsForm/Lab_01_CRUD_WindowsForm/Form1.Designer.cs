namespace Lab_01_CRUD_WindowsForm
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
            std_Age = new TextBox();
            std_courseId = new TextBox();
            std_Name = new TextBox();
            std_Id = new TextBox();
            Id = new Label();
            sName = new Label();
            Age = new Label();
            label5 = new Label();
            CourseId = new Label();
            get = new Button();
            insert = new Button();
            update = new Button();
            delete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // std_Age
            // 
            std_Age.Location = new Point(146, 240);
            std_Age.Name = "std_Age";
            std_Age.Size = new Size(161, 29);
            std_Age.TabIndex = 0;
            // 
            // std_courseId
            // 
            std_courseId.Location = new Point(146, 189);
            std_courseId.Name = "std_courseId";
            std_courseId.Size = new Size(161, 29);
            std_courseId.TabIndex = 1;
            // 
            // std_Name
            // 
            std_Name.Location = new Point(146, 139);
            std_Name.Name = "std_Name";
            std_Name.Size = new Size(161, 29);
            std_Name.TabIndex = 2;
            std_Name.TextChanged += std_Name_TextChanged;
            // 
            // std_Id
            // 
            std_Id.Location = new Point(146, 87);
            std_Id.Name = "std_Id";
            std_Id.Size = new Size(161, 29);
            std_Id.TabIndex = 3;
            std_Id.TextChanged += textBox4_TextChanged;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Id.Location = new Point(53, 89);
            Id.Name = "Id";
            Id.Size = new Size(26, 23);
            Id.TabIndex = 4;
            Id.Text = "Id";
            Id.Click += label1_Click;
            // 
            // sName
            // 
            sName.AutoSize = true;
            sName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sName.Location = new Point(53, 146);
            sName.Name = "sName";
            sName.Size = new Size(57, 23);
            sName.TabIndex = 5;
            sName.Text = "Name";
            sName.Click += label2_Click;
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Age.Location = new Point(53, 247);
            Age.Name = "Age";
            Age.Size = new Size(42, 23);
            Age.TabIndex = 7;
            Age.Text = "Age";
            Age.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoEllipsis = true;
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(182, 21);
            label5.Name = "label5";
            label5.Size = new Size(404, 28);
            label5.TabIndex = 10;
            label5.Text = "Student Form";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // CourseId
            // 
            CourseId.AutoSize = true;
            CourseId.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CourseId.Location = new Point(53, 196);
            CourseId.Name = "CourseId";
            CourseId.Size = new Size(80, 23);
            CourseId.TabIndex = 12;
            CourseId.Text = "CourseId";
            // 
            // get
            // 
            get.BackColor = SystemColors.GradientInactiveCaption;
            get.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            get.Location = new Point(457, 89);
            get.Name = "get";
            get.Size = new Size(194, 44);
            get.TabIndex = 13;
            get.Text = "Get All Data";
            get.UseVisualStyleBackColor = false;
            get.Click += get_Click;
            // 
            // insert
            // 
            insert.BackColor = SystemColors.GradientInactiveCaption;
            insert.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insert.Location = new Point(457, 145);
            insert.Name = "insert";
            insert.Size = new Size(194, 45);
            insert.TabIndex = 14;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = false;
            insert.Click += insert_Click;
            // 
            // update
            // 
            update.BackColor = SystemColors.GradientInactiveCaption;
            update.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update.Location = new Point(457, 196);
            update.Name = "update";
            update.Size = new Size(194, 51);
            update.TabIndex = 15;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click_1;
            // 
            // delete
            // 
            delete.BackColor = SystemColors.GradientInactiveCaption;
            delete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete.Location = new Point(457, 259);
            delete.Name = "delete";
            delete.Size = new Size(194, 47);
            delete.TabIndex = 16;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(53, 327);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(720, 215);
            dataGridView1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 554);
            Controls.Add(dataGridView1);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(insert);
            Controls.Add(get);
            Controls.Add(CourseId);
            Controls.Add(label5);
            Controls.Add(Age);
            Controls.Add(sName);
            Controls.Add(Id);
            Controls.Add(std_Id);
            Controls.Add(std_Name);
            Controls.Add(std_courseId);
            Controls.Add(std_Age);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox std_Age;
        private TextBox std_courseId;
        private TextBox std_Name;
        private TextBox std_Id;
        private Label Id;
        private Label sName;
        private Label Age;
        public Label label5;
        private Label CourseId;
        private Button get;
        private Button insert;
        private Button update;
        private Button delete;
        private DataGridView dataGridView1;
    }
}
