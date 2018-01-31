using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PerRequestProblemSite.Configuration;

namespace PerRequestProblemSite.Web.Startup
{
    [DependsOn(typeof(PerRequestProblemSiteWebCoreModule))]
    public class PerRequestProblemSiteWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public PerRequestProblemSiteWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<PerRequestProblemSiteNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PerRequestProblemSiteWebMvcModule).GetAssembly());
        }
    }
}
