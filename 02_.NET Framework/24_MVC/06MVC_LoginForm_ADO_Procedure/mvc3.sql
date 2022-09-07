use test3;

select * from  Employee;

CREATE TABLE Ad_login(
	Admin_id NVARCHAR(20),
	Ad_Password NVARCHAR(20)
);

INSERT INTO Ad_login
VALUES
('admin', 'admin');

SELECT * FROM Ad_login;

DROP TABLE Ad_login;

create procedure Ab_Login
@Admin_Id Nvarchar (100),
@Password Nvarchar (100),
@Isvalid BIT OUT
AS
BEGIN
SET @Isvalid =(select Count(1) from Ad_login WHERE Admin_id=@Admin_Id and Ad_Password=@Password)
end

sp_helptext ab_Login

drop procedure Ab_Login



CREATE TABLE Profile(
	Name Varchar(20),
	Age int,
	City  Varchar(20)
)

SELECT * FROM Profile;

DROP TABLE Profile

DROP DATABASE TEST3

