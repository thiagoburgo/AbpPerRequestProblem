using System.Collections.Generic;

namespace PerRequestProblemSite.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
