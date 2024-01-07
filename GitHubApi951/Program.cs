using GitHubApi951.GitHub;

namespace GitHubApi951
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddHttpClient<IGithubApi, GithubApi>(c =>
            {
                c.DefaultRequestHeaders.Add("User-Agent", "Agus-Pagus");
                c.DefaultRequestHeaders.Add("Accept", "application/vnd.github+json");
                c.BaseAddress = new Uri("https://api.github.com/");
             
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}