using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class Messages
    {
        public int Id { get; set; }

        public Person FirstPerson { get; set; }
        [Required]
        public Person SecondPerson { get; set; }
      
        [Required]
        public DateTime DateTime_of_Msg { get; set; }

        public string Msg_text { get; set; }
    }
}
