using Backend.Models;
using CRM.Data;
using Microsoft.Extensions.DependencyInjection;

namespace Backend.Services
{
    public static class DbInitializer
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<CrmDbContext>();

            if(!context.Status.Any())
            {
                context.Status.AddRange(
                    new Status { Name = "Lead", Id = Guid.NewGuid(), Position = "1" },
                    new Status { Name = "Kontakt", Id = Guid.NewGuid(), Position = "2" },
                    new Status { Name = "Verhandlung", Id = Guid.NewGuid(), Position = "3" },
                    new Status { Name = "Abschluss", Id = Guid.NewGuid(), Position = "4" }

                );
                context.SaveChanges();
            }
        }
    }

}
