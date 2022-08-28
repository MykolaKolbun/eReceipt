using System.ComponentModel.DataAnnotations;
using FiscalService.Models;
namespace FiscalService.Dtos
{
    public class CustomerUpdateDto
    {
        [Required]
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? TIN { get; set; }
        public string? EMailAddress { get; set; }
        public string? PhoneNumber { get; set; }
    }
}