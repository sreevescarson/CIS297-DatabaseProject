CREATE TABLE [dbo].[Enrollment]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [StudentID] INT NOT NULL, 
    [SectionID] INT NOT NULL, 
    [Grade] NVARCHAR(10) NULL, 
    CONSTRAINT Enrollment_To_Stude FOREIGN KEY (StudentID) REFERENCES Student(Id), 
    CONSTRAINT Enrollment_To_Section FOREIGN KEY ([SectionID]) REFERENCES Section(Id)
)
