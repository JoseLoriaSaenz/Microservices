using System.ComponentModel.DataAnnotations;

namespace CommandsServices.Models
{
    public class Command
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public required string HowTo { get; set; }

        [Required]
        public required string CommandLine { get; set; }

        [Required]
        public int PlatformId { get; set; }

        public Platform? Platform { get; set; }
    }
}