using Microsoft.Data.SqlClient;
using System.Data;

namespace Lab_02_CRUD_Disconnected_Console
{
    internal class Program
    {
        static string connectionString = "Server=localhost\\SQLEXPRESS;Database=StudentDB;Integrated Security=True;TrustServerCertificate=True;";
        static SqlDataAdapter adapter;
        static DataTable dt;

        static void Main(string[] args)
        {
            adapter = new SqlDataAdapter("select * from Student", connectionString);

            // Command for Insert/Update/Delete
            SqlCommandBuilder builder =new SqlCommandBuilder(adapter);

            dt=new DataTable();
            adapter.Fill(dt);

            while(true)
            {
                Console.WriteLine("--- CRUD Menu ---");
                Console.WriteLine("1. Insert Student");
                Console.WriteLine("2. Get All Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Choose: ");
                string choice = Console.ReadLine();

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

            //1.Create student 
            static void InsertStudent()
            {
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter CourseId: ");
                int courseId = int.Parse(Console.ReadLine());

                Console.Write("Enter Age: ");
                int age = int.Parse(Console.ReadLine());

                DataRow row=dt.NewRow();
                row["studentName"] = name;
                row["courseId"] = courseId;
                row["age"] = age;

                dt.Rows.Add(row);
                adapter.Update(dt);

                Console.WriteLine("Student inserted!");


            }

            // 2.Read
            static void GetAllStudents()
            {
                    Console.WriteLine("\n--- Student List ---");
                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine($"{row["studentId"]} - {row["studentName"]} - {row["CourseId"]} - {row["age"]}");
                   }
                
            }

            // 3.Update
            static void UpdateStudent()
            {
                Console.Write("Enter StudentId to Update: ");
                int id = int.Parse(Console.ReadLine());

                bool updated= false;

                foreach (DataRow row in dt.Rows)
                {
                    if ((int)row["StudentId"] == id)
                    {
                        Console.Write("Enter New Name: ");
                        row["studentName"] = Console.ReadLine();

                        Console.Write("Enter New CourseId: ");
                        row["courseId"] = int.Parse(Console.ReadLine());

                        Console.Write("Enter New Age: ");
                        row["age"] = int.Parse(Console.ReadLine());
                        updated = true;
                        break;
                    }
                }

                if (updated)
                {
                    adapter.Update(dt); 
                    Console.WriteLine("Student updated!");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }



            }

            //4.Delete
            static void DeleteStudent()
            {
                Console.Write("Enter StudentId to delete: ");
                int id = int.Parse(Console.ReadLine());

                bool deleted = false;

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
                    Console.WriteLine("Student deleted!");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }


            }



        }

    }
}
