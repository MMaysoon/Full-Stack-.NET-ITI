using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Lab_02_CRUD_Disconnected_Windows
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=StudentDB;Integrated Security=True;TrustServerCertificate=True;";
        SqlDataAdapter adapter;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter("SELECT * FROM Student", connectionString);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            dt = new DataTable();
           
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void LoadStudents()
        {
            
            dataGridView1.DataSource = dt;
        }
        private void ClearTextBoxes()
        {
            std_Id.Text = "";
            std_Name.Text = "";
            std_courseId.Text = "";
            std_Age.Text = "";
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // 1.Get all
        private void button1_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        //2.Insert
        private void button2_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            row["studentName"] = std_Name.Text;
            row["courseId"] = int.Parse(std_courseId.Text);
            row["age"] = int.Parse(std_Age.Text);

            dt.Rows.Add(row);
            adapter.Update(dt);

            dt.Clear();
            adapter.Fill(dt);

            MessageBox.Show("Student inserted!");
            ClearTextBoxes();
            LoadStudents();
        }

        //3.update
        private void button3_Click(object sender, EventArgs e)
        {
            bool updated = false;
            int id = int.Parse(std_Id.Text);

            foreach (DataRow row in dt.Rows)
            {
                if ((int)row["StudentId"] == id)
                {
                    row["studentName"] = std_Name.Text;
                    row["courseId"] = int.Parse(std_courseId.Text);
                    row["age"] = int.Parse(std_Age.Text);
                    updated = true;
                    break;
                }
            }

            if (updated)
            {
                adapter.Update(dt);
                MessageBox.Show("Student updated!");
            }
            else
            {
                MessageBox.Show("Student not found!");
            }

            ClearTextBoxes();
            LoadStudents();

        }

        //4.Delete
        private void button4_Click(object sender, EventArgs e)
        {
            bool deleted = false;
            int id = int.Parse(std_Id.Text);

            foreach (DataRow row in dt.Rows)
            {
                if ((int)row["StudentId"] == id)
                {
                    row.Delete();
                    deleted = true;
                    break;
                }
            }

            if (deleted)
            {
                adapter.Update(dt);
                MessageBox.Show("Student deleted!");
            }
            else
            {
                MessageBox.Show("Student not found!");
            }

            ClearTextBoxes();
            LoadStudents();

        }
    }
}
