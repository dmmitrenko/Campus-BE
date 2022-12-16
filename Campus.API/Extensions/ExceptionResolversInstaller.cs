using Campus.API.ExceptionResolvers.Base;
using Campus.API.ExceptionResolvers;

namespace Campus.API.Extensions;

public class ExceptionResolversInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IExceptionResolver, AppExceptionResolver>();
    }
}
