// Copyright (c) Microsoft. All rights reserved.

// This sample demonstrates basic usage of the DevUI in an ASP.NET Core application with AI agents.

using Microsoft.Agents.AI.DevUI;
using PRD_MultiAgentSystem.Configuration;

namespace PRD_MultiAgentSystem;

/// <summary>
/// Sample demonstrating basic usage of the DevUI in an ASP.NET Core application.
/// </summary>
/// <remarks>
/// This sample shows how to:
/// 1. Set up Azure OpenAI as the chat client
/// 2. Register tools via dependency injection
/// 3. Register agents with their respective tools
/// 4. Register workflows that orchestrate multiple agents
/// 5. Map the DevUI endpoint which automatically configures the middleware
/// 6. Map the dynamic OpenAI Responses API for Python DevUI compatibility
/// 7. Access the DevUI in a web browser
///
/// The DevUI provides an interactive web interface for testing and debugging AI agents.
/// DevUI assets are served from embedded resources within the assembly.
/// Simply call MapDevUI() to set up everything needed.
///
/// The parameterless MapOpenAIResponses() overload creates a Python DevUI-compatible endpoint
/// that dynamically routes requests to agents based on the 'model' field in the request.
/// </remarks>
internal static class Program
{
    /// <summary>
    /// Entry point that starts an ASP.NET Core web server with the DevUI.
    /// </summary>
    /// <param name="args">Command line arguments.</param>
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configure Azure OpenAI chat client
        builder.AddAzureOpenAI();

        // Register tools in DI container
        builder.Services.AddTools();

        // Register OpenAI API services
        builder.Services.AddOpenAIServices();

        // Register all agents with their tools
        builder.AddAgents();

        // Register all workflows
        builder.AddWorkflows();

        var app = builder.Build();

        // Map OpenAI-compatible endpoints
        app.MapOpenAIResponses();
        app.MapOpenAIConversations();

        // Enable DevUI in development environment
        if (builder.Environment.IsDevelopment())
        {
            app.MapDevUI();
        }

        Console.WriteLine("DevUI is available at: https://localhost:50516/devui");
        Console.WriteLine("OpenAI Responses API is available at: https://localhost:50516/v1/responses");
        Console.WriteLine("Press Ctrl+C to stop the server.");

        app.Run();
    }
}