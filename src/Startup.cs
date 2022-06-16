using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ProblemDetailsXMLSerialization
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddRouting()
                .AddControllers()
                .AddControllersAsServices()
                .AddXmlSerializerFormatters();
        }

        public void Configure(IApplicationBuilder app)
        {
            app
                .UseRouting()
                .UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}
