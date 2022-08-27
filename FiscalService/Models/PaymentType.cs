using System.ComponentModel.DataAnnotations;

namespace FiscalService.Model
{
    public class PaymentType
    {
        public int Id { get; set; } 
        [Required]
        public string? Description { get; set; } 
    }
}