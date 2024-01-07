using GitHubApi951.Models;

namespace GitHubApi951.GitHub
{
    public interface IGithubApi
    {
        Task<Repository[]> GetRepositories(string username);
    }
}
