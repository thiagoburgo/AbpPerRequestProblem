using Abp.Authorization;
using PerRequestProblemSite.Authorization.Roles;
using PerRequestProblemSite.Authorization.Users;

namespace PerRequestProblemSite.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
