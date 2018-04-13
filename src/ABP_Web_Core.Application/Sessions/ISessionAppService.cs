using System.Threading.Tasks;
using Abp.Application.Services;
using ABP_Web_Core.Sessions.Dto;

namespace ABP_Web_Core.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
