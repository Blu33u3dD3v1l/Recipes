using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace RecipesShare.WebExtensions
{
    public static class WebApplicationBuilderServices
    {
        public static void AddApplicationServices(this IServiceCollection services, System.Type ServiceType)
        {
            Assembly? serviceAssembly = Assembly.GetAssembly(ServiceType);
            if (serviceAssembly == null)
            {
                throw new InvalidOperationException("Invalid service type provided!");
            }

            System.Type[] serviceTypes = serviceAssembly.GetTypes()
                .Where(t => t.Name.EndsWith("Service") && !t.IsInterface)
                .ToArray();

            foreach (System.Type implementationType in serviceTypes)
            {
                System.Type? interfaceType = implementationType
                    .GetInterface($"I{implementationType.Name}");

                if (interfaceType == null)
                {
                    throw new InvalidOperationException($"No Interface is provided for the service with name: {implementationType.Name}");
                }

                services.AddScoped(interfaceType, implementationType);

            }

        }
    } 
}
