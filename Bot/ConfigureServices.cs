﻿using Bot.Common.Services;
using Bot.Common;
using Microsoft.Extensions.DependencyInjection;
using Bot.Common.Abstractions;
using Bot.Commands;

namespace Microsoft.Extensions.DependencyInjection;

public static class ConfigureService
{
    public static IServiceCollection AddTelegramBotServices(this IServiceCollection services)
    {
        services.AddMemoryCache();
        services.AddSingleton<TelegramBot>();
        services.AddScoped<IMemoryCachService, MemoryCachService>();
        services.AddScoped<ICommandAnalyzer, CommandAnalyzer>();
        services.AddScoped<BaseTextCommand, StartTextCommand>();
        services.AddScoped<BaseCallbackCommand, BotsCallbackCommand>();

        return services;
    }
}
