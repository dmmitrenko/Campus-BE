using Campus.API.Models.Requests;
using Campus.API.Models.Validators;
using FluentValidation.AspNetCore;
using FluentValidation;

namespace Campus.API.Extensions;

public class FluentValidationInstaller : IInstaller
{
    public void InstallServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddFluentValidationAutoValidation(config =>
        {
            config.DisableDataAnnotationsValidation = true;
        });
        services.AddValidatorsFromAssemblyContaining<Program>();
    }
}
