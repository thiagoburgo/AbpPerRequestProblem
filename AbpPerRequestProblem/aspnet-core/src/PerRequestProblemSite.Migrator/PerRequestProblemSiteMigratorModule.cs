using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using PerRequestProblemSite.Configuration;
using PerRequestProblemSite.EntityFrameworkCore;
using PerRequestProblemSite.Migrator.DependencyInjection;

namespace PerRequestProblemSite.Migrator
{
    [DependsOn(typeof(PerRequestProblemSiteEntityFrameworkModule))]
    public class PerRequestProblemSiteMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PerRequestProblemSiteMigratorModule(PerRequestProblemSiteEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(PerRequestProblemSiteMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                PerRequestProblemSiteConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PerRequestProblemSiteMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
