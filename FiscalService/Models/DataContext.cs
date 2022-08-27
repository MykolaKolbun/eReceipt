using FiscalService.Model;
using Microsoft.EntityFrameworkCore;

namespace FiscalService.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Cashier> Cashiers { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<FiscalReceipt> FiscalReceipts { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<MachineType> MachineTypes { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        
    }
}