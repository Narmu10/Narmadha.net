/* Select * from Article;

CREATE PROCEDURE spGetArticle
as
begin
    Select Title,content from Article
end

create procedure spGetCategory
as 
begin 
Select CategoryId,Name,Description from Category
end */


/* to execute */

/*spGetArticle

spGetCategory

Exec spGetArticle
Execute spGetCategory */


/* sp with parameters */

Select * from [User];

Insert into [User] (UserId, Username,Email,PasswordHash,RegistrationDate)
values ('6452','Narmadha','nar10@gmail.com','Hash123@',2024-01-08);

Insert into [User] (UserId, Username,Email,PasswordHash,RegistrationDate)
values ('63072','Saprsh','spr10@gmail.com','Hash124@',2024-01-08),
 ('60390','rams','rams10@gmail.com','Ramh124@',2024-01-08),
  ('63703','vysh','vys10@gmail.com','vysh124@',2024-01-08),
  ('65062','Lotu','Lot10@gmail.com','Lot124@',2024-01-08);

  Drop table [User];

  Delete from [User] where [UserId]='6372';


  Delete from [User];



  Create procedure spGetUserByEmailandUsername
  @Email nvarchar(100),
  @Username nvarchar(100)
  as
  begin
  Select Email,Username from [User]  where Email=@Email and Username= @Username
  end
  spGetUserByEmailandUsername @Email='nar10@gmail.com',@Username='Narmadha'


  /*System store procedure */


sp_helptext spGetArticle

sp_helptext spGetCategory

Create proc spgetUser
as
begin
 select UserId, Username,Email,PasswordHash,RegistrationDate from [User]
end

Select * from [User];

sp_helptext spGetUser

Create proc InsertUser 
@UserId int,
@Username nvarchar(100),
@Email nvarchar(100),
@PasswordHash nvarchar(100),
@RegistrationDate datetime

AS
Begin

Insert into [User](UserId,Username,Email,PasswordHash,RegistrationDate)
values (@UserId,@Username,@Email,@PasswordHash,@RegistrationDate)

end

Exec InsertUser '6432','Moh','moh20@gmail.com','Hash123@','08/08/2023'
Exec InsertUser '6230','spar','spar30@gmail.com','Hash123@','08/08/2023'
Exec InsertUser '6543','Lot','lot40@gmail.com','Hash123@','08/08/2023'
Exec InsertUser '6290','rams','rams70@gmail.com','Hash123@','08/08/2023'
Exec InsertUser '6324','Niki','nik20@gmail.com','Hash123@','08/08/2023'

Execute spGetUser

Create proc UpdateUser
@UserId int,
@Username nvarchar(100),
@Email nvarchar(100),
@PasswordHash nvarchar(100),
@RegistrationDate datetime

AS
Begin

Update [User] set UserId=@UserId,Username=@Username, Email=@Email, PasswordHash=@PasswordHash where RegistrationDate=@RegistrationDate;


end
select * from [User];


CREATE PROCEDURE DeleteUser
    @UserId INT
AS
BEGIN
    
    DELETE FROM [User] WHERE UserId = @UserId;
END

Exec DeleteUser @UserId=65062;


