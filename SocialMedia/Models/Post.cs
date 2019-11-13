using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        public String PostContent { get; set; }
        [Required]
        public DateTime PostedDate { get; set; }
        [Required]
        public List<Comments> Comments { get; set; }
        [Required]
        public List<Reaction> Reaction { get; set; }
        [Required]
        public List<PostImage> PostImages { get; set; }
        [Required]
        public Person PersonnID { get; set; }
        [Required]
        public Share ShareID { get; set; }
        public Tag TagID { get; set; }
        public List<ArchivedPost> ArId{ get; set; }


    }
}
