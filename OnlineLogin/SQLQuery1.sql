insert into tblUser values ('Ravi25', HASHBYTES('sha2_256','ravi123'),'ravi@standav.com')

select * from tblUser where Uname='ravi25'


Alter procedure sp_AutUser
@UName nvarchar(100),
@Password nvarchar(200)
as
begin
Declare @Count int

select @Count=count (UName) from tblUser where UName=@UName and [Password]= @Password
--print @Count
--print Password

if(@Count=1)
begin
select 1 as returncode
end
else
begin
--(select hashbytes('sha1',@Password))
select -1 as returncode
end
end

select count(*) from tbluser where uname='Ravi25'

exec sp_AutUser 'Ravi25','E472F6010115315588E12CDC5CA1B62DC179AF96'

 select hashbytes('sha1','ravi123') from tbluser

 select HASHBYTES('sha1','Hello')


 CREATE PROC spRegisterUser @UserName NVARCHAR(100)
,@Password NVARCHAR(200)
,@Email NVARCHAR(200)
AS
BEGIN
DECLARE @Count INT
DECLARE @ReturnCode INT

SELECT @Count = COUNT(UName)
FROM tblUser
WHERE UName = @UserName

IF @Count > 0
BEGIN
SET @ReturnCode = - 1
END
ELSE
BEGIN
SET @ReturnCode = 1

INSERT INTO tblUser
VALUES (
@UserName
,@Password
,@Email
)
END

SELECT @ReturnCode AS ReturnValue
END




ALTER PROC spSelected @UserName NVARCHAR(100),
 @UType nvarchar(50) output
AS
BEGIN
DECLARE @Count INT
DECLARE @UTypeId INT

SELECT @Count = COUNT([UtypeId])
FROM [tblUNameId]
WHERE UName = @UserName

IF @Count > 0
BEGIN
--SET @ReturnCode = - 1
SELECT @UTypeId=[UtypeId] FROM [tblUNameId] WHERE UName = @UserName
SELECT @UType=[UType] FROM [tblUType] WHERE [UtypeId]=@UTypeId
END
ELSE
BEGIN
SET @UType='null'
END
--print @UType
END

 select exec  spSelected 'Ravi25',''


ALTER PROC spSave
 @UserName nvarchar(100),
 @UType nvarchar(50)
AS
BEGIN
DECLARE @Count INT
DECLARE @UTypeId INT

SELECT @Count = COUNT([UtypeId])
FROM [tblUNameId]
WHERE UName = @UserName

IF @Count > 0
BEGIN
--SET @ReturnCode = - 1
SELECT @UTypeId=[UtypeId] FROM [tblUType] WHERE UType = @UType
--SELECT @UType=[UType] FROM [tblUType] WHERE [UtypeId]=@UTypeId
UPDATE tblUNameId set UTypeId=@UTypeId where UName=@UserName
END
ELSE
BEGIN
--SET @UType='null'
--print @UType
SELECT @UTypeId=[UtypeId] FROM [tblUType] WHERE UType = @UType
INSERT INTO tblUnameId VALUES (@UTypeId,@UserName)
END
END

--UPDATE tblUNameId set UTypeId=@UTypeId where UName=@UserName


exec spSave 'Ravi25','Root'





CREATE PROC spUType @UserName NVARCHAR(100),
 @UType nvarchar(50) output
AS
BEGIN
DECLARE @Count INT
DECLARE @UTypeId INT

SELECT @Count = COUNT([UtypeId])
FROM [tblUNameId]
WHERE UName = @UserName

IF @Count > 0
BEGIN
--SET @ReturnCode = - 1
SELECT @UTypeId=[UtypeId] FROM [tblUNameId] WHERE UName = @UserName
SELECT @UType=[UType] FROM [tblUType] WHERE [UtypeId]=@UTypeId
END
ELSE
BEGIN
SET @UType='null'
END
--print @UType
END
