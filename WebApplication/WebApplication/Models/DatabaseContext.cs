using Microsoft.EntityFrameworkCore;
using System.Data;

namespace WebApplication.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<FriendWith> FriendWith { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<PostImages> PostImages { get; set; }
        public DbSet<Reaction> Reaction { get; set; }
        public DbSet<ReactionType> ReactionType { get; set; }

        public DbSet<Messages> Messages { get; set; }
        public DbSet<RelationshipStatus> RelationshipStatus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //Change this to comply with your database configuration
            options.UseSqlServer("Server=DESKTOP-H2D0O57;Database=ah27378;Trusted_Connection=True;");
        }

        public DatabaseContext()
        {

        }
    }
}