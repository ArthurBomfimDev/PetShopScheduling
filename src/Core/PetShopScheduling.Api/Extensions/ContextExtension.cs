using Microsoft.EntityFrameworkCore;
using PetShopScheduling.Infrastructure.Context;
namespace PetShopScheduling.Api.Extensions;

public static class ContextExtension
{
    public static IServiceCollection ConfigureContext(this IServiceCollection services, IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("DefaultConnection") ?? "";

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(connectionString,
                b => b.MigrationsAssembly("PetShopScheduling.Infrastructure")));

        return services;
    }
}