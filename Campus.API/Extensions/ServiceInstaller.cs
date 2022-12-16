using Campus.Application.Services;
using Campus.Core.Interfaces;

namespace Campus.API.Extensions;

public class ServiceInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ISubjectService, SubjectService>();
        services.AddScoped<ITeacherService, TeacherService>();
        services.AddScoped<IClassroomService, ClassroomService>();
    }
}
