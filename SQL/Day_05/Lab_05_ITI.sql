use iti;

--1.Retrieve number of students who have a value in their age. 
 select count(St_Id)
 from hr.student 
 where st_age is not null

--2.Get all instructors Names without repetition
 select distinct Ins_Name
 from jupter.Instructor

--3.Display student with the following Format (use isNull function)
   --Student ID	 Student Full Name	Department name
   select s.st_id as [Student Id] ,isnull(s.St_Fname+' '+s.St_Lname,'Studnet full name') as [Student Full Name],
   isnull(d.Dept_Name,'No Department') as [Department Name]
   from hr.student s
   inner join hr2.department d on s.Dept_Id=d.Dept_Id

--4.Display instructor Name and Department Name 
  --display all the instructors if they are attached to a department or not
  select i.Ins_Name , d.Dept_Name
  from jupter.Instructor i 
  left outer join hr2.Department d on i.Dept_Id=d.Dept_Id

--5.Display student full name and the name of the course he is taking
   --For only courses which have a grade
    select s.St_Fname+' '+s.St_Lname as FullName , c.Crs_Name as courseName
	from hr.student s
	inner join Stud_Course sc on s.St_Id=sc.St_Id
	inner join Course c on sc.Crs_Id=c.Crs_Id
	where sc.Grade is not null
  
--6.Display number of courses for each topic name
    select t.Top_Name ,count(c.Top_Id)
	from Course c
	inner join topic t on c.Top_Id=t.Top_Id
	group by t.Top_Name

--7.Display max and min salary for instructors
   select max(i.Salary) ,min(i.Salary)
   from jupter.Instructor i

--8.Display instructors who have salaries less than the average salary of all instructors.
   select *
   from jupter.Instructor i 
   where i.Salary < (select avg(Salary) from jupter.Instructor)

--9.Display the Department name that contains the instructor who receives the minimum salary.
   select d.Dept_Name
   from hr2.Department d
   inner join jupter.Instructor i on d.Dept_Id=i.Dept_Id
   where i.Salary = (select min(Salary) from jupter.Instructor)

--10.Select max two salaries in instructor table. 
  select distinct top(2) salary 
  from jupter.Instructor
  order by Salary desc

--11.Select instructor name and his salary 
    --but if there is no salary display instructor bonus keyword. “use coalesce Function”
	select i.Ins_Name , coalesce(convert(varchar(20),i.Salary),' bonus')
	from jupter.Instructor i

--12.Select Average Salary for instructors 
select avg(salary) from jupter.Instructor

--13.Select Student first name and the data of his supervisor 
select s.St_Fname , m.*
from hr.student s
inner join hr.student m on s.St_super=m.St_Id

--14.Write a query to select the highest two salaries in Each Department 
  --for instructors who have salaries. “using one of Ranking Functions”
  select *
  from (
         select * , ROW_NUMBER() over (partition by i.dept_id order by i.salary desc ) as rn
		 from jupter.Instructor i
       ) as func1 where rn<=2

--15.Write a query to select a random student from each department.  “using one of Ranking Functions”
   select * 
   from (
            select * , ROW_NUMBER() over (partition by dept_id order by newid()) as rk
			from hr.Student
			where Dept_Id is not null
        ) as func2 where rk=1
