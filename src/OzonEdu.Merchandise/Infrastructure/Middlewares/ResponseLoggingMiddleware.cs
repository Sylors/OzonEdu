using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace OzonEdu.Merchandise.Infrastructure.Middlewares
{
    public class ResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public ResponseLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await LogResponse(context);
            await _next(context);
        }

        private async Task LogResponse(HttpContext context)
        {
            try
            {
                var headers = context.Response.Headers;
                List<string> listHeaders = new List<string>();
                foreach (var header in headers)
                {
                    listHeaders.Add($"{header.Key}:{header.Value}");
                }

                _logger.LogInformation($"Http Response Information:{Environment.NewLine}" +
                                       $"Headers:{String.Join(";" + Environment.NewLine, listHeaders)} " +
                                       $"Path: {context.Request.Path} ");

            }
            catch (Exception e)
            {
                _logger.LogError(e, "Could not log response body");
            }
        }
    }
}