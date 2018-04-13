using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ABP_Web_Core.MultiTenancy;

namespace ABP_Web_Core.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
