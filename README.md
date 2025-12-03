# PRD Multi-Agent System - Product Requirement Document Generator

[![Microsoft Agent Framework](https://img.shields.io/badge/Microsoft-Agent_Framework-blue)](https://github.com/microsoft/agents)
[![.NET 9.0](https://img.shields.io/badge/.NET-9.0-purple)](https://dotnet.microsoft.com/)

**Transform feature ideas into comprehensive Product Requirement Documents in minutes, not weeks.**

This project demonstrates an AI-powered PRD generation system using the Microsoft Agent Framework. Multiple specialized AI agents work together in a coordinated workflow to analyze, strategize, and document product features—just like a real product team, but faster.

## 🎯 What This System Does

Given a simple feature idea like:
> "Add dark mode to our mobile app"

The system produces a complete PRD including:
- ✅ Market research and competitive analysis
- ✅ User personas and pain points
- ✅ Product vision and strategic goals
- ✅ Success metrics and KPIs
- ✅ Technical implementation approach
- ✅ Risk assessment and dependencies

**Time to complete: Minutes instead of weeks**

## 🚀 Quick Start

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Azure OpenAI access (or compatible endpoint)
- Google Custom Search API (optional, for web research)

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/akshaykokane/Product-Development-Multi-Agent-System-with-Microsoft-Agent-Framework.git
   cd Product-Development-Multi-Agent-System-with-Microsoft-Agent-Framework/PRD-MultiAgentSystem
   ```

2. **Configure Azure OpenAI**
   
   Edit `appsettings.json`:
   ```json
   {
     "AzureOpenAI": {
       "Endpoint": "https://your-endpoint.openai.azure.com",
       "DeploymentName": "gpt-4"
     }
   }
   ```

3. **Configure Google Search (Optional)**
   
   For enhanced market research capabilities:
   ```json
   {
     "GoogleSearch": {
       "ApiKey": "YOUR_API_KEY",
       "SearchEngineId": "YOUR_SEARCH_ENGINE_ID"
     }
   }
   ```
   
   See [GOOGLE-SEARCH-SETUP.md](GOOGLE-SEARCH-SETUP.md) for detailed setup instructions.

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Access the DevUI**
   
   Open your browser to: `https://localhost:50516/devui`

## 🏗️ Architecture

### Project Structure

```
PRD-MultiAgentSystem/
├── Program.cs                          # Application entry point
├── appsettings.json                    # Configuration settings
├── Agents/                             # Specialized AI agent definitions
│   ├── ProductResearcherAgentConfig.cs # Market & user research
│   ├── ProductStrategyAgentConfig.cs   # Strategic planning & goals
│   └── TechnicalArchitectAgentConfig.cs # Technical implementation
├── Tools/                              # Agent capabilities
│   └── SearchTool.cs                   # Google Custom Search integration
├── Workflows/                          # Agent orchestration
│   └── PRDWorkflowConfiguration.cs     # Sequential PRD workflow
└── Configuration/                      # Dependency injection setup
    ├── AIServiceExtensions.cs          # Azure OpenAI configuration
    ├── AgentServiceExtensions.cs       # Agent registration
    ├── ToolServiceExtensions.cs        # Tool registration
    └── WorkflowServiceExtensions.cs    # Workflow registration
```

### The PRD Workflow

```
Feature Idea
     ↓
🔍 Product Researcher Agent
     ↓ (analyzes problem, users, market)
     ↓
🎯 Product Strategy Agent
     ↓ (defines vision, goals, metrics)
     ↓
🏗️ Technical Architect Agent
     ↓ (evaluates implementation, risks)
     ↓
Complete PRD Document
```

**Sequential Orchestration**: Each agent receives and builds upon the previous agent's output, creating a cohesive, comprehensive document.

## 🤖 Meet the AI Team

### 🔍 Product Researcher Agent
**Role:** Market & User Research

**Capabilities:**
- Analyzes feature ideas and problem spaces
- Identifies target users and their pain points
- Researches competitive landscape (with web search)
- Discovers existing solutions and market gaps
- Proposes structured PRD outline

**Output:**
- Problem statement with context
- User personas with goals and pain points
- Competitive analysis
- Initial PRD structure

### 🎯 Product Strategy Agent
**Role:** Strategic Planning

**Capabilities:**
- Defines clear product vision and positioning
- Sets concrete goals and non-goals
- Establishes measurable success metrics
- Ensures strategic alignment

**Output:**
- Product vision statement
- Goals and non-goals
- Success metrics (KPIs)
- Enhanced PRD structure

### 🏗️ Technical Architect Agent
**Role:** Technical Feasibility & Planning

**Capabilities:**
- Evaluates technical feasibility
- Recommends architecture and tech stack
- Identifies implementation milestones
- Assesses technical risks and dependencies
- Provides effort estimates

**Output:**
- Technical feasibility assessment
- Recommended implementation approach
- Risk mitigation strategies
- Effort estimation

## 🛠️ Key Features

### Clean Architecture
- **Separation of Concerns**: Agents, Tools, Workflows in separate folders
- **Dependency Injection**: Proper DI pattern throughout
- **Configuration Management**: Centralized in `appsettings.json`
- **Extensibility**: Easy to add new agents, tools, or workflows

### Advanced Capabilities
- **Web Search Integration**: Google Custom Search API for real-time research
- **Sequential Workflow**: Coordinated agent execution with context passing
- **Interactive DevUI**: Web interface for testing and debugging
- **Streaming Responses**: Real-time output from agents

### Production Ready
- **.NET 9.0**: Latest framework with performance improvements
- **Async/Await**: Efficient asynchronous operations
- **Error Handling**: Comprehensive error handling and logging
- **Configurable**: Environment-specific settings support


## 🎓 Usage Example

### Via DevUI

1. Open `https://localhost:50516/devui`
2. Select the `prd-workflow-sequential` workflow
3. Enter your feature idea:
   ```
   Add real-time collaboration features to our document editor
   ```
4. Watch as each agent processes and contributes
5. Receive a complete PRD document

### Programmatic Usage

```csharp
// The workflow is registered and available through the agent framework
// Access via the DevUI or integrate with your application
```

## 🔧 Configuration Options

### Azure OpenAI Settings
```json
{
  "AzureOpenAI": {
    "Endpoint": "https://your-endpoint.openai.azure.com",
    "DeploymentName": "gpt-4"
  }
}
```

### Google Search Settings
```json
{
  "GoogleSearch": {
    "ApiKey": "YOUR_API_KEY",
    "SearchEngineId": "YOUR_SEARCH_ENGINE_ID"
  }
}
```

### Environment Variables
For production, use environment variables:
```bash
export AzureOpenAI__Endpoint="https://your-endpoint.openai.azure.com"
export AzureOpenAI__DeploymentName="gpt-4"
export GoogleSearch__ApiKey="YOUR_API_KEY"
export GoogleSearch__SearchEngineId="YOUR_SEARCH_ENGINE_ID"
```

## 🚀 Extending the System

### Add a New Agent

1. Create agent configuration in `/Agents`:
   ```csharp
   public static class MarketingAgentConfig
   {
       public const string AgentName = "marketing-specialist";
       public const string SystemPrompt = "You analyze marketing strategies...";
       
       public static void RegisterAgent(WebApplicationBuilder builder)
       {
           builder.AddAIAgent(AgentName, SystemPrompt);
       }
   }
   ```

2. Register in `AgentServiceExtensions.cs`:
   ```csharp
   MarketingAgentConfig.RegisterAgent(builder);
   ```

3. Add to workflow in `PRDWorkflowConfiguration.cs`:
   ```csharp
   var agents = new List<AIAgent>() 
   { 
       researchAgent, 
       strategyAgent, 
       technicalAgent,
       marketingAgent  // Add here
   };
   ```

### Add a New Tool

1. Create tool class in `/Tools`:
   ```csharp
   public class DataAnalysisTool
   {
       [Description("Analyze data and provide insights")]
       public async Task<string> Analyze(string data)
       {
           // Implementation
       }
   }
   ```

2. Register in `ToolServiceExtensions.cs`:
   ```csharp
   services.AddSingleton<DataAnalysisTool>();
   ```

3. Inject into agents that need it

## 📊 Performance & Costs

### Typical PRD Generation
- **Time**: 2-5 minutes (vs. 2-4 weeks traditional)
- **Azure OpenAI Calls**: 3 (one per agent)
- **Google Search Queries**: 1-5 (optional, for research)
- **Cost**: ~$0.10-0.50 per PRD (depending on complexity)

### Optimization Tips
- Use GPT-4-mini for faster, cheaper responses
- Cache search results to avoid duplicate queries
- Implement rate limiting for high-volume usage

## 🤝 Contributing

Contributions are welcome! Areas for improvement:
- Additional specialized agents (Legal, Marketing, UX, etc.)
- More workflow patterns (concurrent, group chat)
- Enhanced tools (databases, analytics, etc.)
- UI improvements for DevUI
- Additional LLM providers

## 📝 License

This project is licensed under the MIT License - see the LICENSE file for details.

## 🙏 Acknowledgments

- [Microsoft Agent Framework](https://github.com/microsoft/agents) - The foundation for agent orchestration
- [Azure OpenAI](https://azure.microsoft.com/en-us/products/ai-services/openai-service) - Powering the AI agents
- [Google Custom Search API](https://developers.google.com/custom-search) - Web research capabilities

## 📧 Contact

**Akshay Kokane**
- GitHub: [@akshaykokane](https://github.com/akshaykokane)
- Repository: [Product-Development-Multi-Agent-System-with-Microsoft-Agent-Framework](https://github.com/akshaykokane/Product-Development-Multi-Agent-System-with-Microsoft-Agent-Framework)

---

**Ready to transform your product development process?** Clone this repo and start generating comprehensive PRDs in minutes! 🚀
