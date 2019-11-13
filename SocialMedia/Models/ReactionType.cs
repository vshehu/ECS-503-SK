using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class ReactionType
    {
        public int Id { get; set; }
        [MaxLength(20)]
        
        public string TypeName { get; set; }
        
        public string IconURL { get; set; }
        public List<Reaction> Reaction { get; set; }
    }
}
