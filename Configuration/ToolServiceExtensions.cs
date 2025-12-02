// Copyright (c) Microsoft. All rights reserved.

using PRD_MultiAgentSystem.Tools;

namespace PRD_MultiAgentSystem.Configuration;

/// <summary>
/// Extension methods for registering tools in the dependency injection container.
/// </summary>
public static class ToolServiceExtensions
{
    /// <summary>
    /// Adds all tool services to the dependency injection container.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The service collection for chaining.</returns>
    public static IServiceCollection AddTools(this IServiceCollection services)
    {
        // Register HttpClient for SearchTool
        services.AddHttpClient<SearchTool>();
        
        // Register SearchTool as singleton
        services.AddSingleton<SearchTool>();
        
        return services;
    }
}
