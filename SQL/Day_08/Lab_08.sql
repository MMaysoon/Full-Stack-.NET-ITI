--1.ITI DB - Create SP - Without Paramter  
  --Show numbers of student per department
  use iti;
 
  create procedure StudDept 
  as
    select d.Dept_Name as [Department Name] ,count(s.st_id) as [Number of Student]
	from student s 
	inner join Department d on s.Dept_Id=d.Dept_Id
	group by d.Dept_Name


  studDept
  

--2.SP 
    -- check n.of employees in project P1
	    -- more than 3 -> display msg
		-- less than  -> display msg + full name of employee
	use Company_SD;
	alter procedure ProjectEmployees  @pname varchar(20) ,@num int =null
	as 
	   select @num=count(w.Essn)
	   from Project p
	   inner join Works_for w on p.Pnumber=w.Pno
	   inner join Employee e on w.ESSn=e.SSN

	   if (@num>3)
	      select 'The number of employess in project '+@pname+'is 3 or more'
	  else 
	      select 'The following employees work for the project '+@pname
		  union all
		  select e.Fname+' '+e.Lname as [Full Name]
		  from Project p
	      inner join Works_for w on p.Pnumber=w.Pno
	      inner join Employee e on w.ESSn=e.SSN

   ProjectEmployees 'AL Solimaniah'


--3.Sp 
    --old employee left the project and new one become instead
	-- sp take 3 paramters (old emp.num ,new emp.num ,project number)
	-- to  update works_on table
	create procedure UpdateWorks @old int ,@new int ,@pnum int
	as 
	   begin try 
	      update Works_for
		   set ESSn=@new 
		     where ESSn=@old and Pno=@pnum
	   end try
	   begin catch 
	      select 'Error'
	   end catch
   
  UpdateWorks 968574,102660,700


--4.Trigger
    -- 1.add budget column in project table
	-- 2.Create audit table  (pnum , username , modificationdate , budget_old , budget_new)
	 use Company_SD;

	 alter table project add Budget int;

	 select * from Project

	 UPDATE Project
     SET Budget = 100000  
     WHERE Pnumber in (100,200,300,400,500,600,700); 


	 create table Audit
	 (
	    ProjectNo int not null ,
		UserName varchar(30) not null , 
		ModificationDate  date,
		Budget_Old money not null  ,
		Budget_New money not null
	 )

	
	 create trigger update_Aduit
	 on project 
	 after update 
	 as  
	      if update(budget)
		  begin
		     declare @old int , @new int , @pnum int 
			 select @old=budget from deleted
			 select @new=budget from inserted
			 select @pnum =Pnumber from inserted

			 insert into Audit 
			 values (@pnum,SUSER_NAME(),GETDATE(),@old,@new)
		  end

	update Project
	   set budget=500
	   where Pnumber=100

	select * from audit


--5.Trigger 
    -- prevent anyone from insering new record
	-- in department table 
	-- with msg 'can't insert'
	 use iti
	 create trigger prevent_insert
	 on department 
	 instead of insert 
	 as  select 'you can not insert a new record in these table'

	insert into Department (Dept_Id, Dept_Name)
     values (10, 'SQL');


--6.trigger 
    -- prevent inset in employee table in march
	  use Company_SD
	  create trigger Prevent_InsertEmp
	  on employee
	  after insert 
	  as 
	     if format(getdate(),'MM') ='March'
		   rollback


--7.Trigger 
    -- on student table after insert
	-- studentAudit (server name , date ,note)

	use iti ;

	create table StudAudit
	(
	   userName varchar(30) not null,
	   ModificationDate date ,
	   note varchar(100)
	)

	create trigger update_Audit 
	on student 
	after insert 
	as 
	   insert into StudAudit 
	   values (SUSER_NAME(),GETDATE(),SUSER_NAME()
	   +'insert new row with key = [' + CONVERT(varchar(20),  (select st_id from inserted))+'] in table student')

	insert into student (st_id,st_fname) values (200,'Maysoon')
	select * from studAudit

--8.trigger
   --on student table  , delete
   create trigger student_delete
	on student 
	instead of delete
	as 
	   insert into StudAudit 
	   values (SUSER_NAME(),GETDATE(),SUSER_NAME()
	   +'try to delete row with key = [' + CONVERT(varchar(20),  (select st_id from deleted))+'] in table student')

	   delete from student where st_id=1

	   select * from StudAudit

	   