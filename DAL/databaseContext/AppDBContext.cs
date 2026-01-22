using DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL.databaseContext
{

    public class AppDBContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        IConfigurationRoot configuration = new ConfigurationBuilder()
        //            .SetBasePath(Directory.GetCurrentDirectory())
        //            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
        //            .Build();

        //        var connectionString = configuration.GetConnectionString("Default");

        //        optionsBuilder.UseSqlServer(connectionString);
        //    }
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false)
                    .Build();

                var rawConnection = configuration.GetConnectionString("Default");

                string serverName = Environment.MachineName + "\\SQLEXPRESS";

                var connectionString = rawConnection.Replace("{SERVER_NAME}", serverName);

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RelationshipEntities();
            
        }

        public DbSet<ClassExamDTO> ClassExams { get; set; }
        public DbSet<SchoolDTO> Schools { get; set; }
        public DbSet<SemesterDTO> Semesters { get; set; }
        public DbSet<TeacherSchoolDTO> Teacher_Schools { get; set; }
        public DbSet<TeacherClassDTO> Teacher_Classes { get; set; }
        public DbSet<ExamFileDTO> Exam_Files { get; set; }
        public DbSet<AccountDTO> Accounts { get; set; }
        public DbSet<FacultyDTO> Faculties { get; set; }
        public DbSet<PersonDTO> Persons { get; set; }
        public DbSet<StudentDTO> Students { get; set; }
        public DbSet<RoomDTO> Rooms { get; set; }
        public DbSet<ClassDTO> Classes { get; set; }
        public DbSet<TeacherDTO> Teachers { get; set; }
        public DbSet<TeachingScheduleDTO> TeachingSchedules { get; set; }
        public DbSet<ExamDTO> Exams { get; set; }
        public DbSet<QuestionDTO> Questions { get; set; }
        public DbSet<QuestionOptionDTO> QuestionOptions { get; set; }
        public DbSet<AssignmentDTO> Assignments { get; set; }
        public DbSet<SubmissionDTO> Submissions { get; set; }
        public DbSet<SubmissionFileDTO> Submission_Files { get; set; }
        public DbSet<StudentScoreDTO> StudentScores { get; set; }
        public DbSet<ResearchTopicDTO> ResearchTopics { get; set; }
        public DbSet<ResearchTopicFileDTO> ResearchTopic_Files { get; set; }
        public DbSet<TopicObjectiveDTO> TopicObjectives { get; set; }
        public DbSet<TopicProgressDTO> TopicProgresses { get; set; }
        public DbSet<CategoryDTO> Categories { get; set; }
        public DbSet<BookDTO> Books { get; set; }
        public DbSet<BookFileDTO> Book_Files { get; set; }
        public DbSet<FilesDTO> Files { get; set; }
        public DbSet<CourseDTO> Courses { get; set; }
        public DbSet<LessonPlanDTO> LessonPlans { get; set; }
        public DbSet<LessonActivityDTO> LessonActivities { get; set; }
        public DbSet<LessonScheduleDTO> LessonSchedules { get; set; }
    }
}
