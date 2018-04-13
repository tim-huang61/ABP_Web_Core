using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP_Web_Core.Authorization;

namespace ABP_Web_Core
{
    [DependsOn(
        typeof(ABP_Web_CoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABP_Web_CoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABP_Web_CoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABP_Web_CoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
