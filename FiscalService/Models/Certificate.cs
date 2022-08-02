namespace FiscalService.Models
{
    public class Certificate
    {
        public int Id { get; set; }
        public string? PublicCertPath { get; set; }
        public string? PrivateCertPath { get; set; }
    }
}