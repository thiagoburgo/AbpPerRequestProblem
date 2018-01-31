using System.Collections.Generic;
using PerRequestProblemSite.Roles.Dto;
using PerRequestProblemSite.Users.Dto;

namespace PerRequestProblemSite.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
