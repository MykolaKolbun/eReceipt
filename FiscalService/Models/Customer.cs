using System.ComponentModel.DataAnnotations;

namespace FiscalService.Models
{
    public class Customer
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public int CertificateId { get; set; }

        public string? Address { get; set; }

        public string? INN { get; set; } 
    }
}