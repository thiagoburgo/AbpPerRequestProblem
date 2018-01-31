using Abp.AspNetCore.Mvc.ViewComponents;

namespace PerRequestProblemSite.Web.Views
{
    public abstract class PerRequestProblemSiteViewComponent : AbpViewComponent
    {
        protected PerRequestProblemSiteViewComponent()
        {
            LocalizationSourceName = PerRequestProblemSiteConsts.LocalizationSourceName;
        }
    }
}
