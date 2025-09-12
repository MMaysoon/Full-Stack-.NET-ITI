use Company_SD;

--1.Display the Department id, name and id and the name of its manager.
select d.Dnum ,d.Dnum , e.SSN , e.Fname
from Departments d
inner join employee e on d.MGRSSN=e.SSN

--2.Display the name of the departments and the name of the projects under its control.
select d.Dname as 'department name' , p.Pname as 'project name'
from  departments d
inner join project p on d.dnum = p.Dnum 
order by 1

--3.Display the full data about all the dependence associated with the name of the employee they depend on him/her.
select Dependent.* , Fname+' '+lname as 'Full Name' from Dependent 
left outer join Employee on Dependent.ESSN=Employee.SSN

--4.Display the Id, name and location of the projects in Cairo or Alex city.
select Pnumber , Pname ,Plocation
from Project
where city in ('cairo','alex')

--5.Display the Projects full data of the projects with a name starts with "a" letter.
select *
from Project
where Pname like 'a%'

--6.display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select * 
from Employee
where (dno=30) and (Salary between 1000 and 2000) 

--7.Retrieve the names of all employees in department 10
 --who works more than or equal10 hours per week
 --on "AL Rabwah" project.
select e.Fname+' '+e.Lname as [Full Name] , w.Hours as [hours] , dno , p.Pname
from Employee  e
inner join Works_for w on e.SSN=w.ESSn 
inner join Project p on w.Pno=p.Pnumber
where dno=10 and w.Hours>=10 and p.Pname='AL Rabwah'

--8.Find the names of the employees who directly supervised with Kamel Mohamed.
select e.Fname+' '+e.lname as [Employee Name] , s.Fname+' '+s.lname as [Superviser Name]
from employee e
inner join employee s on e.Superssn=s.SSN 
where concat(s.fname,' ',s.lname) = 'Kamel Mohamed'

 
--9.Retrieve the names of all employees and the names of the projects they are working on, sorted by the project name.
select fname+' '+lname as fullname
from Employee e
inner join Works_for w on e.SSN=w.ESSn
inner join Project p on w.Pno=p.Pnumber 
order by p.Pname

--10.For each project located in Cairo City
  --find the project number
  --the controlling department name 
  --the department manager last name 
  --address and birthdate.
  select p.Pnumber  ,p.City ,d.Dname,e.Lname,e.Bdate,e.Address
  from Project p 
  inner join Departments d on p.Dnum=d.Dnum
  inner join Employee e on d.MGRSSN=e.SSN
  where p.city='cairo'

--11.Display All Data of the managers
select distinct e.*
from employee e
inner join Departments d on e.SSN=d.MGRSSN

--12.Display All Employees data and the data of their dependents even if they have no dependents
select e.* , d.*
from Employee e
left outer join Dependent d on  e.SSN=d.ESSN 

--13.Insert your personal data to the employee table as a new employee in 
--department number 30 , SSN = 102672, Superssn = 112233, salary=3000.
insert into Employee
 (Fname, Lname, SSN, Bdate, Address, Sex, Salary, SuperSSN, Dno)
 VALUES
    ('Maysoon',  'Ahmed', 102672, '2000-02-14', 'Cairo, Egypt', 'F', 3000, 102672, 30);

--14.Insert another employee with personal data your friend as new employee in department number 30, SSN = 102660, but don’t enter any value for salary or supervisor number to him.
insert into Employee
 (Fname, Lname, SSN, Bdate, Address, Sex, Dno)
 VALUES
    ('Menah',  'Ahmed', 102660, '2000-02-14', 'Cairo, Egypt', 'F',  30);

--15.Upgrade your salary by 20 % of its last value.
update employee 
set Salary= (salary*0.20)+Salary
where SSN=102672

update Employee 
set Salary=Salary*1.2
where SSN=102672;

select * from employee where SSN=102672