using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class RelationshipStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public Person Person { get; set; }
    }
}
