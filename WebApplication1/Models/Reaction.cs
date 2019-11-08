using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Reaction
    {
        public int ID { get; set; }
        public DateTime ReactionDate { get; set;}

        public Comments CommentId { get; set; }
        public Post PostId { get; set; }
        public ReactionType Reactiontypee { get; set; }
        public PostImages ImageId { get; set; }
        public Notification NotioficationId { get; set; }
    }
}
