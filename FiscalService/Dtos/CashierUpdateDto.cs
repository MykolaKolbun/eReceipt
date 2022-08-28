using System.ComponentModel.DataAnnotations;
using FiscalService.Models;

namespace FiscalService.Dtos
{
    public class CashierUpdateDto
    {
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        public string? TIN { get; set; }

        public int CertificateId { get; set; }
        public Certificate Certificate { get; set; }
        
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}