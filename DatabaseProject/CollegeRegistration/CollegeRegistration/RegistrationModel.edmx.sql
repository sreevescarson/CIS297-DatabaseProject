
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/01/2019 19:17:07
-- Generated from EDMX file: C:\Users\LtBak\OneDrive\Documents\GitHub\CIS297-DatabaseProject\DatabaseProject\CollegeRegistration\CollegeRegistration\RegistrationModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Registration];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Enrollment_To_Course]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Enrollment] DROP CONSTRAINT [FK_Enrollment_To_Course];
GO
IF OBJECT_ID(N'[dbo].[FK_Enrollment_To_Stude]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Enrollment] DROP CONSTRAINT [FK_Enrollment_To_Stude];
GO
IF OBJECT_ID(N'[dbo].[FK_Section_To_Course]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Section] DROP CONSTRAINT [FK_Section_To_Course];
GO
IF OBJECT_ID(N'[dbo].[FK_Section_To_Faculty]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Section] DROP CONSTRAINT [FK_Section_To_Faculty];
GO
IF OBJECT_ID(N'[dbo].[FK_Student_Major]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Student] DROP CONSTRAINT [FK_Student_Major];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Course]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Course];
GO
IF OBJECT_ID(N'[dbo].[Enrollment]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Enrollment];
GO
IF OBJECT_ID(N'[dbo].[Faculty]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Faculty];
GO
IF OBJECT_ID(N'[dbo].[Major]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Major];
GO
IF OBJECT_ID(N'[dbo].[Section]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Section];
GO
IF OBJECT_ID(N'[dbo].[Student]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Student];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Courses'
CREATE TABLE [dbo].[Courses] (
    [Id] int  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [Number] int  NOT NULL,
    [Department] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Enrollments'
CREATE TABLE [dbo].[Enrollments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [StudentID] int  NOT NULL,
    [CourseID] int  NOT NULL,
    [Grade] nvarchar(10)  NULL
);
GO

-- Creating table 'Faculties'
CREATE TABLE [dbo].[Faculties] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [PhoneNumber] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Majors'
CREATE TABLE [dbo].[Majors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nchar(50)  NOT NULL,
    [College] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Sections'
CREATE TABLE [dbo].[Sections] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CourseID] int  NOT NULL,
    [FacultyID] int  NOT NULL,
    [Day] nvarchar(50)  NOT NULL,
    [Time] nvarchar(50)  NOT NULL,
    [Semester] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nchar(50)  NOT NULL,
    [MajorID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Courses'
ALTER TABLE [dbo].[Courses]
ADD CONSTRAINT [PK_Courses]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Enrollments'
ALTER TABLE [dbo].[Enrollments]
ADD CONSTRAINT [PK_Enrollments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Faculties'
ALTER TABLE [dbo].[Faculties]
ADD CONSTRAINT [PK_Faculties]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Majors'
ALTER TABLE [dbo].[Majors]
ADD CONSTRAINT [PK_Majors]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sections'
ALTER TABLE [dbo].[Sections]
ADD CONSTRAINT [PK_Sections]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CourseID] in table 'Enrollments'
ALTER TABLE [dbo].[Enrollments]
ADD CONSTRAINT [FK_Enrollment_To_Course]
    FOREIGN KEY ([CourseID])
    REFERENCES [dbo].[Courses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Enrollment_To_Course'
CREATE INDEX [IX_FK_Enrollment_To_Course]
ON [dbo].[Enrollments]
    ([CourseID]);
GO

-- Creating foreign key on [CourseID] in table 'Sections'
ALTER TABLE [dbo].[Sections]
ADD CONSTRAINT [FK_Section_To_Course]
    FOREIGN KEY ([CourseID])
    REFERENCES [dbo].[Courses]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Section_To_Course'
CREATE INDEX [IX_FK_Section_To_Course]
ON [dbo].[Sections]
    ([CourseID]);
GO

-- Creating foreign key on [StudentID] in table 'Enrollments'
ALTER TABLE [dbo].[Enrollments]
ADD CONSTRAINT [FK_Enrollment_To_Stude]
    FOREIGN KEY ([StudentID])
    REFERENCES [dbo].[Students]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Enrollment_To_Stude'
CREATE INDEX [IX_FK_Enrollment_To_Stude]
ON [dbo].[Enrollments]
    ([StudentID]);
GO

-- Creating foreign key on [FacultyID] in table 'Sections'
ALTER TABLE [dbo].[Sections]
ADD CONSTRAINT [FK_Section_To_Faculty]
    FOREIGN KEY ([FacultyID])
    REFERENCES [dbo].[Faculties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Section_To_Faculty'
CREATE INDEX [IX_FK_Section_To_Faculty]
ON [dbo].[Sections]
    ([FacultyID]);
GO

-- Creating foreign key on [MajorID] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_Student_Major]
    FOREIGN KEY ([MajorID])
    REFERENCES [dbo].[Majors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Student_Major'
CREATE INDEX [IX_FK_Student_Major]
ON [dbo].[Students]
    ([MajorID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------