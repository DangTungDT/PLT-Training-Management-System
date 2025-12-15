using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedYear = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DifficultyLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CategoryDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Book_Category_CategoryDTOId",
                        column: x => x.CategoryDTOId,
                        principalTable: "Category",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Book_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    PersonDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_Person_PersonDTOId",
                        column: x => x.PersonDTOId,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Account_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faculty_School_SchoolDTOId",
                        column: x => x.SchoolDTOId,
                        principalTable: "School",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Faculty_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Semester",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SchoolId = table.Column<int>(type: "int", nullable: true),
                    SchoolDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semester", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Semester_School_SchoolDTOId",
                        column: x => x.SchoolDTOId,
                        principalTable: "School",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Semester_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Book_File",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    FileId = table.Column<int>(type: "int", nullable: false),
                    BookDTOId = table.Column<int>(type: "int", nullable: true),
                    FilesDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book_File", x => new { x.BookId, x.FileId });
                    table.ForeignKey(
                        name: "FK_Book_File_Book_BookDTOId",
                        column: x => x.BookDTOId,
                        principalTable: "Book",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Book_File_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_File_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Book_File_Files_FilesDTOId",
                        column: x => x.FilesDTOId,
                        principalTable: "Files",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    FacultyId = table.Column<int>(type: "int", nullable: false),
                    FacultyDTOId = table.Column<int>(type: "int", nullable: true),
                    PersonDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teacher_Faculty_FacultyDTOId",
                        column: x => x.FacultyDTOId,
                        principalTable: "Faculty",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teacher_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teacher_Person_PersonDTOId",
                        column: x => x.PersonDTOId,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teacher_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SemesterId = table.Column<int>(type: "int", nullable: false),
                    CategoryDTOId = table.Column<int>(type: "int", nullable: true),
                    SemesterDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Category_CategoryDTOId",
                        column: x => x.CategoryDTOId,
                        principalTable: "Category",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Course_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Course_Semester_SemesterDTOId",
                        column: x => x.SemesterDTOId,
                        principalTable: "Semester",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Course_Semester_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semester",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FacultyId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FacultyDTOId = table.Column<int>(type: "int", nullable: true),
                    TeacherDTOId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Class_Faculty_FacultyDTOId",
                        column: x => x.FacultyDTOId,
                        principalTable: "Faculty",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Class_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Class_Teacher_TeacherDTOId",
                        column: x => x.TeacherDTOId,
                        principalTable: "Teacher",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Class_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResearchTopic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TopicCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    KeyWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacultyId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FacultyDTOId = table.Column<int>(type: "int", nullable: true),
                    TeacherDTOId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchTopic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResearchTopic_Faculty_FacultyDTOId",
                        column: x => x.FacultyDTOId,
                        principalTable: "Faculty",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ResearchTopic_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResearchTopic_Teacher_TeacherDTOId",
                        column: x => x.TeacherDTOId,
                        principalTable: "Teacher",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ResearchTopic_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teacher_School",
                columns: table => new
                {
                    SchoolId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SchoolDTOId = table.Column<int>(type: "int", nullable: true),
                    TeacherDTOId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher_School", x => new { x.SchoolId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_Teacher_School_School_SchoolDTOId",
                        column: x => x.SchoolDTOId,
                        principalTable: "School",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teacher_School_School_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "School",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teacher_School_Teacher_TeacherDTOId",
                        column: x => x.TeacherDTOId,
                        principalTable: "Teacher",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teacher_School_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOpen = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    CourseDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignment_Course_CourseDTOId",
                        column: x => x.CourseDTOId,
                        principalTable: "Course",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assignment_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    ExamInstruction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    SemesterId = table.Column<int>(type: "int", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    CourseDTOId = table.Column<int>(type: "int", nullable: true),
                    SemesterDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exam_Course_CourseDTOId",
                        column: x => x.CourseDTOId,
                        principalTable: "Course",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exam_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exam_Semester_SemesterDTOId",
                        column: x => x.SemesterDTOId,
                        principalTable: "Semester",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exam_Semester_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semester",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LessonPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Objective = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Material = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentClassId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    ClassDTOId = table.Column<int>(type: "int", nullable: true),
                    CourseDTOId = table.Column<int>(type: "int", nullable: true),
                    RoomDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonPlan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonPlan_Class_ClassDTOId",
                        column: x => x.ClassDTOId,
                        principalTable: "Class",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LessonPlan_Class_StudentClassId",
                        column: x => x.StudentClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LessonPlan_Course_CourseDTOId",
                        column: x => x.CourseDTOId,
                        principalTable: "Course",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LessonPlan_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LessonPlan_Room_RoomDTOId",
                        column: x => x.RoomDTOId,
                        principalTable: "Room",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LessonPlan_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    FacultyId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    ClassDTOId = table.Column<int>(type: "int", nullable: true),
                    FacultyDTOId = table.Column<int>(type: "int", nullable: true),
                    PersonDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_Class_ClassDTOId",
                        column: x => x.ClassDTOId,
                        principalTable: "Class",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Student_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_Faculty_FacultyDTOId",
                        column: x => x.FacultyDTOId,
                        principalTable: "Faculty",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Student_Faculty_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_Person_PersonDTOId",
                        column: x => x.PersonDTOId,
                        principalTable: "Person",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Student_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Teacher_Class",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClassDTOId = table.Column<int>(type: "int", nullable: true),
                    TeacherDTOId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher_Class", x => new { x.ClassId, x.TeacherId });
                    table.ForeignKey(
                        name: "FK_Teacher_Class_Class_ClassDTOId",
                        column: x => x.ClassDTOId,
                        principalTable: "Class",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teacher_Class_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Teacher_Class_Teacher_TeacherDTOId",
                        column: x => x.TeacherDTOId,
                        principalTable: "Teacher",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Teacher_Class_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeachingSchedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TeacherId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: true),
                    RoomId = table.Column<int>(type: "int", nullable: true),
                    ClassDTOId = table.Column<int>(type: "int", nullable: true),
                    CourseDTOId = table.Column<int>(type: "int", nullable: true),
                    RoomDTOId = table.Column<int>(type: "int", nullable: true),
                    TeacherDTOId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachingSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeachingSchedule_Class_ClassDTOId",
                        column: x => x.ClassDTOId,
                        principalTable: "Class",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TeachingSchedule_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeachingSchedule_Course_CourseDTOId",
                        column: x => x.CourseDTOId,
                        principalTable: "Course",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TeachingSchedule_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeachingSchedule_Room_RoomDTOId",
                        column: x => x.RoomDTOId,
                        principalTable: "Room",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TeachingSchedule_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeachingSchedule_Teacher_TeacherDTOId",
                        column: x => x.TeacherDTOId,
                        principalTable: "Teacher",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TeachingSchedule_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResearchTopic_File",
                columns: table => new
                {
                    ResearchTopicId = table.Column<int>(type: "int", nullable: false),
                    FileId = table.Column<int>(type: "int", nullable: false),
                    FilesDTOId = table.Column<int>(type: "int", nullable: true),
                    ResearchTopicDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchTopic_File", x => new { x.ResearchTopicId, x.FileId });
                    table.ForeignKey(
                        name: "FK_ResearchTopic_File_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResearchTopic_File_Files_FilesDTOId",
                        column: x => x.FilesDTOId,
                        principalTable: "Files",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ResearchTopic_File_ResearchTopic_ResearchTopicDTOId",
                        column: x => x.ResearchTopicDTOId,
                        principalTable: "ResearchTopic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ResearchTopic_File_ResearchTopic_ResearchTopicId",
                        column: x => x.ResearchTopicId,
                        principalTable: "ResearchTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TopicObjective",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    ResearchTopicDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicObjective", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TopicObjective_ResearchTopic_ResearchTopicDTOId",
                        column: x => x.ResearchTopicDTOId,
                        principalTable: "ResearchTopic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TopicObjective_ResearchTopic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "ResearchTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TopicProgress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    ResearchTopicDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicProgress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TopicProgress_ResearchTopic_ResearchTopicDTOId",
                        column: x => x.ResearchTopicDTOId,
                        principalTable: "ResearchTopic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TopicProgress_ResearchTopic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "ResearchTopic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exam_File",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    FileId = table.Column<int>(type: "int", nullable: false),
                    ExamDTOId = table.Column<int>(type: "int", nullable: true),
                    FilesDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam_File", x => new { x.ExamId, x.FileId });
                    table.ForeignKey(
                        name: "FK_Exam_File_Exam_ExamDTOId",
                        column: x => x.ExamDTOId,
                        principalTable: "Exam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Exam_File_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exam_File_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exam_File_Files_FilesDTOId",
                        column: x => x.FilesDTOId,
                        principalTable: "Files",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Score = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    ExamDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_Exam_ExamDTOId",
                        column: x => x.ExamDTOId,
                        principalTable: "Exam",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Question_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LessonActivity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    TimeMinutes = table.Column<int>(type: "int", nullable: true),
                    LessonPlanId = table.Column<int>(type: "int", nullable: false),
                    LessonPlanDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonActivity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonActivity_LessonPlan_LessonPlanDTOId",
                        column: x => x.LessonPlanDTOId,
                        principalTable: "LessonPlan",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LessonActivity_LessonPlan_LessonPlanId",
                        column: x => x.LessonPlanId,
                        principalTable: "LessonPlan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudentScore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    ScoreValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ScoreType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseDTOId = table.Column<int>(type: "int", nullable: true),
                    StudentDTOId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentScore", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentScore_Course_CourseDTOId",
                        column: x => x.CourseDTOId,
                        principalTable: "Course",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentScore_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentScore_Student_StudentDTOId",
                        column: x => x.StudentDTOId,
                        principalTable: "Student",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_StudentScore_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Submission",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignmentId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignmentDTOId = table.Column<int>(type: "int", nullable: true),
                    StudentDTOId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Submission_Assignment_AssignmentDTOId",
                        column: x => x.AssignmentDTOId,
                        principalTable: "Assignment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Submission_Assignment_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Submission_Student_StudentDTOId",
                        column: x => x.StudentDTOId,
                        principalTable: "Student",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Submission_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionOption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    QuestionDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionOption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionOption_Question_QuestionDTOId",
                        column: x => x.QuestionDTOId,
                        principalTable: "Question",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_QuestionOption_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Submission_File",
                columns: table => new
                {
                    SubmissionId = table.Column<int>(type: "int", nullable: false),
                    FileId = table.Column<int>(type: "int", nullable: false),
                    FilesDTOId = table.Column<int>(type: "int", nullable: true),
                    SubmissionDTOId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submission_File", x => new { x.SubmissionId, x.FileId });
                    table.ForeignKey(
                        name: "FK_Submission_File_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Submission_File_Files_FilesDTOId",
                        column: x => x.FilesDTOId,
                        principalTable: "Files",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Submission_File_Submission_SubmissionDTOId",
                        column: x => x.SubmissionDTOId,
                        principalTable: "Submission",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Submission_File_Submission_SubmissionId",
                        column: x => x.SubmissionId,
                        principalTable: "Submission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_PersonDTOId",
                table: "Account",
                column: "PersonDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_PersonId",
                table: "Account",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_CourseDTOId",
                table: "Assignment",
                column: "CourseDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_CourseId",
                table: "Assignment",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryDTOId",
                table: "Book",
                column: "CategoryDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryId",
                table: "Book",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_ISBN",
                table: "Book",
                column: "ISBN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_Name",
                table: "Book",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_File_BookDTOId",
                table: "Book_File",
                column: "BookDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_File_FileId",
                table: "Book_File",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_File_FilesDTOId",
                table: "Book_File",
                column: "FilesDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_Name",
                table: "Category",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Class_FacultyDTOId",
                table: "Class",
                column: "FacultyDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_FacultyId",
                table: "Class",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_Name",
                table: "Class",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Class_TeacherDTOId",
                table: "Class",
                column: "TeacherDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_TeacherId",
                table: "Class",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_CategoryDTOId",
                table: "Course",
                column: "CategoryDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_CategoryId",
                table: "Course",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_FullName",
                table: "Course",
                column: "FullName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Course_SemesterDTOId",
                table: "Course",
                column: "SemesterDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_SemesterId",
                table: "Course",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_ShortName",
                table: "Course",
                column: "ShortName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exam_CourseDTOId",
                table: "Exam",
                column: "CourseDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_CourseId",
                table: "Exam",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_SemesterDTOId",
                table: "Exam",
                column: "SemesterDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_SemesterId",
                table: "Exam",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_File_ExamDTOId",
                table: "Exam_File",
                column: "ExamDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_File_FileId",
                table: "Exam_File",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_File_FilesDTOId",
                table: "Exam_File",
                column: "FilesDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_Name",
                table: "Faculty",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_SchoolDTOId",
                table: "Faculty",
                column: "SchoolDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_SchoolId",
                table: "Faculty",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonActivity_LessonPlanDTOId",
                table: "LessonActivity",
                column: "LessonPlanDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonActivity_LessonPlanId",
                table: "LessonActivity",
                column: "LessonPlanId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonPlan_ClassDTOId",
                table: "LessonPlan",
                column: "ClassDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonPlan_CourseDTOId",
                table: "LessonPlan",
                column: "CourseDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonPlan_CourseId",
                table: "LessonPlan",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonPlan_RoomDTOId",
                table: "LessonPlan",
                column: "RoomDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonPlan_RoomId",
                table: "LessonPlan",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonPlan_StudentClassId",
                table: "LessonPlan",
                column: "StudentClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Email",
                table: "Person",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Question_ExamDTOId",
                table: "Question",
                column: "ExamDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_ExamId",
                table: "Question",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOption_QuestionDTOId",
                table: "QuestionOption",
                column: "QuestionDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOption_QuestionId",
                table: "QuestionOption",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchTopic_FacultyDTOId",
                table: "ResearchTopic",
                column: "FacultyDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchTopic_FacultyId",
                table: "ResearchTopic",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchTopic_TeacherDTOId",
                table: "ResearchTopic",
                column: "TeacherDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchTopic_TeacherId",
                table: "ResearchTopic",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchTopic_File_FileId",
                table: "ResearchTopic_File",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchTopic_File_FilesDTOId",
                table: "ResearchTopic_File",
                column: "FilesDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_ResearchTopic_File_ResearchTopicDTOId",
                table: "ResearchTopic_File",
                column: "ResearchTopicDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Room_Name",
                table: "Room",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Semester_SchoolDTOId",
                table: "Semester",
                column: "SchoolDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Semester_SchoolId",
                table: "Semester",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_ClassDTOId",
                table: "Student",
                column: "ClassDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_ClassId",
                table: "Student",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_FacultyDTOId",
                table: "Student",
                column: "FacultyDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_FacultyId",
                table: "Student",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_PersonDTOId",
                table: "Student",
                column: "PersonDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_PersonId",
                table: "Student",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentScore_CourseDTOId",
                table: "StudentScore",
                column: "CourseDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentScore_CourseId",
                table: "StudentScore",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentScore_StudentDTOId",
                table: "StudentScore",
                column: "StudentDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentScore_StudentId",
                table: "StudentScore",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Submission_AssignmentDTOId",
                table: "Submission",
                column: "AssignmentDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Submission_AssignmentId",
                table: "Submission",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Submission_StudentDTOId",
                table: "Submission",
                column: "StudentDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Submission_StudentId",
                table: "Submission",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Submission_File_FileId",
                table: "Submission_File",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Submission_File_FilesDTOId",
                table: "Submission_File",
                column: "FilesDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Submission_File_SubmissionDTOId",
                table: "Submission_File",
                column: "SubmissionDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_FacultyDTOId",
                table: "Teacher",
                column: "FacultyDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_FacultyId",
                table: "Teacher",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_PersonDTOId",
                table: "Teacher",
                column: "PersonDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_PersonId",
                table: "Teacher",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Class_ClassDTOId",
                table: "Teacher_Class",
                column: "ClassDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Class_TeacherDTOId",
                table: "Teacher_Class",
                column: "TeacherDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_Class_TeacherId",
                table: "Teacher_Class",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_School_SchoolDTOId",
                table: "Teacher_School",
                column: "SchoolDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_School_TeacherDTOId",
                table: "Teacher_School",
                column: "TeacherDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_School_TeacherId",
                table: "Teacher_School",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachingSchedule_ClassDTOId",
                table: "TeachingSchedule",
                column: "ClassDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachingSchedule_ClassId",
                table: "TeachingSchedule",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachingSchedule_CourseDTOId",
                table: "TeachingSchedule",
                column: "CourseDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachingSchedule_CourseId",
                table: "TeachingSchedule",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachingSchedule_RoomDTOId",
                table: "TeachingSchedule",
                column: "RoomDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachingSchedule_RoomId",
                table: "TeachingSchedule",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachingSchedule_TeacherDTOId",
                table: "TeachingSchedule",
                column: "TeacherDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachingSchedule_TeacherId",
                table: "TeachingSchedule",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicObjective_ResearchTopicDTOId",
                table: "TopicObjective",
                column: "ResearchTopicDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicObjective_TopicId",
                table: "TopicObjective",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicProgress_ResearchTopicDTOId",
                table: "TopicProgress",
                column: "ResearchTopicDTOId");

            migrationBuilder.CreateIndex(
                name: "IX_TopicProgress_TopicId",
                table: "TopicProgress",
                column: "TopicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Book_File");

            migrationBuilder.DropTable(
                name: "Exam_File");

            migrationBuilder.DropTable(
                name: "LessonActivity");

            migrationBuilder.DropTable(
                name: "QuestionOption");

            migrationBuilder.DropTable(
                name: "ResearchTopic_File");

            migrationBuilder.DropTable(
                name: "StudentScore");

            migrationBuilder.DropTable(
                name: "Submission_File");

            migrationBuilder.DropTable(
                name: "Teacher_Class");

            migrationBuilder.DropTable(
                name: "Teacher_School");

            migrationBuilder.DropTable(
                name: "TeachingSchedule");

            migrationBuilder.DropTable(
                name: "TopicObjective");

            migrationBuilder.DropTable(
                name: "TopicProgress");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "LessonPlan");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "Submission");

            migrationBuilder.DropTable(
                name: "ResearchTopic");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Semester");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "School");
        }
    }
}
