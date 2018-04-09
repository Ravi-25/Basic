Create table tblProductInventory
(
 Id int primary key,
 ProductName nvarchar(50),
 QuantityAvailable int
)

Insert into tblProductInventory values(101,'iPhone',101)
Insert into tblProductInventory values(102,'Apple Laptops',100)
Insert into tblProductInventory values(103,'Books',120)
Insert into tblProductInventory values(104,'Acer Laptops',119)
Insert into tblProductInventory values(105,'iPads',134) 

select * from tblProductInventory

select * from tblProductInventory where ProductName like 'i%'

create procedure spGetPoductByName
@ProductName nvarchar(50)
as
begin
  select * from tblProductInventory
  where ProductName like @ProductName+ '%'
end

spGetPoductByName 'a'



