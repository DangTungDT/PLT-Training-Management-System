using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.databaseContext
{
    public static class GeneratedSeedData
    {
        public static void ApplyGeneratedSeed(this ModelBuilder modelBuilder)
        {
            // =====================
            // Category (first 10)
            // =====================
            modelBuilder.Entity<CategoryDTO>().HasData(
                new CategoryDTO { Id = 1, Name = "Lập trình cơ bản", Description = "C#, Java, Python", IsActive = true, Type = "both", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564") },
                new CategoryDTO { Id = 2, Name = "Cơ sở dữ liệu", Description = "SQL, NoSQL", IsActive = true, Type = "both", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564") },
                new CategoryDTO { Id = 3, Name = "Phát triển web", Description = "Frontend & Backend", IsActive = true, Type = "both", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564") },
                new CategoryDTO { Id = 4, Name = "Phát triển mobile", Description = "Android, iOS, Flutter", IsActive = true, Type = "both", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564") },
                new CategoryDTO { Id = 5, Name = "Trí tuệ nhân tạo", Description = "ML, DL", IsActive = true, Type = "both", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564") },
                new CategoryDTO { Id = 6, Name = "An ninh mạng", Description = "Bảo mật hệ thống", IsActive = true, Type = "book", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564") },
                new CategoryDTO { Id = 7, Name = "DevOps", Description = "Docker, Kubernetes", IsActive = true, Type = "both", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564") },
                new CategoryDTO { Id = 8, Name = "Game Development", Description = "Unity, Unreal", IsActive = true, Type = "both", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564") },
                new CategoryDTO { Id = 9, Name = "Blockchain", Description = "Ethereum", IsActive = true, Type = "book", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564") },
                new CategoryDTO { Id = 10, Name = "Cloud Computing", Description = "AWS, Azure", IsActive = true, Type = "both", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.6939564") }
            );

            // =====================
            // Book (first 10)
            // =====================
            modelBuilder.Entity<BookDTO>().HasData(
                new BookDTO { Id = 2, ISBN = "9780596007737", Name = "Head First Design Patterns", Author = "Elisabeth Freeman", PublishedYear = 2004, Description = "Design patterns", DifficultyLevel = "Intermediate", CategoryId = 1, DateUpload = DateTime.Parse("2025-01-02T00:00:00.0000000"), PersonId = 2, TotalRead = 550, TotalDownload = 220 },
                new BookDTO { Id = 3, ISBN = "9780132350884", Name = "Clean Code", Author = "Robert C. Martin", PublishedYear = 2008, Description = "Clean code", DifficultyLevel = "Intermediate", CategoryId = 1, DateUpload = DateTime.Parse("2025-01-03T00:00:00.0000000"), PersonId = 3, TotalRead = 700, TotalDownload = 300 },
                new BookDTO { Id = 4, ISBN = "9780321127426", Name = "Agile Software Development", Author = "Robert C. Martin", PublishedYear = 2002, Description = "Agile principles", DifficultyLevel = "Intermediate", CategoryId = 14, DateUpload = DateTime.Parse("2025-01-04T00:00:00.0000000"), PersonId = 4, TotalRead = 450, TotalDownload = 180 },
                new BookDTO { Id = 5, ISBN = "9780596519749", Name = "Programming Python", Author = "Mark Lutz", PublishedYear = 2010, Description = "Python in depth", DifficultyLevel = "Advanced", CategoryId = 1, DateUpload = DateTime.Parse("2025-01-05T00:00:00.0000000"), PersonId = 5, TotalRead = 520, TotalDownload = 200 },
                new BookDTO { Id = 6, ISBN = "9781491952023", Name = "You Don't Know JS", Author = "Kyle Simpson", PublishedYear = 2015, Description = "JavaScript deep", DifficultyLevel = "Intermediate", CategoryId = 3, DateUpload = DateTime.Parse("2025-01-06T00:00:00.0000000"), PersonId = 6, TotalRead = 800, TotalDownload = 350 },
                new BookDTO { Id = 7, ISBN = "9781491912058", Name = "Fluent Python", Author = "Luciano Ramalho", PublishedYear = 2015, Description = "Python advanced", DifficultyLevel = "Advanced", CategoryId = 1, DateUpload = DateTime.Parse("2025-01-07T00:00:00.0000000"), PersonId = 7, TotalRead = 480, TotalDownload = 190 },
                new BookDTO { Id = 8, ISBN = "9781491949136", Name = "Learning React", Author = "Alex Banks", PublishedYear = 2017, Description = "React tutorial", DifficultyLevel = "Intermediate", CategoryId = 3, DateUpload = DateTime.Parse("2025-01-08T00:00:00.0000000"), PersonId = 8, TotalRead = 600, TotalDownload = 240 },
                new BookDTO { Id = 9, ISBN = "9781491907337", Name = "Docker Deep Dive", Author = "Nigel Poulton", PublishedYear = 2020, Description = "Docker advanced", DifficultyLevel = "Advanced", CategoryId = 7, DateUpload = DateTime.Parse("2025-01-09T00:00:00.0000000"), PersonId = 9, TotalRead = 400, TotalDownload = 160 },
                new BookDTO { Id = 10, ISBN = "9781492052302", Name = "Blockchain Basics", Author = "Daniel Drescher", PublishedYear = 2017, Description = "Blockchain intro", DifficultyLevel = "Beginner", CategoryId = 9, DateUpload = DateTime.Parse("2025-01-10T00:00:00.0000000"), PersonId = 10, TotalRead = 350, TotalDownload = 140 },
                new BookDTO { Id = 11, ISBN = "9781492032649", Name = "Hands-On Machine Learning", Author = "Aurélien Géron", PublishedYear = 2019, Description = "ML with Scikit & TF", DifficultyLevel = "Advanced", CategoryId = 5, DateUpload = DateTime.Parse("2025-01-11T00:00:00.0000000"), PersonId = 11, TotalRead = 850, TotalDownload = 400 }
            );

            // =====================
            // Book_File (first 10)
            // =====================
            modelBuilder.Entity<BookFileDTO>().HasData(
                new BookFileDTO { BookId = 2, FileId = 2 },
                new BookFileDTO { BookId = 3, FileId = 3 },
                new BookFileDTO { BookId = 4, FileId = 4 },
                new BookFileDTO { BookId = 5, FileId = 5 },
                new BookFileDTO { BookId = 6, FileId = 6 },
                new BookFileDTO { BookId = 7, FileId = 7 },
                new BookFileDTO { BookId = 8, FileId = 8 },
                new BookFileDTO { BookId = 9, FileId = 9 },
                new BookFileDTO { BookId = 10, FileId = 10 },
                new BookFileDTO { BookId = 11, FileId = 11 }
            );

            // =====================
            // Class (first 10)
            // =====================
            modelBuilder.Entity<ClassDTO>().HasData(
                new ClassDTO { Id = 1, Name = "D21CQCN01", FacultyId = 1, TeacherId = "GV001" },
                new ClassDTO { Id = 2, Name = "D21CQCN02", FacultyId = 1, TeacherId = "GV002" },
                new ClassDTO { Id = 3, Name = "D21CQDT01", FacultyId = 2, TeacherId = "GV003" },
                new ClassDTO { Id = 4, Name = "D21CQKT01", FacultyId = 3, TeacherId = "GV004" },
                new ClassDTO { Id = 5, Name = "D21CQCK01", FacultyId = 4, TeacherId = "GV005" },
                new ClassDTO { Id = 6, Name = "D21CQS01", FacultyId = 5, TeacherId = "GV006" },
                new ClassDTO { Id = 7, Name = "D21CQTC01", FacultyId = 6, TeacherId = "GV007" },
                new ClassDTO { Id = 8, Name = "D21CQPM01", FacultyId = 7, TeacherId = "GV008" },
                new ClassDTO { Id = 9, Name = "D21CQIT01", FacultyId = 8, TeacherId = "GV009" },
                new ClassDTO { Id = 10, Name = "D21CQSE01", FacultyId = 9, TeacherId = "GV010" }
            );

            // =====================
            // ClassExam (first available rows)
            // =====================
            modelBuilder.Entity<ClassExamDTO>().HasData(
                new ClassExamDTO { Id = 1, ExamId = 1, ClassId = 1 },
                new ClassExamDTO { Id = 2, ExamId = 1, ClassId = 2 },
                new ClassExamDTO { Id = 3, ExamId = 21, ClassId = 1 }
            );

            // =====================
            // Course (first 10)
            // =====================
            modelBuilder.Entity<CourseDTO>().HasData(
                new CourseDTO { Id = 1, FullName = "Lập trình C# cơ bản", ShortName = "CSHARP101", StartDate = DateTime.Parse("2025-01-01T00:00:00.0000000"), EndDate = DateTime.Parse("2025-06-30T00:00:00.0000000"), Description = "C# cơ bản", CategoryId = 1, SemesterId = 1 },
                new CourseDTO { Id = 2, FullName = "Lập trình Java", ShortName = "JAVA101", StartDate = DateTime.Parse("2025-01-01T00:00:00.0000000"), EndDate = DateTime.Parse("2025-06-30T00:00:00.0000000"), Description = "Java cơ bản", CategoryId = 1, SemesterId = 1 },
                new CourseDTO { Id = 3, FullName = "Cơ sở dữ liệu", ShortName = "DB101", StartDate = DateTime.Parse("2025-01-01T00:00:00.0000000"), EndDate = DateTime.Parse("2025-06-30T00:00:00.0000000"), Description = "SQL Server", CategoryId = 2, SemesterId = 1 },
                new CourseDTO { Id = 4, FullName = "Phát triển Web Frontend", ShortName = "WEBFE", StartDate = DateTime.Parse("2025-01-01T00:00:00.0000000"), EndDate = DateTime.Parse("2025-06-30T00:00:00.0000000"), Description = "React", CategoryId = 3, SemesterId = 1 },
                new CourseDTO { Id = 5, FullName = "Phát triển Web Backend", ShortName = "WEBBE", StartDate = DateTime.Parse("2025-07-01T00:00:00.0000000"), EndDate = DateTime.Parse("2025-12-31T00:00:00.0000000"), Description = "Node.js", CategoryId = 3, SemesterId = 2 },
                new CourseDTO { Id = 6, FullName = "Flutter Mobile", ShortName = "FLUTTER", StartDate = DateTime.Parse("2025-01-01T00:00:00.0000000"), EndDate = DateTime.Parse("2025-06-30T00:00:00.0000000"), Description = "Cross-platform", CategoryId = 4, SemesterId = 1 },
                new CourseDTO { Id = 7, FullName = "Machine Learning", ShortName = "ML101", StartDate = DateTime.Parse("2025-07-01T00:00:00.0000000"), EndDate = DateTime.Parse("2025-12-31T00:00:00.0000000"), Description = "Scikit-learn", CategoryId = 5, SemesterId = 2 },
                new CourseDTO { Id = 8, FullName = "An ninh mạng", ShortName = "CYBER", StartDate = DateTime.Parse("2025-01-01T00:00:00.0000000"), EndDate = DateTime.Parse("2025-06-30T00:00:00.0000000"), Description = "Bảo mật", CategoryId = 6, SemesterId = 1 },
                new CourseDTO { Id = 9, FullName = "DevOps", ShortName = "DEVOPS", StartDate = DateTime.Parse("2025-07-01T00:00:00.0000000"), EndDate = DateTime.Parse("2025-12-31T00:00:00.0000000"), Description = "Docker", CategoryId = 7, SemesterId = 2 },
                new CourseDTO { Id = 10, FullName = "Unity Game", ShortName = "UNITY", StartDate = DateTime.Parse("2025-01-01T00:00:00.0000000"), EndDate = DateTime.Parse("2025-06-30T00:00:00.0000000"), Description = "Game 2D/3D", CategoryId = 8, SemesterId = 1 }
            );

            // =====================
            // CourseClassDTO (first 10)
            // =====================
            modelBuilder.Entity<CourseClassDTO>().HasData(
                new CourseClassDTO { CourseId = 1, ClassId = 1 },
                new CourseClassDTO { CourseId = 14, ClassId = 1 },
                new CourseClassDTO { CourseId = 1, ClassId = 2 },
                new CourseClassDTO { CourseId = 15, ClassId = 2 },
                new CourseClassDTO { CourseId = 1, ClassId = 3 },
                new CourseClassDTO { CourseId = 2, ClassId = 3 },
                new CourseClassDTO { CourseId = 16, ClassId = 3 },
                new CourseClassDTO { CourseId = 2, ClassId = 4 },
                new CourseClassDTO { CourseId = 17, ClassId = 4 },
                new CourseClassDTO { CourseId = 2, ClassId = 5 }
            );

            // =====================
            // Exam (first 10)
            // =====================
            modelBuilder.Entity<ExamDTO>().HasData(
                new ExamDTO { Id = 1, Name = "Giữa kỳ C sharp", Type = "Trắc nghiệm", Duration = 60, ExamInstruction = "Chọn đáp án đúng", Description = "Giữa kỳ", CourseId = 1, SemesterId = 1, Year = 2026, Status = "Đang sử dụng" },
                new ExamDTO { Id = 2, Name = "Cuối kỳ C sharp", Type = "Mixed", Duration = 90, ExamInstruction = "Trắc nghiệm + tự luận", Description = "Cuối kỳ", CourseId = 1, SemesterId = 1, Year = 2025, Status = "đang sử dụng" },
                new ExamDTO { Id = 3, Name = "Giữa kỳ Java", Type = "MultipleChoice", Duration = 60, ExamInstruction = "Chọn đáp án", Description = "Giữa kỳ", CourseId = 2, SemesterId = 1, Year = 2025, Status = "đang sử dụng" },
                new ExamDTO { Id = 4, Name = "Cuối kỳ Java", Type = "Essay", Duration = 90, ExamInstruction = "Tự luận", Description = "Cuối kỳ", CourseId = 2, SemesterId = 1, Year = 2025, Status = "đang sử dụng" },
                new ExamDTO { Id = 5, Name = "Giữa kỳ DB", Type = "MultipleChoice", Duration = 60, ExamInstruction = "SQL", Description = "Giữa kỳ", CourseId = 3, SemesterId = 1, Year = 2025, Status = "đang sử dụng" },
                new ExamDTO { Id = 6, Name = "Cuối kỳ DB", Type = "Mixed", Duration = 90, ExamInstruction = "Thiết kế CSDL", Description = "Cuối kỳ", CourseId = 3, SemesterId = 1, Year = 2025, Status = "đang sử dụng" },
                new ExamDTO { Id = 7, Name = "Giữa kỳ Web FE", Type = "MultipleChoice", Duration = 60, ExamInstruction = "React", Description = "Giữa kỳ", CourseId = 4, SemesterId = 1, Year = 2025, Status = "đang sử dụng" },
                new ExamDTO { Id = 8, Name = "Cuối kỳ Web FE", Type = "Essay", Duration = 120, ExamInstruction = "Project", Description = "Cuối kỳ", CourseId = 4, SemesterId = 1, Year = 2025, Status = "đang sử dụng" },
                new ExamDTO { Id = 9, Name = "Giữa kỳ Web BE", Type = "MultipleChoice", Duration = 60, ExamInstruction = "API", Description = "Giữa kỳ", CourseId = 5, SemesterId = 2, Year = 2025, Status = "Bảng nháp" },
                new ExamDTO { Id = 10, Name = "Cuối kỳ Web BE", Type = "Mixed", Duration = 90, ExamInstruction = "Backend project", Description = "Cuối kỳ", CourseId = 5, SemesterId = 2, Year = 2025, Status = "Bảng nháp" }
            );

            // =====================
            // Exam_File (first 10)
            // =====================
            modelBuilder.Entity<ExamFileDTO>().HasData(
                new ExamFileDTO { ExamId = 1, FileId = 1 },
                new ExamFileDTO { ExamId = 2, FileId = 2 },
                new ExamFileDTO { ExamId = 3, FileId = 3 },
                new ExamFileDTO { ExamId = 4, FileId = 4 },
                new ExamFileDTO { ExamId = 5, FileId = 5 },
                new ExamFileDTO { ExamId = 6, FileId = 6 },
                new ExamFileDTO { ExamId = 7, FileId = 7 },
                new ExamFileDTO { ExamId = 8, FileId = 8 },
                new ExamFileDTO { ExamId = 9, FileId = 9 },
                new ExamFileDTO { ExamId = 10, FileId = 10 }
            );

            // =====================
            // Faculty (first 10)
            // =====================
            modelBuilder.Entity<FacultyDTO>().HasData(
                new FacultyDTO { Id = 1, Name = "Khoa CNTT - HUST", SchoolId = 1, Description = "Công nghệ thông tin HUST" },
                new FacultyDTO { Id = 2, Name = "Khoa Điện tử - HUST", SchoolId = 1, Description = "Điện tử viễn thông HUST" },
                new FacultyDTO { Id = 3, Name = "Khoa Kinh tế - VNU", SchoolId = 2, Description = "Kinh tế Quốc gia Hà Nội" },
                new FacultyDTO { Id = 4, Name = "Khoa CNTT - HUTECH", SchoolId = 3, Description = "Công nghệ thông tin HUTECH" },
                new FacultyDTO { Id = 5, Name = "Khoa Cơ khí - HCMUT", SchoolId = 4, Description = "Cơ khí Bách Khoa TP.HCM" },
                new FacultyDTO { Id = 6, Name = "Khoa KHMT - HCMUS", SchoolId = 5, Description = "Khoa học máy tính HCMUS" },
                new FacultyDTO { Id = 7, Name = "Khoa Sư phạm Toán - HCMUE", SchoolId = 6, Description = "Sư phạm Toán HCMUE" },
                new FacultyDTO { Id = 8, Name = "Khoa Tài chính - UEH", SchoolId = 7, Description = "Tài chính Kinh tế TP.HCM" },
                new FacultyDTO { Id = 9, Name = "Khoa CNTT - TDTU", SchoolId = 8, Description = "Công nghệ thông tin Tôn Đức Thắng" },
                new FacultyDTO { Id = 10, Name = "Khoa CNTT - FPT", SchoolId = 9, Description = "Công nghệ thông tin FPT" }
            );

            // =====================
            // Files (first 10)
            // =====================
            modelBuilder.Entity<FilesDTO>().HasData(
                new FilesDTO { Id = 1, FileName = "slide_csharp1.pdf", FilePath = "/files/slide_csharp1.pdf", FileType = "pdf", FileSize = 2500000, CreatedAt = DateTime.Parse("2026-01-22T09:38:36.7173042") },
                new FilesDTO { Id = 2, FileName = "slide_java1.pdf", FilePath = "/files/slide_java1.pdf", FileType = "pdf", FileSize = 2800000, CreatedAt = DateTime.Parse("2026-01-22T09:38:36.7173042") },
                new FilesDTO { Id = 3, FileName = "lab_sql.zip", FilePath = "/files/lab_sql.zip", FileType = "zip", FileSize = 6000000, CreatedAt = DateTime.Parse("2026-01-22T09:38:36.7173042") },
                new FilesDTO { Id = 4, FileName = "book_clean_code.pdf", FilePath = "/files/book_clean_code.pdf", FileType = "pdf", FileSize = 9000000, CreatedAt = DateTime.Parse("2026-01-22T09:38:36.7173042") },
                new FilesDTO { Id = 5, FileName = "exam_csharp.pdf", FilePath = "/files/exam_csharp.pdf", FileType = "pdf", FileSize = 1800000, CreatedAt = DateTime.Parse("2026-01-22T09:38:36.7173042") },
                new FilesDTO { Id = 6, FileName = "slide_react.pdf", FilePath = "/files/slide_react.pdf", FileType = "pdf", FileSize = 3200000, CreatedAt = DateTime.Parse("2026-01-22T09:38:36.7173042") },
                new FilesDTO { Id = 7, FileName = "project_flutter.zip", FilePath = "/files/project_flutter.zip", FileType = "zip", FileSize = 15000000, CreatedAt = DateTime.Parse("2026-01-22T09:38:36.7173042") },
                new FilesDTO { Id = 8, FileName = "report_ml.docx", FilePath = "/files/report_ml.docx", FileType = "docx", FileSize = 4000000, CreatedAt = DateTime.Parse("2026-01-22T09:38:36.7173042") },
                new FilesDTO { Id = 9, FileName = "code_node.zip", FilePath = "/files/code_node.zip", FileType = "zip", FileSize = 5000000, CreatedAt = DateTime.Parse("2026-01-22T09:38:36.7173042") },
                new FilesDTO { Id = 10, FileName = "tutorial_docker.pdf", FilePath = "/files/tutorial_docker.pdf", FileType = "pdf", FileSize = 7000000, CreatedAt = DateTime.Parse("2026-01-22T09:38:36.7173042") }
            );

            // =====================
            // LessonActivity (first 10)
            // =====================
            modelBuilder.Entity<LessonActivityDTO>().HasData(
                new LessonActivityDTO { Id = 1, Name = "Giới thiệu", SortOrder = 1, TimeMinutes = 15, LessonPlanId = 1 },
                new LessonActivityDTO { Id = 2, Name = "Giảng lý thuyết", SortOrder = 2, TimeMinutes = 60, LessonPlanId = 1 },
                new LessonActivityDTO { Id = 3, Name = "Hỏi đáp", SortOrder = 3, TimeMinutes = 15, LessonPlanId = 1 },
                new LessonActivityDTO { Id = 4, Name = "Thực hành", SortOrder = 1, TimeMinutes = 90, LessonPlanId = 2 },
                new LessonActivityDTO { Id = 5, Name = "Giới thiệu", SortOrder = 1, TimeMinutes = 20, LessonPlanId = 3 },
                new LessonActivityDTO { Id = 6, Name = "Giảng lý thuyết", SortOrder = 2, TimeMinutes = 70, LessonPlanId = 3 },
                new LessonActivityDTO { Id = 7, Name = "Thực hành query", SortOrder = 1, TimeMinutes = 90, LessonPlanId = 4 },
                new LessonActivityDTO { Id = 8, Name = "Giới thiệu React", SortOrder = 1, TimeMinutes = 15, LessonPlanId = 5 },
                new LessonActivityDTO { Id = 9, Name = "Code demo", SortOrder = 2, TimeMinutes = 75, LessonPlanId = 5 },
                new LessonActivityDTO { Id = 10, Name = "Thực hành component", SortOrder = 1, TimeMinutes = 90, LessonPlanId = 6 }
            );

            // =====================
            // LessonPlan (first 10)
            // =====================
            modelBuilder.Entity<LessonPlanDTO>().HasData(
                new LessonPlanDTO { Id = 1, Name = "Giới thiệu C#", Type = "Theory", StartDate = DateTime.Parse("2025-10-01T00:00:00.0000000"), EndDate = DateTime.Parse("2025-10-01T00:00:00.0000000"), Description = "Cú pháp cơ bản", Objective = "Hiểu ngôn ngữ", Material = "Slide 1", CourseId = 1, StudentClassId = 1, RoomId = 1 },
                new LessonPlanDTO { Id = 2, Name = "OOP trong C#", Type = "Theory", StartDate = DateTime.Parse("2025-10-03T00:00:00.0000000"), EndDate = DateTime.Parse("2025-10-03T00:00:00.0000000"), Description = "Class, inheritance", Objective = "Áp dụng OOP", Material = "Slide 2", CourseId = 1, StudentClassId = 1, RoomId = 1 },
                new LessonPlanDTO { Id = 3, Name = "Java basics", Type = "Theory", StartDate = DateTime.Parse("2025-10-02T00:00:00.0000000"), EndDate = DateTime.Parse("2025-10-02T00:00:00.0000000"), Description = "JVM", Objective = "Hiểu Java", Material = "Slide Java", CourseId = 2, StudentClassId = 2, RoomId = 2 },
                new LessonPlanDTO { Id = 4, Name = "SQL query", Type = "Practice", StartDate = DateTime.Parse("2025-10-04T00:00:00.0000000"), EndDate = DateTime.Parse("2025-10-04T00:00:00.0000000"), Description = "SELECT, JOIN", Objective = "Viết query", Material = "Lab SQL", CourseId = 3, StudentClassId = 3, RoomId = 3 },
                new LessonPlanDTO { Id = 5, Name = "React components", Type = "Theory", StartDate = DateTime.Parse("2025-10-05T00:00:00.0000000"), EndDate = DateTime.Parse("2025-10-05T00:00:00.0000000"), Description = "JSX", Objective = "Xây dựng UI", Material = "Slide React", CourseId = 4, StudentClassId = 4, RoomId = 4 },
                new LessonPlanDTO { Id = 6, Name = "Node.js API", Type = "Practice", StartDate = DateTime.Parse("2025-10-06T00:00:00.0000000"), EndDate = DateTime.Parse("2025-10-06T00:00:00.0000000"), Description = "Express", Objective = "Tạo API", Material = "Code sample", CourseId = 5, StudentClassId = 5, RoomId = 5 },
                new LessonPlanDTO { Id = 7, Name = "Flutter widgets", Type = "Theory", StartDate = DateTime.Parse("2025-10-07T00:00:00.0000000"), EndDate = DateTime.Parse("2025-10-07T00:00:00.0000000"), Description = "Stateless/Stateful", Objective = "Xây dựng app", Material = "Slide Flutter", CourseId = 6, StudentClassId = 6, RoomId = 6 },
                new LessonPlanDTO { Id = 8, Name = "ML concepts", Type = "Theory", StartDate = DateTime.Parse("2025-10-08T00:00:00.0000000"), EndDate = DateTime.Parse("2025-10-08T00:00:00.0000000"), Description = "Supervised learning", Objective = "Hiểu ML", Material = "Slide ML", CourseId = 7, StudentClassId = 7, RoomId = 7 },
                new LessonPlanDTO { Id = 9, Name = "Cyber threats", Type = "Theory", StartDate = DateTime.Parse("2025-10-09T00:00:00.0000000"), EndDate = DateTime.Parse("2025-10-09T00:00:00.0000000"), Description = "Phishing, DDoS", Objective = "Nhận diện tấn công", Material = "Slide Cyber", CourseId = 8, StudentClassId = 8, RoomId = 8 },
                new LessonPlanDTO { Id = 10, Name = "Docker containers", Type = "Practice", StartDate = DateTime.Parse("2025-10-10T00:00:00.0000000"), EndDate = DateTime.Parse("2025-10-10T00:00:00.0000000"), Description = "Dockerfile", Objective = "Chạy container", Material = "Lab Docker", CourseId = 9, StudentClassId = 9, RoomId = 9 }
            );

            // =====================
            // LessonSchedule (first 10)
            // =====================
            modelBuilder.Entity<LessonScheduleDTO>().HasData(
                new LessonScheduleDTO { Id = 1, LessonPlanId = 1, ClassId = 1, RoomId = 1, DayOfWeek = 4, Session = "M", StartTime = TimeSpan.Parse("08:00:00"), EndTime = TimeSpan.Parse("10:00:00") },
                new LessonScheduleDTO { Id = 2, LessonPlanId = 1, ClassId = 1, RoomId = 1, DayOfWeek = 4, Session = "A", StartTime = TimeSpan.Parse("13:00:00"), EndTime = TimeSpan.Parse("15:00:00") },
                new LessonScheduleDTO { Id = 3, LessonPlanId = 2, ClassId = 2, RoomId = 2, DayOfWeek = 3, Session = "M", StartTime = TimeSpan.Parse("08:00:00"), EndTime = TimeSpan.Parse("10:00:00") },
                new LessonScheduleDTO { Id = 4, LessonPlanId = 2, ClassId = 2, RoomId = 2, DayOfWeek = 3, Session = "A", StartTime = TimeSpan.Parse("14:00:00"), EndTime = TimeSpan.Parse("16:00:00") },
                new LessonScheduleDTO { Id = 5, LessonPlanId = 3, ClassId = 3, RoomId = 3, DayOfWeek = 4, Session = "M", StartTime = TimeSpan.Parse("07:30:00"), EndTime = TimeSpan.Parse("09:30:00") },
                new LessonScheduleDTO { Id = 6, LessonPlanId = 3, ClassId = 3, RoomId = 3, DayOfWeek = 4, Session = "A", StartTime = TimeSpan.Parse("13:30:00"), EndTime = TimeSpan.Parse("15:30:00") },
                new LessonScheduleDTO { Id = 7, LessonPlanId = 4, ClassId = 4, RoomId = 4, DayOfWeek = 5, Session = "M", StartTime = TimeSpan.Parse("08:00:00"), EndTime = TimeSpan.Parse("10:00:00") },
                new LessonScheduleDTO { Id = 8, LessonPlanId = 4, ClassId = 4, RoomId = 4, DayOfWeek = 5, Session = "A", StartTime = TimeSpan.Parse("15:00:00"), EndTime = TimeSpan.Parse("17:00:00") },
                new LessonScheduleDTO { Id = 9, LessonPlanId = 5, ClassId = 5, RoomId = 5, DayOfWeek = 6, Session = "M", StartTime = TimeSpan.Parse("09:00:00"), EndTime = TimeSpan.Parse("11:00:00") },
                new LessonScheduleDTO { Id = 10, LessonPlanId = 6, ClassId = 6, RoomId = 6, DayOfWeek = 6, Session = "A", StartTime = TimeSpan.Parse("13:00:00"), EndTime = TimeSpan.Parse("15:00:00") }
            );

            // =====================
            // Person (first 10)
            // =====================
            modelBuilder.Entity<PersonDTO>().HasData(
                new PersonDTO { Id = 1, FullName = "Nguyễn Văn An", Email = "an.nguyen@example.com", Phone = "0901000001", Gender = "Male", BirthDate = DateTime.Parse("1985-01-15T00:00:00.0000000"), Address = "Hà Nội", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446") },
                new PersonDTO { Id = 2, FullName = "Trần Thị Bình", Email = "binh.tran@example.com", Phone = "0901000002", Gender = "Female", BirthDate = DateTime.Parse("1986-02-20T00:00:00.0000000"), Address = "TP.HCM", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446") },
                new PersonDTO { Id = 3, FullName = "Lê Văn Cường", Email = "cuong.le@example.com", Phone = "0901000003", Gender = "Male", BirthDate = DateTime.Parse("1984-03-10T00:00:00.0000000"), Address = "Đà Nẵng", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446") },
                new PersonDTO { Id = 4, FullName = "Phạm Thị Dung", Email = "dung.pham@example.com", Phone = "0901000004", Gender = "Female", BirthDate = DateTime.Parse("1987-04-05T00:00:00.0000000"), Address = "Cần Thơ", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446") },
                new PersonDTO { Id = 5, FullName = "Hồ Văn Em", Email = "em.ho@example.com", Phone = "0901000005", Gender = "Male", BirthDate = DateTime.Parse("1983-05-25T00:00:00.0000000"), Address = "Huế", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446") },
                new PersonDTO { Id = 6, FullName = "Vũ Thị Phương", Email = "phuong.vu@example.com", Phone = "0901000006", Gender = "Female", BirthDate = DateTime.Parse("1988-06-12T00:00:00.0000000"), Address = "Nha Trang", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446") },
                new PersonDTO { Id = 7, FullName = "Đặng Văn Giang", Email = "giang.dang@example.com", Phone = "0901000007", Gender = "Male", BirthDate = DateTime.Parse("1985-07-30T00:00:00.0000000"), Address = "Hải Phòng", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446") },
                new PersonDTO { Id = 8, FullName = "Ngô Thị Hạnh", Email = "hanh.ngo@example.com", Phone = "0901000008", Gender = "Female", BirthDate = DateTime.Parse("1986-08-18T00:00:00.0000000"), Address = "Vũng Tàu", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446") },
                new PersonDTO { Id = 9, FullName = "Bùi Văn Inh", Email = "inh.bui@example.com", Phone = "0901000009", Gender = "Male", BirthDate = DateTime.Parse("1982-09-22T00:00:00.0000000"), Address = "Biên Hòa", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446") },
                new PersonDTO { Id = 10, FullName = "Lý Thị Kiều", Email = "kieu.ly@example.com", Phone = "0901000010", Gender = "Female", BirthDate = DateTime.Parse("1989-10-14T00:00:00.0000000"), Address = "Quy Nhơn", CreatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446"), UpdatedAt = DateTime.Parse("2026-01-22T09:38:36.5787446") }
            );

            // =====================
            // Question (first 10 from data)
            // =====================
            modelBuilder.Entity<QuestionDTO>().HasData(
                new QuestionDTO { Id = 6, Type = "MultipleChoice", Content = "Câu hỏi trắc nghiệm 6", Score = 1.00m, ExamId = 2 },
                new QuestionDTO { Id = 7, Type = "MultipleChoice", Content = "Câu hỏi trắc nghiệm 7", Score = 1.00m, ExamId = 2 },
                new QuestionDTO { Id = 8, Type = "Essay", Content = "Câu hỏi tự luận 8", Score = 4.00m, ExamId = 2 },
                new QuestionDTO { Id = 9, Type = "MultipleChoice", Content = "Câu hỏi trắc nghiệm 9", Score = 1.00m, ExamId = 2 },
                new QuestionDTO { Id = 10, Type = "Essay", Content = "Câu hỏi tự luận 10", Score = 5.00m, ExamId = 2 },
                new QuestionDTO { Id = 11, Type = "MultipleChoice", Content = "Câu hỏi trắc nghiệm 11", Score = 1.00m, ExamId = 3 },
                new QuestionDTO { Id = 12, Type = "MultipleChoice", Content = "Câu hỏi trắc nghiệm 12", Score = 1.00m, ExamId = 3 },
                new QuestionDTO { Id = 13, Type = "Essay", Content = "Câu hỏi tự luận 13", Score = 4.00m, ExamId = 3 },
                new QuestionDTO { Id = 14, Type = "MultipleChoice", Content = "Câu hỏi trắc nghiệm 14", Score = 1.00m, ExamId = 3 },
                new QuestionDTO { Id = 15, Type = "Essay", Content = "Câu hỏi tự luận 15", Score = 5.00m, ExamId = 3 }
            );

            // =====================
            // QuestionOption (first 10)
            // =====================
            modelBuilder.Entity<QuestionOptionDTO>().HasData(
                new QuestionOptionDTO { Id = 21, Content = "Lựa chọn A", IsCorrect = false, SortOrder = 1, QuestionId = 6 },
                new QuestionOptionDTO { Id = 22, Content = "Lựa chọn B (đúng)", IsCorrect = true, SortOrder = 2, QuestionId = 6 },
                new QuestionOptionDTO { Id = 23, Content = "Lựa chọn C", IsCorrect = false, SortOrder = 3, QuestionId = 6 },
                new QuestionOptionDTO { Id = 24, Content = "Lựa chọn D", IsCorrect = false, SortOrder = 4, QuestionId = 6 },
                new QuestionOptionDTO { Id = 25, Content = "Lựa chọn A", IsCorrect = false, SortOrder = 1, QuestionId = 7 },
                new QuestionOptionDTO { Id = 26, Content = "Lựa chọn B (đúng)", IsCorrect = true, SortOrder = 2, QuestionId = 7 },
                new QuestionOptionDTO { Id = 27, Content = "Lựa chọn C", IsCorrect = false, SortOrder = 3, QuestionId = 7 },
                new QuestionOptionDTO { Id = 28, Content = "Lựa chọn D", IsCorrect = false, SortOrder = 4, QuestionId = 7 },
                new QuestionOptionDTO { Id = 29, Content = "Lựa chọn A", IsCorrect = false, SortOrder = 1, QuestionId = 8 },
                new QuestionOptionDTO { Id = 30, Content = "Lựa chọn B (đúng)", IsCorrect = true, SortOrder = 2, QuestionId = 8 }
            );

            // (You can continue adding HasData for other tables similarly if needed.)
        }
    }
}
