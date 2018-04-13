using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP_Web_Core.Configuration;
using ABP_Web_Core.EntityFrameworkCore;
using ABP_Web_Core.Migrator.DependencyInjection;

namespace ABP_Web_Core.Migrator
{
    [DependsOn(typeof(ABP_Web_CoreEntityFrameworkModule))]
    public class ABP_Web_CoreMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ABP_Web_CoreMigratorModule(ABP_Web_CoreEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ABP_Web_CoreMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ABP_Web_CoreConsts.ConnectionStringName
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
            IocManager.RegisterAssemblyByConvention(typeof(ABP_Web_CoreMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
