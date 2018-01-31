using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PerRequestProblemSite.Roles.Dto;
using PerRequestProblemSite.Users.Dto;

namespace PerRequestProblemSite.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
