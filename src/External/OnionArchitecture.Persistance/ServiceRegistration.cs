using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitecture.Persistance.Context;
using System.Reflection;

namespace OnionArchitecture.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceRegistration(this IServiceCollection service, IConfiguration configuration)
        {
            var assembly = Assembly.GetExecutingAssembly();

            service.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("sqlServer")));

            //service.AddDbContext<>;
            //service.AddScoped<>.....
        }
    }
}
