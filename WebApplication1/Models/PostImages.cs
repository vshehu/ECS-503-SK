using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PostImages
    {
        public int id { get; set; }
        [Required]
        public String FileName { get; set; }
        [Required]
        public bool isPrimary  {get;set;}


        public List<Reaction> Reactions { get; set; }
        [Required]
        public Post Postid { get; set; }
    }
}
