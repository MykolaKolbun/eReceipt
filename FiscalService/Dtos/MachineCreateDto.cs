using System.ComponentModel.DataAnnotations;
using FiscalService.Model;
namespace FiscalService.Dtos
{
    public class MachineCreateDto
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public int MachineTypeId { get; set; }
        public MachineType MachineType { get; set; }
        
        public int CashierId { get; set; }
        public Cashier Cashier { get; set; }
    }
}