using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class PostImage
    {
        public int Id { get; set; }
        //public string PostContent { get; set; }
        [Required]
        public string filename { get; set; }
        [Required]
        public Boolean isPrimary { get; set; }
        [Required]
        public List<Reaction> Reaction { get; set; }
        [Required]
        public Post PostID { get; set; }
    }
}
