CREATE TABLE [dbo].[Clients]
(
	[ClientId] INT NOT NULL PRIMARY KEY, 
    [ClientName] NCHAR(10) NULL, 
    [ClientPhone] NCHAR(10) NULL, 
    [ClientPhoneNb] NCHAR(10) NULL, 
    [ClientLocation] NCHAR(10) NULL, 
    [ClientRegistration] NCHAR(10) NULL, 
    [ClientBloodType] NCHAR(10) NULL
)
