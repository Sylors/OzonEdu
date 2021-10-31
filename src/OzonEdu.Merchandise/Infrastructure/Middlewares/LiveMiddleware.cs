using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace OzonEdu.Merchandise.Infrastructure.Middlewares
{
    public class LiveMiddleware
    {
        public LiveMiddleware(RequestDelegate next)   
        {
 
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.StatusCode = StatusCodes.Status200OK;
            await context.Response.WriteAsync("");
        }
    }
}