namespace EFDataAccess.Model
{
    public class Cashier
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TIN { get; set; }
        public List<Certificate> Certificates { get; set; } = new List<Certificate>();
        public List<Machine> Machines { get; set; } = new List<Machine>();
    }
}