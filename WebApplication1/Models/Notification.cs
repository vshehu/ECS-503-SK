using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }

        public Person PersonID { get; set; }
        public List<Post> Post { get; set; }
        public List<Reaction> Reactions { get; set; }


    }
}
