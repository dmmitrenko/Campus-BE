using Campus.Subject.Application.Services;
using Campus.Subject.Core.Interfaces;

namespace Campus_Subject.API.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<ISubjectService, SubjectService>();
        services.AddScoped<ITeacherService, TeacherService>();
        services.AddScoped<IClassroomService, ClassroomService>();
    }
}
