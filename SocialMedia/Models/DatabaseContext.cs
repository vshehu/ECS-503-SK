using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Reaction> Reaction{ get; set; }
        public DbSet<ReactionType> ReactionTypes { get; set; }
        public DbSet<FriendWith> FriendWiths { get; set; }
        public DbSet<PostImage> PostImages { get; set; }
        public DbSet<Post>Post { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Share> Share{ get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=DESKTOP-ONL0KNF\ELIRA;Database = SocialMedia;Trusted_Connection = True;");
        }


    }
}
