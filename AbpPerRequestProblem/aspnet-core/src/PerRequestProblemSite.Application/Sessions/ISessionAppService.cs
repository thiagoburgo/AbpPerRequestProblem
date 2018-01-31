using System.Threading.Tasks;
using Abp.Application.Services;
using PerRequestProblemSite.Sessions.Dto;

namespace PerRequestProblemSite.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
