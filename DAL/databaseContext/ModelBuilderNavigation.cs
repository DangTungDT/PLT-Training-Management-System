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
            // School
            modelBuilder.Entity<SchoolDTO>()
                .ToTable("School")
                .HasKey(x => x.Id);

            // Semester
            modelBuilder.Entity<SemesterDTO>()
                .ToTable("Semester")
                .HasKey(x => x.Id);
            modelBuilder.Entity<SemesterDTO>()
                .HasOne<SchoolDTO>()
                .WithMany()
                .HasForeignKey(x => x.SchoolId);

            // Teacher_School (composite key)
            modelBuilder.Entity<TeacherSchoolDTO>()
                .ToTable("Teacher_School")
                .HasKey(x => new { x.SchoolId, x.TeacherId });

            // Teacher_Class (composite key)
            modelBuilder.Entity<TeacherClassDTO>()
                .ToTable("Teacher_Class")
                .HasKey(x => new { x.ClassId, x.TeacherId });

            // Exam_File (composite key)
            modelBuilder.Entity<ExamFileDTO>()
                .ToTable("Exam_File")
                .HasKey(x => new { x.ExamId, x.FileId });

            // Account
            modelBuilder.Entity<AccountDTO>()
                .ToTable("Account")
                .HasKey(x => x.Id);
            modelBuilder.Entity<AccountDTO>()
                .HasOne<PersonDTO>()
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
                .HasOne<SchoolDTO>()
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
                .HasOne<PersonDTO>()
                .WithMany()
                .HasForeignKey(x => x.PersonId);
            modelBuilder.Entity<StudentDTO>()
                .HasOne<ClassDTO>()
                .WithMany()
                .HasForeignKey(x => x.ClassId);
            modelBuilder.Entity<StudentDTO>()
                .HasOne<FacultyDTO>()
                .WithMany()
                .HasForeignKey(x => x.FacultyId);

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
                .HasOne<FacultyDTO>()
                .WithMany()
                .HasForeignKey(x => x.FacultyId)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TeacherDTO>()
                .HasOne<PersonDTO>()
                .WithMany()
                .HasForeignKey(x => x.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            // TeachingSchedule
            modelBuilder.Entity<TeachingScheduleDTO>()
                .ToTable("TeachingSchedule")
                .HasKey(x => x.Id);

            // Exam
            modelBuilder.Entity<ExamDTO>()
                .ToTable("Exam")
                .HasKey(x => x.Id);

            // Question
            modelBuilder.Entity<QuestionDTO>()
                .ToTable("Question")
                .HasKey(x => x.Id);

            // QuestionOption
            modelBuilder.Entity<QuestionOptionDTO>()
                .ToTable("QuestionOption")
                .HasKey(x => x.Id);

            // Assignment
            modelBuilder.Entity<AssignmentDTO>()
                .ToTable("Assignment")
                .HasKey(x => x.Id);

            // Submission
            modelBuilder.Entity<SubmissionDTO>()
                .ToTable("Submission")
                .HasKey(x => x.Id);

            // Submission_File (composite key)
            modelBuilder.Entity<SubmissionFileDTO>()
                .ToTable("Submission_File")
                .HasKey(x => new { x.SubmissionId, x.FileId });

            // StudentScore
            modelBuilder.Entity<StudentScoreDTO>()
                .ToTable("StudentScore")
                .HasKey(x => x.Id);

            // ResearchTopic
            modelBuilder.Entity<ResearchTopicDTO>()
                .ToTable("ResearchTopic")
                .HasKey(x => x.Id);
            modelBuilder.Entity<ResearchTopicDTO>()
                .HasOne(rt => rt.Teacher)
                .WithMany()
                .HasForeignKey(rt => rt.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            // ResearchTopic_File (composite key)
            modelBuilder.Entity<ResearchTopicFileDTO>()
                .ToTable("ResearchTopic_File")
                .HasKey(x => new { x.ResearchTopicId, x.FileId });

            // TopicObjective
            modelBuilder.Entity<TopicObjectiveDTO>()
                .ToTable("TopicObjective")
                .HasKey(x => x.Id);

            // TopicProgress
            modelBuilder.Entity<TopicProgressDTO>()
                .ToTable("TopicProgress")
                .HasKey(x => x.Id);

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

            // Book_File (composite key)
            modelBuilder.Entity<BookFileDTO>()
                .ToTable("Book_File")
                .HasKey(x => new { x.BookId, x.FileId });

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

            // LessonPlan
            modelBuilder.Entity<LessonPlanDTO>()
                .ToTable("LessonPlan")
                .HasKey(x => x.Id);

            // LessonActivity
            modelBuilder.Entity<LessonActivityDTO>()
                .ToTable("LessonActivity")
                .HasKey(x => x.Id);
        }
    }
}
