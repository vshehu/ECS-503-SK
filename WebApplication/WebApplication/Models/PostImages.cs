using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication.Models
{
    public class PostImages
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public bool IsPrimary { get; set; }

        public Post Post { get; set; }
        public List<Reaction> Reactions { get; set; }
    }
}