select   e.name as employee,ISNULL( m.name,'BOSS') as Manager
from     employee e
left join Employee m
on e.ManagerID= m.EmployeeID

select   e.name as employee,coalesce( m.name,'BOSS') as Manager
from     employee e
left join Employee m
on e.ManagerID= m.EmployeeID

select   e.name as employee,case when m.name is NULL then 'BOSS' else m.name end as Manager
from     employee e
left join Employee m
on e.ManagerID= m.EmployeeID

select Name, Gender from tblemployee;

Create procedure spGetemployeegenedr
as
begin
select Name, Gender from tblemployee
end
exec spgetemployeegender

create proc spGetEmployeeByGenderAndDeptId
@Gender nvarchar(20),
@DeptId int
as
begin
select Name, Gender, DepartmentId from tblEmployee 
where Gender=@Gender and DepartmentId=@DeptId
end


exec spGetEmployeeByGenderAndDeptId 'male', 1

sp_helptext spgetemployeegender

sp_helptext spGetEmployeeByGenderAndDeptId

exec spGetEmployeeByGenderAndDeptId 1, '1' --converts 1 to nvarchar(20)

alter proc spgetemployeegender
with encryption -- encrypting sp
as  
begin
select Name, Gender from tblemployee order by name 
end

exec spgetemployeegender

sp_helptext spgetemployeegender

exec spgetemployeegender

create proc GetEmpGenderCount
@Gender nvarchar(20),
@EmpCount int output
as
begin
select @EmpCount=count(id) from tblemployee where gender=@gender
end

declare @EmpCount int
exec GetEmpGenderCount 'male', @EmpCount out
print @EmpCount

declare @EmpCount int
exec GetEmpGenderCount 'female', @EmpCount  --if out not mentioned, o/p will be null
if(@EmpCount is NULL)
 print '@EmpCount is NULL'
else
 print '@EmpCount is not NULL'
print @EmpCount


declare @EmpCount1 int
exec GetEmpGenderCount  @EmpCount=@EmpCount1 out, @Gender='female' 
if(@EmpCount1 is NULL)
 print '@EmpCount is NULL'
else
 print '@EmpCount is not NULL'
print @EmpCount1

sp_help GetEmpGenderCount

sp_help tblEmployee

sp_helptext GetEmpGenderCount

sp_depends GetEmpGenderCount

sp_depends tblemployee

create procedure EmpCount
as
begin
return(select Count(id) from tblemployee)
end

declare @count int
exec @count=EmpCount
print @Count

select ascii('a')

select char(65)

declare @start  int
set @start=0
while(@start<=255)
begin
print char(@start)
set @start=@start+1
end

select ltrim('    hello')
select ltrim(rtrim('    hello     '))

select upper(name), salary , lower(city) , ltrim(upper(reverse(city))) reverse_city, len(reverse(city)) length_city,len(ltrim(reverse(city)))  T_length_city from tblemployee

select left('abcdefghijk',6)

select right('abcdefghijk',6)

select CHARINDEX('@','ravinder.reddy25@gmail.com')

select SUBSTRING('ravinder.reddy25@gmail.com',17+1,9)

select SUBSTRING('ravinder.reddy25@gmail.com',CHARINDEX('@','ravinder.reddy25@gmail.com')+1,LEN('ravinder.reddy25@gmail.com')-CHARINDEX('@','ravinder.reddy25@gmail.com'))

select * from tblPerson

select SUBSTRING(email,CHARINDEX('@',email)+1,LEN(email)-CHARINDEX('@',email)) as [Email Domain] , count(*) as total from tblPerson group by SUBSTRING(email,CHARINDEX('@',email)+1,LEN(email)-CHARINDEX('@',email))

select SUBSTRING(email,CHARINDEX('@',email)+1,LEN(email)-CHARINDEX('@',email)) as [Email Domain] from tblPerson

select REPLICATE('RAVI ',3)


select Name , SUBSTRING(email,1,2)+REPLICATE('*',5)+SUBSTRING(email,CHARINDEX('@',email)+1,LEN(email)-CHARINDEX('@',email)) as [Email Address] from tblPerson

select SPACE(20)+'a'

select PATINDEX('%.com','may@may.com')

select Email, PATINDEX('%.com',Email) as First_Occurence from tblPerson

select email, REPLACE(email,'.com','.co.in') as New_Email from tblPerson

select email, STUFF(email,2,3,'******') as stuffed from tblPerson