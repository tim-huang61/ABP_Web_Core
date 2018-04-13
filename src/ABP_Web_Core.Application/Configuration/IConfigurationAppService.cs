using System.Threading.Tasks;
using ABP_Web_Core.Configuration.Dto;

namespace ABP_Web_Core.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
