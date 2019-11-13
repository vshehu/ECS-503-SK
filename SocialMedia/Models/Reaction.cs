using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class Reaction
    {
        public int Id { get; set; }


        public DateTime ReactionDate { get; set; }
       

        public PostImage postimage{ get; set; }
        public Post postid { get; set; }
        public Comments commentid { get; set; }
        public ReactionType reactiontype { get; set; }
    }
}
