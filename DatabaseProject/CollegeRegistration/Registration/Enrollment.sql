CREATE TABLE [dbo].[Enrollment]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [StudentID] INT NOT NULL, 
    [CourseID] INT NOT NULL, 
    [Grade] NVARCHAR(10) NULL, 
    CONSTRAINT Enrollment_To_Stude FOREIGN KEY (StudentID) REFERENCES Student(Id), 
    CONSTRAINT Enrollment_To_Course FOREIGN KEY (CourseID) REFERENCES Course(Id)
)
