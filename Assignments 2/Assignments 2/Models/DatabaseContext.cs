using Assignment2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Comments> Comments{ get; set; }
        public DbSet<Friendwith> Friendwiths { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostImages> PostImages { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<ReactionType> ReactionTypes { get; set; }
        public DbSet<PostVideo> PostVideo { get; set; }
        public DbSet<Messages> Messages { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           
            options.UseSqlServer("Server=DESKTOP-U07TUOE;Database=social_media_test;Trusted_Connection=True;");

        }
    }
}
