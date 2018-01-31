using System;
using System.Diagnostics;
using Abp.Dependency;
using Abp.Events.Bus.Entities;
using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.DependencyInjection;
using PerRequestProblemSite.Authorization.Roles;
using PerRequestProblemSite.Authorization.Users;
using PerRequestProblemSite.MultiTenancy;

namespace PerRequestProblemSite.EntityFrameworkCore
{
    public class PerRequestProblemSiteDbContext : AbpZeroDbContext<Tenant, Role, User, PerRequestProblemSiteDbContext>
    {
        /* Define a DbSet for each entity of the application */

        private readonly IPerRequestContext perRequestContext;

        public PerRequestProblemSiteDbContext(DbContextOptions<PerRequestProblemSiteDbContext> options)
            : base(options)
        {
            IServiceProvider serviceProvider = IocManager.Instance.Resolve<IServiceProvider>();
            this.perRequestContext = serviceProvider.GetService<IPerRequestContext>();
        }

        protected override void ApplyAbpConceptsForAddedEntity(EntityEntry entry, long? userId, EntityChangeReport changeReport)
        {
            Debug.WriteLine(this.perRequestContext?.Item1);
            base.ApplyAbpConceptsForAddedEntity(entry, userId, changeReport);
        }
    }
}
