using System.ComponentModel.DataAnnotations;

namespace FiscalService.Models
{
    public class PaymentType
    {
        public int Id { get; set; } 
        [Required]
        public string? Description { get; set; } 
    }
}