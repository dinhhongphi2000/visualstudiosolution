use [Test]

Go

set quoted_identifier on
go

create proc [dbo].[Sp_Account_Login]
	@UserName varchar(20),
	@Pass varchar(50)

as
begin
	declare @count int
	declare @res bit
	select @count = count(*) from USERACCOUNT where UserName = @UserName and Pass = @Pass
	if @count > 0
		set @res = 1
	else
		set @res = 0

	select @res
end