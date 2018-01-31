using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace PerRequestProblemSite.EntityFrameworkCore
{
    public static class PerRequestProblemSiteDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<PerRequestProblemSiteDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<PerRequestProblemSiteDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
