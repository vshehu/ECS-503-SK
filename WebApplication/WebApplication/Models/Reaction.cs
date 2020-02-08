using System;

namespace WebApplication.Models
{
    public class Reaction
    {
        public int Id { get; set; }
        public Comments Comments { get; set; }
        public DateTime ReactionDate { get; set; }

        public PostImages PostImages { get; set; }
        public Post Post { get; set; }
    }
}