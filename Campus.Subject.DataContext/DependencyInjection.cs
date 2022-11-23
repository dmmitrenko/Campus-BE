using Campus.Subject.DataContext.Repositories.UoW;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Campus.Subject.DataContext;
public static class DependencyInjection
{
    public static void AddDataContext(this IServiceCollection services, IConfiguration configuration)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        services.AddDbContext<CampusDbContext>(options =>
            options.UseNpgsql(
                configuration.GetConnectionString("LocalConnection"),
                b => b.MigrationsAssembly("Campus.Subject.DataContext")));

        services.AddScoped<CampusDbContext>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
