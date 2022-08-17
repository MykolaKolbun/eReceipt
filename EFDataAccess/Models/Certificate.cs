namespace EFDataAccess.Model
{
    public class Certificate
    {
        public int Id { get; set; }
        public string PublicKeyPath { get; set; }
        public string PrivateKeyPath { get; set; }
        public string Pass { get; set; }
    }
}