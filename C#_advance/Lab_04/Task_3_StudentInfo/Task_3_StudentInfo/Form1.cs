namespace Task_3_StudentInfo
{
    public partial class Form1 : Form
    {
        // 1.list of students 
        List<Student> students;
        public Form1()
        {
            InitializeComponent();


            //2.initalize set of students
            students = new List<Student>()
        {
            new Student(){ Id = 1, Name = "Maysoon", Age = 24},
            new Student(){ Id = 2, Name = "Menah Allah", Age = 22 },
            new Student(){ Id = 3, Name = "Mohammed", Age = 19 }
        };
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (int.TryParse(stud_id.Text, out int id))
            {
                var student = students.FirstOrDefault(s => s.Id == id);
                if (student != null)
                {
                    result.Text = $"ID: {student.Id}\nName: {student.Name}\nAge: {student.Age}";
                }
                else
                {
                    result.Text = "Student not found!";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            stud_id.Text = "";
        }

        private void stud_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
