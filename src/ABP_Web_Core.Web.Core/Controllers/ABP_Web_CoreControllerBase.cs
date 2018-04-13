using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABP_Web_Core.Controllers
{
    public abstract class ABP_Web_CoreControllerBase: AbpController
    {
        protected ABP_Web_CoreControllerBase()
        {
            LocalizationSourceName = ABP_Web_CoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
