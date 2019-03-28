CREATE TABLE [dbo].[Course]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Number] INT NOT NULL, 
    [Department] NVARCHAR(50) NOT NULL
)
