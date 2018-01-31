using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace PerRequestProblemSite
{
    public class PerRequestContextMiddlerware
    {
        private readonly RequestDelegate next;
        private readonly ILogger logger;
        private readonly IPerRequestContext perRequestContext;
        public PerRequestContextMiddlerware(RequestDelegate next,
            IServiceProvider serviceProvider,
            ILogger logger)
        {
            this.perRequestContext = serviceProvider.GetService(typeof(IPerRequestContext)) as IPerRequestContext;
            this.logger = logger;
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {   
            this.perRequestContext.Item1 = "Context 1";

            await next.Invoke(context);
        }
    }
    public static class PerRequestContextMiddlerwareExtensions
    {
        public static IApplicationBuilder UsePerRequestContext(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<PerRequestContextMiddlerware>();
        }
    }
}
