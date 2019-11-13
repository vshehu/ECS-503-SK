using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentCourseCodeFirstSK.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Semester { get; set; }
        public int Credits { get; set; }
    }
}
