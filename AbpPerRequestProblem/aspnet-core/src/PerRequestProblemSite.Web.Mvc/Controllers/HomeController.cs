using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using PerRequestProblemSite.Controllers;

namespace PerRequestProblemSite.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PerRequestProblemSiteControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
