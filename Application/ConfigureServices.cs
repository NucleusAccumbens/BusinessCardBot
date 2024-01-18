namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureServices
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IKickTlgUserCommand, KickTlgUserCommand>();
        services.AddScoped<ICheckUserIsInDbQuery, CheckUserIsInDbQuery>();
        services.AddScoped<ICreateTlgUserCommand, CreateTlgUserCommand>();
        
        return services;
    }
}

