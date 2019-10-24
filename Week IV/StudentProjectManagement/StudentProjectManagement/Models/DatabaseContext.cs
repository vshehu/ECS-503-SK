using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProjectManagement.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Proposal> Proposals { get; set; }
        public DbSet<GradingCriteria> GradingCriterias { get; set; }
        public DbSet<Grading> Gradings { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //Change this to comply with your database configuration
            options.UseSqlServer("Server=DESKTOP-56N3OSK;Database=StudentProject;Trusted_Connection=True;");
        }
    }
}
