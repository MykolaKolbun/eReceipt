using System.ComponentModel.DataAnnotations;

namespace FiscalService.Models
{
    public class Machine
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string Location { get; set; }

        [Required]
        public int CustomerId { get; set; }
        
        [Required]
        public int Type { get; set; }
    }
}