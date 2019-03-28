CREATE TABLE [dbo].[Section]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CourseID] INT NOT NULL, 
    [FacultyID] INT NOT NULL, 
    [Day] NVARCHAR(50) NOT NULL, 
    [Time] NVARCHAR(50) NOT NULL, 
    [Semester] NVARCHAR(50) NOT NULL, 
    CONSTRAINT Section_To_Faculty FOREIGN KEY (FacultyID) REFERENCES Faculty(ID), 
    CONSTRAINT Section_To_Course FOREIGN KEY (CourseID) REFERENCES Course(ID)
)
