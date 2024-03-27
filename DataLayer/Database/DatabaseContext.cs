using System;
using DataLayer.Model;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Welcome.Others;
using static Welcome.Others.UserRolesEnums;

namespace DataLayer.Database
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome. db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatabaseUser>().Property(e => e.ID).ValueGeneratedOnAdd();
            // Create a user
            var user = new DatabaseUser()
            {
                ID = 1,
                Name = "John Doe",
                Password = "1234",
                Role = ADMIN,
                Expires = DateTime.Now.AddYears(10)

            };

            modelBuilder.Entity<DatabaseUser>()
                .HasData(user);

        }

        public DbSet<DatabaseContext> Users { get; set; }

    }
}