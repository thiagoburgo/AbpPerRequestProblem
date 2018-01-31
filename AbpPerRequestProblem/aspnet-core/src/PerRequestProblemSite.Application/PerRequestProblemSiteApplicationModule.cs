using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PerRequestProblemSite.Authorization;

namespace PerRequestProblemSite
{
    [DependsOn(
        typeof(PerRequestProblemSiteCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class PerRequestProblemSiteApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<PerRequestProblemSiteAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(PerRequestProblemSiteApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
