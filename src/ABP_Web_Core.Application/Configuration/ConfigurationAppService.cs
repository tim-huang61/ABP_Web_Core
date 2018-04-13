using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABP_Web_Core.Configuration.Dto;

namespace ABP_Web_Core.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABP_Web_CoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
