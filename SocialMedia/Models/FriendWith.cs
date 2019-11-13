using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class FriendWith
    {
        public int Id { get; set;}
        //public int FirstPerson { get; set; }
        //public int SecondPerson { get; set; }
        [Required]
        public DateTime Friendaversary { get; set; }
        [Required]
        public Person person1 { get; set; }
       // public Person person2 { get; set; }
    }
}
