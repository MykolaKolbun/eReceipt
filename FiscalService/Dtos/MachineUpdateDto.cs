using System.ComponentModel.DataAnnotations;
using FiscalService.Models;
namespace FiscalService.Dtos
{
    public class MachineUpdateDto
    {
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }

        public int MachineTypeId { get; set; }
        public MachineType MachineType { get; set; }
        
        public int CashierId { get; set; }
        public Cashier Cashier { get; set; }
    }
}