CREATE TABLE [dbo].[BloodRequest]
(
	[BloodRequestId] INT NOT NULL PRIMARY KEY, 
    [UnitType] NCHAR(10) NULL, 
    [UnitNB] NCHAR(10) NULL, 
    [UnitDonor] NCHAR(10) NULL, 
    [UnitOffered] NCHAR(10) NULL, 
    [UnitRequest] NCHAR(10) NULL, 
    [HospName] NCHAR(10) NULL 
)
