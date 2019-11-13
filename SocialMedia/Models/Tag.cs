using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class Tag
    {
        public int ID { get; set; }
        [Required]
       
        public DateTime DateTaged { get; set; }
        public List<Post>  PostID { get; set; }

    }
}
