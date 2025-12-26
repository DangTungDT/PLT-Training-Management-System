using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DAL.databaseContext
{
    public static class ModelBuilderNavigation
    {

        public static void RelationshipEntities(this ModelBuilder modelBuilder)
        {
            // Cấu hình Decimal (Fix cảnh báo màu vàng)
            modelBuilder.Entity<QuestionDTO>().Property(p => p.Score).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<ResearchTopicDTO>().Property(p => p.TopicCost).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<StudentScoreDTO>().Property(p => p.ScoreValue).HasColumnType("decimal(18,2)");
                
            // School
            modelBuilder.Entity<SchoolDTO>()
                .ToTable("School")
                .HasKey(x => x.Id);

            //CourseClassDTO
            modelBuilder.Entity<CourseClassDTO>()
        .HasKey(cc => new { cc.CourseId, cc.ClassId });

            // Semester
            modelBuilder.Entity<SemesterDTO>()
                .ToTable("Semester")
                .HasKey(x => x.Id);

            modelBuilder.Entity<SemesterDTO>()
                .HasOne(x => x.School)
                .WithMany()
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            // Teacher_School (composite key)
            modelBuilder.Entity<TeacherSchoolDTO>()
                .ToTable("Teacher_School")
                .HasKey(x => new { x.SchoolId, x.TeacherId });

            modelBuilder.Entity<TeacherSchoolDTO>()
                .HasOne(x => x.School)
                .WithMany()
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TeacherSchoolDTO>()
                .HasOne(x => x.Teacher)
                .WithMany()
                .HasForeignKey(x => x.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            // Teacher_Class (composite key)
            modelBuilder.Entity<TeacherClassDTO>()
                .ToTable("Teacher_Class")
                .HasKey(x => new { x.ClassId, x.TeacherId });

            modelBuilder.Entity<TeacherClassDTO>()
                .HasOne(x => x.Class)
                .WithMany()
                .HasForeignKey(x => x.ClassId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TeacherClassDTO>()
                .HasOne(x => x.Teacher)
                .WithMany()
                .HasForeignKey(x => x.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            // Exam_File (composite key)
            modelBuilder.Entity<ExamFileDTO>()
                .ToTable("Exam_File")
                .HasKey(x => new { x.ExamId, x.FileId });

            modelBuilder.Entity<ExamFileDTO>()
                .HasOne(x => x.Exam)
                .WithMany()
                .HasForeignKey(x => x.ExamId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ExamFileDTO>()
                .HasOne(x => x.File)
                .WithMany()
                .HasForeignKey(x => x.FileId)
                .OnDelete(DeleteBehavior.Restrict);

            // Account
            modelBuilder.Entity<AccountDTO>()
                .ToTable("Account")
                .HasKey(x => x.Id);

            modelBuilder.Entity<AccountDTO>()
                .HasOne(x => x.Person)
                .WithMany()
                .HasForeignKey(x => x.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            // Faculty
            modelBuilder.Entity<FacultyDTO>()
                .ToTable("Faculty")
                .HasKey(x => x.Id);
            modelBuilder.Entity<FacultyDTO>()
                .HasIndex(x => x.Name)
                .IsUnique();
            modelBuilder.Entity<FacultyDTO>()
                .HasOne(x => x.School)
                .WithMany()
                .HasForeignKey(x => x.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            // Person
            modelBuilder.Entity<PersonDTO>()
                .ToTable("Person")
                .HasKey(x => x.Id);
            modelBuilder.Entity<PersonDTO>()
                .HasIndex(x => x.Email)
                .IsUnique();

            // Student
            modelBuilder.Entity<StudentDTO>()
                .ToTable("Student")
                .HasKey(x => x.Id);
            modelBuilder.Entity<StudentDTO>()
                .HasIndex(x => x.PersonId)
                .IsUnique();
            modelBuilder.Entity<StudentDTO>()
                .HasOne(x => x.Person)
                .WithMany()
                .HasForeignKey(x => x.PersonId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<StudentDTO>()
                .HasOne(x => x.Class)
                .WithMany()
                .HasForeignKey(x => x.ClassId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<StudentDTO>()
                .HasOne(x => x.Faculty)
                .WithMany()
                .HasForeignKey(x => x.FacultyId)
                .OnDelete(DeleteBehavior.Restrict);

            // Room
            modelBuilder.Entity<RoomDTO>()
                .ToTable("Room")
                .HasKey(x => x.Id);
            modelBuilder.Entity<RoomDTO>()
                .HasIndex(x => x.Name)
                .IsUnique();

            // Class
            modelBuilder.Entity<ClassDTO>()
                .ToTable("Class")
                .HasKey(x => x.Id);
            modelBuilder.Entity<ClassDTO>()
                .HasIndex(x => x.Name)
                .IsUnique();
            modelBuilder.Entity<ClassDTO>()
                .HasOne(c => c.Faculty)
                .WithMany()
                .HasForeignKey(c => c.FacultyId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<ClassDTO>()
                .HasOne(c => c.Teacher)
                .WithMany()
                .HasForeignKey(c => c.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            // Teacher
            modelBuilder.Entity<TeacherDTO>()
                .ToTable("Teacher")
                .HasKey(x => x.Id);
            modelBuilder.Entity<TeacherDTO>()
                .HasIndex(x => x.PersonId)
                .IsUnique();
            modelBuilder.Entity<TeacherDTO>()
                .HasOne(x => x.Faculty)
                .WithMany()
                .HasForeignKey(x => x.FacultyId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TeacherDTO>()
                .HasOne(x => x.Person)
                .WithMany()
                .HasForeignKey(x => x.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            // TeachingSchedule
            modelBuilder.Entity<TeachingScheduleDTO>()
                .ToTable("TeachingSchedule")
                .HasKey(x => x.Id);

            modelBuilder.Entity<TeachingScheduleDTO>()
                .HasOne(x => x.Teacher)
                .WithMany()
                .HasForeignKey(x => x.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TeachingScheduleDTO>()
                .HasOne(x => x.Course)
                .WithMany()
                .HasForeignKey(x => x.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TeachingScheduleDTO>()
                .HasOne(x => x.Class)
                .WithMany()
                .HasForeignKey(x => x.ClassId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TeachingScheduleDTO>()
                .HasOne(x => x.Room)
                .WithMany()
                .HasForeignKey(x => x.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

            // Exam
            modelBuilder.Entity<ExamDTO>()
                .ToTable("Exam")
                .HasKey(x => x.Id);

            modelBuilder.Entity<ExamDTO>()
                .HasOne(x => x.Course)
                .WithMany()
                .HasForeignKey(x => x.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ExamDTO>()
                .HasOne(x => x.Semester)
                .WithMany()
                .HasForeignKey(x => x.SemesterId)
                .OnDelete(DeleteBehavior.Restrict);

            // Question
            modelBuilder.Entity<QuestionDTO>()
                .ToTable("Question")
                .HasKey(x => x.Id);

            modelBuilder.Entity<QuestionDTO>()
                .HasOne(x => x.Exam)
                .WithMany()
                .HasForeignKey(x => x.ExamId)
                .OnDelete(DeleteBehavior.Restrict);

            // QuestionOption
            modelBuilder.Entity<QuestionOptionDTO>()
                .ToTable("QuestionOption")
                .HasKey(x => x.Id);

            modelBuilder.Entity<QuestionOptionDTO>()
                .HasOne(x => x.Question)
                .WithMany()
                .HasForeignKey(x => x.QuestionId)
                .OnDelete(DeleteBehavior.Restrict);

            // Assignment
            modelBuilder.Entity<AssignmentDTO>()
                .ToTable("Assignment")
                .HasKey(x => x.Id);

            modelBuilder.Entity<AssignmentDTO>()
                .HasOne(x => x.Course)
                .WithMany()
                .HasForeignKey(x => x.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            // Submission
            modelBuilder.Entity<SubmissionDTO>()
                .ToTable("Submission")
                .HasKey(x => x.Id);

            modelBuilder.Entity<SubmissionDTO>()
                .HasOne(x => x.Assignment)
                .WithMany()
                .HasForeignKey(x => x.AssignmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SubmissionDTO>()
                .HasOne(x => x.Student)
                .WithMany()
                .HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Submission_File (composite key)
            modelBuilder.Entity<SubmissionFileDTO>()
                .ToTable("Submission_File")
                .HasKey(x => new { x.SubmissionId, x.FileId });

            modelBuilder.Entity<SubmissionFileDTO>()
                .HasOne(x => x.Submission)
                .WithMany()
                .HasForeignKey(x => x.SubmissionId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SubmissionFileDTO>()
                .HasOne(x => x.File)
                .WithMany()
                .HasForeignKey(x => x.FileId)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentScore
            modelBuilder.Entity<StudentScoreDTO>()
                .ToTable("StudentScore")
                .HasKey(x => x.Id);

            modelBuilder.Entity<StudentScoreDTO>()
                .HasOne(x => x.Student)
                .WithMany()
                .HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StudentScoreDTO>()
                .HasOne(x => x.Course)
                .WithMany()
                .HasForeignKey(x => x.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            // ResearchTopic
            modelBuilder.Entity<ResearchTopicDTO>()
                .ToTable("ResearchTopic")
                .HasKey(x => x.Id);
            modelBuilder.Entity<ResearchTopicDTO>()
                .HasOne(rt => rt.Faculty)
                .WithMany()
                .HasForeignKey(rt => rt.FacultyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ResearchTopicDTO>()
                .HasOne(rt => rt.Teacher)
                .WithMany()
                .HasForeignKey(rt => rt.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            // ResearchTopic_File (composite key)
            modelBuilder.Entity<ResearchTopicFileDTO>()
                .ToTable("ResearchTopic_File")
                .HasKey(x => new { x.ResearchTopicId, x.FileId });

            modelBuilder.Entity<ResearchTopicFileDTO>()
                .HasOne(x => x.ResearchTopic)
                .WithMany()
                .HasForeignKey(x => x.ResearchTopicId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ResearchTopicFileDTO>()
                .HasOne(x => x.File)
                .WithMany()
                .HasForeignKey(x => x.FileId)
                .OnDelete(DeleteBehavior.Restrict);

            // TopicObjective
            modelBuilder.Entity<TopicObjectiveDTO>()
                .ToTable("TopicObjective")
                .HasKey(x => x.Id);

            modelBuilder.Entity<TopicObjectiveDTO>()
                .HasOne(x => x.ResearchTopic)
                .WithMany()
                .HasForeignKey(x => x.TopicId)
                .OnDelete(DeleteBehavior.Restrict);

            // TopicProgress
            modelBuilder.Entity<TopicProgressDTO>()
                .ToTable("TopicProgress")
                .HasKey(x => x.Id);

            modelBuilder.Entity<TopicProgressDTO>()
                .HasOne(x => x.ResearchTopic)
                .WithMany()
                .HasForeignKey(x => x.TopicId)
                .OnDelete(DeleteBehavior.Restrict);

            // Category
            modelBuilder.Entity<CategoryDTO>()
                .ToTable("Category")
                .HasKey(x => x.Id);
            modelBuilder.Entity<CategoryDTO>()
                .HasIndex(x => x.Name)
                .IsUnique();

            // Book
            modelBuilder.Entity<BookDTO>()
                .ToTable("Book")
                .HasKey(x => x.Id);

            modelBuilder.Entity<BookDTO>()
                .HasIndex(x => x.ISBN)
                .IsUnique();

            modelBuilder.Entity<BookDTO>()
                .HasIndex(x => x.Name)
                .IsUnique();

            modelBuilder.Entity<BookDTO>()
                .HasOne(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Book_File (composite key)
            modelBuilder.Entity<BookFileDTO>()
                .ToTable("Book_File")
                .HasKey(x => new { x.BookId, x.FileId });

            modelBuilder.Entity<BookFileDTO>()
                .HasOne(x => x.Book)
                .WithMany()
                .HasForeignKey(x => x.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BookFileDTO>()
                .HasOne(x => x.File)
                .WithMany()
                .HasForeignKey(x => x.FileId)
                .OnDelete(DeleteBehavior.Restrict);

            // Files
            modelBuilder.Entity<FilesDTO>()
                .ToTable("Files")
                .HasKey(x => x.Id);

            // Course
            modelBuilder.Entity<CourseDTO>()
                .ToTable("Course")
                .HasKey(x => x.Id);
            modelBuilder.Entity<CourseDTO>()
                .HasIndex(x => x.FullName)
                .IsUnique();
            modelBuilder.Entity<CourseDTO>()
                .HasIndex(x => x.ShortName)
                .IsUnique();

            modelBuilder.Entity<CourseDTO>()
                .HasOne(x => x.Category)
                .WithMany()
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CourseDTO>()
                .HasOne(x => x.Semester)
                .WithMany()
                .HasForeignKey(x => x.SemesterId)
                .OnDelete(DeleteBehavior.Restrict);

            // LessonPlan
            modelBuilder.Entity<LessonPlanDTO>()
                .ToTable("LessonPlan")
                .HasKey(x => x.Id);

            modelBuilder.Entity<LessonPlanDTO>()
                .HasOne(x => x.Course)
                .WithMany()
                .HasForeignKey(x => x.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LessonPlanDTO>()
                .HasOne(x => x.Class)
                .WithMany()
                .HasForeignKey(x => x.StudentClassId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LessonPlanDTO>()
                .HasOne(x => x.Room)
                .WithMany()
                .HasForeignKey(x => x.RoomId)
                .OnDelete(DeleteBehavior.Restrict);

            // LessonActivity
            modelBuilder.Entity<LessonActivityDTO>()
                .ToTable("LessonActivity")
                .HasKey(x => x.Id);

            modelBuilder.Entity<LessonActivityDTO>()
                .HasOne(x => x.LessonPlan)
                .WithMany()
                .HasForeignKey(x => x.LessonPlanId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CourseClassDTO>()
        .HasOne(cc => cc.Course)
        .WithMany(c => c.CourseClasses)
        .HasForeignKey(cc => cc.CourseId);

            modelBuilder.Entity<CourseClassDTO>()
                .HasOne(cc => cc.Class)
                .WithMany(c => c.CourseClasses)
                .HasForeignKey(cc => cc.ClassId);
        }
    }
}
