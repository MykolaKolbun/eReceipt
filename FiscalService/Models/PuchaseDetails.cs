namespace FiscalService.Models
{
    public class PuchaseDetails
    {
        public int Id { get; set; }
        public int Customer { get; set; }
        public int MachineId { get; set; }
        public double Amount { get; set; }
        public PaymentTypeEnum PaymentType { get; set; }
        public string ReceiptNr { get; set; }
        public string TextData { get; set; }
    }

    public enum PaymentTypeEnum : ushort
    {       
        Cash = 0,
        Card = 1
    }
}