namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp() { Id = 1 ,Name="maysoon",Age=24};
            Emp e2 = new Emp() { Id = 2, Name = "may", Age = 23 };
            Emp e3 = new Emp() { Id = 3, Name = "menah", Age = 22 };
            Emp e4 = new Emp() { Id = 4, Name = "nada", Age = 21 };
         
            //1.Print using Action Delegate
            Console.WriteLine("---------Print ------------");
            Action a1 = e1.Print;
            a1 += e2.Print;  // take method refrence 
            a1.Invoke();

            //2.override Equals
            Console.WriteLine("---------Equals ------------");
            if (e1.Equals(e2))
            {
                Console.WriteLine("e1 equals e2");
            }
            else
            {
                Console.WriteLine("e1 not equal e2");
            }
            


            //3.create departments
            Department d1=new Department() { DeptId = 1 ,DeptName="DotNet"};
            Department d2=new Department() { DeptId = 2 ,DeptName="Analysis"};
            club c1 = new club() { clubId = 2 ,clubName="basketBall"};


            //4.Add Emp to departments and club
            d1.AddEmployee(e1);
            d1.AddEmployee(e2);
            d1.AddEmployee (e3);
            c1.AddEmployee(e1 );
            c1.AddEmployee(e2);


            //5.print Departmet & Employess
            Console.WriteLine("---print Departmet & Employess--");
            Console.WriteLine(d1);
            d1.ListEmployees();

            //6.Print club and Employee
            Console.WriteLine("---print Club & Employess--");
            Console.WriteLine(c1);
            c1.ListMembers();

            //7.Absent -> firing 
            Console.WriteLine("--------Increase Absent-----------");
            e1.IncreaseAbsentDays();
            e1.IncreaseAbsentDays();
            e1.IncreaseAbsentDays();
            e1.IncreaseAbsentDays(); //must firing 

            d1.ListEmployees();
            c1.ListMembers();

        }
    }
}
