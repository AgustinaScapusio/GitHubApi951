using GitHubApi951.Models;
using System.Reflection;
using System.Text.Json;

namespace GitHubApi951.GitHub
{
    public class GithubApi : IGithubApi
    {
        private readonly HttpClient _client;
        public GithubApi(HttpClient client)
        {
            _client = client;
        }

        public async Task<Repository[]> GetRepositories(string username)
        {
            var response = await _client.GetAsync($"https://api.github.com/users/{username}/repos");
            var content = await response.Content.ReadAsStringAsync();
            var repositories = JsonSerializer.Deserialize<Repository[]>(content);
            return repositories;

        }
        
    }
}
