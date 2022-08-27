using FiscalService.Model;
namespace FiscalService.Dtos
{
    public class CertificateReadDto
    {
        public int Id { get; set; }
        public string PublicKeyPath { get; set; }
        public string PrivateKeyPath { get; set; }
        public string Pass { get; set; }
    }
}