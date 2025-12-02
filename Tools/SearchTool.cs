// Copyright (c) Microsoft. All rights reserved.

using System.ComponentModel;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;

namespace PRD_MultiAgentSystem.Tools;

/// <summary>
/// Tool for searching the web using Google Custom Search API.
/// </summary>
public class SearchTool
{
    private readonly string _apiKey;
    private readonly string _searchEngineId;
    private readonly HttpClient _httpClient;
    private const string GoogleSearchApiUrl = "https://www.googleapis.com/customsearch/v1";

    public SearchTool(IConfiguration configuration, HttpClient httpClient)
    {
        _apiKey = configuration["GoogleSearch:ApiKey"] ?? throw new InvalidOperationException("Google Search API Key is not configured");
        _searchEngineId = configuration["GoogleSearch:SearchEngineId"] ?? throw new InvalidOperationException("Google Search Engine ID is not configured");
        _httpClient = httpClient;
    }

    /// <summary>
    /// Search for information on the web using Google Custom Search API.
    /// </summary>
    /// <param name="query">The search query.</param>
    /// <param name="maxResults">Maximum number of results to return (1-10).</param>
    /// <returns>Search results formatted as a string.</returns>
    [Description("Search for information on the web. Provide a search query to find relevant information.")]
    public async Task<string> Search(
        [Description("The search query to look up on the web.")] string query,
        [Description("Maximum number of results to return (1-10). Default is 5.")] int maxResults = 5)
    {
        try
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(query))
            {
                return "Error: Search query cannot be empty.";
            }

            maxResults = Math.Clamp(maxResults, 1, 10);

            // Build the API URL
            var url = $"{GoogleSearchApiUrl}?key={_apiKey}&cx={_searchEngineId}&q={Uri.EscapeDataString(query)}&num={maxResults}";

            // Make the API request
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return $"Error: Google Search API returned status code {response.StatusCode}. Message: {await response.Content.ReadAsStringAsync()}";
            }

            var jsonResponse = await response.Content.ReadAsStringAsync();
            var searchResult = JsonSerializer.Deserialize<GoogleSearchResponse>(jsonResponse);

            if (searchResult?.Items == null || searchResult.Items.Length == 0)
            {
                return $"No results found for query: '{query}'";
            }

            // Format the results
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Search Results for: '{query}'\n");
            resultBuilder.AppendLine("=" + new string('=', 50));

            for (int i = 0; i < searchResult.Items.Length; i++)
            {
                var item = searchResult.Items[i];
                resultBuilder.AppendLine($"\n[{i + 1}] {item.Title}");
                resultBuilder.AppendLine($"URL: {item.Link}");
                resultBuilder.AppendLine($"Description: {item.Snippet}");
                resultBuilder.AppendLine(new string('-', 50));
            }

            return resultBuilder.ToString();
        }
        catch (HttpRequestException ex)
        {
            return $"Error: Network error while searching - {ex.Message}";
        }
        catch (JsonException ex)
        {
            return $"Error: Failed to parse search results - {ex.Message}";
        }
        catch (Exception ex)
        {
            return $"Error: Unexpected error during search - {ex.Message}";
        }
    }

    #region Google Search API Response Models

    private class GoogleSearchResponse
    {
        public SearchItem[]? Items { get; set; }
    }

    private class SearchItem
    {
        public string Title { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public string Snippet { get; set; } = string.Empty;
        public string HtmlTitle { get; set; } = string.Empty;
        public string HtmlSnippet { get; set; } = string.Empty;
    }

    #endregion
}
