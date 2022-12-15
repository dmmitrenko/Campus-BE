using Campus.Application.Services;
using Campus.Core.Interfaces;

namespace Campus.API.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<ISubjectService, SubjectService>();
        services.AddScoped<ITeacherService, TeacherService>();
        services.AddScoped<IClassroomService, ClassroomService>();
    }
}
