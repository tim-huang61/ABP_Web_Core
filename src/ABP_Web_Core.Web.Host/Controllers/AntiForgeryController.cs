using Microsoft.AspNetCore.Antiforgery;
using ABP_Web_Core.Controllers;

namespace ABP_Web_Core.Web.Host.Controllers
{
    public class AntiForgeryController : ABP_Web_CoreControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
