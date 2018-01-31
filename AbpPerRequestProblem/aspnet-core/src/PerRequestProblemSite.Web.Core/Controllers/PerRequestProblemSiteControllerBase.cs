using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PerRequestProblemSite.Controllers
{
    public abstract class PerRequestProblemSiteControllerBase: AbpController
    {
        protected PerRequestProblemSiteControllerBase()
        {
            LocalizationSourceName = PerRequestProblemSiteConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
