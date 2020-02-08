using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string PostContent { get; set; }
        public DateTime PostDate { get; set; }

        public Person Person { get; set; }
        public List<PostImages> PostImages { get; set; }
        public List<Comments> Comments { get; set; }
    }
}