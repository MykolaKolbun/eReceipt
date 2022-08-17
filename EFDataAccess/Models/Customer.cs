namespace EFDataAccess.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string TIN { get; set; }
        public string EMailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public List<Cashier> Cashiers { get; set; } = new List<Cashier>();
    }
}