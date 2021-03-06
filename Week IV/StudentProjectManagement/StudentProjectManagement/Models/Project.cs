﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProjectManagement.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Student> Students { get; set; }
        public List<Proposal> Proposals { get; set; }
        public List<Grading> Gradings { get; set; }
    }
}
