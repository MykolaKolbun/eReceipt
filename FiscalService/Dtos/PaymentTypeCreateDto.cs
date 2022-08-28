using System.ComponentModel.DataAnnotations;
using FiscalService.Models;
namespace FiscalService.Dtos
{
    public class PaymentTypeCreateDto
    {
        [Required]
        public string? Description { get; set; } 
    }
}