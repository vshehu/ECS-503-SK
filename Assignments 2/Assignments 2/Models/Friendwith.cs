using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Friendwith
    {
        public int Id { get; set; }
        //public int FirstPerson { get; set; }
        //      public int SecondPerson { get; set; }
        [Required]
        public DateTime FriendAversary { get; set; }


        //public  Person FirstPersonn { get; set; }
        [Required]
        public Person SecondPerson { get; set; }
     
    }
}
