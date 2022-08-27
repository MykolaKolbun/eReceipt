using System.ComponentModel.DataAnnotations;
using FiscalService.Model;
namespace FiscalService.Dtos
{
    public class CustomerCreateDto
    {
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string TIN { get; set; }
        public string EMailAddress { get; set; }
        public string PhoneNumber { get; set; }
    }
}