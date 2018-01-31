using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using PerRequestProblemSite.Configuration.Dto;

namespace PerRequestProblemSite.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : PerRequestProblemSiteAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
