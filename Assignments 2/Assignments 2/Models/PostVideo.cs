using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Models;

namespace Assignment2.Models
{
    public class PostVideo
    {
        public int Id { get; set; }

        [Required]
        public string FileName { get; set; }
        [Required]
        public bool isPrimary { get; set; }
        [Required]
        public List<Reaction> Reaction { get; set; }
    }
}
