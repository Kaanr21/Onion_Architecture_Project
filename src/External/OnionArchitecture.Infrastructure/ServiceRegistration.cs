using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace OnionArchitecture.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureRegistration(this IServiceCollection service)
        {
            var assembly = Assembly.GetExecutingAssembly();


            //service.AddInfrastructureRegistration() =>program cs kullanımı

        }
    }
}
