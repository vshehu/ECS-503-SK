using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public string ChatHistory{get;set; }

        public bool IsOnline { get; set;}

      
        public Person PeopleID { get; set; }
        public Friendwith Friendwiths { get; set; }
        public List<DeletedMessage> deletedMessages { get; set; }
        

     }
}
