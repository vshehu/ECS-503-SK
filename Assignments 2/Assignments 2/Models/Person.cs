using Assignment2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
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
        [MaxLength(20)]
        public string Address { get; set; }
        [MaxLength(50)]
        public int PhoneNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }


        public List<Friendwith> FrirstPersonn { get; set; }

        //public List<Friendwith> SecondPerson { get; set; }
        public List<Comments> Comments { get; set; }
        public List<Post> Posts { get; set; }
        //public List<Messages> Messages { get; set; }
      

    }
}
