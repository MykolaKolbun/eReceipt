using System.ComponentModel.DataAnnotations;
using FiscalService.Model;
namespace FiscalService.Dtos
{
    public class MachineTypecCreateDto
    {
        [Required]
        public string? Description { get; set; }
    }
}