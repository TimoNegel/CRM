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

            //context.Database.Migrate(); // optional: wendet Migrationen an

            if(!context.Status.Any())
            {
                context.Status.AddRange(
                    new Status { Name = "Start", Id = Guid.NewGuid() },
                                        new Status { Name = "Ende", Id = Guid.NewGuid() }

                );
                context.SaveChanges();
            }
        }
    }

}
