using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using PerRequestProblemSite.Configuration;
using PerRequestProblemSite.Web;

namespace PerRequestProblemSite.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class PerRequestProblemSiteDbContextFactory : IDesignTimeDbContextFactory<PerRequestProblemSiteDbContext>
    {
        public PerRequestProblemSiteDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PerRequestProblemSiteDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            PerRequestProblemSiteDbContextConfigurer.Configure(builder, configuration.GetConnectionString(PerRequestProblemSiteConsts.ConnectionStringName));

            return new PerRequestProblemSiteDbContext(builder.Options);
        }
    }
}
