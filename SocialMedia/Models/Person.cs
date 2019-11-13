using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    
        public class Person
        {
            public int Id { get; set; }
            [Required]
            [MaxLength(20)]
            public string Name { get; set; }
            [Required]
            [MaxLength(20)]
            public string LastName { get; set; }
            [Required]
            [MaxLength(50)]
            public string Email { get; set; }

            [MaxLength(20)]
            public string Address { get; set; }
            [MaxLength(50)]
            public int PhoneNumber { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        public List<Comments> comments { get; set; }
        [Required]
        public List<Post> PostiD { get; set; }

        [Required]
        public List<FriendWith> FriendWith1 { get; set; }
        [Required]
        public List<Share> ShareID { get; set; }
        // public List<FriendWith> FriendWith2 { get; set; }





    }
}
