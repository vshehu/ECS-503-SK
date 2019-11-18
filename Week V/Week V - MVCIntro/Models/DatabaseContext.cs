using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week_V___MVCIntro.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<ListItem> ListItems { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-56N3OSK;Database=ToDo;Trusted_Connection=True;");
        }
    }
}
