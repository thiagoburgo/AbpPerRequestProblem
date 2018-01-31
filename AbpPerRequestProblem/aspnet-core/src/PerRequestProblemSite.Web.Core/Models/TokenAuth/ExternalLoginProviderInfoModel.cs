using Abp.AutoMapper;
using PerRequestProblemSite.Authentication.External;

namespace PerRequestProblemSite.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
