-- =========================================
-- Create table template Windows Azure SQL Database 
-- =========================================

create table USERACCOUNT
(
	UserName	varchar(20) not null,
	Pass		varchar(50)	not null
	Primary key(UserName)
)

select * from USERACCOUNT
