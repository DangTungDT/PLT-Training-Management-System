IF NOT EXISTS (
    SELECT name 
    FROM sys.databases 
    WHERE name = N'PTMDB'
)
BEGIN
    CREATE DATABASE PTMDB;
END;
go

use PTMDB;
go

IF OBJECT_ID('dbo.Account', 'U') IS NULL
BEGIN
	create table Account
	(
		Id int primary key identity(1,1),
		Password varchar(255) not null,
		Role varchar(20) not null default 'user',
		Status varchar(20) not null default 'active',
		Fullname nvarchar(255) not null,
		PersonId int not null,
		Constraint CK_Account_Role check (Role in ('user', 'admin')),
		Constraint CK_Account_Status check (Status in ('active', 'banned'))
	);
END;
go

if OBJECT_ID('dbo.Faculty', 'U') IS NULL
BEGIN
	create table Faculty
	(
		Id int primary key identity(1,1),
		Name nvarchar(255) not null unique,
		Description nvarchar(500)
	);
END;
go

if OBJECT_ID('dbo.Person', 'U') IS NULL
BEGIN
	create table Person
	(
		Id int primary key identity(1,1),
		FullName nvarchar(100) NOT NULL,
		Email varchar(255) NOT NULL UNIQUE,
		Phone varchar(20),
		Gender varchar(10),
		BirthDate date,
		Address nvarchar(255),
		CreatedAt datetime default SYSDATETIME(),
		UpdatedAt datetime default SYSDATETIME()
	);
END;
go

if OBJECT_ID('dbo.Student', 'U') IS NULL
BEGIN
	create table Student
	(
		Id varchar(10)primary key,
		ClassId int not null,
		FacultyId int not null,
		PersonId int unique not null,
		FOREIGN KEY (PersonId) REFERENCES Person(Id)
	);
END;
go

if OBJECT_ID('dbo.Room', 'U') IS NULL
BEGIN
	create table Room
	(
		Id int primary key identity(1,1),
		Name VARCHAR(50) NOT NULL UNIQUE,
		Capacity int not null,
		Location nvarchar(100) not null,
	);
END;
go

if OBJECT_ID('dbo.Class', 'U') IS NULL
BEGIN
	create table Class
	(
		Id int primary key identity(1,1),
		Name VARCHAR(50) NOT NULL UNIQUE,
		FacultyId int not null,
		TeacherId varchar(10) not null,
	);
END;
go

if OBJECT_ID('dbo.Teacher', 'U') IS NULL
BEGIN
	create table Teacher
	(
		Id varchar(10) primary key,
		PersonId int unique not null,
		FacultyId int not null,
		FOREIGN KEY (PersonId) REFERENCES Person(Id)
	);
END;
go

if OBJECT_ID('dbo.TeachingSchedule', 'U') IS NULL
BEGIN
	create table TeachingSchedule
	(
		Id int primary key identity(1,1),
		ScheduleDate date NOT NULL,
		StartTime time NOT NULL,
		EndTime time NOT NULL,
		Note nvarchar(500),
		CreatedAt datetime default SYSDATETIME(),
		TeacherId varchar(10) NOT NULL,
		CourseId int NOT NULL,
		ClassId int NULL,
		RoomId int NULL
	);
END;
go

if OBJECT_ID('dbo.Exam', 'U') IS NULL
BEGIN
	create table Exam
	(
		Id int primary key identity(1,1),
		Name nvarchar(255) not null,
		Type varchar(20) not null,
		Duration int not null,
		ExamInstruction nvarchar(500),
		Description nvarchar(500),
		CourseId int not null,

		constraint CK_Exam_Type check (Type in ('MultipleChoice', 'Essay', 'Mixed'))
	);
END;
go

if OBJECT_ID('dbo.Question', 'U') IS NULL
BEGIN
	create table Question
	(
		Id int primary key identity(1,1),
		Type varchar(20) not null,
		Content nvarchar(500) not null,
		Score decimal(5,2) not null,
		ExamId int not null,

		constraint CK_Question_Type check (Type in ('MultipleChoice', 'Essay'))
	);
END;
go

if OBJECT_ID('dbo.QuestionOption', 'U') IS NULL
BEGIN
	create table QuestionOption
	(
		Id int primary key identity(1,1),
		Content nvarchar(500) not null,
		IsCorrect bit not null,
		SortOrder int,
		QuestionId int not null,
	);
END;
go

if OBJECT_ID('dbo.Assignment', 'U') IS NULL
BEGIN
	create table Assignment
	(
		Id int primary key identity(1,1),
		Type varchar(20) not null,
		IsOpen bit not null default 1,
		StartDate datetime,
		EndDate datetime,
		Description nvarchar(500),
		CourseId int not null,

		constraint CK_Assignment_Type check (Type in ('assignment', 'project'))
	);
