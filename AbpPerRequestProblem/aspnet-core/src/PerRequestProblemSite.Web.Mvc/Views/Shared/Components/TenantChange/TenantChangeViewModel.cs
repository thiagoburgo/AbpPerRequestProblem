using Abp.AutoMapper;
using PerRequestProblemSite.Sessions.Dto;

namespace PerRequestProblemSite.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
