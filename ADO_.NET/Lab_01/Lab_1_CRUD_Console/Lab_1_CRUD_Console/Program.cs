using Azure;
using Microsoft.Data.SqlClient;
using System.Xml.Serialization;

namespace Lab_1_CRUD_Console
{
    internal class Program
    {
        static string connectionString = "Server=localhost\\SQLEXPRESS;Database=StudentDB;Integrated Security=True;TrustServerCertificate=True;";

        static void Main(string[] args)
        {

            Console.WriteLine("--- CRUD Menu ---");
            Console.WriteLine("1. Insert Student");
            Console.WriteLine("2. Get All Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine();

           while(true)
           {
                switch (choice)
                {
                    case "1":
                        InsertStudent();
                        break;
                    case "2":
                        GetAllStudents();
                        break;
                    case "3":
                        UpdateStudent();
                        break;
                    case "4":
                        DeleteStudent();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
           }
        }

        //1.Create student 
        static void InsertStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter CourseId: ");
            int courseId = int.Parse(Console.ReadLine());

            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            using (SqlConnection conn=new SqlConnection(connectionString))
            {
                string query = "insert into Student (studentName,courseId,age) values (@n1,@n2,@n3)";
                SqlCommand cmd=new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@n1", name);
                cmd.Parameters.AddWithValue("@n2", courseId);
                cmd.Parameters.AddWithValue("@n3", age);

                conn?.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                Console.WriteLine($"{rows} Student inserted");
            }


        }

         // 2.Read
         static void GetAllStudents()
         {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "select * from Student";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader=cmd.ExecuteReader();
                Console.WriteLine("\n--- Student List ---");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader[0]}-{reader[1]}-{reader[2]}-{reader[3]}");
                }
                conn.Close() ;
            }
         }

        // 3.Update
        static void UpdateStudent()
        {
            Console.Write("Enter StudentId to Update: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter New Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter New CourseId: ");
            int courseId = int.Parse(Console.ReadLine());

            Console.Write("Enter New Age: ");
            int age = int.Parse(Console.ReadLine());

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "update Student set studentName=@n1,courseId=@n2,age=@n3 where studentId=@id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@n1", name);
                cmd.Parameters.AddWithValue("@n2", courseId);
                cmd.Parameters.AddWithValue("@n3", age);
                

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                Console.WriteLine($"{rows} student updated.");
            }

        }

        //4.Delete
        static void DeleteStudent ()
        {
            Console.Write("Enter StudentId to delete: ");
            int id = int.Parse(Console.ReadLine());

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Student WHERE studentId=@id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                Console.WriteLine($"{rows} student deleted.");
            }
        }
    }
}
