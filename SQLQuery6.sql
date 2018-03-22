USE [sample]
GO
/****** Object:  UserDefinedFunction [dbo].[fu_EmpByGender]    Script Date: 22-03-2018 10:23:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER function [dbo].[fu_EmpByGender](@gender nvarchar(10))
returns table
as
return (select id,name, salary, gender,DepartmentId from tblEmployee where gender=@gender)