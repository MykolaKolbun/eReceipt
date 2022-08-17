namespace EFDataAccess.Model
{
    public class Machine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MyProperty { get; set; }
        public MachineType MachineType { get; set; }
    }
}