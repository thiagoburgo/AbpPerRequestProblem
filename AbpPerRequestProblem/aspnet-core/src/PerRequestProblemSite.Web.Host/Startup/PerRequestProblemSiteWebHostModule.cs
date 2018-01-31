using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PerRequestProblemSite.Configuration;

namespace PerRequestProblemSite.Web.Host.Startup
{
    [DependsOn(
       typeof(PerRequestProblemSiteWebCoreModule))]
    public class PerRequestProblemSiteWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PerRequestProblemSiteWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PerRequestProblemSiteWebHostModule).GetAssembly());
        }
    }
}
