using Abp.MultiTenancy;
using PerRequestProblemSite.Authorization.Users;

namespace PerRequestProblemSite.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
