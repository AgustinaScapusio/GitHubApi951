using System.Text.Json.Serialization;

namespace GitHubApi951.Models
{
    public class IndexViewModel
    {
        public string GithubUsername { get; set; }=string.Empty;
        public Repository[] Repositories { get; set; } = Array.Empty<Repository>();
    }
   

}
