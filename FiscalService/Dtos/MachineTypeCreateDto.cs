using System.ComponentModel.DataAnnotations;
using FiscalService.Models;
namespace FiscalService.Dtos
{
    public class MachineTypeCreateDto
    {
        [Required]
        public string? Description { get; set; }
    }
}