END;
go

if OBJECT_ID('dbo.Submission', 'U') IS NULL
BEGIN
	create table Submission
	(
		Id int primary key identity(1,1),
		AssignmentId int not null,
		StudentId varchar(10) not null,
		FileName nvarchar(255) not null,
	);
END;
go

if OBJECT_ID('dbo.SubmissionFile', 'U') IS NULL
BEGIN
	create table SubmissionFile
	(
		SubmissionId int not null,
		FileId int not null,
		primary key(SubmissionId, FileId)
	);
END;
go

if OBJECT_ID('dbo.StudentScore', 'U') IS NULL
BEGIN
	create table StudentScore
	(
		Id int primary key identity(1,1),
		StudentId varchar(10) not null,
		CourseId int not null,
		ScoreValue decimal(5,2) not null,
		ScoreType varchar(20) not null,

		constraint CK_StudentScore_ScoreType check (ScoreType in ('assignment', 'midterm', 'final'))
	);
END;
go

if OBJECT_ID('dbo.ResearchTopic', 'U') IS NULL
BEGIN
	create table ResearchTopic
	(
		Id int primary key identity(1,1),
		Title nvarchar(255) not null,
		Status varchar(20) not null default 'PendingApproval',
		Description nvarchar(500),
		StartDate datetime,
		EndDate datetime,
		TopicCost decimal(18,2),
		KeyWord varchar(255),
		FacultyId int not null,
		TeacherId varchar(10) not null,
		
		constraint CK_ResearchTopic_Status check (Status in ('PendingApproval', 'InProgress', 'Completed'))
	);
END;
go


if OBJECT_ID('dbo.TopicObjective_File', 'U') IS NULL
BEGIN
	create table ResearchTopicFile
	(
		ResearchTopicId int not null,
		FileId int not null,
		primary key(ResearchTopicId, FileId)
	);
END;
go

if OBJECT_ID('dbo.TopicObjective', 'U') IS NULL
BEGIN
	create table TopicObjective
	(
		Id int primary key identity(1,1),
		Title nvarchar(255) not null,
		Description nvarchar(500),
		TopicId int not null,
	);
END;
go

if OBJECT_ID('dbo.TopicProgress', 'U') IS NULL
BEGIN
	create table TopicProgress
	(
		Id int primary key identity(1,1),
		Title nvarchar(255) not null,
		Status varchar(20) not null default	'NotStarted',
		Description nvarchar(500),
		TopicId int not null,
		constraint CK_TopicProgress_Status check (Status in ('NotStarted', 'InProgress', 'Completed'))
	);
END;
go


if OBJECT_ID('dbo.Category', 'U') IS NULL
BEGIN
	create table Category
	(
		Id int primary key identity(1,1),
		Name nvarchar(255) not null unique,
		Description nvarchar(500),
		IsActive bit not null default 1,
		Type varchar(20) not null,
		CreatedAt dateTime not null default sysdatetime(),
		UpdatedAt dateTime not null default sysdatetime(),

		constraint CK_Category_Type check (Type in ('book', 'Course', 'both'))
	);
END;
go

if OBJECT_ID('dbo.Book', 'U') IS NULL
BEGIN
	create table Book
	(
		Id int primary key identity(1,1),
		ISBN varchar(20) unique, --International Standard Book Number
		Name nvarchar(255) not null unique,
		Author nvarchar(255) not null,
		PublishedYear int not null,
		Description nvarchar(500),
		DifficultyLevel nvarchar(20) not null,
		CategoryId int not null,

		constraint CK_Book_PublishedYear check (PublishedYear <= YEAR(GETDATE())),
		constraint CK_Book_DifficultyLevel check (DifficultyLevel in ('Beginner', 'Expert', 'Advanced', 'Intermediate'))
	);
END;
go

if OBJECT_ID('dbo.Book_File', 'U') IS NULL
BEGIN
	create table Book_File
	(
		BookId int not null,
		FileId int not null,
		primary key(BookId, FileId)
	);
END;
go

if OBJECT_ID('dbo.BookFile', 'U') IS NULL
BEGIN
	create table BookFile
	(
		Id int primary key identity(1,1),
		FileName nvarchar(255) not null,
		FilePath nvarchar(500) not null, --or url
		FileType VARCHAR(50) NOT NULL,   -- pdf, epub, docx, jpg 
		FileSize INT NULL,
		CreatedAt datetime not null default GETDATE(),

		constraint CK_BookFile_CreatedAt check (CreatedAt > GETDATE())
	);
END;
go

