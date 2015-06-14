/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF NOT EXISTS (SELECT * FROM [Users] where Username = 'admin' and password = '123456')
BEGIN
INSERT [Users]
( [Username], [Password],[IsAdmin],[Role],[Lastlogin])
Values
('admin','123456',1,'admin', getDate())

END
GO