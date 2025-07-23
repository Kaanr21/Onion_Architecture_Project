using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace OnionArchitecture.Application
{
    public static class ServiceRegisteration
    {
        public static void AddApplicationRegistiration(this IServiceCollection services)
        {


            var assembly = Assembly.GetExecutingAssembly();

            services.AddMediatR(cfr =>
            {
                cfr.RegisterServicesFromAssembly(assembly);
            });
            //services.AddMediatR(assembly);




        }
    }
}
