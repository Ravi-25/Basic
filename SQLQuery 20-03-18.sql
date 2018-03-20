select isdate(getdate())

select(isdate('2018-02-30 21:30:12.000'))--is not a correct date, returns 0

select(isdate('2018-03-30 21:30:12.000')) -- is a correct date, returns 1

select isdate('2018-03-30 21:30:12.0000000')--is a datetime2 data type so returns 0

select isdate('2018-03-30 21:30:12.000')--is a correcct date time format and returns 1

select day(getdate())

select month(getdate())

select year(getdate())

select DATENAME(day,getdate())

select DATENAME(month,getdate())

select datename(weekday,getdate())

select datename(NS,getdate())

select getdate()
select           empname, datename(weekday,hiredate) as WEEKDAY,
                          datename(day,hiredate) as DAY,
						  datename(month,hiredate) as MONTH,
						  datename(year,hiredate) as YEAR
from Demodb.dbo.Employee1 

select datepart(weekday,getdate())  -- returns 3 as it is tuesday

select datepart(month,getdate())  

select getdate()

select dateadd(day,100,GETDATE()) --adds 100 days to current date

select DATEDIFF(day,dateadd(day,100,GETDATE()),GETDATE())

select hiredate ,CAST(hiredate as nvarchar(100)) as varchardate from demodb.dbo.Employee1

select hiredate, convert(nvarchar,hiredate, 101) as converthiredate from Demodb.dbo.Employee1

select datename(month,hiredate) as [Month of regstration],datepart(month,hiredate), count(pkempid) as [Number of Registrations] from Demodb.dbo.Employee1 group by datename(month,hiredate),datepart(month,hiredate)

select floor(rand()*100)

declare @counter int
set @counter=1
while(@counter <=10)
begin
print floor(rand()*100)
set @counter=@counter+1
end


select round(8.123456123456,5,1) -- 8.123450000000

select round(8.123456123456,5) -- 8.123460000000

select round(81548.123456789,-2)  -- 81500.000000000


SELECT database_id ,
        name ,
        is_cdc_enabled
FROM sys.databases



sp_helptext (sp_cdc_enable_db )