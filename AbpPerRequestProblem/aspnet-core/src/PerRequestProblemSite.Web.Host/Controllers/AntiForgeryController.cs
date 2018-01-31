using Microsoft.AspNetCore.Antiforgery;
using PerRequestProblemSite.Controllers;

namespace PerRequestProblemSite.Web.Host.Controllers
{
    public class AntiForgeryController : PerRequestProblemSiteControllerBase
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
