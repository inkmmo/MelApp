using Melapp.Services;
using Melapp.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using WebWindows.Blazor;

namespace Melapp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IApplicationLanguageService, ApplicationLanguageService>();
        }

        public void Configure(DesktopApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
