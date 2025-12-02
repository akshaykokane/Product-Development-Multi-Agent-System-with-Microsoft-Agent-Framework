// Copyright (c) Microsoft. All rights reserved.

using PRD_MultiAgentSystem.Workflows;

namespace PRD_MultiAgentSystem.Configuration;

/// <summary>
/// Extension methods for registering workflows in the application.
/// </summary>
public static class WorkflowServiceExtensions
{
    /// <summary>
    /// Adds all workflows to the application builder.
    /// </summary>
    /// <param name="builder">The web application builder.</param>
    /// <returns>The web application builder for chaining.</returns>
    public static WebApplicationBuilder AddWorkflows(this WebApplicationBuilder builder)
    {
        PRDWorkflowConfiguration.RegisterWorkflow(builder);

        return builder;
    }
}
