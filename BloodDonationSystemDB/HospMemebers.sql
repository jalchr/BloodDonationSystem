CREATE TABLE [dbo].[HospMemebers]
(
	[MembId] INT NOT NULL PRIMARY KEY, 
    [MembName] NCHAR(10) NULL, 
    [MembPosition] NCHAR(10) NULL, 
    [MembPhone] NCHAR(10) NULL, 
    [MembEmail] NCHAR(10) NULL, 
    [HospName] NCHAR(10) NULL
)
