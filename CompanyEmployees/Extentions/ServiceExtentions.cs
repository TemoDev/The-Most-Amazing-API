using System.Collections.Immutable;
using Contracts;
using LoggerService;

namespace CompanyEmployees.Extentions;

public static class ServiceExtentions
{
    public static void ConfigureCors(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
        });
    }

    public static void ConfigureLoggerService(this IServiceCollection services) =>
        services.AddSingleton<ILoggerManager, LoggerManager>();
}