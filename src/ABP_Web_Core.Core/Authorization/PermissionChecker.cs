using Abp.Authorization;
using ABP_Web_Core.Authorization.Roles;
using ABP_Web_Core.Authorization.Users;

namespace ABP_Web_Core.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
