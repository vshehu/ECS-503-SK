using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Post
    {
        public int id { get; set; }
        [Required]
        public String PostContent { get; set; }
        [Required]
        public DateTime PostedDate { get; set; }

        public List<Comments> Comments { get; set; }
        public List<Reaction> Reactions { get; set; }
        public List<PostImages> PostImages { get; set; }

        public Person PersonId { get; set; }
        public Notification NotificationId { get; set; }

    }
}
