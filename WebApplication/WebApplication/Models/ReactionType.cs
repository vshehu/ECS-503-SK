using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
    public class ReactionType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string IconURL { get; set; }

        public Reaction Reaction { get; set; }
    }
}