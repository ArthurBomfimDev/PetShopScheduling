using PetShopScheduling.Domain.DTO.Registration;
using PetShopScheduling.Infrastructure.Entry.Registration;
using System.Reflection;

namespace PetShopScheduling.Api.Extensions;

public static class InjectionDependencyExtension
{
    public static IServiceCollection ConfigureInjectionDependency(this IServiceCollection services)
    {
        var listAssemblies = new List<Assembly>()
        {
            typeof(Customer).Assembly,
            typeof(CustomerDTO).Assembly,
        };

        var listDependency = (from i in listAssemblies
                              from j in i.GetTypes()
                              let name = j.Name
                              where (name.EndsWith("Repository") || name.EndsWith("Service") || name.Contains("UnitOfWork")) && (!j.IsInterface)
                              select new
                              {
                                  Class = j,
                                  Interface = j.GetInterface($"I{name}")
                              }).ToList();

        foreach (var dependency in listDependency)
        {
            if (dependency.Interface != null)
                services.AddScoped(dependency.Interface, dependency.Class);
        }

        return services;
    }
}