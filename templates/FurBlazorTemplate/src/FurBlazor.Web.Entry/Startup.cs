using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FurBlazor.Web.Entry
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // ����Ǩ���� FurBlazor.Web.Core/WebConfigureStartup.cs
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // ����Ǩ���� FurBlazor.Web.Core/WebConfigureStartup.cs
        }
    }
}
