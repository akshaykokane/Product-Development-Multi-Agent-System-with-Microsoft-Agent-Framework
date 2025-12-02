// Copyright (c) Microsoft. All rights reserved.

using PRD_MultiAgentSystem.Agents;
using PRD_MultiAgentSystem.Tools;

namespace PRD_MultiAgentSystem.Configuration;

/// <summary>
/// Extension methods for registering agents in the application.
/// </summary>
public static class AgentServiceExtensions
{
    /// <summary>
    /// Adds all agents to the application builder.
    /// </summary>
    /// <param name="builder">The web application builder.</param>
    /// <returns>The web application builder for chaining.</returns>
    public static WebApplicationBuilder AddAgents(this WebApplicationBuilder builder)
    {
        // Resolve tools from DI
        var searchTool = builder.Services.BuildServiceProvider().GetRequiredService<SearchTool>();
        
        // Register all agents
        ProductResearcherAgentConfig.RegisterAgent(builder, searchTool);
        ProductStrategyAgentConfig.RegisterAgent(builder);
        TechnicalArchitectAgentConfig.RegisterAgent(builder);
        
        return builder;
    }
}
