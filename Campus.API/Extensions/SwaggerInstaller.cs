using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;

namespace Campus.API.Extensions;

public class SwaggerInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddSwaggerGen(c =>
        {
            c.MapType<DateOnly>(() => new OpenApiSchema
            {
                Type = "string",
                Format = "date",
                Example = new OpenApiString(DateOnly.FromDateTime(DateTime.Now).ToString("dd-MM-yyyy"))
            });
        });
    }
}
