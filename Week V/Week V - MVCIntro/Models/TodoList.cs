using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Week_V___MVCIntro.Models
{
    public class TodoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }

        public List<ListItem> Items { get; set; }
    }
}
