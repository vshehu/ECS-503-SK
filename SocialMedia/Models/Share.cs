using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class Share
    {
        public int ID { get; set; }
        [Required]
        public String ShareType { get; set; }
        public DateTime DateShared { get; set; }
        public List<Post> PostID { get; set; }
        public Person PersonID {get;set;}
    }
}
