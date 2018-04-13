using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABP_Web_Core.Configuration;

namespace ABP_Web_Core.Web.Host.Startup
{
    [DependsOn(
       typeof(ABP_Web_CoreWebCoreModule))]
    public class ABP_Web_CoreWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABP_Web_CoreWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABP_Web_CoreWebHostModule).GetAssembly());
        }
    }
}
