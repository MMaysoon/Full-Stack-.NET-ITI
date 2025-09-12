create database Lab3_DB;
GO

USE Lab3_DB;
GO

create table Instructor (
  IntID int identity (1,1) Primary key,
  fname varchar(50),
  lname varchar(50),
  BirthDate Date, 
  Address varchar(10) Check (Address in ('cairo','alex')),
  Salary Decimal (8,2) Check (Salary between 1000 and 5000) default 3000,
  Overtime Decimal(10,2) Unique,
  HireDate Date Default GetDate(),
  Age AS (YEAR(GETDATE()) - YEAR(BirthDate)),
  NetSalary as (Salary +Overtime)
);

create table Course (
CourseID int identity(1,1) primary key ,
CourseName VarChar(50),
Duration int Unique
)

create table lab (
 LabId int ,
 CourseId int ,
 Capacity int Check(capacity<20),
 Constraint c1 Primary Key (LabId , CourseId),
 Constraint c2 Foreign Key (CourseId) REFERENCES Course(CourseID)
 on Delete Cascade 
 on Update cascade 
)

create table tech (
 InstId int ,
 CourseId int ,
 Constraint t1 PRIMARY KEY (InstId, CourseId),
 Constraint t2 FOREIGN KEY (InstID) REFERENCES Instructor(IntID)
        ON DELETE CASCADE
        ON UPDATE CASCADE, 
 Constraint t3 FOREIGN KEY (CourseId) REFERENCES Course(CourseID)
        ON DELETE CASCADE
        ON UPDATE CASCADE
)