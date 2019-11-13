using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class Comments
    {
        public int Id { get; set; }
        // public int ParentCommentId { get; set; }
        [Required]
        public DateTime DatePosted { get; set; }
        [Required]
        public List<Reaction>Reaction { get; set; }

        public List<Comments> ParentComment { get; set; }
        [Required]
        public Person person { get; set; }
        [Required]
        public Post post { get; set; }
        public Comments comment{ get; set; }
    }
}
