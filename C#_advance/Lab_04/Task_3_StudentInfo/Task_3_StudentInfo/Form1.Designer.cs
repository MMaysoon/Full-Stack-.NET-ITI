namespace Task_3_StudentInfo
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
            stud_id = new TextBox();
            Search = new Button();
            result = new Label();
            SuspendLayout();
            // 
            // stud_id
            // 
            stud_id.Location = new Point(132, 51);
            stud_id.Name = "stud_id";
            stud_id.Size = new Size(261, 29);
            stud_id.TabIndex = 0;
            stud_id.TextAlign = HorizontalAlignment.Center;
            stud_id.TextChanged += stud_id_TextChanged;
            // 
            // Search
            // 
            Search.BackColor = SystemColors.GradientActiveCaption;
            Search.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Search.Location = new Point(432, 51);
            Search.Name = "Search";
            Search.Size = new Size(132, 32);
            Search.TabIndex = 1;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = false;
            Search.Click += Search_Click;
            // 
            // result
            // 
            result.AllowDrop = true;
            result.BackColor = SystemColors.GradientInactiveCaption;
            result.Location = new Point(132, 164);
            result.Name = "result";
            result.Size = new Size(432, 187);
            result.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Controls.Add(Search);
            Controls.Add(stud_id);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox stud_id;
        private Button Search;
        private Label result;
    }
}
