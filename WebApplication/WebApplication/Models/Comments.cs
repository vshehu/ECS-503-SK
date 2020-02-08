using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public int ParentCommentId { get; set; }
        public DateTime DatePosted { get; set; }

        public Person Person { get; set; }
        public Post Post { get; set; }
        public List<Comments> Commentses { get; set; }
    }
}