namespace FiscalService.Models
{
    public class PurchaseDetails
    {
        public int Id { get; set; }
        public int Customer { get; set; }
        public int MachineId { get; set; }
        public double Amount { get; set; }
        public PaymentType PaymentType { get; set; }
        public string ReceiptNr { get; set; }
        public string TextData { get; set; }
    }
}