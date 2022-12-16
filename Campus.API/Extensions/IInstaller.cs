namespace Campus.API.Extensions;

public interface IInstaller
{
    void InstallServices(IServiceCollection services, IConfiguration configuration);
}
