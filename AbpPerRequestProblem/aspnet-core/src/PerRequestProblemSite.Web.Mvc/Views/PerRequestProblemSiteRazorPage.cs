using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace PerRequestProblemSite.Web.Views
{
    public abstract class PerRequestProblemSiteRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PerRequestProblemSiteRazorPage()
        {
            LocalizationSourceName = PerRequestProblemSiteConsts.LocalizationSourceName;
        }
    }
}
