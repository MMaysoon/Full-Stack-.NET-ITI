use Company_SD;
--1.Display (Using Union Function)
   --a.The name and the gender of the dependence that's gender is Female and depending on Female Employee.
   --b. And the male dependence that depends on Male Employee.
    select d.Dependent_name , d.Sex
	from Dependent d
	inner join employee e on d.ESSN=e.SSN and d.Sex='f' and e.Sex='f'
	union
	select d.Dependent_name , d.Sex
	from Dependent d
	inner join employee e on d.ESSN=e.SSN and d.Sex='m' and e.Sex='m'


--2.For each project, list the project name and the total hours per week (for all employees) spent on that project.
   -- get projet name , (sum) of hours (group by) project
   select p.Pname , sum(w.hours) as [total hours]
   from project p
   inner join Works_for w on p.Pnumber=w.Pno
   inner join employee e on  w.ESSn=e.SSN
   group by p.Pname
  
--3.Display the data of the department which has the smallest employee ID(ssn) over all employees' ID.
    select d.*
	from Departments d
	left outer join employee e on d.Dnum=e.dno 
	where e.SSN = (select min(ssn) from Employee )

--4.For each department, retrieve the department name and the maximum, minimum and average salary of its employees.
       select d.Dname , Max(e.Salary) , min(e.salary) , Avg(e.salary)
	   from Departments d
	   inner join Employee e on d.Dnum=e.Dno
	   group by d.Dname

		
--5.	List the full name of all managers who have no dependents.
        -- manger for department 
		-- department & dependent
		-- not have any dependent (not in ) OR (not exists)
		select e.fname+' '+e.Lname
		from employee e
		inner join Departments d on e.SSN=d.MGRSSN
		and not exists (select * from Dependent dd where d.MGRSSN=dd.ESSN)

--6.For each department
  -- if its average salary is less than the average salary of all employees
  -- display its number, name and number of its employees.
     select d.Dname , avg(e.salary) , count(e.ssn)
	 from Departments d
	 inner join Employee e  on d.Dnum=e.dno
	 group by d.dname
	 having avg(e.salary) < (select avg(salary) from employee)

 
--7.Retrieve a list of employee’s names and the projects names
   --they are working on ordered by department number and within each department
   --ordered alphabetically by last name, first name.
   select e.Fname , p.Pname 
   from Employee e
   inner join Works_for w on e.SSN=w.ESSn
   inner join Project p on p.Pnumber=w.Pno
   inner join Departments d  on p.Dnum=d.Dnum
   order by d.Dnum ,e.Lname , e.fname
   
 
--8.Try to get the max 2 salaries using sub query
    select distinct * from employee
	where Salary in (select distinct top(2) salary from employee order by Salary desc)

--9.Get the full name of employees that is similar to any dependent name
    select distinct e.fname+' '+e.lname
	from employee e
	inner join Dependent d on e.SSN=d.ESSN
	where d.Dependent_name like '%'+e.fname+' '+e.lname+'%'

--10.Display the employee number and name if at least one of them have dependents (use exists keyword).
     select e.*
	 from Employee e
	 where  exists (select* from Dependent d where d.ESSN=e.ssn)
	 
--11.In the department table
  --insert new department called "DEPT IT”, with id 100, employee with SSN = 112233 as a manager for this department.
  --The start date for this manager is '1-11-2006'
    insert into Departments values ('DEPT IT', 100, 112233, '2006-11-01');
      
--12.Do what is required 
   --if you know that : Mrs.Noha Mohamed(SSN=968574) 
   --moved to be the manager of the new department (id = 100),
   --and they give you(your SSN =102672) her position (Dept. 20 manager) 

   --a.	First try to update her record in the department table
        update Departments
		set MGRSSN=968574
		where Dnum=100;
  
  --b.	Update your record to be department 20 manager. 
       update Departments
	   Set MGRSSN=102672
	   where Dnum=20;

  --c.Update the data of employee number=102660 to be in your teamwork (he will be supervised by you) (your SSN =102672)
      update Employee
	   set Superssn=102672
	   where SSN=102660;


--13.Unfortunately the company ended the contract with Mr. Kamel Mohamed (SSN=223344)
  --so try to delete his data from your database in case you know
  --that you will be temporarily in his position.
   --Check if Mr. Kamel has dependents, works as a department manager, supervises any employees or works in any projects 
   
       -- 1-Delete Dependent 
	   delete from Dependent
	   where ESSN=223344;

	   -- 2-Update Department manger with another manger
	   update Departments
	   set MGRSSN=102672
	   where MGRSSN=223344;

	   -- 3-Change to another Supervises employees
	   update Employee
	   set Superssn=102672
	   where Superssn=223344;

	   -- 4-Delete works-on
	   delete from Works_for
	   where ESSn=223344;

	   -- Delete the employee
	   delete from Employee
	   where SSN=223344;

--14.	Try to update all salaries of employees who work in Project ‘Al Rabwah’ by 30%
   update employee 
   set Salary+=salary*0.3
   from Employee e 
   inner join Works_for w on e.SSN=w.ESSn
   inner join project p on w.Pno=p.Pnumber
   where p.Pname='Al Rabwah'
            
   
    

