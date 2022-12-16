using Campus.API.ExceptionResolvers.Base;
using Campus.API.ExceptionResolvers;
using Campus.Domain.Exceptions;

namespace Campus.API.Extensions;

public class ExceptionResolversInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IExceptionResolver, AppExceptionResolver>();
        services.AddScoped<IExceptionResolver<TeacherNotFoundException>, TeacherNotFoundExceptionResolver>();
        services.AddScoped<IExceptionResolver<SubjectNotFoundException>, SubjectNotFoundExceptionResolver>();
    }
}
