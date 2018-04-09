USE [AddressBook]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 04/16/2012 14:45:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Country](
	[PKCountryId] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [varchar](50) NOT NULL,
	[ZipCodeStart] [bigint] NOT NULL,
	[ZipCodeEnd] [bigint] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[PKCountryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [IX_Country] UNIQUE NONCLUSTERED 
(
	[CountryName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Country] ON
INSERT [dbo].[Country] ([PKCountryId], [CountryName], [ZipCodeStart], [ZipCodeEnd], [IsActive]) VALUES (8, N'India', 500000, 599999, 1)
SET IDENTITY_INSERT [dbo].[Country] OFF









SELECT * FROM Country




CREATE PROCEDURE [dbo].[spGetAllCountries](@CountryId int) as
BEGIN
if @CountryId=-1
Select * from Country
else if @CountryId=-2
Select * from Country where IsActive=1
else if @CountryId=-3
Select * from Country where IsActive=0
else
select * from Country where PKCountryId = @CountryId
END



CREATE PROCEDURE [dbo].[spManageCountry](@ActionType tinyint,@PKCountryId int output, @CountryName
varchar(50), @ZipCodeStart int, @ZipCodeEnd int, @IsActive bit) as
BEGIN
if(@ActionType =1)
begin
insert into
Country(CountryName,ZipCodeStart,ZipCodeEnd,IsActive)values(@CountryName,@ZipCodeStart,@ZipCodeEnd,@IsActive)
select @PKCountryId=@@Identity
End
else if(@ActionType =2)
update Country set
CountryName = @CountryName,
ZipCodeStart=@ZipCodeStart,ZipCodeEnd=@ZipCodeEnd,IsActive=@IsActive where PKCountryId=@PKCountryId
else if(@ActionType=3)
delete from Country where PKCountryId=@PKCountryId
END