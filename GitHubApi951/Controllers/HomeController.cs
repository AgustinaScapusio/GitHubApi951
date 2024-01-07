using GitHubApi951.GitHub;
using GitHubApi951.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace GitHubApi951.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGithubApi _githubApi;
        public HomeController(ILogger<HomeController> logger, IGithubApi githubApi)
        {
            _logger = logger;
            _githubApi = githubApi;
        }
        [HttpGet ("/")]
        public IActionResult Index()
        {
            return View(new IndexViewModel());
        }
        [HttpPost("/")]
        public async Task<IActionResult> Index(IndexViewModel model)
        {
            var repo= await _githubApi.GetRepositories(model.GithubUsername);
           
            model.Repositories = repo;
            return View(model);
        }

        //Oppgave 1
        //[HttpPost("/")]
        //public async Task<IActionResult> Index(string GithubUserName)
        //{
        //    var vm = new IndexViewModel()
        //    {
        //        GithubUsername = GithubUserName,
        //        Repositories = new Repository[]
        //        {
        //            new Repository
        //            {
        //                Id = 1,
        //                Name = "aasd",
        //            },
        //             new Repository
        //            {
        //                Id = 2,
        //                Name = "aaasdsad",
        //            }
        //        }
        //    };
        //    return View(vm);
        //}



    }
}


