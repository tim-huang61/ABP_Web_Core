using System.Threading.Tasks;
using Abp.Application.Services;
using ABP_Web_Core.Authorization.Accounts.Dto;

namespace ABP_Web_Core.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
