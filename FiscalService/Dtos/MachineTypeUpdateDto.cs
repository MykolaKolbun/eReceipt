using System.ComponentModel.DataAnnotations;
using FiscalService.Models;
namespace FiscalService.Dtos
{
    public class MachineTypeUpdateDto
    {
        [Required]
        public string? Description { get; set; }
    }
}