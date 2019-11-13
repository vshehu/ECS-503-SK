using Assignment2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public String PostContent { get; set; }
        [Required]
        public DateTime PostedDate { get; set; }

        public List<Comments> Comments { get; set; }
        public List<PostImages> PostImages { get; set; }
        public List<PostVideo> PostVideo { get; set; }

    
    }
}
