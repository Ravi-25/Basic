create function CalcAge(@DOB date)
returns int
as
begin
declare @age int
set @age= DATEDIFF(year,@DOB,getdate()) -
           case
		   when (MONTH(@DOB)>MONTH(getdate())) or
		        (MONTH(@DOB) = MONTH(GETDATE())  and day(@DOB) > day(getdate()))
				then 1
				else 0
			end
			return @age
			end

select sample.dbo.calcage('06/25/1985')

select empname, hiredate, dbo.calcage(hiredate) as exprience from Demodb.dbo.Employee1 where dbo.calcage(hiredate)>36

create function fu_EmpByGender(@gender nvarchar(10))  -- inline funtion
returns table
as
return (select name, salary, gender from tblEmployee where gender=@gender)

select * from fu_EmpByGender('female') -- using a inline function with where clause

select name, gender, departmentname from fu_EmpByGender('male') E 
join department D on D.ID=E.departmentid

--multi statement table valued functions

create function mstvf_getemployee()
returns @table table (Id int,name varchar(20),hiredate datetime)
as
begin
insert into @table 
select pkempid, empname,cast(hiredate as date) as Hiredate from Demodb.dbo.Employee1
return
end

select cast(hiredate as date) as hiredate from Demodb.dbo.Employee1

select * from sample.dbo.mstvf_getemployee()

--temp tables

create table #persondetails (id int,name nvarchar(20))


insert into #persondetails values(1,'mike')
insert into #persondetails values(2,'john')
insert into #persondetails values(3,'todd')

select * from #persondetails

select name from tempdb..sysobjects where name like '#%'


create table ##persondetails (id int,name nvarchar(20))

insert into ##persondetails values(1,'mike')
insert into ##persondetails values(2,'john')
insert into ##persondetails values(3,'todd')

select * from ##persondetails

--indexex

create index  IX_tblemployee_sal
on tblemployee (salary asc)

sp_helpindex tblemployee

drop index tblemployee.IX_tblemployee_sal


Create Clustered Index IX_tblEmployee_Gender_Salary
ON tblEmployee(Gender DESC, Salary ASC)

Create NONClustered Index IX_tblEmployee_Name
ON tblEmployee(name)

select * from tblemployee

select * from department

sp_helpindex tblemployee

select id,  name, gender ,salary,departmentname 
from tblemployee E
join  department D
on E.departmentid=D.deptid


create view vwemployeedept
as
select id,  name, gender ,salary,departmentname 
from tblemployee E
join  department D
on E.departmentid=D.deptid

select * from vwemployeedept

sp_helptext vwemployeedept

create view vwitemployeedept
as
select id,  name, gender ,salary,departmentname 
from tblemployee E
join  department D
on E.departmentid=D.deptid
where D.DepartmentName='it'


select * from vwitemployeedept

create view vwaggempdept
as
select departmentname ,count(id) as TotalEmployees
from tblemployee E
join  department D
on E.departmentid=D.deptid
group by departmentname


select * from vwaggempdept

create view vwempwithoutsal
as
select id,name,gender,Departmentid from tblEmployee

select * from vwempwithoutsal

update vwempwithoutsal set name='mike' where id=2

select * from vwempwithoutsal

select * from tblEmployee






select * from department

select * from tblemployee