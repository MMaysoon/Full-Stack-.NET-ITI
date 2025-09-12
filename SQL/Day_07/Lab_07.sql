use iti;

--1.View -> Display student full name ,course name 
   -- is student has grade more than 50
   create view Student_Info
   as 
      select s.St_Fname+' '+s.St_Lname as [Full Name], c.Crs_Name as [Course Name]
	  from student s
	  inner join Stud_Course sc on s.St_Id=sc.St_Id
	  inner join Course c on sc.Crs_Id=c.Crs_Id
	  where sc.Grade>=50

	select * from Student_Info

--2.Encrapted View -> dispaly mangers name and topices thes teach
 
	create view Manger_InfO
	 with encryption 
     as
      select   i.Ins_Name as [Manger Name] , t.Top_Name as [Topic Name]
	  from Department d
	   inner join Instructor i  on d.Dept_Manager=i.Ins_Id
	   inner join Ins_Course ci on i.Ins_Id=ci.Ins_Id
	   inner join Course c on ci.Crs_Id=c.Crs_Id
	   inner join topic t on t.Top_Id=c.Top_Id

	select * from Manger_info

	sp_helptext 'Manger_info'

--3.View -> instructor name , department name -for sd and java department
    create view Department_Info
	as 
	   select i.Ins_Name as [Instructor Name ] , d.Dept_Name as [Department Name]
	   from Instructor i 
	   inner join Department d on i.Dept_Id=d.Dept_Id
	   where Dept_Name in ('sd','java')

	select * from Department_Info

-- 4.create view 'v1' 
     -- display student data who lives in alex or cairo
	 create view v1 
	 as 
	  select * from Student
	  where St_Address in ('cairo','alex')
	  with check option ;

	select * from v1;

	-- prevent run these query -> add check option
	  update v1
	   set St_Address'tanta'
	   where St_Address='alex'   ---False

--5.create view - Comapny DB
    -- display project name and number of employess work on it
     use Company_SD;
	 create view ProjectInfo
	 as 
	    select p.Pname as [Project Name] , count(w.ESSn) as [Employess Number]
		from Project p
		inner join Works_for w on p.Pnumber=w.Pno
		inner join Employee e on w.ESSn=e.SSN
		group by p.Pname

	select * from ProjectInfo;
--6.Create schema 
    use Company_SD;
   --a.Company Schema transfer (Department , Project)
   create schema company;
   alter schema company transfer departments;
   select * from company.departments
   select * from company.project

   --b.Human Resourse transfer (Employee)
   create schema HumanResourse
   alter schema humanResourse transfer employee
   select * from humanresourse.employee

--7.ITI DB -> Depatment Table -> Cluster index (mangager_hiredate)
    -- Can't creake cluster index , it aready have pk 
	-- So create non cluster index
	use iti;
	create nonclustered index  Manger_HireDate on Department(Manager_hiredate)

--8.create index 
   -- allow to add unique ages
   --ITI DB - student table 
   --What happen?
    create unique index AgeIndex on student(st_age)
	--xxx Error -> have duplicated age value so can't apply

--9.Company DB -> Cursor update Salary 
     --(10% <3000)  (20% >=3000)
	 use Company_SD;
	 declare c1 cursor for
	 select Salary from HumanResourse.Employee
	 for update 
	 declare @sal money 
	 open c1
	 fetch c1 into @sal 
	 while @@FETCH_STATUS=0
	   begin
	      if @sal<3000
		   update HumanResourse.Employee
		    set Salary+=Salary*0.1
		 where current of c1
		 else if @sal>=3000
		   update HumanResourse.Employee
		    set Salary+=Salary*0.2
		   where current of c1
		fetch c1 into @sal
	   end
	close c1
	deallocate c1
	    
--10.ITI DB -> Cusror
  --display department name and manger name
    use iti;
	declare  DepatINst cursor for 
	select d.Dept_Name as[Department Name] , i.Ins_Name as [Instructor Name]
	from Department d
	inner join Instructor i on d.Dept_Manager=i.Ins_Id
	for read only 
	declare @manger varchar(20) ,@department varchar(20)
	open DepatINst
	fetch DepatINst into  @department , @manger
	while @@FETCH_STATUS=0
	  begin 
	     select @department ,@manger
		 fetch DepatINst into @department ,@manger
	  end
	close DepatINst
	deallocate DepatINst



--11.Create Cursor  - ITI DB
   -- dispaly all instructor name sperated by comma
  declare c2 cursor for
  select distinct Ins_Name
  from Instructor
  where Ins_Name is not null
  for read only
  declare @namex varchar(20) , @all_names varchar(300)=''
  open c2
  fetch c2 into @namex 
  while @@FETCH_STATUS=0
    begin
	   set @all_names=concat(@all_names,',',@namex)
	   fetch c2 into @namex
	end
  close c2
  deallocate c2

--12.Try to generate script from ITI DB 
     -- describe tables and view 
	  