use iti;

--1.Create a scalar function that takes date and returns Month name of that date.
create function getMonth (@x date)
returns varchar(20)
as 
    begin
	   declare @m varchar(20) ;
	   set @m = DateName(Month,@x);
	   return @m
	end

select dbo.getMonth('2001-02-14')

--2. Create a multi-statements table-valued function that takes 2 integers and returns the values between them.
create function Betweens (@start int , @end int)
returns @t table (num int)
as 
     begin
	    declare @i int =@start
		while(@i<=@end)
		  begin
		   insert into @t (num) values (@i)
		   set @i+=1
		 end
		return
	 end
select * from dbo.betweens(2,5)

--3.Create inline function that takes Student No and returns Department Name with Student full name.
create function StudInfo (@id int)
returns table 
as 
   return 
   (
     select Dept_Name as DepartmentName , St_Fname+' '+St_Lname as 'Full Name'
	 from student
	 join department on student.Dept_Id=Department.Dept_Id
	 where @id=student.St_Id
   )
select * from dbo.StudInfo(2)

--4.Create a scalar function that takes Student ID and returns a message to user 
   --a.If first name and Last name are null then display 'First name & last name are null'
   --b.If First name is null then display 'first name is null'
   --c.If Last name is null then display 'last name is null'
   --d.Else display 'First name & last name are not null'
   create function msg(@id int)
   returns varchar(20)
   as 
      begin
	    declare @msg varchar(50) 
	    declare @Fname varchar(50) 
	    declare @Lname varchar(50) 

	    select @Fname=St_Fname , @Lname=St_Lname
	    from student where st_id=@id

	    if (@Fname is null) and (@Lname is null)
	      set @msg='First name and Last name is null'
	    else if (@Fname is null)
	       set @msg='First name is null'
	    else if (@Lname is null)
	       set @msg='Last name is null'
	   else
	       set @msg='Both Not Null'
	   return @msg
	  end
 select dbo.msg(5)

--5.Create inline function that takes integer which represents manager ID
  --and displays department name, Manager Name and hiring date 
  create function DeptInfo (@mID int)
  returns table 
  as return (
                select d.Dept_Name ,i.Ins_Name,d.Manager_hiredate
                from Department d
                inner join Instructor i on d.Dept_Id=i.Dept_Id
                where d.Dept_Manager=@mid
           )
  select * from DeptInfo(20)

--6.Create multi-statements table-valued function that takes a string
   --If string='first name' returns student first name
   --If string='last name' returns student last name 
   --If string='full name' returns Full Name from student table 
   --Note: Use “ISNULL” function
    create function CString (@s varchar(50))
	returns @t table ( sName varchar(50))
	as 
	   begin
	    if (@s='first name')
		  insert into @t
		  select isnull(st_fname,'fname') from student
		else if (@s='last name')
		  insert into @t
		  select isnull(st_lname,'lname') from student
        else if (@s='Full name')
		  insert into @t
		  select isnull(st_fname+' '+st_lname,'Full name') from student
	    return
	   end
	   
	   select * from dbo.CString('first name')

--7.Write a query that returns the Student No and Student first name without the last char
select st_id ,substring(st_fname,1,len(st_fname)-1)
from student

--8.Wirte query to delete all grades for the students Located in SD Department 
delete Stud_Course 
from Stud_Course 
join Student on Stud_Course.St_Id=Student.St_Id
join Department on Student.Dept_Id=Department.Dept_Id
where Department.Dept_Name='SD'

--9.Using Merge statement between the following two tables [User ID, Transaction Amount]
merge into LastTranscations as l
using DailyTranscations as d on l.UserID = d.UserID
when matched then
    update set l.transactionAmount=d.transactionAmount
when not matched by target then
    insert(UserID,transactionAmount) 
	values(d.UserID,d.transactionAmount)
when not matched by source then
    delete;
 

--10.	Try to Create Login Named(ITIStud) who can access Only student and Course tablesfrom ITI DB then allow him to select and insert data into tables and deny Delete and update

