// Copyright (c) Microsoft. All rights reserved.

using Microsoft.Agents.AI;
using Microsoft.Agents.AI.Hosting;
using Microsoft.Agents.AI.Workflows;
using PRD_MultiAgentSystem.Agents;

namespace PRD_MultiAgentSystem.Workflows;

/// <summary>
/// Configuration for the PRD workflow.
/// </summary>
public static class PRDWorkflowConfiguration
{
    public const string WorkflowNameSequential = "prd-workflow-sequential";


    /// <summary>
    /// Registers the PRD workflow with the application.
    /// Uses sequential orchestration: Research → Strategy → Technical Architecture
    /// </summary>
    /// <param name="builder">The web application builder.</param>
    public static void RegisterWorkflow(WebApplicationBuilder builder)
    {
        var productResearcherAgent = builder.Services.BuildServiceProvider()
            .GetRequiredKeyedService<AIAgent>(ProductResearcherAgentConfig.AgentName);

        var productStrategyAgent = builder.Services.BuildServiceProvider()
            .GetRequiredKeyedService<AIAgent>(ProductStrategyAgentConfig.AgentName);

        var technicalArchitectAgent = builder.Services.BuildServiceProvider()
            .GetRequiredKeyedService<AIAgent>(TechnicalArchitectAgentConfig.AgentName);
        
        // Sequential workflow: Research → Strategy → Technical
        builder.AddWorkflow(WorkflowNameSequential, (sp, key) =>
        {
            var agents = new List<AIAgent>() 
            { 
                productResearcherAgent, 
                productStrategyAgent, 
                technicalArchitectAgent 
            };
            return AgentWorkflowBuilder.BuildSequential(workflowName: key, agents: agents);
        }).AddAsAIAgent();
    }
}