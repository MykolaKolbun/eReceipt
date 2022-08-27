using System.ComponentModel.DataAnnotations;
using FiscalService.Model;

namespace FiscalService.Dtos
{
    public class CashierCreateDto
    {
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string TIN { get; set; }

        public int CertificateId { get; set; }
        public Certificate Certificate { get; set; }
        
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}