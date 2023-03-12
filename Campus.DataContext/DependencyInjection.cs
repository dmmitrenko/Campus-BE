using Campus.DataContext;
using Campus.DataContext.Repositories.Implementations;
using Campus.DataContext.Repositories.Interfaces;
using Campus.DataContext.Repositories.UoW;
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
                b => b.MigrationsAssembly("Campus.DataContext")));

        services.AddScoped<CampusDbContext>();

        services.AddScoped<IReadEducatorRepository, ReadEducatorRepository>();
        services.AddScoped<IReadCourseRepository, ReadCourseRepository>();
        services.AddScoped<IReadClassRepository, ReadClassRepository>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
