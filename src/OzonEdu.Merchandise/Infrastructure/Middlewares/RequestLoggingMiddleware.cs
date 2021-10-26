using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace OzonEdu.Merchandise.Infrastructure.Middlewares
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await LogRequest(context);
            await _next(context);
        }

        private async Task LogRequest(HttpContext context)
        {
            try
            {
                if (context.Request.ContentLength > 0)
                {
                    //context.Request.EnableBuffering();
                    // var buffer = new byte[context.Request.ContentLength.Value];
                    // await context.Request.Body.ReadAsync(buffer, 0, buffer.Length);
                    // var bodyAsText = Encoding.UTF8.GetString(buffer);
                    // _logger.LogInformation("Request logged");
                    // _logger.LogInformation(bodyAsText);
                    //context.Request.Body.Position = 0;
                    var headers = context.Request.Headers;
                    List<string> listHeaders = new List<string>();
                    foreach (var header in headers)
                    {
                        listHeaders.Add($"{header.Key}:{header.Value}");
                    }

                    _logger.LogInformation($"Http Request Information:{Environment.NewLine}" +
                                           $"Headers:{String.Join(";" + Environment.NewLine, listHeaders)} " +
                                           $"Path: {context.Request.Path} ");

                  
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Could not log request body");
            }
        }
    }
}