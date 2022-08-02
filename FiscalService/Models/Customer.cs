namespace FiscalService.Models
{
    class Customer
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int CertificateId { get; set; }

        public string? Address { get; set; }

        public string? INN { get; set; } 
    }
}