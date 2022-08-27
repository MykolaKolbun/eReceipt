using System.ComponentModel.DataAnnotations;
using FiscalService.Model;
namespace FiscalService.Dtos
{
    public class PaymentTypeCreateDto
    {
        [Required]
        public string? Description { get; set; } 
    }
}