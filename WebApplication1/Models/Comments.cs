using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Comments
    {
        public int id { get; set; }
    
        [Required]
        public DateTime DatePosted { get; set; }
       


        public List<Comments> ParentCommentidd { get; set; }
        public List<Reaction> Reactions { get; set; }
        [Required]
        public Post  Postid { get; set; }
        [Required]
        public Person Postetbyperson { get; set; }

        public Comments Commentsparentid  { get; set; }
    }
}
