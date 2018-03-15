select top 50 percent * from tblperson;

select * from tblperson where email like '_@_%'

select * from tblPerson order by name asc, email desc

select * from tblperson where name between 'a%' and'k%'

select * from tblperson where name like '[msk]%'

select * from tblperson where name like '[^msk]%' --not like

select * from tblPerson where genderID =1 or genderID = 2

select * from tblperson where genderid <> 1

select * from tblemployee

select gender, city ,sum(salary) as Sum_Sal, count(Id) as Sum_Emp from tblemployee  group by city, gender having sum(salary)>8000;

select * from tblemployee
select * from Department

select name, gender, salary , departmentname from tblemployee inner join  department on tblemployee.departmentID=department.ID

select name, gender, salary , departmentname from tblemployee left join  department on tblemployee.departmentID=department.ID

select name, gender, salary , departmentname from tblemployee right join  department on tblemployee.departmentID=department.ID

select name, gender, salary , departmentname from tblemployee full outer join  department on tblemployee.departmentID=department.ID

select name, gender, salary , departmentname from tblemployee  cross join  department --on tblemployee.departmentID=department.ID

-- intellegent joins

--left
select name, gender, salary, departmentname
from       tblemployee
left join  department
on tblemployee.departmentid=department.id
where department.id is null


select name, gender, salary, departmentname
from       tblemployee
left join  department
on tblemployee.departmentid=department.id
where tblemployee.departmentid is null

-- right
select name, gender, salary, departmentname
from       tblemployee E
right join  department  D
on E.departmentid=D.id
where D.id is null

select name, gender, salary, departmentname
from       tblemployee E
right join  department  D
on E.departmentid=D.id
where E.Departmentid is null


select name, gender, salary, departmentname
from       tblemployee E
right join  department  D
on E.departmentid=D.id
where E.Departmentid is null
or E.Departmentid is null

--  full
select name, gender, salary, departmentname
from       tblemployee E
full join  department  D
on E.departmentid=D.id
where E.Departmentid is null
or E.Departmentid is null

select * from employee

--  self join
-- left
select e.name as Employee, m.name as Manager
from employee e
left join employee m
on e.managerID=m.employeeID


-- right
select e.name as Employee, m.name as Manager
from employee e
right join employee m
on e.managerID=m.employeeID

-- inner join

select e.name as Employee, m.name as Manager
from employee e
inner join employee m
on e.managerID=m.employeeID

-- cross join

select e.name as Employee, m.name as Manager
from employee e
cross join employee m