using Abp.AutoMapper;
using ABP_Web_Core.Authentication.External;

namespace ABP_Web_Core.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
