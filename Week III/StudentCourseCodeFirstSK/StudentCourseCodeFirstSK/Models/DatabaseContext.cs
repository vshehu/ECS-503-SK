using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentCourseCodeFirstSK.Models
{
    public class DatabaseContext : DbContext 
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-56N3OSK;Database=WeekIII-v.shehu;Trusted_Connection=True;");
        }
    }
}
