using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication.Models
{
    public class FriendWith
    {
        public int Id { get; set; }
        public int FirstPerson { get; set; }
        public int SecondPerson { get; set; }
        public DateTime Friendaversary { get; set; }

        public List<Messages> Messages { get; set; }
    }
}