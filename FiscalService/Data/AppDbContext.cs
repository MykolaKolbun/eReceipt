using Microsoft.EntityFrameworkCore;
using FiscalService.Models;

namespace FiscalService
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<PurchaseDetails> PurchasesDetails { get; set; }
    }
}