if OBJECT_ID('dbo.Course', 'U') IS NULL
BEGIN
	create table Course
	(
		Id int primary key identity(1,1),
		FullName nvarchar(255) not null unique,
		ShortName nvarchar(100) not null unique,
		StartDate datetime,
		EndDate datetime,
		Description nvarchar(500),
		CategoryId int not null,

	);
END;
go

if OBJECT_ID('dbo.LessonPlan', 'U') IS NULL
BEGIN
	Create table LessonPlan
	(
		Id int primary key identity(1,1),
		Name nvarchar(255) not null,
		Type varchar(20) not null,
		StartDate datetime,
		EndDate datetime,
		Description nvarchar(500),
		Objective nvarchar(500) not null,
		Material NVARCHAR(500) NULL,
		CourseId int not null,
		StudentClassId int not null,
		RoomId int not null,

		constraint ck_LessonPlan_Type check (Type in ('Theory', 'Practice', 'both'))
	);
END;
go

if OBJECT_ID('dbo.LessonActivity', 'U') IS NULL
BEGIN
	Create table LessonActivity
	(
		Id int primary key identity(1,1),
		Name NVARCHAR(200) not null,
		SortOrder int,
		TimeMinutes INT,
		LessonPlanId int not null,

	);
END;
go

--Add constriant Foreign Key
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Student_Class')
BEGIN
    ALTER TABLE dbo.Student
    ADD CONSTRAINT FK_Student_Class FOREIGN KEY (ClassId)
        REFERENCES dbo.Class(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Account_Person')
BEGIN
    ALTER TABLE dbo.Account
    ADD CONSTRAINT FK_Account_Person FOREIGN KEY (PersonId)
        REFERENCES dbo.Person(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Student_Faculty')
BEGIN
    ALTER TABLE dbo.Student
    ADD CONSTRAINT FK_Student_Faculty FOREIGN KEY (FacultyId)
        REFERENCES dbo.Faculty(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Class_Faculty')
BEGIN
    ALTER TABLE dbo.Class
    ADD CONSTRAINT FK_Class_Faculty FOREIGN KEY (FacultyId)
        REFERENCES dbo.Faculty(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Class_Teacher')
BEGIN
    ALTER TABLE dbo.Class
    ADD CONSTRAINT FK_Class_Teacher FOREIGN KEY (TeacherId)
        REFERENCES dbo.Teacher(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Teacher_Faculty')
BEGIN
    ALTER TABLE dbo.Teacher
    ADD CONSTRAINT FK_Teacher_Faculty FOREIGN KEY (FacultyId)
        REFERENCES dbo.Faculty(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_TeachingSchedule_Teacher')
BEGIN
    ALTER TABLE dbo.TeachingSchedule
    ADD CONSTRAINT FK_TeachingSchedule_Teacher FOREIGN KEY (TeacherId)
        REFERENCES dbo.Teacher(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_TeachingSchedule_Course')
BEGIN
    ALTER TABLE dbo.TeachingSchedule
    ADD CONSTRAINT FK_TeachingSchedule_Course FOREIGN KEY (CourseId)
        REFERENCES dbo.Course(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_TeachingSchedule_Class')
BEGIN
    ALTER TABLE dbo.TeachingSchedule
    ADD CONSTRAINT FK_TeachingSchedule_Class FOREIGN KEY (ClassId)
        REFERENCES dbo.Class(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_TeachingSchedule_Room')
BEGIN
    ALTER TABLE dbo.TeachingSchedule
    ADD CONSTRAINT FK_TeachingSchedule_Room FOREIGN KEY (RoomId)
        REFERENCES dbo.Room(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Exam_Course')
BEGIN
    ALTER TABLE dbo.Exam
    ADD CONSTRAINT FK_Exam_Course FOREIGN KEY (CourseId)
        REFERENCES dbo.Course(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Question_Exam')
BEGIN
    ALTER TABLE dbo.Question
    ADD CONSTRAINT FK_Question_Exam FOREIGN KEY (ExamId)
        REFERENCES dbo.Exam(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_QuestionOption_Question')
BEGIN
    ALTER TABLE dbo.QuestionOption
    ADD CONSTRAINT FK_QuestionOption_Question FOREIGN KEY (QuestionId)
        REFERENCES dbo.Question(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Assignment_Course')
BEGIN
    ALTER TABLE dbo.Assignment
    ADD CONSTRAINT FK_Assignment_Course FOREIGN KEY (CourseId)
        REFERENCES dbo.Course(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Submission_Assignment')
BEGIN
    ALTER TABLE dbo.Submission
    ADD CONSTRAINT FK_Submission_Assignment FOREIGN KEY (AssignmentId)
        REFERENCES dbo.Assignment(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Submission_Student')
BEGIN
    ALTER TABLE dbo.Submission
    ADD CONSTRAINT FK_Submission_Student FOREIGN KEY (StudentId)
        REFERENCES dbo.Student(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_SubmissionFile_Submission')
BEGIN
    ALTER TABLE dbo.SubmissionFile
    ADD CONSTRAINT FK_SubmissionFile_Submission FOREIGN KEY (SubmissionId)
        REFERENCES dbo.Submission(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_SubmissionFile_BookFile')
BEGIN
    ALTER TABLE dbo.SubmissionFile
    ADD CONSTRAINT FK_SubmissionFile_BookFile FOREIGN KEY (FileId)
        REFERENCES dbo.BookFile(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_StudentScore_Student')
BEGIN
    ALTER TABLE dbo.StudentScore
    ADD CONSTRAINT FK_StudentScore_Student FOREIGN KEY (StudentId)
        REFERENCES dbo.Student(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_StudentScore_Course')
BEGIN
    ALTER TABLE dbo.StudentScore
    ADD CONSTRAINT FK_StudentScore_Course FOREIGN KEY (CourseId)
        REFERENCES dbo.Course(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_ResearchTopic_Faculty')
BEGIN
    ALTER TABLE dbo.ResearchTopic
    ADD CONSTRAINT FK_ResearchTopic_Faculty FOREIGN KEY (FacultyId)
        REFERENCES dbo.Faculty(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_ResearchTopic_Teacher')
BEGIN
    ALTER TABLE dbo.ResearchTopic
    ADD CONSTRAINT FK_ResearchTopic_Teacher FOREIGN KEY (TeacherId)
        REFERENCES dbo.Teacher(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_ResearchTopicFile_ResearchTopic')
BEGIN
    ALTER TABLE dbo.ResearchTopicFile
    ADD CONSTRAINT FK_ResearchTopicFile_ResearchTopic FOREIGN KEY (ResearchTopicId)
        REFERENCES dbo.ResearchTopic(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_ResearchTopicFile_BookFile')
BEGIN
    ALTER TABLE dbo.ResearchTopicFile
    ADD CONSTRAINT FK_ResearchTopicFile_BookFile FOREIGN KEY (FileId)
        REFERENCES dbo.BookFile(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_TopicObjective_ResearchTopic')
BEGIN
    ALTER TABLE dbo.TopicObjective
    ADD CONSTRAINT FK_TopicObjective_ResearchTopic FOREIGN KEY (TopicId)
        REFERENCES dbo.ResearchTopic(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_TopicProgress_ResearchTopic')
BEGIN
    ALTER TABLE dbo.TopicProgress
    ADD CONSTRAINT FK_TopicProgress_ResearchTopic FOREIGN KEY (TopicId)
        REFERENCES dbo.ResearchTopic(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Book_Category')
BEGIN
    ALTER TABLE dbo.Book
    ADD CONSTRAINT FK_Book_Category FOREIGN KEY (CategoryId)
        REFERENCES dbo.Category(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_BookFile_Book')
BEGIN
    ALTER TABLE dbo.Book_File
    ADD CONSTRAINT FK_BookFile_Book FOREIGN KEY (BookId)
        REFERENCES dbo.Book(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_BookFile_BookFile')
BEGIN
    ALTER TABLE dbo.Book_File
    ADD CONSTRAINT FK_BookFile_BookFile FOREIGN KEY (FileId)
        REFERENCES dbo.BookFile(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_Course_Category')
BEGIN
    ALTER TABLE dbo.Course
    ADD CONSTRAINT FK_Course_Category FOREIGN KEY (CategoryId)
        REFERENCES dbo.Category(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_LessonPlan_Course')
BEGIN
    ALTER TABLE dbo.LessonPlan
    ADD CONSTRAINT FK_LessonPlan_Course FOREIGN KEY (CourseId)
        REFERENCES dbo.Course(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_LessonPlan_Class')
BEGIN
    ALTER TABLE dbo.LessonPlan
    ADD CONSTRAINT FK_LessonPlan_Class FOREIGN KEY (StudentClassId)
        REFERENCES dbo.Class(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_LessonPlan_Room')
BEGIN
    ALTER TABLE dbo.LessonPlan
    ADD CONSTRAINT FK_LessonPlan_Room FOREIGN KEY (RoomId)
        REFERENCES dbo.Room(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO


IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE name = 'FK_LessonActivity_LessonPlan')
BEGIN
    ALTER TABLE dbo.LessonActivity
    ADD CONSTRAINT FK_LessonActivity_LessonPlan FOREIGN KEY (LessonPlanId)
        REFERENCES dbo.LessonPlan(Id)
        ON UPDATE NO ACTION ON DELETE NO ACTION;
END
GO

--USE master;
--ALTER DATABASE PTMDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
--DROP DATABASE PTMDB;