// Copyright (c) Microsoft. All rights reserved.

using Azure;
using Azure.AI.OpenAI;
using Azure.Identity;
using Microsoft.Agents.AI.DevUI;
using Microsoft.Agents.AI.Hosting.OpenAI;
using Microsoft.Extensions.AI;
using System.ClientModel;

namespace PRD_MultiAgentSystem.Configuration;

/// <summary>
/// Extension methods for configuring AI services in the application.
/// </summary>
public static class AIServiceExtensions
{
    /// <summary>
    /// Adds Azure OpenAI chat client to the application.
    /// </summary>
    /// <param name="builder">The web application builder.</param>
    /// <returns>The web application builder for chaining.</returns>
    public static WebApplicationBuilder AddAzureOpenAI(this WebApplicationBuilder builder)
    {
        var endpoint = builder.Configuration["AzureOpenAI:Endpoint"] 
            ?? "https://testmediumazureopenai.openai.azure.com";
        var deploymentName = builder.Configuration["AzureOpenAI:DeploymentName"] 
            ?? "gpt-5-mini";

        var chatClient = new AzureOpenAIClient(
                new Uri(endpoint),
                credential: new DefaultAzureCredential())
            .GetChatClient(deploymentName)
            .AsIChatClient();

        builder.Services.AddChatClient(chatClient);

        return builder;
    }

    /// <summary>
    /// Adds OpenAI API services for DevUI compatibility.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The service collection for chaining.</returns>
    public static IServiceCollection AddOpenAIServices(this IServiceCollection services)
    {
        services.AddOpenAIResponses();
        services.AddOpenAIConversations();

        return services;
    }
}
