using Microsoft.EntityFrameworkCore;
using questionnaire.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tele_consult.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Questions>().HasData(
                new { Id = 1, Question = "Title", DateAdd = DateTime.Now },
                new { Id = 2, Question = "First Name", DateAdd = DateTime.Now },
                new { Id = 3, Question = "Last Name", DateAdd = DateTime.Now },
                new { Id = 4, Question = "Date of birth", DateAdd = DateTime.Now },
                new { Id = 5, Question = "Country of residence", DateAdd = DateTime.Now },
                new { Id = 6, Question = "House Address", DateAdd = DateTime.Now },
                new { Id = 7, Question = "Work Address", DateAdd = DateTime.Now },
                new { Id = 8, Question = "Occupation", DateAdd = DateTime.Now },
                new { Id = 9, Question = "Job Title", DateAdd = DateTime.Now },
                new { Id = 10, Question = "Business Type", DateAdd = DateTime.Now });

            modelBuilder.Entity<Choices>().HasData(
                new { Id = 1, Choice = "Mr.", QuestionId = 1 },
                new { Id = 2, Choice = "Ms.", QuestionId = 1 },
                new { Id = 3, Choice = "Mrs.", QuestionId = 1 },
                new { Id = 4, Choice = "Thailand", QuestionId = 5 },
                new { Id = 5, Choice = "America", QuestionId = 5 },
                new { Id = 6, Choice = "Japan", QuestionId = 5 },
                new { Id = 7, Choice = "Programmer", QuestionId = 8 },
                new { Id = 8, Choice = "Marketting", QuestionId = 8 },
                new { Id = 9, Choice = "Software Engineer", QuestionId = 9 },
                new { Id = 10, Choice = "Sales Manager", QuestionId = 9 },
                new { Id = 11, Choice = "SoftwareHourse", QuestionId = 10 },
                new { Id = 12, Choice = "Market", QuestionId = 10 });
        }

        public DbSet<Answers> answers { get; set; }
        public DbSet<Choices> choices { get; set; }
        public DbSet<Questions> questions { get; set; }
        public DbSet<Users> users { get; set; }
    }
}
