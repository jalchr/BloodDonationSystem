CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NULL, 
    [Lastlogin] DATETIME NULL, 
    [IsAdmin] BIT NULL, 
    [HospitalName] NVARCHAR(50) NULL, 
    [HospitalLocation] NVARCHAR(200) NULL, 
    [Role] NVARCHAR(50) NULL
)
