using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DeletedMessage
    {
        public int Id { get; set; }
        public DateTime Datatime { get; set; }

        public Chat ChatId { get; set; }
    }
}
