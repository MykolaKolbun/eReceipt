using System.ComponentModel.DataAnnotations;

namespace FiscalService.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? TIN { get; set; }
        public string? EMailAddress { get; set; }
        public string? PhoneNumber { get; set; }
    }
}