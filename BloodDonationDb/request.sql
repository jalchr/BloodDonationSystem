CREATE TABLE [dbo].[request]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [type] NCHAR(10) NULL, 
    [number] NCHAR(10) NULL, 
    [address] NTEXT NULL, 
    [time] DATE NULL, 
    [offered] NCHAR(10) NULL
)
