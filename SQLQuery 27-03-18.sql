Create Table tblProduct
(
 ProductId int primary key,
 Name nvarchar(20),
 UnitPrice int
)

Insert into tblProduct Values(1, 'Books', 20)
Insert into tblProduct Values(2, 'Pens', 14)
Insert into tblProduct Values(3, 'Pencils', 11)
Insert into tblProduct Values(4, 'Clips', 10)

select * from tblproduct

Create Table tblProductSales
(
 ProductId int,
 QuantitySold int
)

Insert into tblProductSales values(1, 10)
Insert into tblProductSales values(3, 23)
Insert into tblProductSales values(4, 21)
Insert into tblProductSales values(2, 12)
Insert into tblProductSales values(1, 13)
Insert into tblProductSales values(3, 12)
Insert into tblProductSales values(4, 13)
Insert into tblProductSales values(1, 11)
Insert into tblProductSales values(2, 12)
Insert into tblProductSales values(1, 14) 

select * from tblProductSales


Create view vWTotalSalesByProduct
with SchemaBinding
as
Select Name, 
SUM(ISNULL((QuantitySold * UnitPrice), 0)) as TotalSales, 
COUNT_BIG(*) as TotalTransactions
from dbo.tblProductSales
join dbo.tblProduct
on dbo.tblProduct.ProductId = dbo.tblProductSales.ProductId
group by Name

select * from vWTotalSalesByProduct

select * from tblemployee

CREATE TABLE tblEmployeeAudit
(
  Id int identity(1,1) primary key,
  AuditData nvarchar(1000)
)

CREATE TRIGGER tr_tblEMployee_ForInsert
ON tblEmployee
FOR INSERT
AS
BEGIN
 Declare @Id int
 Select @Id = Id from inserted
 
 insert into tblEmployeeAudit 
 values('New employee with Id  = ' + Cast(@Id as nvarchar(5)) + ' is added at ' + cast(Getdate() as nvarchar(20)))
END

Insert into tblEmployee values ('Tan','Female', 4300, 'sydney', 3)

select * from tblemployee
select * from tblEmployeeAudit

CREATE TRIGGER tr_tblEMployee_ForDelete
ON tblEmployee
FOR DELETE
AS
BEGIN
 Declare @Id int
 Select @Id = Id from deleted
 
 insert into tblEmployeeAudit 
 values('An existing employee with Id  = ' + Cast(@Id as nvarchar(5)) + ' is deleted at ' + Cast(Getdate() as nvarchar(20)))
END

delete from tblemployee where id=11

select * from tblemployee
select * from tblEmployeeAudit

sp_helptext tr_tblEMployee_ForDelete

create trigger tr_tlemployee_forupdate
on tblemployee
for update
as 
begin
select * from deleted
select * from inserted
end

select * from tblemployee

update tblemployee set Name='Benn' where id=6






