using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class ArchivedPost
    {
        public int Id { get; set; }
        public DateTime ArchivedDate { get; set; }
        public Post PostId { get; set; }
    }
}
