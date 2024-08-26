CREATE TABLE [dbo].[tblLogin]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NULL
)
