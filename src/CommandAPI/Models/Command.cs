using System.ComponentModel.DataAnnotations;

namespace CommandAPI.Models
{
    public class Command
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public required string HowTo { get; set; }

        [Required]
        public required string Platform { get; set; }

        [Required]
        public required string CommandLine { get; set; }
    }
}