using System.Threading.Tasks;
using PerRequestProblemSite.Configuration.Dto;

namespace PerRequestProblemSite.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
