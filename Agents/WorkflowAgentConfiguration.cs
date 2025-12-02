// Copyright (c) Microsoft. All rights reserved.

using Microsoft.Agents.AI.Hosting;

namespace PRD_MultiAgentSystem.Agents;

/// <summary>
/// Configuration for workflow-specific agents.
/// </summary>
public static class WorkflowAgentConfiguration
{
    public const string WorkflowAssistantName = "workflow-assistant";
    public const string WorkflowAssistantPrompt = "You are a helpful assistant in a workflow.";

    public const string WorkflowReviewerName = "workflow-reviewer";
    public const string WorkflowReviewerPrompt = "You are a reviewer. Review and critique the previous response.";

    /// <summary>
    /// Registers workflow-specific agents with the application.
    /// </summary>
    /// <param name="builder">The web application builder.</param>
    public static void RegisterAgents(WebApplicationBuilder builder)
    {
        builder.AddAIAgent(WorkflowAssistantName, WorkflowAssistantPrompt);
        builder.AddAIAgent(WorkflowReviewerName, WorkflowReviewerPrompt);
    }
}
