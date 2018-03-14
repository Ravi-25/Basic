create database sample1; -- creating a a database sample1

alter database sample1 modify name=sample2;--altering name od DB using a sql cmd

execute sp_renamedb 'sample2', 'sample3';--altering name of DB using sys stored procedure	

drop database sample3;--deleating a DB

execute sp_renamedb 'sample3', 'sample'

use [sample] 
GO  -- using sample DB

create table tblGender  --creating table tblGender
(
ID int NOT NULL primary key,
Gender nvarchar(50) not null
)

alter table tblPerson add constraint tblperson_Gender_FK 
Foreign key (GenderID) references tblGender(ID)   -- adding a constraint

select * from tblGender;
select * from tblPerson;

alter table tblperson add constraint DF_tblPerson_GenderId default 3 for GenderID

insert into tblperson(ID , Name , Email, GenderID) Values (8,'Happy','ha@h.com',NULL)

insert into tblperson(ID , Name , Email) Values (9,'Khan','kakh.com')

create table test1
(
ID int identity(1,1),
value nvarchar(20)
)

create table test2
(
ID int identity(1,1),
value nvarchar(20)
)

insert into test1 values('xxx');

select SCOPE_IDENTITY();
select @@IDENTITY;
select IDENT_CURRENT('test2');

create trigger trForInsert on test1 for insert as
begin
insert into test2 values('yyy')
end

select * from test1;
select * from test2;