IF NOT EXISTS (
    SELECT name 
    FROM sys.databases 
    WHERE name = N'TMSDB'
)
BEGIN
    CREATE DATABASE TMS_DB; --TMS = Training Management System
END;
go

use TMSDB;
go

IF OBJECT_ID('dbo.Account', 'U') IS NULL
BEGIN
	create table Account
	(
		Id int primary key identity(1,1),
		Username varchar(50) not null unique,
		Password varchar(255) not null,
		Email varchar(255) not null unique,
		Role varchar(20) not null default 'user',
		Status varchar(20) not null default 'active',
		Fullname nvarchar(255) not null,

		Constraint CK_Account_Role check (Role in ('user', 'admin')),
		Constraint CK_Account_Status check (Status in ('active', 'banned'))
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
		BookId int not null,

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
	Create table LessonPlan
	(
		Id int primary key identity(1,1),
		Name NVARCHAR(200) not null,
		SortOrder int,
		TimeMinutes INT,
		LessonPlanId int not null,

	);
END;
go