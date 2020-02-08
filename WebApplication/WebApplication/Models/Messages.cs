using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class Messages
    {
        public int Id { get; set; }
        public Person People { get; set; }
        public FriendWith FriendWiths { get; set; }
        public string Message { get; set; }
        public DateTime SentTime { get; set; } = DateTime.Now;
    }
}
