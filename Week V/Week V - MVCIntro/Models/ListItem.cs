using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week_V___MVCIntro.Models
{
    public class ListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDone { get; set; }
        public int Priority { get; set; }

        public TodoList List { get; set; }
    }
}
