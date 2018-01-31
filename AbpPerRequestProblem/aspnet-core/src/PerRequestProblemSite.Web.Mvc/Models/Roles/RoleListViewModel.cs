using System.Collections.Generic;
using PerRequestProblemSite.Roles.Dto;

namespace PerRequestProblemSite.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
