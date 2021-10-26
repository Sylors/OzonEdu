using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using OzonEdu.Merchandise.Infrastructure.Filters;
using OzonEdu.Merchandise.Infrastructure.StartupFilters;

namespace OzonEdu.Merchandise.Infrastructure.Extensions
{
    public static class HostBuilderExtensions
    {
        public static IHostBuilder AddInfrastructure(this IHostBuilder builder)
        {
            return builder;
        }
        
        public static IHostBuilder AddHttp(this IHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {     
                services.AddSingleton<IStartupFilter, SwaggerStartupFilter>();
                services.AddSingleton<IStartupFilter, TerminalStartupFilter>();
                
                services.AddControllers(options => options.Filters.Add<GlobalExceptionFilter>());
                
                services.AddSwaggerGen(options => {
                    options.SwaggerDoc("v1", new OpenApiInfo {Title = "OzonEdu.Merchandise", Version = "v1"});
                });
            });
            
            return builder;
        }
    }
}