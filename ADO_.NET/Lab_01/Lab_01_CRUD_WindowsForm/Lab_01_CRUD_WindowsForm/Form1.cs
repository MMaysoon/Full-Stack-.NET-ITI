using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Lab_01_CRUD_WindowsForm
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=StudentDB;Integrated Security=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void get_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void LoadStudents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "select * from Student";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                var dt = new System.Data.DataTable();
                dt.Load(reader);
                conn.Close();

                dataGridView1.DataSource = dt;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_Click(object sender, EventArgs e)
        {


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "insert into Student (studentName,courseId,age) values (@n1,@n2,@n3)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@n1", std_Name.Text);
                cmd.Parameters.AddWithValue("@n2", int.Parse(std_courseId.Text));
                cmd.Parameters.AddWithValue("@n3", int.Parse(std_Age.Text));

                conn?.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show($"{rows} Student inserted");


                LoadStudents();
                std_Id.Text = "";
                std_Name.Text = "";
                std_courseId.Text = "";
                std_Age.Text = "";
            }
        }

        private void std_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Student WHERE studentId=@id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", std_Id.Text);

                conn?.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show($"{rows} Student deleted");


                LoadStudents();
                std_Id.Text = "";
                std_Name.Text = "";
                std_courseId.Text = "";
                std_Age.Text = "";
            }
        }

        private void update_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "update Student set studentName=@n1,courseId=@n2,age=@n3 where studentId=@id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", std_Id.Text);
                cmd.Parameters.AddWithValue("@n1", std_Name.Text);
                cmd.Parameters.AddWithValue("@n2", int.Parse(std_courseId.Text));
                cmd.Parameters.AddWithValue("@n3", int.Parse(std_Age.Text));


                conn?.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show($"{rows} Student updated");


                LoadStudents();
                std_Id.Text = "";
                std_Name.Text = "";
                std_courseId.Text = "";
                std_Age.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
