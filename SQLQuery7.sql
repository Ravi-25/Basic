USE [sample]
GO
/****** Object:  UserDefinedFunction [dbo].[mstvf_getemployee]    Script Date: 22-03-2018 10:51:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--multi statement table valued functions

ALTER function [dbo].[mstvf_getemployee]()
returns @table table (Id int,name varchar(20),hiredate date)
as
begin
insert into @table 
select pkempid, empname,cast(hiredate as date) as Hiredate from Demodb.dbo.Employee1
return
end
