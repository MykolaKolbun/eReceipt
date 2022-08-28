using System.ComponentModel.DataAnnotations;
using FiscalService.Models;
namespace FiscalService.Dtos
{
    public class FiscalReceiptCreateDto
    {
        public int DailyId { get; set; }
        public string? FiscalIdOnline { get; set; }
        public string? FiscalIdOffline { get; set; }
        public DateOnly OrderDate { get; set; }
        public TimeOnly OrderTime { get; set; }
        public string? Body { get; set; }
        public string? QRCode { get; set; }
        public string? MAC { get; set; }

        public int MachineId { get; set; }
        public Machine Machine { get; set; }
    }
}