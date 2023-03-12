using Campus.Application.Services;
using Campus.Core.Interfaces;
using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Campus.API.Filters;
using Campus.Domain.Converters;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Json.Serialization;
using Campus.API.Middleware;

namespace Campus.API.Extensions;

public static class ServiceExtensions
{
    public static void ConfigureApplicationService(this IServiceCollection services)
    {
        services.AddScoped<ICourseService, CourseService>();
        services.AddScoped<IEducatorService, EducatorService>();
        services.AddScoped<IClassService, ClassService>();
    }

    public static void ConfigureValidation(this IServiceCollection services)
    {
        services.AddFluentValidationAutoValidation(config =>
        {
            config.DisableDataAnnotationsValidation = true;
        });
        services.AddValidatorsFromAssemblyContaining<Program>();
    }

    public static void ConfigureSwagger(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSwaggerGen(c =>
        {
            c.MapType<DateOnly>(() => new OpenApiSchema
            {
                Type = "string",
                Format = "date",
                Example = new OpenApiString(DateOnly.FromDateTime(DateTime.Now).ToString("dd-MM-yyyy"))
            });
        });
    }

    public static void AddCampusMvc(this IServiceCollection services)
    {
        services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.Converters.Add(new DateOnlyJsonConverter());
                options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            })
            .AddMvcOptions(options =>
            {
                options.Filters.Add<ValidationActionFilter>();
            })
            .ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
    }

    public static void UseExceptionMiddleware(this IApplicationBuilder app)
    {
        app.UseMiddleware<ExceptionMiddleware>();
    }
}
