using Systems.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string HowTo { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string Line { get; set; }
        
        [Required]
        public string Platform { get; set; }
    }
}