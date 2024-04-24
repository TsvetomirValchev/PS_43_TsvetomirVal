using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Welcome.Others;

namespace DataLayer.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite("Data Source={databasePath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatabaseUser>().Property(e => e.ID).ValueGeneratedOnAdd();
            modelBuilder.Entity<LogEntry>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.ID).ValueGeneratedOnAdd();
                entity.Property(e => e.Timestamp).IsRequired();
                entity.Property(e => e.Message).IsRequired();
            });
            var user = new DatabaseUser()
            {
                ID = 1,
                Name = "user1",
                Password = "11111111111secure",
                Role = UserRolesEnums.ADMIN,
                Expires = DateTime.Now.AddYears(50),
                Email = "user@example.com",
                FacultyNumber = "381"
            };
            var user2 = new DatabaseUser()
            {
                ID = 2,
                Name = "user4",
                Password = "supersecret",
                Role = UserRolesEnums.STUDENT,
                Expires = DateTime.Now.AddYears(10),
                Email = "demo@example.com",
                FacultyNumber = "183"
            };
            var user3 = new DatabaseUser()
            {
                ID = 3,
                Name = "user3",
                Password = "supersecure",
                Role = UserRolesEnums.PROFESSOR,
                Expires = DateTime.Now.AddYears(20),
                Email = "kircho@example.com",
                FacultyNumber = "831"
            };

            modelBuilder.Entity<DatabaseUser>()
                .HasData(user, user2, user3);
        }
        public DbSet<DatabaseUser>? Users { get; set; }
        public DbSet<LogEntry>? LogEntries { get; set; }
    }
}
