using FiscalService.Models;
using Microsoft.EntityFrameworkCore;
namespace FiscalService.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app, bool isProduction)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>(), isProduction);    
            }

        }

        private static void SeedData(AppDbContext context, bool isProduction)
        {
            if(isProduction)
            {
                Console.WriteLine("--> Atemting to apply migration...");
                try
                {
                    context.Database.Migrate();
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"--> Could not run migrations: {ex.Message}");
                }
            }
            if(!context.Certificates.Any())
            {
                Console.WriteLine("--> Seeding Data...");

                context.Certificates.AddRange(
                    new Certificate(){PublicCertPath="PublicCertPath", PrivateCertPath="PrivateCertPath"}
                );

                context.Customers.AddRange(
                    new Customer(){Name="AirPort", CertificateId = 1, }
                );

                context.Machines.AddRange(
                    new Machine(){CustomerId=1, Type = 1}
                );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}