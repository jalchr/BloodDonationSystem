CREATE TABLE [dbo].[Register]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PhoneNum] VarCHAR(15) NULL, 
    [MBloodType] NCHAR(10) NULL, 
    [MName] NVarCHAR(50) NULL, 
    [Date] DATETIME NULL
)
