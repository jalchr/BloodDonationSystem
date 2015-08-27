CREATE TABLE [dbo].[BloodRequest]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BloodType] NCHAR(10) NULL, 
    [UnitsRequired] INT NULL, 
    [NumOffered] INT NULL, 
    [NumDonator] INT NULL, 
    [Date] DATETIME NULL, 
    [UserId] INT NOT NULL, 
    [HospitalName] NCHAR(100) NULL
)
