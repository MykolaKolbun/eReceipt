using System.ComponentModel.DataAnnotations;
using FiscalService.Models;
namespace FiscalService.Dtos
{
    public class PaymentTypeUpdateDto
    {
        [Required]
        public string? Description { get; set; } 
    }
}