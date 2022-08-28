using FiscalService.Models;
namespace FiscalService.Dtos
{
    public class PaymentTypeReadDto
    {
        public int Id { get; set; } 
        public string? Description { get; set; } 
    }
}